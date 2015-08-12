//Write a method that adds two polynomials.
//Represent them as arrays of their coefficients.

using System;

class AddingPolynomials
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
            if (polynomial[i] != 0 && i != 0)
            {
                if (polynomial[i - 1] >= 0)
                {
                    Console.Write("{1}x^{0} + ", i, polynomial[i]);
                }
                else
                {
                    Console.Write("{1}x^{0} ", i, polynomial[i]);
                }
            }
            else if(i == 0)
            {
                Console.WriteLine(polynomial[i]);
            }
        }
        Console.WriteLine();
    }
    private static void Addition(decimal[] firstPolynomial,decimal[]secondPolynomial)
    {
        int len = Math.Max(firstPolynomial.Length, secondPolynomial.Length);
		bool isFirstBigger = firstPolynomial.Length >= secondPolynomial.Length;
		bool isZero = true;

		decimal[] result = new decimal[len];

		for (int i = 0; i < len; i++)
		{
			if (i < firstPolynomial.Length && i < secondPolynomial.Length)
			{
				result[i] = firstPolynomial[i] + secondPolynomial[i];
				if (result[i] != 0)
					isZero = false;
			}
			else if (isFirstBigger)
			{
				result[i] = firstPolynomial[i];
			}
			else
			{
				result[i] = secondPolynomial[i];
			}
		}

        if (isZero) Console.WriteLine("The result of adding the two polynomials is 0");
        else
        {
            Console.WriteLine("The result of adding the two polynomials is:");
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

        Addition(firstPolynomial, secondPolynomial);
    }
}

