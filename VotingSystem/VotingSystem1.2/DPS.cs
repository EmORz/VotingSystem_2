using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class DPS
{
    private string levent = "Левент Али Апти";
    private string ahter = "Ахтер Исметов Чилев";
    private string emine = "Емине Бейти Хасан";
    private string fatme = "Фатме Зелкиф Емин";
    private string hami = "Хами Ибрахимов Хамиев";
    private string hasan = "Хасан Халилов Хасанов";
    private string[] fileWorkedPlace = File.ReadAllLines(@"E:\Push\VotingSystem_2\VotingSystem\VotingSystem1.2\DPS_Works.txt");


    public DPS()
    { }

    public List<string> ListCol()
    {
        List<string> col = new List<string>();

        col.Add(levent);
        col.Add(ahter);
        col.Add(emine);
        col.Add(fatme);
        col.Add(hami);
        col.Add(hasan);

        return col;
    }
    public Dictionary<string, string> PersonalInfo()
    {
        var temp = new Dictionary<string, string>();
        DPS n = new DPS();
        var listCouncils = n.ListCol();
        temp.Add(listCouncils[0], fileWorkedPlace[0]);
        temp.Add(listCouncils[1], fileWorkedPlace[1]);
        temp.Add(listCouncils[2], fileWorkedPlace[2]);
        temp.Add(listCouncils[3], fileWorkedPlace[3]);
        temp.Add(listCouncils[4], fileWorkedPlace[4]);
        temp.Add(listCouncils[5], fileWorkedPlace[5]);
        return temp;
    }
}

