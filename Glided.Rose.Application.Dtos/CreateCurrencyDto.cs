using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glided.Rose.Application.Dtos
{
    public class CreateCurrencyDto
    {
        public string Gemstone { get; set; }
        public int Quantity { get; set; }
        public string CurrencyType { get; set; }

    }
}
