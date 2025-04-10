
# 💻 Desafio: Dividir uma String com Espaços Preservando o Tamanho dos Segmentos em C#

## 📌 Introdução

Nesta semana, foi me apresentado um desafio durante uma sessão de programação em **C#**. A tarefa, à primeira vista simples, envolvia manipulação de strings — algo que todo desenvolvedor já enfrentou em algum momento. No entanto, o detalhe que tornava o problema mais interessante era a combinação entre espaços em branco, que deveriam ser desconsiderados, e a necessidade de segmentar a string em partes com um tamanho específico..

---

## 🧩 O Problema

> Dada uma string que pode conter espaços entre os caracteres, crie uma função que divida a string em partes de tamanho fixo. Os espaços devem ser ignorados na contagem, mas a ordem dos caracteres deve ser preservada.

### Exemplo 1

```csharp
string input = "ab cde fghij";
int tamanho = 3;
```

**Resultado esperado:**

```
ab, cde, fgh, ij
```

### Exemplo 2

```csharp
string input = "123 45 6789";
int tamanho = 2;
```

**Resultado esperado:**

```
12, 3, 45, 67, 89
```

---

## 🧠 Estratégia de Solução

1. Criar um array e quebrar o texto pelo separador, que no caso é o espaço em branco.
2. Criar uma segunda lista, para popular com a nova quebra se alguma palavra for maior que a quantidade de caracter solicitado.
3. Criar uma segunda lista, para popular com a nova quebra se alguma palavra for maior que a quantidade de caracter solicitado.
4. Se for menor, só adiciona na nova lista.
5. Retornar a lista com os segmentos gerados.

---

## 👨‍💻 Implementação em C#

```csharp
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
```



## 🧾 Conclusão

Esse desafio demonstra como problemas simples podem esconder complexidades interessantes. Trabalhar com strings, especialmente quando há a necessidade de segmentação com regras específicas, exige atenção aos detalhes. A solução apresentada é eficaz e pode ser aplicada a diversos cenários práticos. Poderia ser melhor? Com certeza, pegue o projeto e fique a vontade em alterar como quiser.

Documentar esse tipo de problema também é uma ótima forma de compartilhar conhecimento e ajudar outros desenvolvedores a encontrarem soluções rápidas e elegantes.

---

## 📚 Referências Bibliográficas (ABNT)

- TROELSEN, Andrew; JAPIKSE, Philip. *Pro C# 8 with .NET Core 3*. Apress, 2020.
- FREEMAN, Adam; SANDERSON, Jon G. *C# 9 and .NET 5 – Modern Cross-Platform Development*. Apress, 2021.
- ALBA, Márcio. *C# e Orientação a Objetos*. Novatec Editora, 2017.
