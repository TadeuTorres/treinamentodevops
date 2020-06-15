# Laboratório 12

Tempo estimado: 30 minutos

## Exercício 1
 
Objetivo: Criar um deployment no Kubernetes

### Instruções

<ol>
    <li> Criar um deployment para a imagem de contêiner <b>augustocbn/governoes:1.0</b>
    <li> Verificar o status do Pod criado</b>
    <li> Qual foi o resultado?
    <li> Através do navegador web, acessar a API <b>localhost:80/secretaria</b>
    <li> Qual foi o resultado?
</ol>

## Exercício 2
 
Objetivo: Alterar a imagem do contêiner

### Instruções

<ol>
    <li> Alterar a imagem de contêiner <b>augustocbn/governoes:3.0</b>
    <li> Verificar nos detalhes do Pod se a imagem foi alterada.</b>
</ol>

## Exercício 3
 
Objetivo: Realizar o encaminhamento de portas

### Instruções

<ol>
    <li> Realizar o encaminhamento de portas, de modo que, seja possível acessar o serviço através do navegador. O contêiner expõe a porta 80.
    <li> Através do navegador web, acessar a API <b>localhost:[porta definida no encaminhamento]/secretaria</b>
    <li> Qual foi o resultado?
</ol>

## Exercício 4
 
Objetivo: Desativar o Pod

### Instruções

<ol>
    <li> Desative o Pod em execução.
    <li> Exiba a lista de Pods.
    <li> Qual foi o resultado?
</ol>

## Exercício 5
 
Objetivo: Excluir o deployment.

### Instruções

<ol>
    <li> Executar o deployment.
    <li> Exiba a lista de Pods.
    <li> Qual foi o resultado?
</ol>