using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace AzureKeyVault
{
    public abstract class AuthenticationBase : IAuthentication
    {
        /// <summary>
        /// Azure AD client Id
        /// </summary>
        /// <see cref="https://docs.microsoft.com/en-us/azure/active-directory/develop/howto-create-service-principal-portal"/>
        public string AzureADClientId { get; protected set; }
        /// <summary>
        /// Certificate thumbprint
        /// </summary>
        /// <see cref="https://docs.microsoft.com/en-us/azure/key-vault/key-vault-use-from-web-application#authenticate-with-a-certificate-instead-of-a-client-secret"/>
        public string CertificateThumbprint { get; protected set; }

        /// <summary>
        /// Get AuthenticationResult
        /// </summary>
        /// <param name="authority">Security principal. e.g. https://login.microsoftonline.com/common/microsoft.onmicrosoft.com"</param>
        /// <param name="resource">Resources to access. e.g. "https://graph.microsoft.com/v1.0"</param>
        /// <param name="scope">query terms. e.g. "User.Read"</param>
        /// <returns>AuthenticationResult</returns>
        public virtual async Task<AuthenticationResult> GetAuthenticationResultAsync(string authority, string resource, string scope)
        {
            var authenticationContext = new AuthenticationContext(authority, TokenCache.DefaultShared);
            var clientAssertionCertPfx = await CertificateHelper.FindCertificateByThumbprintAsync(CertificateThumbprint);
            ClientAssertionCertificate assertionCert = new ClientAssertionCertificate(AzureADClientId, clientAssertionCertPfx);
            AuthenticationResult res = await authenticationContext.AcquireTokenAsync(resource, assertionCert);
            return res;
        }

        
    }
}
