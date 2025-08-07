## 🧠 O que são Propriedades em C#?

Propriedades são membros de uma classe que oferecem uma forma controlada de acessar e modificar os dados internos (campos privados). Elas funcionam como uma ponte entre o mundo externo e os campos internos da classe, permitindo:

- **Encapsulamento**: proteger os dados internos contra atribuições inválidas.
- **Validação**: aplicar regras antes de aceitar ou retornar valores.
- **Leitura e escrita simplificada**: com sintaxe clara e intuitiva.

### 🔧 Estrutura básica de uma propriedade

```csharp
private int _idade;

public int Idade
{
    get => _idade;
    set
    {
        if (value < 0)
            throw new ArgumentException("Idade inválida");
        _idade = value;
    }
}
```

---

## 🔍 Análise dos Códigos

### 📄 `Program.cs`

```csharp
Pessoa p1 = new Pessoa();
p1.Nome = "Giancarlo";
p1.Sobrenome = "Massaccesi";
p1.Idade = 44;
p1.Apresentar();
```

Esse trecho cria uma instância da classe `Pessoa`, define suas propriedades e chama o método `Apresentar()`. Aqui, as propriedades `Nome`, `Sobrenome` e `Idade` são utilizadas para atribuir valores com validação embutida.

---

### 📄 `Pessoa.cs`

A classe `Pessoa` define três propriedades principais:

#### 1. 🧾 `Nome`

```csharp
private string _nome;

public string Nome
{
    get => _nome.ToUpper();
    set
    {
        if (value == "")
            throw new ArgumentException("O nome não pode ser vazio");
        _nome = value;
    }
}
```

- **Encapsulamento**: usa o campo privado `_nome`.
- **Validação**: impede que o nome seja vazio.
- **Transformação**: retorna o nome sempre em maiúsculas.

#### 2. 🧾 `Sobrenome`

```csharp
public string Sobrenome { get; set; }
```

- **Auto-implementada**: não possui lógica interna.
- **Simples e direta**: útil quando não há necessidade de validação.

#### 3. 🧾 `Idade`

```csharp
private int _idade;

public int Idade
{
    get => _idade;
    set
    {
        if (value < 0)
            throw new ArgumentException("A idade não pode ser menor que zero");
        _idade = value;
    }
}
```

- **Validação**: impede valores negativos.
- **Encapsulamento**: protege o campo `_idade`.

#### 4. 🧾 `NomeCompleto`

```csharp
public string NomeCompleto => $"{Nome} {Sobrenome}";
```

- **Propriedade somente leitura**.
- **Expressão corporal**: retorna o nome completo formatado.

#### 5. 🗣️ `Apresentar()`

```csharp
public void Apresentar()
{
    Console.WriteLine($"Nome: {NomeCompleto.ToUpper()}, Idade: {Idade}");
}
```

- Exibe os dados formatados no console.
- Usa as propriedades para garantir consistência e validação.

---

## 📘 Documentação Contextualizada

### Classe: `Pessoa`

Representa uma pessoa com nome, sobrenome e idade. Utiliza propriedades para garantir integridade dos dados e facilitar o acesso.

| Propriedade     | Tipo     | Acesso | Descrição |
|----------------|----------|--------|-----------|
| `Nome`         | `string` | `get/set` | Valida se o nome é vazio e retorna em maiúsculas |
| `Sobrenome`    | `string` | `get/set` | Sem validação, autoimplementada |
| `Idade`        | `int`    | `get/set` | Valida se a idade é negativa |
| `NomeCompleto` | `string` | `get`     | Combina `Nome` e `Sobrenome` |

### Método: `Apresentar()`

Exibe no console o nome completo (em maiúsculas) e a idade da pessoa.

---
