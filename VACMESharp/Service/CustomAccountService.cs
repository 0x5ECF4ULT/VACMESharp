#nullable enable
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TGIT.ACME.Protocol.Model;
using TGIT.ACME.Protocol.RequestServices;
using TGIT.ACME.Protocol.Services;
using TGIT.ACME.Protocol.Storage;

namespace VACMESharp.Service
{
    public class CustomAccountService : IAccountService
    {
        private readonly IAcmeRequestProvider _requestProvider;
        private readonly IAccountStore _accountStore;

        public CustomAccountService(IAcmeRequestProvider requestProvider, IAccountStore accountStore)
        {
            _requestProvider = requestProvider;
            _accountStore = accountStore;
        }
        
        public Task<Account> CreateAccountAsync(Jwk jwk, List<string>? contact, bool termsOfServiceAgreed, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Account?> FindAccountAsync(Jwk jwk, CancellationToken cancellationToken) => throw new NotImplementedException();

        public Task<Account?> LoadAcountAsync(string accountId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<Account> FromRequestAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}