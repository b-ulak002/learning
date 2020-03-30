using Microsoft.Azure.KeyVault;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AzureKeyVault
{
    public abstract class KeyVaultBase: AuthenticationBase, IKeyVault
    {
        public virtual SecureString GetSecretFromKeyVaultAsSecureString(string secretUri)
        {
            var kv = new KeyVaultClient(new KeyVaultClient.AuthenticationCallback(GetToken));
            var sec = kv.GetSecretAsync(secretUri).Result;
            if (sec == null)
                throw new InvalidOperationException($"Failed to obtain secret for {secretUri}");
            var password = new SecureString();
            foreach (var c in sec.Value) password.AppendChar(c);
            return password;
        }

        public virtual string GetSecretFromKeyVault(string secretUri)
        {
            var kv = new KeyVaultClient(new KeyVaultClient.AuthenticationCallback(GetToken));
            var sec = kv.GetSecretAsync(secretUri).Result;
            if (sec == null)
                throw new InvalidOperationException($"Failed to obtain password for {secretUri}");

            return sec.Value;
        }

        public virtual X509Certificate2 GetCertificateFromKeyVault(string secretUri)
        {
            var kv = new KeyVaultClient(new KeyVaultClient.AuthenticationCallback(GetToken));
            var sec = kv.GetSecretAsync(secretUri).Result;
            byte[] privateKeyBytes = Convert.FromBase64String(sec.Value);
            X509Certificate2 certificateWithPrivateKey = new X509Certificate2(privateKeyBytes, (string)null, X509KeyStorageFlags.MachineKeySet);
            if (certificateWithPrivateKey == null)
                throw new InvalidOperationException($"Failed to obtain certificate with private key for {secretUri}");

            return certificateWithPrivateKey;
        }

        private async Task<string> GetToken(string authority, string resource, string scope)
        {
            var clientAssertionCertPfx = CertificateHelper.FindCertificateByThumbprint(CertificateThumbprint);
            ClientAssertionCertificate assertionCert = new ClientAssertionCertificate(AzureADClientId, clientAssertionCertPfx);
            AuthenticationResult result = null;
            AuthenticationContext context = new AuthenticationContext(authority, TokenCache.DefaultShared);
            if (assertionCert != null)
                result = await context.AcquireTokenAsync(resource, assertionCert);

            if (result == null)
                throw new InvalidOperationException("Failed to obtain the access token");

            return result.AccessToken;
        }
    }
}
