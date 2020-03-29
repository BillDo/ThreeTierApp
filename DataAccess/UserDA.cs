using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data; // Required for using Dataset , Datatable and Sql
using System.Data.SqlClient; // Required for Using Sql 
using System.Configuration; // for Using Connection From Web.config
using BussinessObject;  // for acessing bussiness object class
namespace DataAccess
{

    public class UserDA
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ToString());

        public int AddUserDetails(UserBO ObjBO) // passing Bussiness object Here 
        {
            try
            {
                /* Because We will put all out values from our (UserRegistration.aspx) cont....
                 To in Bussiness object and then Pass it to Bussiness logic and then to DataAcess
                 this way the flow carry on*/

                SqlCommand cmd = new SqlCommand("Userinsertupdatedelete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", ObjBO.Name);
                cmd.Parameters.AddWithValue("@user_name", ObjBO.UserName);
                cmd.Parameters.AddWithValue("@password", ObjBO.Password);
                cmd.Parameters.AddWithValue("@name", ObjBO.Name);
                cmd.Parameters.AddWithValue("@email", ObjBO.Email);
                cmd.Parameters.AddWithValue("@mobile", ObjBO.Mobile);
                cmd.Parameters.AddWithValue("@status", ObjBO.Status);
                cmd.Parameters.AddWithValue("@created_by", ObjBO.CreatedBy);
                cmd.Parameters.AddWithValue("@created_at", ObjBO.CreatedAt);
                cmd.Parameters.AddWithValue("@modified_by", ObjBO.ModifiedBy);
                cmd.Parameters.AddWithValue("@modified_at", ObjBO.ModifiedAt);
                cmd.Parameters.AddWithValue("@StatementType", AppConstants.Insert);
                con.Open();
                int Result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                return Result;                
            }
            catch
            {
                throw;
            }
            finally
            {              
                con.Close();
                con.Dispose();
            }
        }
    }
}
