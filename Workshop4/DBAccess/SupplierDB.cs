﻿/***************************************************************************************
* 
* Author: Tim Leslie
* Date: March 25, 2019.
* Course: CPRG 217  OOSD Threaded Project
* Assignment: Workshop 4
* Purpose: This is a Supplier database class definition and forms part of the CPRG 217
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
        public static List<Supplier> GetSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();

            SqlConnection conn = TravelExpertsDB.GetConnection();

            // create a sql select statement
            string selectStatement =
                "SELECT SupplierId, SupName " +
                "FROM Suppliers";

            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);

            try
            {
                conn.Open();// open connection

                SqlDataReader sr = selectCommand.ExecuteReader();

                while (sr.Read()) // product record exists
                {
                    Supplier supplier = new Supplier();
                    supplier.SupplierId = (int)sr["SupplierId"];
                    supplier.SupName = sr["SupName"].ToString();
                    suppliers.Add(supplier);
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
            return suppliers;
        }
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

        public static int FindIndexofId(List<Supplier> suppliers, int id)
        {
            int tmpIndex = 0;
            for (int i = 0; i < suppliers.Count; i++)
            {
                if (suppliers[i].SupplierId == id)
                    tmpIndex = i;
            }
            return tmpIndex;
        }


        // Method to add a new product to the Suppliers table of Travel Experts
        // and return the auto-generated SupplierId.
        public static bool AddSupplier(Supplier supplier)
        {
            bool success = true;

            SqlConnection conn = TravelExpertsDB.GetConnection();

            string insertStatement = "INSERT INTO Suppliers (SupplierId, SupName) " +
                                     "VALUES(@SupplierId, @SupName)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, conn);

            insertCommand.Parameters.AddWithValue("@SupplierId", supplier.SupplierId);
            insertCommand.Parameters.AddWithValue("@SupName", supplier.SupName);

            try
            {
                conn.Open();

                insertCommand.ExecuteNonQuery();

                //string selectStatement = "SELECT IDENT_CURRENT('SupplierId') FROM Suppliers"; // extract the SupplierId for the newly added product
                //SqlCommand selectCommand = new SqlCommand(selectStatement, conn);
                //supplierid = Convert.ToInt32(selectCommand.ExecuteScalar()); // execute the sql command expecting the single id result
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

        // Method to update an existing Supplier record in the database.
        // This method compares the 'old' product which was 'SELECT'ed 
        // originally against the product record at the time of 'UPDATE'ing
        // to ensure that no changes have occurred. In other words, this is
        // a concurrency check prior to updating the record.
        public static bool UpdateSupplier(Supplier oldSupplier, Supplier newSupplier)
        {
            bool success = true;

            SqlConnection conn = TravelExpertsDB.GetConnection();

            string updateStatement = "UPDATE Suppliers SET " +
                                     "SupName = @NewSupName " +
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

            // Delete SupplierContacts record for the supplier first
            if (IsInSupplierContacts(supplier))
                DeleteSupplierContacts(supplier);            

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

        private static bool IsInSupplierContacts(Supplier supplier)
        {
            bool result = false;

            List<SupplierContact> suppliercontacts = new List<SupplierContact>();
            suppliercontacts = GetSupplierContacts();

            foreach(SupplierContact suppliercontact in suppliercontacts)
            {
                if (suppliercontact.SupplierId == supplier.SupplierId)
                    result = true;
            }
            return result;
        }

        private static List<SupplierContact> GetSupplierContacts()
        {
            List<SupplierContact> suppliercontacts = new List<SupplierContact>();

            SqlConnection conn = TravelExpertsDB.GetConnection();

            // create a sql select statement
            string selectStatement =
                "SELECT SupplierContactId, SupplierId " +
                "FROM SupplierContacts";

            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);

            try
            {
                conn.Open();// open connection

                SqlDataReader sr = selectCommand.ExecuteReader();

                while (sr.Read()) // product record exists
                {
                    SupplierContact suppliercontact = new SupplierContact();
                    suppliercontact.SupplierContactId = (int)sr["SupplierContactId"];
                    suppliercontact.SupplierId = (int)sr["SupplierId"];
                    suppliercontacts.Add(suppliercontact);
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
            return suppliercontacts;
        }

        public static bool DeleteSupplierContacts(Supplier supplier)
        {
            bool success = true;
            SqlConnection conn = TravelExpertsDB.GetConnection();

            string deleteStatement = "DELETE FROM SupplierContacts " +
                                     "WHERE SupplierId = @SupplierId";

            SqlCommand deleteCommand = new SqlCommand(deleteStatement, conn);

            deleteCommand.Parameters.AddWithValue("@SupplierId", supplier.SupplierId);

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
        public static bool IsInProductsSuppliers(Supplier supplier)
        {
            bool result = false;
            List<ProductsSupplier> prodSuppliers = ProductsSupplierDB.GetAllProductsSuppliers();

            foreach (ProductsSupplier ps in prodSuppliers)
            {
                if (ps.SupplierId == supplier.SupplierId)
                    result = true;
            }
            return result;
        }

        public static int FindMaxSupplierId(List<Supplier> suppliers)            
        {
            int maxId = 0;
            foreach (Supplier supplier in suppliers)
            {
                if (supplier.SupplierId > maxId)
                    maxId = supplier.SupplierId;
            }
            return maxId;
        }
    }
}
