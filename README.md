# WEB API - Data Driven

Demo simples de uma API usando .Net Core 5.0 e Entity Framework em Memória.
Além disso foi adicionado o Swagger para gerar a tela dos endpoints para consulta da documentação.

Observe que as classes de modelo (Category e Product) estão usando Data Annotations. Eu não recomendo o uso de Data Annotation quando o cenário usa Domain Driven por conta das dependências que eles geram ao domínio. Prefira Fluent API ao Data Annotation, especialmente em cenários onde o dominio precisa ser compartilhado com outros projetos, mas como esse projeto é apenas para fins didáticos então não levei em consideração esse problema. 


Ao rodar o projeto, você poderá ver a interface que o Swagger monta como auxilio ao consumo. A mesma pode ser acessada pelo endereço https://[ip]:[porta]/swagger/index.html

![image](https://user-images.githubusercontent.com/22224202/133833092-baa3e085-a18b-43db-afbd-91d6e65a475f.png)



