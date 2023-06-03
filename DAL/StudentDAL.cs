using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class StudentDAL
    {
        public int Student_InsertUpdateDelete(Entity.EStudents objEstu)
        {
            int ret = 0;
            Database db;
            DbCommand dbcmd;
            db = DatabaseFactory.CreateDatabase("cnn");
            dbcmd = db.GetStoredProcCommand("StudentSp_insertUpdateDelete");

            db.AddInParameter(dbcmd, "Action", DbType.String, objEstu.Action);
            db.AddInParameter(dbcmd, "RegistrationNo", DbType.String, objEstu.StudentId);
            db.AddInParameter(dbcmd, "RegistrationNo", DbType.String, objEstu.RegistrationNo);
            db.AddInParameter(dbcmd, "FirstName", DbType.String, objEstu.FirstName);
            db.AddInParameter(dbcmd, "LastName", DbType.String, objEstu.LastName);
            db.AddInParameter(dbcmd, "ContactNo", DbType.String, objEstu.ContactNo);
            db.AddInParameter(dbcmd, "FatherName", DbType.String, objEstu.FatherName);
            db.AddInParameter(dbcmd, "FatherContactNo", DbType.String, objEstu.FatherContactNo);
            db.AddInParameter(dbcmd, "FatherOccupation", DbType.String, objEstu.FatherOccupation);
            db.AddInParameter(dbcmd, "MotherName", DbType.String, objEstu.MotherName);
            db.AddInParameter(dbcmd, "MotherContactNo", DbType.String, objEstu.MotherContactNo);
            db.AddInParameter(dbcmd, "MotherOcupation", DbType.String, objEstu.MotherOcupation);
            db.AddInParameter(dbcmd, "GurdianName", DbType.String, objEstu.GurdianName);
            db.AddInParameter(dbcmd, "Relation", DbType.String, objEstu.Relation);
            db.AddInParameter(dbcmd, "DistrictId", DbType.String, objEstu.DistrictId);
            db.AddInParameter(dbcmd, "UpazilaId", DbType.String, objEstu.UpazilaId);
            db.AddInParameter(dbcmd, "Address", DbType.String, objEstu.Address);
            db.AddInParameter(dbcmd, "BloodGroup", DbType.String, objEstu.BloodGroup);
            db.AddInParameter(dbcmd, "ReligionId", DbType.String, objEstu.ReligionId);
            db.AddInParameter(dbcmd, "StuPic", DbType.String, objEstu.StuPic);
            db.AddInParameter(dbcmd, "EntryBy", DbType.String, objEstu.EntryBy);


            ret = db.ExecuteNonQuery(dbcmd);

            return ret;
        }
        public DataTable SetupSp_GetInstitute(int InstituteId)
        {
            DataTable dt = new DataTable();
            Database db;
            DbCommand dbcmd;
            db = DatabaseFactory.CreateDatabase("cnn");
            dbcmd = db.GetStoredProcCommand("SetupSp_GetInstitute");
            db.AddInParameter(dbcmd, "InstituteId", DbType.Int32, InstituteId);
            dt = db.ExecuteDataSet(dbcmd).Tables[0];

            return dt;
        }

    }
}
