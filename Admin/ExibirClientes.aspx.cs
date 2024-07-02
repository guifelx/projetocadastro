using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datapost.DB;

namespace Projeto3.Admin
{
   public partial class ExibirClientes : System.Web.UI.Page
   {
      protected void Page_Load(object sender, EventArgs e)
      {
            LerClientes();
      }

        protected void Novo_Click(object sender, EventArgs e)
        {
            Response.Redirect("CadastrodeCliente.aspx?key=");
        }


        protected void LerClientes()
        {
            DAO db = new DAO();
            db.DataProviderName = DAO.ProviderName.OleDb; //access
            db.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data/BancoDeDados.accdb") + ";Persist Security Info=False;";

            string comandoSQL = "SELECT ClienteId,Nome,FisicaJuridica, Email, Telefone, CPF, CEP, Numero, Complemento FROM Clientes ORDER BY Nome ASC ";

            GridViewClientes.DataSource = db.Query(comandoSQL);
            GridViewClientes.DataBind();

        }
        protected void Editar_Click(object sender, EventArgs e)
        {

        }

        protected void Fechar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        protected void GridViewClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chave = GridViewClientes.SelectedRow.Cells[1].Text;

            Response.Redirect("CadastrodeCliente.aspx?key=" + chave);
        }
    }
}