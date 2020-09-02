using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Asp
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Customer.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        protected void Button1_Click1(object sender, EventArgs e)
        {
            string check = "SELECT COUNT(*) FROM [Table] WHERE Name= '" + acnotxt.Text + "',Password='" + Nametxt.Text + "' ";
            SqlCommand com = new SqlCommand(check, con);
            con.Open();
            Response.Redirect("https://localhost:44301/HomePage.aspx");
            //int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            //int temp = com.ExecuteScalar();
            con.Close();
           /* if(temp==1)
            {
                Response.Redirect("https://localhost:44301/HomePage.aspx");
            }
            else
            {
                Label3.Text = "invalid acno";
            }*/


        }

        protected void Nametxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}