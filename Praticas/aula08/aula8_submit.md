# BD: Guião 8


## ​8.1. Complete a seguinte tabela.
Complete the following table.

| #    | Query                                                                                                      | Rows  | Cost  | Pag. Reads | Time (ms) | Index used | Index Op.            | Discussion |
| :--- | :--------------------------------------------------------------------------------------------------------- | :---- | :---- | :--------- | :-------- | :--------- | :------------------- | :--------- |
| 1    | SELECT * from Production.WorkOrder                                                                         | 72591 | 0.97  | 618        | 12        |   [PK_WorkOrder_WorkOrderID]      | Clustered Index Scan |            |
| 2    | SELECT * from Production.WorkOrder where WorkOrderID=1234                                                  |   1   |    1  |     26     |    0      |   [PK_WorkOrder_WorkOrderID]      | Clustered Index Seek |            | 
| 3.1  | SELECT * FROM Production.WorkOrder WHERE WorkOrderID between 10000 and 10010                               |   12  |    1  |     220    |    0      |   [PK_WorkOrder_WorkOrderID]      | Clustered Index Seek |            |  
| 3.2  | SELECT * FROM Production.WorkOrder WHERE WorkOrderID between 1 and 72591                                   | 72591 | 0.97  |    556     |    36     |   [PK_WorkOrder_WorkOrderID]      | Clustered Index Seek |            |
| 4    | SELECT * FROM Production.WorkOrder WHERE StartDate = '2012-05-14'                                          | 72591 | 0.91  |    750     |    17     |   [PK_WorkOrder_WorkOrderID]      | Clustered Index Scan |            |
| 5    | SELECT * FROM Production.WorkOrder WHERE ProductID = 757                                                   | 11    | 0.09  |    240     |    0      |   [IX_WorkOrder_WorkOrderID]      | Clustered Index Seek |            |
| 6.1  | SELECT WorkOrderID, StartDate FROM Production.WorkOrder WHERE ProductID = 757                              | 11    | 1     |    220     |    0      |   [IX_WorkOrder_WorkOrderID]      | Clustered Index Seek |            |
| 6.2  | SELECT WorkOrderID, StartDate FROM Production.WorkOrder WHERE ProductID = 945                              | 1105  | 1     |    225     |    0      |   [IX_WorkOrder_WorkOrderID]      | Clustered Index Seek |            |
| 6.3  | SELECT WorkOrderID FROM Production.WorkOrder WHERE ProductID = 945 AND StartDate = '2011-12-04'            | 2     |    1  |    752     |    11     |   [PX_WorkOrder_WorkOrderID]      | Clustered Index Scann|            |
| 7    | SELECT WorkOrderID, StartDate FROM Production.WorkOrderWHERE ProductID = 945 AND StartDate = '2011-12-04'  | 118   |    1  |    235     |    0      |   [NonClusteredIndex-20230504-125648] | Clustered Index Seek |        |
                                                                                                                    | 1105  |    1  |    235     |    0      |   [IX_WorkOrder_WorkOrderID]      | Clustered Index Seek |            |
| 8    | SELECT WorkOrderID, StartDate FROM Production.WorkOrder WHERE ProductID = 945 AND StartDate = '2011-12-04' | 1     | 1     | 222        | 0         |   [IX_WorkOrder_WorkOrderID]      | Clustered Index Seek |            |

## ​8.2.

### a)

```
ALTER TABLE mytemp ADD CONSTRAINT mytemp_pk PRIMARY KEY CLUSTERED (rid);
```

### b)

```
Resultados: tempo= 48413 fragindex=98.76 %		ocupagina=68.47 %		ninserts=50000
```

### c)

```
- Resultados:	tempo= 53583 fragindex=99.15 %		ocupagina=70.25 % 		ninserts=50000	fill=90					
- Resultados:	tempo= 56650 fragindex=99.23 % 		ocupagina=63.10 %		ninserts=50000	fill=80	
- Resultados:	tempo= 58993 fragindex=99.17 %		ocupagina=63.19 %		ninserts=50000	fill=65	
```

### d)

```
- Resultados: 	tempo= 28102 fragindex=98.82 %		ocupagina=68.99 %		ninserts=50000	fill=80	
- Resultados: 	tempo= 35173 fragindex=99.02 %		ocupagina=68.17 %		ninserts=50000	fill=90	
```

### e)

```
A inserçao com todos os indices é mais lenta devido a ter que ser executada a mesma operaçao para cada um
```

## ​8.3.

```
i. CREATE UNIQUE CLUSTERED INDEX IdxSsn ON employee (Ssn);

ii. CREATE INDEX IdxFnameLname ON employee (Fname, Lname);

iii. CREATE INDEX IdxDno ON employee (Dno);

iv. CREATE CLUSTERED INDEX IdxEssnPno ON works_on (Essn, Pno);

v. CREATE CLUSTERED INDEX IdxEssn ON dependent (Essn);

vi. CREATE INDEX IdxDnum ON project (Dnum);
```


