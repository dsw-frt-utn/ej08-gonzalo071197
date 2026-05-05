using System;

public static class Extensions
{
    public static string ToProductCode(this string code)
    {
        if (code == null) return "SIN-CODIGO";

       
        string cleanedCode = code.Trim().ToUpper();

        
        string[] palabras = cleanedCode.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        return string.Join("-", palabras);
    }
}