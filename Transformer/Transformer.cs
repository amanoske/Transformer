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
        
       public String encode(String encode_value)
       {
            return encoder.encode(encode_value, role).ToString();
       }
        public String encode(String encode_value, String temp_role)
        {
            return encoder.encode(encode_value, temp_role).ToString();
        }
        public String decode(String decode_value)
        {
            return decoder.decode(decode_value, role).ToString();
        }
        public String decode(String decode_value, String temp_role)
        {
            return decoder.decode(decode_value, temp_role).ToString();
        }
        
        public string role
        {
            get {return role;}
            set {role = value;}
        }
        Connection client_connection;
        Encoder encoder;
        Decoder decoder;
    }
}
