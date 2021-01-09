Tài khoản để đăng nhập quản lý nhà trạm viên thông

Username : vuvietvan 
Password :12345678
--- và ----
Username : Admin 
Password :12345678

---------------------------------------------------
Các  bước chạy souce code và csdl như sau 
 
Bước 1 : Vào SQL SERVER chọn và mở chạy file "QLNTVT.mdf"
Bước 2 : Sau khi chạy file cơ sở dữ liệu thành công, vào Visual Studio kết nối lại cơ sở dữ liệu với SQL SERVER 
và copy lại đường link (  Data Source=" Tên server của bạn ";Initial Catalog=QLNTVT ;Integrated Security=True )
thay thế cho đường link cũ tại file ConnectionSQL 
Bước 3 : Khởi chạy chương trình và nhập Username và Password ở trên để login

