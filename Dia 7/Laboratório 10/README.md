# Laboratório 10

Tempo estimado: 60 minutos

Cenário: O setor de Recursos Humanos da empresa Global S.A, solicitou a equipe de TI a criação de uma API que será responsável por listar os aniversariantes do mês.

## Exercício 1
 
Objetivo: Criar o projeto no Visual Studio 2019

### Instruções

<ol>
    <li> Abrir o <b>Visual Studio 2019</b>
    <li> Clicar no botão <b>Create a new project</b>
    <li> Escolher o template de projeto <b>ASP.NET Core Web Apllication (C#).</b>
    <li> Definir o nome do projeto: <b>GlobalRH</b>
    <li> Desmarcar a configuração de HTTPS e habilitar o suporte ao Docker (Linux)</b>
</ol>

## Exercício 2
 
Objetivo: Incluir a API no projeto

### Instruções

<ol>
    <li> Na pasta <b>Controllers</b>, adicionar o arquivo <b>Aniversariante.cs</b>, contido na pasta demo1.
    <li> Executar a aplicação e testar o acesso a API <b>/aniversariante</b> através do navegador web.
    <li> Qual foi o resultado?
    <li> Inspecione a barra de tarefas do Docker no Visual Studio, ativada em modo debug.
    <li> Na ferramenta de linha de comando, verifique os contêineres ativos na sua máquina.
    <li> Qual foi o resultado?
    <li> Ainda na linha de comando, verifica as imagens de contêiner disponíveis na sua máquina.
    <li> Qual foi o resultado?
</ol>

## Exercício 3
 
Objetivo: Publicar a imagem no Docker Hub

### Instruções

<ol>
    <li> Através do Visual Studio, publicar a imagem criada no docker hub. Para isso, considere a criação da tag 1.0
    <li> Acessar o Docker Hub (https://hub.docker.com) e verificar se a imagem foi publicada com sucesso.
</ol>

## Exercício 3
 
Objetivo: Criar um contêiner a partir da imagem publicada no Docker Hub.

### Instruções

<ol>
    <li> Utilizar o comando docker run para criar e executar o container.
    <li> Acessar a API "/aniversariante" através do navegador web.
    <li> Qual foi o resultado?
</ol>