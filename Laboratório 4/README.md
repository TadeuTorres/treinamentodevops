# Laboratório 4

Tempo estimado: 30 minutos

Cenário: A empresa Flight Report S.A., possui um componente que possui dependências específicas. Diante do exposto, a equipe técnica observou que os hosted agents não possuem os requisitos necessários para compilar a aplicação.

## Exercício 1
 
Objetivo: Integrar o código fonte a um repositório no Azure DevOps.

### Instruções

<ol>
    <li> Baixar o conteúdo da pasta Demo1 e extrair o conteúdo para o diretório c:\devops\lab4\demo1.
    <li> Tornar o diretório um repositório Git.
    <li> Criar um repositório no Azure DevOps chamado Lab4.
    <li> Vincular o repositório local ao repositório remoto.
    <li> Realizar o push do código fonte para o repositório remoto (branch master).
    <li> Através da interface gráfica do Azure DevOps, garantir que o código fonte foi armazenado com sucesso.
</ol>

## Exercício 2

Objetivo: Importar a CI

### Instruções

<ol>
    <li> No Azure DevOps, importar a CI contida no diretório <b>c:\devops\lab4\demo1\ci.json</b>.
    <li> Renomear a CI importada para <b>ci_lab4</b>.
    <li> Realizar as adequações necessárias e salvar a CI <b>ci_lab4</b>.
</ol>

## Exercício 3

Objetivo: Criar Agent e Agent Pool.

### Instruções

<ol>
    <li> No Azure DevOps, em Project Settings, criar um Agent Pool do tipo Self-hosted, chamado Private Pool.
    <li> Criar um novo Agent e realizar a vinculação dele ao Agent Pool <b>Private Poll</b>.
</ol>

## Exercício 4

Objetivo: Executar a CI <b>ci_lab4</b>.

### Instruções

<ol>
    <li> Executar a CI <b>ci_lab4</b>. Na tela de preparação, escolher o Agent Pool <b>Private Poll</b>.
    <li> Qual foi o resultado?
    <li> Adequar a CI <b>ci_lab4</b> para considerar o Agent Pool <b>Private Poll</b> como padrão.
    <li> Executar a CI <b>ci_lab4</b>. O que mudou na tela de preparação?
    <li> Qual foi o resultado?
</ol>
