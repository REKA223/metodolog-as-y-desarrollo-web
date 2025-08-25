using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.XPath;

namespace CLASE3
{
    public partial class EJBanco : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            var xPathDocum = new XPathDocument(Server.MapPath("~/Banco.xml"));

            XPathNavigator xNavegador = xPathDocum.CreateNavigator();

            XPathNodeIterator iterador = xNavegador.Select("Banco/Cuenta[CuentaSucursal='Barcelona']/CuentaNombre");

            ListBox1.Items.Clear();
            while (iterador.MoveNext())
            {
                ListBox1.Items.Add(iterador.Current.Value);
            }
        }
    }
}