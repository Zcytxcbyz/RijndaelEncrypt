using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace RijndaelEncryption
{
    class Aes
    {
        public bool Encrypt(string filename,string key,string reaultfilename)
        {
            try
            {
                Rijndael aes = Rijndael.Create();
                byte[] data = Readfile(filename);
                byte[] bkey = new Byte[32];
                Array.Copy(Encoding.UTF8.GetBytes(key.PadRight(bkey.Length)), bkey, bkey.Length);
                byte[] bvector = new Byte[16];
                Array.Copy(Encoding.UTF8.GetBytes(key.PadRight(bvector.Length)), bvector, bvector.Length);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(bkey, bvector), CryptoStreamMode.Write);
                cs.Write(data, 0, data.Length);
                cs.FlushFinalBlock();
                byte[] result = ms.ToArray();
                Writefile(result, reaultfilename);
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public bool Decrypt(string filename, string key,string reaultfilename)
        {
            try
            {
                Rijndael aes = Rijndael.Create();
                byte[] data = Readfile(filename);
                byte[] bkey = new Byte[32];
                Array.Copy(Encoding.UTF8.GetBytes(key.PadRight(bkey.Length)), bkey, bkey.Length);
                byte[] bvector = new Byte[16];
                Array.Copy(Encoding.UTF8.GetBytes(key.PadRight(bvector.Length)), bvector, bvector.Length);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(bkey, bvector), CryptoStreamMode.Write);
                cs.Write(data, 0, data.Length);
                cs.FlushFinalBlock();
                byte[] result = ms.ToArray();
                Writefile(result, reaultfilename);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        private byte[] Readfile(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            byte[] data = new byte[fs.Length];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = (byte)fs.ReadByte();
            }
            fs.Close();
            return data;
        }
        private void Writefile(byte[] data,string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            for (int i = 0; i < data.Length; i++)
            {
                fs.WriteByte(data[i]);
            }
            fs.Close();
        }
    }
}
