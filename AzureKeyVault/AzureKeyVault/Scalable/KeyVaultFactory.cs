using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureKeyVault
{
    public class KeyVaultFactory : IKeyVaultFactory
    {
        /// <summary>
        /// Template for factory design pattern
        /// </summary>
        /// <param name="vault"></param>
        /// <returns></returns>
        public KeyVaultBase GetKeyVault(KeyVaultEnum vault)
        {
            switch (vault)
            {
                case KeyVaultEnum.Mssa:
                    return new MssaKeyVault();
                default:
                    throw new ApplicationException(string.Format($"{vault} key vault cannot be created."));
            }
        }
    }
}
