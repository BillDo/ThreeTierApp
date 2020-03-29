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

    public class PatientSignDA
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ToString());

        public int AddPatientSignDetails(PatientSignBO ObjBO) // passing Bussiness object Here 
        {
            try
            {
                /* Because We will put all out values from our (UserRegistration.aspx) cont....
                 To in Bussiness object and then Pass it to Bussiness logic and then to DataAcess
                 this way the flow carry on*/

                SqlCommand cmd = new SqlCommand("PatientSigninsertupdatedelete", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", ObjBO.Id);
                cmd.Parameters.AddWithValue("@patient_id", ObjBO.PatientId);
                cmd.Parameters.AddWithValue("@fever", ObjBO.Fever);
                cmd.Parameters.AddWithValue("@cough", ObjBO.Cough);
                cmd.Parameters.AddWithValue("@shortness_inBreath", ObjBO.ShortnessInBreath);
                cmd.Parameters.AddWithValue("@pneumonia", ObjBO.Pneumonia);
                cmd.Parameters.AddWithValue("@store_throat", ObjBO.StoreThroat);
                cmd.Parameters.AddWithValue("@tired", ObjBO.Tired);
                cmd.Parameters.AddWithValue("@status", ObjBO.Status);
                cmd.Parameters.AddWithValue("@created_by", ObjBO.CreatedBy);
                cmd.Parameters.AddWithValue("@created_at", Utilities.ConvertHelper.ToDateTime(ObjBO.CreatedAt));
                cmd.Parameters.AddWithValue("@modified_by", ObjBO.ModifiedBy);
                cmd.Parameters.AddWithValue("@modified_at", Utilities.ConvertHelper.ToDateTime(ObjBO.ModifiedAt));
                cmd.Parameters.AddWithValue("@StatementType", AppConstants.Insert);
                con.Open();
                int Result = cmd.ExecuteNonQuery();
                cmd.Dispose();
                return Result;                
            }
            catch (Exception ex)
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
