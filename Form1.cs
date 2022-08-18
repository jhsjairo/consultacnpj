using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
    

        CookieContainer cookieContainer = new CookieContainer();


        String UrlDominio = "http://www.receita.fazenda.gov.br";
        String UrlBase = "http://www.receita.fazenda.gov.br/pessoajuridica/cnpj/cnpjreva/";
        String UrlGet = "cnpjreva_solicitacao2.asp";
        String UrlPost = "Valida.asp";

        Clientes c = new Clientes();
        
        public Form1()
        {
            InitializeComponent();

          
        }

       

       

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string test = "";

                HtmlDocument htmlDocument = this.webBrowser1.Document;
                for (int i = 0; i <= htmlDocument.GetElementsByTagName("font").Count - 1; i++)
                {

                    try
                    {
                        test = webBrowser1.Document.GetElementsByTagName("font")[i].OuterText.Replace(".", "").Replace("-", "").Replace("/", "");
                        string test2 = webBrowser1.Document.GetElementsByTagName("font")[i + 1].OuterText.Replace(".", "").Replace("-", "").Replace("/", "");

                    }
                    catch { }


                    switch (test.Trim())
                    {
                        case "NÚMERO DE INSCRIÇÃO":
                            try
                            {
                                string cn = webBrowser1.Document.GetElementsByTagName("font")[i + 1].OuterText.Replace(".", "").Replace("-", "").Replace("/", "").Replace("MATRIZ", "").Replace("FILIAL", "").Trim();
                                c.Cnpj_cpf = cn;
                            }
                            catch { }
                            break;

                        case "NOME EMPRESARIAL":
                            try
                            {
                                c.Razao_social = webBrowser1.Document.GetElementsByTagName("font")[i + 1].OuterText.Replace(".", "").Replace("-", "").Replace("/", "");
                            }
                            catch { }
                            break;

                        case "TÍTULO DO ESTABELECIMENTO (NOME DE FANTASIA)":
                            try
                            {
                                c.Nome_fantasia = webBrowser1.Document.GetElementsByTagName("font")[i + 1].OuterText.Replace(".", "").Replace("-", "").Replace("/", "");
                            }
                            catch { }
                            break;


                        case "LOGRADOURO":
                            try
                            {
                                c.Endereco = webBrowser1.Document.GetElementsByTagName("font")[i + 1].OuterText.Replace(".", "").Replace("-", "").Replace("/", "");
                            }
                            catch { }
                            break;

                        case "NÚMERO":
                            try
                            {
                                c.Endereco_num = webBrowser1.Document.GetElementsByTagName("font")[i + 1].OuterText.Replace(".", "").Replace("-", "").Replace("/", "");
                            }
                            catch { }
                            break;

                        case "COMPLEMENTO":
                            try
                            {
                                c.COMPLEMENTO = webBrowser1.Document.GetElementsByTagName("font")[i + 1].OuterText.Replace(".", "").Replace("-", "").Replace("/", "");
                            }
                            catch { }
                            break;

                        case "CEP":
                            try
                            {
                                c.Cep = webBrowser1.Document.GetElementsByTagName("font")[i + 1].OuterText.Replace(".", "").Replace("-", "").Replace("/", "");
                            }
                            catch { }
                            break;

                        case "BAIRRODISTRITO":
                            try
                            {
                                c.Bairro = webBrowser1.Document.GetElementsByTagName("font")[i + 1].OuterText.Replace(".", "").Replace("-", "").Replace("/", "");
                            }
                            catch { }
                            break;

                        case "MUNICÍPIO":
                            try
                            {
                                c.Cidade = webBrowser1.Document.GetElementsByTagName("font")[i + 1].OuterText.Replace(".", "").Replace("-", "").Replace("/", "");
                            }
                            catch { }
                            break;

                        case "UF":
                            try
                            {
                                c.Uf = webBrowser1.Document.GetElementsByTagName("font")[i + 1].OuterText.Replace(".", "").Replace("-", "").Replace("/", "");
                            }
                            catch { }
                            break;

                        case "ENDEREÇO ELETRÔNICO":
                            try
                            {
                                c.Email = webBrowser1.Document.GetElementsByTagName("font")[i + 1].OuterText.Replace("/", "");
                            }
                            catch { }
                            break;

                        case "TELEFONE":
                            try
                            {
                                c.Fone = webBrowser1.Document.GetElementsByTagName("font")[i + 1].OuterText.Replace(".", "").Replace("-", "").Replace("/", "");
                            }
                            catch { }

                            goto eExit;

                            break;



                    }



                }

            eExit:;

               


                    cnpj_cpf.Text = c.Cnpj_cpf;
                    razao_social.Text = c.Razao_social;
                    fantasia.Text = c.Nome_fantasia;
                    endereco.Text = c.Endereco + ", " + c.Endereco_num;
                  
                    bairro.Text = c.Bairro;
                    cidade.Text = c.Cidade;
                    uf.Text = c.Uf;
                    cep.Text = c.Cep;
                    fone.Text = c.Fone;
                    email.Text = c.Email;
                    endereco.Text = c.COMPLEMENTO;
              

               

            }
            catch
            {

                MessageBox.Show("Erro na importação dos Dados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }



            //.GetElementsByTagName("input")
            //.GetElementsByName("textfield2")[0]
            //    .SetAttribute("value", textBox1.Text);


        }

        private void FRM_CnpjCpfReceita_Load(object sender, EventArgs e)
        {


            //https://www.receita.fazenda.gov.br/pessoajuridica/cnpj/cnpjreva/cnpjreva_solicitacao2.asp
            Uri uri = new Uri("http://servicos.receita.fazenda.gov.br/Servicos/cnpjreva/Cnpjreva_Solicitacao.asp?cnpj");

            webBrowser1.Url = uri;
            webBrowser1.ScriptErrorsSuppressed = true;

            while (webBrowser1.ReadyState != WebBrowserReadyState.Complete &&
                webBrowser1.Document == null)
            {


                btnImportarDados.Enabled = false;
                Application.DoEvents();
            }

            btnImportarDados.Enabled = true;




        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnCnpj_Click(object sender, EventArgs e)
        {
           
        }

        private void FRM_CnpjCpfReceita_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            string xmlOut = webBrowser1.Document.Body.OuterHtml.ToString();
            string rHeader1 = xmlOut.Substring(0, xmlOut.IndexOf("<HEADER>")).ToString();
            string rHeader2 = rHeader1 + xmlOut.Substring(xmlOut.IndexOf("</HEADER>") + 9, xmlOut.Length - (xmlOut.IndexOf("</HEADER>") + 9)).ToString();

            string rFooter1 = rHeader2.Substring(0, rHeader2.IndexOf("<FOOTER>")).ToString();
            string rFooter2 = rFooter1 + rHeader2.Substring(rHeader2.IndexOf("</FOOTER>") + 9, rHeader2.Length - (rHeader2.IndexOf("</FOOTER>") + 9)).ToString();

            HtmlElement htdoc = webBrowser1.Document.Body;
            htdoc.InnerHtml = rFooter2;

            webBrowser1.Document.Window.ScrollTo(0, 140);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
