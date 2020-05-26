# Laboratório 2

Tempo estimado: 60 minutos

## Exercício 1

Objetivo: Testar as instruções básicas do Git através de uma ferramenta de linha de comando.

### Instruções

<ol>
    <li> Baixar o conteúdo da pasta Demo1 e extrair o conteúdo para o diretório c:\devops\lab2\demo1
    <li> Tornar o diretório um repositório Git
    <li> Abrir o projeto no Visual Studio e remover os comentários da classe Program
    <li> Verificar o status do repositório Git
    <li> Incluir as alterações na área de staging e realizar o commit, informando um comentário.
    <li> Verificar o log do repositório Git
</ol>

## Exercício 2

Objetivo: Vincular o repositório Git, criado no Exercício 1, a um repositório remoto no Azure DevOps.

### Instruções

<ol>
    <li> Criar um repositório no Azure DevOps chamado Lab2
    <li> Vincular o repositório local ao repositório remoto
    <li> Realizar o push do código fonte para o repositório remoto
    <li> Através da interface gráfica do Azure DevOps, garantir que o código fonte foi armazenado com sucesso.
</ol>

## Exercício 3

Objetivo: Aplicar políticas de validação ao branch de trabalho.

### Instruções

<ol>
    <li> Através da linha de comando, criar um branch chamado <b>develop</p>
    <li> Enviar o branch criado ao repositório remoto
    <li> Configurar uma validação no branch develop, de modo que todos os commits sejam revisados por um revisor.
    <li> Ainda no branch develop, através do Visual Studio, inclua a linha a seguir no método Main da classe program:
         ```csharp
            Console.WriteLine("Primeiros passos com o Git");
         ```
    <li> Faça o commit das alterações e realize o push para o servidor remoto
    <li> Qual foi o resultado?
    <li> Através da linha de comando, crie o branch <b>feature/exercicio3</b>
    <li> Faça o commit e push das alterações para o repositório remoto, branch <b>feature/exercicio3</b>
    <li> Crie um Pull Request (PR), considerando como origem o branch <b>feature/exercicio3</b> e destino o <b>develop</b>
    <li> Proceda com a aprovação do PR
    <li> No Azure DevOps, verifique o conteúdo do branch <b>develop</b>
</ol>


