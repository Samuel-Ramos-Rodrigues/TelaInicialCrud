using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace TelaInicialCrud.Models
{
    public class Projeto
    {
        [Key]
        public int IdProjeto { get; set; }
        public string NomeProjeto { get; set; }
        public string Descricao { get; set; }

        public float valor { get; set; }

        public DateTime DataInicio { get; set; }
        public DateTime DataFinal { get; set; }
        public int QuantPessoas { get; set; }
    }
}
