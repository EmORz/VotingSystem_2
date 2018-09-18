using System.Collections.Generic;


class GERB
{
    private string nadejda = "Надежда Радославова Димитрова";
    private string radiana = "Радиана Ангелова Димитрова";
    private string valentina = "Валентина Маркова Френкева";
    private string galin = "Галин Пенчев Парашкевов";
    private string gulver = "Гюлвер Исмаил Хасан";
    private string marian = "Мариан Пламенов Иванов";
    private string marina = "Марина Петрова Христова";
    private string nasko = "Наско Стоилов Анастасов";
    private string svetoslav = "Светослав Теофилов Банков";
    private string stefan = "Стефан Димов Стефанов";


    public GERB() { }

    public  List<string> ListCol ()
    {
        List<string> col = new List<string>();

        col.Add(radiana);
        col.Add(valentina);
        col.Add(galin);
        col.Add(gulver);
        col.Add(marian);
        col.Add(marina);
        col.Add(nadejda);
        col.Add(nasko);
        col.Add(svetoslav);
        col.Add(stefan);
        return col;
    }

    public Dictionary<string, string> PersonalInfo()
    {
        var temp = new Dictionary<string, string>();
        temp.Add(radiana, "Месторабота: „ЗД Евроинс” АД София\nОбразование: Висше - магистър\nСпециалност: Икономист, инженер - химик");
        temp.Add(valentina, "Месторабота: Областна Дирекция „Земеделие“ Разград\nОбразование: Висше - магистър\nСпециалност: „Управление на международни бизнес проекти“");
        temp.Add(galin, "Месторабота: СОУ „Христо Ботев“ гр. Разград\nОбразование: Висше\nСпециалност: „Начална педагогика“");
        temp.Add(gulver, "Месторабота: Руж-Дил ЕООД, с.Ясеновец Образование: Средно Специалност: Елетротехник");
        temp.Add(marian, "Месторабота: „СТМ-Вита“ гр.Разград\nОбразование: Висше - бакалавър\nСпециалност: „Индустриален - мениджмънт“");
        temp.Add(marina, "Месторабота: „Биовет“ Разград\nОбразование: Висше - магистър\nСпециалност: „Аграрна икономика“");
        temp.Add(nadejda, "Месторабота: Председател на Общински съвет\nОбразование: Висше\nСпециалност: Музикална педагогика");
        temp.Add(nasko, "Месторабота: „Виталис“ ЕООД, гр. Разград\nОбразование: Висше\nСпециалност: инженер - слаботокова система");
        temp.Add(svetoslav, "Месторабота:\nОбразование: висше\nСпециалност: „Технология на храните“");
        temp.Add(stefan, "Месторабота: „Холидей Н.Ю.С“ ООД\nОбразование: Висше - магистър\nСпециалност: Технология на силикатите");
        return temp;
    }



}

