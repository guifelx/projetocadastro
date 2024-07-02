using Datapost.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto3
{
   public partial class Login : System.Web.UI.Page
   {
      protected void Page_Load(object sender, EventArgs e)
      {

      }

      protected void Entrar_Click(object sender, EventArgs e)
      {
         DAO db = new DAO();
         db.DataProviderName = DAO.ProviderName.OleDb;
         db.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data/BancoDeDados.accdb") + ";Persist Security Info=False;";

         string comando = "SELECT * FROM Usuarios WHERE NomeAcesso='" + NomeAcesso.Text + "' AND Senha='" + Senha.Text + "' AND Status=1";

         DataTable tb = new DataTable();
         tb = (DataTable)db.Query(comando);

         if (tb.Rows.Count == 1)
         {
            // DATA NOS BANCOS DE DADOS SEMPRE NO FORMATO ANO-MES-DIA
            string data = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

           // FAZ O REGISTRO DO ACESSO 
            db.Query("INSERT INTO RegistroAcessos(UsuarioID,DataHoraAcesso) Values(" + tb.Rows[0]["UsuarioId"] + ",'" + data + "')");

            // Cria a variavel de sessão para identificar se o usuário está autenticado para permitir a exibição das opções do menu.
            Session["autenticado"] = "";
            // 1. Inicializa a classe de autenticação
            System.Web.Security.FormsAuthentication.Initialize();
            // 2. CRIAR O TICKET
            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, "admin",
           DateTime.Now, DateTime.Now.AddMinutes(20), false,
           FormsAuthentication.FormsCookiePath);
            // 3. CRIPTOGRAFA O TICKET E GRAVAR NO COOKIE DO NAVEGADOR
            Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName,
           FormsAuthentication.Encrypt(ticket)));
            // Redireciona para o form que o usuário tentou acessar
            Response.Redirect(FormsAuthentication.GetRedirectUrl("Admin", false));
         }
         else
         {
            Msg.Text = "Dados de acesso invalidos";
         }
      }
   }
}