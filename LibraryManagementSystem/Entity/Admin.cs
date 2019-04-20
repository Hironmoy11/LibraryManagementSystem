using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entity
{
    public class Admin
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        //readonly int Id;
        //string UserName;
        //string Password;

        public Admin()
        {

        }
        public Admin(int Id)
        {
            this.Id = Id;
        }

    }
}
