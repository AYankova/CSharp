namespace _05.BitArray64
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class BitArray64:IEnumerable<int>
    {
        private const int Bits = 64;
        private ulong number;

        public BitArray64(ulong number)
        {
            this.Number = number;
        }

        public ulong Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public int Length
        {
            get { return Bits; }
        }

        public int this[int index]
        {
                get
            {
                if (index < 0 || index >= Bits)
                {
                    throw new IndexOutOfRangeException();
                }

                return (int)((this.Number >> index) & 1);
            }

            set
            {
                if (index < 0 || index >= Bits)
                {
                    throw new IndexOutOfRangeException();
                }

                if (value > 1 || value < 0)
                {
                    throw new ArgumentException();
                }

                if (((int)(this.Number >> index) & 1) != value)
                {
                    this.Number ^= (1u << index);
                }
            }
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !(first.Equals(second));
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < Bits; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            return this.Number.Equals((obj as BitArray64).Number);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() + this.Number.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int index = 0; index < Bits; index++)
            {
                result.Insert(0, ((this.Number >> index) & 1));
            }

            return result.ToString();
        }
    }
}
