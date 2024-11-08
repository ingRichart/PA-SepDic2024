using System;

public class CodigoFlow
{

    public static void EsPrimo(int numero)
    {
        int contador, incremento;

        contador = 0;
        incremento = 1;
        while (contador < 2 || incremento <= numero)
        {
            if (numero % incremento == 0)
            {
                contador = contador + 1;
            }
            incremento = incremento + 1;
        }
        if (contador == 2)
        {
            MessageBox.Show("El número " + numero + " es primo");
        }
        else
        {
            MessageBox.Show("El número " + numero + " NO es primo");
        }
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
