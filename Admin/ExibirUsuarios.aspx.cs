using Datapost.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto3.Admin
{
   public partial class ExibirUsuarios : System.Web.UI.Page
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         LerUsuarios();
      }

      protected void LerUsuarios()
      {
         DAO db = new DAO();
         db.DataProviderName = DAO.ProviderName.OleDb; //access
         db.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data/BancoDeDados.accdb") + ";Persist Security Info=False;";

         string comandoSQL = "SELECT UsuarioID,Nome,Email,NomeAcesso,Status FROM Usuarios ORDER BY Nome ASC ";

         GridViewUsuarios.DataSource = db.Query(comandoSQL);
         GridViewUsuarios.DataBind();

      }

      protected void Inserir_Click(object sender, EventArgs e)
      {
         Response.Redirect("CadastroUsuarios.aspx?key=");
      }

      protected void Fechar_Click(object sender, EventArgs e)
      {
         Response.Redirect("~/Default.aspx");
      }

      protected void GridViewUsuarios_SelectedIndexChanged(object sender, EventArgs e)
      {
         string chave = GridViewUsuarios.SelectedRow.Cells[1].Text;

         Response.Redirect("CadastroUsuarios.aspx?key=" + chave);

      }
   }
}