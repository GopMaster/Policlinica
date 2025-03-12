using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Policlinica
{
    public class Persoana
    {

        public string Nume;
        public string Prenume;  
        public int age;
        public char Gen;
        public string nrTelefon;
        public string email;
        public string numeComplet { 
            get { return Nume + " " + Prenume; }
        } 

        public Persoana() {
            Nume = string.Empty;
            Prenume = string.Empty;
            age = 0;
            Gen = '?';
            nrTelefon = string.Empty;
        }
        public Persoana(string _nume , string _prenume, int _age, char _gen, string _nrTelefon , string _email)
        {
            Nume = _nume;
            Prenume =_prenume;
            this.age =_age;
            Gen = _gen;
            this.nrTelefon = _nrTelefon;
            email = _email;
        }
        public string InfoPers() {
            return $"Nume/Prenume:[{numeComplet ?? "Necunoscut"}] Varsta:[{age}]\n GEN:[{(Gen =='M' ? "Masculin" : "Feminim")}]\n NrTelefon:[{nrTelefon ?? "Necunoscut"}]\n email:[{email ?? "Necunoscut"}]  ";
        }



    }
}
