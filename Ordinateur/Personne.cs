using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasseExercice1
{
    class Personne
    {
        private string nom;
        private string prenom;

        private List<Ordinateur> mesOrdinateurs;

        public Personne(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;

            this.mesOrdinateurs = new List<Ordinateur>();
        }
    }

}
