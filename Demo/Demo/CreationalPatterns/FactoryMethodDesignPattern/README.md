# Design-Patterns
Factory Design Pattern

- Xác định một giao diện để tạo một đối tượng, nhưng hãy để các lớp con quyết định lớp nào sẽ khởi tạo. Factory Method cho phép một lớp trì hoãn việc khởi tạo thành các lớp con.

- Xác định hàm tạo "ảo".

- Toán tử mới được coi là có hại.

=> Khi muốn tạo 1 object của 1 type nào đó nhưng nó phải dựa vào 1 số business logic nào đấy để có thể khởi tạo được object đó
VD: Có một nghiệp vụ cho khách hàng tạo Card tín dụng, chỉ có thể tạo 1 trong 3 loại như loại Basic, loại Gold và loại Platinum. Vấn đề là không biết khách hàng sẽ tạo thằng nào ở runtime => Hãy để cho các class ( Factory) triển khai interface ( IFactory) quyết định việc tạo object của class nào (Basic, Gold, Platinum)