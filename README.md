📄 Nome sugerido do arquivo: Explicativo_Codigo_CSharp.md

# 🧾 Explicativo do Código em C#

Este documento descreve o funcionamento do código fornecido, utilizando dos recursos de operadores condicionais.

---

## 1. 🔤 Verificação de Vogais

### 1.1. Entrada do Usuário
- O programa solicita que o usuário digite uma letra:
  ```csharp
  Console.WriteLine("Digite uma letra:");
  string letra = Console.ReadLine();

### 1.2. Verificação com switch

- Utiliza a estrutura switch para verificar se a letra é uma vogal:
  ```csharp
  switch (letra)
  {
      case "a":
      case "e":
      case "i":
      case "o":
      case "u":
          Console.WriteLine("Vogal!");
          break;
      default:
          Console.WriteLine("Não é uma Vogal!");
          break;
  }

✅ Vantagens:

- Código limpo e organizado.

- Evita repetição de comandos.

### 1.3. Verificação com if e || (Comentado)

- Alternativa usando operadores lógicos:
  ```csharp
    if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
    {
        Console.WriteLine("Vogal!");
    }
    else
    {
        Console.WriteLine("Não é uma Vogal!");
    }

✅ Fácil de entender, mas pode ficar extenso com muitas condições.

### 1.4. Verificação com if encadeado (Comentado)

- Outra alternativa usando else if:
  ```csharp
    if (letra == "a") { ... }
    else if (letra == "e") { ... }
    ...
    else { Console.WriteLine("Não é uma Vogal!"); }

❌ Menos eficiente e mais verboso.

## 2. 🛒 Controle de Estoque e Venda (Comentado)

### 2.1. Declaração de Variáveis

- Define a quantidade em estoque e a quantidade desejada para compra:
  ```csharp
    int quantidadeEmEstoque = 10;
    int quantidadeCompra = 0;

### 2.2. Verificação de Venda Possível

- Usa operadores lógicos para verificar se a venda pode ser realizada:
  ```csharp
    bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

### 2.3. Exibição de Informações

- Mostra os dados ao usuário:
  ```csharp
    Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
    Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
    Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

### 2.4. Lógica de Venda com Validação

- Verifica se a quantidade comprada é válida e se há estoque suficiente:
  ```csharp
    if (quantidadeCompra == 0)
    {
        Console.WriteLine("Venda inválida!");
    }
    else if (possivelVenda)
    {
        Console.WriteLine("Venda Realizada");
    }
    else
    {
        Console.WriteLine("Desculpe não temos a quantidade desejada em Estoque!");
    }

### 2.5. Alternativa Simples de Verificação

- Outra forma de verificar apenas o estoque:
  ```csharp
    if (quantidadeEmEstoque >= quantidadeCompra)
    {
        Console.WriteLine("Venda Realizada");
    }
    else
    {
        Console.WriteLine("Desculpe não temos a quantidade desejada em Estoque!");
    }

✅ Considerações Finais

- O código explora diferentes formas de resolver o mesmo problema, o que é ótimo para aprendizado.

- A estrutura switch é ideal para múltiplas comparações simples.

- O controle de estoque usa boas práticas com operadores lógicos e mensagens claras.

- Pode-se melhorar a robustez do programa com validação de entrada e tratamento de erros.


---