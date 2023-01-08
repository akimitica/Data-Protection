using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DP_Project
{
    internal class OneTimePad
    {
        private string pad;
        private DataTable dictionary;
        public string Pad
        {
            get
            {
                return pad;
            }
            set
            {
                this.pad = value;
            }
        }

        public DataTable Dictionary
        {
            get
            {
                return dictionary;
            }
            set
            {
                this.dictionary = value;
            }
        }
        OneTimePad() { }

        OneTimePad(string oneTimePad, DataTable dict)
        {
            this.pad = oneTimePad;
            this.dictionary = dict;
        }



        public string Crypt(string source, string pad)
        {
            byte[] sourceByteArr = Encoding.ASCII.GetBytes(source);
            byte[] key = Encoding.ASCII.GetBytes(pad);
            byte[] result = new byte[sourceByteArr.Length];

            for (int i = 0; i < source.Length; i++)
            {
                result[i] = (byte)(sourceByteArr[i]^key[0]);
                Array.Copy(key, 1, key, 0, key.Length - 1);
                key[key.Length - 1] = (byte)(key[2% key.Length] ^ key[5 % key.Length]);
            }

            return Encoding.ASCII.GetString(result);
        }

        public static byte[] Crypt(byte[] source, byte[] pad)
        {
			byte[] key = pad;
			byte[] result = new byte[source.Length];


			for (int i = 0; i < source.Length; i++)
			{
				result[i] = (byte)(source[i] ^ key[0]);
                Array.Copy(key, 1, key, 0, key.Length - 1);
				key[key.Length - 1] = (byte)(key[2 % key.Length] ^ key[5 % key.Length]);
			}

			return result;

        }

        public string Decrypt(string source, string pad)
        {
            byte[] sourceByteArr = Encoding.ASCII.GetBytes(source);
            byte[] result = new byte[sourceByteArr.Length];
            byte[] key = Encoding.ASCII.GetBytes(pad);

            for (int i = 0; i < source.Length; i++)
            {
                result[i] = (byte)(sourceByteArr[i] ^ key[0]);
                Array.Copy(key, 1, key, 0, key.Length - 1);
                key[key.Length - 1] = (byte)(key[2 % key.Length] ^ key[5% key.Length]);
            }

            return Encoding.ASCII.GetString(result);
        }

        public byte[] Decrypt(byte[] source, byte[] pad)
        {
			byte[] bitRez = new byte[source.Length];
			byte[] key = pad;
			for (int i = 0; i < source.Length; i++)
			{
				bitRez[i] = (byte)(source[i] ^ key[0]);
				Array.Copy(key, 1, key, 0, key.Length - 1);
				key[key.Length - 1] = (byte)(key[2 % key.Length] ^ key[5 % key.Length]);

			}
			
			return bitRez;
        }
    }
}
