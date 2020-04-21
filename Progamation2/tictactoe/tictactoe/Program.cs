using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe
{
    class Program

    {
        static void Main(string[] args)
        {
            int mavaleur= maMethode();

            string[][] tab = new string[3][];


            tab[0] = new string[3] {"0","1","2"};
            tab[1] = new string[3] {"3","4","5"};
            tab[2] = new string[3] {"6","7","8"};
            for(int i=0;i<9;i++)
            { 

                Console.Write("╔" + "═" + "╦" + "═" + "╦" + "═" + "╗"); 
                Console.Write("\n");
                Console.Write("║" + tab[0][0]+ "║" + tab[0][1]+ "║" + tab[0][2]+ "║");
                Console.Write("\n");
                Console.Write("╠" + "═" + "╬" + "═" + "╬" + "═" + "╣");
                Console.Write("\n");
                Console.Write("║" + tab[1][0] + "║" + tab[1][1] + "║" + tab[1][2] + "║");
                Console.Write("\n");       
                Console.Write("╠" + "═" + "╬" + "═" + "╬" + "═" + "╣");
                Console.Write("\n");
                Console.Write("║" + tab[2][0] + "║" + tab[2][1] + "║" + tab[2][2] + "║");
                Console.Write("\n");
                Console.Write("╚" + "═" + "╩" + "═" + "╩" + "═" + "╝");
           

                Console.WriteLine("\n");
                Console.ReadLine();

                string variable = Console.ReadLine();
                ushort chiffre = ushort.Parse(variable);
                #region 1erePartie
                for (int j2 = 1; j2 <= 2; ++j2)
                {
                    char joueur1='x';
                    char joueur2 = 'o';

                //if joueur1=x joueur2=O)//
                int joueur =chiffre;
                    

                    if ( joueur + j2 == 0) {

                        tab[0][0] = "joueur"+j2;
                    }
                    else if (joueur1 == 1)
                    {

                    tab[0][1] = "X";
                    }
                    else if (joueur1 == 2)
                    {

                        tab[0][2] = "X";
                    }
                    else if (joueur1 == 3)
                    {

                    tab[1][0] = "X";
                    }
                    else if (joueur1 == 4)
                    {

                    tab[1][1] = "X";
                    }
                    else if (joueur1 == 5)
                    {

                        tab[1][2] = "X";
                    }
                    else if (joueur1 == 6)
                    {

                        tab[2][0] = "X";
                    }
                    else if (joueur1 == 7)
                    {

                    tab[2][1] = "X";
                    }
                    else if (joueur1 == 8)
                    {

                    tab[2][2] = "X";
                    }
                    #endregion
                }
                    
            }
            Console.ReadLine(); 
        }

        public static int maMethode()
        {
            //mon code va ici
            String maValeurDeRetour = "";


            return 0;
        }

    }
}
