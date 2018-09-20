using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace VotingSystem1._2
{
    class Program
    {
        const byte all = 33;
        const string path = @"E:\CSharpAdvanced\VotingSystem1.2\VotingSystem\VotingSystem1.2\DataCollection.txt";
        public static string text = "Персонална информация за съветниците. Изберете политическа група";
        public static string text1 = "Персонална информация за съветниците. Изберете съветник:";
        public static string label = "..................................................";
        public static List<string> politicanGroup = new List<string>();
        public static Dictionary<string, List<string>> delegateByPolitician = new Dictionary<string, List<string>>();
        public static List<string> kvorum = new List<string>();

        public static List<string> gerbB = new List<string>();
        public static List<string> bspB = new List<string>();
        public static List<string> dpsB = new List<string>();
        public static List<string> reformB = new List<string>();
        public static List<string> kauzaB = new List<string>();
        public static List<string> freeB = new List<string>();

        static void Main(string[] args)
        {
            politicanGroup.Add("ГЕРБ");
            politicanGroup.Add("БСП");
            politicanGroup.Add("ДПС");
            politicanGroup.Add("Реформаторкси блоk");
            politicanGroup.Add("Кауза Разград");
            politicanGroup.Add("Независими съветници");
            //
            GERB gerbb = new GERB();
            BSP bspp = new BSP();
            DPS dpss = new DPS();
            KauzaRz kauzaa = new KauzaRz();
            Free freee = new Free();
            ReformBlog reformBlogg = new ReformBlog();
  
            //
            Labelnfo1();
            var enter = Console.ReadLine();
            if (enter == "0")
            {
                PrintInfoForProgram();
                var allCouncilMan = gerbb.ListCol().Concat(bspp.ListCol().Concat(dpss.ListCol().Concat(kauzaa.ListCol().Concat(freee.ListCol().Concat(reformBlogg.ListCol())))));
                string[] allCouncilArr = allCouncilMan.ToArray();
                //
                string[] toName = allCouncilArr;
                List<string> take = toName.ToList();
                //
                var gerb = gerbb.ListCol();
                var bsp = bspp.ListCol();
                var dps = dpss.ListCol();
                var reforma = reformBlogg.ListCol();
                var nezavisim = freee.ListCol();
                var kauza = kauzaa.ListCol();

                byte count = 0;
                //Kvorum => string za potvyrjdenie => Tuk
                for (int person = 0; person < all; person++)
                {
                    Console.Write(toName[person] + " => ");
                    var checking = Console.ReadLine();
                    Console.WriteLine(checking);
                    File.AppendAllText(path, "Кворум:");

                    if (checking == "tuk")
                    {
                        count++;
                        kvorum.Add($"{toName[person]}");
                        File.AppendAllText(path, toName[person]);
                        take.Remove(toName[person]);
                        GetValueOfCalculate(toName, gerb, person, gerbB);
                        GetValueOfCalculate(toName, bsp, person, bspB);
                        GetValueOfCalculate(toName, dps, person, dpsB);
                        GetValueOfCalculate(toName, reforma, person, reformB);
                        GetValueOfCalculate(toName, nezavisim, person, freeB);
                        GetValueOfCalculate(toName, kauza, person, kauzaB);
                    }
                }
                var result = kvorum.Count > 16 ? "Има кворум" : $"Няма кворум, нужни са още/поне {16 - kvorum.Count} гласа!";
                File.AppendAllText(path, result);
                Console.WriteLine(label);
                Console.WriteLine("Присъстват по партийни групи:");
                File.AppendAllText(path, "Присъстват по партийни групи:");
                var message = "Няма регистрирани съветници";
                Console.WriteLine(politicanGroup[0]);
                Console.WriteLine(gerbB.Count>0? string.Join("=>\n", gerbB):message);            
                Console.WriteLine(politicanGroup[1]);             
                Console.WriteLine(bspB.Count>0? string.Join("=>\n", bspB):message);               
                Console.WriteLine(politicanGroup[2]);
                Console.WriteLine(dpsB.Count>0? string.Join("=>\n", dpsB): message);
                Console.WriteLine(politicanGroup[3]);
                Console.WriteLine(reformB.Count>0? string.Join("=>\n", reformB):message);
                Console.WriteLine(politicanGroup[4]);
                Console.WriteLine(kauzaB.Count>0? string.Join("=>\n", kauzaB):message);
                Console.WriteLine(politicanGroup[5]);
                Console.WriteLine(freeB.Count>0? string.Join("=>\n", freeB):message);       
                Console.WriteLine(label);
                Console.WriteLine($"Гласували общо: {count}");
                File.AppendAllText(path, $"Гласували общо: {count}" + "\n");
                Console.WriteLine($"{result}");
                File.AppendAllText(path, $"{result}" + "\n");
                Console.WriteLine($"Присъстват следните съветници: "+kvorum.Count+"Общ брой на регистрираните");
                for (int i = 0; i < kvorum.Count; i++)
                {
                    Console.WriteLine($"{i} => {kvorum[i]}");
                }
                File.AppendAllText(path, $"Присъстват следните съветници => \n" + string.Join($"\n=>", kvorum));
                Console.WriteLine($"Отсъстват следните съветници => "+take.Count+" => Общ брой на отсъстващите");
                File.AppendAllText(path, $"Отсъстват следните съветници => "+take.Count);                
                for (int i = 0; i < take.Count; i++)
                {
                    Console.WriteLine($"{i} => {take[i]}");                   
                    File.AppendAllText(path, $"{i} => {take[i]}" + "\n");
                }
                Console.WriteLine(label);
                Dictionary<byte, string> positive = new Dictionary<byte, string>();
                Dictionary<byte, string> negative = new Dictionary<byte, string>();
                Dictionary<byte, string> neutral = new Dictionary<byte, string>();
                byte a = 1; byte b = 1; byte c = 1; ;
                if (kvorum.Count > 16)
                {
                    Console.WriteLine("Заседанието има кворум и докладните могат да се гласуват!");
                    File.AppendAllText(path, "Заседанието има кворум и докладните могат да се гласуват!" + "\n");

                    //работи се с лист от кворума => приема се до доказване на противното, 
                    //че за да се приеме докладна трябва да има >50% от гласовете на делегатите.
                    Console.WriteLine("Желате ли да започнете гласуването? Yes/No" + $"\nИмате кворум от => {kvorum.Count} делегата!");
                    File.AppendAllText(path, "Желате ли да започнете гласуването? Yes/No" + $"\nИмате кворум от => {kvorum.Count} делегата!" + "\n");
                    var askAction = Console.ReadLine();
                    var gerbCountN = new byte[3] { 0, 0, 0 };
                    var bspCountN = new byte[3] { 0, 0, 0 };
                    var dpsCountN = new byte[3] { 0, 0, 0 };
                    var reformaCountN = new byte[3] { 0, 0, 0 };
                    var kauzaCountN = new byte[3] { 0, 0, 0 };
                    var freeCountN = new byte[3] { 0, 0, 0 };
                    while (askAction != "No")
                    {
                        for (int i = 0; i < kvorum.Count; i++)
                        {
                            Console.Write(kvorum[i] + " => ");
                            var voting = Console.ReadLine();
                            Console.WriteLine(voting);
                            byte n = 0;
                            if (voting == "z")
                            {
                                positive.Add(a, kvorum[i]);

                                GetV(kvorum, gerb, gerbCountN, i);
                                GetV(kvorum, bsp, bspCountN, i);
                                GetV(kvorum, dps, dpsCountN, i);
                                GetV(kvorum, reforma, reformaCountN, i);
                                GetV(kvorum, nezavisim, freeCountN, i);
                                GetV(kvorum, kauza, kauzaCountN, i);
                                a++;
                            }
                            if (voting == "p")
                            {
                                negative.Add(b, kvorum[i]);
                                GetV2(kvorum, gerb, gerbCountN, i);
                                GetV2(kvorum, bsp, bspCountN, i);
                                GetV2(kvorum, dps, dpsCountN, i);
                                GetV2(kvorum, nezavisim, freeCountN, i);
                                GetV2(kvorum, reforma, reformaCountN, i);
                                GetV2(kvorum, kauza, kauzaCountN, i);
                                b++;
                            }
                            if (voting == "v")
                            {
                                neutral.Add(c, kvorum[i]);
                                GetV3(kvorum, gerb, gerbCountN, i);
                                GetV3(kvorum, bsp, bspCountN, i);
                                GetV3(kvorum, dps, dpsCountN, i);
                                GetV3(kvorum, nezavisim, freeCountN, i);
                                GetV3(kvorum, reforma, reformaCountN, i);
                                GetV3(kvorum, kauza, kauzaCountN, i);
                                c++;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        Console.WriteLine(label);
                        Console.WriteLine("Резултат от гласуването =>");

                        Console.WriteLine("За");
                        File.AppendAllText(path, "За" + "\n");
                        if (positive.Count() != 0)
                        {
                            foreach (var za in positive)
                            {
                                Console.Write($"{za.Key} => ");
                                foreach (var item in za.Value)
                                {
                                    Console.Write($"{item}");
                                    File.AppendAllText(path, $"{item}");
                                }
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.Write(" => " + 0);
                        }
                        Console.WriteLine("Против");
                        File.AppendAllText(path, "Против" + "\n");
                        if (negative.Count() != 0)
                        {
                            foreach (var protiv in negative)
                            {
                                Console.Write($"{protiv.Key} => ");
                                foreach (var item in protiv.Value)
                                {
                                    Console.Write(item);
                                    File.AppendAllText(path, item.ToString());
                                }
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.Write(" => " + 0);
                        }
                        Console.WriteLine("Въздържал се");
                        File.AppendAllText(path, "Въздържал се" + "\n");
                        if (neutral.Count() != 0)
                        {
                            foreach (var pass in neutral)
                            {
                                Console.Write($"{pass.Key} => ");
                                foreach (var item in pass.Value)
                                {
                                    Console.Write(item);
                                    File.AppendAllText(path, item.ToString());

                                }
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.Write(" => " + 0);
                        }
                        Console.WriteLine(label);

                        var isOk = positive.Count() > kvorum.Count / 2;
                        var p = positive.Count() == 0 ? 0 : positive.Count();
                        var nega = negative.Count() == 0 ? 0 : negative.Count();
                        var neutr = neutral.Count() == 0 ? 0 : neutral.Count();

                        Console.WriteLine(label);

                        if (isOk)
                        {
                            Console.WriteLine("Докладната се приема!");
                            File.AppendAllText(path, "Докладната се приема!");
                            VotingRezult(p, nega, neutr);
                        }
                        else
                        {
                            Console.WriteLine("Докладната се отхвърля!");
                            File.AppendAllText(path, "Докладната се отхвърля!\n");
                            VotingRezult(p, nega, neutr);
                        }
                        Console.WriteLine(label);
                        Console.WriteLine("По политически групи:");
                        File.AppendAllText(path, "По политически групи:\n");
                        Console.WriteLine(label);
                        Console.WriteLine("За");
                        File.AppendAllText(path, "За\n");
                        Print(gerbCountN[0], bspCountN[0], dpsCountN[0], reformaCountN[0], kauzaCountN[0], freeCountN[0]);
                        AddToArchive(gerbCountN[0], bspCountN[0], dpsCountN[0], reformaCountN[0], kauzaCountN[0], freeCountN[0]);
                        //
                        Console.WriteLine("Против");
                        File.AppendAllText(path, "Против");
                        Print(gerbCountN[1], bspCountN[1], dpsCountN[1], reformaCountN[1], kauzaCountN[1], freeCountN[1]);
                        AddToArchive(gerbCountN[1], bspCountN[1], dpsCountN[1], reformaCountN[1], kauzaCountN[1], freeCountN[1]);
                        //
                        Console.WriteLine("Въздържал се:");
                        File.AppendAllText(path, "Въздържал се:");
                        Print(gerbCountN[2], bspCountN[2], dpsCountN[2], reformaCountN[2], kauzaCountN[2], freeCountN[2]);
                        AddToArchive(gerbCountN[2], bspCountN[2], dpsCountN[2], reformaCountN[2], kauzaCountN[2], freeCountN[2]);
                        Console.WriteLine(label);
                        File.AppendAllText(path, DateTime.Now.ToString() + "\n");
                        Console.ReadKey();
                        Console.WriteLine("Желате ли да започнете ново гласуване ? Yes/No");
                        //зануляване на стойностите.
                        positive.Clear();
                        neutral.Clear();
                        negative.Clear();
                        for (int i = 0; i < gerbCountN.Length; i++)
                        {
                            gerbCountN[i] = 0;
                        }
                        for (int i = 0; i < bspCountN.Length; i++)
                        {
                            bspCountN[i] = 0;
                        }
                        for (int i = 0; i < dpsCountN.Length; i++)
                        {
                            dpsCountN[i] = 0;
                        }
                        for (int i = 0; i < reformaCountN.Length; i++)
                        {
                            reformaCountN[i] = 0;
                        }
                        for (int i = 0; i < kauzaCountN.Length; i++)
                        {
                            kauzaCountN[i] = 0;
                        }
                        for (int i = 0; i < freeCountN.Length; i++)
                        {
                            freeCountN[i] = 0;
                        }
                        askAction = Console.ReadLine();
                    }
                }
                Console.ReadKey();
            }
            if (enter == "1")
            {
                PrintAddInfoForProgram();
            }
            if (enter == "2")
            {
                Console.WriteLine(text);
                Console.WriteLine(string.Join("\n", politicanGroup));
                var input = Console.ReadLine();

                if (input == politicanGroup[0])
                {
                    GERB personal = new GERB();
                    var infoToChoose = personal.PersonalInfo();
                    Console.WriteLine(text1);
                    Console.WriteLine(string.Join("\n", infoToChoose.Keys));
                    GetPersonalInfo(infoToChoose);
                    return;
                }
                if (input == politicanGroup[1])
                {
                    BSP personal = new BSP();
                    var infoToChoose = personal.PersonalInfo();
                    Console.WriteLine(text1);
                    Console.WriteLine(string.Join("\n", infoToChoose.Keys));
                    GetPersonalInfo(infoToChoose);
                    return;

                }
                if (input == politicanGroup[2])
                {
                    DPS personal = new DPS();
                    var infoToChoose = personal.PersonalInfo();
                    Console.WriteLine(text1);
                    Console.WriteLine(string.Join("\n", infoToChoose.Keys));
                    GetPersonalInfo(infoToChoose);
                    return;
                }
                if (input == politicanGroup[4])
                {
                    KauzaRz personal = new KauzaRz();
                    var infoToChoose = personal.PersonalInfo();
                    Console.WriteLine(text1);
                    Console.WriteLine(string.Join("\n", infoToChoose.Keys));
                    GetPersonalInfo(infoToChoose);
                    return;
                }
                if (input == politicanGroup[5])
                {
                    Free personal = new Free();
                    var infoToChoose = personal.PersonalInfo();
                    Console.WriteLine(text1);
                    Console.WriteLine(string.Join("\n", infoToChoose.Keys));
                    GetPersonalInfo(infoToChoose);
                    return;
                }
                if (input == politicanGroup[3])
                {
                    ReformBlog personal = new ReformBlog();
                    var infoToChoose = personal.PersonalInfo();
                    Console.WriteLine(text1);
                    Console.WriteLine(string.Join("\n", infoToChoose.Keys));
                    GetPersonalInfo(infoToChoose);
                    return;
                }
            }
            if (enter == "3")
            {
                Console.WriteLine("Благодарим Ви, че използвате Системата!");
            }
        }

        private static void GetValueOfCalculate(string[] toName, List<string> gerb, int person, List<string> temporal)
        {
            if (gerb.Contains(toName[person]))
            {
                temporal.Add(toName[person]);
            }
        }

        private static void GetPersonalInfo(Dictionary<string, string> infoToChoose)
        {
            while (true)
            {
                var personalChoose = Console.ReadLine();

                if (infoToChoose.ContainsKey(personalChoose))
                {
                    foreach (var item in infoToChoose)
                    {
                        if (item.Key == personalChoose)
                        {
                            Console.WriteLine(item.Value);
                            Console.WriteLine("Искате ли да продължите с друг съветник? y/n");
                            personalChoose = (Console.ReadLine());
                            if (personalChoose == "y")
                            {
                                continue;
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                }
            }
        }

        private static void AddToArchive(byte gerbCountN, byte bspCountN, byte dpsCountN, byte reformaCountN, byte kauzaCountN, byte freeCountN)
        {
            File.AppendAllText(path, politicanGroup[0] + gerbCountN + "\n");
            File.AppendAllText(path, politicanGroup[1] + bspCountN + "\n");
            File.AppendAllText(path, politicanGroup[2] + dpsCountN + "\n");
            File.AppendAllText(path, politicanGroup[3] + reformaCountN + "\n");
            File.AppendAllText(path, politicanGroup[4] + kauzaCountN + "\n");
            File.AppendAllText(path, politicanGroup[5] + freeCountN + "\n");
        }

        private static void VotingRezult(int p, int nega, int neutr)
        {
            Console.WriteLine(p + " ЗА");
            File.AppendAllText(path, p + " ЗА\n");
            Console.WriteLine(nega + " Против");
            File.AppendAllText(path, nega + " Против\n");
            Console.WriteLine(neutr + " Въздържал се");
            File.AppendAllText(path, neutr + " Въздържал се\n");
        }

        private static void Labelnfo1()
        {
            Console.WriteLine("Искате ли да започнете работа със Системата?");

            Console.WriteLine("за да започнете работа натиснете =>       0");
            Console.WriteLine("за повече информация натиснете   =>       1 ");
            Console.WriteLine("за Персонална информация за съветниците натиснете  =>       2 ");
            Console.WriteLine("за изход от Системата натиснете  =>       3 ");
        }

        private static void GetV3(List<string> kvorum, List<string> gerb, byte[] gerbCountN, int i)
        {
            if (gerb.Contains(kvorum[i]))
            {
                gerbCountN[2]++;
            }
        }
        private static void GetV2(List<string> kvorum, List<string> gerb, byte[] gerbCountN, int i)
        {
            if (gerb.Contains(kvorum[i]))
            {
                gerbCountN[1]++;
            }
        }
        private static void GetV(List<string> kvorum, List<string> gerb, byte[] gerbCountN, int i)
        {
            if (gerb.Contains(kvorum[i]))
            {
                gerbCountN[0]++;
            }
        }
        private static void Print(byte gerbCountN, byte bspCountN, byte dpsCountN, byte reformaCountN,byte kauzaCountN, byte freeCountN)
        {
            Console.WriteLine($"{politicanGroup[0]} => " + gerbCountN);
            Console.WriteLine($"{politicanGroup[1]} => " + bspCountN);
            Console.WriteLine($"{politicanGroup[2]} => " + dpsCountN);
            Console.WriteLine($"{politicanGroup[3]} => " + reformaCountN);
            Console.WriteLine($"{politicanGroup[4]} => " + kauzaCountN);
            Console.WriteLine($"{politicanGroup[5]} => " + freeCountN);
        }
        private static void GetVote(List<string> kvorum, List<string> data, byte[] f, int i, byte n)
        {
            if (data.Contains(kvorum[i]))
            {
                f[n]++;
            }
        }
        public static string PathToStorageFile()
        {
            return @"E:\CSharpAdvanced\VotingSystem\VotingSystem1.2\DataCollection.txt";
        }
        private static void PrintInfoForProgram()
        {
            var printInfo = new Info();
            Console.WriteLine(printInfo);
        }
        private static void PrintAddInfoForProgram()
        {
            var printInfo = new AddionalInformation();
            Console.WriteLine(printInfo);
        }
    }
}