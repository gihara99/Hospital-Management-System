create Database Hospital;
----------------------------------------------------------------------------------------------------------------------------------------------------------------
use Hospital;


-----------------------------------------------------------------------------------------------------------------------------------------------------------------

--Patient_Table

create table patient_Registration
(Patient_Name varchar(30) primary key, Dob date,Age int,Patient_Password varchar(15),Patient_Address varchar(15),Mobile_Number int,Email varchar(20));

insert into patient_Registration values('Dumindu','2000-08-11',23,'dumindu23','Horana',0772705100,'dumindu@gmail.com'); 
-----------------------------------------------------------------------------------------------------------------------------------------------------------------
select *from patient_Registration;

------------------------------------------------------------------------------------------------------------------------------------------------------------------
--User login info--

create table User_login_info
(UserName varchar(20) primary key,Userpassword varchar(20),UserRole varchar(10));

insert into User_login_info values
('Admin1','admin123','Admin');
insert into User_login_info values

insert into User_login_info values
('Gunathilaka','gunathilaka56','Doctor');

------------------------------------------------------------------------------------------------------------------------------------------------------------------


select *from User_login_info;

select count (*) from patient_Registration;

delete from User_login_info where UserName= 'Edmond';

------------------------------------------------------------------------------------------------------------------------------------------------------------------

--Doctor table

create table Doctors
(Doctor_Name varchar(20) primary key,Specialisty varchar(30));

insert into Doctors values
('Gunathilaka','Family medicine');

select * from Doctors;

-------------------------------------------------------------------------------------------------------------------------------------------------------------------
--Appoinments--

create table Appoinments
(Full_Name varchar(20) primary key,Contact_Number int,Email varchar(20),Appoinment_Date date,Specialisty varchar(20),Doctor varchar(15));

select * from Appoinments;

select * from Appoinments where Specialisty;

