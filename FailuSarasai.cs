using System;

namespace ipaantras
{
    class FailuSarasai
    {
        public static void failugeneravimas()
        {
            int laipsnis = 1;
            int desimt = 10;
            int pakeltas = 10;
            for (int k = 0; k < 5; k++)
            {
                Studentai.studentukiekis = pakeltas;
                Studentai.vardasstringlist.Clear();
                Studentai.pavardestringlist.Clear();
                Studentai.ndkiekisintlist.Clear();
                Studentai.ndivertinimailist.Clear();
                Studentai.ndivertimaividinislistas.Clear();
                Studentai.egzaminorezdoublelist.Clear();
                Studentai.galutinisdoublelist.Clear();
                Studentai.galutinismedianadoublelist.Clear();

                for (int i = 0; i < Studentai.studentukiekis; i++)
                {
                    Studentai.suma = 0;


                    Studentai.studentoi = i;
                    Studentai.vardasstringlist.Add("Vardas" + (i + 1));
                    Studentai.pavardestringlist.Add("Pavarde" + (i + 1));

                    Studentai.ndkiekis = Studentai.ndivertinimasrandom.Next(1, 10);
                    for (int j = 0; j < Studentai.ndkiekis; j++)
                    {
                        Studentai.ndivertinimas = Studentai.ndivertinimasrandom.Next(1, 10);
                        Studentai.ndivertimaividinislistas.Add(Studentai.ndivertinimas);
                        Studentai.ndivertinimailist.Add(Studentai.ndivertimaividinislistas);

                        Studentai.suma += Studentai.ndivertinimailist[i][j];
                    }

                    Studentai.egzaminoivertinimas = Studentai.ndivertinimasrandom.Next(1, 10);
                    Studentai.egzaminorezdoublelist.Add(Studentai.egzaminoivertinimas);
                    Galutiniai.galutinisskaiciavimas();

                }
                Studentai.failovardas = "sarasaslaipsniu" + $"{k + 1}";
                laipsnis++;
                pakeltas = (int)Math.Pow(desimt, laipsnis);
                Spausdinimas.rezifaila();
            }
        }
    }
}
