using EFCore;
using EFCore.Models;
using Microsoft.EntityFrameworkCore;

var _dbContext = new AppDbContext();

#region Add & Save Employee To Database
//var employee01 = new Employee
//{
//    Name = "Muhammad"
//};

//_dbContext.Employees.Add(employee01); -- Add Employee 
//_dbContext.SaveChanges(); -- Save Employee to DataBase 
#endregion

#region Add & Save  Blog & Author to Database

//var blog = new Blog { Url = "test01" };

//_dbContext.Blogs.Add(blog);
//_dbContext.SaveChanges();



//var author = new Author
//{
//    FirstName = "Muhammad",
//    LastName = "Abdelgawad"
//};

//_dbContext.Authors.Add(author);
//_dbContext.SaveChanges();


#endregion

#region Add & Save Order to Database

//var order = new Order { Amount = 200 };
//_dbContext.Orders.Add(order);
//_dbContext.SaveChanges();
//Console.WriteLine("Data Saved Successfully!");
#endregion

#region  Add Blog & Check if Blog exists
//using (var _dbContext = new AppDbContext())
//{
//    _dbContext.Database.EnsureCreated();

//    var blog = _dbContext.Blogs.FirstOrDefault(b => b.Url == "www.google.com");

//    if (blog == null)// not exists
//    {
//        _dbContext.Blogs.Add(new Blog { Url = "www.google.com" });
//        _dbContext.SaveChanges();
//        Console.WriteLine("Blog Added Successfully!");
//    }
//}
#endregion

#region Read & Display Stocks from Database
//var stocks = _dbContext.Stocks.ToList();
//foreach (var stock in stocks)
//{
//    Console.WriteLine($"Id: {stock.Id}, Name: {stock.Name}, Symbol: {stock.Symbol}, Sector: {stock.Sector}, Industry: {stock.Industry}, Balance: {stock.Balance}");
//}

#endregion

#region Select Item Using Find

//var stock = _dbContext.Stocks.Find(100);
//Console.WriteLine($"Id: {stock.Id}, Name: {stock.Name}");

#endregion

#region Filter Data - Where 

//var stock = _dbContext.Stocks.Where(s => s.Balance > 90000).ToList();

//foreach (var s in stock)
//{
//	Console.WriteLine($"Id: {s.Id},  Balance: {s.Balance}");
//} 

#endregion

#region Select Specific Columns & Display  -Select - Using Anonymous Type
//var stock = _dbContext.Stocks.Select(x => new { Id = x.Id, Name = x.Name });

//foreach (var s in stock)
//{
//    Console.WriteLine($"Id: {s.Id},  Name: {s.Name}");
//} 
#endregion

#region Grouping Data - GroupBy 

//var stocks = _dbContext.Stocks
//    .GroupBy(s => s.Industry)
//    .Select(x => new { Industry = x.Key, Count = x.Count()});

//foreach (var stock in stocks)
//{
//    Console.WriteLine($"Industry: {stock.Industry},  Count: {stock.Count}");
//}

#endregion

#region Tracking

/// - Enable Tracking  -EF Core Tracks Changes on Balance Property
//var stock = _dbContext.Stocks.SingleOrDefault(s => s.Id == 1);
//stock!.Balance += 5000;
//_dbContext.SaveChanges();

/// - Disable Tracking - Using AsNoTracking() Method
//var stock = _dbContext.Stocks.AsNoTracking().SingleOrDefault(s => s.Id == 1);  
//stock!.Balance += 5000;
//_dbContext.SaveChanges();

/// Disable Tracking for All Queries "Change EF Core Default Tracking"
//_dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;


#endregion

#region Eager Loading - Include Method 
/// - Not Best Practice - Fetch Related Data Separately (Multiple Queries) - Low Performance


//var book = _dbContext.Books.Include(b => b.Author).FirstOrDefault(b => b.Id == 1);
//Console.WriteLine($"Book Name: {book!.Name}");

/// -- ThenInclude for Nested Related Data
//var book = _dbContext.Books.Include(b => b.Author).ThenInclude(b=> b.test).FirstOrDefault(b => b.Id == 1);
//Console.WriteLine($"Book Name: {book!.Name.test}");

#endregion

#region Explicit Loading - Reference(), Load() Methods

/// -- Load Related Data Explicitly - Better Performance (Single Query)
/// 
//var book = _dbContext.Books.FirstOrDefault(b => b.Id == 1);
//_dbContext.Entry(book!).Reference(b => b.Author).Load();   // Load Related Data Explicitly Navigation Property Not Collection
//Console.WriteLine($"Book Name: {book!.Author.Name}");

//var blog = _dbContext.Blogs.FirstOrDefault(b => b.Id == 1);
//_dbContext.Entry(blog!).Collection(b => b.Posts).Load();     // Load Related Data Explicitly Collection "Posts"

//foreach (var post in blog.Posts)
//{
//    Console.WriteLine($"Post Title: {post.Title}");
//}

#endregion

#region Lazy Loading - Virtual Navigation Properties

/// -- First You Need to Install "Microsoft.EntityFrameworkCore.Proxies" Package
/// -- Enable Lazy Loading Proxies in AppDbContext Options
/// -- Make Navigation Properties "Virtual" in Your Entities

//var book = _dbContext.Books.Single(b => b.Id == 1); 
//Console.WriteLine($"Book Name: {book!.Author.Name}");

#endregion

#region SplitQuery
/// -- Efficient for complex includes
/// -- Loads each included relationship using separate SQL queries.
/// -- Use AsSplitQuery to split the query into multiple queries for better performance with large related data
//var blogd = _dbContext.Blogs.Include(b => b.Posts).AsSplitQuery().ToList(); 

#endregion

#region  Execute Stored Procedure

//var bookId = 1;

//var books = _dbContext.Books.FromSqlRaw($"prc_GetBookById {bookId}").ToList(); // Execute Stored Procedure to get Book by Id

//foreach (var book in books)
//{
//	Console.WriteLine($"Book Id: {book.Id}, Book Name: {book.Name}");
//}


#endregion