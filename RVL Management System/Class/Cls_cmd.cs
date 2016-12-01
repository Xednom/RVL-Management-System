using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

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
            string INSERT = "INSERT INTO tblUser(AcctID,Last_Name,First_Name,Middle_Name)VALUES(@acctID,@ln,@fn,@mn)";
            cmd.Parameters.AddWithValue("acctID", Frm_UserAdd.acctID);
            cmd.Parameters.AddWithValue("ln", Frm_UserAdd.lastName);
            cmd.Parameters.AddWithValue("fn", Frm_UserAdd.firstName);
            cmd.Parameters.AddWithValue("mn", Frm_UserAdd.middleName);
            cmd.CommandText = INSERT;
            cmd.ExecuteNonQuery();

            conn.Close();

            cmd.Parameters.Clear();
        }

        public static void updateLogin()
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            conn.ConnectionString = ConfigurationManager.ConnectionStrings["connGlobal"].ToString();

            conn.Open();

            cmd.Connection = conn;
            string InsertLogin = "UPDATE FROM tblLogin SET AcctID=@acctID, UID=@uid, UN =@un, PW=@Pw";
            cmd.Parameters.AddWithValue("acctID", Frm_UserAdd.acctID);
            cmd.Parameters.AddWithValue("uid", Frm_UserAdd.uID);
            cmd.Parameters.AddWithValue("un", Frm_UserAdd.userName);
            cmd.Parameters.AddWithValue("pw", Frm_UserAdd.Password);
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
            string UPDATE = "UPDATE tblUser SET AcctID = @acctID, Last_Name=@ln, First_Name = @fn, Middle_Name=@mn";
            cmd.Parameters.AddWithValue("acctID", Frm_UserAdd.acctID);
            cmd.Parameters.AddWithValue("ln", Frm_UserAdd.lastName);
            cmd.Parameters.AddWithValue("fn", Frm_UserAdd.firstName);
            cmd.Parameters.AddWithValue("mn", Frm_UserAdd.middleName);
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
