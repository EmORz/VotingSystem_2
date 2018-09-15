using System;
using System.Collections.Generic;
using System.Text;


class BSP
{
    public BSP()
    { }

    public List<string> ListCol()
    {
        List<string> col = new List<string>();

        col.Add("Елка Александрова Неделчева");
        col.Add("Илия Христов Илиев");
        col.Add("Диана Добромирова Мирчева");
        col.Add("Стоян Димитров Ненчев");
        col.Add("Таня Петрова Тодорова");
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

