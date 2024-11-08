using System;

public class CodigoFlow
{

    public static decimal Media(decimal num1, decimal num2)
    {
        decimal resul;

        resul = (num1 + num2) / 2;

        return resul;
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
