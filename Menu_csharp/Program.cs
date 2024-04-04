using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        ForegroundColor = ConsoleColor.Green;
        int opc;

        do
        {
            Clear();
            WriteLine("  *** Menu Principal ***");
            WriteLine("==========================");
            WriteLine("[1] Ordena nomes");
            WriteLine("[2] Conta Letras");
            WriteLine("[3] Zenit Polar");
            WriteLine("[4] Desliza Letras");
            WriteLine("[5] Letreiro");
            WriteLine("[6] Iniciasis em Maiúscula");
            WriteLine("[7] Fim");
            WriteLine("==========================");
            Write("Digite sua opção: ");
            opc = int.Parse(ReadLine());

            switch (opc)
            {
                case 1:
                    OLN();
                    break;
                case 2:
                    CL();
                    break;
                case 3:
                    Zenit();
                    break;
                case 4:
                    Desliza();
                    break;
                case 5:
                    Letreiro();
                    break;
                case 6:
                    Iniciais();
                    break;
                case 7:
                    Console.WriteLine("\n\n######## Fim da Execução ########\n\n");
                    break;
                default:
                    Console.WriteLine("\n\n**** Opção Inválida ****");
                    Console.ReadLine();
                    break;
            }
        } while (opc != 7);
    }

    static void OLN()
    {
        string lista, aux, opc;
        do
        {

            Clear();
            Write("Informe uma lista de nomes separados por ',': ");
            lista = ReadLine();

            string[] nome = lista.Split(',');
            //exibir array
            for (int i = 0; i < nome.Length; i++)
            {
                WriteLine($"{i + 1} -> {nome[i]}");
                Thread.Sleep(800);
            }
            //percorrer a lista do final pro começo
            for (int i = 0; i < nome.Length; i++)
            {
                //inverter as posições 
                for (int x = nome.Length - 1; x > 0; x--)
                {
                    if (nome[x].CompareTo(nome[x - 1]) == -1)
                    {
                        aux = nome[x];
                        nome[x] = nome[x - 1];
                        nome[x - 1] = aux;
                    }
                }
            }
            //exibe array ordenado
            WriteLine("\nNomes Ordenados");
            for (int i = 0; i < nome.Length; i++)
            {
                WriteLine($"{i + 1} -> {nome[i]}");
                Thread.Sleep(800);
            }
            WriteLine("\nVocê deseja ordenar nomes novamente? ");
            opc = ReadLine();
        }
        while (opc.Equals("sim") || opc.Equals("s"));
    }

    static void CL()
    {
        string vFrase, vLetra;
        string opc;
        int vTam, i, contA = 0, contE = 0, contI = 0, contO = 0, contU = 0, contV = 0;
        do
        {
            contA = 0;
            contE = 0;
            contI = 0;
            contO = 0;
            contU = 0;
            contV = 0;
            Clear();
            WriteLine("Informe uma frase: ");
            vFrase = ReadLine();

            vTam = vFrase.Length;

            for (i = 0; i < vTam; i++)
            {
                vLetra = vFrase.Substring(i, 1); //A partir de i pegue 1
                switch (vLetra.ToLower())
                {
                    case "a":
                    case "ã":
                    case "á":
                    case "â":
                        {
                            contA++;
                            break;
                        }
                    case "e":
                    case "é":
                    case "ê":
                        {
                            contE++;
                            break;
                        }
                    case "i":
                    case "í":
                        {
                            contI++;
                            break;
                        }
                    case "o":
                    case "ó":
                    case "õ":
                    case "ô":
                        {
                            contO++;
                            break;
                        }
                    case "u":
                    case "û":
                        {
                            contU++;
                            break;
                        }
                }
            }

            contV = contA + contE + contI + contO + contU;
            //Mostrar resultado
            WriteLine($"\nForam digitadas {contA} vogais 'a'.");
            WriteLine($"\nForam digitadas {contE} vogais 'e'.");
            WriteLine($"\nForam digitadas {contI} vogais 'i'.");
            WriteLine($"\nForam digitadas {contO} vogais 'o'.");
            WriteLine($"\nForam digitadas {contU} vogais 'u'.");
            WriteLine($"\nForam digitadas {contV} vogais");
            WriteLine($"\nForam digitadas {i} letras");
            WriteLine("\nVocê deseja contar vogais novamente?");
            opc = ReadLine();
        }
        while (opc.Equals("sim") || opc.Equals("s"));
    }

    static void Zenit()
    {
        string opc;
        do
        {
            Clear();
            string frase, crip = "", letra = "";
            string[] polar = new string[5] { "p", "o", "l", "a", "r" };
            string[] zenit = new string[5] { "z", "e", "n", "i", "t" };
            int i, a;

            Clear();

            WriteLine("Informe uma frase: ");
            frase = ReadLine();

            for (i = 0; i < frase.Length; i++)
            {
                letra = frase.Substring(i, 1);
                for (a = 0; a < 5; a++)
                {
                    if (letra == polar[a])
                    {
                        letra = zenit[a];
                        break;
                    }
                    else if (letra == zenit[a])
                    {
                        letra = polar[a];
                        break;
                    }
                }
                crip += letra;
            }
            WriteLine("\nAntiga frase: " + frase);
            WriteLine("\nFrase criptografada: " + crip);
            WriteLine("\nVocê deseja criptografar frases novamente? (S/N)");
            opc = ReadLine();
        }
        while (opc.Equals("sim") || opc.Equals("s"));
    }

    static void Desliza()
    {
        String opc;
        do
        {
            Clear();
            String frase, letra;
            int i, cont, n = 7;

            WriteLine("Informe uma frase: ");
            frase = ReadLine();

            for (i = 0; i < frase.Length; i++)
            {
                letra = frase.Substring(i, 1);

                for (cont = 50; cont >= n; cont--)
                {

                    SetCursorPosition((cont + 1), 10);
                    WriteLine(" ");
                    SetCursorPosition(cont, 10);
                    WriteLine(letra);
                    Thread.Sleep(50);

                }
                n++;

            }
            WriteLine("\nVocê deseja deslizar letras novamente? (S/N)");
            opc = ReadLine();
        }
        while (opc.Equals("sim") || opc.Equals("s"));
    }

    static void Letreiro()
    {
        string opc;
        do
        {
            Clear();
            String frase;
            int cont;
            WriteLine("Informe uma frase: ");
            frase = ReadLine();

            do
            {

                for (cont = (frase.Length) * 4 + 20; cont >= 20; cont--)
                {
                    for (int y = 0; y <= frase.Length; y++)
                    {
                        SetCursorPosition((cont + frase.Length), 10);
                        WriteLine(" ");
                        SetCursorPosition(20, 10);
                        WriteLine(new string(' ', frase.Length) + "[");
                        SetCursorPosition(cont, 10);
                        WriteLine(frase);
                        SetCursorPosition((frase.Length) * 4 + 20, 10);
                        WriteLine("]" + new string(' ', frase.Length));
                        SetCursorPosition(20, 10);
                        WriteLine(new string(' ', frase.Length) + "[");
                        SetCursorPosition((frase.Length) * 4 + 20, 10);
                        WriteLine("]" + new string(' ', frase.Length));
                        Thread.Sleep(10);
                    }
                }
            }
            while (KeyAvailable == false);
            WriteLine("\nVocê deseja usar o letreiro novamente? (S/N)");
            opc = ReadLine();
        }
        while (opc.Equals("sim") || opc.Equals("s"));
    }

    static void Iniciais()
    {
        string nome, opc;

        do
        {
            string nomeFormatado = "";
            Clear();
            Write("Informe um nome: ");
            nome = ReadLine();

            string[] palavras = nome.Split(' ');

            foreach (string palavra in palavras)
            {
                if (!string.IsNullOrWhiteSpace(palavra))
                {
                    char primeiraLetra = char.ToUpper(palavra[0]);
                    nomeFormatado += primeiraLetra + palavra.Substring(1) + " ";
                }
            }
            Clear();
            nomeFormatado = nomeFormatado.Trim();
            Write("Nome formatado com iniciais maiúsculas: " + nomeFormatado);
            WriteLine("\n\nDeseja formatar nomes novamente (S/N)?");
            opc = ReadLine();
        }
        while (opc.Equals("sim") || opc.Equals("s"));
    }
}
