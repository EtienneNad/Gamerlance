using System;

namespace jeuDeLaVie
{
    public class JeuDeLaVie
    {
        public static void jeuDelaVie()
        {
            for (int l = 0; ; l++)
            {

                int[,] table = new int[10, 10];
                int[,] table2 = new int[10, 10];

                for (int i = 0; i < table.GetLength(0); i++)
                {
                    for (int j = 0; j < table.GetLength(1); j++)
                    {
                        table[i, j] = (new Random().Next(0, 2));
                    }
                }
            }
        }

        public void cycleSuivant()
        {

        }

        public override string ToString()
        {
            StringBuilder a = new StringBuilder();
            
            return null;
        }
    }
}

    

