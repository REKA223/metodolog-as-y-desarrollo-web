using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace CLASE_1
{
    public partial class Ejercicio_C : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var doc = new XmlDocument();
                using (var reader = new XmlTextReader(Server.MapPath("~/Inventario2.xml")))
                {
                    reader.WhitespaceHandling = WhitespaceHandling.None;
                    doc.Load(reader);
                }

                Session["DocumentoEnSesion"] = doc;

                var root = doc.DocumentElement;
                for (int i = 0; i < root.ChildNodes.Count; i++)
                {
                    var producto = root.ChildNodes[i];
                    var nombre = producto.ChildNodes[1].InnerText;
                    DropDownList1.Items.Add(nombre);
                }
            }

        }
        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            var doc = Session["DocumentoEnSesion"] as XmlDocument;
            if (doc == null) return;

            int idx = DropDownList1.SelectedIndex;

            var precioTexto = doc.DocumentElement.ChildNodes[idx].ChildNodes[2].InnerText;

            var cultura = new CultureInfo("es-AR");
            double precio = double.Parse(precioTexto, cultura);

            int cantidad = 1;
            int.TryParse(txtCantidad.Text, out cantidad);

            lblPrecio.Text = precio.ToString("C", cultura);
            lblTotal.Text = (precio * cantidad).ToString("C", cultura);
        }
    }
}