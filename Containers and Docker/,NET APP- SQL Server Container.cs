using SqlDockerDemo.Models.SqlDockerDemo.Data.SqlDockerDemo.Controllers;
using SqlDockerDemo.Models.SqlDockerDemo.Data;

контейнера с .NET приложение(C#) и Entity Framework Core за връзка с SQL Server.

1️⃣ Стартирай SQL Server контейнера
Ако още не си го стартирал, изпълни:

docker run -e ACCEPT_EULA=Y -e MSSQL_SA_PASSWORD=yourStrongPassword12# -p 1433:1433 -v sqldata:/var/opt/mssql -d mcr.microsoft.com/mssql/server:2022-latest
✅ Това ще стартира Microsoft SQL Server в Docker.
✅ Данните ще се съхраняват в sqldata volume.


2️⃣ Създай ново .NET приложение
Създаваме нов ASP.NET Core Web API проект:
dotnet new webapi - n SqlDockerDemo
cd SqlDockerDemo

Добавяме Entity Framework Core пакетите за SQL Server:
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools


3️⃣ Конфигурирай appsettings.json
Отваряме appsettings.json и добавяме ConnectionStrings:
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost,1433;Database=MyDatabase;User Id=sa;Password=yourStrongPassword12#;TrustServerCertificate=True"
  }
}
🔹 Server = localhost,1433 → Свързваме се към контейнера.
🔹 Database=MyDatabase → Името на базата данни, която ще създадем.
🔹 User Id=sa; Password = yourStrongPassword12# → Използваме sa за първоначалната връзка.
🔹 TrustServerCertificate = True → Игнорира SSL сертификати (само за локална среда).


4️⃣ Създай DbContext и модел
Създаваме нова папка Models и в нея файл Product.cs:

namespace SqlDockerDemo.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}

Създаваме ApplicationDbContext.cs:

using Microsoft.EntityFrameworkCore;
using SqlDockerDemo.Models;

namespace SqlDockerDemo.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; }
}


5️⃣ Регистрирай DbContext в Program.cs
Отваряме Program.cs и добавяме конфигурация:


using Microsoft.EntityFrameworkCore;
using SqlDockerDemo.Data;

var builder = WebApplication.CreateBuilder(args);

// Добавяме DbContext с SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();


6️⃣ Създай REST API контролер
Създаваме нов файл ProductsController.cs в папка Controllers:

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SqlDockerDemo.Data;
using SqlDockerDemo.Models;

namespace SqlDockerDemo.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public ProductsController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
    {
        return await _context.Products.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<Product>> CreateProduct(Product product)
    {
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetProducts), new { id = product.Id }, product);
    }
}
✅ GET /api/products → Връща всички продукти
✅ POST /api/products → Добавя нов продукт



7️⃣ Създай и мигрирай базата данни
Генерираме миграция и прилагаме я върху SQL Server:

dotnet ef migrations add InitialCreate
dotnet ef database update
🔹 Това ще създаде таблицата Products в контейнера!


8️⃣ Тествай API-то
Списък с продукти:

curl -X GET http://localhost:5000/api/products
Добавяне на продукт:

curl -X POST http://localhost:5000/api/products -H "Content-Type: application/json" -d '{"name": "Laptop", "price": 1200.99}'
🎯 Заключение
✅ Свързахме.NET Core API с SQL Server в Docker
✅ Използвахме Entity Framework Core за управление на базата
✅ Използвахме REST API за добавяне/четене на данни