# BD: Guião 5


## ​Problema 5.1
 
### *a)*

```
(π Pname, Pnumber (project) ⨝Pnumber=Pno works_on) ⨝ Essn= Ssn (π Fname, Lname, Ssn (employee))
```


### *b)* 

```
π Fname,Minit,Lname,employee.Ssn (employee ⨝ employee.Super_ssn=supervisor.Ssn (ρ supervisor (π Ssn (σ (Fname='Carlos' ∧ Minit='D' ∧ Lname='Gomes') (employee)))))
```


### *c)* 

```
γ Pnumber,Pname; Thours←sum(Hours) (project⨝ Pnumber=Pno works_on)
```


### *d)* 

```
πFname,Minit,Lname σDnumber=3 ∧ Hours> 20 ∧ Pname='Aveiro Digital' (employee⨝Ssn=Essn (department⨝Dnumber=Dnum (project⨝Pnumber=Pno works_on)))
```


### *e)* 

```
πFname, Minit, Lname σPnumber=null (employee⟕Ssn=Essn (project⨝Pnumber=Pno works_on))
```


### *f)* 

```
γ Dname;avg(Salary)->Avg_Salary (σ Sex='F' (department ⨝ Dno=Dnumber employee))
```


### *g)* 

```
σ dependents.DependentsNumber > 2 (ρ dependents (γ Fname, Minit, Lname; count(Dependent_name)->DependentsNumber (employee ⨝(Ssn=Essn) dependent)))
```


### *h)* 

```
π Fname,Minit,Lname (σ Essn=null (dependent ⟖(Essn=Ssn) (ρ managers (employee ⨝(Ssn=Mgr_ssn) department))))
```


### *i)* 

```
π Fname,Minit,Lname,Address (σ Dlocation≠'Aveiro' (dept_location ⨝(Dnumber=Dno) (σ Plocation='Aveiro' (project ⨝ (Pnumber=Pno) (works_on ⨝ (Ssn=Essn) employee)))))
```


## ​Problema 5.2

### *a)*

```
π nif,nome,fax,endereco,tipo,condpag (σ numero=null (fornecedor ⟕(nif=fornecedor) encomenda))
```

### *b)* 

```
γ codProd;avg(unidades)->numUnidades item
```


### *c)* 

```
γ numEnc;count(numEnc)-> numUnidades item
```


### *d)* 

```
γ fornecedor.nome, produto.nome; sum(item.unidades)->quantidade (π fornecedor.nome, produto.nome,item.unidades (produto ⨝(codigo=codProd) (item ⨝(numEnc=numero) (fornecedor ⨝(nif=fornecedor) encomenda))))
```


## ​Problema 5.3

### *a)*

```
σ numeroUtente = null (paciente ⟕ numUtente = numeroUtente ρ numeroUtente←numUtente (prescricao))
```

### *b)* 

```
γ especialidade;count(especialidade)->numeroPrescricoes (σ farmacia ≠ null (medico ⨝ numSNS = numMedico prescricao))
```


### *c)* 

```
γ nome;count(nome)->numeroPrescricoes (σ farmacia ≠ null (farmacia ⨝ nome = farmacia prescricao))
```


### *d)* 

```
σ numPresc = null (σ numRegFarm = 906 (farmaco) ⟕ nome = nomeFarmaco σ numRegFarm = 906 (presc_farmaco))
```

### *e)* 

```
γ farmacia.nome, farmaceutica.nome; count(farmaco.nome)->numFarmacos (farmaceutica ⨝(numReg=farmaco.numRegFarm) (farmaco ⨝(farmaco.nome=presc_farmaco.nomeFarmaco) (presc_farmaco ⨝(presc_farmaco.numPresc=prescricao.numPresc) (farmacia ⨝(nome=farmacia) prescricao))))
```

### *f)* 

```
π paciente.nome,paciente.numUtente (σ numMedicos>1 (γ paciente.nome,paciente.numUtente; count(medico.numSNS)->numMedicos (π paciente.nome,paciente.numUtente,medico.numSNS (medico ⨝(medico.numSNS=prescricao.numMedico) (paciente ⨝(paciente.numUtente=prescricao.numUtente) prescricao)))))
```
