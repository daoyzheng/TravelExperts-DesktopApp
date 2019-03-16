using ClassEntites;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccess {
    public static class ProductsSupplierDB {

        // Get A single products supplier from the DB
        public static ProductsSupplier GetProductsSupplierByProductSupplierId(int productSupplierId) {
            ProductsSupplier prodSuppObj = null;
            string selectStatement = "SELECT ProductSupplierId, ProductId, SupplierId " +
                                     "FROM Products_Suppliers " +
                                     "WHERE ProductSupplierId = @productSupplierId";

            // Get connection to Travel Experts DB
            SqlConnection connection = TravelExpertsDB.GetConnection();

            // Create a select command object
            SqlCommand selectCmd = new SqlCommand(selectStatement, connection);

            // Assign value to parameter(s)
            selectCmd.Parameters.AddWithValue("@productSupplierId", productSupplierId);

            // Execute the select command and start the reading process from DB
            try {
                connection.Open();
                SqlDataReader dr = selectCmd.ExecuteReader(CommandBehavior.SingleRow);
                if (dr.Read()) { // if customer exists
                    prodSuppObj = new ProductsSupplier();
                    prodSuppObj.ProductSupplierId = (int)dr["ProductSupplierId"];

                    // Both Product ID and Supplier ID can be null, need to verify while reading
                    // from DB
                    if (dr["ProductId"] is DBNull) {
                        prodSuppObj.ProductId = null; 
                    } else {
                        prodSuppObj.ProductId = (int)dr["ProductId"];
                    }
                    if (dr["SupplierId"] is DBNull) {
                        prodSuppObj.SupplierId = null;
                    } else {
                        prodSuppObj.SupplierId = (int)dr["SupplierId"];
                    }
                }
            } catch (Exception ex) {
                throw ex;
            } finally {
                connection.Close();
            }

            return prodSuppObj;
        }
        
        // Get All products suppliers from the DB
        public static List<ProductsSupplier> GetAllProductsSuppliers() {
            List<ProductsSupplier> prodSuppList = new List<ProductsSupplier>();
            string selectStatement = "SELECT ProductSupplierId, ProductId, SupplierId " +
                                     "FROM Products_Suppliers " +
                                     "ORDER BY ProductSupplierId";

            // Get connection to Travel Experts DB
            SqlConnection connection = TravelExpertsDB.GetConnection();

            // Create a select command object
            SqlCommand selectCmd = new SqlCommand(selectStatement, connection);

            // Execute the select command and start the reading process from DB
            try {
                connection.Open();
                SqlDataReader dr = selectCmd.ExecuteReader();
                while (dr.Read()) {
                    ProductsSupplier prodSuppObj = new ProductsSupplier();
                    prodSuppObj.ProductSupplierId = (int)dr["ProductSupplierId"];

                    // Both Product ID and Supplier ID can be null, need to verify while reading
                    // from DB
                    if (dr["ProductId"] is DBNull) {
                        prodSuppObj.ProductId = null; 
                    } else {
                        prodSuppObj.ProductId = (int)dr["ProductId"];
                    }
                    if (dr["SupplierId"] is DBNull) {
                        prodSuppObj.SupplierId = null;
                    } else {
                        prodSuppObj.SupplierId = (int)dr["SupplierId"];
                    }

                    // Add to product suppliers list
                    prodSuppList.Add(prodSuppObj);
                }
            } catch (Exception ex) {
                throw ex;
            } finally {
                connection.Close();
            }

            return prodSuppList;
        }

        // Get Product Suppliers by product id
        public static List<ProductsSupplier> GetProductsSupplierByProductId(int productId) {
            List<ProductsSupplier> prodSuppList = new List<ProductsSupplier>();
            string selectStatement = "SELECT ProductSupplierId, ProductId, SupplierId " +
                                     "FROM Products_Suppliers " +
                                     "WHERE ProductId = @productId";

            // Get connection to Travel Experts DB
            SqlConnection connection = TravelExpertsDB.GetConnection();

            // Create a select command object
            SqlCommand selectCmd = new SqlCommand(selectStatement, connection);

            // Assign value to parameter(s)
            selectCmd.Parameters.AddWithValue("@productId", productId);

            // Execute the select command and start the reading process from DB
            try {
                connection.Open();
                SqlDataReader dr = selectCmd.ExecuteReader(CommandBehavior.SingleRow);
                if (dr.Read()) { // if customer exists
                    ProductsSupplier prodSuppObj = new ProductsSupplier();
                    prodSuppObj.ProductSupplierId = (int)dr["ProductSupplierId"];

                    // Both Product ID and Supplier ID can be null, need to verify while reading
                    // from DB
                    if (dr["ProductId"] is DBNull) {
                        prodSuppObj.ProductId = null; 
                    } else {
                        prodSuppObj.ProductId = (int)dr["ProductId"];
                    }
                    if (dr["SupplierId"] is DBNull) {
                        prodSuppObj.SupplierId = null;
                    } else {
                        prodSuppObj.SupplierId = (int)dr["SupplierId"];
                    }
                    prodSuppList.Add(prodSuppObj);
                }
            } catch (Exception ex) {
                throw ex;
            } finally {
                connection.Close();
            }

            return prodSuppList;
        }

        // Get Product Suppliers by supplier id
        public static List<ProductsSupplier> GetProductsSupplierBySupplierId(int supplierId) {
            List<ProductsSupplier> prodSuppList = new List<ProductsSupplier>();
            string selectStatement = "SELECT ProductSupplierId, ProductId, SupplierId " +
                                     "FROM Products_Suppliers " +
                                     "WHERE SupplierId = @supplierId";

            // Get connection to Travel Experts DB
            SqlConnection connection = TravelExpertsDB.GetConnection();

            // Create a select command object
            SqlCommand selectCmd = new SqlCommand(selectStatement, connection);

            // Assign value to parameter(s)
            selectCmd.Parameters.AddWithValue("@supplierId", supplierId);

            // Execute the select command and start the reading process from DB
            try {
                connection.Open();
                SqlDataReader dr = selectCmd.ExecuteReader(CommandBehavior.SingleRow);
                if (dr.Read()) { // if customer exists
                    ProductsSupplier prodSuppObj = new ProductsSupplier();
                    prodSuppObj.ProductSupplierId = (int)dr["ProductSupplierId"];

                    // Both Product ID and Supplier ID can be null, need to verify while reading
                    // from DB
                    if (dr["ProductId"] is DBNull) {
                        prodSuppObj.ProductId = null; 
                    } else {
                        prodSuppObj.ProductId = (int)dr["ProductId"];
                    }
                    if (dr["SupplierId"] is DBNull) {
                        prodSuppObj.SupplierId = null;
                    } else {
                        prodSuppObj.SupplierId = (int)dr["SupplierId"];
                    }
                    prodSuppList.Add(prodSuppObj);
                }
            } catch (Exception ex) {
                throw ex;
            } finally {
                connection.Close();
            }

            return prodSuppList;
        }

        // Insert a new product 
    }
}
