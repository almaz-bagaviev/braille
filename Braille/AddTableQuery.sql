CREATE TABLE [dbo].[Braille]
(
    [Id] INT IDENTITY (1, 1) PRIMARY KEY NOT NULL,
    [Symbol] NVARCHAR (60) NOT NULL,
    [Dots]   NVARCHAR (6)  NOT NULL
);

