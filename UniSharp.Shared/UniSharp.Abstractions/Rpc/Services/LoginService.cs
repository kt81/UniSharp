using System;
using MagicOnion;

namespace UniSharp.Shared.Rpc.Services
{
    public interface ILoginService : IService<ILoginService>
    {
        void Register(Guid uuid);

        void Login(Guid uuid);
    }
}