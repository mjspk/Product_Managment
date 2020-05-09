using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Product_Managment.Data_Access
{

    class Data_Access_Layer
    {
        SqlConnection sqlconnection;

        public Data_Access_Layer()
        {
            if (Properties.Settings.Default.mode == "SQL")
            {
                sqlconnection = new SqlConnection(@"Server =" + Properties.Settings.Default.server + "; DataBase= " + Properties.Settings.Default.database + " ; Integrated Security=false ; User Id= " + Properties.Settings.Default.user_id + ";Password=" + Properties.Settings.Default.password + "");

            }
            else
            {
                sqlconnection = new SqlConnection(@"Server ="+Properties.Settings.Default.server+ "; DataBase= " + Properties.Settings.Default.database + " ; Integrated Security=true; ");

            }
        }

        public void open()
        {
            if(sqlconnection.State!= ConnectionState.Open)
            {
                sqlconnection.Open();

            }
        }


       public void close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();

            }
        }

        public DataTable select_data(string stored_procedures, SqlParameter[] param)
        {
           
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = stored_procedures;
                sqlcmd.Connection = sqlconnection;

                if (param != null)
                {

                    sqlcmd.Parameters.AddRange(param);


                }
                SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
        
            
           

        }

        public void executecommond(string stored_procedures, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedures;
            sqlcmd.Connection = sqlconnection;
            if (param != null)
            {

                sqlcmd.Parameters.AddRange(param);


            }

            sqlcmd.ExecuteNonQuery();
        }





        }

    
}

