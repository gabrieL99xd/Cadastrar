using CadastrarUser.Context;
using CadastrarUser.Repository;
using CadastrarUser.Repository.Interfaces;
using Ninject.Modules;

namespace CadastrarUser.DI
{
    public class NinjectBindings : NinjectModule
    {
        public override void Load()
        {
            Bind<UserContext>().To<UserContext>();
            Bind<IUserRepository>().To<UserRepository>();
        }
    }
}