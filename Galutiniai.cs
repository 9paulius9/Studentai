using System.Linq;

namespace ipaantras
{
    class Galutiniai
    {
        public static void galutinisSkaiciavimas()
        {
            Studentai.vidurkis = (Studentai.suma / Studentai.ndkiekis);
            Studentai.arsklyginis = Studentai.ndkiekis % 2;

            if (Studentai.arsklyginis == 0)
            {
                //kai n elementai lyginis skaicius
                Studentai.vidurioid = Studentai.ndkiekis / 2;
                Studentai.mediana = (((Studentai.ndivertinimailist[Studentai.studentoi][Studentai.vidurioid - 1]) + (Studentai.ndivertinimailist[Studentai.studentoi][Studentai.vidurioid])) / 2.00);
            }
            else
            {
                //kai n elementai nelyginis skaicius
                Studentai.vidurioid = Studentai.ndkiekis / 2;
                Studentai.mediana = Studentai.ndivertinimailist[Studentai.studentoi][Studentai.vidurioid];
            }
            Studentai.galutinisdoublelist.Add((0.3 * Studentai.vidurkis) + (0.7 * Studentai.egzaminoivertinimas));
            Studentai.galutinismedianadoublelist.Add((0.3 * Studentai.mediana) + (0.7 * Studentai.egzaminoivertinimas));
        }
        public static void galutinisSkaiciavimasSuLinkedListu()
        {
            Studentai.vidurkis = (Studentai.suma / Studentai.ndkiekis);
            Studentai.arsklyginis = Studentai.ndkiekis % 2;

            if (Studentai.arsklyginis == 0)
            {
                //kai n elementai lyginis skaicius
                Studentai.vidurioid = Studentai.ndkiekis / 2;
                Studentai.mediana = (((Studentai.ndivertinimaiLList.ElementAt(Studentai.studentoi).ElementAt(Studentai.vidurioid - 1)) + (Studentai.ndivertinimaiLList.ElementAt(Studentai.studentoi).ElementAt(Studentai.vidurioid))) / 2.00);
            }
            else
            {
                //kai n elementai nelyginis skaicius
                Studentai.vidurioid = Studentai.ndkiekis / 2;
                Studentai.mediana = Studentai.ndivertinimaiLList.ElementAt(Studentai.studentoi).ElementAt(Studentai.vidurioid);
            }
            Studentai.galutinisdoubleLList.AddLast((0.3 * Studentai.vidurkis) + (0.7 * Studentai.egzaminoivertinimas));
            Studentai.galutinismedianadoubleLList.AddLast((0.3 * Studentai.mediana) + (0.7 * Studentai.egzaminoivertinimas));
        }

        public static void galutinisSkaiciavimasSuQueue()
        {
            Studentai.vidurkis = (Studentai.suma / Studentai.ndkiekis);
            Studentai.arsklyginis = Studentai.ndkiekis % 2;
            if (Studentai.arsklyginis == 0)
            {
                //kai n elementai lyginis skaicius
                Studentai.vidurioid = Studentai.ndkiekis / 2;
                Studentai.mediana = (((Studentai.ndivertinimaiQueue.ElementAt(Studentai.studentoi).ElementAt(Studentai.vidurioid - 1)) + (Studentai.ndivertinimaiQueue.ElementAt(Studentai.studentoi).ElementAt(Studentai.vidurioid))) / 2.00);
            }
            else
            {
                //kai n elementai nelyginis skaicius
                Studentai.vidurioid = Studentai.ndkiekis / 2;
                Studentai.mediana = Studentai.ndivertinimaiQueue.ElementAt(Studentai.studentoi).ElementAt(Studentai.vidurioid);
            }

            Studentai.galutinisdoubleQueue.Enqueue((0.3 * Studentai.vidurkis) + (0.7 * Studentai.egzaminoivertinimas));
            Studentai.galutinismedianadoubleQueue.Enqueue((0.3 * Studentai.mediana) + (0.7 * Studentai.egzaminoivertinimas));
        }
    }
}
