-------------Database creation-------------
Create database BookLibrary
GO
use BookLibrary

------------Table Creation-----------------

create table Account
(
ID int,
userPassword nvarchar(50) not null,
acc_state nvarchar(50),
acc_type char(1),
Primary key (ID),
)

create table Customer
(
cust_ID int,
cust_name nvarchar(50) not null,
cust_address nvarchar(50),
Primary key (cust_ID),
foreign key(cust_ID)references Account(ID) on Delete cascade on update cascade
)
create table Employee
(
SSN char(14),
emp_name nvarchar(50) not null,
gender char(1) not null,
Salary int,
acc_ID int,
Primary key (SSN),
foreign key(acc_ID)references Account(ID) on Delete cascade on update cascade
)

create table Purchase
(
p_ID int,
p_date date,
Emp_SSN char(14),
customer_ID int,
Primary key (p_ID),
foreign key (Emp_SSN) references Employee(SSN) on Delete no action on update no action,
foreign key (customer_ID) references Customer(cust_ID) on delete no action on update cascade
)

create table Section
(
section_ID int,
primary key (section_ID)
)

create table Rack
(
Rack_ID int,
sec_ID int,
primary key(Rack_ID),
foreign key (sec_ID) references Section(section_ID) on delete cascade on update cascade
)

create Table Books
(
ISBN char(14),
genre nvarchar(50),
title nvarchar(50),
rackid int ,
secid int ,
price char(14),
primary key(ISBN),
foreign key(rackid) references Rack(Rack_ID) on delete set default on update cascade,
foreign key (secid) references Section on delete no action on update No action
)

create Table Purchased_Books
(
pur_ID int not null,
ISBN char(14) not null,
primary key(pur_ID, ISBN),
foreign key (pur_ID) references Purchase(p_ID) on delete cascade on update cascade,
foreign key (ISBN) references Books(ISBN) on delete cascade on update cascade
)

create Table Author 
(
 Author_ID int ,
 auth_Name varchar(100) not null,
 primary key (Author_ID)
)

create Table Writes
(
 Author_ID int not null ,
 ISBN char(14) not null ,
 primary key (Author_ID,ISBN),
 foreign key (Author_ID) references Author(Author_ID) on delete cascade on update cascade,
 foreign key (ISBN) references Books(ISBN) on delete cascade on update cascade 
)

create Table Manager 
(
 ID int ,
 man_Name varchar(100) not null,
 man_shift char(1) ,
 Account_ID  int ,
 primary key (ID),
 foreign key (Account_ID) references Account (ID) on delete cascade on update cascade
)

create Table Book_lending
(
 order_ID int ,
 ord_Date date ,
 ISBN char(14),
 SSN char(14)  ,
 customer_ID int not null,
 primary key (order_ID),
 foreign key (ISBN) references Books (ISBN) on delete cascade on update cascade,
 foreign key (SSN) references Employee(SSN) on delete set default on update cascade,
 foreign key (customer_ID) references Customer (cust_ID) on delete no action on update no action
)

create Table Book_reservation
(
 order_ID int ,
 reserve_date date ,
 ISBN char(14) not null,
 SSN char(14) ,
 customer_ID int not null,
 primary key (order_ID),
 foreign key (ISBN) references Books (ISBN) on delete cascade on update cascade,
 foreign key (SSN) references Employee(SSN) on delete set default on update cascade,
 foreign key (customer_ID) references Customer (cust_ID) on delete no action on update no action
)

create Table bonus 
(
 Employee_SSN char(14) not null ,
 bonus_date date ,
 Manager_ID int not null ,
 bonus_percentage float not null,
 primary key (Employee_SSN,bonus_date,Manager_ID),
 foreign key (Employee_SSN) references Employee (SSN) on delete cascade on update cascade,
 foreign key (Manager_ID) references Manager (ID) on delete no action on update no action
)

create Table Notification_table
(
 notification_timest datetime default current_timestamp  ,
 no_type varchar(50) ,
 no_description varchar(100),
 acc_ID int not null,
 emp_SSN char(14),
 primary key (notification_timest,acc_ID),
 foreign key (acc_ID) references Customer(cust_ID) on delete no action on update cascade,
 foreign key (emp_SSN) references Employee(SSN) on delete no action on update no action
)

insert into Author 
values
(1, 'J.K.Rawling'),
(2, 'Agatha Christie'),
(3, 'Nageeb Mahfouz'),
(4,'Ahmed Khaled Tawfiq'),
(5,'Colleen Hoover'),
(6,'Holly Black'),
(7,'Christina Lauren')

insert into Section 
values 
(1),
(2),
(3),
(4)

insert into Rack 
values 
(1,1),
(2,1),
(11,2),
(12,3)

insert into Books
values 
(1234,'Fiction','Confess',1,1,'$10'),
(1235,'Crime','Verity',2,1,'$7'),
(1236,'Fantasy','The Cruel Prince',12,3,'$20'),
(1237,'Romance','The UnHoneymooners',11,2,'$15')

insert into Writes
values
(5,1234),
(5,1235),
(6,1236),
(7,1237)

insert into Account
values
(1,'ahmed12','activated','M'),
(2,'mariam#45','activated','E'),
(3,'habiba_12','activated','C'),
(4,'omar15','activated','E'),
(5,'mohamed_50','activated','C')

insert into Manager
values
(11,'Ahmed','M',1)

insert into Customer
values 
(3,'Habiba','Maadi'),
(5,'Mohamed','Giza')

insert into Employee
values
(13,'Mariam','F',3000,2),
(14,'Omar','M',2500,4)

insert into Purchase
values
(1,'2022-11-11',13,3),
(2,'2022-11-12',14,5)
insert into Purchased_Books
values
(1,1234),
(2,1235)

insert into Book_lending
values
(2000,'2022-01-03',1236,14,5)

insert into Book_reservation
values
(3000,'2022-05-02',1237,13,3)

insert into  Bonus
values
(13,'2022-01-01',11,10),
(14,'2022-10-06',11,10)

insert into Notification_table
values
(current_timestamp,'Warning','The deadline of returning the book has passed',5,13)
