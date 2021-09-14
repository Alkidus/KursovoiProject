using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Project.Controller
{
    public class DomofonContext : DbContext
    {
        public DomofonContext() : base("MyConnString")
        {
            //Database.SetInitializer<DomofonContext>(new CreateDatabaseIfNotExists<DomofonContext>());
            Database.SetInitializer<DomofonContext>(new DropCreateDatabaseIfModelChanges<DomofonContext>());
        }

    }
}
