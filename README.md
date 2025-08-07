
---

## ✅ Resumo Completo das Tarefas Realizadas

### 1. 🧩 Propriedades

Propriedades são membros que encapsulam campos internos e controlam o acesso à leitura e escrita de dados. Elas são fundamentais para manter a integridade e segurança das informações dentro de uma classe.

#### 🔹 Classe `Pessoa`

| Propriedade     | Tipo     | Características |
|----------------|----------|-----------------|
| `Nome`         | `string` | Possui validação para impedir valores vazios. Retorna o nome em maiúsculas. |
| `Sobrenome`    | `string` | Autoimplementada, sem validação. |
| `NomeCompleto` | `string` | Propriedade calculada que concatena `Nome` e `Sobrenome`. |
| `Idade`        | `int`    | Validação para impedir valores negativos. |

> ✨ Destaque: O uso de validações nas propriedades `Nome` e `Idade` evita inconsistências e garante que os dados estejam sempre corretos.

#### 🔹 Classe `Curso`

| Propriedade | Tipo            | Características |
|-------------|------------------|-----------------|
| `Nome`      | `string`         | Nome do curso. |
| `Alunos`    | `List<Pessoa>`   | Lista que armazena os alunos matriculados. |

> 💡 Observação: A propriedade `Alunos` permite o gerenciamento dinâmico dos participantes do curso.

---

### 2. 🛠️ Métodos

Métodos são responsáveis por definir os comportamentos das classes. Eles permitem que os objetos realizem ações e interajam com seus dados internos.

#### 🔹 Classe `Pessoa`

- `Apresentar()`: Exibe no console o nome completo em maiúsculas e a idade do aluno.

#### 🔹 Classe `Curso`

| Método                          | Finalidade |
|----------------------------------|------------|
| `AdicionarAluno(Pessoa aluno)`   | Adiciona um aluno à lista `Alunos`. |
| `RemoverAluno(Pessoa aluno)`     | Remove um aluno da lista. |
| `ObterQuantidadeDeAlunosMatriculados()` | Retorna o número total de alunos. |
| `ListarAlunos()`                 | Exibe todos os alunos matriculados no curso, com nome completo em maiúsculas. |

> 🔎 Os métodos da classe `Curso` encapsulam a lógica de manipulação da lista de alunos, mantendo o código organizado e reutilizável.

---

### 3. 📘 Construtores

Construtores são métodos especiais usados para inicializar objetos. Eles têm o mesmo nome da classe e não possuem tipo de retorno. São chamados automaticamente quando usamos `new`.

#### 🔹 Classe `Pessoa`

Possui dois construtores:

```csharp
public Pessoa() { }
public Pessoa(string nome, string sobrenome) { Nome = nome; Sobrenome = sobrenome; }
```

- O **construtor padrão** permite criar objetos sem definir valores iniciais.
- O **construtor parametrizado** facilita a criação de objetos já com os dados definidos, promovendo clareza e segurança.

#### 🔹 Classe `Curso`

- Não possui construtor explícito, portanto utiliza o **construtor padrão implícito** gerado pelo compilador.
- Sugestão de melhoria: adicionar um construtor parametrizado para inicializar `Nome` e `Alunos` diretamente.

```csharp
public Curso(string nome)
{
    Nome = nome;
    Alunos = new List<Pessoa>();
}
```

---

### 4. 📄 Conclusão e Benefícios Observados

- ✅ **Encapsulamento**: Propriedades com validação protegem os dados.
- ✅ **Organização**: Métodos bem definidos mantêm a lógica separada e reutilizável.
- ✅ **Flexibilidade**: Construtores permitem diferentes formas de instanciar objetos.
- ✅ **Legibilidade**: O código é claro, direto e fácil de manter.

---

