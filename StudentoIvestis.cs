using System;

namespace ipaantras
{
    class StudentoIvestis
    {
        public static void studentoduomenys()
        {
            Console.WriteLine("iveskite studentu kieki");
            try
            {
                Studentai.studentukiekis = Int32.Parse(Console.ReadLine());
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Negalimas 0");
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

            for (int i = 0; i < Studentai.studentukiekis; i++)
            {
                try
                {
                    Studentai.studentoi = i;
                    Console.WriteLine("Iveskite " + (i + 1) + " studento varda");
                    Studentai.vardasstringlist.Add(Console.ReadLine());

                    Console.WriteLine("Iveskite " + (i + 1) + " studento pavarde");
                    Studentai.pavardestringlist.Add(Console.ReadLine());

                    Console.WriteLine("Iveskite namu darbu kieki");
                    Studentai.ndkiekis = Int32.Parse(Console.ReadLine());


                    Console.WriteLine("Ivesti patiems nd rezultatus spauskite:1, Generuoti nd rezultatus spauskite:2");
                    Studentai.switchpasirinkimas = Console.ReadLine();
                    switch (Convert.ToInt32(Studentai.switchpasirinkimas))
                    {
                        case 1:
                            //Ivesti skaicius
                            Console.WriteLine("Ivedimas");

                            for (int j = 0; j < Studentai.ndkiekis; j++)
                            {
                                Console.WriteLine("Iveskite " + (j + 1) + " nd");
                                Studentai.ndivertinimas = Int32.Parse(Console.ReadLine());
                                Studentai.ndivertimaividinislistas.Add(Studentai.ndivertinimas);
                                Studentai.ndivertinimailist.Add(Studentai.ndivertimaividinislistas);
                                Studentai.suma += Studentai.ndivertinimailist[i][j];
                            }

                            Console.WriteLine("Iveskite egzamino rezultata");
                            Studentai.egzaminoivertinimas = Double.Parse(Console.ReadLine());
                            Studentai.egzaminorezdoublelist.Add(Studentai.egzaminoivertinimas);
                            Galutiniai.galutinisSkaiciavimas();
                            break;

                        case 2:
                            //Generuoti skaicius

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
                            break;
                        default:
                            throw new ArgumentOutOfRangeException("Klaidingas skaicius");
                    }
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine("Ivedete bloga skaiciu");
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
        }

        public static void masyvas()
        {
            //Maasyyyyyyyvass
            Console.WriteLine("iveskite studentu kieki");
            Studentai.studentukiekis = Int32.Parse(Console.ReadLine());

            Studentai.vardasstringarray = new string[Studentai.studentukiekis];
            Studentai.pavardestringarray = new string[Studentai.studentukiekis];
            Studentai.ndkiekisintarray = new int[Studentai.studentukiekis];
            Studentai.egzaminorezdoublearray = new double[Studentai.studentukiekis];
            Studentai.galutinisdoublearray = new double[Studentai.studentukiekis];
            Studentai.galutinismedianadoublearray = new double[Studentai.studentukiekis];

            for (int i = 0; i < Studentai.studentukiekis; i++)

            {

                Console.WriteLine("Iveskite  " + (i + 1) + " varda");
                Studentai.vardasstringarray[i] = Console.ReadLine();
                Console.WriteLine("Iveskite  " + (i + 1) + " pavarde");
                Studentai.pavardestringarray[i] = Console.ReadLine();

                Console.WriteLine("Iveskite namu darbu kieki");
                Studentai.ndkiekis = Int32.Parse(Console.ReadLine());
                Studentai.ndivertinimaiintarray = new int[Studentai.studentukiekis, Studentai.ndkiekis];

                Console.WriteLine("Ivesti patiems nd rezultatus spauskite:1, Generuoti nd rezultatus spauskite:2");
                Studentai.switchpasirinkimas = Console.ReadLine();
                switch (Convert.ToInt32(Studentai.switchpasirinkimas))
                {
                    case 1:
                        //Ivesti
                        Console.WriteLine("Ivedimas");
                        for (int j = 0; j < Studentai.ndkiekis; j++)
                        {
                            Console.WriteLine("Iveskite " + (j + 1) + " nd");
                            Studentai.ndivertinimas = Int32.Parse(Console.ReadLine());
                            Studentai.ndivertinimaiintarray[i, j] = Studentai.ndivertinimas;
                            Studentai.suma += Studentai.ndivertinimas;
                        }
                        Console.WriteLine("Iveskite egzamino rezultata");
                        Studentai.egzaminoivertinimas = Double.Parse(Console.ReadLine());
                        Studentai.egzaminorezdoublearray[i] = Studentai.egzaminoivertinimas;
                        break;

                    case 2:
                        //Generuoti
                        Console.WriteLine("Generavimas");
                        for (int j = 0; j < Studentai.ndkiekis; j++)
                        {
                            //Console.WriteLine("Iveskite " + (j + 1) + "nd");
                            //ndivertinimas = Int32.Parse(Console.ReadLine());
                            Studentai.ndivertinimas = Studentai.ndivertinimasrandom.Next(1, 10);
                            Studentai.ndivertinimaiintarray[i, j] = Studentai.ndivertinimas;
                            Studentai.suma += Studentai.ndivertinimas;
                        }
                        //Console.WriteLine("Iveskite egzamino rezultata");
                        // egzaminoivertinimas = Double.Parse(Console.ReadLine());
                        Studentai.egzaminoivertinimas = Studentai.ndivertinimasrandom.Next(1, 10);
                        Studentai.egzaminorezdoublearray[i] = Studentai.egzaminoivertinimas;
                        break;

                }
                Studentai.vidurkis = (Studentai.suma / Studentai.ndkiekis);
                Studentai.arsklyginis = Studentai.ndkiekis % 2;
                if (Studentai.arsklyginis == 0)
                {
                    //kai n elementai lyginis skaicius
                    Studentai.vidurioid = Studentai.ndkiekis / 2;
                    Studentai.mediana = (Studentai.ndivertinimaiintarray[i, Studentai.vidurioid - 1]) + (Studentai.ndivertinimaiintarray[i, Studentai.vidurioid]) / 2;
                }
                else
                {
                    //kai n elementai nelyginis skaicius
                    Studentai.vidurioid = Studentai.ndkiekis / 2;
                    Studentai.mediana = Studentai.ndivertinimaiintarray[i, Studentai.vidurioid];
                }
                Studentai.galutinisdoublearray[i] = (0.3 * Studentai.vidurkis) + (0.7 * Studentai.egzaminoivertinimas);
                Studentai.galutinismedianadoublearray[i] = (0.3 * Studentai.mediana) + (0.7 * Studentai.egzaminoivertinimas);
            }

            Console.WriteLine("Skaiciuoti galutini su vidurkiu:1, skaicciuoti galutini su mediana:2");
            Studentai.switchpasirinkimas = Console.ReadLine();
            switch (Convert.ToInt32(Studentai.switchpasirinkimas))
            {
                case 1:
                    //Vidurkis
                    Console.WriteLine("Vidurkis");
                    Console.WriteLine("Vardas".PadRight(10) + "Pavardė".PadRight(10) + "Galutinis (Vid.)");
                    Console.WriteLine("------------------------------------");

                    for (int i = 0; i < Studentai.studentukiekis; i++)
                    {
                        Console.WriteLine(Studentai.vardasstringarray[i].PadRight(10) + Studentai.pavardestringarray[i].PadRight(10) + "".PadRight(11) + $"{Studentai.galutinisdoublearray[i]:0.00}");

                    }
                    break;
                case 2:
                    //Mediana
                    Console.WriteLine("Mediana");
                    Console.WriteLine("Vardas".PadRight(10) + "Pavardė".PadRight(10) + "Galutinis (Med.)");
                    Console.WriteLine("------------------------------------");

                    for (int i = 0; i < Studentai.studentukiekis; i++)
                    {
                        Console.WriteLine(Studentai.vardasstringarray[i].PadRight(10) + Studentai.pavardestringarray[i].PadRight(10) + "".PadRight(11) + $"{Studentai.galutinismedianadoublearray[i]:0.00}");
                    }
                    break;

            }
        }

    }
}


