using System;

public class CodigoFlow
{
    public static void LeerCaracter(string caracter)
    {

        bool esLetra, esMay, esMin;

        esLetra = EsUnaLetra(caracter);
        esMay = EsMayu(caracter);
        esMin = EsMinu(caracter);
        if (esLetra)
        {
            MessageBox.Show("Es una Letra");
        }
        else
        {
            MessageBox.Show("No es una Letra");
        }
        if (esMay)
        {
            MessageBox.Show("Es mayúscula");
        }
        else
        {
            MessageBox.Show("No es mayúscula");
        }
        if (esMin)
        {
            MessageBox.Show("Es minúscula");
        }
        else
        {
            MessageBox.Show("No es minúscula");
        }
    }

    public static bool EsMayu(string letra)
    {
        bool resultado;

        if (Char.IsUpper(letra,0))
        {
            resultado = true;
        }
        else
        {
            resultado = false;
        }

        return resultado;
    }

    public static bool EsMinu(string letra)
    {
        bool resultado;

        if ( Char.IsLower(letra, 0))
        {
            resultado = true;
        }
        else
        {
            resultado = false;
        }

        return resultado;
    }

    public static bool EsUnaLetra(string letra)
    {
        bool respuesta;

        if (Char.IsLetter(letra, 0))
        {
            respuesta = true;
        }
        else
        {
            respuesta = false;
        }

        return respuesta;
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
