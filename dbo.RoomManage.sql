CREATE TABLE [dbo].[RoomManage] (
    [Id]            INT         NOT NULL,
    [Room type ]    NCHAR (300) NOT NULL,
    [phone number ] INT         NULL,
    [Room number ]  INT         NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

