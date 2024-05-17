using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoirRush
{
    internal class Readme
    {
        /*
**Main Objects:**

1. **JsonConvert**: This class provides serialization and deserialization methods.
2. **JObject**: A JSON object that can be used to create or parse JSON data.

        **Serialization and Deserialization Methods:**

        1. **ToJson()**: Converts a .NET object to a JSON string.
        2. **FromJson()**: Converts a JSON string to a .NET object.
        3. **SerializeObject()**: Serializes an object to a JSON string.
        4. **DeserializeObject()**: Deserializes a JSON string to an object.



        **1. `ToJson()`**

* Converts a .NET object to a JSON string.
* Can be used to serialize any .NET object, including custom classes, dictionaries, and arrays.
* Example:
```csharp
public class Person {
    public string Name { get; set; }
    public int Age { get; set; }
}

Person person = new Person { Name = "John", Age = 30 };
string json = JsonConvert.SerializeObject(person);
// Output: {"Name":"John","Age":30}
```
**2. `FromJson()`**

* Converts a JSON string to a .NET object.
* Can be used to deserialize a JSON string into any .NET object, including custom classes, dictionaries, and arrays.
* Example:
```csharp
string json = "{\"Name\":\"John\",\"Age\":30}";
Person person = JsonConvert.DeserializeObject<Person>(json);
// Output: Name = "John", Age = 30
```
**3. `SerializeObject()`**

* Serializes an object to a JSON string.
* Similar to `ToJson()`, but allows for more control over the serialization process, such as specifying the formatting of
dates and numbers.
* Example:
```csharp
Person person = new Person { Name = "John", Age = 30 };
string json = JsonConvert.SerializeObject(person, Formatting.Indented);
// Output: {
//   "Name": "John",
//   "Age": 30
// }
```
**4. `DeserializeObject()`**

* Deserializes a JSON string to an object.
* Similar to `FromJson()`, but allows for more control over the deserialization process, such as specifying the type of
object to deserialize into.
* Example:
```csharp
string json = "{\"Name\":\"John\",\"Age\":30}";
Person person = JsonConvert.DeserializeObject<Person>(json);
// Output: Name = "John", Age = 30
```
Key points:

* `ToJson()` and `FromJson()` are convenience methods that can be used to quickly serialize or deserialize objects.
* `SerializeObject()` and `DeserializeObject()` provide more control over the serialization and deserialization process,
but require more code to set up.
* All of these methods use the JSON.NET library under the hood, which is a popular and widely-used library for working
with JSON data in .NET.

**File Encryption and Decryption:**

Newtonsoft JSON doesn't have built-in file encryption/decryption methods. However, you can use the
`System.Security.Cryptography` namespace to encrypt and decrypt files separately from Newtonsoft JSON. Here's an example:

1. **Encrypting a File:**
```csharp
using System.IO;
using System.Security.Cryptography;

// Load the file contents
string json = File.ReadAllText("input.json");

// Encrypt the file contents using AES encryption
var aesAlg = Aes.Create();
aesAlg.KeySize = 256;
aesAlg.GenerateKey();
aesAlg.GenerateIV();

MemoryStream ms = new MemoryStream();
CryptoStream cs = new CryptoStream(ms, aesAlg.CreateEncryptor(), CryptoStreamMode.Write);
StreamWriter writer = new StreamWriter(cs);
writer.Write(json);
writer.Flush();
cs.Flush();
ms.Flush();

// Save the encrypted file
File.WriteAllBytes("output.json", ms.ToArray());
```

2. **Decrypting a File:**
```csharp
using System.IO;
using System.Security.Cryptography;

// Load the encrypted file contents
byte[] encrypted = File.ReadAllBytes("input.json");

// Decrypt the file contents using AES decryption
var aesAlg = Aes.Create();
aesAlg.KeySize = 256;
aesAlg.GenerateKey();
aesAlg.GenerateIV();

MemoryStream ms = new MemoryStream(encrypted);
CryptoStream cs = new CryptoStream(ms, aesAlg.CreateDecryptor(), CryptoStreamMode.Read);
StreamReader reader = new StreamReader(cs);
string decryptedJson = reader.ReadToEnd();
reader.Close();

// Save the decrypted JSON to a file
File.WriteAllText("output.json", decryptedJson);
```

**Best Practices for Securing Passwords:**

1. **Use strong encryption:** Use established encryption algorithms like AES or Blowfish.
2. **Hash and salt passwords:** Store hashed passwords with a random salt value to prevent rainbow table attacks.
3. **Validate user input:** Validate user input (e.g., username and password) before processing it.
4. **Limit access:** Limit access to sensitive data and only provide necessary permissions.

Example of hashing and salting a password:
```csharp
using System.Security.Cryptography;
using System.Text;

// Set the salt value
string salt = "my_secret_salt";

// Get the user's input (username and password)
string username = "john";
string password = "mYPaSsWoRd123!";

// Hash the password with the salt value
var sha256 = SHA256.Create();
var hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password + salt));
string hashedPassword = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();

// Store the hashed password in your database
```

In this example, we use the SHA-256 hashing algorithm to generate a unique hash for each password. The salt value is
concatenated with the password before hashing, making it more difficult for attackers to use precomputed tables (rainbow
tables) to crack the password. */
    }
}
