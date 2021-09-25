using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RedeBebidas.Models
{
    public class ClienteValidator
    {
        [Required]
        [MaxLength(50)]
        [MinLength(5)]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(5)]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [MaxLength(14)]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        [MaxLength(20)]
        [MinLength(5)]
        [Display(Name = "Tipo de telefone")]
        public string TelefoneTipo { get; set; }

        [MaxLength(20)]
        [MinLength(10)]
        [Display(Name = "Número de telefone")]
        public string TelefoneNumero { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(5)]
        [Display(Name = "Tipo de endereço")]
        public string EnderecoTipo { get; set; }

        [Required]
        [MaxLength(9)]
        [Display(Name = "CEP")]
        public string Cep { get; set; }

        [Required]
        [MaxLength(2)]
        [MinLength(2)]
        [Display(Name = "Estado")]
        public string Estado { get; set; }

        [Required]
        [MaxLength(30)]
        [MinLength(5)]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Required]
        [MaxLength(30)]
        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [Required]
        [MaxLength(40)]
        [MinLength(5)]
        [Display(Name = "Logradouro")]
        public string Logradouro { get; set; }

        [Required]
        [MaxLength(5)]
        [MinLength(1)]
        [Display(Name = "Número de endereço")]
        public string EnderecoNumero { get; set; }
    }

    [ModelMetadataType(typeof(ClienteValidator))]
    public partial class Cliente
    {
    }
}
