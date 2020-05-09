using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Product_Managment.Business_Access
{
    class Login_Class
    {

        public DataTable Login(string ID, string pwd,int state)
        {
            Data_Access.Data_Access_Layer dal = new Data_Access.Data_Access_Layer();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            param[1] = new SqlParameter("@pwd", SqlDbType.VarChar, 50);
            param[1].Value = pwd;

            param[2] = new SqlParameter("@state", SqlDbType.Int);
            param[2].Value = state;

            dal.open();
            DataTable dt = new DataTable();
            dt = dal.select_data("SP_login", param);
            dal.close();
            return dt;

        }

        public void add_user(string fullname, string username, string pwd, string user_type, byte[] authority)
        {
            Data_Access.Data_Access_Layer dal = new Data_Access.Data_Access_Layer();
            dal.open();
            SqlParameter[] param = new SqlParameter[5];



            param[0] = new SqlParameter("@fullname", SqlDbType.VarChar, 50);
            param[0].Value = fullname;

            param[1] = new SqlParameter("@username", SqlDbType.VarChar,50);
            param[1].Value = username;

            param[2] = new SqlParameter("@pwd", SqlDbType.VarChar, 50);
            param[2].Value = pwd;

            param[3] = new SqlParameter("@user_type", SqlDbType.VarChar, 50);
            param[3].Value = user_type;

            param[4] = new SqlParameter("@authority", SqlDbType.Binary);
            param[4].Value = authority;





            dal.executecommond("add_user", param);
            dal.close();
        }
        public DataTable get_all_users()
        {
            Data_Access.Data_Access_Layer dal = new Data_Access.Data_Access_Layer();

            DataTable dt = new DataTable();
            dt = dal.select_data("get_all_users", null);
            dal.close();
            return dt;

        }


        public void edit_user(string fullname, string username, string pwd, string user_type, byte[] authority)
        {
            Data_Access.Data_Access_Layer dal = new Data_Access.Data_Access_Layer();
            dal.open();
            SqlParameter[] param = new SqlParameter[5];



            param[0] = new SqlParameter("@fullname", SqlDbType.VarChar, 50);
            param[0].Value = fullname;

            param[1] = new SqlParameter("@username", SqlDbType.VarChar, 50);
            param[1].Value = username;

            param[2] = new SqlParameter("@pwd", SqlDbType.VarChar, 50);
            param[2].Value = pwd;

            param[3] = new SqlParameter("@user_type", SqlDbType.VarChar, 50);
            param[3].Value = user_type;

            param[4] = new SqlParameter("@authority", SqlDbType.Binary);
            param[4].Value = authority;


            dal.executecommond("edit_user", param);
            dal.close();
        }



        public void delete_user(string username)
        {
            Data_Access.Data_Access_Layer dal = new Data_Access.Data_Access_Layer();
            dal.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@username", SqlDbType.VarChar, 50);
            param[0].Value = username;

            dal.executecommond("delete_user", param);
            dal.close();
        }


        public DataTable add_user_verfy(string id)
        {
            Data_Access.Data_Access_Layer dal = new Data_Access.Data_Access_Layer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = id;

            DataTable dt = new DataTable();
            dt = dal.select_data("add_user_verfy", param);
            dal.close();
            return dt;

        }

        public DataTable check_state(int state)
        {
            Data_Access.Data_Access_Layer dal = new Data_Access.Data_Access_Layer();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@state", SqlDbType.Int);
            param[0].Value = state;
            
           DataTable dt= dal.select_data("check_state", param);
            dal.close();
            return dt;
            
        }

        public void uncheck_state()
        {
            Data_Access.Data_Access_Layer dal = new Data_Access.Data_Access_Layer();
            dal.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@state", SqlDbType.Int);
            param[0].Value = 0;

            dal.executecommond("uncheck_state", param);
            dal.close();
        }

    }
    }
