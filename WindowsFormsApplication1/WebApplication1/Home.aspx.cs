using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.CorreiosAtendeClienteService; //Adicionado a referencia do WS correios

namespace WebApplication1
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            CorreiosWS ws = new CorreiosWS();

            try
            {
                ws.ConsultaCEP(TextCep.Text);
                LabRetorno.Text = string.Format(@"Endereço: {0}<br />
                       Complemento 1: {1}<br />
                       Complemento 2: {2}<br />
                       Bairro: {3}<br />
                       Cidade: {4}<br />
                       Estado: {5}",
                        ws.endERP.end,
                        ws.endERP.complemento,
                        ws.endERP.complemento2,
                        ws.endERP.bairro,
                        ws.endERP.cidade,
                        ws.endERP.uf);
                LabRetorno.Attributes.Add("class", "text-success");

            }
            catch (System.Exception ex)
            {
                LabRetorno.Attributes.Add("class", "alert-danger");
                LabRetorno.Text = ex.ToString();
            }
        }
    }
}