using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TGIT.ACME.Protocol.Model;
using TGIT.ACME.Protocol.Services;

namespace VACMESharp.Service
{
    public class CustomAccountService : IAccountService
    {
        public Task<Account> CreateAccountAsync(Jwk jwk, List<string>? contact, bool termsOfServiceAgreed, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<Account?> FindAccountAsync(Jwk jwk, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<Account?> LoadAcountAsync(string accountId, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<Account> FromRequestAsync(CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}