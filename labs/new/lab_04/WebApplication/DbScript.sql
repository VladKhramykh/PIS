drop database Khramykh_ASP_04;
create database Khramykh_ASP_04;
use Khramykh_ASP_04;

create table users
(
	id  int identity(1,1),
	name nvarchar(255),
	phoneNumber nvarchar(50),
	primary key(id)
);

insert into users	values	('Vlad Khramykh', '+375298207908'),
							('Sasha Soikel',  '+375293442128'),
							('Denis Kalach',  '+375292071881'),
							('Vodem Dokurno', '+375293343392');