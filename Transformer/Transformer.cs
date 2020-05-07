using System;
using VaultSharp;
using System.IO;

namespace Transformer
{
    public class Transformer
    {
        public Transformer(IVaultClient connection_details)
        {
            client_connection = new Connection(connection_details);
            encoder = new Encoder(client_connection);
            decoder = new Decoder(client_connection);
        }
        public String encode(String encode)
        {
        }
        public String decode(String decode)
        {

        }

        Connection client_connection;
        Encoder encoder;
        Decoder decoder;
    }
}
