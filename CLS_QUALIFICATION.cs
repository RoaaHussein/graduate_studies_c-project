using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace login1.BL
{
    class Cls_QUALIFICATION
    {
        public DataTable GET_ALL_QUALIFICATION()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();


            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_QUALIFICATION", null);
            DAL.Close();
            return Dt;


        }
    }
}
