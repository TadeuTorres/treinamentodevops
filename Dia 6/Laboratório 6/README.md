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
    <li> Substituir o conteúdo do método <i>Main</i>, da classe <i>Program.cs</i> pelo código a seguir:
    	  <img src="https://raw.githubusercontent.com/augustocbn/treinamentodevops/master/Dia%206/Laborat%C3%B3rio%206/img1.PNG" width="100px" height="100px">

    <li> Ainda na classe <i>Program.cs</i>, importar o namespace "System.Threading.Tasks"
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
    <li> No Azure DevOps, em Project Settings, criar um Agent Pool do tipo Self-hosted, chamado <b>Private Pool</b>.
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
