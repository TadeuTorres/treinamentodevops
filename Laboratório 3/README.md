# Laboratório 3

Tempo estimado: 60 minutos

Cenário: A empresa Flight Report S.A., possui um componente de software que permite a consulta de informações sobre os voos domésticos realizados no Canadá. Contudo, a governança e distribuição desse produto é 100% manual. A fim de resolver esse problema, a empresa contratou uma equipe especializada em integração contínua, com o objetivo de garantir a qualidade do código produzido, bem como, automatizar o delivery do componente.

## Exercício 1
 
Objetivo: Integrar o código fonte a um repositório no Azure DevOps.

### Instruções

<ol>
    <li> Baixar o conteúdo da pasta Demo1 e extrair o conteúdo para o diretório c:\devops\lab3\demo1.
    <li> Tornar o diretório um repositório Git.
    <li> Criar um repositório no Azure DevOps chamado Lab3.
    <li> Vincular o repositório local ao repositório remoto.
    <li> Realizar o push do código fonte para o repositório remoto (branch master).
    <li> Através da interface gráfica do Azure DevOps, garantir que o código fonte foi armazenado com sucesso.
</ol>

## Exercício 2

Objetivo: Criar uma CI, que será responsável por compilar o componente.

### Instruções

<ol>
    <li> Na estrutura de Pipelines do Azure DevOps, criar uma CI chamada <b>ci_lab3</b>.
    <li> Essa CI deve realizar o restore das dependências, o build do código fonte e o publish dos artefatos. Utilizar o agent <b>windows-2019</b>.
    <li> Executar a CI <b>ci_lab3</b> usando como alvo o branch master.
    <li> Acompanhar a execução e garantir que o processo foi executado com sucesso.
</ol>

## Exercício 3

Objetivo: Configurar gatilho, de modo que, qualquer alteração submetida ao branch master, inicie a execução da CI.

### Instruções

<ol>
    <li> Editar a CI <b>ci_lab3</b>.
    <li> Na aba triggers, habilitar o flag de integração contínua e incluir como opção de filtro o branch master.
    <li> Abrir a solução FlightReport no Visual Studio e remover os comentários do método <b>GetDelayedFlights</b>.
    <li> Realizar o commit das alterações e push para o branch master.
    <li> No Azure DevOps, lista de Pipelines, verificar se um novo build foi iniciado para a CI <b>ci_lab3</b>.
    <li> Acompanhar a execução e garantir que o processo foi executado com sucesso.
</ol>

## Exercício 4

Objetivo: Configurar políticas restritivas aos branches de origem dos Pull Requests.

### Instruções

<ol>
    <li> No Azure DevOps, funcionalidade <b>branch policies</b>, do branch master, vincular a CI <b>ci_lab3</b>, de modo que, todos os branches correspondentes aos PRs submetidos, sejam validados pela CI.
    <li> Abrir a solução FlightReport no Visual Studio e remover os comentários do método <b>GetFlights</b>.
    <li> Através da linha de comando, Realizar o commit e push da alteração para o branch master.
    <li> Avaliar o resultado. Qual foi a resposta do git?
    <li> Através da linha de comando, criar um branch chamado <b>feature/getflights</b> e realizar o push para o repositório remoto.
    <li> No Azure DevOps, Criar um Pull Request (PR) do branch <b>feature/getflights</b> para o master.
    <li> Verificar se um novo build foi iniciado e vinculado ao Pull Request (PR).
</ol>

## Exercício 5

Objetivo: X

### Instruções

<ol>
    <li> X </b>.
</ol>

## Exercício 6

Objetivo: X

### Instruções

<ol>
    <li> X </b>.
</ol>