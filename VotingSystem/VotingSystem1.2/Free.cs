using System;
using System.Collections.Generic;
using System.Text;


class Free
{
    public Free() { }
    public List<string> ListCol()
    {
        List<string> col = new List<string>();
        col.Add("Фатме Селим Али");
        col.Add("Милена Дачева Орешкова");
        col.Add("Рейхан Ридван Вели");
        col.Add("Янка Трифонова Георгиева");
        return col;
    }

    public Dictionary<string, string> PersonalInfo()
    {
        var temp = new Dictionary<string, string>();
        Free n = new Free();
        var listCouncils = n.ListCol();

        temp.Add(listCouncils[0], "Месторабота: ОП „Паркстрой“ гр.Разград\nОбразование: Висше\nСпециалност: Инженер - педагог ");
        temp.Add(listCouncils[1], "Месторабота: ОУ „Иван С. Тургенев“ гр. Разград\nОбразование: Висше –магистър\nСпециалност: История, философия, политология, организация и управлени ");
        temp.Add(listCouncils[2], "Месторабота: „Елит Сат Нет“ ООД, гр.Русе\nОбразование: Висше - магистър\nСпециалност: Компютърни системи и мрежи");
        temp.Add(listCouncils[3], "Месторабота: „Домашен социален патронаж“\nОбразование: Висше - магистър\nСпециалност: „Социален мениджмънт“ ");
        return temp;
    }
}

