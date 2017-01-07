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
using MetroFramework;

namespace RVL_Management_System.Class
{
    class Cls_cmd
    {
        public static void userLogin()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            Frm_UserAdd _owner = new Frm_UserAdd();

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

            MetroMessageBox.Show(_owner, "Successfully added these information to the database.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conn.Close();
            cmd.Parameters.Clear();
        }

        public static void userAdd()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            Frm_AddLeadSource _owner = new Frm_AddLeadSource();

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

            MetroMessageBox.Show(_owner, "Successfully saved these User Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void leadAdd()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            Frm_AddLeadSource _owner = new Frm_AddLeadSource();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string INSERT = "INSERT INTO tblLeadSource(LeadDescription)VALUES(@leadD)";
            cmd.Parameters.AddWithValue("leadD", Forms.Frm_AddLeadSource.leadDes);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();

            conn.Close();
            MetroMessageBox.Show(_owner, "Successfully saved these Marketing Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }
        

        public static void marketingAdd()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            Frm_LeadGeneration _owner = new Frm_LeadGeneration();

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
            MetroMessageBox.Show(_owner, "Successfully saved these Marketing Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void companyAdd()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            Frm_LandOwner _owner = new Frm_LandOwner();

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
            MetroMessageBox.Show(_owner, "Successfully saved these Company login Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void landOwnerAdd()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            Frm_LandOwner _owner = new Frm_LandOwner();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string INSERT = "INSERT INTO tblLandOwner(Land_Owner)VALUES(@landOwner)";
            cmd.Parameters.AddWithValue("landOwner", Frm_LandOwner.landOwner);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();

            conn.Close();
            MetroMessageBox.Show(_owner, "Successfully saved these land owner Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void socialMediaAdd()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            Frm_SocialMediaAdd _owner = new Frm_SocialMediaAdd();

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
            MetroMessageBox.Show(_owner, "Successfully saved these Social Media Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void landStayAdd()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            Frm_LandStay _owner = new Frm_LandStay();
            
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string INSERT = "INSERT INTO tblLandStay(Seller,Phone_Number,Seller_Email,Seller_Notes,Seller_Name,Availability,State,County,APN,Acres,Legal,GPS,Price,Contact_or_Checkout)VALUES(@seller,@phoneNumber,@sellerEmail,@sellerNotes,@sellerName,@availability,@state,@county,@APN,@acres,@legal,@GPS,@price,@contactOrCheckout)";
            cmd.Parameters.AddWithValue("seller", Frm_LandStay.seller);
            cmd.Parameters.AddWithValue("phoneNumber", Frm_LandStay.phone);
            cmd.Parameters.AddWithValue("sellerEmail", Frm_LandStay.sellerEmail);
            cmd.Parameters.AddWithValue("sellerNotes", Frm_LandStay.sellerNotes);
            cmd.Parameters.AddWithValue("sellerName", Frm_LandStay.sellerName);
            cmd.Parameters.AddWithValue("availability", Frm_LandStay.availability);
            cmd.Parameters.AddWithValue("state", Frm_LandStay.state);
            cmd.Parameters.AddWithValue("county", Frm_LandStay.county);
            cmd.Parameters.AddWithValue("APN", Frm_LandStay.APN);
            cmd.Parameters.AddWithValue("acres", Frm_LandStay.acres);
            cmd.Parameters.AddWithValue("legal", Frm_LandStay.legal);
            cmd.Parameters.AddWithValue("GPS", Frm_LandStay.gps);
            cmd.Parameters.AddWithValue("price", Frm_LandStay.price);
            cmd.Parameters.AddWithValue("contactOrCheckout", Frm_LandStay.contactOrCheckout);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();

            conn.Close();
            MetroMessageBox.Show(_owner, "Successfully saved these Land Stay Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void accountingBusinessAdd()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            Frm_PropertyAccountingBusiness _owner = new Frm_PropertyAccountingBusiness();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string INSERT = "INSERT INTO tblAccountingBusiness(Type_Of_Account,Type_Of_Payment,Paid_Via,APN_ID,Date_Sold,Date_Aquired,Closed_Sale_Amount,Original_Price,OriginalPrice_Expense,Net_Sale,Balance_Due,Sold_From,Sold_To,Terms_with_LLC,Shared60,Shared40,Check_Number,Invoice_Number,Memo,Date_Payments,Amount_Payments,Total_Amount_Paid,Total_Land_Cost,Payment_Balance_Due,Category_Expense,Notes,Recording_Fee,Card_Processing_Fee,Back_Taxes,Notary,Other_Expense,Total_Expense,Net_Profit)VALUES(@typeAccount,@typePayment,@paidVia,@apnID,@dateSold,@dateAquired,@closedSaleAmount,@originalPrice,@originalPriceExpense,@netSale,@balanceDue,@soldFrom,@soldTo,@termsLLC,@shared60,@shared40,@checkNumber,@invoiceNumber,@memo,@datePayment,@amountPayment,@totalAmountPaid,@totalLandCost,@paymentBalanceDue,@categoryExpense,@notes,@recordingFee,@processingFee,@backTaxes,@notary,@otherExpense,@totalExpense,@netProfit)";
            cmd.Parameters.AddWithValue("typeAccount", Frm_PropertyAccountingBusiness.typeAccount);
            cmd.Parameters.AddWithValue("typePayment", Frm_PropertyAccountingBusiness.typePayment);
            cmd.Parameters.AddWithValue("paidVia", Frm_PropertyAccountingBusiness.paidVia);
            cmd.Parameters.AddWithValue("apnID", Frm_PropertyAccountingBusiness.apnID);
            cmd.Parameters.AddWithValue("dateSold", Frm_PropertyAccountingBusiness.dateSold);
            cmd.Parameters.AddWithValue("dateAquired", Frm_PropertyAccountingBusiness.dateAquired);
            cmd.Parameters.AddWithValue("closedSaleAmount", Frm_PropertyAccountingBusiness.closedSale);
            cmd.Parameters.AddWithValue("originalPrice", Frm_PropertyAccountingBusiness.originalPrice);
            cmd.Parameters.AddWithValue("originalPriceExpense", Frm_PropertyAccountingBusiness.originalPriceExpense);
            cmd.Parameters.AddWithValue("netSale", Frm_PropertyAccountingBusiness.netSale);
            cmd.Parameters.AddWithValue("balanceDue", Frm_PropertyAccountingBusiness.balanceDue);
            cmd.Parameters.AddWithValue("soldFrom", Frm_PropertyAccountingBusiness.soldFrom);
            cmd.Parameters.AddWithValue("soldTo", Frm_PropertyAccountingBusiness.soldTo);
            cmd.Parameters.AddWithValue("termsLLC", Frm_PropertyAccountingBusiness.termsLLC);
            cmd.Parameters.AddWithValue("shared60", Frm_PropertyAccountingBusiness.shared60);
            cmd.Parameters.AddWithValue("shared40", Frm_PropertyAccountingBusiness.shared40);
            cmd.Parameters.AddWithValue("checkNumber", Frm_PropertyAccountingBusiness.checkNumber);
            cmd.Parameters.AddWithValue("invoiceNumber", Frm_PropertyAccountingBusiness.invoiceNumber);
            cmd.Parameters.AddWithValue("memo", Frm_PropertyAccountingBusiness.memo);
            cmd.Parameters.AddWithValue("datePayment", Frm_PropertyAccountingBusiness.datePayment);
            cmd.Parameters.AddWithValue("amountPayment", Frm_PropertyAccountingBusiness.amountPayment);
            cmd.Parameters.AddWithValue("totalAmountPaid", Frm_PropertyAccountingBusiness.totalAmountPaid);
            cmd.Parameters.AddWithValue("totalLandCost", Frm_PropertyAccountingBusiness.totalLandCost);
            cmd.Parameters.AddWithValue("paymentBalanceDue", Frm_PropertyAccountingBusiness.paymentBalanceDue);
            cmd.Parameters.AddWithValue("categoryExpense", Frm_PropertyAccountingBusiness.categoryExpense);
            cmd.Parameters.AddWithValue("notes", Frm_PropertyAccountingBusiness.notes);
            cmd.Parameters.AddWithValue("recordingFee", Frm_PropertyAccountingBusiness.recordingFee);
            cmd.Parameters.AddWithValue("processingFee", Frm_PropertyAccountingBusiness.cardProcessingFee);
            cmd.Parameters.AddWithValue("backTaxes", Frm_PropertyAccountingBusiness.backTaxes);
            cmd.Parameters.AddWithValue("notary", Frm_PropertyAccountingBusiness.notary);
            cmd.Parameters.AddWithValue("otherExpense", Frm_PropertyAccountingBusiness.otherExpense);
            cmd.Parameters.AddWithValue("totalExpense", Frm_PropertyAccountingBusiness.totalExpense);
            cmd.Parameters.AddWithValue("netProfit", Frm_PropertyAccountingBusiness.netProfit);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();

            conn.Close();
            MetroMessageBox.Show(_owner, "Successfully saved these Land Stay Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void adminOfficeAdd()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            Frm_AdminOfficeAdd _owner = new Frm_AdminOfficeAdd();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string INSERT = "INSERT INTO tblAdminContact(Full_name,Email,Phone_number,Address,County,Category)VALUES(@fullName,@email,@phoneNumber,@address,@county,@category)";
            cmd.Parameters.AddWithValue("fullName", Frm_AdminOfficeAdd.fullName);
            cmd.Parameters.AddWithValue("email", Frm_AdminOfficeAdd.email);
            cmd.Parameters.AddWithValue("phoneNumber", Frm_AdminOfficeAdd.phoneNumber);
            cmd.Parameters.AddWithValue("address", Frm_AdminOfficeAdd.address);
            cmd.Parameters.AddWithValue("county", Frm_AdminOfficeAdd.county);
            cmd.Parameters.AddWithValue("category", Frm_AdminOfficeAdd.category);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();

            conn.Close();
            MetroMessageBox.Show(_owner, "Successfully saved these Admin Contact List Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void videoTutorialsAdd()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            Frm_VideoTutorialsAdd _owner = new Frm_VideoTutorialsAdd();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string INSERT = "INSERT INTO tblVideoTutorial(Process,Link)VALUES(@process,@link)";
            cmd.Parameters.AddWithValue("process", Frm_VideoTutorialsAdd.process);
            cmd.Parameters.AddWithValue("link", Frm_VideoTutorialsAdd.link);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();

            conn.Close();
            MetroMessageBox.Show(_owner, "Successfully saved these Youtube Tutorials.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }


        public static void marketingUpdate()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            Frm_MarketingUpdate _owner = new Frm_MarketingUpdate();

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
            MetroMessageBox.Show(_owner, "Successfully updated these Marketing Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void socialMediaUpdate()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            Frm_SocialMediaUpdate _owner = new Frm_SocialMediaUpdate();

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
            MetroMessageBox.Show(_owner, "Successfully updated these social media Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void updateLogin()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            Frm_UserEdit _owner = new Frm_UserEdit();

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

            MetroMessageBox.Show(_owner, "Successfully updated the information for this login.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conn.Close();
            cmd.Parameters.Clear();
        }

        public static void updateUser()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            Frm_UserEdit _owner = new Frm_UserEdit();

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

            MetroMessageBox.Show(_owner, "Successfully updated the User Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conn.Close();
            cmd.Parameters.Clear();
        }

        public static void companyUpdate()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            Frm_CompanyLoginsUpdate _owner = new Frm_CompanyLoginsUpdate();

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
            MetroMessageBox.Show(_owner, "Successfully updated these Company Logins Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void landStayUpdate()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            Frm_LandStay _owner = new Frm_LandStay();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string INSERT = "UPDATE tblLandStay SET Seller = @seller, Phone_Number = @phoneNumber, Seller_Email = @sellerEmail, Seller_Notes = @sellerNotes, Seller_Name = @sellerName, Availability = @availability ,State = @state, County = @county, APN = @APN, Acres = @acres, Legal = @legal, GPS = @GPS, Price = @price,Contact_or_Checkout = @contactOrCheckout WHERE LSID = @lsid";
            cmd.Parameters.AddWithValue("seller", Frm_LandStay.sellerUpdate);
            cmd.Parameters.AddWithValue("phoneNumber", Frm_LandStay.phoneUpdate);
            cmd.Parameters.AddWithValue("sellerEmail", Frm_LandStay.sellerEmailUpdate);
            cmd.Parameters.AddWithValue("sellerNotes", Frm_LandStay.sellerNotesUpdate);
            cmd.Parameters.AddWithValue("sellerName", Frm_LandStay.sellerNameUpdate);
            cmd.Parameters.AddWithValue("availability", Frm_LandStay.availabilityUpdate);
            cmd.Parameters.AddWithValue("state", Frm_LandStay.stateUpdate);
            cmd.Parameters.AddWithValue("county", Frm_LandStay.countyUpdate);
            cmd.Parameters.AddWithValue("APN", Frm_LandStay.APNUpdate);
            cmd.Parameters.AddWithValue("acres", Frm_LandStay.acresUpdate);
            cmd.Parameters.AddWithValue("legal", Frm_LandStay.legalUpdate);
            cmd.Parameters.AddWithValue("GPS", Frm_LandStay.gpsUpdate);
            cmd.Parameters.AddWithValue("price", Frm_LandStay.priceUpdate);
            cmd.Parameters.AddWithValue("contactOrCheckout", Frm_LandStay.contactOrCheckoutUpdate);
            cmd.Parameters.AddWithValue("lsid", Frm_LandStay.lsid);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();

            conn.Close();
            MetroMessageBox.Show(_owner, "Successfully Updated these Land Stay Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void adminOfficeUpdate()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            Frm_AdminOfficeUpdate _owner = new Frm_AdminOfficeUpdate();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string UPDATE = "UPDATE tblAdminContact SET Full_name = @fn, Email = @email, Phone_number = @phoneNumber, Address = @address, County = @county, Category = @category WHERE ACID = @acid";
            cmd.Parameters.AddWithValue("fn", Frm_AdminOfficeUpdate.fullName);
            cmd.Parameters.AddWithValue("email", Frm_AdminOfficeUpdate.eMail);
            cmd.Parameters.AddWithValue("phoneNumber", Frm_AdminOfficeUpdate.phoneNumber);
            cmd.Parameters.AddWithValue("address", Frm_AdminOfficeUpdate.address);
            cmd.Parameters.AddWithValue("county", Frm_AdminOfficeUpdate.county);
            cmd.Parameters.AddWithValue("category", Frm_AdminOfficeUpdate.category);
            cmd.Parameters.AddWithValue("acid", Frm_AdminOfficeUpdate.acid);
            cmd.CommandText = UPDATE;
            cmd.ExecuteNonQuery();

            conn.Close();
            MetroMessageBox.Show(_owner, "Successfully updated these Admin Contact List Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            string DELETE = "DELETE tblCompanyLogins WHERE CID = @cid";
            cmd.Parameters.AddWithValue("cid", Frm_CompanyLoginsDelete.CID);
            cmd.CommandText = DELETE;
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Successfully deleted this Company Logins Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }

        public static void LandStayDelete()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();
            conn.Open();

            cmd.Connection = conn;
            string DELETE = "DELETE tblLandStay WHERE LSID = @lsid";
            cmd.Parameters.AddWithValue("lsid", Frm_LandStay.lsidDelete);
            cmd.CommandText = DELETE;
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Successfully deleted these Company Logins Information.", "RVL System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmd.Parameters.Clear();
        }
    }
}
