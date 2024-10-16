using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Desempenio1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlDataSource1.UpdateParameters["apellido"].DefaultValue = TextBox1.Text;
            SqlDataSource1.UpdateParameters["nombre"].DefaultValue = TextBox2.Text;
            int result = SqlDataSource1.Update();
            if (result != 0)
            {
                Label6.Text = "Se ha modificado " + result.ToString() + " registro.";
            }
            else
            {
                Label6.Text = "No se han modificado registros";
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = GridView1.SelectedRow.Cells[1].Text;
            TextBox2.Text = GridView1.SelectedRow.Cells[2].Text;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlDataSource3.InsertParameters["nombre"].DefaultValue = TextBox3.Text;
            SqlDataSource3.InsertParameters["idDirector"].DefaultValue = DropDownList1.SelectedValue;
            int result = SqlDataSource3.Insert();
            if (result != 0)
            {
                Label6.Text = "Se ha creado " + result.ToString() + " registro.";
            }
            else
            {
                Label6.Text = "No se han creado registros";
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataSource2.FilterExpression = "idDirector = " + DropDownList2.SelectedValue;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlDataSource3.FilterExpression = String.Empty;
            SqlDataSource3.FilterParameters.Clear();
         }
    }
}