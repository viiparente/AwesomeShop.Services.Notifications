# AwesomeShop.Services.Notifications - Formação Microsserviços com ASP.NET Core

A arquitetura do AwesomeShop, sistema de e-commerce baseado na arquitetura de microsserviços, contém 6 microsserviços:
- [Customers](https://github.com/viiparente/AwesomeShop.Services.Customers)
- [Products](https://github.com/viiparente/AwesomeShop.Services.Products) 
- [Orders](https://github.com/viiparente/AwesomeShop.Services.Orders)
- [Payments](https://github.com/viiparente/AwesomeShop.Services.Payments)
- [Notifications](https://github.com/viiparente/AwesomeShop.Services.Notifications)
- [API Gateway](https://github.com/viiparente/AwesomeShop.Services.ApiGateway)

## Tecnologias, práticas e arquitetura utilizadas
- ASP.NET Core com .NET 5
- Arquitetura de Microsserviços
- Princípios do Domain-Driven Design
- MongoDB
- Clean Architecture
- CQRS
- RabbitMQ e arquitetura orientada a eventos
- API Gateway com Ocelot 
- Service Discovery com Consul
- Observabilidade com Prometheus e Grafana

## Funcionalidades do Notifications
- Envio de e-mail baseado nos eventos de domínio:
    - PaymentAccepted
    - OrderCreated
    - CustomerCreated
