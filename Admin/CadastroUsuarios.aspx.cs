using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datapost.DB;

namespace Projeto3.Admin
{
   public partial class CadastroUsuarios : System.Web.UI.Page
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         if (!IsPostBack)
         {
            if (Request.QueryString["key"].ToString() != "")
            {
               UsuarioID.Text = Request.QueryString["key"].ToString();
               LerUsuario();
               LerAcessos();
            }
         }
      }

      protected void LerUsuario()
      {
         DAO db = new DAO();
         db.DataProviderName = DAO.ProviderName.OleDb;
         db.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data/BancoDeDados.accdb") + ";Persist Security Info=False;";

         string comandoSQL = "SELECT * FROM Usuarios WHERE UsuarioId=" + UsuarioID.Text;

         DataTable tb = new DataTable();

         tb = (DataTable)db.Query(comandoSQL);
         if (tb.Rows.Count > 0)
         {
            Nome.Text = tb.Rows[0]["Nome"].ToString();
            Email.Text = tb.Rows[0]["Email"].ToString();
            NomeAcesso.Text = tb.Rows[0]["NomeAcesso"].ToString();
            Senha.Text = tb.Rows[0]["Senha"].ToString();
            Status.SelectedValue = tb.Rows[0]["Status"].ToString();

         }
      }
      protected void Salvar_Click(object sender, EventArgs e)
      {
         if (!NomeAcessoValido(NomeAcesso.Text))
         {
            Alerta.Text = "Este nome de acesso já existe";
         }
         else if (Nome.Text.Trim() == "")
         {
            Alerta.Text = "Digite seu nome";
         }
         else if (Email.Text.Trim() == "")
         {
            Alerta.Text = "Digite o e-mail";
         }
         else if (NomeAcesso.Text == "")
         {
            Alerta.Text = "Digite o nome de acesso";
         }
         else if (Senha.Text.Trim() == "")
         {
            Alerta.Text = "Digite a senha";
         }
         else
         {
            DAO db = new DAO();
            db.DataProviderName = DAO.ProviderName.OleDb;
            db.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data/BancoDeDados.accdb") + ";Persist Security Info=False;";

            String sql = "";

            if (UsuarioID.Text == "")
            {
               sql = "INSERT INTO Usuarios(Nome,Email,NomeAcesso,Senha,Status) VALUES('" + Nome.Text + "','" + Email.Text + "','" + NomeAcesso.Text + "','" + Senha.Text + "'," + Status.SelectedValue + ");";
            }
            else
            {
               sql = "UPDATE Usuarios SET Nome='" + Nome.Text + "',Email='" + Email.Text + "',NomeAcesso='" + NomeAcesso.Text + "',Senha='" + Senha.Text + "',Status=" + Status.SelectedValue + " WHERE UsuarioId=" + UsuarioID.Text;
            }

            db.Query(sql);

            Response.Redirect("ExibirUsuarios.aspx");
         }
      }

      protected bool NomeAcessoValido(string nomeAcesso)
      {
         // retornar true se o nome pode ser gravado
         DAO db = new DAO();
         db.DataProviderName = DAO.ProviderName.OleDb;
         db.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data/BancoDeDados.accdb") + ";Persist Security Info=False;";

         string comando = "SELECT NomeAcesso,UsuarioID FROM Usuarios WHERE NomeAcesso='" + nomeAcesso + "';";

         DataTable tb = new DataTable();

         tb = (DataTable)db.Query(comando);

         if (tb.Rows.Count > 0 && tb.Rows[0]["UsuarioID"].ToString() != UsuarioID.Text)
         {
            return false;
         }
         else
         {
            return true;
         }

         //if(tb.Rows.Count == 0)
         //{
         //   return true;
         //}
         //else
         //{
         //   // o nome de acesso já esta cadastrado
         //   if (UsuarioID.Text == "")
         //   {
         //      // um INSERT
         //      return false;
         //   }
         //   else
         //   {
         //      // EDIÇÃO e o nome de acesso existe
         //      if (tb.Rows[0]["UsuarioID"].ToString() == UsuarioID.Text)
         //      {
         //         return true;
         //      }
         //      else
         //      {
         //         return false;
         //      }
         //   }
         //}
      }

      protected void LerAcessos()
      {
         DAO db = new DAO();
         db.DataProviderName = DAO.ProviderName.OleDb;
         db.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data/BancoDeDados.accdb") + ";Persist Security Info=False;";

         string comando = "SELECT DataHoraAcesso FROM RegistroAcessos WHERE UsuarioId=" + UsuarioID.Text + "  ORDER BY DataHoraAcesso DESC";

         GridViewAcessos.DataSource = db.Query(comando);
         GridViewAcessos.DataBind();
      }
   }
}