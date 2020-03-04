using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ipaantras
{
    class Program
    {
        static void Main(string[] args)
        {
            //Masyvui
            string switchpasirinkimas;
            int studentukiekis=0;
            int ndkiekis = 0;
            int ndivertinimas = 0;
            double suma = 0;
            double vidurkis = 0;
            double arsklyginis = 0;
            int vidurioid = 0;
            double mediana = 0;
            double egzaminoivertinimas = 0;
            string[] vardasstringarray;//Masyvui
            string[] pavardestringarray;//Masyvui
            int[] ndkiekisintarray;//Masyvui
            int[,] ndivertinimaiintarray;//Masyvui
            double[] egzaminorezdoublearray;//Masyvui
            double[] galutinisdoublearray;//Masyvui
            double[] galutinismedianadoublearray;//Masyvui
            Random ndivertinimasrandom = new Random();

            //Listui
            List<string> vardasstringlist = new List<string>();//Listui
            List<string> pavardestringlist = new List<string>();//Listui
            List<int> ndkiekisintlist = new List<int>();//Listui
            List<List<int>> ndivertinimailist = new List<List<int>>();
            List<int> ndivertimaividinislistas = new List<int>();
            List<double> egzaminorezdoublelist = new List<double>();//Listui
            List<double> galutinisdoublelist = new List<double>();//Listui
            List<double> galutinismedianadoublelist = new List<double>();//Listui
    
            Console.WriteLine("Ar naudoti masyva:1 ar lista:2?");
            switchpasirinkimas= Console.ReadLine();
            switch (Convert.ToInt32(switchpasirinkimas))
            {
                case 1:
            //Maasyyyyyyyvass
            Console.WriteLine("iveskite studentu kieki");
            studentukiekis = Int32.Parse(Console.ReadLine());

                    vardasstringarray = new string[studentukiekis];
                    pavardestringarray = new string[studentukiekis];
                    ndkiekisintarray = new int[studentukiekis];
                    egzaminorezdoublearray = new double[studentukiekis];
                    galutinisdoublearray = new double[studentukiekis];
                    galutinismedianadoublearray = new double[studentukiekis];
            
            for (int i=0; i< studentukiekis; i++)
            {
                Console.WriteLine("Iveskite  " + (i + 1) + " varda");
                vardasstringarray[i] = Console.ReadLine();

                Console.WriteLine("Iveskite  " + (i+1) +" pavarde");
                pavardestringarray[i] = Console.ReadLine();

                Console.WriteLine("Iveskite namu darbu kieki");
                ndkiekis = Int32.Parse(Console.ReadLine());
                ndivertinimaiintarray = new int[studentukiekis, ndkiekis];        

                        Console.WriteLine("Ivesti patiems nd rezultatus spauskite:1, Generuoti nd rezultatus spauskite:2");
                        switchpasirinkimas = Console.ReadLine();
                        switch (Convert.ToInt32(switchpasirinkimas))
                        {
                            case 1:
                                //Ivesti
                                Console.WriteLine("Ivedimas");

                                for (int j = 0; j < ndkiekis; j++)
                                {
                                    Console.WriteLine("Iveskite " + (j + 1) + " nd");
                                    ndivertinimas = Int32.Parse(Console.ReadLine());
                                    ndivertinimaiintarray[i, j] = ndivertinimas;

                                    suma += ndivertinimas;
                                }

                                Console.WriteLine("Iveskite egzamino rezultata");
                                egzaminoivertinimas = Double.Parse(Console.ReadLine());
                                egzaminorezdoublearray[i] = egzaminoivertinimas;

                                break;

                            case 2:
                                //Generuoti
                                Console.WriteLine("Generavimas");
                                
                                for (int j = 0; j < ndkiekis; j++)
                                {
                                    //Console.WriteLine("Iveskite " + (j + 1) + "nd");
                                    //ndivertinimas = Int32.Parse(Console.ReadLine());

                                    ndivertinimas = ndivertinimasrandom.Next(1,10);
                                    ndivertinimaiintarray[i, j] = ndivertinimas;
                                    suma += ndivertinimas;
                                }

                                //Console.WriteLine("Iveskite egzamino rezultata");
                                // egzaminoivertinimas = Double.Parse(Console.ReadLine());

                                egzaminoivertinimas = ndivertinimasrandom.Next(1, 10);
                                egzaminorezdoublearray[i] = egzaminoivertinimas;
                                break;
                        }
                                        
                vidurkis = (suma / ndkiekis);
                arsklyginis = ndkiekis % 2;
                if(arsklyginis==0)
                {
                    //kai n elementai lyginis skaicius
                    vidurioid = ndkiekis / 2;
                    mediana = (ndivertinimaiintarray[i, vidurioid - 1]) + (ndivertinimaiintarray[i, vidurioid])/2;
                }else{
                    //kai n elementai nelyginis skaicius
                    vidurioid = ndkiekis / 2;
                    mediana = ndivertinimaiintarray[i,vidurioid];
                }
                
                galutinisdoublearray[i] = (0.3*vidurkis) + (0.7*egzaminoivertinimas);
               galutinismedianadoublearray[i] = (0.3 * mediana) + (0.7 * egzaminoivertinimas);
            }
                    Console.WriteLine("Skaiciuoti galutini su vidurkiu:1, skaicciuoti galutini su mediana:2");
                    switchpasirinkimas = Console.ReadLine();
                    switch (Convert.ToInt32(switchpasirinkimas))
                    {
                        case 1:
                            //Vidurkis
                            Console.WriteLine("Vidurkis");
                            Console.WriteLine("Vardas".PadRight(10) + "Pavardė".PadRight(10) + "Galutinis (Vid.)");
                            Console.WriteLine("------------------------------------");

                            for (int i = 0; i < studentukiekis; i++)
                            {
                                Console.WriteLine(vardasstringarray[i].PadRight(10) + pavardestringarray[i].PadRight(10) + "".PadRight(11) + $"{galutinisdoublearray[i]:0.00}");
                            }
                            break;

                        case 2:
                            //Mediana
                            Console.WriteLine("Mediana");
                            Console.WriteLine("Vardas".PadRight(10) + "Pavardė".PadRight(10) + "Galutinis (Med.)"); 
                            Console.WriteLine("------------------------------------");

                            for (int i =0; i<studentukiekis; i++)
                                {
                                     Console.WriteLine(vardasstringarray[i].PadRight(10) + pavardestringarray[i].PadRight(10) + "".PadRight(11) + $"{galutinismedianadoublearray[i]:0.00}");
                                }
                                break;
                    }      
                    break;

                case 2:

                    //Listaaaas
                    Console.WriteLine("Listas");

                    Console.WriteLine("iveskite studentu kieki");
                    studentukiekis = Int32.Parse(Console.ReadLine());

                    for (int i = 0; i < studentukiekis; i++)
                    {
                        Console.WriteLine("Iveskite " + (i+1) +" studento varda");
                        vardasstringlist.Add(Console.ReadLine());

                        Console.WriteLine("Iveskite " + (i+1) +" studento pavarde");
                        pavardestringlist.Add(Console.ReadLine());

                        Console.WriteLine("Iveskite namu darbu kieki");
                        ndkiekis = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Ivesti patiems nd rezultatus spauskite:1, Generuoti nd rezultatus spauskite:2");
                        switchpasirinkimas = Console.ReadLine();
                        switch (Convert.ToInt32(switchpasirinkimas))
                        {
                            case 1:
                                //Ivesti skaicius
                                Console.WriteLine("Ivedimas");

                               for (int j = 0; j < ndkiekis; j++)
                                {
                                    Console.WriteLine("Iveskite " + (j + 1) + " nd");
                                    ndivertinimas = Int32.Parse(Console.ReadLine());
                                    ndivertimaividinislistas.Add(ndivertinimas);
                                    ndivertinimailist.Add(ndivertimaividinislistas);

                                    suma += ndivertinimailist[i][j];
                                }

                                Console.WriteLine("Iveskite egzamino rezultata");
                                egzaminoivertinimas = Double.Parse(Console.ReadLine());
                                egzaminorezdoublelist.Add(egzaminoivertinimas);

                                break;

                            case 2:
                                //Generuoti skaicius
                                Console.WriteLine("Generavimas");

                                for (int j = 0; j < ndkiekis; j++)
                                {
                                    ndivertinimas = ndivertinimasrandom.Next(1, 10);
                                    ndivertimaividinislistas.Add(ndivertinimas);
                                    ndivertinimailist.Add(ndivertimaividinislistas);

                                    suma += ndivertinimailist[i][j];
                                }
                                
                                egzaminoivertinimas = ndivertinimasrandom.Next(1, 10);
                                egzaminorezdoublelist.Add(egzaminoivertinimas);

                                break;
                        }

                        vidurkis = (suma / ndkiekis);
                        arsklyginis = ndkiekis % 2;
                        if (arsklyginis == 0)
                        {
                            //kai n elementai lyginis skaicius
                            vidurioid = ndkiekis / 2;
                            mediana = (ndivertinimailist[i][vidurioid - 1]) + (ndivertinimailist[i][vidurioid]) / 2;
                        }
                        else
                        {
                            //kai n elementai nelyginis skaicius
                            vidurioid = ndkiekis / 2;
                            mediana = ndivertinimailist[i][vidurioid];
                        }

                        galutinisdoublelist.Add((0.3 * vidurkis) + (0.7 * egzaminoivertinimas));
                        galutinismedianadoublelist.Add((0.3 * mediana) + (0.7 * egzaminoivertinimas));
                    }

                    Console.WriteLine("Skaiciuoti galutini su vidurkiu:1, skaicciuoti galutini su mediana:2");
                    switchpasirinkimas = Console.ReadLine();
                    switch (Convert.ToInt32(switchpasirinkimas))
                    {
                        case 1:
                            //Vidurkis
                            Console.WriteLine("Vidurkis");
                            Console.WriteLine("Vardas".PadRight(10) + "Pavardė".PadRight(10) + "Galutinis (Vid.)");
                            Console.WriteLine("------------------------------------");

                            for (int i = 0; i < studentukiekis; i++)
                            {
                                Console.WriteLine(vardasstringlist[i].PadRight(10) + pavardestringlist[i].PadRight(10) + "".PadRight(11) + $"{galutinisdoublelist[i]:0.00}");
                            }
                            break;

                        case 2:
                            //Mediana
                            Console.WriteLine("Mediana");
                            Console.WriteLine("Vardas".PadRight(10) + "Pavardė".PadRight(10) + "Galutinis (Med.)");
                            Console.WriteLine("------------------------------------");

                            for (int i = 0; i < studentukiekis; i++)
                            {
                                Console.WriteLine(vardasstringlist[i].PadRight(10) + pavardestringlist[i].PadRight(10) + "".PadRight(11) + $"{galutinismedianadoublelist[i]:0.00}");
                            }
                            break;
                    }
                    break;
            }
            Console.ReadKey();
        }
    }
}