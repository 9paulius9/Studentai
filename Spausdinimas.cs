using System;
using System.IO;
using System.Linq;

namespace ipaantras
{
    class Spausdinimas
    {
        public static void rezspausdinimasvid()
        {
            Console.WriteLine("Vardas".PadRight(10) + "Pavardė".PadRight(10) + "Galutinis (Vid.)");
            Console.WriteLine("------------------------------------");
            Studentai.vardasstringlist.Sort();
            for (int i = 0; i < Studentai.studentukiekis; i++)
            {
                Console.WriteLine(Studentai.vardasstringlist[i].PadRight(10) + Studentai.pavardestringlist[i].PadRight(18) + $"{Studentai.galutinisdoublelist[i]:0.00}");
            }
        }
        public static void rezspausdinimasmed()
        {
            Console.WriteLine("Vardas".PadRight(10) + "Pavardė".PadRight(10) + "Galutinis (Med.)");
            Console.WriteLine("------------------------------------");
            Studentai.vardasstringlist.Sort();
            for (int i = 0; i < Studentai.studentukiekis; i++)
            {
                Console.WriteLine(Studentai.vardasstringlist[i].PadRight(10) + Studentai.pavardestringlist[i].PadRight(10) + "".PadRight(11) + $"{Studentai.galutinismedianadoublelist[i]:0.00}");
            }
        }

        public static void rezspausdinimasfailas()
        {
            Console.WriteLine("Vardas".PadRight(10) + "Pavardė".PadRight(10) + "Galutinis(Vid.)/".PadRight(14) + "Galutinis(Med.)");
            Console.WriteLine("------------------------------------");

            for (int i = 0; i < Studentai.studentukiekis; i++)
            {
                Console.WriteLine(Studentai.vardasstringlist[i].PadRight(9) + Studentai.pavardestringlist[i].PadRight(10) + "".PadRight(11) + $"{Studentai.galutinisdoublelist[i]:0.00}".PadRight(17) + $"{Studentai.galutinismedianadoublelist[i]:0.00}");
            }
        }

        public static void rezspausdinimasSuLinkedList()
        {
            Console.WriteLine("Vardas".PadRight(10) + "Pavardė".PadRight(10) + "Galutinis(Vid.)/".PadRight(14) + "Galutinis(Med.)");
            Console.WriteLine("------------------------------------");

            for (int i = 0; i < Studentai.studentukiekis; i++)
            {
                Console.WriteLine(Studentai.vardasstringLList.ElementAt(i).PadRight(9) + Studentai.pavardestringLList.ElementAt(i).PadRight(10) + "".PadRight(11) + $"{Studentai.galutinisdoubleLList.ElementAt(i):0.00}".PadRight(17) + $"{Studentai.galutinismedianadoubleLList.ElementAt(i):0.00}");
            }
        }
        public static void rezspausdinimasSuQueue()
        {
            Console.WriteLine("Vardas".PadRight(10) + "Pavardė".PadRight(10) + "Galutinis(Vid.)/".PadRight(14) + "Galutinis(Med.)");
            Console.WriteLine("------------------------------------");

            for (int i = 0; i < Studentai.studentukiekis; i++)
            {
                Console.WriteLine(Studentai.vardasstringQueue.ElementAt(i).PadRight(9) + Studentai.pavardestringQueue.ElementAt(i).PadRight(10) + "".PadRight(11) + $"{Studentai.galutinisdoubleQueue.ElementAt(i):0.00}".PadRight(17) + $"{Studentai.galutinismedianadoubleQueue.ElementAt(i):0.00}");
            }
        }

