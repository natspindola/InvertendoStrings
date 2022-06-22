using System;

public static class Program
{
    public static string InverteString(this string str)
    {

        char[] chars = str.ToCharArray();

        for (int i = 0; i < str.Length / 2; i++)
        {
            char ch = chars[i];
            chars[i] = chars[str.Length - i - 1];
            chars[str.Length - i - 1] = ch;
        }

        return new string(chars);
    }

    public static void Main()
    {
        string texto = "Olá, eu sou a Natália e busco um estágio!";
        Console.WriteLine("Olá, eu sou a Natália e busco um estágio!");
        string reverse = texto.InverteString();
        Console.WriteLine(reverse);
    }
}