//•	Extend the previous program to support also subtraction and multiplication of polynomials.

using System;

    class SubtractingPolynomials
    {
        static decimal[] EnterPolynomial(out decimal[] polynomial)
        {
            Console.Write("Enter the polynomial degree: ");
            int degree = int.Parse(Console.ReadLine());

            polynomial = new decimal[degree + 1];

            for (int i = polynomial.Length - 1; i >= 0; i--)
            {
                Console.Write("x^" + i + ": ");
                polynomial[i] = decimal.Parse(Console.ReadLine());
            }
            return polynomial;
        }
        static void PrintPolynomial(decimal[] polynomial)
        {
            for (int i = polynomial.Length - 1; i >= 0; i--)
        {
            if (i == polynomial.Length - 1&& polynomial[i] != 0)
            {
                Console.Write("     {0}{1}x^{2} ", polynomial[i] > 0 ? "" : "-", Math.Abs(polynomial[i]), i);
            }
            else if (i == 0)
            {
                if (polynomial[i] < 0) Console.Write("{0}{1} ", "- ", -polynomial[i]);
                else if (polynomial[i] > 0) Console.Write("{0}{1} ", "+ ", polynomial[i]);
            }
            else
            {
                if (polynomial[i] < 0) Console.Write("{0}{1}x^{2} ", "- ", -polynomial[i], i);
                else if (polynomial[i] > 0) Console.Write("{0}{1}x^{2} ", "+ ", polynomial[i], i);
            }
        }
        Console.WriteLine();
        }
    
        static void Subtract(decimal[] firstPolynomial, decimal[] secondPolynomial)
        {
            int len = Math.Max(firstPolynomial.Length, secondPolynomial.Length);
            bool isFirstBigger = firstPolynomial.Length >= secondPolynomial.Length;
            bool isZero = true;

            decimal[] result = new decimal[len];

            for (int i = 0; i < len; i++)
            {
                if (i < firstPolynomial.Length && i < secondPolynomial.Length)
                {
                    result[i] = firstPolynomial[i] -secondPolynomial[i];
                    if (result[i] != 0)
                        isZero = false;
                }
                else if (isFirstBigger)
                {
                    result[i] = firstPolynomial[i];
                }
                else
                {
                    result[i] = -secondPolynomial[i];
                }
            }

            if (isZero) Console.WriteLine("The result of substracting the two polynomials is 0");
            else
            {
                Console.WriteLine("The result of substracting the two polynomials is:");
                PrintPolynomial(result);
            }
        }
        static void Multiply(decimal[] firstPolynomial, decimal[] secondPolynomial)
        {

            int len = firstPolynomial.Length + secondPolynomial.Length;
            bool isZero = true;

            decimal[] result = new decimal[len-1];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = 0;
            }

            for (int i = 0; i < firstPolynomial.Length; i++)
            {
                for (int j = 0; j < secondPolynomial.Length; j++)
                {
                    int position = i + j;

                    result[position] += (firstPolynomial[i] * secondPolynomial[j]);
                    isZero = false;
                }
            }
            if (isZero) Console.WriteLine("The result of multiplying the two polynomials is 0");
            else
            {
                Console.WriteLine("The result of multiplying the two polynomials is:");
                PrintPolynomial(result);
            }

        }

        static void Main()
        {
            decimal[] firstPolynomial = EnterPolynomial(out firstPolynomial);
            Console.Write("You've entered: ");
            PrintPolynomial(firstPolynomial);

            decimal[] secondPolynomial = EnterPolynomial(out secondPolynomial);
            Console.Write("You've entered: ");
            PrintPolynomial(secondPolynomial);

            Subtract(firstPolynomial,secondPolynomial);
            Multiply(firstPolynomial, secondPolynomial);
        }
    }
