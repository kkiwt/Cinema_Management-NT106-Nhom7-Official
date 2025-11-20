

﻿using CinemaManagement;
using Microsoft.VisualBasic.Devices;
using Supabase; 
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

namespace TrangChu
{
    public partial class TrangChuChinh : Form
    {
        private List<Phim> DanhSachPhim= new List<Phim>();
        private int ViTriBatDauCuaMotPhim = 0;

        private int KichThuocTrang = 3; // Số phim hiển thị mỗi trang
        private int TongSoTrang = 1; // Tổng số trang
        private int TrangHienTai = 1; // Trang hiện tại

        private const string SupabaseUrl = "https://qyhamranljmfsrxfxfls.supabase.co" ;
        private const string SupabaseKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InF5aGFtcmFubGptZnNyeGZ4ZmxzIiwicm9sZSI6ImFub24iLCJpYXQiOjE3NjE0NjgzMzQsImV4cCI6MjA3NzA0NDMzNH0.Qtd4vxXBsDlx7ZDWFV92WTmHqXUpJrbyOqW8D5yIBJs";


>>>>>>> Stashed changes
        public TrangChuChinh()
        {
            InitializeComponent();
        }

        // Trong TrangChuChinh.cs

        // Khai báo thêm biến để theo dõi vị trí phim
        private int currentMovieStartIndex = 0;
        // Note: Tôi sẽ loại bỏ movieBindingSource và thay thế bằng cách quản lý chỉ mục đơn giản hơn
        // vì giao diện của bạn hiển thị 3 phim cùng lúc, không phải 1.
        /*
                private void TrangChuChinh_Load(object sender, EventArgs e)
                {
                    // Cần có phương thức Load để khởi tạo dữ liệu
                    LoadDataFromDatabase();
                    DisplayMovies();
                    UpdateNavigationButtons();
                }

                // ... (Trong class Movie đã có sẵn)

                private List<Movie> movieList = new List<Movie>();

                private void LoadDataFromDatabase()
                {
                    // *** THAY THẾ PHẦN NÀY BẰNG CODE KẾT NỐI VÀ TRUY VẤN CSDL CỦA BẠN ***

                    // Ví dụ dữ liệu tĩnh - Cần nhiều hơn 3 phim để test Next/Prev
                    movieList.Add(new Movie
                    {
                        Id = 1,
                        Title = "TEEYOD 3", // Phim 1
                        Details = "Mô tả chi tiết 1...",
                        PosterPath = @"C:\YourProjectPath\Posters\poster1.jpg" // Cần đường dẫn hợp lệ
                    });
                    movieList.Add(new Movie
                    {
                        Id = 2,
                        Title = "MAI", // Phim 2
                        Details = "Mô tả chi tiết 2...",
                        PosterPath = @"C:\YourProjectPath\Posters\poster2.jpg"
                    });
                    movieList.Add(new Movie
                    {
                        Id = 3,
                        Title = "EXHUMA", // Phim 3
                        Details = "Mô tả chi tiết 3...",
                        PosterPath = @"C:\YourProjectPath\Posters\poster3.jpg"
                    });
                    movieList.Add(new Movie
                    {
                        Id = 4,
                        Title = "Phim Bốn", // Phim 4
                        Details = "Mô tả chi tiết 4...",
                        PosterPath = @"C:\YourProjectPath\Posters\poster4.jpg"
                    });
                    movieList.Add(new Movie
                    {
                        Id = 5,
                        Title = "Phim Năm", // Phim 5
                        Details = "Mô tả chi tiết 5...",
                        PosterPath = @"C:\YourProjectPath\Posters\poster5.jpg"
                    });
                    // ... thêm các phim khác để có tổng số phim lớn hơn 3
                }

                // Trong TrangChuChinh.cs, thêm vào bên dưới LoadDataFromDatabase()

                private void DisplayMovies()
                {
                    // Lấy 3 phim cần hiển thị
                    Movie movie1 = (currentMovieStartIndex < movieList.Count) ? movieList[currentMovieStartIndex] : null;
                    Movie movie2 = (currentMovieStartIndex + 1 < movieList.Count) ? movieList[currentMovieStartIndex + 1] : null;
                    Movie movie3 = (currentMovieStartIndex + 2 < movieList.Count) ? movieList[currentMovieStartIndex + 2] : null;

                    // Hiển thị Phim 1
                    SetMovieDisplay(PosterPhim1, TenPhim1, movie1);

                    // Hiển thị Phim 2
                    SetMovieDisplay(PosterPhim2, TenPhim2, movie2);

                    // Hiển thị Phim 3
                    SetMovieDisplay(PosterPhim3, TenPhim3, movie3);
                }

                private void SetMovieDisplay(PictureBox posterBox, Label titleLabel, Movie movie)
                {
                    if (movie != null)
                    {
                        titleLabel.Text = movie.Title;
                        posterBox.Visible = true;
                        titleLabel.Visible = true;
                        // Tải ảnh poster. Cần đảm bảo đường dẫn trong LoadDataFromDatabase là hợp lệ
                        try
                        {
                            if (!string.IsNullOrEmpty(movie.PosterPath) && File.Exists(movie.PosterPath))
                            {
                                posterBox.Image = Image.FromFile(movie.PosterPath);
                            }
                            else
                            {
                                // Sử dụng ảnh mặc định nếu không tìm thấy
                                posterBox.Image = Properties.Resources.Default_Poster; // Cần tạo resource này hoặc dùng Image.FromFile từ 1 đường dẫn mặc định
                            }
                        }
                        catch (Exception ex)
                        {
                            // Xử lý lỗi tải ảnh
                            posterBox.Image = null;
                            // Có thể log lỗi: Console.WriteLine("Lỗi tải ảnh: " + ex.Message);
                        }
                    }
                    else
                    {
                        // Ẩn control nếu không còn phim để hiển thị
                        titleLabel.Text = "";
                        posterBox.Image = null;
                        posterBox.Visible = false;
                        titleLabel.Visible = false;
                        // Có thể ẩn thêm các nút Chi Tiết, Đặt Vé tương ứng ở đây nếu cần
                    }
                }

                private void UpdateNavigationButtons()
                {
                    // Nút Prev chỉ được bật khi không phải đang ở 3 phim đầu tiên
                    Prev.Enabled = currentMovieStartIndex > 0;

                    // Nút Next chỉ được bật khi còn ít nhất 1 phim nữa để hiển thị (ngoài 3 phim hiện tại)
                    Next.Enabled = currentMovieStartIndex + 3 < movieList.Count;
                }
        */



