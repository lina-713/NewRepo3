using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Kurs14
{
    internal class IndividualAccount
    {
        public int Id { get; set; }
        [DisplayName("Номер лицевого счета")]
        public BigInteger AccountNumber { get; set; }
        [DisplayName("Услуга")]
        public string NameService { get; set; }
    }
}
