using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AdminDataAccess
    {
        public int Add(Admin admin)
        {
            string query = string.Format("INSERT INTO Admin(Id, UserName,Password) VALUES('{0}', '{1}' ,'{2}')", admin.Id, admin.UserName,admin.Password);
            return DataAccess.ExecuteQuery(query);
        }

        public int Remove(int Id)
        {
            string query = "DELETE FROM Admin WHERE Id=" + Id;
            return DataAccess.ExecuteQuery(query);
        }

        public int Edit(Admin admin)
        {
            string query = "UPDATE Admin SET UserName='" + admin.UserName + "', Password='" + admin.Password + "' WHERE Id=" + admin.Id;
            return DataAccess.ExecuteQuery(query);
        }

        public List<Admin> GetAll()
        {
            string query = "SELECT Id, UserNmae, Password FROM Admin";
            SqlDataReader reader = DataAccess.GetData(query);

            Admin admin = null;
            List<Admin> adminList = new List<Admin>();
            while (reader.Read())
            {
                admin = new Admin(Convert.ToInt32(reader["Id"]));
                admin.UserName = reader["UserName"].ToString();
                admin.Password = reader["Password"].ToString();

                adminList.Add(admin);
            }
            return adminList;
        }

        public Admin GetById(int Id)
        {
            string query = "SELECT Id, UserName, Password FROM Admin WHERE Id=" + Id;
            SqlDataReader reader = DataAccess.GetData(query);
            reader.Read();

            Admin admin = null;
            if (reader.HasRows)
            {
                admin = new Admin(Convert.ToInt32(reader["Id"]));
                admin.UserName = reader["UserName"].ToString();
                admin.Password = reader["Password"].ToString();
            }
            return admin;
        }
    }
}
