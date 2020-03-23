using System;


namespace ipaantras
{
    class Program
    {
        static void Main(string[] args)
        {
            FailuSarasai.failugeneravimas();
            Console.WriteLine("Ivesti duomenys:1, nuskaityti is failo:2?");
            try
            {
                Studentai.switchpasirinkimas = Console.ReadLine();
                switch (Convert.ToInt32(Studentai.switchpasirinkimas))
                {
                    case 1:
                        StudentoIvestis.studentoduomenys();

                        Console.WriteLine("Skaiciuoti galutini su vidurkiu:1, skaicciuoti galutini su mediana:2");
                        try
                        {
                            Studentai.switchpasirinkimas = Console.ReadLine();
                            switch (Convert.ToInt32(Studentai.switchpasirinkimas))
                            {
                                case 1:
                                    Spausdinimas.rezspausdinimasvid();
                                    break;

                                case 2:
                                    Spausdinimas.rezspausdinimasmed();
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
                        break;
                    case 2:
                        FailoNuskaitymas.nuskaitymas();
                        Spausdinimas.rezspausdinimasfailas();
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
            Console.ReadKey();
        }
    }
}
