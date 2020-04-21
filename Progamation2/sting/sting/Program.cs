using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sting
{
    class Program
    {
        static void Main(string[] args)
        {

            string variable = Console.ReadLine();
            ushort chiffre = ushort.Parse(variable);

            Console.WriteLine(FapriquerCarre(chiffre));
            Console.WriteLine(FAbriquerTriangle(chiffre));
            Console.WriteLine(FAbriquerTriangle2(chiffre));
            Console.WriteLine(FAbriquerTriangle3(chiffre));
            Console.WriteLine(FAbriquerTriangle4(chiffre));
            Console.WriteLine(FAbriquerlozange(chiffre));
            Console.WriteLine(FAbriquerlozange2(chiffre));
            Console.ReadKey();

        }



        public static string FapriquerCarre(ushort chiffre)
        {
            Console.Write("carré");
            Console.WriteLine("\n");
            StringBuilder sb = new StringBuilder();
            int a = 10;
            for (int i = 0; i < chiffre; i++)
            {
                for (int k = 0; k < chiffre; k++)
                {
                    sb.Append("*");
                }
                a++;
                sb.Append("\n");
            }
            sb.AppendLine("");
            return sb.ToString();
        }


        public static string FAbriquerTriangle(ushort chiffre)

        {
            Console.Write("triangle");
            Console.WriteLine("\n");
            StringBuilder sd = new StringBuilder();
            int val2 = 1;
            int d = val2;
            int val = chiffre;
            int c = val;
            for (int i = 0; i < val; i++)
            {
                for (int v = 0; v < d; v++)
                {
                    sd.Append(" ");
                }
                d++;

                for (int k = 0; k < c; k++)
                {
                    sd.Append("*");
                }
                c--;

                sd.AppendLine("");

            }

            return sd.ToString();
        }

        public static string FAbriquerTriangle2(ushort chiffre)

        {
            Console.Write("triangle2");
            Console.WriteLine("\n");

            {StringBuilder sc = new StringBuilder();

                int val5 = chiffre;
                int e = val5;
                int val6 = 1;
                int f = val6;

                for (int i = 0; i < val5; i++)
                {
                    for (int v = 0; v < e; v++)
                    {
                        sc.Append(" ");
                    }
                    e--;
                    for (int k = 0; k < f; k++)
                    {
                        sc.Append("*");
                    }
                    f++;
                    sc.AppendLine("");
                }

                return sc.ToString();
            }

        }
        public static string FAbriquerTriangle3(ushort chiffre)
        {
            Console.Write("triangle3");
            Console.WriteLine("\n");
            StringBuilder se = new StringBuilder();
            int h = chiffre;

            int g = 1;

            for (int i = 0; i < chiffre; i++)
            {
                for (int v = 0; v < g; v++)
                {
                    se.Append("*");
                }
                h--;

                for (int k = 0; k < h; k++)
                {
                    se.Append("");
                }
                g++;

                se.AppendLine("");

            }

            return se.ToString();
        }
        public static string FAbriquerTriangle4(ushort chiffre)
        {
            Console.Write("triangle4");
            Console.WriteLine("\n");
            StringBuilder sf = new StringBuilder();

            int h = chiffre;



            for (int i = 0; i < chiffre; i++)
            {


                for (int k = 0; k < h; k++)
                {
                    sf.Append("*");
                }
                h--;

                sf.AppendLine("");

            }

            return sf.ToString();

        }

        public static string FAbriquerlozange(ushort chiffre)
        {
            Console.Write("lozange");
            Console.WriteLine("\n");

            StringBuilder sg = new StringBuilder();
            int a = chiffre;

            int b = 1;

            for (int i = 0; i < chiffre; i++)
            {
                for (int v = 1; v < b; v++)
                {
                    sg.Append(" *");
                }
                a--;

                for (int k = 0; k < a; k++)
                {
                    sg.Append(" ");
                }
                b++;

                sg.AppendLine("");

            }

            int h = chiffre;


            for (int j = 0; j < chiffre; j++)
            {


                for (int l = 0; l < h; l++)
                {
                    sg.Append(" *");
                }
                h--;

                sg.AppendLine("");

            }

            return sg.ToString();
        }


        public static string FAbriquerlozange2(ushort chiffre)
        {
            Console.Write("lozange2");
            Console.WriteLine("\n");
            StringBuilder se = new StringBuilder();


            int val5 = chiffre;
            int e = val5;
            int val6 = 1;
            int f = val6;

            for (int i = 0; i < val5; i++)
            {
                for (int v = 0; v < e; v++)
                {
                    se.Append(" ");
                }
                e--;
                for (int k = 0; k < f; k++)
                {
                    se.Append("* ");
                }
                
                f++ ;
                
                se.AppendLine("");
            }

            int val2 = 1;
            int d = val2;
            int val = chiffre;
            int c = val;

            for (int i = 1; i < val; i++)
            {
                for (int v = 0; v < d; v++)
                {
                    se.Append(" ");
                }
                d++;

                for (int k = 1; k < c; k++)
                {
                    se.Append(" *");
                }
                c--;

                se.AppendLine(" ");
            }
            return se.ToString();

        }
    }
}