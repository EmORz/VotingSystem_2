using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class KauzaRz
{
    private string bojinel = "Божинел Василев Христов";
    private string vladimir = "Владимир Димитров Димитров";
    private string kaloqn = "Калоян Руменов Монев";
    private string[] fileWorkedPlace = File.ReadAllLines(@"E:\Push\VotingSystem_2\VotingSystem\VotingSystem1.2\Kauza_Works.txt");

    public KauzaRz() { }

    public List<string> ListCol()
    {
        List<string> col = new List<string>();

        col.Add(bojinel);
        col.Add(vladimir);
        col.Add(kaloqn);
        return col;
    }
    public Dictionary<string, string> PersonalInfo()
    {
        var temp = new Dictionary<string, string>();
        KauzaRz n = new KauzaRz();
        var listCouncils = n.ListCol();

        temp.Add(listCouncils[0], fileWorkedPlace[0]);
        temp.Add(listCouncils[1], fileWorkedPlace[1]);
        temp.Add(listCouncils[2], fileWorkedPlace[2]);
        return temp;
    }
}

