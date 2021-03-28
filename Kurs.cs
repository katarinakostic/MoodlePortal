using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodlePortal
{
    public class Kurs
    {
        public String Sifra_kursa { get; set; }
        public String Naziv { get; set; }
        public int Godina { get; set; }
        public byte Izborni { get; set; }   //0 ako jeste, 1 ako nije
        public String Pristupni_kod { get; set; }
        public Kurs(String sifra, String naziv, int god, byte izborni, String pr_kod)
        {
            Sifra_kursa = sifra;
            Naziv = naziv;
            Godina = god;
            Izborni = izborni;
            Pristupni_kod = pr_kod;
        }
      
        internal static string GenerateCode(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string s = "";
            using (System.Security.Cryptography.RNGCryptoServiceProvider provider = new System.Security.Cryptography.RNGCryptoServiceProvider())
            {
                while (s.Length != length)
                {
                    byte[] oneByte = new byte[1];
                    provider.GetBytes(oneByte);
                    char character = (char)oneByte[0];
                    if (valid.Contains(character))
                    {
                        s += character;
                    }
                }
            }
            return s;
        }

        /*
        internal static string GenerateCode()
        {
            //byte[] bytes = System.Text.Encoding.UTF8.GetBytes(input + salt);
            byte[] bytes = new byte[9];
            System.Security.Cryptography.SHA256Managed sha256hashstring = new System.Security.Cryptography.SHA256Managed();

            byte[] hash = sha256hashstring.ComputeHash(bytes);
            
            return SecurityLogin.ByteArrayToHexString(hash);
        }
        */

    }
}
