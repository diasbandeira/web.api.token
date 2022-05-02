using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.API.Token.Authentication.Models;

namespace Web.API.Token.Authentication.Services
{
    public class FuncionariosSeguranca
    {
        public static bool Login(string login, string senha)
        {
            using (FuncionarioDbContext entities = new FuncionarioDbContext())
            {
                return entities.Usuarios.Any(user =>
                    user.Login.Equals(login, StringComparison.OrdinalIgnoreCase) && user.Senha == senha);                
            }
        }
    }
}