using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasseExercice1
{
    class Processus
    {
        private int id;

        private File file;

        public Processus(int id, File uneFile)
        {
            this.id = id;
            this.file = uneFile;
        }
    }
}
