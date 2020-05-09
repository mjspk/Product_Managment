using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Product_Managment.Business_Access
{
    class Customers_Class
    {
        public DataTable get_all_customer
()
        {
            Data_Access.Data_Access_Layer dal = new Data_Access.Data_Access_Layer();

            DataTable dt = new DataTable();
            dt = dal.select_data("get_all_customer", null);
            dal.close();
            return dt;

        }
        public void add_customer(string First_Name, string Last_Name, string @Tel, string Email, byte[] Image_customer,string state)
        {
            Data_Access.Data_Access_Layer dal = new Data_Access.Data_Access_Layer();
            dal.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@First_Name", SqlDbType.VarChar, 50);
            param[0].Value = First_Name;

            param[1] = new SqlParameter("@Last_Name", SqlDbType.VarChar, 50);
            param[1].Value = Last_Name;

            param[2] = new SqlParameter("@Tel", SqlDbType.NChar);
            param[2].Value = Tel;

            param[3] = new SqlParameter("@Email", SqlDbType.VarChar, 50);
            param[3].Value = Email;

            param[4] = new SqlParameter("@Image_customer", SqlDbType.Image);
            param[4].Value = Image_customer;

            param[5] = new SqlParameter("@state", SqlDbType.VarChar,50);
            param[5].Value = state;



            dal.executecommond("add_customer", param);
            dal.close();

        }

        public void delete_customer(int ID_customer)
        {
            Data_Access.Data_Access_Layer dal = new Data_Access.Data_Access_Layer();
            dal.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_customer", SqlDbType.VarChar, 50);
            param[0].Value = ID_customer;

            dal.executecommond("delete_customer", param);
            dal.close();
        }


        public void update_customer(int ID_customer, string First_Name, string Last_Name, string @Tel, string Email, byte[] Image_customer, string state)
        {
            Data_Access.Data_Access_Layer dal = new Data_Access.Data_Access_Layer();
            dal.open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@ID_customer", SqlDbType.Int);
            param[0].Value = ID_customer; 

            param[1] = new SqlParameter("@First_Name", SqlDbType.VarChar, 50);
            param[1].Value = First_Name;

            param[2] = new SqlParameter("@Last_Name", SqlDbType.VarChar, 50);
            param[2].Value = Last_Name;

            param[3] = new SqlParameter("@Tel", SqlDbType.NChar);
            param[3].Value = Tel;

            param[4] = new SqlParameter("@Email", SqlDbType.VarChar, 50);
            param[4].Value = Email;

            param[5] = new SqlParameter("@Image_customer", SqlDbType.Image);
            param[5].Value = Image_customer;

            param[6] = new SqlParameter("@state", SqlDbType.VarChar,50);
            param[6].Value = state;





            dal.executecommond("update_customer", param);
            dal.close();

        }
        public DataTable Search_customer(string id)
        {
            Data_Access.Data_Access_Layer dal = new Data_Access.Data_Access_Layer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = id;

            DataTable dt = new DataTable();
            dt = dal.select_data("Search_customer", param);
            dal.close();
            return dt;

        }
    }
}
