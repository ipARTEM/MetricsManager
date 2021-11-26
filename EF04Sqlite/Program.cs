
// Добавление
using EF04Sqlite;
using Microsoft.EntityFrameworkCore;

using (ApplicationContext db = new ApplicationContext())
{
    User tom = new User { Name = "Tom", Age = 33 };
    User alice = new User { Name = "Alice", Age = 26 };

    // Добавление
    db.Users.Add(tom);
    db.Users.Add(alice);
    db.SaveChanges();
}

// получение
using (ApplicationContext db = new ApplicationContext())
{
    // получаем объекты из бд и выводим на консоль
    var users = db.Users.ToList();
    Console.WriteLine("Данные после добавления:");
    foreach (User u in users)
    {
        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
    }
}

// Редактирование
using (ApplicationContext db = new ApplicationContext())
{
    // получаем первый объект
    User? user2 = db.Users.FirstOrDefault();
    if (user2 != null)
    {
        user2.Name = "Bob";
        user2.Age = 44;
        //обновляем объект
        //db.Users.Update(user);
        db.SaveChanges();
    }
    // выводим данные после обновления
    Console.WriteLine("\nДанные после редактирования:");
    var users = db.Users.ToList();
    foreach (User u in users)
    {
        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
    }
}

// Удаление
using (ApplicationContext db = new ApplicationContext())
{
    // получаем первый объект
    User? user3 = db.Users.FirstOrDefault();
    if (user3 != null)
    {
        //удаляем объект
        db.Users.Remove(user3);
        db.SaveChanges();
    }
    // выводим данные после обновления
    Console.WriteLine("\nДанные после удаления:");
    var users = db.Users.ToList();
    foreach (User u in users)
    {
        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
    }
}

User? user4 = null;
using (ApplicationContext db = new ApplicationContext())
{
    // получаем объект
    user4 = db.Users.FirstOrDefault();
    Console.WriteLine("Данные до редактирования:");
    var users = db.Users.ToList();
    foreach (User u in users)
    {
        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
    }
}


// Редактирование
using (ApplicationContext db = new ApplicationContext())
{
    // Редактирование
    if (user4 != null)
    {
        user4.Name = "Sam";
        user4.Age = 33;
        db.SaveChanges();
    }
    // выводим данные после обновления
    Console.WriteLine("\nДанные после редактирования:");
    var users = db.Users.ToList();
    foreach (var u in users)
    {
        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
    }
}

//*************************************************************


// Добавление
using (ApplicationContext db = new ApplicationContext())
{
    User tom = new User { Name = "Tom", Age = 33 };
    User alice = new User { Name = "Alice", Age = 26 };

    // Добавление
    await db.Users.AddRangeAsync(tom, alice);
    await db.SaveChangesAsync();
}

// получение
using (ApplicationContext db = new ApplicationContext())
{
    // получаем объекты из бд и выводим на консоль
    var users = await db.Users.ToListAsync();
    Console.WriteLine("Данные после добавления:");
    foreach (User u in users)
    {
        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
    }
}

// Редактирование
using (ApplicationContext db = new ApplicationContext())
{
    // получаем первый объект
    User? user = await db.Users.FirstOrDefaultAsync();
    if (user != null)
    {
        user.Name = "Bob";
        user.Age = 44;
        //обновляем объект
        await db.SaveChangesAsync();
    }
    // выводим данные после обновления
    Console.WriteLine("\nДанные после редактирования:");
    var users = await db.Users.ToListAsync();
    foreach (User u in users)
    {
        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
    }
}

// Удаление
using (ApplicationContext db = new ApplicationContext())
{
    // получаем первый объект
    User? user = await db.Users.FirstOrDefaultAsync();
    if (user != null)
    {
        //удаляем объект
        db.Users.Remove(user);
        await db.SaveChangesAsync();
    }
    // выводим данные после обновления
    Console.WriteLine("\nДанные после удаления:");
    var users = await db.Users.ToListAsync();
    foreach (User u in users)
    {
        Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
    }
}