create database LibraryManager
create table Books(
	BookID int IDENTITY(1,1) PRIMARY KEY  NOT NULL,
	Title char(50) NOT NULL,
	Author char(50) NULL,
	Page_Count [int] NULL,
	Topic char(30) NULL,
	Code char(15) NULL
);
INSERT INTO Books(Title, Author, Page_Count, Topic)  VALUES ('Android','QuocDung',200,'Lap Trinh')
INSERT INTO Books(Title, Author, Page_Count, Topic)  VALUES ('Java','QuocDung',200,'Lap Trinh')
INSERT INTO Books(Title, Author, Page_Count, Topic)  VALUES ('C#','QuocDung',200,'Lap Trinh')
INSERT INTO Books(Title, Author, Page_Count, Topic)  VALUES ('iOS','QuocDung',200,'Lap Trinh')
INSERT INTO Books(Title, Author, Page_Count, Topic)  VALUES ('C++','QuocDung',200,'Lap Trinh')
INSERT INTO Books(Title, Author, Page_Count, Topic)  VALUES ('Python','QuocDung',200,'Lap Trinh')
