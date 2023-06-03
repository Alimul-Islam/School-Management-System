<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/AdminMaster.Master" AutoEventWireup="true" CodeBehind="StudentRegistration.aspx.cs" Inherits="SchoolManagementSystem.Setup.StudentRegistration" %>

<%@ Register Src="~/ResponseMessage.ascx" TagPrefix="uc1" TagName="ResponseMessage" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="content-wrapper">
        <div class="container">
            <!-- general form elements -->
            <div class="card card-primary">
                <div class="card-header">
                    <h3 class="card-title">Create New Student Profile</h3>
                </div>
                <uc1:ResponseMessage runat="server"  id="rmMsg" />
                <!-- /.card-header -->
                <!-- form start -->
                <div class="card-body">
                    <div class="row">
                        <div class="col-md-3">
                            <div class="form-group ">
                                <label class="form-label">Registration No </label>
                                <asp:TextBox ID="txtRegistration" runat="server"  placeholder="Enter Registration No" CssClass="form-control"></asp:TextBox>

                            </div>

                        </div>
                        <div class="col-md-3">
                            <div class="form-group ">
                                <label class="form-label">First Name</label>
                                <asp:TextBox ID="txtFirstName" runat="server" placeholder="Enter First Name" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <div class="form-group ">
                                <label class="form-label">Last Name</label>
                                <asp:TextBox ID="txtLastName" runat="server" placeholder="Enter Last Name" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <div class="form-group ">
                                <label class="form-label">Contact No </label>
                                <asp:TextBox ID="txtContact" runat="server" placeholder="Enter Contact No" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>

                        <div class="col-md-3">
                            <div class="form-group ">
                                <label class="form-label">Father Name </label>
                                <asp:TextBox ID="txFatherName" runat="server" placeholder="Enter Father Name" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>

                        <div class="col-md-3">
                            <div class="form-group ">
                                <label class="form-label">Father Contact No </label>
                                <asp:TextBox ID="txtFatherContactNo" runat="server" placeholder="Enter Name Contact No" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>

                        <div class="col-md-3">
                            <div class="form-group ">
                                <label class="form-label">Father Occupation </label>
                                <asp:TextBox ID="txtFatherOccupation" runat="server" placeholder="Enter Father Occupation" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>



                        <div class="col-md-3">
                            <div class="form-group ">
                                <label class="form-label">Mother Name </label>
                                <asp:TextBox ID="txtMotherName" runat="server" placeholder="Enter Mother Name " CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>

                        <div class="col-md-3">
                            <div class="form-group ">
                                <label class="form-label">Mother Contact No </label>
                                <asp:TextBox ID="txtMotherContactNo" runat="server" placeholder="Enter Mother Contact No" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>

                        <div class="col-md-3">
                            <div class="form-group ">
                                <label class="form-label">Mother Occupation </label>
                                <asp:TextBox ID="MotherOccupationstxt" runat="server" placeholder="Enter Mother Occupation" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>


                        <div class="col-md-3">
                            <div class="form-group ">
                                <label class="form-label">Local Gurdian Name</label>
                                <asp:TextBox ID="txtGurdianName" runat="server" placeholder="Enter Gurdian Name" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>


                        
                        <div class="col-md-3">
                            <div class="form-group ">
                                <label class="form-label">Relation</label>
                                <asp:TextBox ID="txtRelation" runat="server" placeholder="Enter Relation" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>

                        <div class="col-md-3">
                            <div class="form-group ">
                                <label class="form-label">Blood Group</label>
                                 <asp:DropDownList ID="ddlBloodGroup" runat="server" CssClass="form-control" AutoPostBack="True">
                                     <asp:ListItem Value="0">Select...</asp:ListItem>
                                     <asp:ListItem>A+ </asp:ListItem>
                                     <asp:ListItem>B+</asp:ListItem>
                                     <asp:ListItem>AB+ </asp:ListItem>
                                     <asp:ListItem>O+</asp:ListItem>
                                     <asp:ListItem>A- </asp:ListItem>
                                     <asp:ListItem>B-</asp:ListItem>
                                     <asp:ListItem>AB- </asp:ListItem>
                                     <asp:ListItem>B-</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>

                        <div class="col-md-3">
                            <div class="form-group ">
                                <label class="form-label">District </label>
                                <asp:DropDownList ID="ddlDistrict" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddlDistrict_SelectedIndexChanged">

                                </asp:DropDownList>
                            </div>
                        </div>

                        <div class="col-md-3">
                            <div class="form-group ">
                                <label class="form-label">Upazila </label>
                                <asp:DropDownList ID="ddlUpazila" runat="server" CssClass="form-control" ></asp:DropDownList>
                            </div>
                        </div>


                           <div class="col-md-3">
                            <div class="form-group ">
                                <label class="form-label">Religion</label>
                                <asp:DropDownList ID="ddlReligion" runat="server" CssClass="form-control" AutoPostBack="True">
                                    <asp:ListItem Value="0">Select...</asp:ListItem>
                                    <asp:ListItem>Islam </asp:ListItem>
                                    <asp:ListItem>Buddha</asp:ListItem>
                                    <asp:ListItem>Christian </asp:ListItem>
                                    <asp:ListItem>Hindu</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>



                        <div class="col-md-6">
                            <div class="form-group ">
                                <label class="form-label">Address</label>
                                <asp:TextBox ID="txtAddress" runat="server" placeholder="Enter Address  Name" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>


                        
                        <div class="col-md-6">
                            <div class="form-group ">
                                <label class="form-label">Profile Photo</label>
                                <asp:FileUpload ID="FileUpload1" runat="server" placeholder="Upload a Photo" CssClass="form-control" />
                               
                            </div>
                        </div>
                       




                        <div class="col-md-2">
                            <div class="form-group ">
                                <label class="form-label">&nbsp;</label>
                                <asp:Button ID="btnSave" runat="server" CssClass="btn btn-primary form-control" Text="Save" OnClick="btnSave_Click"  />
                            </div>

                        </div>
                    </div>


                </div>

                <div class="card-header ">
                    <h3 class="card-title text-center">Student List</h3>
                </div>

                   <div class="card-body">
                    <div class="row">
                        <div class="col-md-12" style ="overflow:scroll">
                            <div class="form-group ">
                                <asp:HiddenField ID="hdnUpdateInstituteId" runat="server" />
                                <asp:GridView ID="gvStudent" runat="server" CssClass="table table-bordered table-striped" AutoGenerateColumns="false"  Width="100%" >
                                    <Columns>
                                        <asp:BoundField DataField="EIIN_RegistrationNo" HeaderText="EIIN/ Registration No" />
                                        <asp:BoundField DataField="InstituteName" HeaderText="Institute Name" />
                                        <asp:BoundField DataField="Email" HeaderText="Email" />
                                        <asp:BoundField DataField="Phone" HeaderText="Phone" />
                                        <asp:BoundField DataField="DistrictName" HeaderText="District" />
                                        <asp:BoundField DataField="UpazilaName" HeaderText="Upazila" />
                                        <asp:BoundField DataField="Address" HeaderText="Address" />
                                        <asp:BoundField DataField="SchoolType" HeaderText="Institute Type" />

                                         <asp:TemplateField HeaderText="Action">
                                            <ItemTemplate>
                                                <asp:HiddenField ID="hdnInstituteId" runat="server" Value='<%# Eval("InstituteId") %>' />
                                                <asp:ImageButton ID="imgEdit" runat="server" ImageUrl="~/assets/site/images/ico_information.png" CommandName="editc" CommandArgument='<%# Container.DataItemIndex %>' Width="25px" />
                                                 <asp:ImageButton ID="imgDelete" runat="server" ImageUrl="~/assets/img/cancel.png" CommandName="deletec" CommandArgument='<%# Container.DataItemIndex %>' OnClientClick="if ( ! ConfirmationMsg()) return false;" meta:resourcekey="imgDelete" Width="25px" />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>
                    </div>
                </div>
            <!-- /.card -->
        </div>
    </div>
        </div>
</asp:Content>
