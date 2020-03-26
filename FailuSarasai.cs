using System;
using System.Linq;

namespace ipaantras
{
    class FailuSarasai
    {
        public static void failuGeneravimas()
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
                    Galutiniai.galutinisSkaiciavimas();

                }
                Studentai.failovardas = "sarasaslaipsniu" + $"{k + 1}";
                laipsnis++;
                pakeltas = (int)Math.Pow(desimt, laipsnis);
                Spausdinimas.reziFaila();
                //Spausdinimas.reziFailaBeKietiaku();
            }
        }

        public static void failuGenerimvasSuLInkedList()
        {
            int laipsnis = 1;
            int desimt = 10;
            int pakeltas = 10;
            for (int k = 0; k < 5; k++)
            {
                Studentai.studentukiekis = pakeltas;
                Studentai.vardasstringLList.Clear();
                Studentai.pavardestringLList.Clear();
                Studentai.ndkiekisintLList.Clear();
                Studentai.ndivertinimaiLList.Clear();
                Studentai.ndivertimaividinisLList.Clear();
                Studentai.egzaminorezdoubleLList.Clear();
                Studentai.galutinisdoubleLList.Clear();
                Studentai.galutinismedianadoubleLList.Clear();

                for (int i = 0; i < Studentai.studentukiekis; i++)
                {
                    Studentai.suma = 0;
                    Studentai.studentoi = i;
                    Studentai.vardasstringLList.AddLast("Vardas" + (i + 1));
                    Studentai.pavardestringLList.AddLast("Pavarde" + (i + 1));

                    Studentai.ndkiekis = Studentai.ndivertinimasrandom.Next(1, 10);
                    for (int j = 0; j < Studentai.ndkiekis; j++)
                    {
                        Studentai.ndivertinimas = Studentai.ndivertinimasrandom.Next(1, 10);
                        Studentai.ndivertimaividinisLList.AddLast(Studentai.ndivertinimas);
                        Studentai.ndivertinimaiLList.AddLast(Studentai.ndivertimaividinisLList);

                        Studentai.suma += Convert.ToDouble(Studentai.ndivertinimaiLList.ElementAt(i).ElementAt(j));
                    }

                    Studentai.egzaminoivertinimas = Studentai.ndivertinimasrandom.Next(1, 10);
                    Studentai.egzaminorezdoubleLList.AddLast(Studentai.egzaminoivertinimas);
                    Galutiniai.galutinisSkaiciavimasSuLinkedListu();

                }
                Studentai.failovardas = "sarasaslaipsniu" + $"{k + 1}";
                laipsnis++;
                pakeltas = (int)Math.Pow(desimt, laipsnis);
                //Spausdinimas.rezifailaSuLinkedList();
                Spausdinimas.rezifailaBeKietiakuSuLinkedList();
            }
        }

        public static void failuGenerimvasSuQueue()
        {
            int laipsnis = 1;
            int desimt = 10;
            int pakeltas = 10;
            for (int k = 0; k < 5; k++)
            {
                Studentai.studentukiekis = pakeltas;
                Studentai.vardasstringQueue.Clear();
                Studentai.pavardestringQueue.Clear();
                Studentai.ndkiekisintQueue.Clear();
                Studentai.ndivertinimaiQueue.Clear();
                Studentai.ndivertimaividinisQueue.Clear();
                Studentai.egzaminorezdoubleQueue.Clear();
                Studentai.galutinisdoubleQueue.Clear();
                Studentai.galutinismedianadoubleQueue.Clear();

                for (int i = 0; i < Studentai.studentukiekis; i++)
                {
                    Studentai.suma = 0;


                    Studentai.studentoi = i;
                    Studentai.vardasstringQueue.Enqueue("Vardas" + (i + 1));
                    Studentai.pavardestringQueue.Enqueue("Pavarde" + (i + 1));

                    Studentai.ndkiekis = Studentai.ndivertinimasrandom.Next(1, 10);
                    for (int j = 0; j < Studentai.ndkiekis; j++)
                    {
                        Studentai.ndivertinimas = Studentai.ndivertinimasrandom.Next(1, 10);
                        Studentai.ndivertimaividinisQueue.Enqueue(Studentai.ndivertinimas);
                        Studentai.ndivertinimaiQueue.Enqueue(Studentai.ndivertimaividinisQueue);

                        Studentai.suma += Studentai.ndivertinimaiQueue.ElementAt(i).ElementAt(j);
                    }

                    Studentai.egzaminoivertinimas = Studentai.ndivertinimasrandom.Next(1, 10);
                    Studentai.egzaminorezdoubleQueue.Enqueue(Studentai.egzaminoivertinimas);
                    Galutiniai.galutinisSkaiciavimasSuQueue();

                }
                Studentai.failovardas = "sarasaslaipsniu" + $"{k + 1}";
                laipsnis++;
                pakeltas = (int)Math.Pow(desimt, laipsnis);
                //Spausdinimas.reziFailaSuQueue();
                Spausdinimas.rezifailaBeKietiakuSuLinkedList();
            }
        }
    }
}
