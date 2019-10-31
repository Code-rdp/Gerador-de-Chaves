using System;
using System.Text;

namespace Gerador_de_Chaves
{
    public class Licença {

        // Método usando para codificar, você pode usar interno, público, privado ...
        public static string Base64Encode(string texto)
        {
            var texto_code = Encoding.UTF8.GetBytes(texto);
            return Convert.ToBase64String(texto_code);
        }

        // Método usando para decodificar, você pode usar interno, público, privado ...
        public static string Base64Decode(string texto_code)
        {
            var texto_decode = Convert.FromBase64String(texto_code);
            return Encoding.UTF8.GetString(texto_decode);
        }
    }
}
