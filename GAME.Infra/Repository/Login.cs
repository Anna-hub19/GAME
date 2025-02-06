using GAME.Domain.Entity;
using GAME.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME.Infra.Repository
{
    public class Login : ILogin
    {
        bool ILogin.GetLogin(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
