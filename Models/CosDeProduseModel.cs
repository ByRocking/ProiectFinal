using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProiectFinal.Models
{
    public class CosDeProduseModel
    {
        public int Id { get; set; }

        public string Titlu { get; set; }

        public string Autor { get; set; }

        public int Cantitate { get; set; }
    }

    public class CosDeProduseModelDbContext : DbContext
    {
        public DbSet<CosDeProduseModel> CosDeProduse { get; set; }
    }
}