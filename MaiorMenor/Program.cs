internal class Program
{
    private static void Main(string[] args)
    {
        float[] value = new float[15];
        float maior, menor;
        int count; 

        for(count = 0; count < 15; count++)
        {
            Console.Write($"Informe o {count+1}º valor: ");
            value[count] = float.Parse(Console.ReadLine());

        }

        maior = value[0];
        menor = value[0];

        for (count = 1; count < 15; count++)
        {            
            if (value[count] > maior)
            {
                maior = value[count];
            }
            if (value[count] < menor)
            {
                menor = value[count];   
            }
        }
        Console.WriteLine("O maior valor {0} e o menor valor {1}", maior, menor);
    }
}