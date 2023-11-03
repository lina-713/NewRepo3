using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs14
{
    internal class Status
    {
        public int Id { get; set; }
        [DisplayName("Имя статуса")]
        public string Name { get; set; }
    }
}
