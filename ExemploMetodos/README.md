## 🧠 O que são métodos em C#?

Métodos são blocos de código que executam uma tarefa específica. Eles ajudam a organizar, reutilizar e encapsular lógica dentro de classes. Em C#, um método pode:

- Ter um nome descritivo
- Receber parâmetros
- Retornar valores (ou não)
- Ser público, privado, estático etc.

### 🔧 Estrutura de um método

```csharp
public int Somar(int a, int b)
{
    return a + b;
}
```

- `public`: modificador de acesso
- `int`: tipo de retorno
- `Somar`: nome do método
- `(int a, int b)`: parâmetros
- `return a + b;`: corpo do método

---

## 📂 Análise dos seus códigos

### 1. `Program.cs` — Ponto de entrada

Este arquivo instancia objetos e chama métodos definidos nas classes:

```csharp
Pessoa p1 = new Pessoa();
p1.Nome = "Giancarlo";
p1.Sobrenome = "Massaccesi";
```

- Aqui, o método `set` da propriedade `Nome` é invocado, com validação.
- O método `AdicionarAluno()` é chamado para inserir alunos no curso.
- Por fim, `ListarAlunos()` exibe os nomes dos alunos.

---

### 2. `Pessoa.cs` — Classe com propriedades e método de apresentação

#### 🔹 Propriedades com lógica

```csharp
public string Nome
{
    get => _nome.ToUpper();
    set
    {
        if (value == "")
        {
            throw new ArgumentException("O nome não pode ser vazio");
        }
        _nome = value;
    }
}
```

- O `get` transforma o nome em maiúsculas.
- O `set` valida se o nome é vazio.

#### 🔹 Método `Apresentar()`

```csharp
public void Apresentar()
{
    Console.WriteLine($"Nome: {NomeCompleto.ToUpper()}, Idade: {Idade}");
}
```

- Exibe o nome completo e idade formatados.
- Não retorna valor (tipo `void`), apenas imprime no console.

---

### 3. `Curso.cs` — Classe com métodos de manipulação de alunos

#### 🔹 `AdicionarAluno(Pessoa aluno)`

```csharp
public void AdicionarAluno(Pessoa aluno)
{
    Alunos.Add(aluno);
}
```

- Recebe um objeto `Pessoa` e adiciona à lista `Alunos`.

#### 🔹 `ObterQuantidadeDeAlunosMatriculados()`

```csharp
public int ObterQuantidadeDeAlunosMatriculados()
{
    int quantidade = Alunos.Count;
    return quantidade;
}
```

- Retorna o número de alunos matriculados.

#### 🔹 `RemoverAluno(Pessoa aluno)`

```csharp
public bool RemoverAluno(Pessoa aluno)
{
    return Alunos.Remove(aluno);
}
```

- Tenta remover um aluno da lista e retorna `true` ou `false`.

#### 🔹 `ListarAlunos()`

```csharp
public void ListarAlunos()
{
    Console.WriteLine($"Alunos do curso de: {Nome}");
    foreach (Pessoa aluno in Alunos)
    {
        Console.WriteLine(aluno.NomeCompleto.ToUpper());
    }
}
```

- Itera sobre a lista e imprime os nomes dos alunos.

---

## 📘 Documentação contextualizada sobre métodos

### 🧾 Métodos utilizados

| Classe   | Método                        | Tipo     | Descrição |
|----------|-------------------------------|----------|-----------|
| `Pessoa` | `Apresentar()`                | `void`   | Exibe nome completo e idade |
| `Curso`  | `AdicionarAluno(Pessoa)`      | `void`   | Adiciona aluno à lista |
| `Curso`  | `ObterQuantidadeDeAlunosMatriculados()` | `int` | Retorna número de alunos |
| `Curso`  | `RemoverAluno(Pessoa)`        | `bool`   | Remove aluno da lista |
| `Curso`  | `ListarAlunos()`              | `void`   | Lista todos os alunos |

### 📌 Observações

- Os métodos são bem encapsulados e seguem boas práticas.
- Há uso de propriedades com lógica de validação (`Nome`, `Idade`).
- O uso de `void`, `int` e `bool` como tipos de retorno mostra variedade de métodos.
- O código é orientado a objetos e demonstra interação entre classes.

---

