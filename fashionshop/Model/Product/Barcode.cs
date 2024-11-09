using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fashionshop.Model.Product
{
    public class Barcode
    {
        public string value { get; }

        public Barcode(string value)
        {
            if(string.IsNullOrWhiteSpace(value))
            {
                throw new Exception("BarCode is null or empty.");
            }
            if (!value.All(char.IsDigit))
            {
                throw new Exception("Barcode must be just numbers.");
            }
            if (value.Length > 13)
            {
                throw new Exception("Barcode must have 13 digits or less.");
            }
            this.value = value;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
