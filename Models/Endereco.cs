using CadastrarUser.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadastrarUser.Models
{
    public class Endereco : BaseModel
    {
        [Required(ErrorMessage = "O campo Logradouro é obrigatório.")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O campo Complemento é obrigatório.")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "O campo Número é obrigatório.")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "O campo Cidade é obrigatório.")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O campo Estado é obrigatório.")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "O campo País é obrigatório.")]
        public string Pais { get; set; }

        [Required(ErrorMessage = "O campo CEP é obrigatório.")]
        public string CEP { get; set; }


        public Endereco()
        {
        }

        public Endereco(string logradouro, string complemento, string numero, string cidade, string estado, string pais, string cep)
        {
            Logradouro = logradouro;
            Complemento = complemento;
            Numero = numero;
            Cidade = cidade;
            Estado = estado;
            Pais = pais;
            CEP = cep;
        }
    }
}