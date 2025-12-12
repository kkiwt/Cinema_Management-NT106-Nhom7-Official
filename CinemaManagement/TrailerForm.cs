using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagement
{
    public partial class TrailerForm : Form
    {
        private readonly string embedUrl;
        private HttpListener httpListener;
        private int listenerPort;

        public TrailerForm(string embedUrl)
        {
            InitializeComponent();
            this.embedUrl = embedUrl;
            this.FormClosing += TrailerForm_FormClosing;
        }

        private async void TrailerForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (webView == null)
                {
                    MessageBox.Show("WebView2 control không khả dụng. Kiểm tra cài đặt Microsoft.Web.WebView2.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                await webView.EnsureCoreWebView2Async(null);
                webView.CoreWebView2.Settings.IsScriptEnabled = true;
                webView.CoreWebView2.Settings.AreDefaultScriptDialogsEnabled = true;
                webView.CoreWebView2.Settings.IsStatusBarEnabled = false;

                var id = ExtractYouTubeVideoId(embedUrl);
                if (!string.IsNullOrEmpty(id))
                {
                    listenerPort = GetFreePort();
                    string origin = $"http://localhost:{listenerPort}";
                    string html = CreatePlayerHtml(id, origin);

                    StartLocalHttpServer(html, listenerPort);
                    webView.CoreWebView2.Navigate($"http://localhost:{listenerPort}/");
                }
                else
                {
                    webView.CoreWebView2.Navigate(embedUrl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể khởi tạo WebView2: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private string CreatePlayerHtml(string videoId, string origin)
        {
            var template = @"<!doctype html>
                <html><head><meta charset=""utf-8""><meta name=""viewport"" content=""width=device-width,initial-scale=1"">
                <style>html,body,#player{{height:100%;width:100%;margin:0;background:#000;}}</style>
                </head><body><div id=""player""></div>
                <script src=""https://www.youtube.com/iframe_api""></script>
                <script>
                var player;
                function onYouTubeIframeAPIReady(){{ player = new YT.Player('player', {{
                height:'100%', width:'100%', videoId:'{0}',
                playerVars:{{ autoplay:1, controls:0, rel:0, modestbranding:1, playsinline:1, iv_load_policy:3, enablejsapi:1, origin:'{1}' }},
                events: {{
                  onReady:function(e){{ try{{ e.target.playVideo(); }}catch(ex){{}} setTimeout(setBestQuality,800); }},
                  onStateChange:function(e){{ if (e.data === YT.PlayerState.PLAYING) setBestQuality(); }}
                }}
                }}); }}
                function setBestQuality(){{ try{{ if(!player || !player.getAvailableQualityLevels) return; var levels = player.getAvailableQualityLevels(); if(levels && levels.length) player.setPlaybackQuality(levels[0]); }}catch(e){{}} }}
                </script></body></html>";
            return string.Format(template, videoId, origin);
        }

        private void TrailerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (httpListener != null && httpListener.IsListening)
                {
                    httpListener.Stop();
                    httpListener.Close();
                    httpListener = null;
                }
            }
            catch { }
        }

        private void StartLocalHttpServer(string html, int port)
        {
            try
            {
                httpListener = new HttpListener();
                string prefix = $"http://localhost:{port}/";
                httpListener.Prefixes.Add(prefix);
                httpListener.Start();

                Task.Run(async () =>
                {
                    while (httpListener != null && httpListener.IsListening)
                    {
                        try
                        {
                            var ctx = await httpListener.GetContextAsync().ConfigureAwait(false);
                            var resp = ctx.Response;
                            var buffer = Encoding.UTF8.GetBytes(html);
                            resp.ContentType = "text/html; charset=utf-8";
                            resp.ContentLength64 = buffer.Length;
                            await resp.OutputStream.WriteAsync(buffer, 0, buffer.Length).ConfigureAwait(false);
                            resp.OutputStream.Close();
                        }
                        catch (HttpListenerException) { break; }
                        catch { /* ignore per-request errors */ }
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể khởi động local server: {ex.Message}\nSẽ mở trang YouTube mặc định.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                var id = ExtractYouTubeVideoId(embedUrl);
                if (!string.IsNullOrEmpty(id))
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo($"https://www.youtube.com/watch?v={id}") { UseShellExecute = true });
                    this.Close();
                }
            }
        }
        private static int GetFreePort()
        {
            var l = new TcpListener(IPAddress.Loopback, 0);
            l.Start();
            int port = ((IPEndPoint)l.LocalEndpoint).Port;
            l.Stop();
            return port;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static string GetEmbedUrlFromYouTubeUrl(string url)
        {
            if (string.IsNullOrWhiteSpace(url)) return url;
            string id = ExtractYouTubeVideoId(url);
            if (!string.IsNullOrEmpty(id)) return $"https://www.youtube.com/embed/{id}";
            return url;
        }

        private static string ExtractYouTubeVideoId(string url)
        {
            var m = Regex.Match(url, @"(?<=v=)[\w-]{11}|(?<=be/)[\w-]{11}|(?<=embed/)[\w-]{11}");
            return m.Value;
        }

        private void NutQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
