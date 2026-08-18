# Fundamentos de Web APIs em .NET

Projeto base desenvolvido para a disciplina de **Desenvolvimento de Software com C#**, abordando criação de Web APIs, servidor Kestrel, contratos OpenAPI e documentação com Swagger UI.

---

## 🚀 Tecnologias

* **.NET 10** com C#
* **ASP.NET** (Arquitetura baseada em Controllers)
* **Kestrel** (Servidor HTTP interno)
* **Microsoft.AspNetCore.OpenApi** 
* **Swagger UI** (Interface interativa)

---

## 🛠️ Execução

1. Clone o repositório: `git clone [https://github.com/seu-usuario/FIAP.API.git](https://github.com/seu-usuario/FIAP.API.git)`
2. Restaure os pacotes: `dotnet restore`
3. Execute o projeto: `dotnet run --project FIAP.API`

---

## 🌐 Endpoints e Documentação

| Recurso | URL | Descrição |
| --- | --- | --- |
| **Swagger UI** | `https://localhost:7212/swagger` | Interface gráfica para testes de rotas |
| **OpenAPI JSON** | `https://localhost:7212/openapi/v1.json` | Contrato técnico da API em formato JSON |
| **Endpoint Demo** | `https://localhost:7212/WeatherForecast` | Rota de exemplo da aplicação |

---

## 📚 Tópicos Abordados

* Inicialização do Host Kestrel e ciclo de vida da aplicação
* Pipeline de Middlewares (HTTPS, Autorização e Controllers)
* Contratos de Serviço e especificação OpenAPI
* Integração e consumo via Swagger UI
