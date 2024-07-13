// looking for sqlite path

using var db = new BloggingContext();

System.Console.WriteLine($"Database Path: {db.DbPath}");

// Create
Console.WriteLine("Inserting a new blog");
db.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
db.SaveChanges();