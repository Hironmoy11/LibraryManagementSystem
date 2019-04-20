using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
  public  class ServiceFactory
    {
      public IAdminService GetAdminServiceInstance()
      {
          return new AdminService();
      }
    }
}
