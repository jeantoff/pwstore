/*    
    PWSTORE store login informations fin an encrypted xml file
    Use only for testing or code re-use purpose.
    
    Copyright (C) 2014  Jean-Christophe Bouvard

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.

    Also add information on how to contact you by electronic and paper mail.

If the program does terminal interaction, make it output a short notice like this when it starts in an interactive mode:

    PWSTORE  Copyright (C) 2014  Jean-Christophe Bouvard
    This program comes with ABSOLUTELY NO WARRANTY.
    This is free software, and you are welcome to redistribute it
    under certain conditions.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.IO;


namespace pwstore
{
    /// <summary>
    /// Sources des finctions principales :
    /// http://www.codeproject.com/Articles/38951/How-To-Hash-Data-Using-MD5-and-SHA1
    /// </summary>
    public static class  cryptutils
    {
        /// <summary>
        /// take any string and encrypt it using MD5 then
        /// return the encrypted data 
        /// </summary>
        /// <param name="data">input text you will enterd to encrypt it</param>
        /// <returns>return the encrypted text as hexadecimal string</returns>
        public static string GetMD5HashData(string data)
        {
            //create new instance of md5
            MD5 md5 = MD5.Create();

            //convert the input text to array of bytes
            byte[] hashData = md5.ComputeHash(Encoding.Default.GetBytes(data));

            //create new instance of StringBuilder to save hashed data
            StringBuilder returnValue = new StringBuilder();

            //loop for each byte and add it to StringBuilder
            for (int i = 0; i < hashData.Length; i++)
            {
                returnValue.Append(hashData[i].ToString());
            }

            // return hexadecimal string
            return returnValue.ToString();

        }

        /// <summary>
        /// take any string and encrypt it using SHA1 then
        /// return the encrypted data
        /// </summary>
        /// <param name="data">input text you will enterd to encrypt it</param>
        /// <returns>return the encrypted text as hexadecimal string</returns>
        public static string GetSHA1HashData(string data)
        {
            //create new instance of md5
            SHA1 sha1 = SHA1.Create();

            //convert the input text to array of bytes
            byte[] hashData = sha1.ComputeHash(Encoding.Default.GetBytes(data));

            //create new instance of StringBuilder to save hashed data
            StringBuilder returnValue = new StringBuilder();

            //loop for each byte and add it to StringBuilder
            for (int i = 0; i < hashData.Length; i++)
            {
                returnValue.Append(hashData[i].ToString());
            }

            // return hexadecimal string
            return returnValue.ToString();
        }

        /// <summary>
        /// encrypt input text using MD5 and compare it with
        /// the stored encrypted text
        /// </summary>
        /// <param name="inputData">input text you will enterd to encrypt it</param>
        /// <param name="storedHashData">the encrypted text
        ///         stored on file or database ... etc</param>
        /// <returns>true or false depending on input validation</returns>
        public static bool ValidateMD5HashData(string inputData, string storedHashData)
        {
            //hash input text and save it string variable
            string getHashInputData = GetMD5HashData(inputData);

            if (string.Compare(getHashInputData, storedHashData) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// encrypt input text using SHA1 and compare it with
        /// the stored encrypted text
        /// </summary>
        /// <param name="inputData">input text you will enterd to encrypt it</param>
        /// <param name="storedHashData">the encrypted
        ///           text stored on file or database ... etc</param>
        /// <returns>true or false depending on input validation</returns>

        public static bool ValidateSHA1HashData(string inputData, string storedHashData)
        {
            //hash input text and save it string variable
            string getHashInputData = GetSHA1HashData(inputData);

            if (string.Compare(getHashInputData, storedHashData) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        ///<summary>
        /// Steve Lydford - 12/05/2008.
        ///
        /// Encrypts a file using Rijndael algorithm.
        ///</summary>
        ///<param name="inputFile"></param>
        ///<param name="outputFile"></param>
        public static  bool EncryptFile(string inputFile, string outputFile,string password)
        {
            if (password == "")
                password = @"myKey123";

            try
            {
                //string password = @"myKey123"; // Your Key Here
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                string cryptFile = outputFile;
                FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt,
                    RMCrypto.CreateEncryptor(key, key),
                    CryptoStreamMode.Write);

                FileStream fsIn = new FileStream(inputFile, FileMode.Open);

                int data;
                while ((data = fsIn.ReadByte()) != -1)
                    cs.WriteByte((byte)data);


                fsIn.Close();
                cs.Close();
                fsCrypt.Close();
            }
            catch
            {
                return false;
            }

            return true;
        }
        ///<summary>
        /// Steve Lydford - 12/05/2008.
        ///
        /// Decrypts a file using Rijndael algorithm.
        ///</summary>
        ///<param name="inputFile"></param>
        ///<param name="outputFile"></param>
        public static  bool DecryptFile(string inputFile, string outputFile,string password)
        {

                if(password=="")
                    password = @"myKey123";
                //string password = @"myKey123"; // Your Key Here

                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt,
                    RMCrypto.CreateDecryptor(key, key),
                    CryptoStreamMode.Read);

                FileStream fsOut = new FileStream(outputFile, FileMode.Create);

                int data;
                while ((data = cs.ReadByte()) != -1)
                    fsOut.WriteByte((byte)data);

                fsOut.Close();
                cs.Close();
                fsCrypt.Close();

                return true;

         
        }

    }
}
