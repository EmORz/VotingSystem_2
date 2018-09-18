using System;
using System.Collections.Generic;
using System.Text;


class Free
{
    private string fatme = "Фатме Селим Али";
    private string milena = "Милена Дачева Орешкова";
    private string reihan = "Рейхан Ридван Вели";
    private string qnka = "Янка Трифонова Георгиева";

   
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

        temp.Add(listCouncils[0], "Месторабота: ОП „Паркстрой“ гр.Разград\nОбразование: Висше\nСпециалност: Инженер - педагог ");
        temp.Add(listCouncils[1], "Месторабота: ОУ „Иван С. Тургенев“ гр. Разград\nОбразование: Висше –магистър\nСпециалност: История, философия, политология, организация и управлени ");
        temp.Add(listCouncils[2], "Месторабота: „Елит Сат Нет“ ООД, гр.Русе\nОбразование: Висше - магистър\nСпециалност: Компютърни системи и мрежи");
        temp.Add(listCouncils[3], "Месторабота: „Домашен социален патронаж“\nОбразование: Висше - магистър\nСпециалност: „Социален мениджмънт“ ");
        return temp;
    }
}

