﻿// добавление данных
using EF01;

using (ApplicationContext db = new ApplicationContext())
{
    // создаем два объекта User
    User user1 = new User { Name = "Tom", Age = 33 };
    User user2 = new User { Name = "Alice", Age = 26  };
    db.Users.Add(user1);
    db.Users.Add(user2);

    // добавляем их в бд
    db.Users.AddRange(user1, user2);


    db.SaveChanges();

    db.SaveChanges();
}
// получение данных
using (ApplicationContext db = new ApplicationContext())
{
    // получаем объекты из бд и выводим на консоль
    var users = db.Users.ToList();
    Console.WriteLine("Users list:");
    foreach (User u in users)
    {
        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
    }
}

Console.ReadKey();