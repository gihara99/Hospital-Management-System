create Database Hospital;

use Hospital;
create table patient_Registration
(Patient_Name varchar(30) primary key, Dob date,Age int,Patient_Password varchar(15),Patient_Address varchar(15),Mobile_Number int,Email varchar(20));

insert into patient_Registration values('Dumindu','2000-08-11',23,'dumindu23','Horana',0772705100,'dumindu@gmail.com'); 


