using System;
using System.Collections.Generic;
using System.Text;


class ReformBlog
{
    public ReformBlog() { }

    public List<string> ListCol()
    {
        List<string> col = new List<string>();

        col.Add("Митко Иванов Ханчев");
        col.Add("Веселин Валентинов Спасов");
        col.Add("Джипо Николов Джипов");
        col.Add("Иво Борисов Димитров");
        col.Add("Мануел Василев Чутурков");
        return col;
    }

    public Dictionary<string, string> PersonalInfo()
    {
        var temp = new Dictionary<string, string>();
        ReformBlog n = new ReformBlog();
        var listCouncils = n.ListCol();

        temp.Add(listCouncils[0], "Месторабота: Кооперация „Екип 7“\nОбразование: Висше - магистър\nСпециалност: Българска филология ");
        temp.Add(listCouncils[1], "Месторабота: „Разград-полиграф“ гр.Разград\nОбразование: Висше\nСпециалност:  „Мениджмънт / Управление на предприятията“ ");
        temp.Add(listCouncils[2], "Месторабота: „МАТ“ ООД\nОбразование: Висше\nСпециалност: „Строителен инженер“");
        temp.Add(listCouncils[3], "Месторабота: ЕТ Богитех – Иво Димитров Разград\nОбразование: Висше\nСпециалност: „Електроника и автоматика“");
        temp.Add(listCouncils[4], "Месторабота: ППМГ „ Акад. Н. Обрешков“\nОбразование: висше - магистър\nСпециалност: история, география, право");

        return temp;
    }

}

