# BD: Guião 6

## Problema 6.1

### *a)* Todos os tuplos da tabela autores (authors);

```
SELECT * FROM authors
```

### *b)* O primeiro nome, o último nome e o telefone dos autores;

```
SELECT au_lname, au_fname, phone
FROM     authors
```

### *c)* Consulta definida em b) mas ordenada pelo primeiro nome (ascendente) e depois o último nome (ascendente); 

```
SELECT TOP (100) PERCENT au_lname, au_fname, phone
FROM     dbo.authors
ORDER BY au_lname, au_fname
```

### *d)* Consulta definida em c) mas renomeando os atributos para (first_name, last_name, telephone); 

```
SELECT TOP (100) PERCENT au_lname AS first_name, au_fname AS last_name, phone AS telephone
FROM     dbo.authors
ORDER BY first_name, last_name
```

### *e)* Consulta definida em d) mas só os autores da Califórnia (CA) cujo último nome é diferente de ‘Ringer’; 

```
SELECT TOP (100) PERCENT au_lname AS first_name, au_fname AS last_name, phone AS telephone, city
FROM     dbo.authors
WHERE  (city = 'CA') AND (au_fname <> 'Ringer')
ORDER BY first_name, last_name
```

### *f)* Todas as editoras (publishers) que tenham ‘Bo’ em qualquer parte do nome; 

```
SELECT TOP (100) PERCENT pub_name
FROM     dbo.publishers
WHERE  (pub_name LIKE '%Bo%')
```

### *g)* Nome das editoras que têm pelo menos uma publicação do tipo ‘Business’; 

```
SELECT TOP (100) PERCENT dbo.publishers.pub_name, dbo.titles.type
FROM     dbo.publishers INNER JOIN
                  dbo.titles ON dbo.publishers.pub_id = dbo.titles.pub_id
WHERE  (dbo.titles.type = 'Business')
```

### *h)* Número total de vendas de cada editora; 

```
SELECT        TOP (100) PERCENT dbo.publishers.pub_name, SUM(dbo.sales.qty) AS Expr1
FROM            dbo.publishers INNER JOIN
                         dbo.titles ON dbo.publishers.pub_id = dbo.titles.pub_id INNER JOIN
                         dbo.sales ON dbo.titles.title_id = dbo.sales.title_id
GROUP BY dbo.publishers.pub_name
```

### *i)* Número total de vendas de cada editora agrupado por título; 

```
SELECT TOP (100) PERCENT dbo.publishers.pub_name, SUM(dbo.sales.qty) AS Expr1, dbo.titles.title
FROM     dbo.publishers INNER JOIN
                  dbo.titles ON dbo.publishers.pub_id = dbo.titles.pub_id INNER JOIN
                  dbo.sales ON dbo.titles.title_id = dbo.sales.title_id
GROUP BY dbo.publishers.pub_name, dbo.titles.title
```

### *j)* Nome dos títulos vendidos pela loja ‘Bookbeat’; 

```
SELECT TOP (100) PERCENT dbo.titles.title, dbo.stores.stor_name
FROM     dbo.titles INNER JOIN
                  dbo.sales ON dbo.titles.title_id = dbo.sales.title_id INNER JOIN
                  dbo.stores ON dbo.sales.stor_id = dbo.stores.stor_id
WHERE  (dbo.stores.stor_name = 'Bookbeat')
```

### *k)* Nome de autores que tenham publicações de tipos diferentes; 

```
SELECT dbo.authors.au_fname, dbo.authors.au_lname
FROM     dbo.titles INNER JOIN
                  dbo.titleauthor ON dbo.titles.title_id = dbo.titleauthor.title_id INNER JOIN
                  dbo.authors ON dbo.titleauthor.au_id = dbo.authors.au_id
GROUP BY dbo.authors.au_fname, dbo.authors.au_lname
HAVING (COUNT(DISTINCT dbo.titles.type) > 1)
```

### *l)* Para os títulos, obter o preço médio e o número total de vendas agrupado por tipo (type) e editora (pub_id);

