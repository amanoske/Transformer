using System;
using VaultSharp.V1.Commons;
using VaultSharp.V1.SecretsEngines.Transform;

namespace Transformer
{
    public class Encoder
    {
        public Encoder(Connection client)
        {
            connection = client;
        }

        public async System.Threading.Tasks.Task<string> encode(String encode_value, String role_name)
        {
            var encodeOptions = new EncodeRequestOptions{ Value = encode_value };
            Secret<EncodedResponse> response = await connection.session.V1.Secrets.Transit.EncryptAsync(encode_value, encodeOptions);
            return response.Data.EncodedValue.ToString();
        }

        public async System.Threading.Tasks.Task<string> encode(String encode_value, String role_name, String endpoint_path)
        {
            var encodeOptions = new EncodeRequestOptions { Value = encode_value };
            Secret<EncodedResponse> response = await connection.session.V1.Secrets.Transit.EncryptAsync(encode_value, encodeOptions, endpoint_path);
            return response.Data.EncodedValue.ToString();
        }

        Connection connection;
    }
}
