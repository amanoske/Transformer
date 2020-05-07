# What is Transformer?
Transformer is a C#.net class library that leverages [SharpVault](https://github.com/rajanadar/VaultSharp) to manage encoding and decoding data via the [Transform Secret Engine](https://learn.hashicorp.com/vault/adp/transform) in [HashiCorp Vault Enterprise](https://www.hashicorp.com/products/vault/)

# How does it work?
Once you have configured your Vault system and auth method, Transform simplifies the process of encoding and decoding data in a threadsafe manner. 

````c#
//asssume IVaultClient client initialized, roles within Endpoint configured for "FPE-role." See SharpVault for more details
Transformer transform = new Transformer(client);
transform.setRole("FPE-role");

//Encode a set of text
string encode_me = transform.encode(encode_me);

//Decode encoded text
string decode_me = transform.decode(decode_me);
````
