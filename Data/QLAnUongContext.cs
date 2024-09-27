using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class QLKhoaHocContext : DbContext
{
    public QLKhoaHocContext(DbContextOptions<QLKhoaHocContext> options)
        : base(options)
    {
    }

    // Thêm các DbSet cho các b?ng trong c? s? d? li?u
    public DbSet<Category> Categories { get; set; }
    public DbSet<Course> Courses { get; set; }
}
public class Category
{
    public int CatID { get; set; }
    public string CatName { get; set; }
    public string CatDescription { get; set; }

    // Navigation property
    public ICollection<Course> Courses { get; set; }
}

public class Course
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string ImageFilePath { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public int CatID { get; set; }
    public int NumsLike{ get; set; }

    // Navigation property
    public Category Category { get; set; }
}