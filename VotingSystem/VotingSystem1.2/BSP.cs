using System;
using System.Collections.Generic;
using System.Text;


class BSP
{
    private string elka = "Елка Александрова Неделчева";
    private string iliq = "Илия Христов Илиев";
    private string diana = "Диана Добромирова Мирчева";
    private string stoqn = "Стоян Димитров Ненчев";
    private string tanq = "Таня Петрова Тодорова";

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

        temp.Add(listCouncils[0], "Месторабота: ОУ „Георги Сава Раковски“, с.Раковски\nОбразование: Висше - мaгистър\nСпециалност: „Филология“");
        temp.Add(listCouncils[1], "Месторабота: ОП „Паркстрой“, гр.Разград\nОбразование: Висше\nСпециалност: „География“ ");
        temp.Add(listCouncils[2], "Месторабота: Андрея ЕООД\nОбразование: Висше - мaгистър\nСпециалност: „Електроинженер“");
        temp.Add(listCouncils[3], "Месторабота: Образование: Висше - магистър\nСпециалност: Право");
        temp.Add(listCouncils[4], "Месторабота: Образование: Висше\nСпециалност: „История“");
       
        return temp;
    }
}

