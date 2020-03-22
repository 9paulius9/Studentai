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
                            Galutiniai.galutinisskaiciavimas();
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
                            Galutiniai.galutinisskaiciavimas();
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
    }
}


