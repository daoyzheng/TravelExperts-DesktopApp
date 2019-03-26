/***************************************************************************************
* 
* Author: Tim Leslie
* Date: March 25, 2019.
* Course: CPRG 217 Rapid OOSD Threaded Project
* Assignment: Workshop 4
* Purpose: This is a Supplier database class definition and forms part of the CPRG 214
* Threaded Project Workshop 4. This class contains several public static methods
* which allow manipulation of the Suppliers table and Supplier entity class.
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
    public class SupplierDB
    {
        // Method to return a Supplier object for the given supplierid.
        public static Supplier GetSupplier(int supplierid)
        {
            Supplier supplier = null;

            SqlConnection conn = TravelExpertsDB.GetConnection();

            // create a sql select statement
            string selectStatement =
                "SELECT SupplierId, SupName " +
                "FROM Suppliers " +
                "WHERE SupplierId = @SupplierId";

            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);

            selectCommand.Parameters.AddWithValue("@SupplierId", supplierid);
            try
            {
                conn.Open();// open connection

                SqlDataReader sr = selectCommand.ExecuteReader(CommandBehavior.SingleRow);

                if (sr.Read()) // product record exists
                {
                    supplier = new Supplier();
                    supplier.SupplierId = (int)sr["SupplierId"];
                    supplier.SupName = sr["SupName"].ToString();
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
            return supplier;
        }

        // Method to add a new product to the Suppliers table of Travel Experts
        // and return the auto-generated SupplierId.
        public static int AddSupplier(Supplier supplier)
        {
            int supplierid = 0;

            SqlConnection conn = TravelExpertsDB.GetConnection();

            string insertStatement = "INSERT INTO Suppliers (SupName) " +
                                     "VALUES(@SupName)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, conn);

            insertCommand.Parameters.AddWithValue("@SupName", supplier.SupName);

            try
            {
                conn.Open();

                insertCommand.ExecuteNonQuery();

                string selectStatement = "SELECT IDENT_CURRENT('SupplierId') FROM Suppliers"; // extract the SupplierId for the newly added product
                SqlCommand selectCommand = new SqlCommand(selectStatement, conn);
                supplierid = Convert.ToInt32(selectCommand.ExecuteScalar()); // execute the sql command expecting the single id result
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return supplierid;
        }

        // Method to update an existing Supplier record in the database.
        // This method compares the 'old' product which was 'SELECT'ed 
        // originally against the product record at the time of 'UPDATE'ing
        // to ensure that no chnages have occurred. In other words, this is
        // a concurrency check prior to updating the record.
        public static bool UpdateSupplier(Supplier oldSupplier, Supplier newSupplier)
        {
            bool success = true;

            SqlConnection conn = TravelExpertsDB.GetConnection();

            string updateStatement = "UPDATE Suppliers SET " +
                                     "SupName = @NewSupName, " +
                                     "WHERE SupplierId = @OldSupplierId " + // to identify record to update
                                     "AND SupName = @OldSupName";

            SqlCommand updateCommand = new SqlCommand(updateStatement, conn);

            updateCommand.Parameters.AddWithValue("@NewSupName", newSupplier.SupName);
            updateCommand.Parameters.AddWithValue("@OldSupplierId", oldSupplier.SupplierId);
            updateCommand.Parameters.AddWithValue("@OldSupName", oldSupplier.SupName);

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
        public static bool DeleteSupplier(Supplier supplier)
        {
            bool success = true;
            SqlConnection conn = TravelExpertsDB.GetConnection();

            string deleteStatement = "DELETE FROM Suppliers " +
                                     "WHERE SupplierId = @SupplierId " +
                                     "AND SupName = @SupName";

            SqlCommand deleteCommand = new SqlCommand(deleteStatement, conn);

            deleteCommand.Parameters.AddWithValue("@SupplierId", supplier.SupplierId);
            deleteCommand.Parameters.AddWithValue("@SupName", supplier.SupName);

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
