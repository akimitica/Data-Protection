using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Security.Cryptography.Xml;

namespace DP_Project
{
    internal class FourSquare
    {
        FourSquare()
        {

        }

        public FourSquare(string pad)
        {
            this.pad = pad;
            this.alfabet = "abcdefghijklmnoprstuvwxyz";
        }

        private string pad;
        private string alfabet;
        private string prva_matrica = "";
        private string druga_matrica = "";

        public string Pad
        {
            get 
            {
                return this.pad;
            }
            set 
            {
                this.pad = value;
            }
        }

        public void GenerisiCypherMatrica(string keyword)
        {
            if (Regex.IsMatch(keyword, @"&[a-z]+ [a-]+$"))
            {
                string[] keywordSplit = keyword.Split(' ');

                foreach (char c in keywordSplit[0])
                {
                    if (!prva_matrica.Contains(c))
                    {
                        prva_matrica += c;
                    }
                }
                foreach (char c in keywordSplit[1])
                {
                    if (!druga_matrica.Contains(c))
                    {
                        druga_matrica += c;
                    }
                }

                foreach (char c in this.alfabet)
                {
                    if (!prva_matrica.Contains(c))
                    {
                        prva_matrica += c;
                    }
                }
                foreach (char c in this.alfabet)
                {
                    if (!druga_matrica.Contains(c))
                    {
                        druga_matrica += c;
                    }
                }
            }
            else GenerisiCypherMatrica("Neka validna rec");

            prva_matrica = prva_matrica.ToUpper();
            druga_matrica = druga_matrica.ToUpper();
        }



        public string Crypt(string source)
        {
            string input = "";
            string output = "";

            MatchCollection izdvojeno = Regex.Matches(source, @"[A-PR-Za-pr-z]+");
            foreach(Match el in izdvojeno)
            {
                input += el.Value;
            }

            input=input.ToLower();
            if (input.Length % 2 != 0)
            {
                input += "x";
            }
            GenerisiCypherMatrica(this.pad);

            for (int i = 0; i < input.Length; i += 2)
            {
                int prvo_slovo_index = alfabet.IndexOf(input[i]);
                int red_prvo_slovo = prvo_slovo_index / 5;
                int kolona_prvo_slovo = prvo_slovo_index % 5;

                int drugo_slovo_index = alfabet.IndexOf(input[i + 1]);
                int red_drugo_slovo = drugo_slovo_index / 5;
                int kolona_drugo_slovo = drugo_slovo_index % 5;

                output += prva_matrica[red_prvo_slovo * 5 + kolona_drugo_slovo];
                output += druga_matrica[red_drugo_slovo * 5 + kolona_prvo_slovo];
            }

            return output;
        }

        public string Decrypt(string source)
        {
            string output = "";
            string input = "";
            MatchCollection izdvojeno = Regex.Matches(source, @"[A-PR-Z]+");
            foreach(Match el in izdvojeno)
            {
                input += el.Value;
            }
            GenerisiCypherMatrica(this.pad);
            for (int i = 0; i < input.Length; i += 2) 
            {
                int prvo_slovo_index = prva_matrica.IndexOf(input[i]);
                int red_prvo_slovo = prvo_slovo_index / 5;
                int kolona_prvo_slovo = prvo_slovo_index % 5;

                int drugo_slovo_index = druga_matrica.IndexOf(input[i + 1]);
                int red_drugo_slovo = drugo_slovo_index / 5;
                int kolona_drugo_slovo = drugo_slovo_index % 5;

                output += alfabet[red_prvo_slovo * 5 + kolona_drugo_slovo];
                output += alfabet[red_drugo_slovo * 5 + kolona_prvo_slovo];
            }
            output = output.ToUpper();

            return output;
        }
    }
}