        public static void rezifaila()
        {
            try
            {
                StreamWriter sw = new StreamWriter("D:\\Files\\Darbai(Disk D)\\Programavimas\\ipaantras\\ipaantras\\SugeneruotiSarasai\\" + Studentai.failovardas + ".txt");
                StreamWriter swvargsiukai = new StreamWriter("D:\\Files\\Darbai(Disk D)\\Programavimas\\ipaantras\\ipaantras\\SugeneruotiSarasai\\vargsiukai.txt");
                StreamWriter swkietiakai = new StreamWriter("D:\\Files\\Darbai(Disk D)\\Programavimas\\ipaantras\\ipaantras\\SugeneruotiSarasai\\kietiakai.txt");

                sw.WriteLine("Vardas".PadRight(15) + "Pavardė".PadRight(13) + "Galutinis(Vid.)/".PadRight(14) + "Galutinis(Med.)");
                sw.WriteLine("--------------------------------------------------------");
                swvargsiukai.WriteLine("Vardas".PadRight(15) + "Pavardė".PadRight(13) + "Galutinis(Vid.)/".PadRight(14) + "Galutinis(Med.)");
                swvargsiukai.WriteLine("----------------------------------------------------------");
                swkietiakai.WriteLine("Vardas".PadRight(15) + "Pavardė".PadRight(13) + "Galutinis(Vid.)/".PadRight(14) + "Galutinis(Med.)");
                swkietiakai.WriteLine("-----------------------------------------------------------");

                for (int i = 0; i < Studentai.studentukiekis; i++)
                {
                    sw.WriteLine(Studentai.vardasstringlist[i].PadRight(15) + Studentai.pavardestringlist[i].PadRight(15) + "".PadRight(9) + $"{Studentai.galutinisdoublelist[i]:0.00}".PadRight(15) + $"{Studentai.galutinismedianadoublelist[i]:0.00}");
                    if (Studentai.galutinisdoublelist[i] < 5.0)
                    {
                        swvargsiukai.WriteLine(Studentai.vardasstringlist[i].PadRight(15) + Studentai.pavardestringlist[i].PadRight(15) + "".PadRight(9) + $"{Studentai.galutinisdoublelist[i]:0.00}".PadRight(15) + $"{Studentai.galutinismedianadoublelist[i]:0.00}");

                    }
                    else
                    {
                        swkietiakai.WriteLine(Studentai.vardasstringlist[i].PadRight(15) + Studentai.pavardestringlist[i].PadRight(15) + "".PadRight(9) + $"{Studentai.galutinisdoublelist[i]:0.00}".PadRight(15) + $"{Studentai.galutinismedianadoublelist[i]:0.00}");
                    }
                }

                sw.Close();
                swvargsiukai.Close();
                swkietiakai.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("blogas failas\n");
                Console.WriteLine($"Generic Exception Handler: {e}");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Bloga Direktorija\n");
                Console.WriteLine($"Generic Exception Handler: {e}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Ivedete neskaiciu\n");
                Console.WriteLine($"Generic Exception Handler: {e}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Bloga įvestis");
                Console.WriteLine($"Generic Exception Handler: {e}");
            }
        }

        public static void vienasFailas()
        {
            StreamWriter sw = new StreamWriter("D:\\Files\\Darbai(Disk D)\\Programavimas\\ipaantras\\ipaantras\\SugeneruotiSarasai\\v5failas.txt");

            for (int i = 0; i < 10000; i++)
            {
                Studentai.suma = 0;
                Studentai.studentoi = i;
                Studentai.vardasstringlist.Add("Vardas" + (i + 1));
                sw.Write("Vardas" + (i + 1));
                sw.Write(" ");
                Studentai.pavardestringlist.Add("Pavarde" + (i + 1));
                sw.Write("Pavarde" + (i + 1));
                sw.Write(" ");
                Studentai.ndkiekis = Studentai.ndivertinimasrandom.Next(1, 10);
                for (int j = 0; j < 5; j++)
                {
                    Studentai.ndivertinimas = Studentai.ndivertinimasrandom.Next(1, 10);
                    sw.Write(Studentai.ndivertinimas);
                    sw.Write(" ");
                    Studentai.ndivertimaividinislistas.Add(Studentai.ndivertinimas);

                    Studentai.ndivertinimailist.Add(Studentai.ndivertimaividinislistas);

                    Studentai.suma += Studentai.ndivertinimailist[i][j];
                }

                Studentai.egzaminoivertinimas = Studentai.ndivertinimasrandom.Next(1, 10);
                sw.WriteLine(Studentai.egzaminoivertinimas);
                Studentai.egzaminorezdoublelist.Add(Studentai.egzaminoivertinimas);
                Galutiniai.galutinisskaiciavimas();

            }
            sw.Close();
        }

    }
}
