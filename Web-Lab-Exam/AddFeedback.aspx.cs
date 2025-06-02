using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Web_Lab_Exam
{
    public partial class AddFeedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Only proceed if all front-end validators are satisfied
            if (!Page.IsValid)
                return;

            string connStr = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

            string query = "INSERT INTO Feedback (StudentName, CourseName, Comments, Phone) " +
                           "VALUES (@StudentName, @CourseName, @Comments, @Phone)";

            using (SqlConnection con = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@StudentName", TextBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@CourseName", TextBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@Comments", TextBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@Phone", TextBox4.Text.Trim());  // Treat phone as string

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        lblMessage.Text = "Feedback submitted successfully!";
                        lblMessage.ForeColor = System.Drawing.Color.Green;

                        // Clear input fields
                        TextBox1.Text = "";
                        TextBox2.Text = "";
                        TextBox3.Text = "";
                        TextBox4.Text = "";
                    }
                    catch (Exception ex)
                    {
                        lblMessage.Text = "Error: " + ex.Message;
                        lblMessage.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
        }
    }
}
