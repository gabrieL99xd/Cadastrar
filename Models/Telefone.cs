using CadastrarUser.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CadastrarUser.Models
{
    public class Telefone : BaseModel
    {
        [Required(ErrorMessage = "O campo Número de Telefone é obrigatório.")]
        public string NumeroDeTelefone { get; set; }
        public int UsuarioId;
        public Telefone(string numero)
        {
            NumeroDeTelefone = numero;
        }

        public Telefone() { }

    }
}