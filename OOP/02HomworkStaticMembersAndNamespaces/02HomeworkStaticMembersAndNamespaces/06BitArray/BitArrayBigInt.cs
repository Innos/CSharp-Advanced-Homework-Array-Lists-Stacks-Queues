using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BitArray
{
    class BitArrayBigInt
    {
        private int bits;
        private BigInteger number;

        public BitArrayBigInt(int bits)
        {
            this.Bits = bits;
        }
        //Property
        public int Bits
        {
            get { return this.bits; }
            private set
            {
                if(value < 1 || value > 100000)
                {
                    throw new ArgumentOutOfRangeException("value", "Bits must be between [1..100000].");
                }
                this.bits = value;
            }
        }
        //Indexation
        public int this[int index]
        {
            get
            {
                if(index < 0 || index > this.Bits - 1)
                {
                    throw new IndexOutOfRangeException(String.Format("Index must be between [0..{0}]",this.bits - 1));
                }
                if((number &((BigInteger)1<<index)) == 0)
                {
                    return 0;
                }
                return 1;
            }
            set
            {
                if(index < 0 || index > this.Bits - 1)
                {
                    throw new IndexOutOfRangeException(String.Format("Index must be between [0..{0}]", this.bits - 1));
                }
                if(value != 0 && value != 1)
                {
                    throw new ArgumentOutOfRangeException("value", "Bits can only be 0 or 1.");
                }
                this.number &= ~((BigInteger)1 << index);
                this.number |= ((BigInteger)value << index);
            }
        }
        //To string method
        public override string ToString()
        {
            return number.ToString();
        }
    }
}
