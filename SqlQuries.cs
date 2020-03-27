using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class SqlQuries
    {
        //select * from emp

        //INSERT INTO table_name(column1, column2, column3, ...)VALUES(value1, value2, value3, ...);

        //UPDATE table_name SET column1 = value1, column2 = value2, WHERE condition;

        //DELETE FROM table_name WHERE condition;

        //SELECT MIN(Price) AS SmallestPrice FROM Products;

        //AVG
        //SELECT AVG(column_name)FROM table_nameWHERE condition;

        //WHERE CustomerName LIKE '_r%'	Finds any values that have "r" in the second position
        //WHERE CustomerName LIKE 'a__%'	Finds any values that start with "a" and are at least 3 characters in length

        //SELECT* FROM Customers WHERE City LIKE 'ber%';
        //WHERE column_name BETWEEN value1 AND value2

        //SELECT Orders.OrderID, Customers.CustomerName, Orders.OrderDate FROM Orders INNER JOIN Customers ON Orders.CustomerID=Customers.CustomerID;

        //SELECT column_name(s) FROM table1 LEFT JOIN table2 ON table1.column_name = table2.column_name;

        //self join
        //SELECT A.CustomerName AS CustomerName1, B.CustomerName AS CustomerName2, A.City FROM Customers A, Customers B WHERE A.CustomerID<> B.CustomerID AND A.City = B.City ORDER BY A.City;

        //union
        //SELECT column_name(s) FROM table1 UNION SELECT column_name(s) FROM table2;

        //groupby 
        //SELECT COUNT(CustomerID), Country FROM Customers GROUP BY Country HAVING COUNT(CustomerID) > 5 ORDER BY COUNT(CustomerID) DESC;

        //SELECT SupplierName FROM Suppliers WHERE EXISTS(SELECT ProductName FROM Products WHERE Products.SupplierID = Suppliers.supplierID AND Price < 20)


        //Values from one table to another table
        //INSERT INTO table2(column1, column2, column3) SELECT column1, column2, column3 FROM table1 WHERE condition;

        //        CASE
        //    WHEN condition1 THEN result1
        //    WHEN condition2 THEN result2
        //    WHEN conditionN THEN resultN
        //    ELSE result
        //END;

        //        CREATE PROCEDURE procedure_name
        //AS
        //sql_statement
        //GO;

        //ALTER TABLE students   ADD UNIQUE(S_Id)

        // ALTER TABLE students ADD CONSTRAINT uc_StudentId UNIQUE(S_Id, LastName)

        //   CREATE TABLE Persons(
        //    ID int NOT NULL,
        //    LastName varchar(255) NOT NULL,
        //    FirstName varchar(255),
        //    Age int,
        //    CHECK(Age>=18)
        //);

        //        CREATE TABLE Persons(
        //    Personid int NOT NULL AUTO_INCREMENT,
        //    LastName varchar(255) NOT NULL,
        //    FirstName varchar(255),
        //    Age int,
        //    PRIMARY KEY(Personid)
        //);

        //        CREATE VIEW view_name AS
        //SELECT column1, column2, ...
        //FROM table_name
        //WHERE condition;

        //        MERGE sales.category t
        //    USING sales.category_staging s
        //ON (s.category_id = t.category_id)
        //WHEN MATCHED
        //    THEN UPDATE SET
        //        t.category_name = s.category_name,
        //        t.amount = s.amount
        //WHEN NOT MATCHED BY TARGET
        //    THEN INSERT (category_id, category_name, amount)
        //         VALUES (s.category_id, s.category_name, s.amount)
        //WHEN NOT MATCHED BY SOURCE
        //    THEN DELETE;



    }
}
