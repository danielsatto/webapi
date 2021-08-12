using Microsoft.EntityFrameworkCore;
using webapi.Models;

namespace webapi.Data 
{
    // Classe que representa o banco de dados
    // Para instalar o EFCore use o comando 
    //      dotnet add package Microsoft.EntityFrameworkCore.InMemory    
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {}

        public DbSet<Product> Products {get;set;}
        public DbSet<Category> Categories {get;set;}
    

    }
}