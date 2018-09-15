using System;
using System.Collections.Generic;
using System.Text;

class DPS
{
    public DPS()
    { }

    public List<string> ListCol()
    {
        List<string> col = new List<string>();

        col.Add("Левент Али Апти");
        col.Add("Ахтер Исметов Чилев");
        col.Add("Емине Бейти Хасан");
        col.Add("Фатме Зелкиф Емин");
        col.Add("Хами Ибрахимов Хамиев");
        col.Add("Хасан Халилов Хасанов");

        return col;
    }
    public Dictionary<string, string> PersonalInfo()
    {
        var temp = new Dictionary<string, string>();
        DPS n = new DPS();
        var listCouncils = n.ListCol();
        temp.Add(listCouncils[0], "Месторабота: МБАЛ „Св. Иван Рилски“ гр. Разград\nОбразование: Висше - медицина\nСпециалност: „Анестезиология и интензивно лечение“");
        temp.Add(listCouncils[1], "Месторабота: Д-р „Чилев Дент АПМП-ИП“ ЕООД\nОбразование: Висше - магистър\nСпециалност: „Дентална медицина“ ");
        temp.Add(listCouncils[2], "Месторабота: „ХИЕМ“ ЕООД, с.Дянково\nОбразование: Средно - специално\nСпециалност: „Икономика“");
        temp.Add(listCouncils[3], "Месторабота: Образование: Средно образование");
        temp.Add(listCouncils[4], "Месторабота: „Фус Агро“ ООД, гр. Русе\nОбразование: Висше - магистър\nСпециалност: Агроном");
        temp.Add(listCouncils[5], "Месторабота: Образование: Висше - бакалавър\nСпециалност: Учител математика и физика");
        return temp;
    }
}

