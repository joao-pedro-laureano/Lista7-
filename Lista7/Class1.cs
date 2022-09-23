public static class Exercicios
{
    public static void Exercicio1()
    {
        double a, b;
        Console.WriteLine("Digite a quantidade máxima: ");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a quantidade mínima: ");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("O estoque médio é: " + (a + b) / 2);
    }
    public static void Exercicio2()
    {
        double a, b;
        Console.WriteLine("Digite a cotação do dolar:");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Qual o valor a ser convertido: ");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("O valor convertido é: " + a*b);
    }
    public static void Exercicio3()
    {
        double a, b;
        Console.WriteLine("Preço das peças:");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Quantidade das peças é: ");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("A comissão é: " + a * b*5/100);
    }
    public static void Exercicio4()
    {
        //int a, b, c, d;
        //Console.WriteLine("Digite 4 valores: ");
        //a = int.Parse(Console.ReadLine());
        //b = int.Parse(Console.ReadLine());
        //c = int.Parse(Console.ReadLine());
        //d = int.Parse(Console.ReadLine());
        //Console.WriteLine("A operação ultilizando a soma é: " + (a + b + a + c + a + d) + (b + a + b + b + b + c + b + d);
        //Console.WriteLine();
        //Console.WriteLine("A operação ultilizando a multipicação é: " + (a * b * a * c * a * d);
    }
    public static void Exercicio5()
    {
        double dist, litro, tempo, velocidade, auton = 12;
        Console.WriteLine("Digite o tempo gasto na viagem: ");
        tempo = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a velocidade média na viagem: ");
        velocidade = double.Parse(Console.ReadLine());
        dist = tempo * velocidade;
        litro = dist / 12;
        Console.WriteLine("A velocidade média é: " + velocidade);
        Console.WriteLine("O tempo gasto é: " + tempo);
        Console.WriteLine("A distância percorida é: " + dist);
        Console.WriteLine("A quantidade de litros é: " + litro);
    }
    public static void Exercicio6()
    {
        double f, c;
        Console.WriteLine("Digite uma temperatura em Graus Celcius:");
        c = double.Parse(Console.ReadLine());
        f = (9 * c + 160) / 5;
        Console.WriteLine("A temperatura convertida é:" + f);
        


    }
    public static void Exercicio7()
    {
        double f, c;
        Console.WriteLine("Digite uma temperatura em Graus Fahrenheit:");
        f = double.Parse(Console.ReadLine());
        c = (f - 32) * 5 / 9;
        Console.WriteLine("A temperatura convertida é:" + c);
    }
    public static void Exercicio8()
    {
        double v, r, a;
        Console.WriteLine("Digite o raio: ");
        r = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o altura: ");
        a = double.Parse(Console.ReadLine());
        v = 3.14159 * r * r * a;
        Console.WriteLine("O volume da lata é: " + v);
    }
    public static void Exercicio9()
    {
        int a, m, d, dias;
        Console.WriteLine("Digite sua idade em anos");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite sua idade em meses");
        m = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite sua idade em dias");
        d = int.Parse(Console.ReadLine());
        dias = (a * 365) + (m * 30) + d;
        Console.WriteLine("Sua idade em dias é: " + dias);
    }
    public static void Exercicio10()
    {
        int a, b;
        Console.WriteLine("Digite 2 valores: ");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        if (b < a) Console.WriteLine("É maior que o primeiro");
        if (b <= a) Console.WriteLine("É maior ou igual que o primeiro");
        if (b == a) Console.WriteLine("É igual que o primeiro");
        if (b > a) Console.WriteLine("É menor que o primeiro");
        if (b >= a) Console.WriteLine("É menor ou igual que o primeiro");
    }
    public static void Exercicio11()
    {
        int a, b, newb, newa;
        Console.WriteLine("Digite 2 valores inteiros: ");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        newb = a;
        newa = b;
        Console.WriteLine("Valor de A é: " + newa + ". O valor de B é: " + newb);
    }
    public static void Exercicio12()
    {
        int a;
        Console.WriteLine("Digite 1 valor inteiros: ");
        a = int.Parse(Console.ReadLine());
        if (a >= 0) Console.WriteLine("X");
        if (a < 0) Console.WriteLine("X*(-1)");
    }
    public static void Exercicio13_()
    {
        int a = 0, b = 0, c = 0;
        var lista = new List<int>();

        Console.WriteLine("Digite 3 valores");
        lista.Add(int.Parse(Console.ReadLine()));
        lista.Add(int.Parse(Console.ReadLine()));
        lista.Add(int.Parse(Console.ReadLine()));

        Console.WriteLine($"Ordem decrescente: {string.Join(", ", lista.OrderBy(x => x))}");
    }

    public static void Exercicio13_2()
    {
        int a = 0, b = 0, c = 0, maior = 0, menor = 0, meio = 0;

        Console.WriteLine("Digite 3 valores");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());

        if (a < b)
        {
            menor = a;
            maior = b;
        }
        else
        {
            menor = b;
            maior = a;
        }

        if (c < menor)
        {
            meio = menor;
            menor = c;
        }
        else if (c > maior)
        {
            meio = maior;
            maior = c;
        }
        else
        {
            meio = c;
        }

        Console.WriteLine("Ordem decrescente: " + maior + " " + meio + " " + menor);
    }

    public static void Exercicio13()
    {
        int a = 0, b = 0, c = 0, maior = 0, menor = 0, meio = 0;

        Console.WriteLine("Digite 3 valores");
        a = int.Parse(Console.ReadLine());
        maior = a;
        menor = a;

        b = int.Parse(Console.ReadLine());

        if (b > maior) maior = b;
        if (b < menor) menor = b;

        c = int.Parse(Console.ReadLine());
        if (c > maior) maior = c;
        else if (c < menor) menor = c;
        else meio = c;

        Console.WriteLine("Ordem decrescente: " + maior + " " + meio + " " + menor);
    }
    public static void Exercicio14()
    {
        int a, b, newb, newa;
        Console.WriteLine("Digite 2 valores inteiros: ");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
    }

    public static int CalculaMedia(params int[] valores)
    {
        return valores.Sum() / valores.Length;
    }

    public static int Somar(params int[] valores)
    {
        return valores.Sum();
    }

    public static int Maior(params int[] valores)
    {
        return valores.Max();
    }
}
