using CadastrarUser.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CadastrarUser.Models
{
    public class Usuario : BaseModel
    {   

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "O campo Email deve ser um endereço de email válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Senha é obrigatório.")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "A senha deve ter entre 6 e 50 caracteres.")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "O campo CPF é obrigatório.")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "O campo Data de Nascimento é obrigatório.")]
        [DataType(DataType.Date, ErrorMessage = "O campo Data de Nascimento deve ser uma data válida.")]
        public DateTime DataNascimento { get; set; }

        public DateTime DataCriacaoDoRegistro { get; set; }

        public DateTime DataAtualizacaoDoRegistro { get; set; }

        public List<Telefone> Telefones { get; set; }

        public Perfil Perfil { get; set; }

        public Endereco Endereco { get; set; }

        public Usuario()
        {
        }

        public Usuario(string nome, string email, string senha, string cpf, DateTime dataNascimento, DateTime dataCriacao, DateTime dataAtualizacao, List<Telefone> telefones, Endereco endereco , Perfil perfil)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            DataCriacaoDoRegistro = dataCriacao;
            DataAtualizacaoDoRegistro = dataAtualizacao;
            Telefones = telefones;
            Endereco = endereco;
            Perfil = perfil;
        }
    }
}