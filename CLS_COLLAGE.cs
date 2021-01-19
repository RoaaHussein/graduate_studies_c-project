using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace login1.BL
{
    class ClS_COLLAGE
    {
        public DataTable GET_ALL_COLLEGE()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();


            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_COLLEGE", null);
            DAL.Close();
            return Dt;


        }

    }
}
