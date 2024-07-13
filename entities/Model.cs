


using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

public class BloggingContext: DbContext{
    public DbSet<Blog> Blogs {get; set;}

    public DbSet<Post> Posts {get; set;}

    public string DbPath {get;}

    public BloggingContext(){
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "blogging.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       optionsBuilder.UseSqlite($"Data Source={DbPath}");
    }
}