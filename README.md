# e-commerce
xây dựng một ứng dụng e-commerce microservices theo kiến trúc mẫu từ Microsoft. Kiến trúc này gồm nhiều client khác nhau giao tiếp với backend thông qua API Gateway. Mỗi microservice có phong cách kiến trúc và cơ sở dữ liệu riêng, sử dụng cả giao tiếp đồng bộ (synchronous) và bất đồng bộ (asynchronous) qua event bus.

Chúng ta sẽ từng bước xây dựng một ứng dụng thương mại điện tử (e-commerce) với các microservices như:

    Catalog Service (dịch vụ danh mục sản phẩm)
    Basket Service (dịch vụ giỏ hàng)
    Discount Service (dịch vụ giảm giá)
    Ordering Service (dịch vụ đặt hàng)
    YARP API Gateway
    Shopping Web Client (ứng dụng web dành cho khách hàng)

Mỗi microservice sẽ có cơ sở dữ liệu riêng (NoSQL, SQL) và giao tiếp thông qua gRPC, RabbitMQ.
Giới thiệu về từng microservice

    Catalog Service
        Dùng ASP.NET Core Minimal API và C# 12.
        Áp dụng Vertical Slice Architecture với feature folders.
        Sử dụng CQRS (Command Query Responsibility Segregation) với Mediator.
        Lưu trữ dữ liệu bằng Martin Library (document database trên PostgreSQL).
        Áp dụng các kỹ thuật logging, xử lý ngoại lệ, health checks.
        Chạy trên Docker.

    Basket Service
        Dùng ASP.NET 8 Web API, tuân theo chuẩn REST.
        Dùng Redis làm cache.
        Áp dụng Proxy Pattern, Decorator Pattern, Cache-Aside Pattern.
        Gọi Discount Service qua gRPC để tính giá cuối cùng.
        Gửi sự kiện basket checkout bằng RabbitMQ.

    Discount Service
        Là một ASP.NET gRPC Service hiệu năng cao.
        Dùng SQLite và Entity Framework Core.
        Áp dụng gRPC để giao tiếp với Basket Service.
        Chạy trên Docker với SQLite.

    Ordering Service
        Sử dụng Domain-Driven Design (DDD), Clean Architecture và SOLID Principles.
        Dùng Entity Framework Core Code-First với SQL Server.
        Lắng nghe sự kiện từ RabbitMQ để xử lý đặt hàng.

    API Gateway (YARP)
        Dùng YARP (Yet Another Reverse Proxy) để tạo API Gateway.
        Áp dụng gateway routing pattern và rate limiting.
        Chạy trên Docker.

    Shopping Web Client
        Dùng ASP.NET Core Razor Pages với Bootstrap 4.
        Gọi API qua YARP API Gateway bằng Refit.
        Sử dụng các tính năng như model binding, validations, view components.
        Chạy trên Docker.

Các công nghệ và kỹ thuật quan trọng trong khóa học

    Triển khai microservices với .NET 8.
    Domain-Driven Design (DDD), Vertical Slice Architecture, Clean Architecture.
    Các mẫu thiết kế (Design Patterns): SOLID, Dependency Injection, Mediator, Proxy, Decorator, API Gateway.
    Cơ sở dữ liệu: SQL Server, PostgreSQL, Redis, SQLite, Martin (DocumentDB).
    Giao tiếp giữa microservices:
        Đồng bộ: HTTP, gRPC.
        Bất đồng bộ: RabbitMQ, MassTransit (publish-subscribe pattern).
    Triển khai API Gateway với YARP Reverse Proxy.
    Triển khai trên Docker và Docker Compose.
