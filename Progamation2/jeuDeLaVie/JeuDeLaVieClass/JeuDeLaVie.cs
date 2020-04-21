using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
   
namespace jeuDeLaVie
{
    public class JeuDeLaVieTable
    {
        int tableauNouveau = 0;
        int tableauVieux = 1;
        int[,,] tableaux;
        int tailleX = 45;
        int tailleY = 45;

        public JeuDeLaVieTable()
        {
            tableaux = new int[tailleX, tailleY, 2];
            Random r = new Random();

            for (int y = 0;y < tailleY; y++)
            {
                for (int x = 0; x < tailleX; x++)
                {
                    tableaux[y, x, tableauNouveau] = (r.NextDouble() < 0.2 ? 1 : -1);
                }
            }
        }

        public void cycleSuivant()
        {
            if (tableauNouveau == 0)
            {
                tableauNouveau = 1;
            }
            else
            {
                tableauNouveau = 0;
            }

            if (tableauVieux == 0)
            {
                tableauVieux = 1;
            }
            else
            {
                tableauVieux = 0;
            }

            for (int y = 0; y < tailleY; y++)
            {
                for (int x = 0; x < tailleX; x++)
                {
                    int summary=0;
                    if(y > 0)
                    {
                       if(tableaux[y-1, x, tableauVieux] == 1)
                        {
                            summary++;
                        }
                        if (x > 0)
                        {
                            if (tableaux[y - 1, x-1, tableauVieux] == 1)
                            {
                                summary++;
                            }
                        }
                        if (x < tailleX - 1)
                        {
                            if (tableaux[y - 1, x + 1, tableauVieux] == 1)
                            {
                                summary++;
                            }
                        }
                    }
                    if (y < tailleY -1)
                    {
                        if (tableaux[y + 1, x, tableauVieux] == 1)
                        {
                            summary++;
                        }
                        if (x > 0)
                        {
                            if (tableaux[y + 1, x - 1, tableauVieux] == 1)
                            {
                                summary++;
                            }
                        }
                        if (x < tailleX - 1)
                        {
                            if (tableaux[y +1, x + 1, tableauVieux] == 1)
                            {
                                summary++;
                            }
                        }
                    }
                    if (x > 0)
                    {
                        if (tableaux[y , x - 1, tableauVieux] == 1)
                        {
                            summary++;
                        }
                    }
                    if (x < tailleX -1)
                    {
                        if (tableaux[y, x +1, tableauVieux] == 1)
                        {
                            summary++;
                        }
                    }

                    if (summary == 2)
                    {
                        tableaux[y, x, tableauNouveau] = tableaux[y, x, tableauVieux];
                    }
                    else if (summary < 2)
                    {
                        tableaux[y, x, tableauNouveau] = -1;
                    }
                    else if (summary > 3)
                    {
                        tableaux[y, x, tableauNouveau] = -1;
                    }
                    else if (summary == 3)
                    {
                        tableaux[y, x, tableauNouveau] = +1;
                         

                    }
                }
            }
        }
        public override string ToString()
        {
            StringBuilder tab = new StringBuilder();
             
            for (int y = 0; y < tailleY; y++)
            {
                
                for (int x = 0; x < tailleX; x++)
                {
                    if (tableaux[x, y, tableauNouveau] == 1)
                    {
                        tab.Append('*');

                    }

                    else
                    {
                        tab.Append(' ');
                    }
                    
                }
                tab.Append(Environment.NewLine);
            }
           
            return tab.ToString();
        }
    }
}