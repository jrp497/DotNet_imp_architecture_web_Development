using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using BO_Layer;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DAL_Layer
{
    public class movieDAL
    {
        public void insertmovie(movie m)
        {
            string connectionstring = "Data Source= ingnrilpsql02; Initial Catalog = A104; User ID=a36; Password= a36";
            string query = "insert into Movie_747846 values('" + m.name + "'," + m.budget + "," + m.share + ")";
            SqlConnection connection= new SqlConnection(connectionstring);
            SqlCommand comm = new SqlCommand(query,connection);
            connection.Open();
            //int result = 
            comm.ExecuteNonQuery();
            connection.Close();
           // return result;
        }
        public DataTable search(movie m)
        {
            string connectionstring = "Data Source= ingnrilpsql02; Initial Catalog = A104; User ID=a36; Password= a36";
            string query = "select Movie_Name,Movie_Budget,Movie_Share,Mov_Id from Movie_747846 where Movie_Name = '"+m.movname+"'";
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand comm = new SqlCommand(query, connection);
            SqlDataAdapter adap = new SqlDataAdapter(comm);
            //adap.SelectCommand = comm;
            DataTable dt = new DataTable();
            adap.Fill(dt);
            return dt;
            //connection.Open();
            //int result=comm.ExecuteNonQuery();
            //connection.Close();
          }
        public int del(movie m)
        {
            string connectionstring = "Data Source= ingnrilpsql02; Initial Catalog = A104; User ID=a36; Password= a36";
            string query = "delete from Movie_747846 where Mov_ID = "+m.id+"";
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand comm = new SqlCommand(query, connection);
            connection.Open();
            int result = comm.ExecuteNonQuery();
            connection.Close();
            return result;
        }
        public int update(movie m)
        {
            string connectionstring = "Data Source= ingnrilpsql02; Initial Catalog = A104; User ID=a36; Password= a36";
            string query = "update Movie_747846  set Movie_Name='" + m.name + "' where Mov_ID = " + m.id + "";
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand comm = new SqlCommand(query, connection);
            connection.Open();
            int result = comm.ExecuteNonQuery();
            connection.Close();
            return result;
        }
        public int procedure(movie m)
        {
            string connectionstring = "Data Source= ingnrilpsql02; Initial Catalog = A104; User ID=a36; Password= a36";
            string query = "sp_movie";
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand comm = new SqlCommand(query, connection);
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@id", m.id);
            comm.Parameters.AddWithValue("@share", m.sharepart);
            connection.Open();
            int result = comm.ExecuteNonQuery();
            connection.Close();
            return result;
        }
        public void view(movie m)
        {
            string connectionstring = "Data Source= ingnrilpsql02; Initial Catalog = A104; User ID=a36; Password= a36";
            string query = "select Movie_Name from Movie_747846";
            SqlConnection connection = new SqlConnection(connectionstring);
            SqlCommand comm = new SqlCommand(query, connection);
            ArrayList list = new ArrayList();
            list.Add(comm);

        }
    }
}
