/# BD: Guião 9


## ​9.1
 
### *a)*

```
USE Empresa
GO

CREATE PROCEDURE deleteEmployee 
	@issn as char(9),
	@RegisterId uniqueidentifier, 
	@Status varchar(16) output,
	@Message varchar(255) output
as
begin
	set nocount on;
	begin try
		begin tran

			DELETE FROM Works_on WHERE Essn = @issn;

			DELETE FROM Dependent WHERE Essn = @issn;

			UPDATE Department SET Mgr_ssn = NULL WHERE Mgr_ssn = @issn;

			UPDATE Employee SET Super_ssn = NULL WHERE Super_ssn = @issn;

			DELETE FROM EMPLOYEE WHERE Ssn = @issn;

		commit tran;
		set @Status = 'Success';
		set @Message = 'Remoção com sucesso';
	end try
	begin catch	
		if (@@TRANCOUNT > 0)
			rollback tran;
		set @Status = 'Failed';
		set @Message = 'Erro na remoção. (' + ERROR_MESSAGE() + ')';
	end catch

end
go
```

### *b)* 

```
USE Empresa
GO

CREATE PROC RecGest (@anosout CHAR(9) OUTPUT, @ssnout INT OUTPUT,
	@RegisterId uniqueidentifier, 
	@Status varchar(16) output,
	@Message varchar(255) output)
as
begin
	set nocount on;
	begin try
		begin tran
		SELECT * FROM (Employee JOIN Department ON Ssn = Mgr_ssn);

		(SELECT TOP 1 @anosout = MAX(DATEDIFF(year,Department.Mgr_start_date,getDate())), @ssnout = Department.Mgr_ssn
		FROM Employee JOIN Department ON Ssn = Mgr_ssn
		GROUP BY Department.Mgr_start_date, Department.Mgr_Ssn)

		commit tran;
		set @Status = 'Success';
		set @Message = 'Remoção com sucesso';
	end try
	begin catch	
		if (@@TRANCOUNT > 0)
			rollback tran;
		set @Status = 'Failed';
		set @Message = 'Erro na remoção. (' + ERROR_MESSAGE() + ')';
	end catch

end
go
```

### *c)* 

```
USE Empresa
GO

CREATE Trigger funcAvoid ON Department
AFTER INSERT, UPDATE
AS
	SET NOCOUNT ON;
	DECLARE @mSSN CHAR(9);
	SELECT @mSSN=Msr_ssn FROM inserted;

	IF EXISTS( SELECT Msr_ssn FROM Department WHERE Msr_ssn=@mSSN )
	BEGIN
		RAISERROR ('Ha manager de departamento!', 16,1);
		ROLLBACK TRAN;
	END
 GO
```

### *d)* 

```
USE Empresa
GO

CREATE TRIGGER checkMoney on Employee
AFTER INSERT, UPDATE
AS
	BEGIN
		SET NOCOUNT ON;

		DECLARE @Msalario DECIMAL(6,2)
		DECLARE @Dno INT
		DECLARE @ssn CHAR(9)
		DECLARE @salario DECIMAL(6,2)
		SELECT @Dno=Dno, @salario=Salary, @ssn=Ssn FROM inserted;

		SELECT @Msalario=Salary
		FROM Department JOIN Employee ON Msr_ssn=Ssn
		WHERE Dnumber=@Dno

		IF (@salario > @MSalario)
		BEGIN
			UPDATE Employee
			SET Salary=@MSalario - 1
			WHERE Ssn=@ssn
		END
	END
GO
```

### *e)* 

```
USE Empresa
GO

CREATE FUNCTION employeeProjects (@ssn char(9)) RETURNS TABLE
AS
    RETURN (SELECT Employee.Fname + ' ' + Employee.Minit + '. ' + Employee.Lname as Name, Plocation FROM Works_on INNER JOIN Employee ON Essn = Ssn INNER JOIN PROJECT pr ON Pno = Pnumber WHERE Essn = @ssn);

GO
```

### *f)* 

```
USE Empresa
GO

CREATE FUNCTION Dnov (@dno INT)
RETURNS @table TABLE
(
  Fname VARCHAR,
  Lname VARCHAR,
  Ssn INT
)
AS
    BEGIN
        DECLARE @avgSalary DECIMAL(10,2)
        SET @avgSalary = SELECT(AVG(Salary) FROM Employee WHERE Dno=@dno)
        INSERT @table
        SELECT Fname, Lname, Ssn FROM Employee WHERE Dno=@dno AND Salary > @avgSalary
        RETURN
    END;
GO
```

### *g)* 

```
USE Empresa
GO

CREATE FUNCTION employeeDeptHighAverage (@Dno INT) RETURNS @Pbudget TABLE (pname varchar(15), pnumber int primary key, plocation varchar(15), dnum int, budget numeric(10,2), totalbudget numeric(10,2)) AS
BEGIN

    DECLARE C CURSOR FOR SELECT Pname, Pnumber, Plocation, Dnum FROM PROJECT WHERE Dnum = @Dno;
    OPEN C;

    DECLARE @name AS varchar(15), @pnum AS INT, @location AS varchar(15), @dnum AS INT;
    FETCH C INTO @name, @pnum, @location, @dnum;
    
    DECLARE @prevBudget AS numeric(10,2);
    SET @prevBudget = 0;

    WHILE @@FETCH_STATUS = 0
        BEGIN

            DECLARE @cost AS numeric(10,2);
            SELECT @cost = SUM(wo.Hours * em.Salary / 40) FROM Works_on wo INNER JOIN EMPLOYEE em ON em.Ssn = wo.Essn WHERE wo.Pno = @pnum;
            
            SET @prevBudget += @cost;
        
            INSERT INTO @Pbudget VALUES (@name, @pnum, @location, @dnum, @cost, @prevBudget);
            
            FETCH C INTO @name, @pnum, @location, @dnum;

        END

    CLOSE C;
    DEALLOCATE C;

    RETURN;
END
```

