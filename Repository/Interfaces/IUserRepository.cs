using CadastrarUser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrarUser.Repository.Interfaces
{
    public interface IUserRepository
    {
        void Add(Usuario user);
        void Update(Usuario user);
        void Delete(Usuario user);
        Usuario Get(int id);
        List<Usuario> GetAll();
    }
}
