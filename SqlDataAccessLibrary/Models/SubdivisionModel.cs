using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataAccessLibrary.Models
{
    public class SubdivisionModel
    {
        public int id { get; set; }
        public int Код { get; set; }
        public string? Имя { get; set; }
        public int Код_подчинения { get; set; }
        public string? Имя_сокр { get; set; }
    }
}
