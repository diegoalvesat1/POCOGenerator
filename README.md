# POCO Generator
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

* Selecione as tabelas que serão utilizadas pelo *EntityFramework Reverse POCO Generator*.

![seleção de Tabelas](https://github.com/diegoalvesat1/Patch-images/blob/master/POCO_Generator_Select_Tables.png)

No campo "*Regex*" é informado o que ficará descrito na variável "*TableFilterInclude*". Esse campo é copiado automaticamente para a área de tranferência.

![Regex](https://github.com/diegoalvesat1/Patch-images/blob/master/image.png)

Após selecionar as tabelas, você deverá substituir a variável "*TableFilterInclude*" no arquivo "*POCOGeneratorDatabase.tt*" criado pelo *EntityFramework Reverse POCO Generator* ([clique aqui](https://marketplace.visualstudio.com/items?itemName=SimonHughes.EntityFrameworkReversePOCOGenerator)) contido no projeto POCOGenerator.Data, na linha 194, pelo que está na área de transferência.

![variável TableFilterInclude](https://github.com/diegoalvesat1/Patch-images/blob/master/POCO_Generator_TableFilterInclude.png)

![variável TableFilterInclude inserido](https://github.com/diegoalvesat1/Patch-images/blob/master/POCO_Generator_TableFilterInclude_set_Tables.png)

É importante definir as configurações da "*connectionString*" no app.config do projeto *POCOGenerator.Data*.

![configuração de banco](https://github.com/diegoalvesat1/Patch-images/blob/master/POCO_Generator_config.png)

Após essa alteração salve o arquivo para que o *EntityFramework Reverse POCO Generator* gere no arquivo "*POCOGeneratorDatabase.cs*" as configurações das tabelas que foram selecionadas para que você possa usar em seu projeto.
