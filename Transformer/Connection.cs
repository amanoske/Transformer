using System;
using VaultSharp;

namespace Transformer
{
    public class Connection
    {
        public Connection(IVaultClient client)
        {
            session = client;
        }

        public IVaultClient session
        {
            get { return session; }
            set { session = value; }
        }
    }
}
