using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Kurs14
{
    internal class Services
    {
        public int Id { get; set; }
        [DisplayName("Название услуги")]
        public string NameServices { get; set; }
        [DisplayName("Цена")]
        public int Price { get; set; }
        [DisplayName("Описание")]
        public string Explain { get; set; }
        [DisplayName("Количество подклчений")]
        public int CountServices { get; set; }

    }
}
