## ​7.2 
 
### *a)*

```
Está na primeira forma normal (1FN), pois não está na segunda forma normal (2FN),
uma vez que existem dependencias parciais (R3), porém os atributos são atómicos e não existem relações dentro de relações.
-> R3 (_Nome_Autor_ -> Afiliacao_Autor)
```

### *b)* 

```
De 1FN para 2FN: Decompor as relações

Livro (_Titulo_, _Autor_, Tipo_Livro, Preco, N_Paginas, Editor, Endereco_Editor, Ano_Publicacao)
Autor (_Autor_, Afiliado_Autor)


De 2FN para 3FN: Decompor as dependencias transitivas:

Livro (_Titulo_, _Autor_, Tipo_Livro, N_Paginas, Editor, Endereco_Editor, Ano_Publicacao)
Tipo_Livro (_Tipo_Livro_, NoPaginas, Preco)
Autor (_Autor_, Afiliado_Autor)
Editor (_Editor_, Endereco_Editor)
.
```




## ​7.3
 
### *a)*

```
A chave de R é {A, B}
```


### *b)* 

```
R1 (_A_, _B_, C)
R2 (_B_, F, G, H)
R3 (_A_, D, E, I, J)
```


### *c)* 

```
R1 (_A_, _B_, C)
F2 (_B_, F)
R3 (_A_, D, E)
R4 (_F_, G, H)
R5 (_D_,I,J)

```


## ​7.4
 
### *a)*

```
A chave de R é {A,B}
```


### *b)* 

```
Decomposição 2FN:
R1 (_A_, _B_, C, D , E)

Decomposição 3FN:
R1 (_B_, C, D)
R2 (_C_,A)
R3 (_D_,E)

Apresenta anomalias na situação da relação (_C_,A)
```


### *c)* 

```
R1 (_C_, _B_, A, D)
R1A (_C_,_B_,D)
R1B (_C_, A)


```



## ​7.5
 
### *a)*

```
A chave de R é {A,B}
```

### *b)* 

```
R1 (_A_,_B_,C, D, E)
R2 (_A_, C)
```


### *c)* 

```
R1 (_A_,_B_, E)
R2 (_A_, C)
R3 (C,D)
```

### *d)* 

```
Como não existe nenhuma violação da 3FN mantemos esta forma quanto à BCNF
R1 (_A_,_B_, E)
R2 (_A_, C)
R3 (C,D)
```
