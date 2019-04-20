using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
  public interface IAdminService
    {
        int Add(Admin admin);
        int Remove(int Id);
        int Edit(Admin admin);
        List<Admin> GetAll();
        Admin GetById(int Id);
        
    }
}
