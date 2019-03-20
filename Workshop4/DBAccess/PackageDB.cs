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

    /*
    * Term 2 Threaded Project 
    * Author : Mahda Kazemian
    * Date : March 19,2019
    * Course Name : Threaded Project for OOSD
    * Module : PROJ-207-OOSD
    * Purpose :to get the packageid from sql and 
    * dispaly information related to that package.
    * also do Add,Modify,Delete and update function in order to change the packages.
    */
    public static class PackageDB
    {

        public static Package GetPackage(int packageId)
        {

            Package package = null;
            SqlConnection connection = TravelExpertsDB.GetConnection();// create the connection

            // create a  command string
            string selectQuery = "SELECT PackageId, PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission " + 
                "FROM Packages " + 
                "WHERE PackageId = @PackageId";


            // connect to the database and execute the command
            SqlCommand cmd = new SqlCommand(selectQuery, connection);
            //define the command's object value
            cmd.Parameters.AddWithValue("@PackageId", packageId);
            try
            {
                connection.Open();// open connection
                //read one row from database with the specific value
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
                if (reader.Read()) // we have a package
                {
                    //create the Package array
                    package = new Package();
                    package.PackageId = (int)reader["PackageId"];
                    package.PkgName = reader["PkgName"].ToString();
                    package.PkgStartDate = Convert.ToDateTime(reader["PkgStartDate"]);
                    package.PkgEndDate = Convert.ToDateTime(reader["PkgEndDate"]);
                    package.PkgDesc = reader["PkgDesc"].ToString();
                    package.PkgBasePrice = (decimal)reader["PkgBasePrice"];
                    package.PkgAgencyCommission = (decimal)reader["PkgAgencyCommission"];

                }// end of if
            }// end of try
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();//close connection
            }
            return package;

        }// end of GetPackage

        // Add function to add/insert a package in database
        public static int AddPackage(Package pack)
        {
            int packID = 0;
            SqlConnection con = TravelExpertsDB.GetConnection();
            string insertStatement = "INSERT INTO Packages (PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission) " +
                                     "VALUES(@PkgName, @PkgStartDate, @PkgEndDate, @PkgDesc, @PkgBasePrice, @PkgAgencyCommission)";
            SqlCommand cmd = new SqlCommand(insertStatement, con);
            cmd.Parameters.AddWithValue("@PkgName", pack.PkgName);
            cmd.Parameters.AddWithValue("@PkgStartDate", pack.PkgStartDate);
            cmd.Parameters.AddWithValue("@PkgEndDate", pack.PkgEndDate);
            cmd.Parameters.AddWithValue("@PkgDesc", pack.PkgDesc);
            cmd.Parameters.AddWithValue("@PkgBasePrice", pack.PkgBasePrice);
            cmd.Parameters.AddWithValue("@PkgAgencyCommission", pack.PkgAgencyCommission);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                string selectQuery = "SELECT IDENT_CURRENT('Packages') FROM Packages"; // identity value
                SqlCommand selectCommand = new SqlCommand(selectQuery, con);
                packID = Convert.ToInt32(selectCommand.ExecuteScalar()); // single value
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return packID;
        }


        //update function 
        public static bool UpdatePackage(Package oldPackage, Package newPackage)
        {
            bool success = true;
            SqlConnection con = TravelExpertsDB.GetConnection();
            string updateStatement = "UPDATE Packages SET " +
                                     "PkgName = @NewPkgName, " +
                                     "PkgStartDate = @NewPkgStartDate, " +
                                     "PkgEndDate = @NewPkgEndDate, " +
                                     "PkgDesc = @NewPkgDesc, " +
                                     "PkgBasePrice = @NewPkgBasePrice, " +
                                     "PkgAgencyCommission = @NewPkgAgencyCommission "+
                                     "WHERE PackageId = @OldPackageId " + // to identify record to update
                                     "AND PkgName = @OldPkgName " + // remaining conditions for optimistic concurrency
                                     "AND PkgStartDate = @OldPkgStartDate " +
                                     "AND PkgEndDate = @OldPkgEndDate " +
                                     "AND PkgDesc = @OldPkgDesc " +
                                     "AND PkgBasePrice = @OldPkgBasePrice " +
                                     "AND PkgAgencyCommission = @OldPkgAgencyCommission ";

            SqlCommand cmd = new SqlCommand(updateStatement, con);

            cmd.Parameters.AddWithValue("@NewPkgName", newPackage.PkgName);
            cmd.Parameters.AddWithValue("@NewPkgStartDate", newPackage.PkgStartDate);
            cmd.Parameters.AddWithValue("@NewPkgEndDate", newPackage.PkgEndDate);
            cmd.Parameters.AddWithValue("@NewPkgDesc", newPackage.PkgDesc);
            cmd.Parameters.AddWithValue("@NewPkgBasePrice", newPackage.PkgBasePrice);
            cmd.Parameters.AddWithValue("@NewPkgAgencyCommission", newPackage.PkgAgencyCommission);

            cmd.Parameters.AddWithValue("@OldPackageId", oldPackage.PackageId);

            cmd.Parameters.AddWithValue("@OldPkgName", oldPackage.PkgName);
            cmd.Parameters.AddWithValue("@OldPkgStartDate", oldPackage.PkgStartDate);
            cmd.Parameters.AddWithValue("@OldPkgEndDate", oldPackage.PkgEndDate);
            cmd.Parameters.AddWithValue("@OldPkgDesc", oldPackage.PkgDesc);
            cmd.Parameters.AddWithValue("@OldPkgBasePrice", oldPackage.PkgBasePrice);
            cmd.Parameters.AddWithValue("@OldPkgAgencyCommission", oldPackage.PkgAgencyCommission);

            try
            {
                con.Open();
                int rowsUpdated = cmd.ExecuteNonQuery();
                if (rowsUpdated == 0) success = false; // did not update (another user updated or deleted)
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

            return success;
        }

        // Delete function to delete a package from database
        public static bool DeletePackage(Package package)
        {
            bool success = true;
            SqlConnection con = TravelExpertsDB.GetConnection();
            string deleteStatement = "DELETE FROM Packages " +
                                    "WHERE PackageId = @PackageId " + // to identify record
                                    "AND PkgName = @PkgName " + // remaining: for optimistic concurrency
                                    "AND PkgStartDate = @PkgStartDate " +
                                    "AND PkgEndDate = @PkgEndDate " +
                                    "AND PkgDesc = @PkgDesc " +
                                    "AND PkgBasePrice = @PkgBasePrice " +
                                    "AND PkgAgencyCommission = @PkgAgencyCommission";

            SqlCommand cmd = new SqlCommand(deleteStatement, con);

            cmd.Parameters.AddWithValue("@PackageId", package.PackageId);
            cmd.Parameters.AddWithValue("@PkgName", package.PkgName);
            cmd.Parameters.AddWithValue("@PkgStartDate", package.PkgStartDate);
            cmd.Parameters.AddWithValue("@PkgEndDate", package.PkgEndDate);
            cmd.Parameters.AddWithValue("@PkgDesc", package.PkgDesc);
            cmd.Parameters.AddWithValue("@PkgBasePrice", package.PkgBasePrice);
            cmd.Parameters.AddWithValue("@PkgAgencyCommission", package.PkgAgencyCommission);

            try
            {
                con.Open();
                int count = cmd.ExecuteNonQuery();
                if (count == 0) // optimistic concurrency violation
                    success = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

            return success;
        }





    }// end of PackageDB class
}// end of namespace
