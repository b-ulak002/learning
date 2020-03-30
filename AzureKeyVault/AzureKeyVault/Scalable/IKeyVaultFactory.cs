namespace AzureKeyVault
{
    /// <summary>
    /// Interface for key vault service factory
    /// Implements a factory design pattern
    /// </summary>
    public interface IKeyVaultFactory
    {
        /// <summary>
        /// Factory method to create IKeyVaultService object based on enum. 
        /// </summary>
        /// <param name="vault">Enum for different key vault service. e.g. TrackIt</param>
        /// <returns>IKeyVaultService</returns>
        KeyVaultBase GetKeyVault(KeyVaultEnum vault);
    }
}
