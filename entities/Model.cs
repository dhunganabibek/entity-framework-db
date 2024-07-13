


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
        var connectionString = "server=localhost;database=test;user=root;password=Test123@";
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }

    
}

public class Blog
{
    public int BlogId {get; set;}
    public string Url {get; set;}

    public List<Post> Posts {get;} = new();
}

public class Post
{
    public int PostId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }

    public int BlogId { get; set; }
    public Blog Blog { get; set; }
}