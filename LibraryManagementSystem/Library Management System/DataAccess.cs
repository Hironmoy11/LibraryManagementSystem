﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class DataAccess
    {
        private SqlConnection sqlcon;
        public SqlConnection Sqlcon
        {
            get { return sqlcon; }
            set { sqlcon = value; }
        }

        private SqlCommand sqlcom;
        public SqlCommand Sqlcom
        {
            get { return sqlcom; }
            set { sqlcom = value; }
        }

        private SqlDataAdapter sda;
        public SqlDataAdapter Sda
        {
            get { return sda; }
            set { sda = value; }
        }

        private DataSet ds;
        public DataSet Ds
        {
            get { return ds; }
            set { ds = value; }
        }

        //internal DataTable dt;

        public DataAccess()
        {
            //this.sqcon = new SqlConnection(WFAExer.Properties.Settings.Default.conStr);
            //this.Sqlcon = new SqlConnection(@"Data Source=LAPTOP-HASIB\SQLEXPRESS;Initial Catalog=testDB;Integrated Security=True");
            this.Sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=simple;Integrated Security=True");
            // this.Sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=simple;Persist Security Info=False;");
            Sqlcon.Open();
        }

        private void QueryText(string query)
        {
            this.Sqlcom = new SqlCommand(query, this.Sqlcon);
        }

        public DataSet ExecuteQuery(string sql)
        {
            this.QueryText(sql);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return Ds;
        }

        public int ExecuteUpdateQuery(string sql)
        {
            this.QueryText(sql);
            int u = this.Sqlcom.ExecuteNonQuery();
            return u;
        }
    }
}
