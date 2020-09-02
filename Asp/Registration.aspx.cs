using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;    

namespace Asp
{
    public partial class Registration : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Customer.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ins="INSERT INTO [Table](Name,Phoneno,Actype,IniAmount,Password) values('"+ Nametxt.Text+"','"+Phonetxt.Text+"','"+Typetxt.Text+"','"+Initxt.Text+"','"+Passtxt.Text+"')";
            SqlCommand com = new SqlCommand(ins,con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();



        }
    }
}