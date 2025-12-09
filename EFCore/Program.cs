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

#region Global Query Filter
// Display Orders with IsDeleted Column Using Global Query Filter

//var orders = _dbContext.Orders.ToList();
//foreach (var order in orders)
//{
//	Console.WriteLine($"Id: {order.Id}, OrderNo: {order.OrderNo}, Amount: {order.Amount}, IsDeleted: {order.IsDeleted}");
//} 
#endregion

#region Add Opertaion - New Record Database

/// -- Add National And Save to Database

//var nationality = new Nationality { Name = "Egyptian" };
//_dbContext.Nationalities.Add(nationality);  // Add National To DbSet
//_dbContext.SaveChanges(); // Save Changes to Database 

/// --Add Multiple Nationalities to Database

//var nationalities = new List<Nationality>
//{
//    new Nationality { Name = "Spanish" },
//    new Nationality { Name = "Indian" },
//    new Nationality { Name = "Chinese" },
//    new Nationality { Name = "Nigerian" },
//    new Nationality { Name = "Turkish"}
//};
//_dbContext.Nationalities.AddRange(nationalities); // Add Multiple Nationalities to DbSet
//_dbContext.SaveChanges(); // Save Changes to Database

/// -- Add Author with Existing National -- Using Navigation Property

//var author = new Author
//{
//    FirstName = "John",
//    LastName = "Doe" ,
//    Nationality =  new Nationality { Name "Russian" } // Add New Nationality while Adding Author 
//};

//_dbContext.Authors.Add(author); // Add Author to DbSet
//_dbContext.SaveChanges(); // Save Changes to Database


#endregion

#region Update Operation - Existing Record Database

/// -- Update Existing National Name - Using Find Method  -First Way

//var nationatlity = _dbContext.Nationalities.Find(1);
//nationatlity!.Name = "TestUpdate1";
//_dbContext.SaveChanges();

/// -- Update Existing National Name - Using Update Method by Creating New Object  -Second Way

//var nationatlity = new Nationality { Id = 1, Name = "TestUpdate2" };
//_dbContext.Nationalities.Update(nationatlity); 
//_dbContext.SaveChanges();

/// -- Update Existing National Name - Using Entry & CurrentValues.SetValues Method -Third Way

//var currentNationality = _dbContext.Nationalities.Find(1);
//var newNationality = new Nationality { Id = 1, Name = "Testv3" };
//_dbContext.Entry(currentNationality!).CurrentValues.SetValues(newNationality);
//_dbContext.SaveChanges();

/// -- Update Existing National Name - Using Entry & Property Method if some columns i dont want to update it - Fourth Way
//var order = new Order { Id = 1,OrderNo= 9, Amount = 5000  };

//_dbContext.Orders.Update(order);
//_dbContext.Entry(order).Property(o => o.OrderNo).IsModified = false; // Exclude OrderNo Property from Update
//_dbContext.Entry(order).Property(o => o.IsDeleted).IsModified = false; // Exclude IsDeleted Property from Update
//_dbContext.SaveChanges();

///-- Update Multiple Orders - Using UpdateRange Method - Fifth Way
//var orders = _dbContext.Orders.Where(o => !o.IsDeleted).ToList();
//foreach (var order in orders)
//{
//    order.IsDeleted = true; // Mark as deleted
//}
//_dbContext.UpdateRange(orders);
//_dbContext.SaveChanges();

#endregion

#region Delete Operation - Existing Record Database

///-- Delete Nationality - Using Remove Method  - First Way

//var nationalities = _dbContext.Nationalities.Find(1);
//_dbContext.Nationalities.Remove(nationalities!);
//_dbContext.SaveChanges();

/// Delete Multiple Nationalities - Using RemoveRange Method - Second Way 

//var nationalities = _dbContext.Nationalities.Where(n => n.Id > 11 && n.Id < 15).ToList();
//_dbContext.Nationalities.RemoveRange(nationalities); 
//_dbContext.SaveChanges();

