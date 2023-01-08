using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Project
{
    internal class XXTEA
    {
        private static readonly UTF8Encoding utf8 = new UTF8Encoding();
        private const UInt32 delta = 0x9E3779B9;

        private static UInt32 MX(UInt32 sum, UInt32 y, UInt32 z, Int32 p, UInt32 e, UInt32[] k)
        {
            return (z >> 5 ^ y << 2) + (y >> 3 ^ z << 4) ^ (sum ^ y) + (k[p & 3 ^ e] ^ z);
        }

        public XXTEA() { }

        public static string Encrypt(string data, string key)
        {
            byte[] dataBytes = utf8.GetBytes(data);
            byte[] keyBytesIn = utf8.GetBytes(key);

            if (dataBytes.Length == 0)
            {
                return "";
            }

            byte[] keyBytes = new byte[16];
            if (keyBytes.Length < 16)
            {
                keyBytesIn.CopyTo(keyBytes, 0);
            }
            else
            {
                Array.Copy(keyBytesIn, 0, keyBytes, 0, keyBytesIn.Length);
            }

            int lengthData = dataBytes.Length;
            int dn = ((lengthData / 4) == 0) ? lengthData / 4 : (lengthData / 4) + 1;

            UInt32[] data32 = new uint[dn];
            UInt32[] key32 = new uint[4];

            for (int i = 0; i < dn * 4 - 4; i += 4)
            {
                data32[i / 4] = (UInt32)dataBytes[i] << 12 | (UInt32)dataBytes[i + 1] << 8 | (UInt32)dataBytes[i + 2] << 4 | (UInt32)dataBytes[i + 3];
            }

            for (int i = 0; i < 12; i += 4)
            {
                key32[i / 4] = (UInt32)keyBytes[i] << 12 | (UInt32)keyBytes[i + 1] << 8 | (UInt32)keyBytes[i + 2] << 4 | (UInt32)keyBytes[i + 3];
            }


            //enkripcija uint32 podataka XXTEA algoritmom



            Int32 n = data32.Length - 1;
            if (n < 1)
            {
                return "";
            }
            UInt32 z = data32[n], y, sum = 0, e;
            Int32 p, q = 6 + 52 / (n + 1);
            unchecked
            {
                while (0 < q--)
                {
                    sum += delta;
                    e = sum >> 2 & 3;
                    for (p = 0; p < n; p++)
                    {
                        y = data32[p + 1];
                        z = data32[p] += MX(sum, y, z, p, e, key32);
                    }
                    y = data32[0];
                    z = data32[n] += MX(sum, y, z, p, e, key32);
                }
            }



            //vracanje u niz bajtova


            byte[] retByte = new byte[data32.Length * 4];

            for (int i = 0; i < retByte.Length; i += 4)
            {
                retByte[i] = (byte)(data32[i / 4] >> 12);
                retByte[i + 1] = (byte)(data32[i / 4] >> 8);
                retByte[i + 2] = (byte)(data32[i / 4] >> 4);
                retByte[i + 3] = (byte)(data32[i / 4]);

            }

            //pretvaranje niza bajtova u 64 string na kraju

            return Convert.ToBase64String(retByte);
        }

        public string Decrypt(string data, string key)
        {


            //Convert.FromBase64String(data);
            //iz stringa u niz bajtova
            byte[] dataBytes = Convert.FromBase64String(data);
            byte[] keyBytesIn = utf8.GetBytes(key);

            if (dataBytes.Length == 0)
            {
                return "";
            }

            //za slucaj da prosledjeni kljuc nije u odgovarajucem obliku (duzina manja od 16)
            byte[] keyBytes = new byte[16];
            if (keyBytes.Length < 16)
            {
                keyBytesIn.CopyTo(keyBytes, 0);
            }
            else
            {
                Array.Copy(keyBytesIn, 0, keyBytes, 0, keyBytesIn.Length);
            }


            //iz niza bajtova u niz grupa od po 4 bajtova (unsigned int 32)

            int lengthData = dataBytes.Length;

            //ako duzina niza nije deljiva sa 4 onda se deli sa 4 i na to dodaje jos 4 bajta
            int dn = ((lengthData / 4) == 0) ? lengthData / 4 : (lengthData / 4) + 1;


            UInt32[] data32 = new UInt32[dn];

            //kljuc je 16-bitni
            UInt32[] key32 = new UInt32[4];



            for (int i = 0; i < dn * 4 - 4; i += 4)
            {
                //potrebno je da 4 bajta koja smestamo u jedan UInt32 prosirimo (kastujemo u uint32) i svakom dodelimo poziciju:
                //prvi bajt na prvom mestu drugi na drugom itd... shiftovanjem ( << ) i logickim OR
                //1011 (Uint32)
                //0000 0000 0000 1011 << 12
                //1011 0000 0000 0000
                //.....
                data32[i / 4] = (UInt32)dataBytes[i] << 12 | (UInt32)dataBytes[i + 1] << 8 | (UInt32)dataBytes[i + 2] << 4 | (UInt32)dataBytes[i + 3];
            }
            for (int i = 0; i < 12; i += 4)
            {
                key32[i / 4] = (UInt32)keyBytes[i] << 12 | (UInt32)keyBytes[i + 1] << 8 | (UInt32)keyBytes[i + 2] << 4 | (UInt32)keyBytes[i + 3];
            }


            Int32 n = data32.Length - 1;
            if (n < 1)
            {
                return "";
            }
            UInt32 z, y = data32[0], sum, e;
            Int32 p, q = 6 + 52 / (n + 1);
            unchecked
            {
                sum = (UInt32)(q * delta);
                while (sum != 0)
                {
                    e = sum >> 2 & 3;
                    for (p = n; p > 0; p--)
                    {
                        z = data32[p - 1];
                        y = data32[p] -= MX(sum, y, z, p, e, key32);
                    }
                    z = data32[n];
                    y = data32[0] -= MX(sum, y, z, p, e, key32);
                    sum -= delta;
                }
            }


            byte[] retByte = new byte[data32.Length * 4];

            for (int i = 0; i < retByte.Length; i += 4)
            {
                retByte[i] = (byte)(data32[i / 4] >> 12);
                retByte[i + 1] = (byte)(data32[i / 4] >> 8);
                retByte[i + 2] = (byte)(data32[i / 4] >> 4);
                retByte[i + 3] = (byte)(data32[i / 4]);

            }

            //pretvaranje niza bajtova u 64 string na kraju
            return utf8.GetString(retByte);
        }




        ///binarno
        ///
        public byte[] Encrypt(byte[] data, byte[] key)
        {

            //iz stringa u niz bajtova
            byte[] dataBytes = data;
            byte[] keyBytesIn = key;

            if (dataBytes.Length == 0)
            {
                return null;
            }

            //za slucaj da prosledjeni kljuc nije u odgovarajucem obliku (duzina manja od 16)
            byte[] keyBytes = new byte[16];
            if (keyBytes.Length < 16)
            {
                keyBytesIn.CopyTo(keyBytes, 0);
            }
            else
            {
                Array.Copy(keyBytesIn, 0, keyBytes, 0, keyBytesIn.Length);
            }


            //iz niza bajtova u niz grupa od po 4 bajtova (unsigned int 32)

            int lengthData = dataBytes.Length;

            //ako duzina niza nije deljiva sa 4 onda se deli sa 4 i na to dodaje jos 4 bajta
            int dn = ((lengthData / 4) == 0) ? lengthData / 4 : (lengthData / 4) + 1;


            UInt32[] data32 = new UInt32[dn];

            //kljuc je 16-bitni
            UInt32[] key32 = new UInt32[4];



            for (int i = 0; i < dn * 4 - 4; i += 4)
            {
                //potrebno je da 4 bajta koja smestamo u jedan UInt32 prosirimo (kastujemo u uint32) i svakom dodelimo poziciju:
                //prvi bajt na prvom mestu drugi na drugom itd... shiftovanjem ( << ) i logickim OR
                //1011 (Uint32)
                //0000 0000 0000 1011 << 12
                //1011 0000 0000 0000
                //.....
                data32[i / 4] = (UInt32)dataBytes[i] << 12 | (UInt32)dataBytes[i + 1] << 8 | (UInt32)dataBytes[i + 2] << 4 | (UInt32)dataBytes[i + 3];
            }
            for (int i = 0; i < 12; i += 4)
            {
                key32[i / 4] = (UInt32)keyBytes[i] << 12 | (UInt32)keyBytes[i + 1] << 8 | (UInt32)keyBytes[i + 2] << 4 | (UInt32)keyBytes[i + 3];
            }



            //enkripcija uint32 podataka XXTEA algoritmom



            Int32 n = data32.Length - 1;
            if (n < 1)
            {
                return null;
            }
            UInt32 z = data32[n], y, sum = 0, e;
            Int32 p, q = 6 + 52 / (n + 1);
            unchecked
            {
                while (0 < q--)
                {
                    sum += delta;
                    e = sum >> 2 & 3;
                    for (p = 0; p < n; p++)
                    {
                        y = data32[p + 1];
                        z = data32[p] += MX(sum, y, z, p, e, key32);
                    }
                    y = data32[0];
                    z = data32[n] += MX(sum, y, z, p, e, key32);
                }
            }



            //vracanje u niz bajtova


            byte[] retByte = new byte[data32.Length * 4];

            for (int i = 0; i < retByte.Length; i += 4)
            {
                retByte[i] = (byte)(data32[i / 4] >> 12);
                retByte[i + 1] = (byte)(data32[i / 4] >> 8);
                retByte[i + 2] = (byte)(data32[i / 4] >> 4);
                retByte[i + 3] = (byte)(data32[i / 4]);

            }

            //pretvaranje niza bajtova u 64 string na kraju

            return retByte;

        }


        public byte[] Decrypt(byte[] data, byte[] key)
        {


            //Convert.FromBase64String(data);
            //iz stringa u niz bajtova
            byte[] dataBytes = data;
            byte[] keyBytesIn = key;

            if (dataBytes.Length == 0)
            {
                return null;
            }

            //za slucaj da prosledjeni kljuc nije u odgovarajucem obliku (duzina manja od 16)
            byte[] keyBytes = new byte[16];
            if (keyBytes.Length < 16)
            {
                keyBytesIn.CopyTo(keyBytes, 0);
            }
            else
            {
                Array.Copy(keyBytesIn, 0, keyBytes, 0, keyBytesIn.Length);
            }


            //iz niza bajtova u niz grupa od po 4 bajtova (unsigned int 32)

            int lengthData = dataBytes.Length;

            //ako duzina niza nije deljiva sa 4 onda se deli sa 4 i na to dodaje jos 4 bajta
            int dn = ((lengthData / 4) == 0) ? lengthData / 4 : (lengthData / 4) + 1;


            UInt32[] data32 = new UInt32[dn];

            //kljuc je 16-bitni
            UInt32[] key32 = new UInt32[4];



            for (int i = 0; i < dn * 4 - 4; i += 4)
            {
                //potrebno je da 4 bajta koja smestamo u jedan UInt32 prosirimo (kastujemo u uint32) i svakom dodelimo poziciju:
                //prvi bajt na prvom mestu drugi na drugom itd... shiftovanjem ( << ) i logickim OR
                //1011 (Uint32)
                //0000 0000 0000 1011 << 12
                //1011 0000 0000 0000
                //.....
                data32[i / 4] = (UInt32)dataBytes[i] << 12 | (UInt32)dataBytes[i + 1] << 8 | (UInt32)dataBytes[i + 2] << 4 | (UInt32)dataBytes[i + 3];
            }
            for (int i = 0; i < 12; i += 4)
            {
                key32[i / 4] = (UInt32)keyBytes[i] << 12 | (UInt32)keyBytes[i + 1] << 8 | (UInt32)keyBytes[i + 2] << 4 | (UInt32)keyBytes[i + 3];
            }


            Int32 n = data32.Length - 1;
            if (n < 1)
            {
                return null;
            }
            UInt32 z, y = data32[0], sum, e;
            Int32 p, q = 6 + 52 / (n + 1);
            unchecked
            {
                sum = (UInt32)(q * delta);
                while (sum != 0)
                {
                    e = sum >> 2 & 3;
                    for (p = n; p > 0; p--)
                    {
                        z = data32[p - 1];
                        y = data32[p] -= MX(sum, y, z, p, e, key32);
                    }
                    z = data32[n];
                    y = data32[0] -= MX(sum, y, z, p, e, key32);
                    sum -= delta;
                }
            }


            byte[] retByte = new byte[data32.Length * 4];

            for (int i = 0; i < retByte.Length; i += 4)
            {
                retByte[i] = (byte)(data32[i / 4] >> 12);
                retByte[i + 1] = (byte)(data32[i / 4] >> 8);
                retByte[i + 2] = (byte)(data32[i / 4] >> 4);
                retByte[i + 3] = (byte)(data32[i / 4]);

            }

            return retByte;
        }
    }
}