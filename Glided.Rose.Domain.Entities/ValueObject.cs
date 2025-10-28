using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glided.Rose.Domain.Entities
{
    public class ValueObject
    {
        public int GoldPiece { get; }

        public ValueObject(int goldPiece)
        {
            GoldPiece = goldPiece;
        }
    }
}
