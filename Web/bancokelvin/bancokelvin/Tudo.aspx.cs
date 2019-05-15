using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bancokelvin
{
    public partial class Tudo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Listar();
            }
            check();
            radio();


        }

       
        SqlConnection con = new SqlConnection(" Password =93912;Persist Security Info=True;User ID = RA93912; Initial Catalog = RA93912; Data Source = 10.101.148.8");



        public void Listar()
        {
            SqlDataAdapter d = new SqlDataAdapter("select Marca from Marcas", con);
            DataTable data = new DataTable();
            d.Fill(data);
            D1.DataTextField = "Marca";
            D1.DataValueField = "Marca";
            D1.DataSource = data;
            D1.DataBind();


        }

        public void Listar2()
        {
            if (D1.SelectedItem.ToString() == "Airbus")
            {
                SqlDataAdapter d = new SqlDataAdapter("select Modelo from ModeloAIR", con);
                DataTable data = new DataTable();
                d.Fill(data);
                D2.DataTextField = "Modelo";
                D2.DataValueField = "Modelo";
                D2.DataSource = data;
                D2.DataBind();
            }
            else if (D1.SelectedItem.ToString() == "Boeing")
            {
                SqlDataAdapter d = new SqlDataAdapter("select Modelo from ModeloBO", con);
                DataTable data = new DataTable();
                d.Fill(data);
                D2.DataTextField = "Modelo";
                D2.DataValueField = "Modelo";
                D2.DataSource = data;
                D2.DataBind();
            }
            else if (D1.SelectedItem.ToString() == "Embraer")
            {
                SqlDataAdapter d = new SqlDataAdapter("select Modelo from ModeloEM", con);
                DataTable data = new DataTable();
                d.Fill(data);
                D2.DataTextField = "Modelo";
                D2.DataValueField = "Modelo";
                D2.DataSource = data;
                D2.DataBind();
            }
            


        }

        public void check()
        {
            SqlDataAdapter da = new SqlDataAdapter("select Assento from Assento",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CheckBoxList1.DataTextField = "Assento";
            CheckBoxList1.DataValueField = "Assento";
            CheckBoxList1.DataSource = dt;
            CheckBoxList1.DataBind();
        }
        public void radio()
        {
            SqlDataAdapter da = new SqlDataAdapter("select Assento from Lugar", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            RadioButtonList1.DataTextField = "Assento";
            RadioButtonList1.DataValueField = "Assento";
            RadioButtonList1.DataSource = dt;
            RadioButtonList1.DataBind();
        }




        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
                Listar2();
            
          
           
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

            

        }
    }
}