using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    [DataContract]
    public class BaseDados
    {
        [DataMember]
        public int Id { get; private set; }
    }

    public class Entrada: BaseDados
    {
        public Entrada()
        {

        }

        public Entrada(Produto produto, Cliente cliente, bool ent_status, DateTime ent_dt_cad, decimal ent_valor, decimal ent_desconto, char ent_formaPag)
        {
            this.Produto = produto;
            this.Cliente = cliente;
            Ent_status = ent_status;
            Ent_dt_cad = ent_dt_cad;
            Ent_valor = ent_valor;
            Ent_desconto = ent_desconto;
            Ent_formaPag = ent_formaPag;
        }

        [Required]
       public Produto Produto { get; private set; }


        [Required]
        public Cliente Cliente { get; private set; }

        [Required]
        public bool Ent_status { get; private set; }

        [Required]
        [DataType(dataType: DataType.DateTime)]
        public DateTime Ent_dt_cad { get; private set; }

        [Required]
        public decimal Ent_valor { get; private set; }
        
        [Required]
        public decimal Ent_desconto { get; private set; }

        [Required]
        public char Ent_formaPag { get; private set; }
    }

    public class Apresentacao : BaseDados
    {
        public Apresentacao()
        {
        }

        public Apresentacao(int ape_id, string ape_Nome, char ape_sigla)
        {
            Ape_id = ape_id;
            Ape_Nome = ape_Nome;
            Ape_sigla = ape_sigla;
        }

        public int Ape_id { get; private set; }
        public string Ape_Nome { get; private set; }
        public char Ape_sigla { get; private set; }
    }

    public class Cliente:BaseDados
    {
        public Cliente()
        {
        }

        public Cliente(int cli_id, char cli_cpf, string cli_end, int cli_cel, DateTime cli_dt_cad)
        {
            this.Cli_id = cli_id;
            this.Cli_cpf = cli_cpf;
            this.Cli_end = cli_end;
            this.Cli_cel = cli_cel;
            Cli_dt_cad = cli_dt_cad;
        }

        [Required]
        public int Cli_id { get; private set; }

        [Required]
        public char Cli_cpf { get; private set; }

        [Required]
        public string Cli_end { get; private set; }

        [Required]
        public int Cli_cel { get; private set; }

        [Required]
        [DataType(dataType: DataType.DateTime)]
        public DateTime Cli_dt_cad { get; private set; }

    }

    public class Produto:BaseDados
    {
        public Produto()
        {

        }

        public Produto(Receita receita, int prod_id, string prod_nome, decimal prod_preco, bool prod_status, DateTime prod_dt_cad)
        {
            this.Receita = receita;
            Prod_id = prod_id;
            Prod_nome = prod_nome;
            Prod_preco = prod_preco;
            Prod_status = prod_status;
            Prod_dt_cad = prod_dt_cad;
        }

        [Required]
        public Receita Receita { get; private set; }

        [Required]
        public int Prod_id { get; private set; }

        [Required]
        public string Prod_nome { get; private set; }

        [Required]
        public decimal Prod_preco { get; private set; }

        [Required]
        public bool Prod_status { get; private set; }

        [Required]
        [DataType(dataType: DataType.DateTime)]
        public DateTime Prod_dt_cad { get; private set; }

    }


    public class Receita:BaseDados
    {
        public Receita()
        {
        }

        public Receita(int rec_id, Item item, decimal rec_item_qtd, bool rec_status, DateTime rec_dt_cad)
        {
            Rec_id = rec_id;
            Item = item;
            Rec_item_qtd = rec_item_qtd;
            Rec_status = rec_status;
            Rec_dt_cad = rec_dt_cad;
        }

        [Required]
        public int Rec_id { get; private set; }

        [Required]
        public Item Item { get; private set; }

        [Required]
        public decimal Rec_item_qtd { get; private set; }

        [Required]
        public bool Rec_status { get; private set; }

        [Required]
        [DataType(dataType: DataType.DateTime)]
        public DateTime Rec_dt_cad { get; private set; }



    }

    public class Item:BaseDados
    {
        public Item()
        {
        }

        public Item(int ite_id, int itr_apre_id, string ite_nome)
        {
            Ite_id = ite_id;
            Itr_apre_id = itr_apre_id;
            Ite_nome = ite_nome;
        }

        [Required]
        public int Ite_id { get;  private set; }

        [Required]
        public int Itr_apre_id { get; private set; }

        [Required]
        public string Ite_nome { get; set; }


    }


    public class Entrada_mat:BaseDados
    {
        public Entrada_mat()
        {
        }

        public Entrada_mat(int emat_id, int emat_cod_barras, Item item, decimal emat_qtd, DateTime emat_dt_cad, Dados_NF dados_NF)
        {
            Emat_id = emat_id;
            Emat_cod_barras = emat_cod_barras;
            Item = item;
            Emat_qtd = emat_qtd;
            Emat_dt_cad = emat_dt_cad;
            Dados_NF = dados_NF;
        }


        [Required]
        public int Emat_id { get; set; }

        [Required]
        public int Emat_cod_barras { get; set; }

        [Required]
        public Item Item { get; set; }

        [Required]
        public decimal Emat_qtd { get; set; }

        [Required]
        [DataType(dataType: DataType.DateTime)]
        public DateTime Emat_dt_cad { get; private set; }

        [Required]
        public Dados_NF Dados_NF { get; set; }
       
    }

    public class Dados_NF:BaseDados
    {
        public Dados_NF()
        {
        }

        public Dados_NF(int dnf_id, int dnf_serie, int dnf_num, DateTime dnf_dt_ent, DateTime dnf_dt_cad, char dnf_tipo)
        {
            Dnf_id = dnf_id;
            Dnf_serie = dnf_serie;
            Dnf_num = dnf_num;
            Dnf_dt_ent = dnf_dt_ent;
            Dnf_dt_cad = dnf_dt_cad;
            Dnf_tipo = dnf_tipo;
        }

        [Required]
        public int Dnf_id { get; set; }

        [Required]
        public int Dnf_serie { get; set; }

        [Required]
        public int Dnf_num { get; set; }

        [Required]
        [DataType(dataType: DataType.DateTime)]
        public DateTime Dnf_dt_ent { get; private set; }

        [Required]
        [DataType(dataType: DataType.DateTime)]
        public DateTime Dnf_dt_cad { get; private set; }

        [Required]
        public char Dnf_tipo { get; set; }
    }

    public class Estoque:BaseDados
    {
        public Estoque()
        {
        }

        public Estoque(Entrada_mat entrada_Mat, Item item, decimal est_qtd, char est_tipo, DateTime est_dt_cad)
        {
            Entrada_Mat = entrada_Mat;
            Item = item;
            Est_qtd = est_qtd;
            Est_tipo = est_tipo;
            Est_dt_cad = est_dt_cad;
        }

        [Required]
        public Entrada_mat Entrada_Mat { get; set; }
        
        [Required]
        public Item Item { get; set; }

        [Required]
        public decimal Est_qtd { get; set; }

        [Required]
        public char Est_tipo { get; set; }

        [Required]
        [DataType(dataType: DataType.DateTime)]
        public DateTime Est_dt_cad { get; private set; }
    }

    public class Saida_mat:BaseDados
    {
        public Saida_mat()
        {
        }

        public Saida_mat(int smat_id, Dados_NF dados_NF, int smat_cod_barras, Item item, decimal smat_qtd, DateTime smat_dt_cad)
        {
            Smat_id = smat_id;
            Dados_NF = dados_NF;
            Smat_cod_barras = smat_cod_barras;
            Item = item;
            Smat_qtd = smat_qtd;
            Smat_dt_cad = smat_dt_cad;
        }

        [Required]
        public int Smat_id { get; set; }

        [Required]
        public Dados_NF Dados_NF { get; set; }


        [Required]
        public int Smat_cod_barras { get; set; }

        [Required]
        public Item Item { get; set; }

        [Required]
        public decimal Smat_qtd { get; set; }

        [Required]
        [DataType(dataType: DataType.DateTime)]
        public DateTime Smat_dt_cad { get; private set; }


    }
}

