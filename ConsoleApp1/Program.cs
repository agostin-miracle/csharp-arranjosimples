
using System.Linq.Expressions;





//ProcessaArrano.PermuteRecursive(new string[] { "01", "12", "23", "34", "45", "48" }, 0);
ProcessaArrano.PermuteRecursive(new string[] { "A", "M", "O", "R" }, 0);

Console.WriteLine("Pressione qualquer tecla para continuar");
Console.ReadKey();




/// <summary>
/// Demonstrativo exemplo de implementacao de algoritmo de Arranjo Simples
/// </summary>
public static class ProcessaArrano
{
    static int iteration;
    /// <summary>
    /// Processo o arranjo do array de string em 's', com start inicial de leitura
    /// </summary>
    /// <param name="s">Array de String</param>
    /// <param name="k">start Inicial</param>
    public static void PermuteRecursive(string[] s, int k)
    {
        int i, len;
        len = s.Length;
        if (k == len)
        {
            printf(s);
        }
        else
        {
            for (i = k; i < len; i++)
            {
                PermuteArray(s, k, i);
                PermuteRecursive(s, k + 1);
                PermuteArray(s, i, k);
            }
        }

    }


    private static void PermuteArray(string[] str, int p1, int p2)
    {
        string tmp;
        tmp = str[p1];
        str[p1] = str[p2];
        str[p2] = tmp;
    }


    private static void printf(string[] p)
    {

        string _r = "";
        for (int i = 0; i < p.Length; i++)
        {
            _r += p[i] + " ";
        }
        iteration++;
        Console.WriteLine($"{iteration}  : {_r}");
    }
}