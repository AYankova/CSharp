namespace Substring
{
    using System;
    using System.Text;

    public static class SubstringClass
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            StringBuilder result = new StringBuilder(length);

            if (index < 0 || index > sb.Length-1)
            {
                throw new IndexOutOfRangeException("Index is outside the boundaries of the string!");
            }

            if (length < 0 || length + index > sb.Length-1)
            {
                throw new ArgumentOutOfRangeException("Length comes outside the boundaries of the string!");
            }

            for (int i = index; i < length + index; i++)
			{
			 result.Append(sb[i]);
			}

            return result;
        }

        public static StringBuilder Substring(this StringBuilder sb, int index)
        {
            StringBuilder result = new StringBuilder();

            if (index < 0 || index > sb.Length - 1)
            {
                throw new IndexOutOfRangeException("Index is outside the boundaries of the string!");
            }

            for (int i = index; i <  sb.Length; i++)
            {
                result.Append(sb[i]);
            }

            return result;
        }
    }
}
