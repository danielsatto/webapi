# webapi
Demo simples de uma API usando .Net Core 5.0 e Entity Framework em Memória.
Além disso foi adicionado o swagger para gerar a tela dos endpoints para consulta da documentação.

Observe que as classes de modelo (Category e Product) estão usando Data Annotations. Eu não recomendo o uso quando o cenário usa Domain Driven por conta das dependências que eles geram ao domínio. Mas como nesse exemplo não foi compartilhado o domínio, então não há problemas.