```
SELECT dbo.titles.type, dbo.titles.pub_id, AVG(dbo.titles.price) AS avg_price, SUM(dbo.sales.qty) AS no_sales
FROM     dbo.titles INNER JOIN
                  dbo.sales ON dbo.titles.title_id = dbo.sales.title_id
GROUP BY dbo.titles.type, dbo.titles.pub_id
```

### *m)* Obter o(s) tipo(s) de título(s) para o(s) qual(is) o máximo de dinheiro “à cabeça” (advance) é uma vez e meia superior à média do grupo (tipo);

```
SELECT type, MAX(advance) AS max_advance, AVG(advance) AS avg_advance
FROM     dbo.titles
GROUP BY type
HAVING (MAX(advance) > 1.5 * AVG(advance))
```

### *n)* Obter, para cada título, nome dos autores e valor arrecadado por estes com a sua venda;

```
SELECT dbo.titles.title, dbo.authors.au_fname, dbo.authors.au_lname, dbo.titles.price * dbo.titles.royalty / 100 * dbo.titleauthor.royaltyper / 100 AS lucro
FROM     dbo.titles INNER JOIN
                  dbo.titleauthor ON dbo.titles.title_id = dbo.titleauthor.title_id INNER JOIN
                  dbo.authors ON dbo.titleauthor.au_id = dbo.authors.au_id
GROUP BY dbo.titles.title, dbo.authors.au_fname, dbo.authors.au_lname, dbo.titles.price * dbo.titles.royalty / 100 * dbo.titleauthor.royaltyper / 100
```

### *o)* Obter uma lista que incluía o número de vendas de um título (ytd_sales), o seu nome, a faturação total, o valor da faturação relativa aos autores e o valor da faturação relativa à editora;

```
SELECT title, ytd_sales, price * ytd_sales AS faturacao, price * ytd_sales * royalty * 1 / 100 AS auths_revenue, (price * ytd_sales) * (100 - royalty) * 1 / 100 AS publisher_revenue
FROM     dbo.titles
```

### *p)* Obter uma lista que incluía o número de vendas de um título (ytd_sales), o seu nome, o nome de cada autor, o valor da faturação de cada autor e o valor da faturação relativa à editora;

```
SELECT TOP (100) PERCENT dbo.titles.title, dbo.titles.ytd_sales, dbo.titles.price * dbo.titles.ytd_sales AS faturacao, dbo.authors.au_fname AS author, 
                  dbo.titles.price * dbo.titles.ytd_sales * dbo.titles.royalty * dbo.titleauthor.royaltyper * 1 / 10000 AS auth_revenue, (dbo.titles.price * dbo.titles.ytd_sales) * (100 - dbo.titles.royalty) * 1 / 100 AS publisher_revenue
FROM     dbo.titles INNER JOIN
                  dbo.titleauthor ON dbo.titles.title_id = dbo.titleauthor.title_id INNER JOIN
                  dbo.authors ON dbo.titleauthor.au_id = dbo.authors.au_id
ORDER BY dbo.titles.title
```

### *q)* Lista de lojas que venderam pelo menos um exemplar de todos os livros;

```
SELECT dbo.stores.stor_name, COUNT(dbo.titles.title) AS n_titles
FROM     dbo.stores INNER JOIN
                  dbo.sales ON dbo.stores.stor_id = dbo.sales.stor_id INNER JOIN
                  dbo.titles ON dbo.sales.title_id = dbo.titles.title_id
GROUP BY dbo.stores.stor_name
HAVING (COUNT(dbo.titles.title) = (SELECT COUNT(title_id) AS Expr1 FROM dbo.titles AS titles_1)).
```

### *r)* Lista de lojas que venderam mais livros do que a média de todas as lojas;

```
SELECT dbo.stores.stor_name, SUM(dbo.sales.qty) AS sales
FROM     dbo.stores INNER JOIN
                  dbo.sales ON dbo.stores.stor_id = dbo.sales.stor_id INNER JOIN
                  dbo.titles ON dbo.sales.title_id = dbo.titles.title_id
GROUP BY dbo.stores.stor_name
HAVING (SUM(dbo.sales.qty) >
                      (SELECT SUM(sales_1.qty) AS Expr1
                       FROM      dbo.stores AS stores_2 INNER JOIN dbo.sales AS sales_1 ON stores_2.stor_id = sales_1.stor_id INNER JOIN
                                         dbo.titles AS titles_1 ON sales_1.title_id = titles_1.title_id) * 1 / (SELECT COUNT(DISTINCT stor_name) AS Expr1 FROM dbo.stores AS stores_1))
```

