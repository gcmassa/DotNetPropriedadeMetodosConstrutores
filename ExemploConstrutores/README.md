
---

## 🧠 O que são Construtores em C#?

Um **construtor** é um método especial usado para **inicializar objetos** de uma classe. Ele tem o mesmo nome da classe e **não possui tipo de retorno** (nem mesmo `void`). Os construtores são chamados automaticamente quando um objeto é criado com `new`.

### Tipos de Construtores

- **Construtor padrão (sem parâmetros)**  
  Usado quando não se deseja passar valores na criação do objeto.

- **Construtor parametrizado**  
  Permite inicializar o objeto com valores específicos.

- **Sobrecarga de construtores**  
  É possível ter múltiplos construtores com diferentes assinaturas.

---

## 🔍 Análise dos Códigos

### 1. `Pessoa.cs`

A classe `Pessoa` possui dois construtores:

```csharp
public Pessoa() { }
public Pessoa(string nome, string sobrenome) { Nome = nome; Sobrenome = sobrenome; }
```

- O **construtor padrão** permite criar um objeto sem definir nome e sobrenome imediatamente.
- O **construtor parametrizado** facilita a criação de objetos já com os dados definidos, promovendo encapsulamento e legibilidade.

Além disso, a classe implementa:
- **Propriedades com validação** (`Nome`, `Idade`)
- **Propriedade calculada** (`NomeCompleto`)
- **Método de apresentação** (`Apresentar()`)

### 2. `Curso.cs`

A classe `Curso` não possui construtor explícito, então o compilador fornece um **construtor padrão implícito**. Ela contém:

- Propriedades: `Nome`, `Alunos`
- Métodos para manipular alunos:
  - `AdicionarAluno(Pessoa aluno)`
  - `RemoverAluno(Pessoa aluno)`
  - `ObterQuantidadeDeAlunosMatriculados()`
  - `ListarAlunos()`

### 3. `Program.cs`

Aqui vemos o uso dos construtores:

```csharp
Pessoa p1 = new Pessoa("Giancarlo", "Massaccesi");
Pessoa p2 = new Pessoa(nome:"Eduardo", sobrenome: "Neves Queiroz");
```

- Ambos os objetos são criados usando o **construtor parametrizado**, com e sem nomeação de parâmetros.
- O uso de `new Pessoa(...)` demonstra como os construtores facilitam a inicialização direta.

Depois, o programa cria um curso e adiciona os alunos:

```csharp
Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();
```

---

## 📄 Documentação Explicativa: Construtores no Projeto

### Objetivo

Demonstrar o uso de construtores em C# para inicializar objetos de forma segura, clara e eficiente.

### Classes Envolvidas

| Classe  | Construtores | Finalidade |
|---------|--------------|------------|
| Pessoa  | Padrão e Parametrizado | Inicializar dados pessoais com ou sem valores |
| Curso   | Implícito (sem parâmetros) | Criar instância de curso e gerenciar alunos |

### Benefícios Observados

- ✅ **Encapsulamento**: Os dados são validados no momento da atribuição.
- ✅ **Flexibilidade**: O uso de múltiplos construtores permite diferentes formas de instanciar objetos.
- ✅ **Legibilidade**: O código no `Program.cs` é claro e direto ao ponto.

### Sugestões de Melhoria

- Adicionar um construtor parametrizado à classe `Curso`, por exemplo:

```csharp
public Curso(string nome)
{
    Nome = nome;
    Alunos = new List<Pessoa>();
}
```

Assim, o código ficaria mais enxuto:

```csharp
Curso cursoDeIngles = new Curso("Inglês");
```

---
