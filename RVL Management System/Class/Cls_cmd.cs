using System;
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
            string INSERT = "INSERT INTO tblMarketing(Lead_Received,Last_Name,First_Name,Middle_Name,Phone_Number,Email_Address,Issue_Description,Lead_Source,Other,Lead_FollowUp,Lead_Status,Priority,Memo,Lead_Assigned,Lead_Assesment)VALUES(@leadReceived,@ln,@fn,@mn,@pNum,@eAdd,@issueDes,@leadSource,@other,@leadFollow,@leadStats,@priority,@memo,@leadAssigned,@leadAssesment)";
            cmd.Parameters.AddWithValue("leadReceived", Frm_LeadGeneration.leadReceived);
            cmd.Parameters.AddWithValue("ln", Frm_LeadGeneration.lastName);
            cmd.Parameters.AddWithValue("fn", Frm_LeadGeneration.firstName);
            cmd.Parameters.AddWithValue("mn", Frm_LeadGeneration.middleName);
            cmd.Parameters.AddWithValue("pNum", Frm_LeadGeneration.phoneNumber);
            cmd.Parameters.AddWithValue("eAdd", Frm_LeadGeneration.emailAddress);
            cmd.Parameters.AddWithValue("issueDes", Frm_LeadGeneration.issueDescription);
            cmd.Parameters.AddWithValue("leadSource", Frm_LeadGeneration.leadSource);
            cmd.Parameters.AddWithValue("other", Frm_LeadGeneration.other);
            cmd.Parameters.AddWithValue("leadFollow", Frm_LeadGeneration.leadFollow);
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

        public static void companyAdd()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string INSERT = "INSERT INTO tblCompanyLogins(Category_Name,URL_Link,Username,Password,Name_Login_Under,Give_Access_To)VALUES(@catName,@url,@un,@pw,@nameLogin,@giveAccess)";
            cmd.Parameters.AddWithValue("catName", Frm_CompanyLoginsAdd.categoryName);
            cmd.Parameters.AddWithValue("url", Frm_CompanyLoginsAdd.URLlink);
            cmd.Parameters.AddWithValue("un", Frm_CompanyLoginsAdd.userName);
            cmd.Parameters.AddWithValue("pw", Frm_CompanyLoginsAdd.passWord);
            cmd.Parameters.AddWithValue("nameLogin", Frm_CompanyLoginsAdd.nameLogin);
            cmd.Parameters.AddWithValue("giveAccess", Frm_CompanyLoginsAdd.giveAccess);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Successfully saved this Company login Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void landOwnerAdd()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string INSERT = "INSERT INTO tblLandOwner(Land_Owner)VALUES(@landOwner)";
            cmd.Parameters.AddWithValue("landOwner", Frm_LandOwner.landOwner);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Successfully saved this land owner Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void socialMediaAdd()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string INSERT = "INSERT INTO tblSocialMedia(Current_Market_Value,Updated_Price,Title,Social_Media_Notes,Hashtags,Schedule,Pre_Approved,Status,Additional_Notes)VALUES(@currentMarketValue,@updatedPrice,@title,@SocialMediaNotes,@hashtags,@schedule,@preApproved,@status,@additionalNotes)";
            cmd.Parameters.AddWithValue("currentMarketValue", Frm_SocialMediaAdd.currentMarketValue);
            cmd.Parameters.AddWithValue("updatedPrice", Frm_SocialMediaAdd.updatedPrice);
            cmd.Parameters.AddWithValue("title", Frm_SocialMediaAdd.title);
            cmd.Parameters.AddWithValue("SocialMediaNotes", Frm_SocialMediaAdd.socialMediaNotes);
            cmd.Parameters.AddWithValue("hashtags", Frm_SocialMediaAdd.hashtagsToUse);
            cmd.Parameters.AddWithValue("schedule", Frm_SocialMediaAdd.scheduleToBePosted);
            cmd.Parameters.AddWithValue("preApproved", Frm_SocialMediaAdd.preApproved);
            cmd.Parameters.AddWithValue("status", Frm_SocialMediaAdd.status);
            cmd.Parameters.AddWithValue("additionalNotes", Frm_SocialMediaAdd.additionalNotes);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Successfully saved this Social Media Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void marketingUpdate()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string INSERT = "INSERT INTO tblMarketing(Lead_Received,Last_Name,First_Name,Middle_Name,Phone_Number,Email_Address,Issue_Description,Lead_Source,Other,Lead_FollowUp,Lead_Status,Priority,Memo,Lead_Assigned,Lead_Assesment)VALUES(@leadReceived,@ln,@fn,@mn,@pNum,@eAdd,@issueDes,@leadSource,@other,@leadFollow,@leadStats,@priority,@memo,@leadAssigned,@leadAssesment)";
            cmd.Parameters.AddWithValue("leadReceived", Frm_MarketingUpdate.leadReceived);
            cmd.Parameters.AddWithValue("ln", Frm_MarketingUpdate.lastName);
            cmd.Parameters.AddWithValue("fn", Frm_MarketingUpdate.firstName);
            cmd.Parameters.AddWithValue("mn", Frm_MarketingUpdate.middleName);
            cmd.Parameters.AddWithValue("pNum", Frm_MarketingUpdate.phoneNumber);
            cmd.Parameters.AddWithValue("eAdd", Frm_MarketingUpdate.emailAddress);
            cmd.Parameters.AddWithValue("issueDes", Frm_MarketingUpdate.issueDescription);
            cmd.Parameters.AddWithValue("leadSource", Frm_MarketingUpdate.leadSource);
            cmd.Parameters.AddWithValue("other", Frm_MarketingUpdate.other);
            cmd.Parameters.AddWithValue("leadFollow", Frm_MarketingUpdate.leadFollow);
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

        public static void socialMediaUpdate()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string UPDATE = "UPDATE tblSocialMedia SET Current_Market_Value =@currentMarketValue, Updated_Price = @updatedPrice, Title = @title, Social_Media_Notes = @socialMedia, Hashtags = @hashtags, Schedule = @schedule, Pre_Approved = @preApproved, Status = @status, Additional_Notes =@additionalNotes";
            cmd.Parameters.AddWithValue("currentMarketValue", Frm_SocialMediaUpdate.currentMarketValue);
            cmd.Parameters.AddWithValue("updatedPrice", Frm_SocialMediaUpdate.updatePrice);
            cmd.Parameters.AddWithValue("title", Frm_SocialMediaUpdate.title);
            cmd.Parameters.AddWithValue("socialMedia", Frm_SocialMediaUpdate.socialMediaNotes);
            cmd.Parameters.AddWithValue("hashtags", Frm_SocialMediaUpdate.hashtags);
            cmd.Parameters.AddWithValue("schedule", Frm_SocialMediaUpdate.schedule);
            cmd.Parameters.AddWithValue("preApproved", Frm_SocialMediaUpdate.preApproved);
            cmd.Parameters.AddWithValue("status", Frm_SocialMediaUpdate.status);
            cmd.Parameters.AddWithValue("additionalNotes", Frm_SocialMediaUpdate.additionalNotes);
            cmd.CommandText = UPDATE;
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Successfully updated this social media Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        public static void companyUpdate()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string UPDATE = "UPDATE tblCompanyLogins SET Category_Name = @cn, URL_Link=@url, Username = @un, Password=@pw, Name_Login_Under = @nLogin, Give_Access_To = @gAccessTo WHERE CID = @cid";
            cmd.Parameters.AddWithValue("cn", Frm_CompanyLoginsUpdate.categoryName);
            cmd.Parameters.AddWithValue("url", Frm_CompanyLoginsUpdate.URLlink);
            cmd.Parameters.AddWithValue("un", Frm_CompanyLoginsUpdate.userName);
            cmd.Parameters.AddWithValue("pw", Frm_CompanyLoginsUpdate.passWord);
            cmd.Parameters.AddWithValue("nLogin", Frm_CompanyLoginsUpdate.nameLogin);
            cmd.Parameters.AddWithValue("gAccessTo", Frm_CompanyLoginsUpdate.giveAccess);
            cmd.Parameters.AddWithValue("cid", Frm_CompanyLoginsUpdate.categoryID);
            cmd.CommandText = UPDATE;
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Successfully updated this Company Logins Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        public static void companyDelete()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string UPDATE = "DELETE tblCompanyLogins WHERE CID = @cid";
            cmd.Parameters.AddWithValue("cid", Frm_CompanyLoginsDelete.CID);
            cmd.CommandText = UPDATE;
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Successfully deleted this Company Logins Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }
    }
}
