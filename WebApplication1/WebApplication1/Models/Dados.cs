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
        public int Id { get; protected set; }
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


    public class Receita
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
        public int Rec_id { get; protected set; }

        [Required]
        public Item Item { get; protected set; }

        [Required]
        public decimal Rec_item_qtd { get; protected set; }

        [Required]
        public bool Rec_status { get; protected set; }

        [Required]
        [DataType(dataType: DataType.DateTime)]
        public DateTime Rec_dt_cad { get; private set; }



    }

    public class Item
    {
        public Item()
        {
        }
    }
}
