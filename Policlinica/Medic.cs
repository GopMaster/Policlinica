using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Policlinica
{
   public  class Medic : Persoana
    {

        string Specializare;
        int NrOperatiuni;

        
        public Medic(Persoana pers , string _Specializare) : base(pers.Nume, pers.Prenume, pers.age, pers.Gen, pers.nrTelefon, pers.email)
        {
            Specializare = _Specializare;
            int nrOperatiunil = 0;
        
        }


    }
}
