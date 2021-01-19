using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace login1.BL
{
    class CLS_STUDENTS
    {
        public DataTable GET_ALL_CATEGORISES()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("GET_ALL_CATEGORISES", null);
            DAL.Close();
            return DT;
        }

        public DataTable GET_ALL_CATEGORISES2()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("GET_ALL_CATEGORISES2", null);
            DAL.Close();
            return DT;
        }

        public DataTable GET_ALL_CATEGORISES3()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("GET_ALL_CATEGORISES3", null);
            DAL.Close();
            return DT;
        }

        public void ADD_STUDENT(string STUDENT_ID, string NAME_ENGLISH , string GENDER_ARABIC, string GENDER_ENGLISH , string NATIONALTY_ARABIC, string NATIONALTY_ENGLISH,  string BIRTHDAY_ARABIC , string BRTHDAY_ENGLISH , string PLACE_BIRTH_ARABIC, string PLACE_BIRTH_ENGLISH , string WORK_SIDE_ARABIC , string WORK_SIDE_ENGLISH , string CURRNENT_ADDRESS, string EMAIL , string HOME_PHONE , string MOBILE, string FAX , string COUNTRY , string DATE2 , string UNIVERSITY , string AVERAGE , string TOTAL_RESULT, string PLATE_NUMBER , string SYSTEM_TYPE , string MARK_TYPE, string TOPIC_ARABIC , string TOPIC_ENGLISH , int SPECIALIZATION_ID,
            string SPECIALIZATION , string DEPARTMENT1, string DEPARTMENT2 , string COLLEGE1 , string COLLEGE2 , string QUALIFICATION , string PROGRAM_NUMBER
            , string REQUIRED_DEGREE , string NAME_ARABIC, string IDTYPE, string IDNUM, string IDDATE, string IDSOURCE, string YEARREGISTERDATE, string FIRSTACCEPTANCE, string  LASTACCEPTANCE, string PERIODSTUDY, string  STARTDATE, string ENDDATE, string REGISTERDATE, string SUPPORTSIDE, string  SUPPORTTYPE, string CARDNUMBER, string DATECARD, string  DETAILS1,
            string m1_num, string m2_num, string m3_num, string m1_DATE, string m2_DATE, string m3_DATE, string DETAILS2, string NAME_doc, string edu_degree, string committee1, string uni, string college_committee, string dept_committee, string un1, string un2, string un3, string un4, string un5, string un6, string NAME_doc2, string edu_degree2, string committee2, string uni2, string college_committee2, string dept_committee2, byte[] PIC_IMAGE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[79];

            param[0] = new SqlParameter("@STUDENT_ID", SqlDbType.NVarChar, 50);
            param[0].Value = STUDENT_ID; 

            param[1] = new SqlParameter("@NAME_ENGLISH", SqlDbType.NVarChar, 50);
            param[1].Value = NAME_ENGLISH;

            param[2] = new SqlParameter("@GENDER_ARABIC", SqlDbType.NVarChar, 50);
            param[2].Value = GENDER_ARABIC;

            param[3] = new SqlParameter("@GENDER_ENGLISH", SqlDbType.NVarChar, 50);
            param[3].Value = GENDER_ENGLISH;

            param[4] = new SqlParameter("@NATIONALTY_ARABIC", SqlDbType.NVarChar, 50);
            param[4].Value = NATIONALTY_ARABIC;

            param[5] = new SqlParameter("@NATIONALTY_ENGLISH", SqlDbType.NVarChar, 50);
            param[5].Value = NATIONALTY_ENGLISH;

            param[6] = new SqlParameter("@BIRTHDAY_ARABIC", SqlDbType.NVarChar, 50);
            param[6].Value = BIRTHDAY_ARABIC;

            param[7] = new SqlParameter("@BRTHDAY_ENGLISH", SqlDbType.NVarChar, 50);
            param[7].Value = BRTHDAY_ENGLISH;

            param[8] = new SqlParameter("@PLACE_BIRTH_ARABIC", SqlDbType.NVarChar, 50);
            param[8].Value = PLACE_BIRTH_ARABIC;

            param[9] = new SqlParameter("@PLACE_BIRTH_ENGLISH", SqlDbType.NVarChar, 50);
            param[9].Value = PLACE_BIRTH_ENGLISH;

            param[10] = new SqlParameter("@WORK_SIDE_ARABIC", SqlDbType.NVarChar, 50);
            param[10].Value = WORK_SIDE_ARABIC;

            param[11] = new SqlParameter("@WORK_SIDE_ENGLISH", SqlDbType.NVarChar, 50);
            param[11].Value = WORK_SIDE_ENGLISH;

            param[12] = new SqlParameter("@CURRNENT_ADDRESS", SqlDbType.NVarChar, 50);
            param[12].Value = CURRNENT_ADDRESS;

            param[13] = new SqlParameter("EMAIL", SqlDbType.NVarChar, 50);
            param[13].Value = EMAIL;

            param[14] = new SqlParameter("@HOME_PHONE", SqlDbType.NVarChar, 50);
            param[14].Value = HOME_PHONE;

            param[15] = new SqlParameter("@MOBILE", SqlDbType.NVarChar, 50);
            param[15].Value = MOBILE;

            param[16] = new SqlParameter("@FAX", SqlDbType.NVarChar, 50);
            param[16].Value = FAX;

            param[17] = new SqlParameter("@COUNTRY", SqlDbType.NVarChar, 50);
            param[17].Value = COUNTRY;

            param[18] = new SqlParameter("@DATE2", SqlDbType.NVarChar, 50);
            param[18].Value = DATE2;

            param[19] = new SqlParameter("@UNIVERSITY", SqlDbType.NVarChar, 50);
            param[19].Value = UNIVERSITY;

            param[20] = new SqlParameter("@AVERAGE", SqlDbType.NVarChar, 50);
            param[20].Value = AVERAGE;

            param[21] = new SqlParameter("@TOTAL_RESULT", SqlDbType.NVarChar, 50);
            param[21].Value = TOTAL_RESULT;

            param[22] = new SqlParameter("@PLATE_NUMBER", SqlDbType.NVarChar, 50);
            param[22].Value = PLATE_NUMBER;

            param[23] = new SqlParameter("@SYSTEM_TYPE", SqlDbType.NVarChar, 50);
            param[23].Value = SYSTEM_TYPE;

            param[24] = new SqlParameter("@MARK_TYPE", SqlDbType.NVarChar, 50);
            param[24].Value = MARK_TYPE;

            param[25] = new SqlParameter("@TOPIC_ARABIC", SqlDbType.NVarChar, 50);
            param[25].Value = TOPIC_ARABIC;

            param[26] = new SqlParameter("@TOPIC_ENGLISH", SqlDbType.NVarChar, 50);
            param[26].Value = TOPIC_ENGLISH;

            param[27] = new SqlParameter("@SPECIALIZATION_ID", SqlDbType.Int);
            param[27].Value = SPECIALIZATION_ID;

            param[28] = new SqlParameter("@SPECIALIZATION", SqlDbType.NVarChar, 50);
            param[28].Value = SPECIALIZATION;

            param[29] = new SqlParameter("@DEPARTMENT1", SqlDbType.NVarChar, 50);
            param[29].Value = DEPARTMENT1;

            param[30] = new SqlParameter("@DEPARTMENT2", SqlDbType.NVarChar, 50);
            param[30].Value = DEPARTMENT2;

            param[31] = new SqlParameter("@COLLEGE1", SqlDbType.NVarChar, 50);
            param[31].Value = COLLEGE1;

            param[32] = new SqlParameter("@COLLEGE2", SqlDbType.NVarChar, 50);
            param[32].Value = COLLEGE2;

            param[33] = new SqlParameter("@QUALIFICATION", SqlDbType.NVarChar, 50);
            param[33].Value = QUALIFICATION;

            param[34] = new SqlParameter("@PROGRAM_NUMBER", SqlDbType.NVarChar, 50);
            param[34].Value = PROGRAM_NUMBER;

            param[35] = new SqlParameter("@REQUIRED_DEGREE", SqlDbType.NVarChar, 50);
            param[35].Value = REQUIRED_DEGREE;

            param[36] = new SqlParameter("@NAME_ARABIC", SqlDbType.NVarChar, 50);
            param[36].Value = NAME_ARABIC;

            param[37] = new SqlParameter("@IDTYPE", SqlDbType.NVarChar, 50);
            param[37].Value = IDTYPE;

            param[38] = new SqlParameter("@IDNUM", SqlDbType.NVarChar, 50);
            param[38].Value = IDNUM;

            param[39] = new SqlParameter("@IDDATE", SqlDbType.NVarChar, 50);
            param[39].Value = IDDATE;

            param[40] = new SqlParameter("@IDSOURCE", SqlDbType.NVarChar, 50);
            param[40].Value = IDSOURCE;

            param[41] = new SqlParameter("@YEARREGISTERDATE", SqlDbType.NVarChar, 50);
            param[41].Value = YEARREGISTERDATE;

            param[42] = new SqlParameter("@FIRSTACCEPTANCE", SqlDbType.NVarChar, 50);
            param[42].Value = FIRSTACCEPTANCE;

            param[43] = new SqlParameter("@LASTACCEPTANCE", SqlDbType.NVarChar, 50);
            param[43].Value = LASTACCEPTANCE;

            param[44] = new SqlParameter("@PERIODSTUDY", SqlDbType.NVarChar, 50);
            param[44].Value = PERIODSTUDY;

            param[45] = new SqlParameter("@STARTDATE", SqlDbType.NVarChar, 50);
            param[45].Value = STARTDATE;

            param[46] = new SqlParameter("@ENDDATE", SqlDbType.NVarChar, 50);
            param[46].Value = ENDDATE;

            param[47] = new SqlParameter("@REGISTERDATE", SqlDbType.NVarChar, 50);
            param[47].Value = REGISTERDATE;

            param[48] = new SqlParameter("@SUPPORTSIDE", SqlDbType.NVarChar, 50);
            param[48].Value = SUPPORTSIDE;

            param[49] = new SqlParameter("@SUPPORTTYPE", SqlDbType.NVarChar, 50);
            param[49].Value = SUPPORTTYPE;

            param[50] = new SqlParameter("@CARDNUMBER", SqlDbType.NVarChar, 50);
            param[50].Value = CARDNUMBER;

            param[51] = new SqlParameter("@DATECARD", SqlDbType.NVarChar, 50);
            param[51].Value = DATECARD;

            param[52] = new SqlParameter("@DETAILS1", SqlDbType.NVarChar, 50);
            param[52].Value = DETAILS1;

            param[53] = new SqlParameter("@m1_num", SqlDbType.NVarChar, 50);
            param[53].Value = m1_num;

            param[54] = new SqlParameter("@m2_num", SqlDbType.NVarChar, 50);
            param[54].Value = m2_num;

            param[55] = new SqlParameter("@m3_num", SqlDbType.NVarChar, 50);
            param[55].Value = m3_num;

            param[56] = new SqlParameter("@m1_DATE", SqlDbType.NVarChar, 50);
            param[56].Value = m1_DATE;

            param[57] = new SqlParameter("@m2_DATE", SqlDbType.NVarChar, 50);
            param[57].Value = m2_DATE;

            param[58] = new SqlParameter("@m3_DATE", SqlDbType.NVarChar, 50);
            param[58].Value = m3_DATE;

            param[59] = new SqlParameter("@DETAILS2", SqlDbType.NVarChar, 50);
            param[59].Value = DETAILS2;

            param[60] = new SqlParameter("@NAME_doc", SqlDbType.NVarChar, 50);
            param[60].Value = NAME_doc;

            param[61] = new SqlParameter("@edu_degree", SqlDbType.NVarChar, 50);
            param[61].Value = edu_degree;

            param[62] = new SqlParameter("@committee1", SqlDbType.NVarChar, 50);
            param[62].Value = committee1;

            param[63] = new SqlParameter("@uni", SqlDbType.NVarChar, 50);
            param[63].Value = uni;

            param[64] = new SqlParameter("@college_committee", SqlDbType.NVarChar, 50);
            param[64].Value = college_committee;

            param[65] = new SqlParameter("@dept_committee", SqlDbType.NVarChar, 50);
            param[65].Value = dept_committee;

            param[66] = new SqlParameter("@un1", SqlDbType.NVarChar, 50);
            param[66].Value = un1;

            param[67] = new SqlParameter("@un2", SqlDbType.NVarChar, 50);
            param[67].Value = un2;

            param[68] = new SqlParameter("@un3", SqlDbType.NVarChar, 50);
            param[68].Value = un3;

            param[69] = new SqlParameter("@un4", SqlDbType.NVarChar, 50);
            param[69].Value = un4;

            param[70] = new SqlParameter("@un5", SqlDbType.NVarChar, 50);
            param[70].Value = un5;

            param[71] = new SqlParameter("@un6", SqlDbType.NVarChar, 50);
            param[71].Value = un6;

            param[72] = new SqlParameter("@NAME_doc2", SqlDbType.NVarChar, 50);
            param[72].Value = NAME_doc2;

            param[73] = new SqlParameter("@edu_degree2", SqlDbType.NVarChar, 50);
            param[73].Value = edu_degree2;

            param[74] = new SqlParameter("@committee2", SqlDbType.NVarChar, 50);
            param[74].Value = committee2;

            param[75] = new SqlParameter("@uni2", SqlDbType.NVarChar, 50);
            param[75].Value = uni2;

            param[76] = new SqlParameter("@college_committee2", SqlDbType.NVarChar, 50);
            param[76].Value = college_committee2;

            param[77] = new SqlParameter("@dept_committee2", SqlDbType.NVarChar, 50);
            param[77].Value = dept_committee2;



            param[78] = new SqlParameter("@PIC_IMAGE", SqlDbType.Image);
            param[78].Value = PIC_IMAGE;



            DAL.ExecuteCommand("ADD_STUDENT", param);
            DAL.Close();


        }

        /*public void ADD_TABLEINFO(string IDTYPE, string IDNUM, string IDDATE, string IDSOURCE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@IDTYPE", SqlDbType.NVarChar, 50);
            param[0].Value = IDTYPE;

            param[1] = new SqlParameter("@IDNUM", SqlDbType.NVarChar, 50);
            param[1].Value = IDNUM;

            param[2] = new SqlParameter("@IDDATE", SqlDbType.NVarChar, 50);
            param[2].Value = IDDATE;

            param[3] = new SqlParameter("@IDSOURCE", SqlDbType.NVarChar, 50);
            param[3].Value = IDSOURCE;

            DAL.ExecuteCommand("ADD_TABLEINFO", param);
            DAL.Close();
        }*/
        public void UPDATE_STUDENT(string STUDENT_ID, string NAME_ENGLISH, string GENDER_ARABIC, string GENDER_ENGLISH, string NATIONALTY_ARABIC, string NATIONALTY_ENGLISH, string BIRTHDAY_ARABIC, string BRTHDAY_ENGLISH, string PLACE_BIRTH_ARABIC, string PLACE_BIRTH_ENGLISH, string WORK_SIDE_ARABIC, string WORK_SIDE_ENGLISH, string CURRNENT_ADDRESS, string EMAIL, string HOME_PHONE, string MOBILE, string FAX, string COUNTRY, string DATE2, string UNIVERSITY, string AVERAGE, string TOTAL_RESULT, string PLATE_NUMBER, string SYSTEM_TYPE, string MARK_TYPE, string TOPIC_ARABIC, string TOPIC_ENGLISH, int SPECIALIZATION_ID,
            string SPECIALIZATION, string DEPARTMENT1, string DEPARTMENT2, string COLLEGE1, string COLLEGE2, string QUALIFICATION, string PROGRAM_NUMBER
            , string REQUIRED_DEGREE, string NAME_ARABIC, string IDTYPE, string IDNUM, string IDDATE, string IDSOURCE, string YEARREGISTERDATE, string FIRSTACCEPTANCE, string LASTACCEPTANCE, string PERIODSTUDY, string STARTDATE, string ENDDATE, string REGISTERDATE, string SUPPORTSIDE, string SUPPORTTYPE, string CARDNUMBER, string DATECARD, string DETAILS1, string m1_num, string m2_num, string m3_num, string m1_DATE, string m2_DATE, string m3_DATE, string  DETAILS2, string NAME_doc, string edu_degree, string committee1, string uni, string college_committee, string dept_committee, string un1, string  un2, string un3, string un4, string un5, string un6,
            string NAME_doc2, string edu_degree2, string committee2, string uni2, string college_committee2, string dept_committee2, byte[] PIC_IMAGE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[79];

            param[0] = new SqlParameter("@STUDENT_ID", SqlDbType.NVarChar, 50);
            param[0].Value = STUDENT_ID;

            param[1] = new SqlParameter("@NAME_ENGLISH", SqlDbType.NVarChar, 50);
            param[1].Value = NAME_ENGLISH;

            param[2] = new SqlParameter("@GENDER_ARABIC", SqlDbType.NVarChar, 50);
            param[2].Value = GENDER_ARABIC;

            param[3] = new SqlParameter("@GENDER_ENGLISH", SqlDbType.NVarChar, 50);
            param[3].Value = GENDER_ENGLISH;

            param[4] = new SqlParameter("@NATIONALTY_ARABIC", SqlDbType.NVarChar, 50);
            param[4].Value = NATIONALTY_ARABIC;

            param[5] = new SqlParameter("@NATIONALTY_ENGLISH", SqlDbType.NVarChar, 50);
            param[5].Value = NATIONALTY_ENGLISH;

            param[6] = new SqlParameter("@BIRTHDAY_ARABIC", SqlDbType.NVarChar, 50);
            param[6].Value = BIRTHDAY_ARABIC;

            param[7] = new SqlParameter("@BRTHDAY_ENGLISH", SqlDbType.NVarChar, 50);
            param[7].Value = BRTHDAY_ENGLISH;

            param[8] = new SqlParameter("@PLACE_BIRTH_ARABIC", SqlDbType.NVarChar, 50);
            param[8].Value = PLACE_BIRTH_ARABIC;

            param[9] = new SqlParameter("@PLACE_BIRTH_ENGLISH", SqlDbType.NVarChar, 50);
            param[9].Value = PLACE_BIRTH_ENGLISH;

            param[10] = new SqlParameter("@WORK_SIDE_ARABIC", SqlDbType.NVarChar, 50);
            param[10].Value = WORK_SIDE_ARABIC;

            param[11] = new SqlParameter("@WORK_SIDE_ENGLISH", SqlDbType.NVarChar, 50);
            param[11].Value = WORK_SIDE_ENGLISH;

            param[12] = new SqlParameter("@CURRNENT_ADDRESS", SqlDbType.NVarChar, 50);
            param[12].Value = CURRNENT_ADDRESS;

            param[13] = new SqlParameter("EMAIL", SqlDbType.NVarChar, 50);
            param[13].Value = EMAIL;

            param[14] = new SqlParameter("@HOME_PHONE", SqlDbType.NVarChar, 50);
            param[14].Value = HOME_PHONE;

            param[15] = new SqlParameter("@MOBILE", SqlDbType.NVarChar, 50);
            param[15].Value = MOBILE;

            param[16] = new SqlParameter("@FAX", SqlDbType.NVarChar, 50);
            param[16].Value = FAX;

            param[17] = new SqlParameter("@COUNTRY", SqlDbType.NVarChar, 50);
            param[17].Value = COUNTRY;

            param[18] = new SqlParameter("@DATE2", SqlDbType.NVarChar, 50);
            param[18].Value = DATE2;

            param[19] = new SqlParameter("@UNIVERSITY", SqlDbType.NVarChar, 50);
            param[19].Value = UNIVERSITY;

            param[20] = new SqlParameter("@AVERAGE", SqlDbType.NVarChar, 50);
            param[20].Value = AVERAGE;

            param[21] = new SqlParameter("@TOTAL_RESULT", SqlDbType.NVarChar, 50);
            param[21].Value = TOTAL_RESULT;

            param[22] = new SqlParameter("@PLATE_NUMBER", SqlDbType.NVarChar, 50);
            param[22].Value = PLATE_NUMBER;

            param[23] = new SqlParameter("@SYSTEM_TYPE", SqlDbType.NVarChar, 50);
            param[23].Value = SYSTEM_TYPE;

            param[24] = new SqlParameter("@MARK_TYPE", SqlDbType.NVarChar, 50);
            param[24].Value = MARK_TYPE;

            param[25] = new SqlParameter("@TOPIC_ARABIC", SqlDbType.NVarChar, 50);
            param[25].Value = TOPIC_ARABIC;

            param[26] = new SqlParameter("@TOPIC_ENGLISH", SqlDbType.NVarChar, 50);
            param[26].Value = TOPIC_ENGLISH;

            param[27] = new SqlParameter("@SPECIALIZATION_ID", SqlDbType.Int);
            param[27].Value = SPECIALIZATION_ID;

            param[28] = new SqlParameter("@SPECIALIZATION", SqlDbType.NVarChar, 50);
            param[28].Value = SPECIALIZATION;

            param[29] = new SqlParameter("@DEPARTMENT1", SqlDbType.NVarChar, 50);
            param[29].Value = DEPARTMENT1;

            param[30] = new SqlParameter("@DEPARTMENT2", SqlDbType.NVarChar, 50);
            param[30].Value = DEPARTMENT2;

            param[31] = new SqlParameter("@COLLEGE1", SqlDbType.NVarChar, 50);
            param[31].Value = COLLEGE1;

            param[32] = new SqlParameter("@COLLEGE2", SqlDbType.NVarChar, 50);
            param[32].Value = COLLEGE2;

            param[33] = new SqlParameter("@QUALIFICATION", SqlDbType.NVarChar, 50);
            param[33].Value = QUALIFICATION;

            param[34] = new SqlParameter("@PROGRAM_NUMBER", SqlDbType.NVarChar, 50);
            param[34].Value = PROGRAM_NUMBER;

            param[35] = new SqlParameter("@REQUIRED_DEGREE", SqlDbType.NVarChar, 50);
            param[35].Value = REQUIRED_DEGREE;

            param[36] = new SqlParameter("@NAME_ARABIC", SqlDbType.NVarChar, 50);
            param[36].Value = NAME_ARABIC;

            param[37] = new SqlParameter("@IDTYPE", SqlDbType.NVarChar, 50);
            param[37].Value = IDTYPE;

            param[38] = new SqlParameter("@IDNUM", SqlDbType.NVarChar, 50);
            param[38].Value = IDNUM;

            param[39] = new SqlParameter("@IDDATE", SqlDbType.NVarChar, 50);
            param[39].Value = IDDATE;

            param[40] = new SqlParameter("@IDSOURCE", SqlDbType.NVarChar, 50);
            param[40].Value = IDSOURCE;

            param[41] = new SqlParameter("@PIC_IMAGE", SqlDbType.Image);
            param[41].Value = PIC_IMAGE;

            param[41] = new SqlParameter("@YEARREGISTERDATE", SqlDbType.NVarChar, 50);
            param[41].Value = YEARREGISTERDATE;

            param[42] = new SqlParameter("@FIRSTACCEPTANCE", SqlDbType.NVarChar, 50);
            param[42].Value = FIRSTACCEPTANCE;

            param[43] = new SqlParameter("@LASTACCEPTANCE", SqlDbType.NVarChar, 50);
            param[43].Value = LASTACCEPTANCE;

            param[44] = new SqlParameter("@PERIODSTUDY", SqlDbType.NVarChar, 50);
            param[44].Value = PERIODSTUDY;

            param[45] = new SqlParameter("@STARTDATE", SqlDbType.NVarChar, 50);
            param[45].Value = STARTDATE;

            param[46] = new SqlParameter("@ENDDATE", SqlDbType.NVarChar, 50);
            param[46].Value = ENDDATE;

            param[47] = new SqlParameter("@REGISTERDATE", SqlDbType.NVarChar, 50);
            param[47].Value = REGISTERDATE;

            param[48] = new SqlParameter("@SUPPORTSIDE", SqlDbType.NVarChar, 50);
            param[48].Value = SUPPORTSIDE;

            param[49] = new SqlParameter("@SUPPORTTYPE", SqlDbType.NVarChar, 50);
            param[49].Value = SUPPORTTYPE;

            param[50] = new SqlParameter("@CARDNUMBER", SqlDbType.NVarChar, 50);
            param[50].Value = CARDNUMBER;

            param[51] = new SqlParameter("@DATECARD", SqlDbType.NVarChar, 50);
            param[51].Value = DATECARD;

            param[52] = new SqlParameter("@DETAILS1", SqlDbType.NVarChar, 50);
            param[52].Value = DETAILS1;

            param[53] = new SqlParameter("@m1_num", SqlDbType.NVarChar, 50);
            param[53].Value = m1_num;

            param[54] = new SqlParameter("@m2_num", SqlDbType.NVarChar, 50);
            param[54].Value = m2_num;

            param[55] = new SqlParameter("@m3_num", SqlDbType.NVarChar, 50);
            param[55].Value = m3_num;

            param[56] = new SqlParameter("@m1_DATE", SqlDbType.NVarChar, 50);
            param[56].Value = m1_DATE;

            param[57] = new SqlParameter("@m2_DATE", SqlDbType.NVarChar, 50);
            param[57].Value = m2_DATE;

            param[58] = new SqlParameter("@m3_DATE", SqlDbType.NVarChar, 50);
            param[58].Value = m3_DATE;

            param[59] = new SqlParameter("@DETAILS2", SqlDbType.NVarChar, 50);
            param[59].Value = DETAILS2;

            param[60] = new SqlParameter("@NAME_doc", SqlDbType.NVarChar, 50);
            param[60].Value = NAME_doc;

            param[61] = new SqlParameter("@edu_degree", SqlDbType.NVarChar, 50);
            param[61].Value = edu_degree;

            param[62] = new SqlParameter("@committee1", SqlDbType.NVarChar, 50);
            param[62].Value = committee1;

            param[63] = new SqlParameter("@uni", SqlDbType.NVarChar, 50);
            param[63].Value = uni;

            param[64] = new SqlParameter("@college_committee", SqlDbType.NVarChar, 50);
            param[64].Value = college_committee;

            param[65] = new SqlParameter("@dept_committee", SqlDbType.NVarChar, 50);
            param[65].Value = dept_committee;

            param[66] = new SqlParameter("@un1", SqlDbType.NVarChar, 50);
            param[66].Value = un1;

            param[67] = new SqlParameter("@un2", SqlDbType.NVarChar, 50);
            param[67].Value = un2;

            param[68] = new SqlParameter("@un3", SqlDbType.NVarChar, 50);
            param[68].Value = un3;

            param[69] = new SqlParameter("@un4", SqlDbType.NVarChar, 50);
            param[69].Value = un4;

            param[70] = new SqlParameter("@un5", SqlDbType.NVarChar, 50);
            param[70].Value = un5;

            param[71] = new SqlParameter("@un6", SqlDbType.NVarChar, 50);
            param[71].Value = un6;

            param[72] = new SqlParameter("@NAME_doc2", SqlDbType.NVarChar, 50);
            param[72].Value = NAME_doc2;

            param[73] = new SqlParameter("@edu_degree2", SqlDbType.NVarChar, 50);
            param[73].Value = edu_degree2;

            param[74] = new SqlParameter("@committee2", SqlDbType.NVarChar, 50);
            param[74].Value = committee2;

            param[75] = new SqlParameter("@uni2", SqlDbType.NVarChar, 50);
            param[75].Value = uni2;

            param[76] = new SqlParameter("@college_committee2", SqlDbType.NVarChar, 50);
            param[76].Value = college_committee2;

            param[77] = new SqlParameter("@dept_committee2", SqlDbType.NVarChar, 50);
            param[77].Value = dept_committee2;



            param[78] = new SqlParameter("@PIC_IMAGE", SqlDbType.Image);
            param[78].Value = PIC_IMAGE;



            DAL.ExecuteCommand("UPDATE_STUDENT", param);
            DAL.Close();


        }

        public DataTable VerifyproductID(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = ID;
            DT = DAL.SelectData("VerifyproductID", param);
            DAL.Close();
            return DT;
        }
        public DataTable GET_ALL_STUDENTS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("GET_ALL_STUDENTS", null);
            DAL.Close();
            return DT;
        }
        public DataTable SearchStudent(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = ID;
            DT = DAL.SelectData("SearchStudent", param);
            DAL.Close();
            return DT;
        }

        public DataTable GET_IMAGE_STUDENT(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = ID;
            DT = DAL.SelectData("GET_IMAGE_STUDENT", param);
            DAL.Close();
            return DT;
        }

        public void deletestudent( string STUDENT_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
        
            param[0] = new SqlParameter("@Student_ID", SqlDbType.VarChar, 50);
            param[0].Value =STUDENT_ID;

            DAL.ExecuteCommand("deletestudent", param);
            DAL.Close();


        }

        public void ADD_MINUTE(string MINUTES_ID, string uni_year, string day, string min_date1, string center, string dept, string result, string min_date2, string year_no, string notes, string MINUTES_DECISION)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[11];

            param[0] = new SqlParameter("@uni_year", SqlDbType.NVarChar, 50);
            param[0].Value = uni_year;

            param[1] = new SqlParameter("@day", SqlDbType.NVarChar, 50);
            param[1].Value = day;

            param[2] = new SqlParameter("@min_date1 ", SqlDbType.NVarChar, 50);
            param[2].Value = min_date1;

            param[3] = new SqlParameter("@center", SqlDbType.NVarChar, 50);
            param[3].Value = center;

            param[4] = new SqlParameter("@dept", SqlDbType.NVarChar, 50);
            param[4].Value = dept;

            param[5] = new SqlParameter("@result", SqlDbType.NVarChar, 50);
            param[5].Value = result;

            param[6] = new SqlParameter("@min_date2", SqlDbType.NVarChar, 50);
            param[6].Value = min_date2;

            param[7] = new SqlParameter("@year_no", SqlDbType.NVarChar, 50);
            param[7].Value = year_no;

            param[8] = new SqlParameter("@notes", SqlDbType.NVarChar, 50);
            param[8].Value = notes;

            param[9] = new SqlParameter("@MINUTES_DECISION", SqlDbType.NVarChar, 50);
            param[9].Value = MINUTES_DECISION;

            param[10] = new SqlParameter("@MINUTES_ID", SqlDbType.NVarChar, 50);
            param[10].Value = MINUTES_ID;

           


            DAL.ExecuteCommand("ADD_MINUTE", param);
            DAL.Close();


        }



        public void ADD_table(string name, string nationality, string year )
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[3];



            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            param[0].Value = name;

            param[1] = new SqlParameter("@nationality", SqlDbType.NVarChar, 50);
            param[1].Value = nationality;

            param[2] = new SqlParameter("@year", SqlDbType.NVarChar, 50);
            param[2].Value = year;




            DAL.ExecuteCommand("ADD_table", param);
            DAL.Close();


        }


        
    }
}
