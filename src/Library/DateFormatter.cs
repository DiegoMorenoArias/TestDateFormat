namespace TestDateFormat;

/// <summary>
/// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
/// </summary>
public class DateFormatter
{

    /// <summary>
    /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
    /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd". No se controla que la fecha recibida tenga el formato
    /// asumido.
    /// </summary>
    /// <param name="date">Una fecha en formato "dd/mm/yyyy".</param>
    /// <returns>La fecha convertida al formato "yyyy-mm-dd".</returns>
    public static string ChangeFormat(string date)
    {
        char [] Digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
        if (date.Length==10 && date[2]=='/' && date[5]=='/' && Digits.Contains(date[0]) && Digits.Contains(date[1]) && Digits.Contains(date[3]) && Digits.Contains(date[4]) && Digits.Contains(date[6]) && Digits.Contains(date[7]) && Digits.Contains(date[8]) && Digits.Contains(date[9]))
        { 
            return date.Substring(6) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2);
        }
        
        else
        {
            return "";
        }
    }
}
