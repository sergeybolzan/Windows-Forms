
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/01/2017 10:51:56
-- Generated from EDMX file: D:\Study\GitHub\Windows-Forms\BanksSearchApp\Logic\BanksModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SearchBanks];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_BankBranchBank]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BranchBankSet] DROP CONSTRAINT [FK_BankBranchBank];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[BranchBankSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BranchBankSet];
GO
IF OBJECT_ID(N'[dbo].[BankSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BankSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'BranchBankSet'
CREATE TABLE [dbo].[BranchBankSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [Latitude] nvarchar(max)  NOT NULL,
    [Longitude] nvarchar(max)  NOT NULL,
    [BankId] int  NOT NULL
);
GO

-- Creating table 'BankSet'
CREATE TABLE [dbo].[BankSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NULL,
    [DateTime] datetime  NULL,
    [UsdSell] float  NOT NULL,
    [UsdBuy] float  NOT NULL,
    [EurSell] float  NOT NULL,
    [EurBuy] float  NOT NULL,
    [RurSell] float  NOT NULL,
    [RurBuy] float  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'BranchBankSet'
ALTER TABLE [dbo].[BranchBankSet]
ADD CONSTRAINT [PK_BranchBankSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BankSet'
ALTER TABLE [dbo].[BankSet]
ADD CONSTRAINT [PK_BankSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [BankId] in table 'BranchBankSet'
ALTER TABLE [dbo].[BranchBankSet]
ADD CONSTRAINT [FK_BankBranchBank]
    FOREIGN KEY ([BankId])
    REFERENCES [dbo].[BankSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BankBranchBank'
CREATE INDEX [IX_FK_BankBranchBank]
ON [dbo].[BranchBankSet]
    ([BankId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------