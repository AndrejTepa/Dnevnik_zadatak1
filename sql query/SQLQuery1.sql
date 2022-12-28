create database dnevnik
use dnevnik
create table ucenici
(
id int not null identity(1,1) primary key,
ime nvarchar(20) not null,
prezime nvarchar(20) not null,
odeljenje nvarchar(10) not null,
grupa nvarchar(10) not null
)
create table uloga
(
id int not null identity (1,1) primary key,
naziv nvarchar(20)
)
create table osoba
(
id int not null identity(1,1) primary key,
ime nvarchar(20) not null,
prezime nvarchar(20) not null,
adresa nvarchar(50) not null,
jmbg nvarchar(15) not null,
email nvarchar(25) not null,
pass nvarchar(25) not null,
uloga int REFERENCES uloga(id)
)