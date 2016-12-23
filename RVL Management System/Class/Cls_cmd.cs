﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;
using RVL_Management_System.Forms;

namespace RVL_Management_System.Class
{
    class Cls_cmd
    {
        public static void userLogin()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
           
            conn.Open();

            cmd.Connection = conn;
            string InsertLogin = "INSERT INTO tblLogin(AcctID,UID,UN,PW)VALUES(@acctID,@uid,@un,@pw)";
            cmd.Parameters.AddWithValue("acctID", Frm_UserAdd.acctID);
            cmd.Parameters.AddWithValue("uid", Frm_UserAdd.uID);
            cmd.Parameters.AddWithValue("un", Frm_UserAdd.userName);
            cmd.Parameters.AddWithValue("pw", Frm_UserAdd.Password);
            cmd.CommandText = InsertLogin;
            cmd.ExecuteNonQuery();

            MessageBox.Show("Successfully added this information to the database.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conn.Close();
            cmd.Parameters.Clear();
        }

        public static void userAdd()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string INSERT = "INSERT INTO tblUser(AcctID,Full_Name,Email)VALUES(@acctID,@fn,@email)";
            cmd.Parameters.AddWithValue("acctID", Frm_UserAdd.acctID);
            cmd.Parameters.AddWithValue("fn", Frm_UserAdd.fullName);
            cmd.Parameters.AddWithValue("email", Frm_UserAdd.email);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();

            conn.Close();

            cmd.Parameters.Clear();
        }

        public static void leadAdd()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string INSERT = "INSERT INTO tblLeadSource(LeadDescription)VALUES(@leadD)";
            cmd.Parameters.AddWithValue("leadD", Forms.Frm_AddLeadSource.leadDes);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Successfully saved this Marketing Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }
        

        public static void marketingAdd()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string INSERT = "INSERT INTO tblMarketing(Lead_Received,Last_Name,First_Name,Middle_Name,Phone_Number,Email_Address,Issue_Description,Lead_Source,Lead_Status,Priority,Memo,Lead_Assigned,Lead_Assesment)VALUES(@leadReceived,@ln,@fn,@mn,@pNum,@eAdd,@issueDes,@leadSource,@leadStats,@priority,@memo,@leadAssigned,@leadAssesment)";
            cmd.Parameters.AddWithValue("leadReceived", Frm_LeadGeneration.leadReceived);
            cmd.Parameters.AddWithValue("ln", Frm_LeadGeneration.lastName);
            cmd.Parameters.AddWithValue("fn", Frm_LeadGeneration.firstName);
            cmd.Parameters.AddWithValue("mn", Frm_LeadGeneration.middleName);
            cmd.Parameters.AddWithValue("pNum", Frm_LeadGeneration.phoneNumber);
            cmd.Parameters.AddWithValue("eAdd", Frm_LeadGeneration.emailAddress);
            cmd.Parameters.AddWithValue("issueDes", Frm_LeadGeneration.issueDescription);
            cmd.Parameters.AddWithValue("leadSource", Frm_LeadGeneration.leadSource);
            cmd.Parameters.AddWithValue("leadStats", Frm_LeadGeneration.leadStat);
            cmd.Parameters.AddWithValue("priority", Frm_LeadGeneration.priority);
            cmd.Parameters.AddWithValue("memo", Frm_LeadGeneration.memo);
            cmd.Parameters.AddWithValue("leadAssigned", Frm_LeadGeneration.leadAssigned);
            cmd.Parameters.AddWithValue("leadAssesment", Frm_LeadGeneration.leadAssesment);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Successfully saved this Marketing Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void marketingUpdate()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string INSERT = "INSERT INTO tblMarketing(Lead_Received,Last_Name,First_Name,Middle_Name,Phone_Number,Email_Address,Issue_Description,Lead_Source,Other,Lead_Status,Priority,Memo,Lead_Assigned,Lead_Assesment)VALUES(@leadReceived,@ln,@fn,@mn,@pNum,@eAdd,@issueDes,@leadSource,@other,@leadStats,@priority,@memo,@leadAssigned,@leadAssesment)";
            cmd.Parameters.AddWithValue("leadReceived", Frm_MarketingUpdate.leadReceived);
            cmd.Parameters.AddWithValue("ln", Frm_MarketingUpdate.lastName);
            cmd.Parameters.AddWithValue("fn", Frm_MarketingUpdate.firstName);
            cmd.Parameters.AddWithValue("mn", Frm_MarketingUpdate.middleName);
            cmd.Parameters.AddWithValue("pNum", Frm_MarketingUpdate.phoneNumber);
            cmd.Parameters.AddWithValue("eAdd", Frm_MarketingUpdate.emailAddress);
            cmd.Parameters.AddWithValue("issueDes", Frm_MarketingUpdate.issueDescription);
            cmd.Parameters.AddWithValue("leadSource", Frm_MarketingUpdate.leadSource);
            cmd.Parameters.AddWithValue("other", Frm_MarketingUpdate.other);
            cmd.Parameters.AddWithValue("leadStats", Frm_MarketingUpdate.leadStat);
            cmd.Parameters.AddWithValue("priority", Frm_MarketingUpdate.priority);
            cmd.Parameters.AddWithValue("memo", Frm_MarketingUpdate.memo);
            cmd.Parameters.AddWithValue("leadAssigned", Frm_MarketingUpdate.leadAssigned);
            cmd.Parameters.AddWithValue("leadAssesment", Frm_MarketingUpdate.leadAssesment);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Successfully updated this Marketing Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void updateLogin()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();

            conn.Open();

            cmd.Connection = conn;
            string InsertLogin = "UPDATE tblLogin SET AcctID=@acctID, UID=@uid, UN =@un, PW=@Pw WHERE LID =@lid";
            cmd.Parameters.AddWithValue("acctID", Frm_UserEdit.acctID);
            cmd.Parameters.AddWithValue("uid", Frm_UserEdit.userID);
            cmd.Parameters.AddWithValue("un", Frm_UserEdit.userName);
            cmd.Parameters.AddWithValue("pw", Frm_UserEdit.passWord);
            cmd.Parameters.AddWithValue("lid", Frm_UserEdit.loginID);
            cmd.CommandText = InsertLogin;
            cmd.ExecuteNonQuery();

            MessageBox.Show("Successfully updated the information for this login.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conn.Close();
            cmd.Parameters.Clear();
        }

        public static void updateUser()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string UPDATE = "UPDATE tblUser SET AcctID = @acctID, Last_Name=@ln, First_Name = @fn, Middle_Name=@mn WHERE UID = @uid";
            cmd.Parameters.AddWithValue("acctID", Frm_UserEdit.acctID);
            cmd.Parameters.AddWithValue("ln", Frm_UserEdit.lastName);
            cmd.Parameters.AddWithValue("fn", Frm_UserEdit.firstName);
            cmd.Parameters.AddWithValue("mn", Frm_UserEdit.middleName);
            cmd.Parameters.AddWithValue("uid", Frm_UserEdit.userID);
            cmd.CommandText = UPDATE;
            cmd.ExecuteNonQuery();

            MessageBox.Show("Successfully updated the User Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conn.Close();
            cmd.Parameters.Clear();
        }

        public static void taskAssign()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string INSERT = "UPDATE tblUser SET TaskAssign=@taskAssign WHERE UID = @uid";
            cmd.Parameters.AddWithValue("TaskAssign", Frm_Tasks.taskAssign);
            cmd.Parameters.AddWithValue("UID", Frm_Tasks.uID);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();

            MessageBox.Show("Task assign to this person.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();

            cmd.Parameters.Clear();
        }
    }
}
