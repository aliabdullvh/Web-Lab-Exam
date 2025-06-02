using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Lab_Exam
{
    public partial class Viewfeedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        private void BindGrid()
        {
            string connStr = ConfigurationManager.ConnectionStrings["YourConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM FeedbackTbl", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            BindGrid();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            BindGrid();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];
            string feedbackId = GridView1.DataKeys[e.RowIndex].Value.ToString();
            string studentName = ((TextBox)row.Cells[0].Controls[0]).Text;
            string courseName = ((TextBox)row.Cells[1].Controls[0]).Text;
            string comments = ((TextBox)row.Cells[2].Controls[0]).Text;
            string phone = ((TextBox)row.Cells[3].Controls[0]).Text;

            string connStr = ConfigurationManager.ConnectionStrings["YourConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE FeedbackTbl SET StudentName=@StudentName, CourseName=@CourseName, Comments=@Comments, Phone=@Phone WHERE FeedbackID=@FeedbackID", con);
                cmd.Parameters.AddWithValue("@StudentName", studentName);
                cmd.Parameters.AddWithValue("@CourseName", courseName);
                cmd.Parameters.AddWithValue("@Comments", comments);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@FeedbackID", feedbackId);
                cmd.ExecuteNonQuery();
            }

            GridView1.EditIndex = -1;
            BindGrid();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string feedbackId = GridView1.DataKeys[e.RowIndex].Value.ToString();
            string connStr = ConfigurationManager.ConnectionStrings["YourConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM FeedbackTbl WHERE FeedbackID=@FeedbackID", con);
                cmd.Parameters.AddWithValue("@FeedbackID", feedbackId);
                cmd.ExecuteNonQuery();
            }

            BindGrid();
        }


    }
}