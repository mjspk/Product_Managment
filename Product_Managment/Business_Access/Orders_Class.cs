using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Product_Managment.Business_Access
{
    class Orders_Class
    {


        public DataTable get_last_order()

        {
            Data_Access.Data_Access_Layer dal = new Data_Access.Data_Access_Layer();

            DataTable dt = new DataTable();
            dt = dal.select_data("get_last_order", null);
            dal.close();
            return dt;

        }


        public void add_order( int ID_order,  DateTime DATE_order, int ID_customer, string DESCRIPTION_order, string SALEMAN,string TOTAL, string DEFENCES_AMOUNT, string REMAINING_AMOUNT)
        {
            Data_Access.Data_Access_Layer dal = new Data_Access.Data_Access_Layer();
            dal.open();
            SqlParameter[] param = new SqlParameter[8];

           

            param[0] = new SqlParameter("@ID_order", SqlDbType.Int);
            param[0].Value = ID_order;

            param[1] = new SqlParameter("@DATE_order", SqlDbType.DateTime);
            param[1].Value = DATE_order;


            param[2] = new SqlParameter("@ID_customer", SqlDbType.Int);
            param[2].Value = ID_customer;

            param[3] = new SqlParameter("@DESCRIPTION_order", SqlDbType.VarChar,250);
            param[3].Value = DESCRIPTION_order;

            param[4] = new SqlParameter("@SALEMAN", SqlDbType.VarChar,75);
            param[4].Value = SALEMAN;

            param[5] = new SqlParameter("@TOTAL", SqlDbType.VarChar, 75);
            param[5].Value = TOTAL;


            param[6] = new SqlParameter("@DEFENCES_AMOUNT", SqlDbType.VarChar, 75);
            param[6].Value = DEFENCES_AMOUNT;


            param[7] = new SqlParameter("@REMAINING_AMOUNT", SqlDbType.VarChar, 75);
            param[7].Value = REMAINING_AMOUNT;



            dal.executecommond("add_order", param);
            dal.close();
        }



        public DataTable get_order_details()
        {
            Data_Access.Data_Access_Layer dal = new Data_Access.Data_Access_Layer();

            DataTable dt = new DataTable();
            dt = dal.select_data("get_order_details", null);
            dal.close();
            return dt;

        }

        
        public void add_order_details( string ID_product,  int ID_order,  string PRICE, int QTE, string AMOUNT, string DISCOUNT,string TOTAL_AMOUNT)
        {
            Data_Access.Data_Access_Layer dal = new Data_Access.Data_Access_Layer();
            dal.open();
            SqlParameter[] param = new SqlParameter[7];

           

            param[0] = new SqlParameter("@ID_product", SqlDbType.VarChar,50);
            param[0].Value = ID_product;

            param[1] = new SqlParameter("@ID_order", SqlDbType.Int);
            param[1].Value = ID_order;

            param[2] = new SqlParameter("@PRICE", SqlDbType.VarChar, 250);
            param[2].Value = PRICE;

            param[3] = new SqlParameter("@QTE", SqlDbType.Int);
            param[3].Value = QTE;

             param[4] = new SqlParameter("@AMOUNT", SqlDbType.VarChar, 75);
            param[4].Value = AMOUNT;


            param[5] = new SqlParameter("@DISCOUNT", SqlDbType.VarChar,75);
            param[5].Value = DISCOUNT;

          

            param[6] = new SqlParameter("@TOTAL_AMOUNT", SqlDbType.VarChar, 75);
            param[6].Value = TOTAL_AMOUNT;


           


            dal.executecommond("add_order_details", param);
            dal.close();
        }

        public DataTable quntity_varfy(string ID_product)
        {
            Data_Access.Data_Access_Layer dal = new Data_Access.Data_Access_Layer();
            SqlParameter[] param = new SqlParameter[1];



            param[0] = new SqlParameter("@ID_product", SqlDbType.VarChar,50);
            param[0].Value = ID_product;

            DataTable dt = new DataTable();
            dt = dal.select_data("quntity_varfy", param);
            dal.close();
            return dt;
            
        }



        public DataTable get_last_order_forprint()

        {
            Data_Access.Data_Access_Layer dal = new Data_Access.Data_Access_Layer();

            DataTable dt = new DataTable();
            dt = dal.select_data("get_last_order_forprint", null);
            dal.close();
            return dt;

        }


        public DataTable Search_orders(string id)
        {
            Data_Access.Data_Access_Layer dal = new Data_Access.Data_Access_Layer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = id;

            DataTable dt = new DataTable();
            dt = dal.select_data("Search_orders", param);
            dal.close();
            return dt;

        }

        public void delete_order(int ID_order)
        {
            Data_Access.Data_Access_Layer dal = new Data_Access.Data_Access_Layer();
            dal.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_order", SqlDbType.VarChar, 50);
            param[0].Value = ID_order;

            dal.executecommond("delete_order", param);
            dal.close();
        }
        public DataTable get_all_order()
        {
            Data_Access.Data_Access_Layer dal = new Data_Access.Data_Access_Layer();

            DataTable dt = new DataTable();
            dt = dal.select_data("get_all_order", null);
            dal.close();
            return dt;

        }

        public DataTable Get_order_for_edit(int ID_order)
        {
            Data_Access.Data_Access_Layer dal = new Data_Access.Data_Access_Layer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID_order;
            DataTable dt = new DataTable();
            dt = dal.select_data("Get_order_for_edit", param);
            dal.close();
            return dt;

        }
        public DataTable get_order_details_for_edit(int ID_order)
        {
            Data_Access.Data_Access_Layer dal = new Data_Access.Data_Access_Layer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID_order;
            DataTable dt = new DataTable();
            dt = dal.select_data("get_order_details_for_edit", param);
            dal.close();
            return dt;

        }
       

        


       

    }
}
