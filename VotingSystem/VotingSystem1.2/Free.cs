using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


class Free
{
    private string fatme = "Фатме Селим Али";
    private string milena = "Милена Дачева Орешкова";
    private string reihan = "Рейхан Ридван Вели";
    private string qnka = "Янка Трифонова Георгиева";
    private string[] fileWorkedPlace = File.ReadAllLines(@"E:\Push\VotingSystem_2\VotingSystem\VotingSystem1.2\Free_Works.txt");

    public Free() { }

    public List<string> ListCol()
    {
        List<string> col = new List<string>();
        col.Add(fatme);
        col.Add(milena);
        col.Add(reihan);
        col.Add(qnka);
        return col;
    }

    public Dictionary<string, string> PersonalInfo()
    {
        var temp = new Dictionary<string, string>();
        Free n = new Free();
        var listCouncils = n.ListCol();
        temp.Add(listCouncils[0],fileWorkedPlace[0]);
        temp.Add(listCouncils[1],fileWorkedPlace[1]);
        temp.Add(listCouncils[2],fileWorkedPlace[2]);
        temp.Add(listCouncils[3],fileWorkedPlace[3]);
        return temp;
    }
}

