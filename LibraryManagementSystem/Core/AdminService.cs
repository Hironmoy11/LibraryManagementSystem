using Data;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class AdminService : IAdminService
    {
         private static AdminDataAccess adminDataAccess = null;

        public AdminService()
        {
            if (AdminService.adminDataAccess == null)
            {
                AdminService.adminDataAccess = new AdminDataAccess();
            }
        }

        public int Add(Admin admin)
        {
            return AdminService.adminDataAccess.Add(admin); 

        }
        public int Remove(int Id)
        {
            return AdminService.adminDataAccess.Remove(Id);

        }
        public int Edit(Admin admin)
        {
            return AdminService.adminDataAccess.Edit(admin);

        }
        public List<Admin> GetAll()
        {
            return AdminService.adminDataAccess.GetAll();

        }

        public Admin GetById(int Id)
        {
            return AdminService.adminDataAccess.GetById(Id);

        }
        public void Login()
        {

        }
        public void Logout()
        {

        }
        //
        public int AddLibrarian(Admin admin)
        {
            return AdminService.adminDataAccess.Add(admin);

        }
        public List<Admin> ViewLibrarian()
        {
            return AdminService.adminDataAccess.GetAll();

        }
        public int UpdateLibrarian(Admin admin)
        {
            return AdminService.adminDataAccess.Edit(admin);

        }

        public int DeleteLibarian(int Id)
        {
            return AdminService.adminDataAccess.Remove(Id);

        }
       
       
        public int AddBook(Admin admin)
        {
            return AdminService.adminDataAccess.Add(admin);

        }
        public int DeleteBook(int Id)
        {
            return AdminService.adminDataAccess.Remove(Id);

        }
        public List<Admin> ViewBook()
        {
            return AdminService.adminDataAccess.GetAll();

        }
        public List<Book> SearchBook(string name)
        {
           // List<Book> personList = PersonService.personDataAccess.GetAll();
            List<Book> filteredPersonList = new List<Book>();
            //foreach (Book person in personList)
            //{
            //    if (person.Name.ToLower().Contains(name.ToLower()))
            //    {
            //        filteredPersonList.Add(person);
            //    }
            //}
            return filteredPersonList;
        }


    }
}
