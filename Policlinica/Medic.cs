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
         List<Persoana> pacienti = new List<Persoana>();

        public Medic(Persoana pers , string _Specializare) : base(pers.Nume, pers.Prenume, pers.age, pers.Gen, pers.nrTelefon, pers.email)
        {
            Specializare = _Specializare;
            int nrOperatiunil = 0;
        
        }
        public Medic(string _nume , string _prenume , int _age , char _gen , string _nrTelefon ,string _email, string _Specializare) : base(_nume,_prenume,_age,_gen,_nrTelefon , _email)
        {
            Specializare = _Specializare;

        }








        public static string GetDoctorType(int index)
        {
            Dictionary<int, string> doctorTypes = new Dictionary<int, string>()
        {
            { 1, "Medicină internă" },
            { 2,  "Pediatrie "},
            { 3,  "Chirurgie" },
            { 4,  "Anestezie" },
            { 5, "Medicina de urgenta" },
            { 6, "Neurologie" },
            { 7, "Obstetrica si ginecologie" },
            { 8, "Psihiatrie" },
            { 9, "Urologie" },
            { 10, "Dermatologie" },
            { 11, "Medicina de familie" },
            { 12, "Patologie" },
            { 13, "Radiologie" },
            { 14, "Imunologie" },
            { 15, "Ortopedie" },
            { 16, "Oftalmologie" },
            { 17, "Cardiologie" },
            { 18, "Otorinolaringologie" },
            { 19, "Kinetoterapie" },
            { 20, "Asistență medicală preventivă" },
            { 21, "Neurochirurgie" },
            { 22, "Medicina nucleara" },
            { 23, "Chirurgie plastică" },
            { 24, "Chirurgie vasculară" },
            { 25, "Reumatologie" },
            { 26, "Oncologie" },
            { 27, "Chirurgie cardiotoracică" },
            { 28, "Genetica medicala" },
            { 29, "Chirurgie colorectală" },
            { 30, "Chirurgie generală" },
            { 31, "Gastroenterologie" },
            { 32, "Hematologie" },
            { 33, "Geriatrie" },
            { 34, "Medicina de terapie intensiva" },
            { 35, "Medicina sportiva" },
            { 36, "Medicina somnului" },
            { 37, "Nefrologie" },
            { 38, "Endocrinologie" },
            { 39, "Medicina spitalicească" },
            { 40, "Sănătatea publică" },
            { 41, "Patologia criminalistică" },
            { 42, "Medicina muncii" },
            { 43, "Pneumologie" },
            { 44, "Anestezie pediatrică" },
            { 45, "Radiologie Diagnostică" },
            { 46, "Chirurgie pediatrică" },
            { 47, "Psihiatria copilului si adolescentului" },
            { 48, "Psihiatrie geriatrică" },
            { 49, "Psihiatrie criminalistică" },
            { 50, "Neuropatologie" },
            { 51, "Genomica" }
        };

            if (doctorTypes.ContainsKey(index))
            {
                return doctorTypes[index];
            }
            else
            {
                return "Invalid";
            }
        }




    }

    
}
