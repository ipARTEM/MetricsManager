
using EF03Sqlite;

using (ApplicationContext db = new ApplicationContext())
{
    db.Database.EnsureCreated();
    // асинхронная версия
    await db.Database.EnsureCreatedAsync();
}

using (ApplicationContext db = new ApplicationContext())
{
    bool isCreated = db.Database.EnsureCreated();
    // bool isCreated2 = await db.Database.EnsureCreatedAsync();
    if (isCreated) Console.WriteLine("База данных была создана");
    else Console.WriteLine("База данных уже существует");
}

using (ApplicationContext db = new ApplicationContext())
{
    db.Database.EnsureDeleted();
    db.Database.EnsureCreated();
    // асинхронная версия
    await db.Database.EnsureCreatedAsync();
    await db.Database.EnsureDeletedAsync();

    bool isAvalaible = db.Database.CanConnect();
    // bool isAvalaible2 = await db.Database.CanConnectAsync();
    if (isAvalaible) Console.WriteLine("База данных доступна");
    else Console.WriteLine("База данных не доступна");
}