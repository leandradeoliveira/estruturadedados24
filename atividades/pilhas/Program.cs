// basicamente as puilhas trabalham com 
// uma estrutura LIFO -> Last In fitrst out 
// trez metodos importtantes 
//Push()insere um elemento no topo da pilha 
//Pop()remove o elemento do topo da pilha
//Peek()retorna o elemento do topo da pilha sem removê-lo
// Invertendo as bolas 




using System;
using System.Collections.Generic;

class PalindromeChecker
{
    static void Main(string[] args)
    {
        Console.Write("ovo em ovo : ");
        string input = Console.ReadLine();

        Stack<char> stack = new Stack<char>();

        // Push each character of the input string onto the stack
        foreach (char c in input)
        {
            stack.Push(c);
        }

        string reversed = string.Empty;

        // Pop each character from the stack and append to the reversed string
        while (stack.Count > 0)
        {
            reversed += stack.Pop();
        }

        // Check if the original input is equal to the reversed string
        if (input.Equals(reversed, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("palindromoa.");
        }
        else
        {
            Console.WriteLine("nao palindromo .");
        }
    }
}