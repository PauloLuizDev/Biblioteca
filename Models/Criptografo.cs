using System;
using System.Security.Cryptography;
using System.Text;

namespace Biblioteca.Models
{
    public static class criptografo
    {
        public static string TextoCriptografado(string TextoClaro)
        {
            MD5 MD5Hasher = MD5.Create();

            byte[] By = Encoding.Default.GetBytes(TextoClaro);
            byte[] BytesCriptografado = MD5Hasher.ComputeHash(By);

            StringBuilder SB = new StringBuilder();
            foreach(byte b in BytesCriptografado)
            {
                string DebugB = b.ToString("x2");
                SB.Append(DebugB);
            }

            return SB.ToString();

        }
    }
}