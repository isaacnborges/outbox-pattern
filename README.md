# outbox-pattern

Projeto onde é aplicado o padrão [Transactional Outbox](https://microservices.io/patterns/data/transactional-outbox.html) utilizando a lib [MassTransit](https://masstransit.io/) como abstração da publicação e consumo das mensagens no [RabbitMq](https://rabbitmq-website.pages.dev/).

### Project SDK
---
- [.Net 8](https://dotnet.microsoft.com/download/dotnet/8.0)

### Executar migrations
----
```
dotnet ef --project ./Customers.Api/Customers.Api.csproj database update
```

### Executar via Docker
Ao executar o comando abaixo, irá baixar as dependências do projeto
- PostgreSql
- RabbitMq
```
docker-compose up -d
```

#### Referências
Código baseado no vídeo do [Nick Chapsas](https://www.youtube.com/@nickchapsas): [The Pattern You MUST Learn in .NET](https://youtu.be/032SfEBFIJs?si=9dNtEG2MyvWNCx_i)
