using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
   public class EStudents
    {
        public int Action { get; set; }
        public int StudentId { get; set; }
        public string RegistrationNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string FatherName { get; set; }
        public string FatherContactNo { get; set; }
        public string FatherOccupation { get; set; }
        public string MotherName { get; set; }
        public string MotherContactNo { get; set; }
        public string MotherOcupation { get; set; }
        public string GurdianName { get; set; }
        public string Relation { get; set; }
        public int DistrictId { get; set; }
        public int UpazilaId { get; set; }
        public string Address { get; set; }
        public string BloodGroup { get; set; }
        public int ReligionId { get; set; }
        public string StuPic { get; set; }
        public int EntryBy { get; set; }
        public string EntryDate { get; set; }
        public int UpdateBy { get; set; }
        public string UpdateDate { get; set; }

    }
}
