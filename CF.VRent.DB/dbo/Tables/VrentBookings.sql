﻿CREATE TABLE [dbo].[VrentBookings] (
    [ID]                 INT              IDENTITY (1, 1) NOT NULL,
    [BookingType]        TINYINT          NOT NULL,
    [KemasBookingID]     UNIQUEIDENTIFIER NOT NULL,
    [KemasBookingNumber] NVARCHAR (20)    NOT NULL,
    [DateBegin]          DATETIME         NOT NULL,
    [DateEnd]            DATETIME         NOT NULL,
    [TotalAmount]        DECIMAL (10, 3)  NOT NULL,
    [UserID]             UNIQUEIDENTIFIER NOT NULL,
    [UserFirstName]      NVARCHAR (50)    NULL,
    [UserLastName]       NVARCHAR (50)    NULL,
    [CorporateID]        NVARCHAR (50)    NULL,
    [CorporateName]      NVARCHAR (50)    NULL,
    [CreatorID]          UNIQUEIDENTIFIER NULL,
    [CreatorFirstName]   NVARCHAR (50)    NULL,
    [CreatorLastName]    NVARCHAR (50)    NULL,
    [StartLocationID]    UNIQUEIDENTIFIER NULL,
    [StartLocationName]  NVARCHAR (50)    NULL,
    [State]              NVARCHAR (50)    NOT NULL,
    [CreatedOn]          DATETIME         NOT NULL,
    [CreatedBy]          UNIQUEIDENTIFIER NOT NULL,
    [ModifiedOn]         DATETIME         NULL,
    [ModifiedBy]         UNIQUEIDENTIFIER NULL,
    CONSTRAINT [PK_VrentBookings1] PRIMARY KEY CLUSTERED ([ID] ASC)
);



