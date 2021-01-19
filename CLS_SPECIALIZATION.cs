using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace login1.BL
{
    class CLS_SPECIALIZATION
    {
        public DataTable GET_ALL_SPECIALIZATION()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();


            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_SPECIALIZATION", null);
            DAL.Close();
            return Dt;
        }
    }
}
