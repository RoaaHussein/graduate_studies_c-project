using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace login1.BL
{
    class CLS_MINUTES
    {
        public DataTable GET_ALL_MINUTES()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();


            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("GET_ALL_MINUTES", null);
            DAL.Close();
            return Dt;
        }


        //public void inserttable(string name1, string nation1, string register_year1, string grad_year1, string sum_mark1, string aver1, string  result1, string note1 )
        //{        //                    @name1 nvarchar(50),
        //         //@nation1 nvarchar(50),
        //         //@register_year1 nvarchar(50),
        //         //@grad_year1 nvarchar(50),
        //         //@sum_mark1 nvarchar(50),
        //         //@aver1 nvarchar(50),
        //         //@result1 nvarchar(50),
        //         //@note1 nvarchar(50)
        //    DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
        //    DAL.Open();
        //    SqlParameter[] param = new SqlParameter[8];
        //    param[0] = new SqlParameter("name1", SqlDbType.NVarChar, 50);
        //    param[0].Value = name1;

        //    param[1] = new SqlParameter("nation1", SqlDbType.NVarChar, 50);
        //    param[1].Value = nation1;


        //    param[2] = new SqlParameter("register_year1", SqlDbType.NVarChar, 50);
        //    param[2].Value = register_year1;

        //    param[3] = new SqlParameter("grad_year1", SqlDbType.NVarChar, 50);
        //    param[3].Value = grad_year1;

        //    param[4] = new SqlParameter("sum_mark1", SqlDbType.NVarChar, 50);
        //    param[4].Value = sum_mark1;

        //    param[5] = new SqlParameter("aver1", SqlDbType.NVarChar, 50);
        //    param[5].Value = aver1;

        //    param[6] = new SqlParameter("result1", SqlDbType.NVarChar, 50);
        //    param[6].Value = result1;

        //    param[7] = new SqlParameter("note1", SqlDbType.NVarChar, 50);
        //    param[7].Value = note1;




        //    DAL.ExecuteCommand("inserttable", param);
        //    DAL.Close();
        //}
         


        public DataTable ADD_here(string NAME_ARABIC)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@NAME_ARABIC", SqlDbType.NVarChar, 50);
            param[0].Value = NAME_ARABIC;
            Dt = DAL.SelectData("ADD_here", param);
            DAL.Close();
            return Dt;
        }

        public DataTable stu_info(string NAME_ARABIC)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@NAME_ARABIC", SqlDbType.NVarChar, 50);
            param[0].Value = NAME_ARABIC;
            Dt = DAL.SelectData("stu_info", param);
            DAL.Close();
            return Dt;
        }

        public DataTable ADD_there(string NAME_ARABIC)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@NAME_ARABIC", SqlDbType.NVarChar, 50);
            param[0].Value = NAME_ARABIC;
            Dt = DAL.SelectData("ADD_there", param);
            DAL.Close();
            return Dt;
        }
        public void ADD_MINUTES(string MINUTES_ID, string STUDY_YEAR, string DAY, string MINUTES_HISTORY, string COLLEG_NOTE, string DEPARTMENT, string REQUEST, string STUDENT_DATA, string DEPARTMENT_NUMBER, string DEPARTMENT_HISTORY, string COLLEGE_NUMBER, string COLLEGE_HISTORY, string STUDENT_NAME, string DEGREE, string STUDENT_DEPARTMENT, string STUDENT_COLLEGE, string SPECIALIZATION, string NOTES, string MINUTES_DECISION, string n1, string n2, string n3, string n4, string n5, string n6, string n7, string n8/*, String n9*/)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[27];
            param[0] = new SqlParameter("MINUTES_ID", SqlDbType.NVarChar, 50);
            param[0].Value = MINUTES_ID;

            param[1] = new SqlParameter("STUDY_YEAR", SqlDbType.NVarChar, 50);
            param[1].Value = STUDY_YEAR;


            param[2] = new SqlParameter("DAY", SqlDbType.NVarChar, 50);
            param[2].Value = DAY;


            param[3] = new SqlParameter("MINUTES_HISTORY", SqlDbType.NVarChar, 50);
            param[3].Value = MINUTES_HISTORY;

            param[4] = new SqlParameter("COLLEG_NOTE", SqlDbType.NVarChar, 50);
            param[4].Value = COLLEG_NOTE;

            param[5] = new SqlParameter("DEPARTMENT", SqlDbType.NVarChar, 50);
            param[5].Value = DEPARTMENT;


            param[6] = new SqlParameter("REQUEST", SqlDbType.NVarChar, 50);
            param[6].Value = REQUEST;


            param[7] = new SqlParameter("STUDENT_DATA", SqlDbType.NVarChar, 50);
            param[7].Value = STUDENT_DATA;

            param[8] = new SqlParameter("DEPARTMENT_NUMBER ", SqlDbType.NVarChar, 50);
            param[8].Value = DEPARTMENT_NUMBER;

            param[9] = new SqlParameter("DEPARTMENT_HISTORY", SqlDbType.NVarChar, 50);
            param[9].Value = DEPARTMENT_HISTORY;

            param[10] = new SqlParameter("COLLEGE_NUMBER", SqlDbType.NVarChar, 50);
            param[10].Value = COLLEGE_NUMBER;

            param[11] = new SqlParameter("COLLEGE_HISTORY", SqlDbType.NVarChar, 50);
            param[11].Value = COLLEGE_HISTORY;


            param[12] = new SqlParameter("STUDENT_NAME", SqlDbType.NVarChar, 50);
            param[12].Value = STUDENT_NAME;


            param[13] = new SqlParameter("DEGREE", SqlDbType.NVarChar, 50);
            param[13].Value = DEGREE;

            param[14] = new SqlParameter("STUDENT_DEPARTMENT", SqlDbType.NVarChar, 50);
            param[14].Value = STUDENT_DEPARTMENT;

            param[15] = new SqlParameter("STUDENT_COLLEGE", SqlDbType.NVarChar, 50);
            param[15].Value = STUDENT_COLLEGE;

            param[16] = new SqlParameter("SPECIALIZATION", SqlDbType.NVarChar, 50);
            param[16].Value = SPECIALIZATION;

            param[17] = new SqlParameter("NOTES", SqlDbType.NVarChar);
            param[17].Value = NOTES;

            param[18] = new SqlParameter("MINUTES_DECISION", SqlDbType.NVarChar);
            param[18].Value = MINUTES_DECISION;

            param[19] = new SqlParameter("n1", SqlDbType.NVarChar, 50);
            param[19].Value = n1;

            param[20] = new SqlParameter("n2", SqlDbType.NVarChar, 50);
            param[20].Value = n2;

            param[21] = new SqlParameter("n3", SqlDbType.NVarChar, 50);
            param[21].Value = n3;

            param[22] = new SqlParameter("n4", SqlDbType.NVarChar, 50);
            param[22].Value = n4;

            param[23] = new SqlParameter("n5", SqlDbType.NVarChar, 50);
            param[23].Value = n5;

            param[24] = new SqlParameter("n6", SqlDbType.NVarChar, 50);
            param[24].Value = n6;

            param[25] = new SqlParameter("n7", SqlDbType.NVarChar, 50);
            param[25].Value = n7;

            param[26] = new SqlParameter("n8", SqlDbType.NVarChar, 50);
            param[26].Value = n8;

            //param[27] = new SqlParameter("n9", SqlDbType.NVarChar, 50);
            //param[27].Value = n8;






            DAL.ExecuteCommand("ADD_MINUTES", param);
            DAL.Close();


        }

        public DataTable VerifyMINUTES_ID(String ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = ID;
            Dt = DAL.SelectData("VerifyMINUTES_ID", param);
            DAL.Close();
            return Dt;
        }




        //public DataTable GET_ALL_DATA()
        //{
        //    DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();


        //    DataTable Dt = new DataTable();
        //    Dt = DAL.SelectData("GET_ALL_DATA", null);
        //    DAL.Close();
        //    return Dt;
        //}

        public DataTable SearchMINUTES(String ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = ID;
            Dt = DAL.SelectData("SearchMINUTES", param);
            DAL.Close();
            return Dt;
        }

        public void DeleteMinutes(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = ID;



            DAL.ExecuteCommand("DeleteMinutes", param);
            DAL.Close();
        }







        public void ADD_MINUTESss(string MINUTES_ID, string STUDY_YEAR, String DAY, String MINUTES_HISTORY, String COLLEG_NOTE, String DEPARTMENT, String DEGREE, string TOPIC_YEAR, String CLASS, String NOTES, String MINUTES_DECISION, string name1, string nation1, string register_year1, string grad_year1, string aver1, string result1)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[17];
            param[0] = new SqlParameter("MINUTES_ID", SqlDbType.NVarChar, 50);
            param[0].Value = MINUTES_ID;

            param[1] = new SqlParameter("STUDY_YEAR", SqlDbType.NVarChar, 50);
            param[1].Value = STUDY_YEAR;



            param[2] = new SqlParameter("DAY", SqlDbType.NVarChar, 50);
            param[2].Value = DAY;

            param[3] = new SqlParameter("MINUTES_HISTORY", SqlDbType.NVarChar, 50);
            param[3].Value = MINUTES_HISTORY;

            param[4] = new SqlParameter("COLLEG_NOTE", SqlDbType.NVarChar, 50);
            param[4].Value = COLLEG_NOTE;

            param[5] = new SqlParameter("DEPARTMENT", SqlDbType.NVarChar, 50);
            param[5].Value = DEPARTMENT;

            param[6] = new SqlParameter("DEGREE", SqlDbType.NVarChar, 50);
            param[6].Value = DEGREE;

            param[7] = new SqlParameter("TOPIC_YEAR", SqlDbType.NVarChar, 50);
            param[7].Value = TOPIC_YEAR;

            param[8] = new SqlParameter("CLASS", SqlDbType.NVarChar, 50);
            param[8].Value = CLASS;

            param[9] = new SqlParameter("NOTES", SqlDbType.NVarChar);
            param[9].Value = NOTES;

            param[10] = new SqlParameter("MINUTES_DECISION", SqlDbType.NVarChar);
            param[10].Value = MINUTES_DECISION;

            param[11] = new SqlParameter("name1", SqlDbType.NVarChar, 50);
            param[11].Value = name1;

            param[12] = new SqlParameter("nation1", SqlDbType.NVarChar, 50);
            param[12].Value = nation1;


            param[13] = new SqlParameter("register_year1", SqlDbType.NVarChar, 50);
            param[13].Value = register_year1;

            param[14] = new SqlParameter("grad_year1", SqlDbType.NVarChar, 50);
            param[14].Value = grad_year1;

            //param[15] = new SqlParameter("sum_mark1", SqlDbType.NVarChar, 50);
            //param[15].Value = sum_mark1;

            param[15] = new SqlParameter("aver1", SqlDbType.NVarChar, 50);
            param[15].Value = aver1;

            param[16] = new SqlParameter("result1", SqlDbType.NVarChar, 50);
            param[16].Value = result1;

            //param[18] = new SqlParameter("note1", SqlDbType.NVarChar, 50);
            //param[18].Value = note1;

            DAL.ExecuteCommand("ADD_MINUTESss", param);
            DAL.Close();










        }

        //public void inserttable(string name1, string nation1, string register_year1, string grad_year1, string sum_mark1, string aver1, string  result1, string note1 )
        //{        //                    @name1 nvarchar(50),
        //         //@nation1 nvarchar(50),
        //         //@register_year1 nvarchar(50),
        //         //@grad_year1 nvarchar(50),
        //         //@sum_mark1 nvarchar(50),
        //         //@aver1 nvarchar(50),
        //         //@result1 nvarchar(50),
        //         //@note1 nvarchar(50)
        //    DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
        //    DAL.Open();
        //    SqlParameter[] param = new SqlParameter[8];
           // param[0] = new SqlParameter("name1", SqlDbType.NVarChar, 50);
           // param[0].Value = name1;

           // param[1] = new SqlParameter("nation1", SqlDbType.NVarChar, 50);
           //param[1].Value = nation1;


           // param[2] = new SqlParameter("register_year1", SqlDbType.NVarChar, 50);
           // param[2].Value = register_year1;

           // param[3] = new SqlParameter("grad_year1", SqlDbType.NVarChar, 50);
           //param[3].Value = grad_year1;

           //param[4] = new SqlParameter("sum_mark1", SqlDbType.NVarChar, 50);
           //param[4].Value = sum_mark1;

           //param[5] = new SqlParameter("aver1", SqlDbType.NVarChar, 50);
           //param[5].Value = aver1;

         // param[6] = new SqlParameter("result1", SqlDbType.NVarChar, 50);
         // param[6].Value = result1;

         //param[7] = new SqlParameter("note1", SqlDbType.NVarChar, 50);
         // param[7].Value = note1;




        //    DAL.ExecuteCommand("inserttable", param);
        //    DAL.Close();
        //}
        public void ADD_MINUTESss3(string MINUTES_ID, string STUDY_YEAR, String DAY, String MINUTES_HISTORY, string COLLEG_NOTE, string DEPARTMENT, string REQUEST, string STUDENT_NAME, string UNIVERSITY_BASED, string UNIVERSITY, string STUDY, String NOTES, string SPECIALIZATION, String MINUTES_DECISION)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[14];
            param[0] = new SqlParameter("MINUTES_ID", SqlDbType.NVarChar, 50);
            param[0].Value = MINUTES_ID;

            param[1] = new SqlParameter("STUDY_YEAR", SqlDbType.NVarChar, 50);
            param[1].Value = STUDY_YEAR;

            param[2] = new SqlParameter("DAY", SqlDbType.NVarChar, 50);
            param[2].Value = DAY;

            param[3] = new SqlParameter("MINUTES_HISTORY", SqlDbType.NVarChar, 50);
            param[3].Value = MINUTES_HISTORY;

            param[4] = new SqlParameter("COLLEG_NOTE", SqlDbType.NVarChar, 50);
            param[4].Value = COLLEG_NOTE;

            param[5] = new SqlParameter("DEPARTMENT", SqlDbType.NVarChar, 50);
            param[5].Value = DEPARTMENT;

            param[6] = new SqlParameter("REQUEST", SqlDbType.NVarChar, 50);
            param[6].Value = REQUEST;

            param[7] = new SqlParameter("STUDENT_NAME", SqlDbType.NVarChar, 50);
            param[7].Value = STUDENT_NAME;

            param[8] = new SqlParameter("UNIVERSITY_BASED", SqlDbType.NVarChar, 50);
            param[8].Value = UNIVERSITY_BASED;

            param[9] = new SqlParameter("UNIVERSITY", SqlDbType.NVarChar, 50);
            param[9].Value = UNIVERSITY;

            param[10] = new SqlParameter("STUDY", SqlDbType.NVarChar, 50);
            param[10].Value = STUDY;

            param[11] = new SqlParameter("NOTES", SqlDbType.NVarChar);
            param[11].Value = NOTES;

            param[12] = new SqlParameter("SPECIALIZATION", SqlDbType.NVarChar, 50);
            param[12].Value = SPECIALIZATION;

            param[13] = new SqlParameter("MINUTES_DECISION", SqlDbType.NVarChar);
            param[13].Value = MINUTES_DECISION;

           


            DAL.ExecuteCommand("ADD_MINUTESss3", param);
            DAL.Close();


        }

        public void UPDATE_MINUTES(string MINUTES_ID, string STUDY_YEAR, string DAY, string MINUTES_HISTORY, String COLLEG_NOTE, String DEPARTMENT, String REQUEST, String STUDENT_DATA, string DEPARTMENT_NUMBER, String DEPARTMENT_HISTORY, string COLLEGE_NUMBER, string COLLEGE_HISTORY, String STUDENT_NAME, String DEGREE, String STUDENT_DEPARTMENT, String STUDENT_COLLEGE, String SPECIALIZATION, String NOTES, String MINUTES_DECISION, String n1, String n2, String n3, String n4, String n5, String n6, String n7, String n8/*, String n9*/)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[27];
            param[0] = new SqlParameter("MINUTES_ID", SqlDbType.NVarChar, 50);
            param[0].Value = MINUTES_ID;

            param[1] = new SqlParameter("STUDY_YEAR", SqlDbType.NVarChar, 50);
            param[1].Value = STUDY_YEAR;


            param[2] = new SqlParameter("DAY", SqlDbType.NVarChar, 50);
            param[2].Value = DAY;


            param[3] = new SqlParameter("MINUTES_HISTORY", SqlDbType.NVarChar, 50);
            param[3].Value = MINUTES_HISTORY;

            param[4] = new SqlParameter("COLLEG_NOTE", SqlDbType.NVarChar, 50);
            param[4].Value = COLLEG_NOTE;

            param[5] = new SqlParameter("DEPARTMENT", SqlDbType.NVarChar, 50);
            param[5].Value = DEPARTMENT;


            param[6] = new SqlParameter("REQUEST", SqlDbType.NVarChar, 50);
            param[6].Value = REQUEST;


            param[7] = new SqlParameter("STUDENT_DATA", SqlDbType.NVarChar, 50);
            param[7].Value = STUDENT_DATA;

            param[8] = new SqlParameter("DEPARTMENT_NUMBER ", SqlDbType.NVarChar, 50);
            param[8].Value = DEPARTMENT_NUMBER;

            param[9] = new SqlParameter("DEPARTMENT_HISTORY", SqlDbType.NVarChar, 50);
            param[9].Value = DEPARTMENT_HISTORY;

            param[10] = new SqlParameter("COLLEGE_NUMBER", SqlDbType.NVarChar, 50);
            param[10].Value = COLLEGE_NUMBER;

            param[11] = new SqlParameter("COLLEGE_HISTORY", SqlDbType.NVarChar, 50);
            param[11].Value = COLLEGE_HISTORY;


            param[12] = new SqlParameter("STUDENT_NAME", SqlDbType.NVarChar, 50);
            param[12].Value = STUDENT_NAME;


            param[13] = new SqlParameter("DEGREE", SqlDbType.NVarChar, 50);
            param[13].Value = DEGREE;

            param[14] = new SqlParameter("STUDENT_DEPARTMENT", SqlDbType.NVarChar, 50);
            param[14].Value = STUDENT_DEPARTMENT;

            param[15] = new SqlParameter("STUDENT_COLLEGE", SqlDbType.NVarChar, 50);
            param[15].Value = STUDENT_COLLEGE;

            param[16] = new SqlParameter("SPECIALIZATION", SqlDbType.NVarChar, 50);
            param[16].Value = SPECIALIZATION;

            param[17] = new SqlParameter("NOTES", SqlDbType.NVarChar);
            param[17].Value = NOTES;

            param[18] = new SqlParameter("MINUTES_DECISION", SqlDbType.NVarChar);
            param[18].Value = MINUTES_DECISION;

            param[19] = new SqlParameter("n1", SqlDbType.NVarChar, 50);
            param[19].Value = n1;

            param[20] = new SqlParameter("n2", SqlDbType.NVarChar, 50);
            param[20].Value = n2;

            param[21] = new SqlParameter("n3", SqlDbType.NVarChar, 50);
            param[21].Value = n3;

            param[22] = new SqlParameter("n4", SqlDbType.NVarChar, 50);
            param[22].Value = n4;

            param[23] = new SqlParameter("n5", SqlDbType.NVarChar, 50);
            param[23].Value = n5;

            param[24] = new SqlParameter("n6", SqlDbType.NVarChar, 50);
            param[24].Value = n6;

            param[25] = new SqlParameter("n7", SqlDbType.NVarChar, 50);
            param[25].Value = n7;

            param[26] = new SqlParameter("n8", SqlDbType.NVarChar, 50);
            param[26].Value = n8;

            //param[27] = new SqlParameter("n9", SqlDbType.NVarChar, 50);
            //param[27].Value = n9;








            DAL.ExecuteCommand("UPDATE_MINUTES", param);
            DAL.Close();


        }


        public void UPDATE_MINUTESs(string MINUTES_ID, string STUDY_YEAR, String DAY, String MINUTES_HISTORY, String COLLEG_NOTE, String DEPARTMENT, String REQUEST, string TOPIC_YEAR, String CLASS, String NOTES, String MINUTES_DECISION, string name1, string nation1, string register_year1, string grad_year1, string aver1, string result1)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[17];
            param[0] = new SqlParameter("MINUTES_ID", SqlDbType.NVarChar, 50);
            param[0].Value = MINUTES_ID;

            param[1] = new SqlParameter("STUDY_YEAR", SqlDbType.NVarChar, 50);
            param[1].Value = STUDY_YEAR;



            param[2] = new SqlParameter("DAY", SqlDbType.NVarChar, 50);
            param[2].Value = DAY;

            param[3] = new SqlParameter("MINUTES_HISTORY", SqlDbType.NVarChar, 50);
            param[3].Value = MINUTES_HISTORY;

            param[4] = new SqlParameter("COLLEG_NOTE", SqlDbType.NVarChar, 50);
            param[4].Value = COLLEG_NOTE;

            param[5] = new SqlParameter("DEPARTMENT", SqlDbType.NVarChar, 50);
            param[5].Value = DEPARTMENT;

            param[6] = new SqlParameter("REQUEST", SqlDbType.NVarChar, 50);
            param[6].Value = REQUEST;

            param[7] = new SqlParameter("TOPIC_YEAR", SqlDbType.NVarChar, 50);
            param[7].Value = TOPIC_YEAR;

            param[8] = new SqlParameter("CLASS", SqlDbType.NVarChar, 50);
            param[8].Value = CLASS;

            param[9] = new SqlParameter("NOTES", SqlDbType.NVarChar);
            param[9].Value = NOTES;

            param[10] = new SqlParameter("MINUTES_DECISION", SqlDbType.NVarChar);
            param[10].Value = MINUTES_DECISION;

            param[11] = new SqlParameter("name1", SqlDbType.NVarChar, 50);
            param[11].Value = name1;

            param[12] = new SqlParameter("nation1", SqlDbType.NVarChar, 50);
            param[12].Value = nation1;


            param[13] = new SqlParameter("register_year1", SqlDbType.NVarChar, 50);
            param[13].Value = register_year1;

            param[14] = new SqlParameter("grad_year1", SqlDbType.NVarChar, 50);
            param[14].Value = grad_year1;

            //param[15] = new SqlParameter("sum_mark1", SqlDbType.NVarChar, 50);
            //param[15].Value = sum_mark1;

            param[15] = new SqlParameter("aver1", SqlDbType.NVarChar, 50);
            param[15].Value = aver1;

            param[16] = new SqlParameter("result1", SqlDbType.NVarChar, 50);
            param[16].Value = result1;


            DAL.ExecuteCommand("UPDATE_MINUTESs", param);
            DAL.Close();










        }

        public void UPDATE_MINUTESs3(string MINUTES_ID, string STUDY_YEAR, String DAY, String MINUTES_HISTORY, string COLLEG_NOTE, string DEPARTMENT, string REQUEST, string STUDENT_NAME, string UNIVERSITY_BASED, string UNIVERSITY, string STUDY, String NOTES, string SPECIALIZATION, String MINUTES_DECISION)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[14];
            param[0] = new SqlParameter("MINUTES_ID", SqlDbType.NVarChar, 50);
            param[0].Value = MINUTES_ID;

            param[1] = new SqlParameter("STUDY_YEAR", SqlDbType.NVarChar, 50);
            param[1].Value = STUDY_YEAR;

            param[2] = new SqlParameter("DAY", SqlDbType.NVarChar, 50);
            param[2].Value = DAY;

            param[3] = new SqlParameter("MINUTES_HISTORY", SqlDbType.NVarChar, 50);
            param[3].Value = MINUTES_HISTORY;

            param[4] = new SqlParameter("COLLEG_NOTE", SqlDbType.NVarChar, 50);
            param[4].Value = COLLEG_NOTE;

            param[5] = new SqlParameter("DEPARTMENT", SqlDbType.NVarChar, 50);
            param[5].Value = DEPARTMENT;

            param[6] = new SqlParameter("REQUEST", SqlDbType.NVarChar, 50);
            param[6].Value = REQUEST;

            param[7] = new SqlParameter("STUDENT_NAME", SqlDbType.NVarChar, 50);
            param[7].Value = STUDENT_NAME;

            param[8] = new SqlParameter("UNIVERSITY_BASED", SqlDbType.NVarChar, 50);
            param[8].Value = UNIVERSITY_BASED;

            param[9] = new SqlParameter("UNIVERSITY", SqlDbType.NVarChar, 50);
            param[9].Value = UNIVERSITY;

            param[10] = new SqlParameter("STUDY", SqlDbType.NVarChar, 50);
            param[10].Value = STUDY;

            param[11] = new SqlParameter("NOTES", SqlDbType.NVarChar);
            param[11].Value = NOTES;

            param[12] = new SqlParameter("SPECIALIZATION", SqlDbType.NVarChar, 50);
            param[12].Value = SPECIALIZATION;

            param[13] = new SqlParameter("MINUTES_DECISION", SqlDbType.NVarChar);
            param[13].Value = MINUTES_DECISION;


            DAL.ExecuteCommand("UPDATE_MINUTESs3", param);
            DAL.Close();


        }






    }
}
