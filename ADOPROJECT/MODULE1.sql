create database project1
use project1


----------------module 1 (product page) -------------------------------------------------

create table product(pid int primary key,pname varchar(30),pdesc varchar(100))

create procedure insprod(@pid int,@pname varchar(30),@pdesc  varchar(100))
as
insert into product values(@pid,@pname,@pdesc)

exec insprod 101,'LED TV','SONY'
exec insprod 102,'LCD TV','TCS'
exec insprod 103,'PHONE','ANDROID'

create procedure updprod(@pid int,@pname varchar(30),@pdesc varchar(100))
as
update product set pname=@pname,pdesc=@pdesc  where pid=@pid

EXEC updprod 101,'PHONE','OPPO'

create procedure disprod
as
select * from product

exec disprod 
create procedure disprod1(@pid int)
as
select * from product where pid=@pid

exec disprod1 103


create procedure delprod(@pid int)
as 
delete from product where pid=@pid
exec delprod 101

select @@SERVERNAME


------------------module 2 (user page) ----------------------------

create table usertable(uid varchar(10),pwd varchar(12),usrtype varchar(20))

create procedure insuser(@uid varchar(10),@pwd varchar(12),@usrtype varchar(20))
as
insert into usertable values(@uid,@pwd,@usrtype)

exec insuser 'ANAND','@2000','ADMIN'
exec insuser 'KUMAR','@0108','USER'

select * from usertable

create procedure viewuser
as 
select * from usertable


create procedure viewuserid(@uid varchar(10))
as
select * from usertable where uid=@uid

create procedure upduser(@uid varchar(10),@pwd varchar(12),@usrtype varchar(20))
as
update usertable set pwd=@pwd,usrtype=@usrtype where uid=@uid



create procedure deluser(@uid varchar(10))
as
delete from usertable where @uid=uid

-------------------------module 3  (model page)--------------------------

create table model(pid int references product(pid),pname varchar(30),mid int primary key,mname varchar(30),spec varchar(100),uprice int,soh int)


create procedure insmodel(@pid int,@pname varchar(30),@mid int,@mname varchar(30),@spec varchar(100),@uprice int,@soh int)
as
insert into model values(@pid,@pname,@mid,@mname,@spec,@uprice,@soh)

create procedure updmodel(@pid int,@pname varchar(30),@mid int,@mname varchar(30),@spec varchar(100),@uprice int,@soh int)
as
update model set pid=@pid,pname=@pname,mname=@mname,spec=@spec,uprice=@uprice,soh=@soh where mid=@mid



create procedure viewmodel
as
select * from model
exec viewmodel

create procedure viewmodelbyid(@mid int)
as
select * from model where mid=@mid


create procedure delmodel(@mid int)
as 
delete from model where mid=@mid

exec delmodel 1001

-------MODULE 4(LOGIN page)------------

create procedure chklog(@uid varchar(10),@pwd varchar(12),@usrtype varchar(20))
as
select count(*) from usertable where uid=@uid and pwd=@pwd and usrtype=@usrtype

select * from usertable
exec chklog 'ANAND','@200','ADMIN'

                                                                     
------------viewmodel sales page---------------------------------------
create table sales(billno int identity,billdate date default getdate(),pid int,pname varchar(30),mid int,mname varchar(30),spec varchar(100),uprice int,qty int,totamt int)
insert into sales (pid ,pname ,mid,mname,spec,uprice ,qty ,totamt)values(1,'Mobile',1000,'Samsung s100','8Gb Ram,Dual Camara',17000,2,34000)

create procedure InsSales(@pid int,@pname varchar(30),@mid int,@mname varchar(30),@spec varchar(100),@uprice int,@qty int,@totamt int)
as
insert into sales(pid ,pname ,mid,mname,spec,uprice ,qty ,totamt) values(@pid,@pname,@mid,@mname,@spec,@uprice,@qty,@totamt)

select * from sales

-------------------------reports page-----------------------------------------

create procedure DailyRpt
as
select * from sales where billdate =cast(getdate() as date)

exec DailyRpt

alter procedure SalesRpt(@fdate datetime,@tdate datetime)
as
select * from sales where billdate between @fdate and @tdate

exec SalesRpt '2022-11-04','2022-11-05'

create procedure ProductRpt(@pid int)
as
select * from sales where pid=@pid

exec ProductRpt 101

create procedure ModelRpt(@mid int)
as
select * from sales where mid=@mid

exec ModelRpt 1000



