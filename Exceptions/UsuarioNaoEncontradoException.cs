using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadastrarUser.Exceptions
{
    public class UsuarioNaoEncontradoException : Exception
    {
        public UsuarioNaoEncontradoException()
        {
        }

        public UsuarioNaoEncontradoException(string message) : base(message)
        {
        }

        public UsuarioNaoEncontradoException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}