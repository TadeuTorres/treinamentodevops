# Laboratório 6

Tempo estimado: 60 minutos

Cenário: 

<p>A empresa Share Price S.A é uma corretora de valores baseada em São Paulo. Ela contratou a nossa equipe para desenvolver um aplicativo capaz de exibir o valor dos papéis operados por ela. A idéia é que os títulos sejam exibidos de forma contínua, a cada dois minutos.</p>

<p>Uma vez que a empresa possui uma pequena equipe de infraestrutura, a aplicação precisa conter em um único pacote todos os softwares necessários a sua execução.</p>

<p>
	Os papéis operados pela corretora são os seguintes:
	<ol>
	  <li>PETR4
	  <li>MGLU3
	  <li>AZUL4
	</ol>
</p>


## Exercício 1
 
Objetivo: Criar o código fonte para listar o preço das ações.

### Instruções

<ol>
    <li> Criar uma nova aplicação do tipo console.
    	 <pre><code class='language-cs'>
            dotnet new console -o SharePrice -n SharePrice.Monitor
         </code></pre>
    <li> Executar a aplicação com o comando:
    	 <pre><code class='language-cs'>
            dotnet run
         </code></pre>
    <li> Qual foi o resultado?
    <li> Parar a execução do programa
    <li> Substituir o conteúdo do método <i>Main</i>, da classe <i>Program.cs</i> pelo código a seguir:
    	  <img src="https://raw.githubusercontent.com/augustocbn/treinamentodevops/master/Dia%206/Laborat%C3%B3rio%206/img1.PNG" width="700px" height="400px">

<li> Ainda na classe <i>Program.cs</i>, importar o namespace "System.Threading.Tasks"
    <li> Extrair o pacote da aplicação através do comando:
       	 <pre><code class='language-cs'>
            dotnet publish -c release
         </code></pre>

</ol>

## Exercício 2

Objetivo: Criar uma imagem de contêiner

### Instruções

<ol>
    <li> Criar o arquivo de configuração da imagem (Dockerfile)
    <li> Construir uma imagem chamada <b>share-price-img</b>
    <li> Verificar se a imagem foi registrada no repositório local
</ol>

## Exercício 3

Objetivo: Criar um contêiner.

### Instruções

<ol>
    <li> Criar um contêiner chamado <b>share-price</b>
    <li> Verificar se o container foi registrado no repositório local
</ol>

## Exercício 4

Objetivo: Executar o monitor da Share Price S.A.

### Instruções

<ol>
    <li> Executar o contêiner <b>share-price</b>
    <li> Executar comando para listar os contêineres ativos
    <li> Qual foi o resultado?
    <li> Inspecionar a execução do contêiner
    <li> Qual foi o resultado?
</ol>

## Exercício 5

Objetivo: Esconder os vestígios

### Instruções

<ol>
    <li> Remover o contêiner <b>share-price</b>
    <li> Remover a imagem <b>share-price-img</b>
</ol>
