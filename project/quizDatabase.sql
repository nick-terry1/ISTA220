-- description: This is the creation of the tables and some sample content for my quiz program
-- author: nick terry
-- date: april 9, 2018

use Quiz;

create table Users (
userID int  primary key,
password varchar(30) not null,
userName varchar(30) not null
);

create table Subjects (
subjectID int not null,
subjectTitle varchar(50) not null,
userID int not null,
primary key (subjectID),
foreign key (userID) references Users(userID)
);

create table Questions (
questionID int not null,
subjectID int not null,
questionContent text not null,
answerID int not null,
primary key (questionID),
foreign key (subjectID) references Subjects(subjectID),
);

create table Answers (
answerID int not null,
answerContent text not null,
correct bit not null,
questionID int not null,
primary key (answerID),
foreign key (questionID) references Questions(questionID)
);

insert into dbo.Users
values (1,'pa$$word','nickt');

insert into dbo.Subjects
values  (1,'Math',1),
		(2,'English',1),
		(3,'History',1);

insert into dbo.Questions
values	(1,1,'whats 2 + 2?',1),
		(2,1,'whats 1 * 1?',5),
		(3,2,'what does happy rhyme with?',10),
		(4,3,'when was the war of 1812?',14);

insert into dbo.Answers
values	(1,'4',1,1),
		(2,'5',0,1),
		(3,'6',0,1),
		(4,'7',0,1),
		(5,'1',1,2),
		(6,'10',0,2),
		(7,'11',0,2),
		(8,'2',0,2),
		(9,'sad',0,3),
		(10,'sappy',1,3),
		(11,'sorry',0,3),
		(12,'celebrate',0,3),
		(13,'1885',0,4),
		(14,'1812',1,4),
		(15,'1776',0,4),
		(16,'1865',0,4);