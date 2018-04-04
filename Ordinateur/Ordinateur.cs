using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasseExercice1
{
    class Ordinateur
    {
        private string nom;
        private int puissance;
        private int tailleMemoire;

        private Processus processus;

        public Ordinateur(string nom, int puissance, int tailleMemoire, Processus unProcessus)
        {
            this.nom = nom;
            this.puissance = puissance;
            this.tailleMemoire = tailleMemoire;
            this.processus = unProcessus;
        }

    }
}
