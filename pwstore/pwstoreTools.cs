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
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using System.IO;

namespace pwstore
{
    public static class pwstoreTools
    {
        /// <summary>
        /// Deserialise une liste de logins à partir d'un fichier xml
        /// le cryptage se fait à partir du hash
        /// </summary>
        /// <param name="hashpw"></param>
        /// <param name="path2file"></param>
        /// <returns></returns>
        public static BindingList<LogInfoStore> UnserializeList(string hashpw,string path2file)
        {
            BindingList<LogInfoStore> listinfo = new BindingList<LogInfoStore>();
 
            string xmlfileclear = Path.Combine(path2file , hashpw + "_clear.xml");
            string xmlfilecrypt = Path.Combine(path2file ,hashpw + ".xml");
            string pwencrypt = hashpw.Substring(0, 8);

            if (!System.IO.File.Exists(xmlfilecrypt))
                return null;

            cryptutils.DecryptFile(xmlfilecrypt, xmlfileclear, pwencrypt);


            XmlSerializer serializer = new XmlSerializer(listinfo.GetType());

            StreamReader reader = new StreamReader(xmlfileclear);
            object deserialized = serializer.Deserialize(reader.BaseStream);
            listinfo = (BindingList<LogInfoStore>)deserialized;
            reader.Close();

            System.IO.File.Delete(xmlfileclear);

            return listinfo;
        }

        /// <summary>
        /// Serialise une liste de logins dans un fichier xml
        /// le cryptage se fait à partir du hash
        /// </summary>
        /// <param name="listinfo"></param>
        /// <param name="hashpw"></param>
        /// <param name="path2file"></param>
        /// <returns></returns>
        public static bool SerializeList(BindingList<LogInfoStore> listinfo,string hashpw, string path2file)
        {
            string xmlfileclear = Path.Combine(path2file, hashpw + "_clear.xml");
            string xmlfilecrypt = Path.Combine(path2file, hashpw + ".xml");
            string pwencrypt = hashpw.Substring(0, 8);

            if (hashpw == "" || listinfo == null || listinfo.Count == 0)
                return false;

            XmlSerializer serializer = new XmlSerializer(listinfo.GetType());
            StreamWriter writer = new StreamWriter(xmlfileclear);
            serializer.Serialize(writer.BaseStream, listinfo);
            writer.Close();

            cryptutils.EncryptFile(xmlfileclear, xmlfilecrypt, pwencrypt);

            System.IO.File.Delete(xmlfileclear);
             
            return true;
        }

    }
}
