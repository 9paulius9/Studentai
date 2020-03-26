using System;
using System.Collections.Generic;

namespace ipaantras
{
    public class Studentai
    {
        //Masyvui
        public static string switchpasirinkimas { get; set; }
        public static string switchfailuiskaityt { get; set; }
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
        public static List<double> galutinisvargsiukaidoublelist = new List<double>();//Listui
        public static List<double> galutiniskietiakaidoublelist = new List<double>();//Listui

        //LinkedListui
        public static LinkedList<string> vardasstringLList = new LinkedList<string>();//Listui
        public static LinkedList<string> pavardestringLList = new LinkedList<string>();//Listui
        public static LinkedList<int> ndkiekisintLList = new LinkedList<int>();//Listui
        public static LinkedList<LinkedList<int>> ndivertinimaiLList = new LinkedList<LinkedList<int>>();
        public static LinkedList<int> ndivertimaividinisLList = new LinkedList<int>();
        public static LinkedList<double> egzaminorezdoubleLList = new LinkedList<double>();//Listui
        public static LinkedList<double> galutinisdoubleLList = new LinkedList<double>();//Listui
        public static LinkedList<double> galutinismedianadoubleLList = new LinkedList<double>();//Listui
        public static LinkedList<double> galutinisvargsiukaidoubleLList = new LinkedList<double>();//Listui
        public static LinkedList<double> galutiniskietiakaidoubleLList = new LinkedList<double>();//Listui

        //Queue
        public static Queue<string> vardasstringQueue = new Queue<string>();//Listui
        public static Queue<string> pavardestringQueue = new Queue<string>();//Listui
        public static Queue<int> ndkiekisintQueue = new Queue<int>();//Listui
        public static Queue<Queue<int>> ndivertinimaiQueue = new Queue<Queue<int>>();
        public static Queue<int> ndivertimaividinisQueue = new Queue<int>();
        public static Queue<double> egzaminorezdoubleQueue = new Queue<double>();//Listui
        public static Queue<double> galutinisdoubleQueue = new Queue<double>();//Listui
        public static Queue<double> galutinismedianadoubleQueue = new Queue<double>();//Listui
        public static Queue<double> galutinisvargsiukaidoubleQueue = new Queue<double>();//Listui
        public static Queue<double> galutiniskietiakaidoubleQueue = new Queue<double>();//Listui


        //Failui skaityt

        public static int count { get; set; }
        public static int eilutes { get; set; }
        public static int temp { get; set; }
        public static string line { get; set; }
        public static string[] wordas { get; set; }
        public static int ndskaicius { get; set; }
        public static string failovardas { get; set; }

        public static List<string> vardaaaaaas = new List<string>();
        public static List<string> vardas = new List<string>();
        public static List<string> pavarde = new List<string>();
        public static List<string> darbai = new List<string>();
        public static List<string> egzas = new List<string>();
        public static List<string> zodziai = new List<string>();

        public static LinkedList<string> vardaaaaaasLList = new LinkedList<string>();
        public static LinkedList<string> vardasLList = new LinkedList<string>();
        public static LinkedList<string> pavardeLList = new LinkedList<string>();
        public static LinkedList<string> darbaiLList = new LinkedList<string>();
        public static LinkedList<string> egzasLList = new LinkedList<string>();
        public static LinkedList<string> zodziaiLList = new LinkedList<string>();

        public static Queue<string> vardaaaaaasQueue = new Queue<string>();
        public static Queue<string> vardasQueue = new Queue<string>();
        public static Queue<string> pavardeQueue = new Queue<string>();
        public static Queue<string> darbaiQueue = new Queue<string>();
        public static Queue<string> egzasQueue = new Queue<string>();
        public static Queue<string> zodziaiQueue = new Queue<string>();

    }

}

