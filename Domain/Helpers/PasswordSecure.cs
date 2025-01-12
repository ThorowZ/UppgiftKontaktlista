using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    public static class PasswordSecure
    {
    //    public static readonly byte[] _key = Encoding.UTF8.GetBytes("FTZBMLKrIm");

    //public static string SetSecurePassword(string password) 
    //    {
    //        using var hmac = new HMACSHA256(_key);
    //        var key = hmac.Key;
    //        var hashBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
    //        var encoded = Convert.ToBase64String(hashBytes);
    //        return encoded;

    //    }

    //    public static bool Validate(string password, string expectedeHashedPassword)
    //    {
    //        using var hmac = new HMACSHA256(_key);
    //        var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
    //        var encoded = Convert.ToBase64String(hash);
    //        return encoded == expectedeHashedPassword;
    //    }
    }


}



