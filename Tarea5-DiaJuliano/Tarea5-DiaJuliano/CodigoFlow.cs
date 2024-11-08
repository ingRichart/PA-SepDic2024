using System;

public class CodigoFlow
{
    public static int DiaJuliano(int dia, int mes, int anio)
    {
        int diasJuliano, m;

        m = 1;
        diasJuliano = 0;
        while (m < mes)
        {
            if (m == 2)
            {
                if (EsBisiesto(anio))
                {
                    diasJuliano = diasJuliano + 29;
                }
                else
                {
                    diasJuliano = diasJuliano + 28;
                }
            }
            else
            {
                diasJuliano = diasJuliano + DiasMes(m);
            }
            m = m + 1;
        }
        diasJuliano = diasJuliano + dia;

        return diasJuliano;
    }

    public static int DiasMes(int mes)
    {
        int dias;

        if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
        {
            dias = 31;
        }
        else
        {
            dias = 30;
        }

        return dias;
    }

    public static bool EsBisiesto(int anio)
    {
        bool resp;

        if (anio % 4 == 0)
        {
            resp = true;
            if (anio % 100 == 0)
            {
                resp = false;
                if (anio % 400 == 0)
                {
                    resp = true;
                }
                else
                {
                    resp = false;
                }
            }
            else
            {
                resp = true;
            }
        }
        else
        {
            resp = false;
        }

        return resp;
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
