using Datapost.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto3.Admin
{
    public partial class CadastrodeCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["key"].ToString() != "")
                {
                    ClienteId.Text = Request.QueryString["key"].ToString();
                    LerCliente();
                }
            }
        }

        protected void LerCliente()
        {
            DAO db = new DAO();
            db.DataProviderName = DAO.ProviderName.OleDb;
            db.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data/BancoDeDados.accdb") + ";Persist Security Info=False;";

            string comandoSQL = "SELECT * FROM Clientes WHERE ClienteId=" + ClienteId.Text;

            DataTable tb = new DataTable();

            tb = (DataTable)db.Query(comandoSQL);
            if (tb.Rows.Count > 0)
            {
                NomeCliente.Text = tb.Rows[0]["Nome"].ToString();
                FisicaJuridica.SelectedValue = tb.Rows[0]["FisicaJuridica"].ToString();
                CPF.Text = tb.Rows[0]["CPF"].ToString();
                Email.Text = tb.Rows[0]["Email"].ToString();
                Telefone.Text = tb.Rows[0]["Telefone"].ToString();
                CEP.Text = tb.Rows[0]["CEP"].ToString();
                Numero.Text = tb.Rows[0]["Numero"].ToString();
                Complemento.Text = tb.Rows[0]["Complemento"].ToString();
            }
        }

        protected void Salvar_Click(object sender, EventArgs e)
        {
            if (!Validacao(CPF.Text))
            {
                MensagemAlerta.Text = "Este cliente já está cadastrado";
            }
            else if (NomeCliente.Text.Trim() == "")
            {
                MensagemAlerta.Text = "Digite o nome do cliente";
            }
            else if (Email.Text.Trim() == "")
            {
                MensagemAlerta.Text = "Digite o e-mail do cliente";
            }
            else if (CEP.Text == "")
            {
                MensagemAlerta.Text = "Digite o seu CEP do cliente";
            }
            else if (Telefone.Text.Trim() == "")
            {
                MensagemAlerta.Text = "Digite o telefone do cliente";
            }
            else if (Numero.Text.Trim() == "")
            {
                MensagemAlerta.Text = "Digite um número para o endereço";
            }
            else
            {
                DAO db = new DAO();
                db.DataProviderName = DAO.ProviderName.OleDb;
                db.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data/BancoDeDados.accdb") + ";Persist Security Info=False;";

                String sql = "";

                if (ClienteId.Text == "")
                {
                    sql = "INSERT INTO Clientes(Nome,FisicaJuridica,Email,Telefone,CPF,CEP, Numero, Complemento) VALUES('" + NomeCliente.Text + "','" + FisicaJuridica.SelectedValue + "','" + Email.Text + "','" + Telefone.Text + "','" + CPF.Text + "','" + CEP.Text + "','" + Numero.Text + "','" + Complemento.Text + "')";
                }
                else
                {
                    sql = "UPDATE Clientes SET Nome='" + NomeCliente.Text + "',Email='" + Email.Text + "',CPF='" + CPF.Text + "',Telefone='" + Telefone.Text + "',FisicaJuridica='" + FisicaJuridica.SelectedValue + "',Numero='" + Numero.Text + "',CEP='" + CEP.Text + "',Complemento='" + Complemento.Text + "' WHERE ClienteId=" + ClienteId.Text;

                }

                db.Query(sql);

                Response.Redirect("ExibirClientes.aspx");
            }
        }

        protected bool Validacao(string cpfValido)
        {
            // retornar true se o nome pode ser gravado
            DAO db = new DAO();
            db.DataProviderName = DAO.ProviderName.OleDb;
            db.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Server.MapPath("~/App_Data/BancoDeDados.accdb") + ";Persist Security Info=False;";

            string comando = "SELECT CPF, ClienteId FROM Clientes WHERE CPF='" + cpfValido + "';";

            DataTable tb = new DataTable();

            tb = (DataTable)db.Query(comando);

            if (tb.Rows.Count > 0 && tb.Rows[0]["ClienteId"].ToString() != ClienteId.Text)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}