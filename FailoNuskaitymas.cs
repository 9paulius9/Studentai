using System;
using System.Linq;

namespace ipaantras
{
    class FailoNuskaitymas
    {
        public static void nuskaitymas()
        {
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(@"D:\\Files\\Darbai(Disk D)\\Programavimas\\ipaantras\\ipaantras\\SugeneruotiSarasai\\v5failas.txt");

                while ((Studentai.line = file.ReadLine()) != null && Studentai.count <= 10000)
                {
                    Studentai.eilutes++;
                    Studentai.zodziai = Studentai.line.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()).ToList();

                    Studentai.vardaaaaaas.Add(Studentai.zodziai[Studentai.count]);
                    Studentai.vardas.Add(Studentai.zodziai[Studentai.count]);
                    Studentai.pavarde.Add(Studentai.zodziai[Studentai.count + 1]);
                    Studentai.darbai.Add(Studentai.zodziai[Studentai.count + 2]);
                    Studentai.darbai.Add(Studentai.zodziai[Studentai.count + 3]);
                    Studentai.darbai.Add(Studentai.zodziai[Studentai.count + 4]);
                    Studentai.darbai.Add(Studentai.zodziai[Studentai.count + 5]);
                    Studentai.darbai.Add(Studentai.zodziai[Studentai.count + 6]);
                    Studentai.egzas.Add(Studentai.zodziai[Studentai.count + 7]);
                }

                Studentai.studentukiekis = Studentai.eilutes;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Generic Exception Handler: {e}");
            }

