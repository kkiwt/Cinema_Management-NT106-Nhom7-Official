using Microsoft.VisualBasic.Devices;
using System.Drawing;
using TrangChu;

namespace CinemaManagement
{
    public partial class TrangChuChinh : Form
    {
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
            /*if (currentMovieStartIndex > 0)
            {
                currentMovieStartIndex = Math.Max(0, currentMovieStartIndex - 3); // Cuộn ngược lại 3 phim
                DisplayMovies();
                UpdateNavigationButtons();
            }*/
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
    }
}

