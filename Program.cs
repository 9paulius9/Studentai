using System;
using System.Diagnostics;

namespace ipaantras
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime a = DateTime.Now;
            Stopwatch stopwatch = Stopwatch.StartNew(); //creates and start the instance of Stopwatch
            stopwatch.Start();
            Studentai.switchfailuiskaityt = "2";

            Console.WriteLine("Ivesti duomenys:1, nuskaityti is failo:2?");
            try
            {
                // Studentai.switchpasirinkimas = Console.ReadLine();
                switch (Convert.ToInt32(Studentai.switchfailuiskaityt))
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
                        FailoNuskaitymas.nuskaitymas();//Listas
                        Spausdinimas.rezspausdinimasfailas();//Listas

                        //FailoNuskaitymas.linkedListFailoNuskaitymas();//LinkedListas
                        //Spausdinimas.rezspausdinimasSuLinkedList();//LinkedListas

                        //FailoNuskaitymas.queueFailoNuskaitymas();//Queue
                        //Spausdinimas.rezspausdinimasSuQueue();//Queue
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

            stopwatch.Stop();
            Console.WriteLine("stopwatch:" + stopwatch.Elapsed);
            DateTime b = DateTime.Now;
            Console.WriteLine(b.Subtract(a).TotalSeconds);
            Console.ReadLine();
        }
    }
}
