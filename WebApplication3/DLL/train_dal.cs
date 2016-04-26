using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BO;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;




namespace DAL
{
    public class train_dal
    {
        public int inserttrain(train_bo obj1)
        {
            string connectionString = "Data Source= ingnrilpsql02; Initial Catalog = A104; User ID=a36; Password= a36";

            //string query = "insert into train_75 values('" + obj1.name + "'," + obj1.no + ")";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("sp_addtrain", connection);
            
            //SqlCommand cmd = new SqlCommand(query, connection);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@train_name", obj1.name);
            cmd.Parameters.AddWithValue("@train_no", obj1.no);

           
            connection.Open();
            int result = cmd.ExecuteNonQuery();
            connection.Close();
            return 0;
        }





        public DataTable showtrains(train_bo tbo)
        {
            string connectionString = "Data Source= ingnrilpsql02; Initial Catalog = A104; User ID=a36; Password= a36";
            //string query = "select * from train_75 where sr_no like "+tbo.no+"";
            string query1 = "select * from train_75 where train_name like '%" + tbo.name + "%'";
            SqlConnection connection = new SqlConnection(connectionString);
            //SqlCommand cmd1 = new SqlCommand(query, connection);
            SqlCommand cmd2 = new SqlCommand(query1, connection);
            DataTable dt = new DataTable();
            //SqlDataAdapter mySqlAdapter = new SqlDataAdapter(cmd1);
            SqlDataAdapter mySqlAdapter = new SqlDataAdapter(cmd2);
            mySqlAdapter.Fill(dt);
            return dt;

        }

        public int delete(train_bo del)
        {
           
            string connectionString = "Data Source= ingnrilpsql02; Initial Catalog = A104; User ID=a36; Password= a36";
            //string query = "delete from train_75 where sr_no = "+del.no+"";

            string query = "delete from train_75 where train_name like '" + del.name + "'";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd1 = new SqlCommand(query, connection);
            
            
            connection.Open();
            int r=cmd1.ExecuteNonQuery();
            connection.Close();
            return r;
        }
    }
}


