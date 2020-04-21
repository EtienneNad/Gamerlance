using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using PersonneClass;
using System.Collections;

namespace ProjetsExempleP2
{
    public class Classe
    {
        private ArrayList membres = new ArrayList(); 
        
        public Classe(ArrayList membres)
        {
            Personne p = new Personne();
            object z=p;
            Personne x = membres[0] as Personne;
            
        } 
    }
}
