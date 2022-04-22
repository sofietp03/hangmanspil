using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangman
{
    public class logisk
    {
        //metode til hele spillet 
        public static void hangmankode()
        {
            //ordliste
            List<string> Ordlist = new List<string>();
            {
                Ordlist.Add("stimulation");
                Ordlist.Add("appointment");
                Ordlist.Add("veil");
                Ordlist.Add("pleasant");
                Ordlist.Add("snuggle");
                Ordlist.Add("inject");
                Ordlist.Add("frame");
                Ordlist.Add("consultation");
                Ordlist.Add("bread");
                Ordlist.Add("crutch");
                Ordlist.Add("cancer");
                Ordlist.Add("shame");
                Ordlist.Add("beautiful");
                Ordlist.Add("twist");
                Ordlist.Add("theme");
                Ordlist.Add("trustee");
                Ordlist.Add("spokesperson");
                Ordlist.Add("tank");
                Ordlist.Add("utter");
                Ordlist.Add("awful");
            }

            //lave random ved navn rand og laver det til en ny random
            Random rand = new Random();

            int ordlistleng = rand.Next(0, Ordlist.Count - 1);

            //bogstavet bliver gjort til lille bogstav
            string valgtord = Ordlist[ordlistleng].ToLower();
            //udskriver hvor mange bogstaver ordet har
            Console.WriteLine("ordet har {0} bogstaver", valgtord.Length);
            //man har 6 forsøg
            int forsøg = 6;
            List<string> alleradegætted = new List<string>();
            string visord = "";
            //forsøg er støre end 0 og vis bogstav ikke er det samme som det valgte ord 
            while (forsøg > 0 && visord != valgtord)
            {
                //udskriver hvor mange forsøg man har
                Console.WriteLine("forsøg du har {0}", forsøg);
                //man skal skrive et bogstav 
                Console.WriteLine("skriv et bogstav");
                char[] input = Console.ReadLine().ToCharArray();

                string gæt = "";
                //input længden er større en 0 og input bliver lavet til string og i små bogstaver 
                if (input.Length > 0)
                {
                    gæt = input[0].ToString();
                    gæt = gæt.ToLower();
                }
                //putter allderadegætted i vaiable gæt 
                alleradegætted.Add(gæt);


                visord = "";

                string holdteskt = "";
                Console.Clear();
                //hvis bogstavet er i ordet udskriver dette
                if (valgtord.Contains(gæt))
                {
                    holdteskt = "{0} det bogstav er i ordet";
                }
                //udskriver dette nå bogstavet er forkeret
                else
                {
                    holdteskt = "{0} det bogstav er ikke i ordet";
                    //fjener forsøg
                    forsøg--;
                }


                Console.WriteLine(holdteskt, gæt);


                foreach (var bogstav in valgtord)
                {
                    if (alleradegætted.Contains(bogstav.ToString()))
                    {
                        holdteskt += bogstav;
                    }
                    else
                    {
                        holdteskt += "-";
                    }
                }


                Console.WriteLine(holdteskt);
                Console.WriteLine();


            }
            Console.Clear();
            //udskriver dette når du har tabt og skriver hvad ordet var 
            if (forsøg == 0)
            {
                Console.WriteLine("du løb tør for forsøg. tabte");
                Console.WriteLine("det valgte ord var: {0}", valgtord);

            }
            //når du har vundet 
            else
            {
                Console.WriteLine("du har vundet spillet");
            }
















        }










    }
}