            for (int i = 0; i < Studentai.vardaaaaaas.Count(); i++)
            {

                Studentai.vardasstringlist.Add(Studentai.vardas[i]);
                Studentai.pavardestringlist.Add(Studentai.pavarde[i]);
                Studentai.ndkiekis = (Studentai.zodziai.Count() - 3);
                for (int j = 0 + Studentai.temp; j < Studentai.ndkiekis + Studentai.temp; j++)
                {
                    int r = 0;
                    Int32.TryParse(Studentai.darbai[j], out r);
                    Studentai.ndivertinimas = r;
                    Studentai.ndivertimaividinislistas.Add(Studentai.ndivertinimas);
                    Studentai.ndivertinimailist.Add(Studentai.ndivertimaividinislistas);

                    Studentai.suma += Studentai.ndivertinimailist[i][j];
                }
                Studentai.temp += Studentai.ndkiekis;
                Studentai.egzaminorezdoublelist.Add(Double.Parse(Studentai.egzas[i]));

                Studentai.vidurkis = (Studentai.suma / Studentai.ndkiekis);
                Studentai.arsklyginis = Studentai.ndkiekis % 2;
                if (Studentai.arsklyginis == 0)
                {
                    //kai n elementai lyginis skaicius
                    Studentai.vidurioid = Studentai.ndkiekis / 2;
                    Studentai.mediana = (Studentai.ndivertinimailist[i][Studentai.vidurioid - 1]) + (Studentai.ndivertinimailist[i][Studentai.vidurioid]) / 2;
                }
                else
                {
                    //kai n elementai nelyginis skaicius
                    Studentai.vidurioid = Studentai.ndkiekis / 2;
                    Studentai.mediana = Studentai.ndivertinimailist[i][Studentai.vidurioid];
                }
                Studentai.suma = 0;
                Studentai.galutinisdoublelist.Add((0.3 * Studentai.vidurkis) + (0.7 * Studentai.egzaminorezdoublelist[i]));
                Studentai.galutinismedianadoublelist.Add((0.3 * Studentai.mediana) + (0.7 * Studentai.egzaminorezdoublelist[i]));
            }
        }
        public static void linkedListFailoNuskaitymas()
        {
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(@"D:\\Files\\Darbai(Disk D)\\Programavimas\\ipaantras\\ipaantras\\SugeneruotiSarasai\\v5failas.txt");

                while ((Studentai.line = file.ReadLine()) != null && Studentai.count <= 10000)
                {
                    Studentai.eilutes++;
                    Studentai.zodziai = Studentai.line.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()).ToList();

                    Studentai.vardaaaaaasLList.AddLast(Studentai.zodziai.ElementAt(Studentai.count));
                    Studentai.vardasLList.AddLast(Studentai.zodziai.ElementAt(Studentai.count));
                    Studentai.pavardeLList.AddLast(Studentai.zodziai.ElementAt((Studentai.count + 1)));
                    Studentai.darbaiLList.AddLast(Studentai.zodziai.ElementAt(Studentai.count + 2));
                    Studentai.darbaiLList.AddLast(Studentai.zodziai.ElementAt(Studentai.count + 3));
                    Studentai.darbaiLList.AddLast(Studentai.zodziai.ElementAt(Studentai.count + 4));
                    Studentai.darbaiLList.AddLast(Studentai.zodziai.ElementAt(Studentai.count + 5));
                    Studentai.darbaiLList.AddLast(Studentai.zodziai.ElementAt(Studentai.count + 6));
                    Studentai.egzasLList.AddLast(Studentai.zodziai.ElementAt(Studentai.count + 7));
                }

                Studentai.studentukiekis = Studentai.eilutes;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Generic Exception Handler: {e}");
            }

            for (int i = 0; i < Studentai.vardaaaaaasLList.Count(); i++)
            {

                Studentai.vardasstringLList.AddLast(Studentai.vardasLList.ElementAt(i));
                Studentai.pavardestringLList.AddLast(Studentai.pavardeLList.ElementAt(i));
                Studentai.ndkiekis = (Studentai.zodziai.Count() - 3);
                for (int j = 0 + Studentai.temp; j < Studentai.ndkiekis + Studentai.temp; j++)
                {
                    int r = 0;
                    Int32.TryParse(Studentai.darbaiLList.ElementAt(j), out r);
                    Studentai.ndivertinimas = r;
                    Studentai.ndivertimaividinisLList.AddLast(Studentai.ndivertinimas);
                    Studentai.ndivertinimaiLList.AddLast(Studentai.ndivertimaividinisLList);

                    Studentai.suma += Convert.ToDouble(Studentai.ndivertinimaiLList.ElementAt(i).ElementAt(j));
                    //Studentai.suma += Convert.ToDouble(Studentai.ndivertinimaiLList.Last);
                }
                Studentai.temp += Studentai.ndkiekis;
                Studentai.egzaminorezdoubleLList.AddLast(Double.Parse(Studentai.egzasLList.ElementAt(i)));

                Studentai.vidurkis = (Studentai.suma / Studentai.ndkiekis);
                Studentai.arsklyginis = Studentai.ndkiekis % 2;
                if (Studentai.arsklyginis == 0)
                {
                    //kai n elementai lyginis skaicius
                    Studentai.vidurioid = Studentai.ndkiekis / 2;
                    Studentai.mediana = (Studentai.ndivertinimaiLList.ElementAt(i).ElementAt(Studentai.vidurioid - 1) + (Studentai.ndivertinimaiLList.ElementAt(i).ElementAt(Studentai.vidurioid)) / 2);
                }
                else
                {
                    //kai n elementai nelyginis skaicius
                    Studentai.vidurioid = Studentai.ndkiekis / 2;
                    Studentai.mediana = Studentai.ndivertinimaiLList.ElementAt(i).ElementAt(Studentai.vidurioid);
                }
                Studentai.suma = 0;
                Studentai.galutinisdoubleLList.AddLast((0.3 * Studentai.vidurkis) + (0.7 * Studentai.egzaminorezdoubleLList.ElementAt(i)));
                Studentai.galutinismedianadoubleLList.AddLast((0.3 * Studentai.mediana) + (0.7 * Studentai.egzaminorezdoubleLList.ElementAt(i)));
            }
        }

        public static void queueFailoNuskaitymas()
        {
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(@"D:\\Files\\Darbai(Disk D)\\Programavimas\\ipaantras\\ipaantras\\SugeneruotiSarasai\\v5failas.txt");

                while ((Studentai.line = file.ReadLine()) != null && Studentai.count <= 10000)
                {
                    Studentai.eilutes++;
                    Studentai.zodziai = Studentai.line.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim()).ToList();

                    Studentai.vardaaaaaasQueue.Enqueue(Studentai.zodziai[Studentai.count]);
                    Studentai.vardasQueue.Enqueue(Studentai.zodziai[Studentai.count]);
                    Studentai.pavardeQueue.Enqueue(Studentai.zodziai[Studentai.count + 1]);
                    Studentai.darbaiQueue.Enqueue(Studentai.zodziai[Studentai.count + 2]);
                    Studentai.darbaiQueue.Enqueue(Studentai.zodziai[Studentai.count + 3]);
                    Studentai.darbaiQueue.Enqueue(Studentai.zodziai[Studentai.count + 4]);
                    Studentai.darbaiQueue.Enqueue(Studentai.zodziai[Studentai.count + 5]);
                    Studentai.darbaiQueue.Enqueue(Studentai.zodziai[Studentai.count + 6]);
                    Studentai.egzasQueue.Enqueue(Studentai.zodziai[Studentai.count + 7]);
                }

                Studentai.studentukiekis = Studentai.eilutes;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Generic Exception Handler: {e}");
            }

            for (int i = 0; i < Studentai.vardaaaaaasQueue.Count(); i++)
            {

                Studentai.vardasstringQueue.Enqueue(Studentai.vardasQueue.ElementAt(i));
                Studentai.pavardestringQueue.Enqueue(Studentai.pavardeQueue.ElementAt(i));
                Studentai.ndkiekis = (Studentai.zodziai.Count() - 3);
                for (int j = 0 + Studentai.temp; j < Studentai.ndkiekis + Studentai.temp; j++)
                {
                    int r = 0;
                    Int32.TryParse(Studentai.darbaiQueue.ElementAt(j), out r);
                    Studentai.ndivertinimas = r;
                    Studentai.ndivertimaividinisQueue.Enqueue(Studentai.ndivertinimas);
                    Studentai.ndivertinimaiQueue.Enqueue(Studentai.ndivertimaividinisQueue);

                    Studentai.suma += Studentai.ndivertinimaiQueue.ElementAt(i).ElementAt(j);
                }
                Studentai.temp += Studentai.ndkiekis;
                Studentai.egzaminorezdoubleQueue.Enqueue(Double.Parse(Studentai.egzasQueue.ElementAt(i)));

                Studentai.vidurkis = (Studentai.suma / Studentai.ndkiekis);
                Studentai.arsklyginis = Studentai.ndkiekis % 2;
                if (Studentai.arsklyginis == 0)
                {
                    //kai n elementai lyginis skaicius
                    Studentai.vidurioid = Studentai.ndkiekis / 2;
                    Studentai.mediana = (Studentai.ndivertinimaiQueue.ElementAt(i).ElementAt(Studentai.vidurioid - 1)) + (Studentai.ndivertinimaiQueue.ElementAt(i).ElementAt(Studentai.vidurioid)) / 2;
                }
                else
                {
                    //kai n elementai nelyginis skaicius
                    Studentai.vidurioid = Studentai.ndkiekis / 2;
                    Studentai.mediana = Studentai.ndivertinimaiQueue.ElementAt(i).ElementAt(Studentai.vidurioid);
                }
                Studentai.suma = 0;
                Studentai.galutinisdoubleQueue.Enqueue((0.3 * Studentai.vidurkis) + (0.7 * Studentai.egzaminorezdoubleQueue.ElementAt(i)));
                Studentai.galutinismedianadoubleQueue.Enqueue((0.3 * Studentai.mediana) + (0.7 * Studentai.egzaminorezdoubleQueue.ElementAt(i)));
            }


        }

    }
}



