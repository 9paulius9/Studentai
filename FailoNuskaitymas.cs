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
                System.IO.StreamReader file = new System.IO.StreamReader(@"D:\\Files\\Darbai(Disk D)\\Programavimas\\ipaantras\\ipaantras\\kursiokai.txt");

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
    }
}
