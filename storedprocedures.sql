USE BookLibrary;
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------------------------------------------
Create procedure return_employee
AS 
Begin
SELECT * FROM Employee
END
GO

-----------------------------------------------
Create procedure updatesalary
       @salary int ,
	   @id int
AS
Begin
update Employee set Salary =@salary where acc_ID=@id;
END
GO
 
 ---------------------------------------------------
create procedure bookbyname @bookname varchar(100)
AS
Begin
select * from Books where title = @bookname;
END
GO
------------------------------------------------------
create procedure select_title_genre @genre varchar(50)
AS
Begin
select title from Books where genre= @genre;
END
GO

--------------------------------------------------------
create procedure insertpurchase 
    @purchaseid int ,
	@purchasedate date,
	@empssn int,
	@customerid int
AS
Begin
insert into Purchase values(@purchaseid,@purchasedate,@empssn,@customerid);
END
GO
---------------------------------------------------------
create procedure insertpurchasebooks
    @purchaseid int ,
	@ISBN char(14)
AS
Begin
insert into Purchased_Books values(@purchaseid,@ISBN);
END
GO
-----------------------------------------------------------
create procedure getcustomerinfo @custid int
AS
Begin
select  cust_ID,cust_name, cust_address,userPassword,acc_state,acc_type from Customer,Account where cust_ID= @custid and ID=cust_ID;
END
GO
----------------------------------------------
create procedure returncustomerid 
AS
Begin
Select cust_ID from Customer;
END
GO
---------------------------------------
create procedure customerlend
   @orderid int,
   @resdata date,
   @ISBN char(14),
   @ssn char(14),
   @cusid int
AS
Begin
insert into Book_lending values(@orderid,@resdata,@ISBN,null,@cusid);
END
GO
---------------------------------------------------
create procedure selectlend @orderid int 
AS
Begin
select  * from Book_lending where order_ID= @orderid;
END 
GO
------------------------------------------------
create procedure selectssnbyempid @empid int
AS
Begin
select  SSN from Employee where acc_ID= @empid;
END 
GO