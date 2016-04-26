using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BO_Layer;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DAL_Layer
{
    public class BookDAL
    {
        public int insertBook(Book bObject)
        {
            string connectionString = "Data Source= ingnrilpsql02; Initial Catalog = A81; User ID=a36; Password= a36";
            //string query = "insert into Book_399730 values('" + bObject.name + "'," + bObject.cost + "," + bObject.rating + "," + bObject.fine + ")";
            
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("sp_addBook", connection);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@bkName", bObject.name);
            cmd.Parameters.AddWithValue("@bkCost", bObject.cost);
            cmd.Parameters.AddWithValue("@bkFine", bObject.fine);
            cmd.Parameters.AddWithValue("@bkRating", bObject.rating);

            SqlParameter param = new SqlParameter("@BookID", System.Data.SqlDbType.Int);
            param.Direction = System.Data.ParameterDirection.Output;
            cmd.Parameters.Add(param);

            connection.Open();
            int result = cmd.ExecuteNonQuery();
            connection.Close();

            return (int)param.Value;

        }
    }
}