### *s)* Nome dos títulos que nunca foram vendidos na loja “Bookbeat”;

```
SELECT        TOP (100) PERCENT dbo.titles.title, dbo.stores.stor_name
FROM            dbo.titles INNER JOIN
                         dbo.sales ON dbo.titles.title_id = dbo.sales.title_id INNER JOIN
                         dbo.stores ON dbo.sales.stor_id = dbo.stores.stor_id
WHERE        (dbo.stores.stor_name <> 'Bookbeat')
```

### *t)* Para cada editora, a lista de todas as lojas que nunca venderam títulos dessa editora; 

```
... Write here your answer ...
```

## Problema 6.2

### ​5.1

#### a) SQL DDL Script
 
[a) SQL DDL File](ex_6_2_1_ddl.sql "SQLFileQuestion")

#### b) Data Insertion Script

[b) SQL Data Insertion File](ex_6_2_1_data.sql "SQLFileQuestion")

#### c) Queries

##### *a)*

```
... Write here your answer ...
```

##### *b)* 

```
... Write here your answer ...
```

##### *c)* 

```
... Write here your answer ...
```

##### *d)* 

```
... Write here your answer ...
```

##### *e)* 

```
... Write here your answer ...
```

##### *f)* 

```
... Write here your answer ...
```

##### *g)* 

```
... Write here your answer ...
```

##### *h)* 

```
... Write here your answer ...
```

##### *i)* 

```
... Write here your answer ...
```

### 5.2

#### a) SQL DDL Script
 
[a) SQL DDL File](ex_6_2_2_ddl.sql "SQLFileQuestion")

#### b) Data Insertion Script

[b) SQL Data Insertion File](ex_6_2_2_data.sql "SQLFileQuestion")

#### c) Queries

##### *a)*

```
SELECT stock.fornecedor.nome, stock.encomenda.numero, stock.fornecedor.nif, stock.fornecedor.endereco, stock.fornecedor.fax, stock.fornecedor.condpag, stock.fornecedor.tipo
FROM     stock.fornecedor INNER JOIN
                  stock.encomenda ON stock.fornecedor.nif = stock.encomenda.fornecedor
WHERE  (stock.encomenda.numero IS NULL)
```

##### *b)* 

```
SELECT codProd, AVG(unidades) AS AvgUnidades
FROM     stock.item
GROUP BY codProd
```


##### *c)* 

```
SELECT numEnc, AVG(unidades) AS AvgUnidades
FROM     stock.item
GROUP BY numEnc
```


##### *d)* 

```
SELECT stock.fornecedor.nome, stock.produto.nome AS nomeProduto, SUM(stock.item.unidades) AS Quantidade
FROM     stock.item INNER JOIN
                  stock.produto ON stock.item.codProd = stock.produto.codigo INNER JOIN
                  stock.encomenda ON stock.item.numEnc = stock.encomenda.numero INNER JOIN
                  stock.fornecedor ON stock.encomenda.fornecedor = stock.fornecedor.nif
GROUP BY stock.fornecedor.nome, stock.produto.nome
```

### 5.3

#### a) SQL DDL Script
 
[a) SQL DDL File](ex_6_2_3_ddl.sql "SQLFileQuestion")

#### b) Data Insertion Script

[b) SQL Data Insertion File](ex_6_2_3_data.sql "SQLFileQuestion")

#### c) Queries

##### *a)*

```
... Write here your answer ...
```

##### *b)* 

```
... Write here your answer ...
```


##### *c)* 

```
... Write here your answer ...
```


##### *d)* 

```
... Write here your answer ...
```

##### *e)* 

```
... Write here your answer ...
```

##### *f)* 

```
... Write here your answer ...
```
