using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataAccessLibrary.Models
{
    public class GroupModel
    {
        public int Id { get; set; }
        public int? Код { get; set; }
        public int? Код_программы { get; set; }
        public string? Программа_бучения { get; set; }
        public DateTime? Начал_обучения { get; set; }
        public DateTime? Начало_практики { get; set; }
        public DateTime? Окончание_обучения { get; set; }
        public int? Часов_теории { get; set; }
        public int? Часов_практики { get; set; }
        public string? Пояснение { get; set; }
        public bool? Закрытие { get; set; }
        public int? Код_отв { get; set; }
        public string? Оператор { get; set; }
        public string? Программа_короткое_имя { get; set; }
        public int? Тип_обучения { get; set; }
        public string? Подразделение { get; set; }
        public string? Ответственный { get; set; }
        public bool? Можно_закрывать { get; set; }
        public int? id_программы { get; set; }
        public bool? Сдан_в_архив { get; set; }
        public bool? Контроль { get; set; }
        public bool? Проверено { get; set; }
    }
}
