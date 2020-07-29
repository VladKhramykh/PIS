create database PIS_CONTACT;
use PIS_CONTACT;

drop table Contacts;

create table Contacts
(
	id bigint primary key identity(1,1),
	surname varchar(50) null,
	phone varchar(50)
);

insert into Contacts values ('valera', '+375299987856');

select * from Contacts;