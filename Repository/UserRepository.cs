using CadastrarUser.Context;
using CadastrarUser.Exceptions;
using CadastrarUser.Models;
using CadastrarUser.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CadastrarUser.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _context;
        public UserRepository(UserContext context) 
        {
            _context = context;
        }

        public void Add(Usuario user)
        {
            user.DataCriacaoDoRegistro = DateTime.Now;
            user.DataAtualizacaoDoRegistro = DateTime.Now;
            _context.Usuarios.Add(user);
            _context.SaveChanges();
        }

        public void Update(Usuario user)
        {
            var Existe = _context.Usuarios.Any(u => u.Id == user.Id);
            if(!Existe)
            {
                throw new UsuarioNaoEncontradoException("Usuário não existe.");
            }

            user.DataAtualizacaoDoRegistro = DateTime.Now;
            //Ids do front para ser excluídos foram multiplicado por -1
            foreach (var telefone in user.Telefones)
            {
                if(telefone.Id  < 0)
                {
                    telefone.Id *= -1;
                    _context.Telefones.Remove(telefone);
                }
            }

            _context.Usuarios.Update(user);
            
            _context.SaveChanges();
        }

        public void Delete(Usuario user)
        {
            var Existe = _context.Usuarios.Any(u => u.Id == user.Id);
            if (!Existe)
            {
                throw new UsuarioNaoEncontradoException("Usuário não existe.");
            }

            _context.Usuarios.Remove(user);
             _context.SaveChanges();
        }

        public Usuario Get(int id)
        {
            return _context.Usuarios.Include(u => u.Endereco).Include(u => u.Telefones).FirstOrDefault(u => u.Id == id);
        }

        public List<Usuario> GetAll()
        {
            return _context.Usuarios.Include(u => u.Endereco).Include(u => u.Telefones).ToList();
        }
    }
}