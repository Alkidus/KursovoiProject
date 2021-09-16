using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Project.Models;

namespace Project.Controller
{
    public class DomofonContext : DbContext
    {
        public DomofonContext() : base("MyConnString")
        {
            //Database.SetInitializer<DomofonContext>(new CreateDatabaseIfNotExists<DomofonContext>());
            Database.SetInitializer<DomofonContext>(new DropCreateDatabaseIfModelChanges<DomofonContext>());
        }

        public DbSet<Accrual> Accruals { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<DomofonHandset> DomofonHandsets { get; set; }
        public DbSet<DomofonKey> DomofonKeys { get; set; }
        public DbSet<DomofonSystem> DomofonSystems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<RepairRequest> RepairRequests { get; set; }
        public DbSet<Serviceman> Servicemen { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
