
using EF05DbContextOptionsBuilder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using (ApplicationContext db = new ApplicationContext("Data Source=helloapp.db"))
{
    var users = db.Users.ToList();
    Console.WriteLine("Пользователи:");
    foreach (User user in users)
    {
        Console.WriteLine($"{user.Id}.{user.Name} - {user.Age}");
    }
}


//********************************


var optionsBuilder2 = new DbContextOptionsBuilder<ApplicationContext2>();

var options = optionsBuilder2.UseSqlite("Data Source=helloapp.db").Options;

using (ApplicationContext2 db = new ApplicationContext2(options))
{
    var users = db.Users.ToList();
    foreach (User user in users)
        Console.WriteLine($"{user.Id}.{user.Name} - {user.Age}");
}

//********************************

var builder = new ConfigurationBuilder();
// установка пути к текущему каталогу
builder.SetBasePath(Directory.GetCurrentDirectory());
// получаем конфигурацию из файла appsettings.json
builder.AddJsonFile("appsettings.json");
// создаем конфигурацию
var config = builder.Build();
// получаем строку подключения
string connectionString = config.GetConnectionString("DefaultConnection");

var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext2>();

var options2 = optionsBuilder.UseSqlite(connectionString).Options;

using (ApplicationContext2 db = new ApplicationContext2(options2))
{
    var users = db.Users.ToList();
    foreach (User user in users)
        Console.WriteLine($"{user.Id}.{user.Name} - {user.Age}");
}