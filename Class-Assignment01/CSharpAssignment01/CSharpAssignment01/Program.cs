using SampleConsleApp;
using System;
using System.Collections;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment01
{
    class Diseases
    {
        public string DisName { get; set; }
        public string DisSeverity { get; set; }
        public string DisCause { get; set; }
        public string DisDescription { get; set; }

    }
    class Symptoms : Diseases
    {
        public ArrayList Symptom { get; set; } = null;
        public string  SymptomDescription { get; set; } = null;

    }
    class DiseasesManager
    {
        static private ArrayList _data = new ArrayList();
        public string[] GetAllDiseases()
        {
            string[] DisName = new string[_data.Count];
            for (int i= 0;i <_data.Count;i++)
            {
                if (_data[i] is Symptoms)
                { var temp = _data[i] as Symptoms;

                    DisName[i] =temp.DisName ;
                }

            }
            return DisName;
        }
        public  Symptoms getSymptomObj(string dis)
        {
            foreach (var item in _data)
            {
                if (item is Symptoms)
                {
                    var temp = item as Symptoms;
                    if(temp.DisName==dis)
                    {
                        return temp;
                    }

                }

            }
            
            throw new DiseasesException("Diseases not found");
        }
        public  void AddDiseases(Symptoms dis)
        {
            _data.Add(dis);


        }
        public  void AddSymptom(Symptoms dis,string [] symp,string sympDesc)
        {
            var disObj = dis as Symptoms;
            if (disObj.Symptom == null)
            {
                ArrayList ar = new ArrayList();
                foreach (var item in symp)
                {
                    ar.Add(item);
                }
                disObj.Symptom = ar;

            }
            else
            {
                ArrayList ar = disObj.Symptom as ArrayList;
                foreach (var item in symp)
                {
                    ar.Add(item);
                }
                disObj.Symptom = ar;
            }

            disObj.SymptomDescription = sympDesc;
            

        }
        public ArrayList  CheckPatient(string[] PSymp)
        {
            ArrayList a = new ArrayList();
            foreach (var i in PSymp)
            {
                foreach (var item in _data)
                {
                    if ((item as Symptoms).Symptom.Contains(i))
                        a.Add((item as Symptoms));

                }
            }
            return a;
            

        }

    }

    class Program
    {
            static DiseasesManager d = new DiseasesManager();
        enum Options
        {
            AddD = 1, AddS = 2, CheckP = 3
        }
        enum Cause
        {
            external_factors=1 , internal_disorder=2
        }
        public const string menu = "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~DISEASES DETECTION SOFTWARE~~~~~~~~~~~~~~~~~~~\nTO ADD NEW DISEASES------------------------>PRESS 1\nTO ADD SYMPTOMS---------------->PRESS 2\nTO CHECK PATIENT------------------------->PRESS 3\nPS: ANY OTHER KEY IS CONSIDERED AS EXIT.....................................";

        private static void AddDiseasesHelper()
        {  
            string DisName = Utilities.Prompt("Add Diseases Name");
            string DisSeverity = Utilities.Prompt("Add Severity\n(e.g. “high”, “medium”, “low”)");
            string DisCause = Convert.ToString((Cause)Utilities.GetNumber("external factors------>press:1 \n internal disorder------>press:2"));
            DiscriptionNotSet:
            string DisDescription = Utilities.Prompt("Add Diseases Description not less than 30 charecters");
            if (DisDescription.Length < 30)
            {
                Utilities.Prompt("Add Diseases Description not less than 30 charecters");
                goto DiscriptionNotSet;
            }
            else
            { Symptoms s = new Symptoms { DisName = DisName, DisCause = DisCause, DisDescription = DisDescription };
                d.AddDiseases(s);
            }

        }
        private static void AddSymptomHelper()
        {   SymptomNotFound:
            var DisData = d.GetAllDiseases();
            Console.WriteLine("Enter Any one Diseases from following\n------------------------");
            foreach (var item in DisData)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            string DisName = Console.ReadLine();
            try
            {
                var temp=d.getSymptomObj(DisName) ;
                //Console.WriteLine(temp.GetType());
                
                //Console.WriteLine(TempObj.GetType());
                string[] symp=Utilities.Prompt("Enter Diseases Symptoms space sperated ").Split(' ');
                string sympDesc = Utilities.Prompt("Enter Symptom Description (e.g. “body temperature exceeds 102 C”)");
                d.AddSymptom(temp, symp, sympDesc);
              
          }
            catch (Exception e)
            {
                Console.WriteLine(e);
                goto SymptomNotFound;
            }
            



           




        }
        private static void CheckPatientHelper()
        {
           string  PName = Utilities.Prompt("Enter Patient Name");
            string[] PSymp = Utilities.Prompt("Enter Symptoms space seperated ").Split(' ');
            ArrayList ar=d.CheckPatient( PSymp);
            Console.WriteLine("Possible diseases");
            foreach (var item in ar)
            {
                var a = item as Symptoms;
                Console.WriteLine(a.DisName);

            }





        }

        private static bool processMenu(Options choice)
        {
            switch (choice)
            {
                case Options.AddD:
                    AddDiseasesHelper();
                    break;

                case Options.AddS:
                    AddSymptomHelper();
                    break;

                case Options.CheckP:
                    CheckPatientHelper();
                    break;
                default:
                    return false;
            }
            return true;
        }
        public static void Run()
        {
            bool processing = true;
            do
            {
                Options choice = (Options)Utilities.GetNumber(menu);
                processing = processMenu(choice);
                Utilities.Prompt("press Enter to continue");
                Console.Clear();
            } while (processing);
            Console.WriteLine("Thanks for Using our Application!!!");

        }






        static void Main(string[] args)
        {
            Run();
        }
    }
}
