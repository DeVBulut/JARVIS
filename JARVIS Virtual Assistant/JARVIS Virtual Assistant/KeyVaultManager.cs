using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JARVIS_Virtual_Assistant
{
    public class KeyVaultManager
    {
        readonly string tenantId;
        readonly string clientId;
        readonly string clientSecret;

        public KeyVaultManager()
        {
            tenantId = "7bf9a1e4-1321-4358-afdc-a32c2d54bf07";
            clientId = "6f6edb87-318a-407d-ba6f-b241cfc136af";
            clientSecret = "TfJ8Q~JgbUl4_YcxtIP4ZtNUnxLp0JofdTt2YcCG";
        }

        public string GetSecret(string SecretName)
        {
            var credential = new ClientSecretCredential(tenantId, clientId, clientSecret);
            var client = new SecretClient(vaultUri: new Uri("https://projectadamvault.vault.azure.net/"), credential);
            return client.GetSecret(SecretName).Value.Value;
        }

    }
}
