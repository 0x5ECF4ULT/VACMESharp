#nullable enable
using System.Threading;
using System.Threading.Tasks;
using TGIT.ACME.Protocol.IssuanceServices;
using TGIT.ACME.Protocol.Model;

namespace VACMESharp.Service
{
    public class VaultCertificateIssuer : ICertificateIssuer
    {
        public Task<(byte[]? certificate, AcmeError? error)> IssueCertificate(string csr, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}