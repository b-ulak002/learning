using Microsoft.Azure.KeyVault;
using Microsoft.Azure.Services.AppAuthentication;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureKeyVault
{
    class Program
    {
        static void Main(string[] args)
        {        
            //Option 1: Simple solution
            AzureServiceTokenProvider tokenProvider = new AzureServiceTokenProvider();
            KeyVaultClient keyVaultClient = new KeyVaultClient(new KeyVaultClient.AuthenticationCallback(tokenProvider.KeyVaultTokenCallback));
            string secretUri = "https://test-kv-for-learning.vault.azure.net/secrets/test-secret/9b53e0caf5024d9a87c41d2750550780";
            var credentail = keyVaultClient.GetSecretAsync(secretUri).Result;
            var secret = credentail.Value.ToString();

            //Option 2: Scalable solution, more advanced using X509 certificate on the machine
            KeyVaultFactory kvsf = new KeyVaultFactory();
            KeyVaultBase mssaKeyVault = kvsf.GetKeyVault(KeyVaultEnum.Mssa);
            string uri = "https://ram-keyvault.vault.azure.net/secrets/releaseinformationppe/09206feab33e4c1b9bec280a131dc3dd";
            var password = mssaKeyVault.GetSecretFromKeyVault(uri);          
        }
    }
}
