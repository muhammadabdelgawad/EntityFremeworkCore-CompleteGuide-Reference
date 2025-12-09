# Entity Framework Core - Complete Guide & Reference 

A comprehensive demonstration project showcasing **Entity Framework Core** features, patterns, and best practices for building robust data access layers in .NET applications.

[![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?style=flat&logo=dotnet)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-14.0-239120?style=flat&logo=c-sharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![EF Core](https://img.shields.io/badge/EF%20Core-Latest-512BD4?style=flat)](https://docs.microsoft.com/en-us/ef/core/)
[![SQL Server](https://img.shields.io/badge/SQL%20Server-Express-CC2927?style=flat&logo=microsoft-sql-server)](https://www.microsoft.com/sql-server)

## 📖 About The Project

This repository serves as a **complete learning resource** and **reference implementation** for Entity Framework Core. It demonstrates practical examples of data access patterns, relationship configurations, query optimization techniques, and advanced features used in real-world applications.

Perfect for developers looking to:
- 🎓 Learn EF Core from basics to advanced concepts
- 📚 Reference common implementation patterns
- 🔍 Understand performance optimization techniques
- 🛠️ Implement best practices in production applications

## ✨ Features

### Core Operations
- ✅ **CRUD Operations** - Create, Read, Update, Delete with multiple approaches
- ✅ **Advanced Querying** - Filtering, projection, grouping, and ordering
- ✅ **Bulk Operations** - High-performance batch updates and deletes
- ✅ Stored procedure integration
- ✅ Raw SQL queries
  
### Relationships
- 🔗 **One-to-One** - Blog and BlogImage
- 🔗 **One-to-Many** - Blog and Posts, Author and Books
- 🔗 **Many-to-Many** - Story and Tags with junction table

### Loading Strategies
- 📦 **Eager Loading** - Load related data upfront with `Include()`
- 📦 **Explicit Loading** - Load related data on-demand with `Load()`
- 📦 **Lazy Loading** - Automatic loading with virtual navigation properties

### Advanced Features
- 🎯 **Query Optimization** - NoTracking, SplitQuery, and performance tuning
- 🗃️ **Stored Procedures** - Integration with database procedures
- 🛡️ **Global Query Filters** - Soft delete implementation
- 📊 **Computed Columns** - Database-calculated values
- 🔢 **Sequences** - Database sequence generation
- 🔐 **Transaction management** with savepoints
- 🗑️ **Soft delete** with global query filters
- 🌱 **Data seeding strategies**
- 📊 **Computed columns and sequences**
- 🔧 **Fluent API configuration**
- 📋 **Migration management**


## 📊 Database Schema

The project includes these main entities:

| Entity | Description | Key Features |
|--------|-------------|--------------|
| **Blog** | Blog posts system | One-to-Many with Posts |
| **Post** | Individual blog posts | Foreign key to Blog |
| **Author** | Book authors | One-to-Many with Books |
| **Book** | Books collection | Foreign key to Author |
| **Stock** | Market stock data | Grouping examples |
| **Order** | Orders with soft delete | Global query filter, Sequence |
| **Nationality** | Reference data | Used by Authors |
| **Story/Tag** | Content tagging | Many-to-Many relationship |
## 🛠️ Technology Stack

- **.NET 10** - Latest .NET framework
- **C# 14.0** - Modern C# language features
- **Entity Framework Core** - ORM for data access
- **SQL Server Express** - Database engine
- **Fluent API** - Code-first configuration
 ## 📋 Prerequisites

Before you begin, ensure you have the following installed:

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- [SQL Server 2019+](https://www.microsoft.com/sql-server/sql-server-downloads) or SQL Server Express
- [Visual Studio 2026](https://visualstudio.microsoft.com/) (recommended) or [Visual Studio Code](https://code.visualstudio.com/)
- [SQL Server Management Studio](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms) (optional)


