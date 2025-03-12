using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Policlinica
{
    public class Program
    {

        List<Medic> medici = new List<Medic>();
        static void Main(string[] args)
        {
            char CHR;
            while (true) {

                Console.Clear();
               MENU();
             CHR = Console.ReadKey().KeyChar;
                switch (CHR) {

                    case '1':
                        CitirePacientTastatura();
                        break;
                    case '2':
                        CitireMedicTastatura();
                        break;
                    case '3':
                        CitirePacientTastatura();
                        break;
                    case '4':
                        CitirePacientTastatura();
                        break;
                    case '5':
                        CitirePacientTastatura();
                        break;


                    default:
                        Console.WriteLine("Nu se cunoaste operatia");
                        break;
                
                
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(); // Pauses the console until any key is pressed
                
            }


        }
        public static  bool FunctieValidareText(string sample, string RegexValidation) {
            if (string.IsNullOrEmpty(sample)) return false;
            return Regex.IsMatch(sample, RegexValidation);
        
        }
        public static void MENU() {
            Console.WriteLine("1.Citire Pacient de la tastatură");
            Console.WriteLine("2. Adauga Medic de la tastatura");

        }
        public static Persoana CitirePacientTastatura() {


            Console.WriteLine("Introduceti Numele Pacientului: ");
            string nume;
            do
            {
               nume = Console.ReadLine();
            } while (FunctieValidareText(nume, @"^[A-Za-z]+$") == false);

            Console.WriteLine("Introduceti Prenumele Pacientului: ");
            string prenume;
            do
            {
                 prenume  = Console.ReadLine();
            } while (FunctieValidareText(prenume , @"^[A-Za-z]+$") == false);

            Console.WriteLine("Introduceti Varsta Pacientului: ");
            string varsta;
            do
            {
                varsta = Console.ReadLine();



            } while (FunctieValidareText(varsta, @"^(120|1[01][0-9]|[1-9]?[0-9])$") == false);

            Console.WriteLine("Introduceti Genul Pacientului: M - Masculin F - Feminin");
                char gen;
            bool isValid = false;
                do
            {
                gen = Console.ReadLine()[0];
                if (gen == 'F' || gen == 'M')
                {
                    isValid = true;
                }
                else
                    isValid = false ;
            } while (isValid == false);

            Console.WriteLine("Introduceti Emailul  Pacientului: ");
            string email;
                do {
                    email = Console.ReadLine();
            } while (FunctieValidareText(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$") == false);

            Console.WriteLine("Introduceti NrTelefon al  Pacientului: ");
            string nrTelefon;
            do
            {
                nrTelefon = Console.ReadLine();
            } while (FunctieValidareText(nrTelefon, @"^(072|073|074|075|076|077|078)\d{7}$") == false);
            Int32.TryParse(varsta, out int age);
            return new Persoana(nume, prenume, age, gen, nrTelefon, email);
         

        }

        public static Medic CitireMedicTastatura()
        {


            Console.WriteLine("Introduceti Numele Medic: ");
            string nume;
            do
            {
              nume = Console.ReadLine();
            } while (FunctieValidareText(nume, @"^[A-Za-z]+$") == false);

            Console.WriteLine("Introduceti Prenumele Medic: ");
            string prenume;
            do
            {
                prenume = Console.ReadLine();
            } while (FunctieValidareText(prenume, @"^[A-Za-z]+$") == false);

            Console.WriteLine("Introduceti Varsta Medic: ");
            string varsta;
            do
            {
                varsta = Console.ReadLine();



            } while (FunctieValidareText(varsta, @"^(120|1[01][0-9]|[1-9]?[0-9])$") == false);

            Console.WriteLine("Introduceti Genul Medic: M - Masculin F - Feminin");
            char gen;
            bool isValid = false;
            do
            {
                gen = Console.ReadLine()[0];
                if (gen == 'F' || gen == 'M')
                {
                    isValid = true;
                }
                else
                    isValid = false;
            } while (isValid == false);

            Console.WriteLine("Introduceti Emailul  Medicului: ");
            string email;
            do
            {
                email = Console.ReadLine();
            } while (FunctieValidareText(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$") == false);

            Console.WriteLine("Introduceti NrTelefon al  Medicului: ");
            string nrTelefon;
            do
            {
                nrTelefon = Console.ReadLine();
            } while (FunctieValidareText(nrTelefon, @"^(072|073|074|075|076|077|078)\d{7}$") == false);
            Int32.TryParse(varsta, out int age);
            
            Console.Clear();
            PrintMedicTypes();
            Console.WriteLine("Introduceti specializarea medicului");
            string specializare;
            do {
                 Int32.TryParse(Console.ReadLine(), out int num);
                specializare  = GetDoctorType(num);



            } while (GetDoctorType(num) == "Invalid");
            return new Medic(nume,  prenume,age, gen,nrTelefon,email,specializare);


        }
        public static void PrintMedicTypes() {
            Console.WriteLine("1.\tMedicină internă\r\n2.\tPediatrie\r\n3.\tChirurgie\r\n4.\tAnestezie\r\n5.\tMedicina de urgenta\r\n6.\tNeurologie\r\n7.\tObstetrica si ginecologie\r\n8.\tPsihiatrie\r\n9.\tUrologie\r\n10.\tDermatologie\r\n11.\tMedicina de familie\r\n12.\tPatologie\r\n13.\tRadiologie\r\n14.\tImunologie\r\n15.\tOrtopedie\r\n16.\tOftalmologie\r\n17.\tCardiologie\r\n18.\tOtorinolaringologie\r\n19.\tKinetoterapie\r\n20.\tAsistență medicală preventivă\r\n21.\tNeurochirurgie\r\n22.\tMedicina nucleara\r\n23.\tChirurgie plastică\r\n24.\tChirurgie vasculară\r\n25.\tReumatologie\r\n26.\tOncologie\r\n27.\tChirurgie cardiotoracică\r\n28.\tGenetica medicala\r\n29.\tChirurgie colorectală\r\n30.\tChirurgie generală\r\n31.\tGastroenterologie\r\n32.\tHematologie\r\n33.\tGeriatrie\r\n34.\tMedicina de terapie intensiva\r\n35.\tMedicina sportiva\r\n36.\tMedicina somnului\r\n37.\tNefrologie\r\n38.\tEndocrinologie\r\n39.\tMedicina spitalicească\r\n40.\tSănătatea publică\r\n41.\tPatologia criminalistică\r\n42.\tMedicina muncii\r\n43.\tPneumologie\r\n44.\tAnestezie pediatrică\r\n45.\tRadiologie Diagnostică\r\n46.\tChirurgie pediatrică\r\n47.\tPsihiatria copilului si adolescentului\r\n48.\tPsihiatrie geriatrică\r\n49.\tPsihiatrie criminalistică\r\n50.\tNeuropatologie\r\n51.\tGenomica\r\n");
        }

    }
}
