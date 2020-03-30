using System.Security;

namespace AzureKeyVault
{
    public interface IKeyVault : IAuthentication
    {
        /// <summary>
        /// Get Secret from key vault as secure string(prefered method)
        /// </summary>
        /// <param name="secretUri">Uri to locate secret in key vault</param>
        /// <returns>SecureString</returns>
        SecureString GetSecretFromKeyVaultAsSecureString(string secretUri);
        /// <summary>
        /// Get Secret from key vault as plain text
        /// </summary>
        /// <param name="secretUri">Uri to locate secret in key vault</param>
        /// <returns>string</returns>
        string GetSecretFromKeyVault(string secretUri);
    }
}
