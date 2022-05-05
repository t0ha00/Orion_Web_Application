using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataAccessLibrary.Models
{
    public class MainGroupsTableInfoModel
    {
        public int id { get; set; }
        public string? Программа_обучения { get; set; }
        public int Учен { get; set; }
        public DateTime? Нач { get; set; }
        //Начало практики
        public DateTime? Практ { get; set; }
        public DateTime? Окончание { get; set; }
        public int? Теор { get; set; }
        //Часы практики
        public int? Час_практики { get; set; }
        //Тип обучения
        public int? Тип { get; set; }

    }
}
