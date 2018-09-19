using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


class ReformBlog
{
    private string mitko = "Митко Иванов Ханчев";
    private string veselin = "Веселин Валентинов Спасов";
    private string djipo = "Джипо Николов Джипов";
    private string ivo = "Иво Борисов Димитров";
    private string manuel  = "Мануел Василев Чутурков";
    private string[] fileWorkedPlace = File.ReadAllLines(@"E:\Push\VotingSystem_2\VotingSystem\VotingSystem1.2\Reforma_Works.txt");


    public ReformBlog() { }

    public List<string> ListCol()
    {
        List<string> col = new List<string>();

        col.Add(mitko);
        col.Add(veselin);
        col.Add(djipo);
        col.Add(ivo);
        col.Add(manuel);
        return col;
    }

    public Dictionary<string, string> PersonalInfo()
    {
        var temp = new Dictionary<string, string>();
        ReformBlog n = new ReformBlog();
        var listCouncils = n.ListCol();
        temp.Add(listCouncils[0],fileWorkedPlace[0]);
        temp.Add(listCouncils[1],fileWorkedPlace[1]);
        temp.Add(listCouncils[2],fileWorkedPlace[2]);
        temp.Add(listCouncils[3],fileWorkedPlace[3]);
        temp.Add(listCouncils[4],fileWorkedPlace[4]);
        return temp;
    }

}

