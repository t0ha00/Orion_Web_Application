using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataAccessLibrary
{
    public class StudentsModel
    {
        public int Код { get; }
        public string? ФИО { get; set; }
        public string? Дата_рождения { get; set; }
        public string? ТН { get; set; }
        public string? ИНН { get; set; }
        public string? СНИЛС { get; set; }
        public string? Почта { get; set; }
        public string? Примечание { get; set; }
        public string? Тел { get; set; }
        public int? s { get; set; }
        public int? Ур_образования { get; set; }
        
    }
}
