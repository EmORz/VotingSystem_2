using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


class BSP
{
    private string elka = "Елка Александрова Неделчева";
    private string iliq = "Илия Христов Илиев";
    private string diana = "Диана Добромирова Мирчева";
    private string stoqn = "Стоян Димитров Ненчев";
    private string tanq = "Таня Петрова Тодорова";
    private string[] fileWorkedPlace = File.ReadAllLines(@"E:\Push\VotingSystem_2\VotingSystem\VotingSystem1.2\BSP_Works.txt");


    public BSP()
    { }

    public List<string> ListCol()
    {
        List<string> col = new List<string>();

        col.Add(elka);
        col.Add(iliq);
        col.Add(diana);
        col.Add(stoqn);
        col.Add(tanq);
        return col;
    }
    public Dictionary<string, string> PersonalInfo()
    {
        var temp = new Dictionary<string, string>();
        BSP n = new BSP();
        var listCouncils = n.ListCol();

        temp.Add(listCouncils[0], fileWorkedPlace[0]);
        temp.Add(listCouncils[1], fileWorkedPlace[1]);
        temp.Add(listCouncils[2], fileWorkedPlace[2]);
        temp.Add(listCouncils[3], fileWorkedPlace[3]);
        temp.Add(listCouncils[4], fileWorkedPlace[4]);
       
        return temp;
    }
}

