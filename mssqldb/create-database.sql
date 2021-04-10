CREATE DATABASE WineCatalog;
GO
USE WineCatalog;
GO
create table Wines
(
    Id       int identity
        constraint PK_Wines
            primary key,
    Name     nvarchar(100) not null,
    Country  nvarchar(100) not null,
    Type     nvarchar(50),
    Year     nvarchar(20),
    Age      nvarchar(20),
    Varietal nvarchar(50),
    Size     nvarchar(20),
    Price    float         not null,
    Image    nvarchar(250)
);
