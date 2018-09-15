using System;
using System.Collections.Generic;
using System.Text;

class KauzaRz
{
    public KauzaRz() { }

    public List<string> ListCol()
    {
        List<string> col = new List<string>();

        col.Add("Божинел Василев Христов");
        col.Add("Владимир Димитров Димитров");
        col.Add("Калоян Руменов Монев");
        return col;
    }
    public Dictionary<string, string> PersonalInfo()
    {
        var temp = new Dictionary<string, string>();
        KauzaRz n = new KauzaRz();
        var listCouncils = n.ListCol();

        temp.Add(listCouncils[0], "Месторабота: „Агроспектър 2000“ ООД\nОбразование: Висше\nСпециалност: „Публична администрация“");
        temp.Add(listCouncils[1], "Месторабота: „Абритус Ойл“ гр.Разград\nОбразование: Висше\nСпециалност: „Публична администрация“ ");
        temp.Add(listCouncils[2], "Месторабота: адвокат към „Адвокатска колегия“ Варна\nОбразование: Висше, Доктор по Гражданско и семейно право\nСпециалност: Право");
        return temp;
    }
}

