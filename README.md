# POCOGenerator
Uma interface de usuário simples que foi criada para filtrar e selecionar quais tabelas você deseja que o *EntityFramework Reverse POCO Generator* utilize.

O projeto foi adaptado do [EntityFramework-Reverse-POCO-Generator-UI](https://github.com/sjh37/EntityFramework-Reverse-POCO-Generator-UI) para buscar por tabelas específicas do banco de dados.

![Interface do POCOGenerator](https://github.com/diegoalvesat1/Patch-images/blob/master/POCO_Generator_UI.png)

Alguns projetos utilizam bancos de dados com uma grande quantidade de tabelas. Além disso muitas empresas utilizam prefixos (ex: PRDCLIENTE, PRDESTOQUE...) para determinar de qual projeto, produto ou relacionamento é aquela tabela.

Com essa gama de tabelas torna-se difícil a seleção de tabelas específicas na lista que é apresentada após selecionar o banco de dados na interface do *EntityFramework Reverse POCO Generator UI*. O POCOGenerator facilita o uso da interface para essas situações.

A interface funciona da seguinte forma:

* Clique em "*conectar banco de dados*" e selecione a instância e o banco de dados.

![conexão com o banco de dados](https://github.com/diegoalvesat1/Patch-images/blob/master/POCO_Generator_ConnectionDatabase.png)

* Você pode filtrar a lista de tabelas informando o prefixo:

![Prefixo da Tabela](https://github.com/diegoalvesat1/Patch-images/blob/master/POCO_Generator_Filter_Prefixo.png)

* Ou o nome da tabela:

![Nome da Tabela](https://github.com/diegoalvesat1/Patch-images/blob/master/POCO_Generator_Filter_Tabela.png)

