using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace login1.BL
{
    class CLS_LOGIN
    {
        public DataTable LOGIN(string USER_ID, string PWD)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = USER_ID;

            param[1] = new SqlParameter("@PWD", SqlDbType.NVarChar, 50);
            param[1].Value = PWD;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("SP_LOGIN", param);

            DAL.Close();
            return DT;


        }

        public void ADD_USER(string USER_ID, string FullName, string PWD, string UserType)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("USER_ID", SqlDbType.NVarChar, 50);
            param[0].Value = USER_ID;

            param[1] = new SqlParameter("FullName", SqlDbType.NVarChar, 50);
            param[1].Value = FullName;


            param[2] = new SqlParameter("PWD", SqlDbType.NVarChar, 50);
            param[2].Value = PWD;


            param[3] = new SqlParameter("UserType", SqlDbType.NVarChar, 50);
            param[3].Value = UserType;

            DAL.ExecuteCommand("ADD_USER", param);
            DAL.Close();

             }
        public void user_author(bool del)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("del", SqlDbType.NVarChar, 50);
            param[0].Value = del;
            DAL.ExecuteCommand("user_author", param);
            DAL.Close();
        }

        public void EDIT_USER(string USER_ID, string FullName, string PWD, string UserType)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("USER_ID", SqlDbType.NVarChar, 50);
            param[0].Value = USER_ID;

            param[1] = new SqlParameter("FullName", SqlDbType.NVarChar, 50);
            param[1].Value = FullName;


            param[2] = new SqlParameter("PWD", SqlDbType.NVarChar, 50);
            param[2].Value = PWD;


            param[3] = new SqlParameter("UserType", SqlDbType.NVarChar, 50);
            param[3].Value = UserType;

            DAL.ExecuteCommand("EDIT_USER", param);
            DAL.Close();

        }
        public DataTable user_author(string USER_ID,String uni)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@uni_id", SqlDbType.NVarChar, 50);
            param[0].Value = uni;

            param[1] = new SqlParameter("@userid", SqlDbType.NVarChar, 50);
            param[1].Value = USER_ID;

            DT = DAL.SelectData("user_author", param);
            DAL.Close();
            return DT;
           

        }
        public void delete_USER(string USER_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("USER_ID", SqlDbType.NVarChar, 50);
            param[0].Value = USER_ID;

            

            DAL.ExecuteCommand("delete_USER", param);
            DAL.Close();

        }
        public DataTable searchusers(string criterion)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@criterion", SqlDbType.NVarChar, 50);
            param[0].Value = criterion;
            DT = DAL.SelectData("searchusers", param);
            DAL.Close();
            return DT;
        }


    }
}
