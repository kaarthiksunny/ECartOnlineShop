CREATE TABLE [dbo].[AdminTable] (
    [AdminId]   INT            IDENTITY (1, 1) NOT NULL,
    [AdminName] NVARCHAR (50)  NULL,
    [DOJ]       NVARCHAR (50)  NULL,
    [Mobile]    NVARCHAR (50)  NULL,
    [Address]   NVARCHAR (250) NULL,
    [Password]  NVARCHAR (50)  NULL,
    CONSTRAINT [PK_AdminTable] PRIMARY KEY CLUSTERED ([AdminId] ASC)
);

