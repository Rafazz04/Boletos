using System.Text.RegularExpressions;

namespace BoletosCrud.Utils;

public static class Util
{
    public static string LimpaFormatacaoDocumento(string documento)
    {
        return documento.Replace(".", "").Replace("-", "").Replace("/", "");
    }
    public static string RemoverEspacosIgnoreCase(string input)
    {
        if (input == null)
            return null;

        return Regex.Replace(input.Trim(), @"\s+", string.Empty, RegexOptions.IgnoreCase);
    }
}
