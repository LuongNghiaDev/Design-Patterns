# Design-Patterns
Singleton Design Pattern

- Đảm bảo một lớp chỉ có một phiên bản và cung cấp một điểm truy cập toàn cầu cho nó.

- Gói gọn "khởi tạo đúng lúc" hoặc "khởi tạo trong lần sử dụng đầu tiên"

=> Lưu ý: Về vấn đề đa luồng , chạy trên các thread khác nhau cùng 1 lần vẫn sẽ gây ra vấn đề tạo ra nhiều các instance khác nhau (tức chạy trên 2 thread Singleton sẽ tạo ra 2 instance khác nhau) đó là hạn chế của singleton
=> Xem code để chống lỗi multi threading