### *h)* 

```
USE Empresa
GO

CREATE TRIGGER delDepInst ON Department
INSTEAD OF DELETE
AS
		BEGIN
			DECLARE @Dname VARCHAR(30);
			DECLARE @Dnumber int;
			DECLARE @Msr_ssn int;
			DECLARE @Mgr_start_date date;

			SELECT @Dname = Dname FROM deleted;
			SELECT @Dnumber = Dnumber FROM deleted;
			SELECT @Msr_ssn = Msr_ssn FROM deleted;
			SELECT @Mgr_start_date = Mgr_start_date FROM deleted;

			IF (NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES
				WHERE TABLE_SCHEMA = 'Empresa' AND TABLE_NAME = 'Department_DELETED'))
				CREATE TABLE Department_DELETED (Dname VARCHAR(30), Dnumber int, Msr_ssn int NULL, Mgr_start_date date NULL);
			INSERT INTO Department_DELETED VALUES (@Dname, @Dnumber, @Msr_ssn, @Mgr_start_date);
			DELETE FROM Department WHERE Dnumber = @Dnumber; 
		END		
GO

CREATE TRIGGER delDepAfter ON Department
AFTER DELETE
AS
		BEGIN
			DECLARE @Dname VARCHAR(30);
			DECLARE @Dnumber int;
			DECLARE @Msr_ssn int;
			DECLARE @Mgr_start_date date;

			SELECT @Dname = Dname FROM deleted;
			SELECT @Dnumber = Dnumber FROM deleted;
			SELECT @Msr_ssn = Msr_ssn FROM deleted;
			SELECT @Mgr_start_date = Mgr_start_date FROM deleted;

			IF (NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES
				WHERE TABLE_SCHEMA = 'Empresa' AND TABLE_NAME = 'Department_DELETED'))
				CREATE TABLE Department_DELETED (Dname VARCHAR(30), Dnumber int, Msr_ssn int NULL, Mgr_start_date date NULL);
			INSERT INTO Department_DELETED VALUES (@Dname, @Dnumber, @Msr_ssn, @Mgr_start_date);
		END			

GO
--Vantagens after:
--É fácil de implementar e pode ser usado para realizar tarefas simples, como registrar as mudanças feitas em uma tabela.

--Pode ser usado para validar a integridade referencial dos dados em tabelas relacionadas.

--É útil para atualizar outras tabelas que dependem dos dados atualizados ou excluídos.

--Desvantagens after:
--Pode resultar em um aumento significativo no tempo de resposta da consulta.

--Pode resultar em alterações inesperadas em outras tabelas relacionadas.

--Vantagens instead of:
--Pode ser usado para realizar validação de dados mais complexa, como verificar se há conflitos de dados em tabelas relacionadas.

--Pode ser usado para simular uma operação base de dados quando a tabela real não existe.

--Permite controlar completamente o comportamento de uma consulta, incluindo a forma como os dados são retornados.


--Desvantagens instead of:
--Requer mais esforço e habilidade para implementar

--Pode ser menos eficiente do que AFTER em consultas simples.

--Não pode ser usado para atualizar outras tabelas que dependem dos dados atualizados ou eliminados.
```

### *i)* 

```
Mais valias e características distintivas:

Stored procedures:

São armazenados na base de dados e podem ser executados várias vezes.
Permitem passagem de parâmetros de entrada e saída.
Podem ser utilizados para executar operações complexas que envolvem várias consultas, atualizações ou exclusões de dados, gerenciar transações e garantir a integridade dos dados, restringir o acesso direto dos usuários às tabelas ou visualizações subjacentes, utilizados para melhorar o desempenho de consultas frequentes, armazenando resultados em cache.
UDFs:

Permitem definir funções personalizadas que podem ser utilizadas em consultas SQL.
Podem ser definidos para retornar um valor escalar, uma tabela ou uma tabela em linha.
São geralmente mais simples do que os stored procedures e são projetados para executar operações mais simples, como cálculos matemáticos, formatação de dados, etc.
Podem ser utilizados para simplificar as consultas SQL, reduzindo a quantidade de código necessário.
Podem ser utilizados para melhorar o desempenho de consultas complexas, encapsulando cálculos repetitivos em uma função reutilizável.
Em termos de situações em que devem ser utilizados, aqui estão alguns exemplos:

Stored procedures:

Para executar operações complexas que envolvem várias atualizações ou exclusões de dados em várias tabelas.
Para gerenciar transações e garantir a integridade dos dados em situações críticas.
Para restringir o acesso direto dos utliziadores às tabelas ou visualizações subjacentes.
Para melhorar o desempenho de consultas frequentes, armazenando resultados em cache.

UDFs:

Para executar cálculos personalizados que são frequentemente usados em consultas SQL.
Para simplificar consultas SQL complexas, encapsulando cálculos repetitivos em uma função reutilizável.
Para melhorar o desempenho de consultas complexas, reduzindo a quantidade de código necessário.
```
