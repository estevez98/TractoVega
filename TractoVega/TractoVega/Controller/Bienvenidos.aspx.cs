using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DBUtilitarios;
using DBLogica;

public partial class View_Bienvenidos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void DDL_Idioma_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["idioma"] =  DDL_Idioma.SelectedValue.ToString();
        Response.Redirect("~/View/Inicio_Visitante.aspx");

        DLIdioma idioma = new DLIdioma();
        DLIdioma datos = new DLIdioma();
        String ter = idioma.obtenerTerminacion(int.Parse(Session["idioma"].ToString()));

        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(ter);
        Thread.CurrentThread.CurrentUICulture = new CultureInfo(ter);
    }
}