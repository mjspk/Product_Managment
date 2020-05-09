using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Product_Managment.Business_Access
{
    class Product_Class
    {
        public DataTable get_all_Category()
        {
            Data_Access.Data_Access_Layer dal = new Data_Access.Data_Access_Layer();

            DataTable dt = new DataTable();
            dt = dal.select_data("get_all_Category", null);
            dal.close();
            return dt;

        }
        public void add_product(string ID_product, string LABEL_product, int QTE_product, string PRICE_product, byte[] IMAGE_product, int ID_CAT)
        {
            Data_Access.Data_Access_Layer dal = new Data_Access.Data_Access_Layer();
            dal.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_product", SqlDbType.VarChar, 50);
            param[0].Value = ID_product;

            param[1] = new SqlParameter("@LABEL_product", SqlDbType.VarChar, 50);
            param[1].Value = LABEL_product;

            param[2] = new SqlParameter("@QTE_product", SqlDbType.Int);
            param[2].Value = QTE_product;

            param[3] = new SqlParameter("@PRICE_product", SqlDbType.VarChar, 50);
            param[3].Value = PRICE_product;

            param[4] = new SqlParameter("@IMAGE_product", SqlDbType.Image);
            param[4].Value = IMAGE_product;

            param[5] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[5].Value = ID_CAT;

            dal.executecommond("add_product", param);
            dal.close();

        }


        public DataTable add_product_verfy(string id)
        {
            Data_Access.Data_Access_Layer dal = new Data_Access.Data_Access_Layer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = id;

            DataTable dt = new DataTable();
            dt = dal.select_data("add_product_verfy", param);
            dal.close();
            return dt;

        }


        public DataTable get_all_product()
        {
            Data_Access.Data_Access_Layer dal = new Data_Access.Data_Access_Layer();

            DataTable dt = new DataTable();
            dt = dal.select_data("get_all_product", null);
            dal.close();
            return dt;

        }


        public DataTable Search_product(string id)
        {
            Data_Access.Data_Access_Layer dal = new Data_Access.Data_Access_Layer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = id;

            DataTable dt = new DataTable();
            dt = dal.select_data("Search_product", param);
            dal.close();
            return dt;

        }

        public void delete_product(string ID_product)
        {
            Data_Access.Data_Access_Layer dal = new Data_Access.Data_Access_Layer();
            dal.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_product", SqlDbType.VarChar, 50);
            param[0].Value = ID_product;

            dal.executecommond("delete_product", param);
            dal.close();
        }

        public DataTable get_image(string id)
        {
            Data_Access.Data_Access_Layer dal = new Data_Access.Data_Access_Layer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_product", SqlDbType.VarChar, 50);
            param[0].Value = id;

            DataTable dt = new DataTable();
            dt = dal.select_data("get_image", param);
            dal.close();
            return dt;



        }

        public void update_product(string ID_product, string LABEL_product, int QTE_product, string PRICE_product, byte[] IMAGE_product, int ID_CAT)
        {
            Data_Access.Data_Access_Layer dal = new Data_Access.Data_Access_Layer();
            dal.open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@ID_product", SqlDbType.VarChar, 50);
            param[0].Value = ID_product;

            param[1] = new SqlParameter("@LABEL_product", SqlDbType.VarChar, 50);
            param[1].Value = LABEL_product;

            param[2] = new SqlParameter("@QTE_product", SqlDbType.Int);
            param[2].Value = QTE_product;

            param[3] = new SqlParameter("@PRICE_product", SqlDbType.VarChar, 50);
            param[3].Value = PRICE_product;

            param[4] = new SqlParameter("@IMAGE_product", SqlDbType.Image);
            param[4].Value = IMAGE_product;

            param[5] = new SqlParameter("@ID_CAT", SqlDbType.Int);
            param[5].Value = ID_CAT;

            dal.executecommond("update_product", param);
            dal.close();

        }
    }
    }
