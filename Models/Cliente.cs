using System;
using System.Collections.Generic;

#nullable disable

namespace RedeBebidas.Models
{
    public partial class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string TelefoneTipo { get; set; }
        public string TelefoneNumero { get; set; }
        public string EnderecoTipo { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public string EnderecoNumero { get; set; }
    }
}
