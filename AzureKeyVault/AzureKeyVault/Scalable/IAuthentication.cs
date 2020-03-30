using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System.Threading.Tasks;

namespace AzureKeyVault
{
    public interface IAuthentication
    {
        /// <summary>
        /// Get AuthenticationResult
        /// </summary>
        /// <param name="authority">Security principal. e.g. https://login.microsoftonline.com/common/microsoft.onmicrosoft.com"</param>
        /// <param name="resource">Resources to access. e.g. "https://graph.microsoft.com/v1.0"</param>
        /// <param name="scope">query terms. e.g. "User.Read"</param>
        /// <returns>AuthenticationResult</returns>
        Task<AuthenticationResult> GetAuthenticationResultAsync(string authority, string resource, string scope);
    }
}
