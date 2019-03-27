/***************************************************************************************
* 
* Author: Tim Leslie
* Date: March 25, 2019.
* Course: CPRG 217 Rapid OOSD Threaded Project
* Assignment: Workshop 4
* Purpose: This is a Product database class definition and forms part of the CPRG 214
* Threaded Project Workshop 4. This class contains several public static methods
* which allow manipulation of the Products table and Product entity class.
* 
****************************************************************************************/
using ClassEntites;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccess
{
    public class ProductDB
    {
        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();

            SqlConnection conn = TravelExpertsDB.GetConnection();

            // create a sql select statement
            string selectStatement =
                "SELECT ProductId, ProdName " +
                "FROM Products";

            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);

            try
            {
                conn.Open();// open connection

                SqlDataReader sr = selectCommand.ExecuteReader();

                while (sr.Read()) // product record exists
                {
                    Product product = new Product();
                    product.ProductId = (int)sr["ProductId"];
                    product.ProdName = sr["ProdName"].ToString();
                    products.Add(product);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return products;
        }
        // Method to return a Product object for the given productId.
        public static Product GetProduct(int productid)
        {
            Product product = null;

            SqlConnection conn = TravelExpertsDB.GetConnection();

            // create a sql select statement
            string selectStatement = 
                "SELECT ProductId, ProdName " +
                "FROM Products " +
                "WHERE ProductId = @ProductId";

            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);

            selectCommand.Parameters.AddWithValue("@ProductId", productid);
            try
            {
                conn.Open();// open connection

                SqlDataReader pr = selectCommand.ExecuteReader(CommandBehavior.SingleRow);

                if (pr.Read()) // product record exists
                {
                    product = new Product();
                    product.ProductId = (int)pr["ProductId"];
                    product.ProdName = pr["ProdName"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return product;
        }

        // Method to add a new product to the Products table of Travel Experts
        // and return the auto-generated ProductId.
        public static int AddProduct(Product product)
        {
            int productid = 0;

            SqlConnection conn = TravelExpertsDB.GetConnection();

            string insertStatement = "INSERT INTO Products (ProdName) " +
                                     "VALUES(@ProdName)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, conn);

            insertCommand.Parameters.AddWithValue("@ProdName", product.ProdName);

            try
            {
                conn.Open();

                insertCommand.ExecuteNonQuery();

                string selectStatement = "SELECT IDENT_CURRENT('ProductId') FROM Products"; // extract the ProductId for the newly added product
                SqlCommand selectCommand = new SqlCommand(selectStatement, conn);
                productid = Convert.ToInt32(selectCommand.ExecuteScalar()); // execute the sql command expecting the single id result
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return productid;
        }

        // Method to update an existing Product record in the database.
        // This method compares the 'old' product which was 'SELECT'ed 
        // originally against the product record at the time of 'UPDATE'ing
        // to ensure that no chnages have occurred. In other words, this is
        // a concurrency check prior to updating the record.
        public static bool UpdateProduct(Product oldProduct, Product newProduct)
        {
            bool success = true;

            SqlConnection conn = TravelExpertsDB.GetConnection();

            string updateStatement = "UPDATE Products SET " +
                                     "ProdName = @NewProdName, " +
                                     "WHERE ProductId = @OldProductId " + // to identify record to update
                                     "AND ProdName = @OldProdName"; 

            SqlCommand updateCommand = new SqlCommand(updateStatement, conn);

            updateCommand.Parameters.AddWithValue("@NewProdName", newProduct.ProdName);
            updateCommand.Parameters.AddWithValue("@OldProductId", oldProduct.ProductId);
            updateCommand.Parameters.AddWithValue("@OldProdName", oldProduct.ProdName);

            try
            {
                conn.Open();
                int rowsUpdated = updateCommand.ExecuteNonQuery();
                if (rowsUpdated == 0) success = false; // did not update (another user updated or deleted)
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return success;
        }
        public static bool DeleteProduct(Product product)
        {
            bool success = true;
            SqlConnection conn = TravelExpertsDB.GetConnection();

            string deleteStatement = "DELETE FROM Products " +
                                     "WHERE ProductId = @ProductId " +
                                     "AND ProdName = @ProdName";

            SqlCommand deleteCommand = new SqlCommand(deleteStatement, conn);

            deleteCommand.Parameters.AddWithValue("@ProductId", product.ProductId);
            deleteCommand.Parameters.AddWithValue("@ProdName", product.ProdName);

            try
            {
                conn.Open();
                int count = deleteCommand.ExecuteNonQuery();
                if (count == 0) // optimistic concurrency violation
                    success = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return success;
        }
    }
}
