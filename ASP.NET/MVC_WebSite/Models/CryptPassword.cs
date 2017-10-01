using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace MVC_WebSite.Models
{
    /*
    public class CryptPassword
    {

        // Create hash to insert password into database
        public static string CryptSha256(string password)
        {
            SHA512 sha = SHA512.Create();
            byte[] data = sha.ComputeHash(System.Text.Encoding.Default.GetBytes(password));
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
               sb.Append(data[i].ToString("x2"));
            }
            password = sb.ToString();
            return password;
        }
    }
    */
}