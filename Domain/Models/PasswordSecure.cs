using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models
{
    internal class PasswordSecure
    {

    public virtual void SetSecurePassword(string password) 
        {
            //using var hmac = new HMACSHA256();
            //Salt = Convert.ToBase64String(hmac.Key);
            //var hashBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            //password = Convert.ToBase64String(hashBytes);
        
        }
    }


}



