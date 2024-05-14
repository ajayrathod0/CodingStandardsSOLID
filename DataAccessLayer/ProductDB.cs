using Models;
using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class ProductDB : IProductDB
    {
        public bool CreateProduct(Product product)
        {
            bool result = false;
            string cs = ConfigurationManager.ConnectionStrings["B22ASPDB"].ConnectionString;

            SqlConnection con = new SqlConnection(cs);

            // DBConnection conn = DBConnection.Instance;

            try
            {

                SqlCommand cmd = new SqlCommand(SP.uspCreateProduct, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", product.Name);
                cmd.Parameters.AddWithValue("@Price", product.Price);
                cmd.Parameters.AddWithValue("@ImagePath", product.ImagePath);

                SqlParameter status = new SqlParameter()
                {
                    ParameterName = "@Status",
                    Direction = ParameterDirection.Output,
                    SqlDbType = SqlDbType.Bit
                };
                cmd.Parameters.Add(status);
                con.Open();
                cmd.ExecuteNonQuery();

                result = (bool)status.Value;
            }
            catch (Exception ex) { }
            finally
            {

                if (con != null)
                {
                    con.Close();
                }

            }

            return result;
        }

        public bool UpdateProduct(Product product)
        {

            bool result = false;
            string cs = ConfigurationManager.ConnectionStrings["B22ASPDB"].ConnectionString;

            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(SP.uspUpdateProduct, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", product.Id);
            cmd.Parameters.AddWithValue("@Name", product.Name);
            cmd.Parameters.AddWithValue("@Price", product.Price);
            cmd.Parameters.AddWithValue("@ImagePath", product.ImagePath);

            SqlParameter status = new SqlParameter()
            {
                ParameterName = "@Status",
                Direction = ParameterDirection.Output,
                SqlDbType = SqlDbType.Bit,
            };
            cmd.Parameters.Add(status);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            result = (bool)status.Value;
            return result;
        }
    }
}
