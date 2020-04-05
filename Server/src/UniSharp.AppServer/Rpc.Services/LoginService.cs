using System;
using MagicOnion.Server;
using UniSharp.Shared.Rpc.Services;

namespace UniSharp.AppServer.Rpc.Services
{
    public class LoginService : ServiceBase<ILoginService>, ILoginService
    {
        public void Register(Guid uuid)
        {
            throw new NotImplementedException();
        }

        public void Login(Guid uuid)
        {
            throw new NotImplementedException();
        }
    }
}