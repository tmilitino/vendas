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

        public Entrada(Produto produto, Cliente cliente, char ent_status, DateTime ent_dt_cad, decimal ent_valor, decimal ent_desconto, char ent_formaPag)
        {
            this.produto = produto;
            this.cliente = cliente;
            Ent_status = ent_status;
            Ent_dt_cad = ent_dt_cad;
            Ent_valor = ent_valor;
            Ent_desconto = ent_desconto;
            Ent_formaPag = ent_formaPag;
        }

        [Required]
       public Produto produto { get; private set; }


        [Required]
        public Cliente cliente { get; private set; }

        [Required]
        public char Ent_status { get; private set; }

        [DataType(dataType: DataType.DateTime)]
        public DateTime Ent_dt_cad { get; private set; }

        [Required]
        public decimal Ent_valor { get; private set; }
        
    [Required]
    public decimal Ent_desconto { get; private set; }

        [Required]
        public char Ent_formaPag { get; private set; }
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

    }
}
