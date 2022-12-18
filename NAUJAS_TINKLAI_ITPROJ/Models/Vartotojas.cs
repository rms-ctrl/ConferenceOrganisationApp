using System;
using System.Security.Cryptography;

namespace NAUJAS_TINKLAI_ITPROJ.Models
{
    public class Vartotojas
    {
        public int pk_Id { get; set; }
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public string ElPastas { get; set; }
        public string Slaptazodis { get; set; }
        public DateTime GimimoData { get; set; }
        public string Privilegijos { get; set; }


        // Method to encrypt the password using MD5
        public void EncryptPassword()
        {
            using (MD5CryptoServiceProvider provider = new MD5CryptoServiceProvider())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(Slaptazodis);
                Slaptazodis = Convert.ToBase64String(provider.ComputeHash(inputBytes));
            }
        }

        // Method to verify the password using MD5
        public bool VerifyPassword(string enteredPassword)
        {
            using (MD5CryptoServiceProvider provider = new MD5CryptoServiceProvider())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(enteredPassword);
                string enteredPasswordHash = Convert.ToBase64String(provider.ComputeHash(inputBytes));

                return Slaptazodis == enteredPasswordHash;
            }
        }
    }
}