/// Delete Blog - Using Find & Remove Methods   - Third Way

//var blog = _dbContext.Blogs.Find(5);

//_dbContext.Blogs.Remove(blog!);
//_dbContext.SaveChanges();

///-- Delete Blog & Its Related Posts - Using RemoveRange Method - Fourth Way

//var blog = _dbContext.Blogs.Find(6);
//var post = _dbContext.Posts.Where(p => p.BlogId == 5);

//_dbContext.Blogs.RemoveRange(post!);
//_dbContext.Blogs.Remove(blog!);
//_dbContext.SaveChanges();



#endregion

#region Transactions
/// -- Using Transaction to Ensure Data Integrity

//using var transaction = _dbContext.Database.BeginTransaction();

//try
//{
//    _dbContext.Nationalities.Add(new Nationality { Name = "Test 8" });
//    _dbContext.SaveChanges();



//    // _dbContext.Nationalities.Add(new Nationality {Id= 10, Name = "Test 10" });  // This will cause an exception due to duplicate primary key

//    _dbContext.SaveChanges();

//    transaction.Commit(); // Commit Transaction if all operations succeed
//}
//catch (Exception)
//{
//    transaction.Rollback(); // Rollback Transaction if any operation fails

//}


/// -- Using Savepoint in Transaction to Rollback Partial Changes

//var transaction = _dbContext.Database.BeginTransaction();
//try
//{
//    _dbContext.Nationalities.Add(new Nationality { Name = "Test 8" });
//    _dbContext.SaveChanges();

//    transaction.CreateSavepoint("AfterFirstInsert"); // Create Savepoint after first insert

//    // _dbContext.Nationalities.Add(new Nationality {Id= 10, Name = "Test 10" });  // This will cause an exception due to duplicate primary key
//    _dbContext.Nationalities.Add(new Nationality { Name = "Test 3" });
//    _dbContext.Nationalities.Add(new Nationality { Name = "Test 4" });
//    _dbContext.SaveChanges();

//    transaction.Commit(); // Commit Transaction if all operations succeed
//}
//catch (Exception)
//{

//    transaction.RollbackToSavepoint("AfterFirstInsert"); // Rollback to Savepoint
//}

/// --- Using Savepoint in Transaction to Rollback Partial Changes and Commit Remaining Changes "If Business Need that"

//var transaction = _dbContext.Database.BeginTransaction();
//try
//{
//    _dbContext.Nationalities.Add(new Nationality { Name = "Test 8" });
//    _dbContext.SaveChanges();

//    transaction.CreateSavepoint("AfterFirstInsert"); // Create Savepoint after first insert

//    // _dbContext.Nationalities.Add(new Nationality {Id= 10, Name = "Test 10" });  // This will cause an exception due to duplicate primary key
//    _dbContext.Nationalities.Add(new Nationality { Name = "Test 3" });
//    _dbContext.Nationalities.Add(new Nationality { Name = "Test 4" });
//    _dbContext.SaveChanges();

//    transaction.Commit(); // Commit Transaction if all operations succeed
//}
//catch (Exception)
//{

//    transaction.RollbackToSavepoint("AfterFirstInsert"); // Rollback to Savepoint
//    transaction.Commit(); // Commit the transaction after rolling back to savepoint
//}
#endregion

#region Bulk Update & Delete Operations 
/// -- Bulk Delete ExecuteDelete Method

//_dbContext.Stocks.ExecuteDelete(); // Bulk Delete All Data From Stocks 

//_dbContext.Stocks.Skip(100).ExecuteDelete(); // Bulk Delete Stocks 

//_dbContext.Stocks.Where(s=> s.Id > 90).ExecuteDelete(); // Bulk Delete Stocks with Condition


/// -- Bulk Update ExecuteUpdate Method

//_dbContext.Stocks.Take(10).ExecuteUpdate(s => s.SetProperty(x=> x.Name, x=>x.Name + " updated"));
#endregion