        private async void TrangChuChinh_Load(object sender, EventArgs e)
        {

            await LoadPhimTuSupabase();
        }

        private async Task LoadPhimTuSupabase()
        {
            try
            {
                // 2. Khởi tạo Supabase Client
                var Options = new SupabaseOptions { AutoConnectRealtime = true };
                var Client = new Supabase.Client(SupabaseUrl, SupabaseKey, Options);
                await Client.InitializeAsync();

                // 3. Truy vấn dữ liệu từ bảng 'Phim'
                // Phương thức From<Phim>() sẽ ánh xạ dữ liệu trả về vào list Phim
                var Response = await Client.From<Phim>().Get();

                // 4. Lấy danh sách phim đã được ánh xạ
                DanhSachPhim = Response.Models;
                DanhSachPhim = Response.Models;

                if (DanhSachPhim != null && DanhSachPhim.Count > 0)
                {
                    TongSoTrang = (int)Math.Ceiling((double)DanhSachPhim.Count / KichThuocTrang);
                    TrangHienTai = 1; // Bắt đầu ở trang 1

                    HienThiPhim();
                    CapNhatNutDiChuyen();
                    CapNhatTrang(); // Gọi hàm cập nhật Label
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu phim nào.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối hoặc truy vấn Supabase: " + ex.Message);
            }
        }

        private void CapNhatNutDiChuyen()
        {
            Prev.Enabled = ViTriBatDauCuaMotPhim > 0;
            Next.Enabled = ViTriBatDauCuaMotPhim + 3 < DanhSachPhim.Count;
        }
        // Hàm mới: Cập nhật nội dung Label hiển thị số trang
        private void CapNhatTrang()
        {
            // Căn cứ vào CurrentMovieStartIndex và pageSize để tính currentPage
            if (DanhSachPhim.Count > 0)
            {
                TrangHienTai = (ViTriBatDauCuaMotPhim / KichThuocTrang) + 1;
                Trang.Text = $"Trang {TrangHienTai} / {TongSoTrang}";
            }
            else
            {
                Trang.Text = "Không có phim nào";
            }
        }
        private void HienThiPhim()
        {
            BangPhim.Controls.Clear();
            for (int i = ViTriBatDauCuaMotPhim; i < ViTriBatDauCuaMotPhim + 3 && i < DanhSachPhim.Count; i++)
            {
                var MucPhim = new MovieItemControl();
                var DuLieuPhim = DanhSachPhim[i];
                MucPhim.PhimDuocChon += MucPhimDuocChon;
                MucPhim.ThongTinPhim(DuLieuPhim);
                BangPhim.Controls.Add(MucPhim);
            }
        }

        private void MucPhimDuocChon (object sender, PhimDuocChonEventArgs e)
        {
            Phim PhimDaDuocChon = e.PhimDuocChon;
            MessageBox.Show($"Trang chủ nhận được yêu cầu Chi tiết/Đặt vé cho phim: {PhimDaDuocChon.TenPhim}");
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (ViTriBatDauCuaMotPhim + 3 < DanhSachPhim.Count)
            {
                ViTriBatDauCuaMotPhim += 3;
                HienThiPhim();
                CapNhatNutDiChuyen();
                CapNhatTrang(); // Gọi hàm cập nhật Label
            }
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            if (ViTriBatDauCuaMotPhim > 0)
            {
                ViTriBatDauCuaMotPhim = Math.Max(0, ViTriBatDauCuaMotPhim - 3);
                HienThiPhim();
                CapNhatNutDiChuyen();
                CapNhatTrang(); // Gọi hàm cập nhật Label
            }
        }


        private void UuDai_Click(object sender, EventArgs e)
        {

        }

        private void PhimHot_Click(object sender, EventArgs e)
        {

        }

        private void TaiKhoan_Click(object sender, EventArgs e)
        {
            MenuTaiKhoan.Show(TaiKhoan, new Point(0, TaiKhoan.Height)); //Hien thi menu tai khoan de chon 3 tien ich.
        }


        private void Poster_Click(object sender, EventArgs e)
        {

        }

        private void Phim_Load(object sender, EventArgs e)
        {

        }

        private void DuongDan_Click(object sender, EventArgs e)
        {

        }

        private void Next_Click(object sender, EventArgs e)
        {
            /*if (currentMovieStartIndex + 3 < movieList.Count)
            {
                currentMovieStartIndex += 3; // Cuộn 3 phim một lần
                DisplayMovies();
                UpdateNavigationButtons();
            }*/
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            if (currentMovieStartIndex > 0)
            {
                currentMovieStartIndex = Math.Max(0, currentMovieStartIndex - 3); // Cuộn ngược lại 3 phim
                DisplayMovies();
                UpdateNavigationButtons();
            }
        }

        private void ChiTietPhim1_Click(object sender, EventArgs e)
        {
            ChiTietPhim ChiTietP1 = new ChiTietPhim();
            ChiTietP1.Show();
        }

        private void TenPhim2_Click(object sender, EventArgs e)
        {

        }

        private void TenPhim3_Click(object sender, EventArgs e)
        {

        }

        private void ThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            ThongTInTaiKhoan thongtintaikhoan = new ThongTInTaiKhoan();
            thongtintaikhoan.ShowDialog();
            this.Close();
        }

        private void VeDaDat_Click(object sender, EventArgs e)
        {

        }

        private void MenuTaiKhoan_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

    }
}

