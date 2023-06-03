using DAL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DAL.Entity;


namespace SchoolManagementSystem.Setup
{
    public partial class StudentRegistration : System.Web.UI.Page
    {

        StudentBLL ObjStuBLL = new StudentBLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            CommonDAL.Fillddl(ddlDistrict, @"SELECT DistrictId, DistrictName FROM Con_District
                ORDER BY DistrictName", "DistrictName", "DistrictId");
       
        }

        protected void ddlDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommonDAL.Fillddl(ddlUpazila, @"SELECT UpazilaId, UpazilaName FROM Con_Upazila
            WHERE (DistrictId = " + ddlDistrict.SelectedValue + ") ORDER BY UpazilaName", "UpazilaName", "UpazilaId");
        }




        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckFieldValue() == false)
            {
                Save();
                LoadGrid();
            }
        }


        private void Save()
        {
            int save = 0;

            EStudents ObjStu = new EStudents();

            ObjStu.RegistrationNo = txtRegistration.Text;
            ObjStu.FirstName = txtFirstName.Text;
            ObjStu.LastName = txtRegistration.Text;
            ObjStu.ContactNo = txtRegistration.Text;
            ObjStu.FatherName = txtRegistration.Text;
            ObjStu.FatherContactNo = txtRegistration.Text;
            ObjStu.FatherOccupation = txtRegistration.Text;
            ObjStu.MotherName = txtRegistration.Text;
            ObjStu.MotherContactNo = txtRegistration.Text;
            ObjStu.GurdianName = txtRegistration.Text;
            ObjStu.DistrictId = int.Parse(ddlDistrict.SelectedValue);
            ObjStu.UpazilaId = int.Parse(ddlUpazila.SelectedValue);
            ObjStu.Address = txtRegistration.Text;
            ObjStu.BloodGroup = txtRegistration.Text;
            //ObjStu.ReligionId = int.Parse(ddlReligion.SelectedValue);
            ObjStu.StuPic = txtRegistration.Text;
            ObjStu.EntryBy = int.Parse(Session["UserId"].ToString());




            if (btnSave.Text == "Save")
            {
                ObjStu.Action = 1;
                ObjStu.StudentId = 0;
            }
            else if (btnSave.Text == "Update")
            {
                ObjStu.Action = 2;
                ObjStu.StudentId = int.Parse(hdnUpdateInstituteId.Value);
            }

            save = ObjStuBLL.Students_insertUpdateDeleteInfo(ObjStu);
            if (save > 0)
            {
                rmMsg.SuccessMessage = btnSave.Text + " Successfull.";
                btnSave.Text = "Save";
            }

        }


        private void LoadGrid()

        {
            DataTable dt = new DataTable();

            dt = ObjStuBLL.SetupSp_StudentInfo();
            if (dt.Rows.Count > 0)
            {
                gvStudent.DataSource = dt;
                gvStudent.DataBind();
            }
            else
            {
                gvStudent.DataSource = null;
                gvStudent.DataBind();
            }
        }

        private bool CheckFieldValue()
        {
            bool IsReq = false;

            if (txtRegistration.Text == "")
            {
                IsReq = true;
                rmMsg.FailureMessage = " Registration No can't be empty";
            }
            else if (txtFirstName.Text == "")
            {
                IsReq = true;
                rmMsg.FailureMessage = "FirstName can't be empty";
            }
            else if (txtLastName.Text == "")
            {
                IsReq = true;
                rmMsg.FailureMessage = "LastName can't be empty";
            }
            else if (txtContact.Text == "")
            {
                IsReq = true;
                rmMsg.FailureMessage = "Contact can't be empty";
            }
            //else if (ddlDistrict.SelectedValue == "0")
            //{
            //    IsReq = true;
            //    rmMsg.SuccessMessage = "Select District.";
            //}
            //else if (ddlUpazila.SelectedValue == "0" || ddlUpazila.SelectedIndex == -1)
            //{
            //    IsReq = true;
            //    rmMsg.FailureMessage = "Select Upazila.";
            //}
            else if (txtAddress.Text == "")
            {
                IsReq = true;
                rmMsg.FailureMessage = "Address can't be empty";
            }



            return IsReq;
        }

       
    }
}