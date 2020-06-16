# Laboratório 13

Tempo estimado: 30 minutos

## Exercício 1
 
Objetivo: Realizar o deployment a partir de um arquivo *.yaml

### Instruções

<ol>
    <li> Criar um deloyment a partir da configuração contida no arquivo <b>demo1/lab14.yaml</b>
    <li> Exibir os Pods em execução
    <li> Qual foi o resultado?
    <li> Através do navegador web, tente acessar o serviço.
    <li> Qual foi o resultado?
</ol>

## Exercício 2
 
Objetivo: Criar um serviço que nos permita realizar a interação com os Pods.

### Instruções

<ol>
    <li> Criar o serviço <b>demo1/lab14-service.yaml</b>
    <li> Usar o kubectl para verificar ser o serviço foi criado corretamente.</b>
    <li> Qual IP foi vinculado ao serviço?</b>
    <li> Através do navegador web, tente acessar o serviço.</b>
    <li> Qual foi o resultado?</b>
</ol>

## Exercício 3
 
Objetivo: Ativando o LoadBalancer.

### Instruções

<ol>
    <li> Abrir o arquivo <b>demo1/lab14-service.yaml</b> em modo de edição.
    <li> No nível da propriedade <b>ports</b>, incluir a propriedade <b>type: LoadBalancer</b>.
    <li> Atualizar as configurações do serviço.
    <li> Usar o kubectl para listar os serviços.
    <li> O que mudou?
    <li> Através do navegador web, tente acessar o serviço.</b>
    <li> Qual foi o resultado?</b>
</ol>