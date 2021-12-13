create database film;
use film;

create table podaciFilm(
id int primary key,
naziv nvarchar(50),
trajanje varchar(10),
zanr nvarchar(40),
originalniNaziv varchar(50),
zemljaPorekla nvarchar(20)
);

insert into podaciFilm
values(50, 'Baze 19 ADO Forma', '0:31:09', 'Dokumentarac', 'Baze 19 ADO Forma', 'Srbija'),
(31, 'Trka pacova', '01:52:00', 'Komedija', 'Rat race', 'SAD'),
(22, 'Ратови звезда: Успон Скајвокера', '02:22:00','Naucnofantasticni film', 'Star Wars: The Rise of Skywalker', 'SAD');
