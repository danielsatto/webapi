# WEB API - Data Driven

Demo simples de uma API usando .Net Core 5.0 e Entity Framework em Memória.
Além disso foi adicionado o Swagger para gerar a tela dos endpoints para consulta da documentação.

Packages:
	Microsoft.EntityFrameworkCore.SqlServer  
	Microsoft.EntityFrameworkCore.InMemory

Observe que as classes de modelo (Category e Product) estão usando Data Annotations. Eu não recomendo o uso de Data Annotation quando o cenário usa Domain Driven por conta das dependências que eles geram ao domínio. 
Prefira Fluent API ao Data Annotation, especialmente em cenários onde o dominio precisa ser compartilhado com outros projetos.
Mas como esse projeto é um cenário Data Driven, não há problema em usar Data Anottations. 


Ao rodar o projeto, você poderá ver a interface que o Swagger monta como auxilio ao consumo. A mesma pode ser acessada pelo endereço https://[ip]:[porta]/swagger/index.html

![image](https://user-images.githubusercontent.com/22224202/133833092-baa3e085-a18b-43db-afbd-91d6e65a475f.png)

Para acessar o endpoint da API use o seguinte endereço:
   https://[ip]:[porta]/v1/[controller]

   Ex.: para acessar o endpoint get de categories use https://[ip]:[porta]/v1/categories com método http GET



