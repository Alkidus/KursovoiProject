using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class User//пользователи базой
    {
        public int Id { get; set; }
        public string UserName { get; set; }//имя
        public string UserPassword { get; set; }//пароль

    }
}
