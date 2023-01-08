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

        OFB(){ IV = "1001001010010010"; }


        public string Crypt(string pad, MODE mode, string source, OneTimePad oneTimePad)
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
                        pom = Encoding.ASCII.GetBytes(FourSquare.Crypt(Encoding.ASCII.GetString(pom)));
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

        public string Decrypt()
        {
            return String.Empty;
        }
    }
}
