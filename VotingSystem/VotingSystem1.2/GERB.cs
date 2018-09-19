using System.Collections.Generic;
using System.IO;

class GERB
{
    private string nadejda = "Надежда Радославова Димитрова";
    private string radiana = "Радиана Ангелова Димитрова";
    private string valentina = "Валентина Маркова Френкева";
    private string galin = "Галин Пенчев Парашкевов";
    private string gulver = "Гюлвер Исмаил Хасан";
    private string marian = "Мариан Пламенов Иванов";
    private string marina = "Марина Петрова Христова";
    private string nasko = "Наско Стоилов Анастасов";
    private string svetoslav = "Светослав Теофилов Банков";
    private string stefan = "Стефан Димов Стефанов";
   
    private string[] fileWorkedPlace = File.ReadAllLines(@"E:\Push\VotingSystem_2\VotingSystem\VotingSystem1.2\GERB_Works.txt");
   
    public GERB() { }

    public  List<string> ListCol ()
    {
        List<string> col = new List<string>();

        col.Add(radiana);
        col.Add(valentina);
        col.Add(galin);
        col.Add(gulver);
        col.Add(marian);
        col.Add(marina);
        col.Add(nadejda);
        col.Add(nasko);
        col.Add(svetoslav);
        col.Add(stefan);
        return col;
    }

    public Dictionary<string, string> PersonalInfo()
    {
        var temp = new Dictionary<string, string>();
        temp.Add(radiana, fileWorkedPlace[0]);
        temp.Add(valentina, fileWorkedPlace[1]);
        temp.Add(galin, fileWorkedPlace[2]);
        temp.Add(gulver, fileWorkedPlace[3]);
        temp.Add(marian, fileWorkedPlace[4]);
        temp.Add(marina, fileWorkedPlace[5]);
        temp.Add(nadejda, fileWorkedPlace[6]);
        temp.Add(nasko, fileWorkedPlace[7]);
        temp.Add(svetoslav, fileWorkedPlace[8]);
        temp.Add(stefan, fileWorkedPlace[9]);
        return temp;
    }



}

