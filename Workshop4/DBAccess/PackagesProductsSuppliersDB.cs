/***************************************************************************************
* 
* Author: Tim Leslie
* Date: March 25, 2019.
* Course: CPRG 217 Rapid OOSD Threaded Project
* Assignment: Workshop 4
* Purpose: This is a PackagesProductsSuppliers database class definition and forms part of the CPRG 214
* Threaded Project Workshop 4. This class contains several public static methods
* which allow manipulation of the PackagesProductsPackagesProductsSupplierss table and the
* PackagesProductsPackagesProductsSupplierss entity class.
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
    public class PackagesProductsSuppliersDB
    {
        // Method to return a list of  all PackagesProductsSuppliers objects 
        public static List<PackagesProductsSuppliers> GetAllPackagesProductsSuppliers()
        {
            List<PackagesProductsSuppliers> packagesProductsSuppliers = new List<PackagesProductsSuppliers>();
            SqlConnection conn = TravelExpertsDB.GetConnection();

            // create a sql select statement
            string selectStatement =
                "SELECT PackageId, ProductSupplierId " +
                "FROM Packages_Products_Suppliers ";

            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);

            try
            {
                conn.Open();// open connection

                SqlDataReader sr = selectCommand.ExecuteReader();

                while (sr.Read()) // product record exists
                {
                    PackagesProductsSuppliers pps = new PackagesProductsSuppliers();
                    pps.PackageId = (int)sr["PackageId"];
                    pps.ProductSupplierId = (int)sr["ProductSupplierId"];

                    packagesProductsSuppliers.Add(pps);
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
            return packagesProductsSuppliers;
        }

        // Method to return a list of PackagesProductsSuppliers objects for the given PackagesProductsSuppliersid.
        public static List<PackagesProductsSuppliers> GetPackagesProductsSuppliers(int ppsid)
        {
            List<PackagesProductsSuppliers> packagesProductsSuppliers = new List<PackagesProductsSuppliers>();
            SqlConnection conn = TravelExpertsDB.GetConnection();

            // create a sql select statement
            string selectStatement =
                "SELECT PackageId, ProductSupplierId " +
                "FROM Packages_Products_Suppliers " +
                "WHERE PackageId = @PackageId";

            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);

            selectCommand.Parameters.AddWithValue("@PackageId", ppsid);
            try
            {
                conn.Open();// open connection

                SqlDataReader sr = selectCommand.ExecuteReader();

                while (sr.Read()) // product record exists
                {
                    PackagesProductsSuppliers pps = new PackagesProductsSuppliers();
                    pps.PackageId = (int)sr["PackageId"];
                    pps.ProductSupplierId = (int)sr["ProductSupplierId"];

                    packagesProductsSuppliers.Add(pps);
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
            return packagesProductsSuppliers;
        }

        // Method to add a new product to the PackagesProductsSupplierss table of Travel Experts
        // and return the auto-generated PackagesProductsSuppliersId.
        public static int AddPackagesProductsSuppliers(PackagesProductsSuppliers pps)
        {
            int ppsid = 0;

            SqlConnection conn = TravelExpertsDB.GetConnection();

            string insertStatement = "INSERT INTO PackagesProductsSuppliers (ProductSupplierId) " +
                                        "VALUES(@ProductSupplierId)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, conn);

            insertCommand.Parameters.AddWithValue("@ProductSupplierId", pps.ProductSupplierId);

            try
            {
                conn.Open();

                insertCommand.ExecuteNonQuery();

                string selectStatement = "SELECT IDENT_CURRENT('PackageId') FROM PackagesProductsSuppliers"; // extract the PackagesProductsSuppliersId for the newly added product
                SqlCommand selectCommand = new SqlCommand(selectStatement, conn);
                pps.PackageId = Convert.ToInt32(selectCommand.ExecuteScalar()); // execute the sql command expecting the single id result
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return ppsid;
        }

        // Method to update an existing PackagesProductsSuppliers record in the database.
        // This method compares the 'old' product which was 'SELECT'ed 
        // originally against the product record at the time of 'UPDATE'ing
        // to ensure that no chnages have occurred. In other words, this is
        // a concurrency check prior to updating the record.
        public static bool UpdatePackagesProductsSuppliers(PackagesProductsSuppliers oldPPS, PackagesProductsSuppliers newPPS)
        {
            bool success = true;

            SqlConnection conn = TravelExpertsDB.GetConnection();

            string updateStatement = "UPDATE PackagesProductsSupplierss SET " +
                                        "ProductSupplierId = @NewProductSupplierId, " +
                                        "WHERE PackageId = @OldPackageId " + // to identify record to update
                                        "AND ProductSupplierId = @OldProductSupplierId";

            SqlCommand updateCommand = new SqlCommand(updateStatement, conn);

            updateCommand.Parameters.AddWithValue("@NewProductSupplierId", newPPS.ProductSupplierId);
            updateCommand.Parameters.AddWithValue("@OldPackageId", oldPPS.PackageId);
            updateCommand.Parameters.AddWithValue("@OldProductSupplierId", oldPPS.ProductSupplierId);

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
        public static bool DeletePackagesProductsSuppliers(PackagesProductsSuppliers pps)
        {
            bool success = true;
            SqlConnection conn = TravelExpertsDB.GetConnection();

            string deleteStatement = "DELETE FROM PackagesProductsSuppliers " +
                                        "WHERE PackageId = @PackageId " +
                                        "AND ProductSupplierId = @ProductSupplierId";

            SqlCommand deleteCommand = new SqlCommand(deleteStatement, conn);

            deleteCommand.Parameters.AddWithValue("@PackageId", pps.PackageId);
            deleteCommand.Parameters.AddWithValue("@ProductSupplierId", pps.ProductSupplierId);

            try
            {
                conn.Open();
                int count = deleteCommand.ExecuteNonQuery();
                if (count == 0)
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
