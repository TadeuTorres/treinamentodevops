# Laboratório 5

Tempo estimado: 30 minutos

Cenário: A empresa Freight S.A., possui um componente de software com funcionalidades de cálculo de frete. A fim de, melhorar o relacionamento com o seus clientes, os gestores identificaram a necessidade de otimizar a entrega de novas versões do produto. Para isso, será necessário criar um Pipeline de deployment contínuo para o projeto.

## Exercício 1
 
Objetivo: Integrar o código fonte a um repositório no Azure DevOps.

### Instruções

<ol>
    <li> Baixar o conteúdo da pasta Demo1 e extrair o conteúdo para o diretório c:\devops\lab5\demo1.
    <li> Tornar o diretório um repositório Git.
    <li> Criar um repositório no Azure DevOps chamado Lab5.
    <li> Vincular o repositório local ao repositório remoto.
    <li> Realizar o push do código fonte para o repositório remoto (branch master).
    <li> Através da interface gráfica do Azure DevOps, garantir que o código fonte foi armazenado com sucesso.
</ol>

## Exercício 2

Objetivo: Importar a CI

### Instruções

<ol>
    <li> No Azure DevOps, importar a CI contida no diretório <b>c:\devops\lab5\demo1\ci.json</b>.
    <li> Renomear a CI importada para <b>ci_lab5</b>.
    <li> Realizar as adequações necessárias e salvar a CI <b>ci_lab5</b>.
</ol>

## Exercício 3

Objetivo: Criar a CD

### Instruções

<ol>
    <li> Criar um CD, chamada <b>cd_lab5</b>.
    <li> Incluir como artifact da <b>cd_lab5</b> o pacote produzido pela <b>ci_lab5</b>.
    <li> Configurar gatilho, de modo que a CD seja iniciada sempre que um build for finalizado.
    <li> Garantir que a CD public o nuget package gerado em um feed privado do Azure DevOps.
</ol>

