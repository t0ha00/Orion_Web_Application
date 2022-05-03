using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataAccessLibrary.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public int Код { get; set; }
        public string? ФИО { get; set; }
        public int? ТН { get; set; }
        public string? Логин { get; set; }
        public string? Пароль { get; set; }
        public int? Код_филиала { get; set; }
        public int? Запись_удалена { get; set; }
        public bool Ответственный_за_группы { get; set; }
        public int Уровень { get; set; }
        public string? Должность { get; set; }
        public bool? Подписант { get; set; }
        public string? Почта { get; set; }
        public string? Код_WT { get; set; }
        public string? ТП { get; set; }
    }
}
