using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AdsLib;

namespace Projeto3
{
   public partial class ExibirError : System.Web.UI.Page
   {
      protected void Page_Load(object sender, EventArgs e)
      {
         TratamentoExcecoes leitura= new TratamentoExcecoes();
         Erros.Text = leitura.LerExcecoes().Replace("\n","<br/>");
      }

      protected void Limpar_Click(object sender, EventArgs e)
      {
         TratamentoExcecoes excluir = new TratamentoExcecoes();
         excluir.ExcluirArquivo();

         Response.Redirect("ExibirError.aspx");

      }
   }
}