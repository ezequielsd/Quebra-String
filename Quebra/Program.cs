using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string string1 = "ab cde fghi";
        string string2 = "123 45 6789";

        Console.WriteLine($"String 1 original antes da quebra: {string1} \n");
        Console.WriteLine($"String 2 original antes da quebra: {string2} \n\n");

        int tamanho = 3;
        List<string> resultado = DividirStringPorCaracteres(string1, tamanho);
        Console.WriteLine($"Resultado com tamanho {tamanho}: {string.Join(", ", resultado)}");
                
        tamanho = 2;
        resultado = DividirStringPorCaracteres(string2, tamanho);
        Console.WriteLine($"Resultado com tamanho {tamanho}: {string.Join(", ", resultado)}");
    }

    static List<string> DividirStringPorCaracteres(string texto, int tamanho)
    {
        string[] array = texto.Split(new char[] {' '});
        List<string> list = new List<string>();

        foreach (string str in array) 
        {
            if (str.Length > tamanho)
            {                
                for (int i = 0; i < str.Length; i += tamanho)
                {             
                    string parte = str.Substring(i, Math.Min(tamanho, str.Length - i));
                    list.Add(parte);
                }
            }
            else
                list.Add(str);
        }
               
        return list;
    }

}