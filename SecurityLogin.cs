using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodlePortal
{
    class SecurityLogin
    {
        public String GenSaltSHA256(String pass_input)
        {
            String salt = CreateSalt(10);
            String hashed_password = salt.Substring(0, 8) + GenerateSHA256Hash(pass_input, salt) + salt.Substring(8, 8);

            //saltBox.Text = salt;
            //hashBox.Text = hashed_password;

            return hashed_password;
        }


        //na osnovu unetog passworda, generise se hash vrednost koja se spaja sa salt-om iz baze 
        //i proverava se da li se ta vrednost poklapa sa passwordom u bazi
        public String CheckValue(String username, String pass_input)
        {
            //pronaci salt vrednost iz baze
            //String salt = RadSaBazomNastavnik.getSalt(username);
            String salt = RadSaBazomLogin.getSalt(username);

            String hashed_password = salt.Substring(0, 8) + GenerateSHA256Hash(pass_input, salt) + salt.Substring(8, 8);

            return hashed_password;

        }

        public String CreateSalt(int size)
        {
            var rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            var buff = new byte[size];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }

        public String GenerateSHA256Hash(String input, String salt)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input + salt);
            System.Security.Cryptography.SHA256Managed sha256hashstring = new System.Security.Cryptography.SHA256Managed();

            byte[] hash = sha256hashstring.ComputeHash(bytes);

            return ByteArrayToHexString(hash);
        }
        public static string ByteArrayToHexString(byte[] ba)
        {
            StringBuilder hex = new StringBuilder(ba.Length * 2);
            foreach (byte b in ba)
                hex.AppendFormat("{0:x2}", b);
            return hex.ToString();
        }
    }
}
