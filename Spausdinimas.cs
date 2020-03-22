using System;

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
            Console.WriteLine("-----------------------------------------------------------------");
            Studentai.vardasstringlist.Sort();
            for (int i = 0; i < Studentai.studentukiekis; i++)
            {
                Console.WriteLine(Studentai.vardasstringlist[i].PadRight(9) + Studentai.pavardestringlist[i].PadRight(10) + "".PadRight(11) + $"{Studentai.galutinisdoublelist[i]:0.00}".PadRight(17) + $"{Studentai.galutinismedianadoublelist[i]:0.00}");
            }
        }
    }
}
