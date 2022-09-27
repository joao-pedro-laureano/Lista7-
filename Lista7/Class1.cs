public static class Exercicios

{
    //var c = Exercicios.CalculaMedia(4, 6, 7, 5, 3, 1, 4);
    //var s = Exercicios.Somar(4, 6, 7, 5, 3, 1, 4);
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
        int a, b;
        Console.WriteLine("Digite 2 valores inteiros: ");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        if(a > b)
        {
            Console.WriteLine(a - b);
        }
        if (a < b)
        {
            Console.WriteLine(b - a);
        }
    }
    public static void Exercicio15()
    {
        double n1, n2, n3, n4, nr;
        Console.WriteLine("Digite sua n1:");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite sua n2:");
        n2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite sua n3:");
        n3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite sua n4:");
        n4 = int.Parse(Console.ReadLine());
        var media = (n1 + n2 + n3 + n4) / 4;
        
        if (media >= 7)
        {
            Console.WriteLine($"Sua média foi {media}. Está aprovado!");
        }
        else Console.WriteLine($"Sua média foi {media}. Está de recuperação !!! \n \nQual foi o valor de sua prova de recuperação ?");
        nr = int.Parse(Console.ReadLine());
        var newmedia = (nr + media) / 2;
        if (newmedia > 7)
        {
            Console.WriteLine($"Sua média da recuperação foi {media}. Está aprovado!");
        }
        else Console.WriteLine($"Sua média com a recuperação foi {media}. Está reprovado !!");
    }
    public static void Exercicio16()
    {
        int a, b;
        Console.WriteLine("Digite 2 valores inteiros: ");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine("O maior número é: " + a);
        }
        if (a < b)
        {
            Console.WriteLine("O maior número é: " + b);
        }
        if (a == b)
        {
            Console.WriteLine("Os números são iguais!");
        }
    }
    public static void Exercicio17()
    {
        int a;
        Console.WriteLine("Digite 1 valor inteiro: ");
        a = int.Parse(Console.ReadLine());
        if (a >= 0 && a <= 9)
        {
            Console.WriteLine("O número é válido!");
        }
        else Console.WriteLine("O número não válido!");
    }
    public static void Exercicio18()
    {
        string r;
        Console.WriteLine("Escreva um código");
        int c = int.Parse(Console.ReadLine());
        switch (c)
        {
            case 1 :
                    r = "um";
                break;
            case 2:
                r = "dois";
                break;
            case 3:
                r = "três";
                break;
                default : r = "Esse código é inválido";
                break;
        }
        Console.WriteLine(r);
    }
    public static void Exercicio19()
    {
        double a, b, c;
        Console.WriteLine("Digite os 3 lados do triângulo: ");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());
        
        if(a < (b+c) && b < (a + c) && c < (a + b))
        {
            if(a==b && b==c)
            {
                Console.WriteLine("O triângulo é equilátero!");
            }
            else if (a == b || b == c)
            {
                Console.WriteLine("O triângulo é isóceles!");
            }
            else
            {
                Console.WriteLine("O triângulo é escaleno!");
            }
        }
        else
        {
            Console.WriteLine("Triângulo indispoível!");
        }
    }
    public static void Exercicio20()
    {
        double a, b, c,maior, menor;
        var lista = new List<double>();
        do
        {
            Console.WriteLine("Digite 3 valores");

            lista.Add(a = double.Parse(Console.ReadLine()));
            lista.Add(b = double.Parse(Console.ReadLine()));
            lista.Add(c = double.Parse(Console.ReadLine()));
            maior = lista.Max();
            menor = lista.Min();
        }while(a <= 0 || b <= 0 || c <= 0);
        double div = maior / menor;
        Console.WriteLine($"O menor vezes o maior {maior * menor}");
        Console.WriteLine("O maior dividido pelo maior " + div);
    }
    public static void Exercicio21()
    {
        string a;
        Console.WriteLine("Digite os valores");
        do
        {
            a = Console.ReadLine();
            if(int.Parse(a) > 0)
            {
                Console.WriteLine("Positivo");
            }
            if (int.Parse(a) < 0)
            {
                Console.WriteLine("Negativo");
            }
        } while (a != "pare");
    }
    public static void Exercicio22()
    {
        int a;
        Console.WriteLine("Digite um número");
        a = int.Parse(Console.ReadLine());
        if (a > 0) Console.WriteLine("O número: " + a + " foi armazenado em a");
        else Console.WriteLine("O número " + a + " foi armazenado em b");
    }
    public static void Exercicio23()
    {
        int a, b;
        string A, r, c, d, e;

        Console.WriteLine("Escreva 2 números");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Escreva oque realiza fazer: ");
        

    }
    public static void Exercicio24() //revisar
    {
        int a, b;
        string A, r, c, d, e;

        Console.WriteLine("Escreva 2 números");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Escreva oque realiza fazer entra as opções: \n" +
            "1 – Verificar se um dos números lidos é ou não múltiplo do outro \n" +
            "2 – Verificar se os dois números lidos são pares \n" +
            "3 – Verificar se a média dos dois números é maior ou igual a 7. \n" +
            "4 – Sair ");
        do
        {
            A = Console.ReadLine();
            if (a % b == 0 && b % a == 0)
            {
                c = ($"Número {a} é multiplo do número {b} ou vice versa!");
            }
            else c = ($"Número {a} não é multiplo do número {b} ou vice versa!");
            if (a % 2 == 0)
            {
                d = ($"O número {a} é par.");
            }
            if (b % 2 == 0)
            {
                d = ($"O número {b} é par.");
            }
            else Console.WriteLine("Ambos são ímpares!");
            if ((a + b) / 2 >= 7)
            {
                e = ("A média entre os números é maior que 7");
            }
            else e = ("A média entre os números é menor que 7");
            switch (int.Parse(A))
            {
                case 1:
                    r = "um";
                    break;
                case 2:
                    r = "dois";
                    break;
                case 3:
                    r = "três";
                    break;
                default:
                    r = "Esse código é inválido";
                    break;
            }

        } while (int.Parse(A) == 4);
    }
    public static void Exercicio25()
    {
        string s;
        double h;
        Console.WriteLine("Escreva o seu sexo: ");
        s = Console.ReadLine();
        Console.WriteLine("Escreva a sua altura");
        h = double.Parse(Console.ReadLine());
        if (s == "Homem")
        {
            Console.WriteLine("Seu peso ideal é: " + ((72.7 * h) - 58));
        }
        if (s == "Mulher")
        {
            Console.WriteLine("Seu peso ideal é: " + ((62.1 * h) - 44.7));
        }
    }
    public static void Exercicio26()
    {
        for (int i = 100; i > 0; i--)
        {
            Console.WriteLine(i);
        }
    }
    public static void Exercicio28()
    {
        for (int i = 1; i <= 2000; i++)
        {
            Console.WriteLine(i);
        }
    }
    public static void Exercicio29()
    {
        for (int i = 100; i <= 200; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
    public static void Exercicio30()
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i + "x1 = " + i*1);
        }
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i + "x2 = " + i * 1);
        }
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i + "x3 = " + i * 1);
        }
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i + "x4 = " + i * 1);
        }
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i + "x5 = " + i * 1);
        }
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i + "x6 = " + i * 1);
        }
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i + "x7 = " + i * 1);
        }
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i + "x8 = " + i * 1);
        }
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i + "x9 = " + i * 1);
        }
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i + "x10 = " + i * 1);
        }
    }
    public static void Exercicio31()
    {
        int a, somai = 0, somap = 0;
        Console.WriteLine("Digite os números positivos");
        do
        {
            a = int.Parse(Console.ReadLine());
            if (a % 2 == 0 && a > 0)
            {
                Console.WriteLine("O número é par!");
                somap = somap + a;
            }
            if (a % 2 != 0 && a > 0)
            {
                Console.WriteLine("O número é impar!");
                somai = somai + a;
            }
        } while (a > 0);
        Console.WriteLine("A soma dos números pares é: " + somap);
        Console.WriteLine("A soma dos números impares é: " + somai);
    }
    public static void Exercicio32()
    {
        int i, a;
        double soma = 0;
        Console.WriteLine("Digite quantos números desejam exibir");
        i = int.Parse(Console.ReadLine());
        for (a = 0; a < i; a++)
        {
            if (a % 2 != 0)
            {
                soma = soma + (a*a);
            }
        }
        Console.WriteLine("A soma dos quadrados dos números ímpares é: " + soma);
    }
    public static void Exercicio33()
    {
        double n, soma=0;
        int i = 0;
        Console.WriteLine("Digite sua matrícula");
        Console.ReadLine();
        Console.WriteLine("Digite as notas");
        do
        {
            n =double.Parse(Console.ReadLine());
            soma = soma + n;
            i++;
        } while (n >= 0);
        Console.WriteLine("A média dos alunos é: " + soma/(i - 1));
    }
    public static void Exercicio34()
    {
        double a, maior, menor;
        Console.WriteLine("Digite os números");
        a = double.Parse(Console.ReadLine());
        maior = a;
        menor = maior;
        do
        {
            a = double.Parse(Console.ReadLine());
            if(a > maior)
            {
                maior = a;
            }
            if (a > 0 && a < menor)
            {
                menor = a;
            }
        } while (a >= 0);
        Console.WriteLine("O maior é: " + maior);
        Console.WriteLine("O menor é: " + menor);
    }
    public static void Exercicio35()
    {
        double a;
        for (int i = 0; i <= 100; i++)
        {
            Console.WriteLine(i);
            if (i % 10 == 0)
            {
                Console.WriteLine("Múltiplo de 10");
            }
        }
    }
    public static void Exercicio36()
    {
        double a, b = 0, maior, menor, soma = 0;
        Console.WriteLine("Digite os números");
        a = double.Parse(Console.ReadLine());
        maior = a;
        menor = maior;
        for (int i = 1; i < 10; i++)
        {
            a = double.Parse(Console.ReadLine());
            if (a > maior)
            {
                maior = a;
            }
            if (a < menor)
            {
                menor = a;
            }
            soma = soma + a;
            b++;
        }
        Console.WriteLine("O maior é: " + maior);
        Console.WriteLine("O menor é: " + menor);
        Console.WriteLine("A média dos valores é: " + soma / b);
    }
}

