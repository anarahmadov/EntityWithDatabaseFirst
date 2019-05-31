--use MyDatabase

--create table News
--(
--Id int primary key identity(1,1),
--Content text not null,
--Header nvarchar(Max) not null,
--CreationDate Date not null
--);

--create table Users
--(
--Id int primary key identity(1,1),
--Username nvarchar(20) not null,
--Password nvarchar(20) not null
--);

--create table Comments
--(
--Id int primary key identity(1,1),
--UserId int foreign key references Users(Id) not null,
--NewsId int foreign key references News(Id) on delete cascade not null
--);


--alter table Comments
--add Content nvarchar(max) not null

--insert into News (Content, Header, CreationDate)
--values('При использовании Блокнота в Windows 10 можно удалить 
--или изменить верхние и нижние колонтитулы. По умолчанию в Блокноте используются следующие колонтитулы.','Изменение верхнего 
--и нижнего колонтитула',GETDATE()),
--('Эти команды отображают заголовок документа в верхней части страницы и номер страницы — в нижней
--Эти параметры нельзя сохранить, поэтому все параметры и верхнего, и нижнего колонтитула необходимо вводить вручную каждый раз при печати документа.
--', 'Использование Блокнота для создания файла журнала',GETDATE()),
--('Блокнот-это средство обработки текста, входит в состав Windows и устанавливается по умолчанию в группе программ стандартные. Его можно использовать для создания файла журнала типа, 
--который добавляет текущие дату и время каждый раз, 
--когда открывается файл блокнота. В данной статье описывается, как создать файл журнала с помощью & блокнота.','Дополнительные сведения',GETDATE())

--insert into Users (Username, Password)
--values ('samir123','samir1234'),
--('elvin123','elvin1234'),
--('anar123','anar1234')

--insert into Comments (Content,UserId, NewsId)
--values ('Salam',1,1),
--('Salam',2,2),
--('Salam',3,3)


--create trigger deleteUser
--on Users
--instead of delete
--as
--begin
--delete from Comments
--where Comments.UserId IN (select id from deleted)
--delete from Users
--Where Id IN (select id from deleted)
--end

