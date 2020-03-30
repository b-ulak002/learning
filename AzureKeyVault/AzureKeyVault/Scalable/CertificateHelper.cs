using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AzureKeyVault
{
    public static class CertificateHelper
    {
        /// <summary>
        /// Find certificate by thumbprint. Look in specific list of cert stores
        /// </summary>
        public static X509Certificate2 FindCertificateByThumbprint(string thumbprint)
        {
            List<X509Store> storesToLook = new List<X509Store>
            {
                new X509Store(StoreName.My, StoreLocation.CurrentUser),
                new X509Store(StoreName.TrustedPeople, StoreLocation.LocalMachine)
            };
            foreach (var store in storesToLook)
            {
                X509Certificate2 cert = FindCertificateInStore(store, thumbprint);
                if (cert != null)
                {
                    return cert;
                }
            }
            return null;
        }

        /// <summary>
        /// Retrieve certificate from store
        /// </summary>
        private static X509Certificate2 FindCertificateInStore(X509Store store, string thumbprint)
        {
            try
            {
                store.Open(OpenFlags.ReadOnly);
                X509Certificate2Collection col = store.Certificates.Find(X509FindType.FindByThumbprint,
                    thumbprint, false);
                if (col == null || col.Count == 0)
                    return null;
                return col[0];
            }
            finally
            {
                store.Close();
            }
        }

        /// <summary>
        /// Find Certificate By Thumbprint. Location==LocalMachine, StoreName==TrustedPeople
        /// </summary>
        public static Task<X509Certificate2> FindCertificateByThumbprintAsync(string thumbprint)
        {
            List<X509Store> stores = new List<X509Store>
            {
                new X509Store(StoreName.My, StoreLocation.CurrentUser),
                new X509Store(StoreName.TrustedPeople, StoreLocation.LocalMachine)
            };
            foreach (var store in stores)
            {
                X509Certificate2 cert = FindCertificateInStoreAsync(store, thumbprint);
                if (cert != null)
                {
                    return Task.FromResult(cert);
                }
            }
            return null;
        }

        private static X509Certificate2 FindCertificateInStoreAsync(X509Store store, string thumbprint)
        {
            try
            {
                store.Open(OpenFlags.ReadOnly);
                X509Certificate2Collection col = store.Certificates.Find(X509FindType.FindByThumbprint,
                    thumbprint, false);
                if (col == null || col.Count == 0)
                    return null;

                return col[0];
            }
            finally
            {
                store.Close();
            }
        }
    }
}
