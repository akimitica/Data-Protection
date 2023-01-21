using DP_Project.Encr_Decr.CypherLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DP_Project.Encr_Decr.Mode

{
    public enum MODE
    {
        OneTimePad = 0,
        FourSquare = 1,
        XXTEA = 2

    };
    internal class OFB
    {
        private string IV;

        public OFB(){ IV = "1001001010010010"; }


        public string Crypt(string pad, MODE mode, string source)
        {
            string[] sourceSplit = source.Split(' ');
            byte[] key = Encoding.ASCII.GetBytes(pad);
            string result = String.Empty;
            int i = 0;
            byte[] pom = Encoding.ASCII.GetBytes(IV);

            while (sourceSplit[i] != null)
            {
                byte[] sourceSplitByte = Encoding.ASCII.GetBytes(sourceSplit[i]);
                switch(mode)
                {
                    case (MODE.OneTimePad):
                        pom = OneTimePad.Crypt(pom, key);
                        break;
                    case (MODE.FourSquare):
                        string b = Encoding.ASCII.GetString(pom);
                        pom = Encoding.ASCII.GetBytes(b);
                        break;
                    case (MODE.XXTEA):
                        pom = Encoding.ASCII.GetBytes(XXTEA.Encrypt(Encoding.ASCII.GetString(pom), Encoding.ASCII.GetString(key)));
                        break;
                }
                byte[] res = new byte[sourceSplit.Length];
                for (int j = 0; j < sourceSplit[i].Length; j++)
                {
                    res[j] = (byte)(pom[j] ^ sourceSplitByte[j]);
                }
                result = result + ' ' + Encoding.ASCII.GetString(res);
                i++;
            }
            return result;
        }


        public string Decrypt(string pad, MODE mode, string source)
        {
            string[] sourceSplit = source.Split(' ');
            byte[] key = Encoding.ASCII.GetBytes(pad);
            string result = String.Empty;
            int i = 0;
            byte[] pom = Encoding.ASCII.GetBytes(IV);

            while (sourceSplit[i] != null)
            {
                byte[] sourceSplitByte = Encoding.ASCII.GetBytes(sourceSplit[i]);
                switch (mode)
                {
                    case (MODE.OneTimePad):
                        OneTimePad otp = new OneTimePad();
                        pom = otp.Decrypt(pom, key);
                        break;
                    case (MODE.FourSquare):
                        string b = Encoding.ASCII.GetString(pom);
                        pom = Encoding.ASCII.GetBytes(b);
                        break;
                    case (MODE.XXTEA):
                        pom = Encoding.ASCII.GetBytes(XXTEA.Encrypt(Encoding.ASCII.GetString(pom), Encoding.ASCII.GetString(key)));
                        break;
                }
                byte[] res = new byte[sourceSplit.Length];
                for (int j = 0; j < sourceSplit[i].Length; j++)
                {
                    res[j] = (byte)(pom[j] ^ sourceSplitByte[j]);
                }
                result = result + ' ' + Encoding.ASCII.GetString(res);
                i++;
            }
            return result;
        }




        public byte[] Crypt(byte[] pad, MODE mode, byte[] source)
        {
            byte[][] sourceSplit = new byte[source.Length/5][];
            int i = 0;

            while (source[i] != null)
            {
                for (int j = 0; j < 5; j++)
                {
                    sourceSplit[i][j] = source[i + j];
                }
                i += 5;
            }

            byte[] res = new byte[sourceSplit.Length];
            i = 0;
            byte[] pom = Encoding.ASCII.GetBytes(IV);

            while (sourceSplit[i] != null)
            {
                switch (mode)
                {
                    case (MODE.OneTimePad):
                        pom = OneTimePad.Crypt(pom, pad);
                        break;
                    case (MODE.FourSquare):
                        string b = Encoding.ASCII.GetString(pom);
                        pom = Encoding.ASCII.GetBytes(b);
                        break;
                    case (MODE.XXTEA):
                        XXTEA xxtea= new XXTEA();
                        pom = xxtea.Encrypt(pom, pad);
                        break;
                }
                for (int j = 0; j < sourceSplit[i].Length; j++)
                {
                    res[i + j] = sourceSplit[i][j];
                }
                i++;
            }
            return res;
        }


        public byte[] Decrypt(byte[] pad, MODE mode, byte[] source)
        {
            byte[][] sourceSplit = new byte[source.Length / 5][];
            int i = 0;

            while (source[i] != null)
            {
                for (int j = 0; j < 5; j++)
                {
                    sourceSplit[i][j] = source[i + j];
                }
                i += 5;
            }

            byte[] res = new byte[sourceSplit.Length];
            i = 0;
            byte[] pom = Encoding.ASCII.GetBytes(IV);

            while (sourceSplit[i] != null)
            {
                switch (mode)
                {
                    case (MODE.OneTimePad):
                        OneTimePad otp = new OneTimePad(); 
                        pom = otp.Decrypt(pom, pad);
                        break;
                    case (MODE.FourSquare):
                        string b = Encoding.ASCII.GetString(pom);
                        pom = Encoding.ASCII.GetBytes(b);
                        break;
                    case (MODE.XXTEA):
                        XXTEA xxtea = new XXTEA();
                        pom = xxtea.Decrypt(pom, pad);
                        break;
                }
                for (int j = 0; j < sourceSplit[i].Length; j++)
                {
                    res[i + j] = sourceSplit[i][j];
                }
                i++;
            }
            return res;
        }
    }
}
