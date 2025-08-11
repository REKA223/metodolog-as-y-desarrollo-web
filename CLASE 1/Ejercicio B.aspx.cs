using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace CLASE_1
{
    public partial class Ejercicio_B : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void EscribirXML_Click(object sender, EventArgs e)
        {
            string ruta = Server.MapPath("~/Clientes.xml");

            var settings = new XmlWriterSettings
            {
                Indent = true,
                Encoding = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false)
            };

            using (XmlWriter writer = XmlWriter.Create(ruta, settings))
            {
                writer.WriteStartDocument();
                writer.WriteComment("Escribir datos en XML");

                writer.WriteStartElement("DatosCliente");
                writer.WriteAttributeString("NombreTipo", "Guardar");

                writer.WriteStartElement("NombreNumero");
                writer.WriteString(txtNombre.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("Apellidos");
                writer.WriteString(txtApellidos.Text);
                writer.WriteEndElement();

                writer.WriteStartElement("Direccion");
                writer.WriteString(txtDireccion.Text);
                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }

            Response.Redirect("~/Clientes.xml", endResponse: false);
        }
    }
}