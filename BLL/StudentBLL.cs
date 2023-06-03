using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Entity;
using System.Data;

namespace BLL
{
     public class StudentBLL
    {
        StudentDAL ObjStuDAL = new StudentDAL();
        public int Students_insertUpdateDeleteInfo(EStudents objEStu)
        {
            int ret = 0;
            ret = ObjStuDAL.Student_InsertUpdateDelete(objEStu);
            return ret;
        }


        public DataTable SetupSp_StudentInfo(int InstituteId = 0)
        {
            DataTable dt = new DataTable();
            dt = ObjStuDAL.SetupSp_GetInstitute(InstituteId);
            return dt;
        }


    }
}
