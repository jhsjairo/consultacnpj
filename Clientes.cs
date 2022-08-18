using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
 

    class Clientes
    {
        public int Pk { get; set; }
        public int Fk_tipo_cliente { get; set; }
        public int Fk_setor { get; set; }
        public int Fk_carteira { get; set; }
        public string Nome_fantasia { get; set; }
        public string Razao_social { get; set; }
        public string Endereco { get; set; }
        public string Endereco_num { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string cCidade { get; set; }
        public string Uf { get; set; }
        public string cUf { get; set; }
        public string Cep { get; set; }
        public string Cnpj_cpf { get; set; }
        public string Ie { get; set; }
        public string Im { get; set; }
        public string Nao_contribuinte { get; set; }
        public string Fone { get; set; }
        public string Email { get; set; }
        public string Tipo_preco { get; set; }
        public string comercial_nome { get; set; }
        public string comercial_fone { get; set; }
        public string comercial_email { get; set; }
        public string financeiro_nome { get; set; }
        public string financeiro_fone { get; set; }
        public string financeiro_email { get; set; }

        public string serasa_data { get; set; }
        public string serasa_situacao { get; set; }

        public double Limite_credito { get; set; }

        public string Obs { get; set; }
        public string Desativado { get; set; }

        public string DATA_HORA_USUARIO { get; set; }
        public int FK_USUARIO { get; set; }

        public string BLOQUEAR_LIMITE { get; set; }
        public string BLOQUEAR_INADIMPLENTE { get; set; }
        public string BLOQUEAR_DESCONTO_VENDA { get; set; }
        public string BLOQUEADO { get; set; }
        public int FK_VENDEDOR { get; set; }
        public string COMPLEMENTO { get; set; }
        public int COR { get; set; }
        public string PONTO_REFERENCIA { get; set; }

        public string NAO_EMITIR_NFCE { get; set; }
        public string DADOS_OBS_NFCE { get; set; }
        public object DATA_ANIVERSARIO { get; set; }
        public string DATA_CADASTRO { get; set; }

        public string CPAIS { get; set; }
        public string PAIS { get; set; }
        public string COBRAR_TAXA_BOLETO { get; set; }
        public string MENSAL { get; set; }
        public string OBS_PEDIDO { get; set; }
        public string BLOQUEAR_PRODUCAO { get; set; }
        public string BLOQUEAR_PRODUCAO_DIAS { get; set; }


        public string LOCAL { get; set; }
        public int FK_CLIENTE { get; set; }
        public string DESCRICAO { get; set; }

    }

}
