using System;
using System.Collections.Generic;

namespace ipaantras
{
    public class Studentai
    {
        //Masyvui
        public static string switchpasirinkimas { get; set; }
        public static int studentukiekis { get; set; }
        public static int ndkiekis { get; set; }
        public static int ndivertinimas { get; set; }
        public static double suma { get; set; }
        public static double vidurkis { get; set; }
        public static int studentoi { get; set; }
        public static double arsklyginis { get; set; }
        public static int vidurioid { get; set; }
        public static double mediana { get; set; }
        public static double egzaminoivertinimas { get; set; }

        string[] vardasstringarray;//Masyvui
        string[] pavardestringarray;//Masyvui
        int[] ndkiekisintarray;//Masyvui
        int[,] ndivertinimaiintarray;//Masyvui
        double[] egzaminorezdoublearray;//Masyvui
        double[] galutinisdoublearray;//Masyvui
        double[] galutinismedianadoublearray;//Masyvui

        public static Random ndivertinimasrandom = new Random();

        //Listui
        public static List<string> vardasstringlist = new List<string>();//Listui
        public static List<string> pavardestringlist = new List<string>();//Listui
        public static List<int> ndkiekisintlist = new List<int>();//Listui
        public static List<List<int>> ndivertinimailist = new List<List<int>>();
        public static List<int> ndivertimaividinislistas = new List<int>();
        public static List<double> egzaminorezdoublelist = new List<double>();//Listui
        public static List<double> galutinisdoublelist = new List<double>();//Listui
        public static List<double> galutinismedianadoublelist = new List<double>();//Listui

        //Failui skaityt

        public static int count { get; set; }
        public static int eilutes { get; set; }
        public static int temp { get; set; }
        public static string line { get; set; }
        public static string[] wordas { get; set; }
        public static int ndskaicius { get; set; }

        public static List<string> vardaaaaaas = new List<string>();
        public static List<string> vardas = new List<string>();
        public static List<string> pavarde = new List<string>();
        public static List<string> darbai = new List<string>();
        public static List<string> egzas = new List<string>();
        public static List<string> zodziai = new List<string>();

    }

    }

