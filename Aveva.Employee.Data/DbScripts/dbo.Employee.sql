CREATE TABLE [dbo].[Employee] (
    [Id]          INT           NOT NULL IDENTITY,
    [FirstName]   VARCHAR (100) NOT NULL,
    [LastName]    VARCHAR (100) NOT NULL,
    [Email]       VARCHAR (100) NOT NULL,
    [DateOfBirth] DATE          NULL,
    [Active]      BIT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

