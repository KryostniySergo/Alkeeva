using Alkeeva.DB.Model;
using Microsoft.EntityFrameworkCore;
using System.IO;

public class ApplicationContext : DbContext
{
    public DbSet<Faculty> Faculties { get; set; } = null!;
    public DbSet<Speciality> Specialities { get; set; } = null!;
    public DbSet<Abiturients> Abiturients { get; set; } = null!;

    public ApplicationContext()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("" +
            "Host=localhost;" +
            "Port=5432;" +
            "Database=alkeeva;" +
            "Username=postgres;" +
            "Password=12345");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        var fist = new Faculty { Id = 1, Name = "ФИСТ" };
        var fbto = new Faculty { Id = 2, Name = "ФБТО" };
        var cmka = new Faculty { Id = 3, Name = "ЦМК" };

        var ivt = new Speciality { Id = 1, Name = "ИВТ", MinPoint = 100, NessasaryItem = "физика", FacultyId = fist.Id };
        var ist = new Speciality { Id = 2, Name = "ИСТ", MinPoint = 100, NessasaryItem = "физика", FacultyId = fist.Id };
        var ib = new Speciality { Id = 3, Name = "ИБ", MinPoint = 200, NessasaryItem = "информатика", FacultyId = fbto.Id };
        var yits = new Speciality { Id = 4, Name = "УИТС", MinPoint = 150, NessasaryItem = "информатика", FacultyId = fbto.Id };
        var bizinf = new Speciality { Id = 5, Name = "БИ", MinPoint = 120, NessasaryItem = "обществознание", FacultyId = cmka.Id };
        var recl = new Speciality { Id = 6, Name = "РСО", MinPoint = 100, NessasaryItem = "обществознание", FacultyId = cmka.Id };

        int offset = 0;
        Random rand = new Random();

        //ИВТ
        List<Abiturients> Ivts = new List<Abiturients>();
        using (StreamReader reader = new StreamReader(@"D:\MyFuckingProgramms\Alkeeva\Alkeeva\DB\Del_me_Later\ИВТ.txt"))
        {
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                Ivts.Add(new Abiturients
                {
                    Id = ++offset,
                    FIO = line,
                    Russian = rand.Next(30, 100),
                    Math = rand.Next(30, 100),
                    Physics = rand.Next(30, 100),
                    Social = 0,
                    Informatics = 0,
                    SpecialityId = ivt.Id
                });
            }
        }

        //ИСТ
        List<Abiturients> Ists = new List<Abiturients>();
        using (StreamReader reader = new StreamReader(@"D:\MyFuckingProgramms\Alkeeva\Alkeeva\DB\Del_me_Later\ИСТ.txt"))
        {
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                Ists.Add(new Abiturients
                {
                    Id = ++offset,
                    FIO = line,
                    Russian = rand.Next(30, 100),
                    Math = rand.Next(30, 100),
                    Physics = rand.Next(30, 100),
                    Social = 0,
                    Informatics = 0,
                    SpecialityId = ist.Id
                });
            }
        }

        //ИБ
        List<Abiturients> IB = new List<Abiturients>();
        using (StreamReader reader = new StreamReader(@"D:\MyFuckingProgramms\Alkeeva\Alkeeva\DB\Del_me_Later\ИБ.txt"))
        {
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                IB.Add(new Abiturients
                {
                    Id = ++offset,
                    FIO = line,
                    Russian = rand.Next(30, 100),
                    Math = rand.Next(30, 100),
                    Physics = 0,
                    Social = 0,
                    Informatics = rand.Next(30, 100),
                    SpecialityId = ib.Id
                });
            }
        }

        //УИТС
        List<Abiturients> Yits = new List<Abiturients>();
        using (StreamReader reader = new StreamReader(@"D:\MyFuckingProgramms\Alkeeva\Alkeeva\DB\Del_me_Later\УИТС.txt"))
        {
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                Yits.Add(new Abiturients
                {
                    Id = ++offset,
                    FIO = line,
                    Russian = rand.Next(30, 100),
                    Math = rand.Next(30, 100),
                    Physics = 0,
                    Social = 0,
                    Informatics = rand.Next(30, 100),
                    SpecialityId = yits.Id
                });
            }
        }

        //БИ
        List<Abiturients> Bi = new List<Abiturients>();
        using (StreamReader reader = new StreamReader(@"D:\MyFuckingProgramms\Alkeeva\Alkeeva\DB\Del_me_Later\БИ.txt"))
        {
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                Bi.Add(new Abiturients
                {
                    Id = ++offset,
                    FIO = line,
                    Russian = rand.Next(30, 100),
                    Math = rand.Next(30, 100),
                    Physics = 0,
                    Social = rand.Next(30, 100),
                    Informatics = 0,
                    SpecialityId = bizinf.Id
                });
            }
        }

        //РСО
        List<Abiturients> Rso = new List<Abiturients>();
        using (StreamReader reader = new StreamReader(@"D:\MyFuckingProgramms\Alkeeva\Alkeeva\DB\Del_me_Later\РСО.txt"))
        {
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                Rso.Add(new Abiturients
                {
                    Id = ++offset,
                    FIO = line,
                    Russian = rand.Next(30, 100),
                    Math = rand.Next(30, 100),
                    Physics = 0,
                    Social = rand.Next(30, 100),
                    Informatics = 0,
                    SpecialityId = recl.Id
                });
            }
        }

        modelBuilder.Entity<Faculty>().HasData(fist, fbto, cmka);
        modelBuilder.Entity<Speciality>().HasData(ivt, ist, ib, yits, bizinf, recl);
        modelBuilder.Entity<Abiturients>().HasData(Ivts);
        modelBuilder.Entity<Abiturients>().HasData(Ists);
        modelBuilder.Entity<Abiturients>().HasData(IB);
        modelBuilder.Entity<Abiturients>().HasData(Yits);
        modelBuilder.Entity<Abiturients>().HasData(Bi);
        modelBuilder.Entity<Abiturients>().HasData(Rso);
    }
}