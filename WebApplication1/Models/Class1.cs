using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MySql.Data.MySqlClient;
namespace WebApplication1.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public String Genre { get; set; }
        public decimal Price { get; set; }

    }
    public class lotteryUser
    {
        public int ID { get; set; }
        public string username { get; set; }
        public string emal { get; set; }
        public string password { get; set; }
    }
    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}