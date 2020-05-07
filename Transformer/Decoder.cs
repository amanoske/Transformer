using System;
using VaultSharp.V1.Commons;
using VaultSharp.V1.SecretsEngines.Transform;

namespace Transformer
{
    public class Decoder
    {
        public Decoder(Connection client)
        {
            connection = client;
        }

        public async System.Threading.Tasks.Task<string> decode(String decode_value, String role_name)
        {
            var decodeOptions = new DecodeRequestOptions { Value = decode_value};
            Secret<DecodedResponse> response = await connection.session.V1.Secrets.Transit.DecryptAsync(role_name, decodeOptions);
            return response.Data.DecodedValue;
        }

        Connection connection;

    }
}
