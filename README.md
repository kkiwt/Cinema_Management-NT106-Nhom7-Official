Đồ án Lập trình mạng căn bản NT106.Q14 - Nhóm 7 - Cinema_Management
---
Đề tài: ỨNG DỤNG QUẢN LÝ RẠP CHIẾU PHIM - SOLUNAR CINEMA 

## 🧾 Thông tin môn học
| Mục | Thông tin |
| :--- | :--- |
| **Môn học** | Lập trình mạng căn bản |
| **Lớp** | NT106.Q14 |
| **Giảng viên** | ThS. Lê Minh Khánh Hội |
| **Nhóm thực hiện** | Nhóm 7 |
| **Nhóm trưởng** | Nguyễn Tuấn Kiệt |

## 👨‍💻 Thành viên nhóm 7
| STT | Họ và tên | MSSV |
| :--- | :--- | :--- |
| 1 | Nguyễn Tuấn Kiệt (**Nhóm trưởng**) | 24520907 |
| 2 | Hoàng Nhật Huy | 24520662 |
| 3 | Nguyễn Nhật Thanh | 24521633 |
| 4 | Nguyễn Thái Hùng | 24520613 |
| 5 | Nguyễn Hữu Chiến | 24520218 |

## 📌 Giới thiệu đề tài
Solunar Cinema, một ứng dụng quản lý rạp chiếu phim cho phép người dùng có thể đăng ký, đăng nhập vào bên trong ứng dụng để xem các bộ phim mà rạp Solunar (một rạp phim giả định) đang chiếu và có thể đặt vé, bắp nước và thanh toán online trên ứng dụng thay vì phải ra trực tiếp rạp để thanh toán tại quầy. Ngoài ra, có các tài khoản là tài khoản của nhân viên và các tài khoản ấy có thể thêm/xóa phim, ưu đãi hay xem thống kê về doanh thu của các bộ phim đang chiếu,…

## 🖥Các tính năng chính 
| STT | Tính năng | Ghi chú |
| :--- | :--- | :--- |
| 01 | Đăng ký | |
| 02 | Đăng nhập | |
| 03 | Đăng xuất | |
| 04 | Xem thông tin tài khoản | |
| 05 | Xem ưu đãi | |
| 06 | Đặt vé | |
| 07 | Mua bắp nước | |
| 08 | Thanh toán | |
| 09 | Xem thông tin vé đã đặt | |
| 10 | Xem / viết đánh giá | |
| 11 | Xóa đánh giá |  |
| 12 | Xem thống kê về doanh thu phim | dành cho nhân viên |
| 13 | Thêm / xóa phim | dành cho nhân viên |
| 14 | Thêm ưu đãi | dành cho nhân viên |
| 15 | Xem tất cả vé đã đặt của người dùng | dành cho nhân viên |

## ⚙️ Hướng dẫn cài đặt và sử dụng;

## 1. Yêu Cầu Hệ Thống

* **IDE:** Cài đặt **Visual Studio 2022** trở lên.
* **Runtime:** Cài đặt **.NET 8 SDK / Runtime**.

## 2. Hướng Dẫn Cài Đặt và Khởi Chạy

### 2.1. Thiết Lập Dự Án
* Mở Visual Studio và chọn **`Clone a Repository`**.
* Gán link bên dưới và tạo thư mục để lưu dự án.

    ```
    https://github.com/kkiwt/Cinema_Management-NT106-Nhom7-Official
    ```

### 2.2. Khởi Chạy Ứng Dụng

* **Bước 1: Chạy Server**
    * Chọn project **`ServerAndService`**.
    * Chạy chương trình.
* **Bước 2: Chạy Client**
    * Chọn project **`CinemaManagement`**.
    * Chạy chương trình.
    * Có thể dùng nhiều instance để mô phỏng có nhiều khách vào đặt vé.
---

---

## 3. Thử nghiệm các chức năng:

* Đăng ký / Đăng nhập.
* Nếu quên mật khẩu thì có thể đặt lại.
* Xem các phim hiện có trên hệ thống rạp.
* Xem thông tin phim, trailer.
* Xem và viết đánh giá phim.
* Xem ưu đãi hiện có của rạp.
* Xem thông tin tài khoản.
* Đặt vé (chọn ngày chiếu, suất chiếu, ghế, mua bắp nước (nếu có)).
* Thanh toán.
* Đăng xuất.
* **Đối với tài khoản là nhân viên có thêm các chức năng:**
    * Thực hiện việc thêm và xóa phim, đánh giá.
    * Xem được doanh thu phim.
    * Thực hiện việc thêm ưu đãi.
    * Xem tất cả các vé mà người dùng đã đặt.
