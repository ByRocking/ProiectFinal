using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProiectFinal.Models
{
    public class CatalogDeProduseModel
    {
        public int Id { get; set; }

        public string Titlu { get; set; }

        public string Autor { get; set; }
    }

    public class CatalogDeProduseDbContext : DbContext
    {
        public DbSet<CatalogDeProduseModel> CatalogDeProduse { get; set; }
    }
}