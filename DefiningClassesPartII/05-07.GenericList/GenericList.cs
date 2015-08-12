namespace GenericList
{
    using System;
    using System.Text;

    public class GenericList<T> where T:IComparable,new ()
    {
        private T[] genericList;
        private int capacity;
        private int count = 0;

        public GenericList():this(16)
        {

        }

        public GenericList(int capacity)
        {
            this.genericList = new T[capacity];
            this.Capacity = capacity;
        }

        public int Capacity
        {
            get 
            { 
                return this.capacity;
            }

            private set 
            {
                if (value < 1)
                {
                    throw new ArgumentException("Invalid capacity!");
                }
                else
                {
                    this.capacity = value;
                }
            }
        }

        public int Count
        {
            get { return this.count; }
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException("Invalid or non-existent index!");
                }

                T result = genericList[index];
                return result;
            }
        }

        private void DoubleSize()
        {
            int newSize = 2 * this.genericList.Length;
            T[] newGenericList =new T[newSize];

            for (int i = 0; i < Count; i++)
            {
                newGenericList[i] = this.genericList[i]; 
            }

            this.genericList = newGenericList;
            this.Capacity *= 2;
        }

        public void AddElement(T element)
        {
            if (count >= genericList.Length)
            {
                this.DoubleSize();
            }

            this.genericList[count] = element;
            ++count;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Invalid or non-existent index!");
            }

            T result = genericList[index];

            for (int i = index; i < count-1; i++)
            {
                this.genericList[i] = this.genericList[i + 1];
            }

            this.genericList[count - 1] = new T();
            count--;
        }

        public void InsertAt(int index,T element)
        {
            if (index < 0 || index > count)
            {
                throw new IndexOutOfRangeException("Invalid or non-existent index!");
            }

            if (index==count)
            {
                this.AddElement(element);
            }

            if (count >= this.genericList.Length-1)
            {
                this.DoubleSize();
            }

            count++;

            for (int i = count; i > index; i--)
            {
                this.genericList[i] = this.genericList[i - 1];
            }

            this.genericList[index] = element;
        }

        public int IndexOf(T element)
        {
            for (int i = 0; i < count; i++)
            {
                if (genericList[i].Equals(element))
                {
                   return i; 
                }
            }

            return -1;
        }

        public void Clear()
        {
            this.genericList = new T[16];
            this.count = 0;
            this.Capacity = 16;
        }

        public T Min()
        {
            T min = this.genericList[0];

            for (int i = 0; i < count; i++)
            {
                if (genericList[i].CompareTo(min) < 0)
                {
                    min = this.genericList[i];
                }
            }

            return min;
        }

        public T Max()
        {
            T max = this.genericList[0];

            for (int i = 0; i < count; i++)
            {
                if (genericList[i].CompareTo(max) > 0)
                {
                    max = this.genericList[i];
                }
            }

            return max;
        }

        public override string ToString()
        {
            if (count == 0)
            {
                Console.WriteLine("The generic list is empty!");
            }

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                result.Append(i < count - 1 ? genericList[i] + ", " : genericList[i] + "");
            }

            return result.ToString();
        }
    }
}
