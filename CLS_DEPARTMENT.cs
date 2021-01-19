using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace login1.BL
{
    class CLS_DEPARTMENT
    {
        public DataTable GET_ALL_DEPARTMENT()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();


            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_DEPARTMENT", null);
            DAL.Close();
            return Dt;


        }
    }
}
