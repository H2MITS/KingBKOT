
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/26/2018 10:34:17
-- Generated from EDMX file: D:\Projects\KingBBQ\KingBKOT\Data\KBBQModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [cindyDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_tbl_PurchaseDetails_purchaseProducts]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbl_PurchaseDetails] DROP CONSTRAINT [FK_tbl_PurchaseDetails_purchaseProducts];
GO
IF OBJECT_ID(N'[dbo].[FK_tbl_PurchaseDetails_tbl_PurchaseMaster]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tbl_PurchaseDetails] DROP CONSTRAINT [FK_tbl_PurchaseDetails_tbl_PurchaseMaster];
GO
IF OBJECT_ID(N'[dbo].[FK_tblProducts_tblProType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblProducts] DROP CONSTRAINT [FK_tblProducts_tblProType];
GO
IF OBJECT_ID(N'[dbo].[FK_tblPurchaseOrder_purchaseProducts]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[tblPurchaseOrder] DROP CONSTRAINT [FK_tblPurchaseOrder_purchaseProducts];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[billAndSettlement]', 'U') IS NOT NULL
    DROP TABLE [dbo].[billAndSettlement];
GO
IF OBJECT_ID(N'[dbo].[DailySales]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DailySales];
GO
IF OBJECT_ID(N'[dbo].[ElectronicCurrency]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ElectronicCurrency];
GO
IF OBJECT_ID(N'[dbo].[GenEmpID]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GenEmpID];
GO
IF OBJECT_ID(N'[dbo].[genNochargeIDs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[genNochargeIDs];
GO
IF OBJECT_ID(N'[dbo].[kotGenerator]', 'U') IS NOT NULL
    DROP TABLE [dbo].[kotGenerator];
GO
IF OBJECT_ID(N'[dbo].[LogHistory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[LogHistory];
GO
IF OBJECT_ID(N'[dbo].[purchaseProducts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[purchaseProducts];
GO
IF OBJECT_ID(N'[dbo].[tbl_PurchaseDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbl_PurchaseDetails];
GO
IF OBJECT_ID(N'[dbo].[tbl_PurchaseMaster]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tbl_PurchaseMaster];
GO
IF OBJECT_ID(N'[dbo].[tblAdvBooking]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblAdvBooking];
GO
IF OBJECT_ID(N'[dbo].[tblCurrency]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblCurrency];
GO
IF OBJECT_ID(N'[dbo].[tblEmployee]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblEmployee];
GO
IF OBJECT_ID(N'[dbo].[tblExpenses]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblExpenses];
GO
IF OBJECT_ID(N'[dbo].[tblOrderInfo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblOrderInfo];
GO
IF OBJECT_ID(N'[dbo].[tblProducts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblProducts];
GO
IF OBJECT_ID(N'[dbo].[tblProType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblProType];
GO
IF OBJECT_ID(N'[dbo].[tblPurchaseOrder]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblPurchaseOrder];
GO
IF OBJECT_ID(N'[dbo].[tblTax]', 'U') IS NOT NULL
    DROP TABLE [dbo].[tblTax];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[KBBQModelStoreContainer].[detailsSettlement]', 'U') IS NOT NULL
    DROP TABLE [KBBQModelStoreContainer].[detailsSettlement];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'billAndSettlements'
CREATE TABLE [dbo].[billAndSettlements] (
    [kot] nvarchar(50)  NOT NULL,
    [orderDecrip] nvarchar(50)  NOT NULL,
    [fname] nvarchar(35)  NULL,
    [lname] nvarchar(35)  NULL,
    [ordDate] datetime  NOT NULL,
    [ordTime] varchar(max)  NOT NULL,
    [totalDue] decimal(19,4)  NOT NULL,
    [tax1_Amt] decimal(19,4)  NOT NULL,
    [tax2_Amt] decimal(19,4)  NOT NULL,
    [subTotal] decimal(19,4)  NOT NULL,
    [mode] nvarchar(50)  NULL,
    [empID] nvarchar(50)  NOT NULL,
    [couponCode] nchar(20)  NULL,
    [discount] decimal(18,2)  NULL,
    [mobile] nvarchar(50)  NULL
);
GO

-- Creating table 'DailySales'
CREATE TABLE [dbo].[DailySales] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [TableNum] int  NULL,
    [ServiceType] varchar(max)  NOT NULL,
    [Qty] int  NULL,
    [ItemName] varchar(max)  NOT NULL,
    [ItemPrice] nvarchar(45)  NOT NULL,
    [empID] nvarchar(40)  NOT NULL,
    [OrderDate] nvarchar(30)  NULL,
    [OrderTime] nvarchar(30)  NOT NULL,
    [statues] varchar(max)  NOT NULL,
    [KOT] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'ElectronicCurrencies'
CREATE TABLE [dbo].[ElectronicCurrencies] (
    [id] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(70)  NOT NULL
);
GO

-- Creating table 'GenEmpIDs'
CREATE TABLE [dbo].[GenEmpIDs] (
    [id] int IDENTITY(1,1) NOT NULL,
    [nums] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'genNochargeIDs'
CREATE TABLE [dbo].[genNochargeIDs] (
    [genID] int IDENTITY(1,1) NOT NULL,
    [done] varchar(max)  NOT NULL
);
GO

-- Creating table 'kotGenerators'
CREATE TABLE [dbo].[kotGenerators] (
    [genKOT] int  NOT NULL,
    [done] varchar(max)  NOT NULL
);
GO

-- Creating table 'LogHistories'
CREATE TABLE [dbo].[LogHistories] (
    [id] int IDENTITY(1,1) NOT NULL,
    [empID] nvarchar(100)  NOT NULL,
    [logDate] datetime  NOT NULL,
    [logTime] nvarchar(25)  NOT NULL,
    [endShiftDate] datetime  NOT NULL,
    [endShiftTime] nvarchar(25)  NOT NULL,
    [statues] varchar(max)  NOT NULL
);
GO

-- Creating table 'purchaseProducts'
CREATE TABLE [dbo].[purchaseProducts] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [pName] nvarchar(50)  NULL,
    [date] datetime  NULL,
    [weight] decimal(18,2)  NULL,
    [unit] nchar(10)  NULL,
    [qty] decimal(18,2)  NULL,
    [rate] decimal(18,2)  NULL,
    [totalAmt] decimal(18,2)  NULL,
    [cdate] datetime  NULL,
    [udate] datetime  NULL
);
GO

-- Creating table 'tbl_PurchaseDetails'
CREATE TABLE [dbo].[tbl_PurchaseDetails] (
    [pdetailsId] bigint IDENTITY(1,1) NOT NULL,
    [purchaseID] bigint  NULL,
    [productID] bigint  NULL,
    [qty] decimal(18,2)  NULL,
    [weight] decimal(18,2)  NULL,
    [unit] varchar(50)  NULL,
    [rate] decimal(18,2)  NULL,
    [createdDate] datetime  NULL,
    [updatedDate] datetime  NULL
);
GO

-- Creating table 'tbl_PurchaseMaster'
CREATE TABLE [dbo].[tbl_PurchaseMaster] (
    [pId] bigint IDENTITY(1,1) NOT NULL,
    [refNo] varchar(50)  NULL,
    [date] datetime  NULL,
    [totalWeight] decimal(18,2)  NULL,
    [unit] char(10)  NULL,
    [totalAmt] decimal(18,2)  NULL,
    [remarks] varchar(150)  NULL,
    [createdDate] datetime  NULL,
    [updateDate] datetime  NULL,
    [partyName] nvarchar(50)  NULL
);
GO

-- Creating table 'tblCurrencies'
CREATE TABLE [dbo].[tblCurrencies] (
    [curID] int IDENTITY(1,1) NOT NULL,
    [CurName] nvarchar(30)  NOT NULL,
    [curSymbol] nchar(3)  NOT NULL,
    [Statues] nvarchar(25)  NULL,
    [convertAmt] nvarchar(25)  NULL
);
GO

-- Creating table 'tblEmployees'
CREATE TABLE [dbo].[tblEmployees] (
    [id] int IDENTITY(1,1) NOT NULL,
    [empID] nvarchar(25)  NOT NULL,
    [fname] nvarchar(50)  NOT NULL,
    [lname] nvarchar(50)  NOT NULL,
    [oname] nvarchar(50)  NOT NULL,
    [gender] nvarchar(15)  NOT NULL,
    [dob] datetime  NOT NULL,
    [phone] nvarchar(25)  NOT NULL,
    [resAddress] varchar(max)  NOT NULL,
    [emailAdd] varchar(max)  NULL,
    [ref_fname] nvarchar(50)  NOT NULL,
    [ref_lname] nvarchar(50)  NOT NULL,
    [ref_phone] nvarchar(25)  NOT NULL,
    [photo] varbinary(max)  NULL
);
GO

-- Creating table 'tblPurchaseOrders'
CREATE TABLE [dbo].[tblPurchaseOrders] (
    [id] int IDENTITY(1,1) NOT NULL,
    [productId] bigint  NULL,
    [date] datetime  NULL,
    [weight] decimal(18,2)  NULL,
    [unit] nchar(10)  NULL,
    [qty] decimal(18,2)  NULL,
    [cdate] datetime  NULL,
    [udate] datetime  NULL
);
GO

-- Creating table 'tblTaxes'
CREATE TABLE [dbo].[tblTaxes] (
    [taxID] int IDENTITY(1,1) NOT NULL,
    [tax_1] decimal(5,3)  NOT NULL,
    [tax_2] decimal(5,3)  NULL,
    [tax_3] decimal(5,3)  NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [empID] nvarchar(25)  NOT NULL,
    [Uname] nvarchar(50)  NOT NULL,
    [Pass] nvarchar(50)  NOT NULL,
    [privileges] nvarchar(20)  NOT NULL,
    [cdate] datetime  NULL
);
GO

-- Creating table 'detailsSettlements'
CREATE TABLE [dbo].[detailsSettlements] (
    [KOT] nvarchar(50)  NOT NULL,
    [paidDate] datetime  NOT NULL,
    [paidTime] nvarchar(25)  NOT NULL,
    [currencyInUsed] nvarchar(25)  NULL,
    [bill] decimal(19,4)  NOT NULL,
    [custCurrencyChosen] nvarchar(25)  NULL,
    [AmountPaid] decimal(19,4)  NOT NULL,
    [changeDue] decimal(19,4)  NULL,
    [paymentType] nvarchar(30)  NULL,
    [acctName] nvarchar(125)  NULL,
    [acctNum] nvarchar(50)  NULL,
    [electronicType] nvarchar(40)  NULL,
    [empID] nvarchar(50)  NULL,
    [receiptno] nvarchar(50)  NULL
);
GO

-- Creating table 'tblOrderInfoes'
CREATE TABLE [dbo].[tblOrderInfoes] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [orderType] nvarchar(50)  NOT NULL,
    [tableNo] nvarchar(10)  NOT NULL,
    [KOT] nvarchar(50)  NOT NULL,
    [ordDate] datetime  NOT NULL,
    [ordTime] nvarchar(25)  NOT NULL,
    [fname] nvarchar(60)  NOT NULL,
    [lname] nvarchar(60)  NOT NULL,
    [adultNo] nvarchar(15)  NOT NULL,
    [childrenNo] nvarchar(15)  NOT NULL,
    [empID] nvarchar(70)  NOT NULL,
    [waiterId] nvarchar(70)  NULL,
    [mobile] varchar(50)  NULL
);
GO

-- Creating table 'tblProducts'
CREATE TABLE [dbo].[tblProducts] (
    [prodID] int IDENTITY(1,1) NOT NULL,
    [proName] nvarchar(125)  NOT NULL,
    [prodTypeName] nvarchar(35)  NOT NULL,
    [proType] nvarchar(35)  NOT NULL,
    [proDescrip] varchar(max)  NOT NULL,
    [tax_1] nvarchar(20)  NOT NULL,
    [tax_2] nvarchar(20)  NULL,
    [tax_3] nvarchar(20)  NULL,
    [proPrice] nvarchar(20)  NULL,
    [tax_1Amt] nvarchar(20)  NULL,
    [tax_2Amt] nvarchar(20)  NULL,
    [tax_3Amt] nvarchar(20)  NULL,
    [proNetPrice] nvarchar(20)  NULL,
    [qty] nvarchar(1)  NOT NULL,
    [Statues] bit  NULL,
    [Reason] varchar(max)  NULL,
    [prodTypeId] bigint  NULL
);
GO

-- Creating table 'tblProTypes'
CREATE TABLE [dbo].[tblProTypes] (
    [proTypeID] bigint IDENTITY(1,1) NOT NULL,
    [prodTypeName] nvarchar(35)  NULL,
    [proSubCate] nvarchar(35)  NULL
);
GO

-- Creating table 'tblAdvBookings'
CREATE TABLE [dbo].[tblAdvBookings] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [custName] varchar(50)  NULL,
    [mob] varchar(50)  NULL,
    [eventDate] datetime  NULL,
    [todayDate] datetime  NULL,
    [adults] int  NULL,
    [child] int  NULL,
    [advancePayment] decimal(18,0)  NULL,
    [totalPayment] decimal(18,0)  NULL,
    [status] varchar(50)  NULL,
    [cdate] datetime  NULL,
    [udate] datetime  NULL,
    [recptNo] varchar(50)  NULL
);
GO

-- Creating table 'tblExpenses'
CREATE TABLE [dbo].[tblExpenses] (
    [id] bigint IDENTITY(1,1) NOT NULL,
    [expName] nvarchar(50)  NULL,
    [expDate] datetime  NULL,
    [amount] decimal(18,2)  NULL,
    [expBy] nvarchar(50)  NULL,
    [cdate] datetime  NULL,
    [udate] datetime  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [kot] in table 'billAndSettlements'
ALTER TABLE [dbo].[billAndSettlements]
ADD CONSTRAINT [PK_billAndSettlements]
    PRIMARY KEY CLUSTERED ([kot] ASC);
GO

-- Creating primary key on [id] in table 'DailySales'
ALTER TABLE [dbo].[DailySales]
ADD CONSTRAINT [PK_DailySales]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [name] in table 'ElectronicCurrencies'
ALTER TABLE [dbo].[ElectronicCurrencies]
ADD CONSTRAINT [PK_ElectronicCurrencies]
    PRIMARY KEY CLUSTERED ([name] ASC);
GO

-- Creating primary key on [id] in table 'GenEmpIDs'
ALTER TABLE [dbo].[GenEmpIDs]
ADD CONSTRAINT [PK_GenEmpIDs]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [genID] in table 'genNochargeIDs'
ALTER TABLE [dbo].[genNochargeIDs]
ADD CONSTRAINT [PK_genNochargeIDs]
    PRIMARY KEY CLUSTERED ([genID] ASC);
GO

-- Creating primary key on [genKOT] in table 'kotGenerators'
ALTER TABLE [dbo].[kotGenerators]
ADD CONSTRAINT [PK_kotGenerators]
    PRIMARY KEY CLUSTERED ([genKOT] ASC);
GO

-- Creating primary key on [id] in table 'LogHistories'
ALTER TABLE [dbo].[LogHistories]
ADD CONSTRAINT [PK_LogHistories]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'purchaseProducts'
ALTER TABLE [dbo].[purchaseProducts]
ADD CONSTRAINT [PK_purchaseProducts]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [pdetailsId] in table 'tbl_PurchaseDetails'
ALTER TABLE [dbo].[tbl_PurchaseDetails]
ADD CONSTRAINT [PK_tbl_PurchaseDetails]
    PRIMARY KEY CLUSTERED ([pdetailsId] ASC);
GO

-- Creating primary key on [pId] in table 'tbl_PurchaseMaster'
ALTER TABLE [dbo].[tbl_PurchaseMaster]
ADD CONSTRAINT [PK_tbl_PurchaseMaster]
    PRIMARY KEY CLUSTERED ([pId] ASC);
GO

-- Creating primary key on [curSymbol] in table 'tblCurrencies'
ALTER TABLE [dbo].[tblCurrencies]
ADD CONSTRAINT [PK_tblCurrencies]
    PRIMARY KEY CLUSTERED ([curSymbol] ASC);
GO

-- Creating primary key on [empID] in table 'tblEmployees'
ALTER TABLE [dbo].[tblEmployees]
ADD CONSTRAINT [PK_tblEmployees]
    PRIMARY KEY CLUSTERED ([empID] ASC);
GO

-- Creating primary key on [id] in table 'tblPurchaseOrders'
ALTER TABLE [dbo].[tblPurchaseOrders]
ADD CONSTRAINT [PK_tblPurchaseOrders]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [taxID] in table 'tblTaxes'
ALTER TABLE [dbo].[tblTaxes]
ADD CONSTRAINT [PK_tblTaxes]
    PRIMARY KEY CLUSTERED ([taxID] ASC);
GO

-- Creating primary key on [empID] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([empID] ASC);
GO

-- Creating primary key on [KOT], [paidDate], [paidTime], [bill], [AmountPaid] in table 'detailsSettlements'
ALTER TABLE [dbo].[detailsSettlements]
ADD CONSTRAINT [PK_detailsSettlements]
    PRIMARY KEY CLUSTERED ([KOT], [paidDate], [paidTime], [bill], [AmountPaid] ASC);
GO

-- Creating primary key on [id] in table 'tblOrderInfoes'
ALTER TABLE [dbo].[tblOrderInfoes]
ADD CONSTRAINT [PK_tblOrderInfoes]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [prodID] in table 'tblProducts'
ALTER TABLE [dbo].[tblProducts]
ADD CONSTRAINT [PK_tblProducts]
    PRIMARY KEY CLUSTERED ([prodID] ASC);
GO

-- Creating primary key on [proTypeID] in table 'tblProTypes'
ALTER TABLE [dbo].[tblProTypes]
ADD CONSTRAINT [PK_tblProTypes]
    PRIMARY KEY CLUSTERED ([proTypeID] ASC);
GO

-- Creating primary key on [id] in table 'tblAdvBookings'
ALTER TABLE [dbo].[tblAdvBookings]
ADD CONSTRAINT [PK_tblAdvBookings]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'tblExpenses'
ALTER TABLE [dbo].[tblExpenses]
ADD CONSTRAINT [PK_tblExpenses]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [productID] in table 'tbl_PurchaseDetails'
ALTER TABLE [dbo].[tbl_PurchaseDetails]
ADD CONSTRAINT [FK_tbl_PurchaseDetails_purchaseProducts]
    FOREIGN KEY ([productID])
    REFERENCES [dbo].[purchaseProducts]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tbl_PurchaseDetails_purchaseProducts'
CREATE INDEX [IX_FK_tbl_PurchaseDetails_purchaseProducts]
ON [dbo].[tbl_PurchaseDetails]
    ([productID]);
GO

-- Creating foreign key on [productId] in table 'tblPurchaseOrders'
ALTER TABLE [dbo].[tblPurchaseOrders]
ADD CONSTRAINT [FK_tblPurchaseOrder_purchaseProducts]
    FOREIGN KEY ([productId])
    REFERENCES [dbo].[purchaseProducts]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tblPurchaseOrder_purchaseProducts'
CREATE INDEX [IX_FK_tblPurchaseOrder_purchaseProducts]
ON [dbo].[tblPurchaseOrders]
    ([productId]);
GO

-- Creating foreign key on [purchaseID] in table 'tbl_PurchaseDetails'
ALTER TABLE [dbo].[tbl_PurchaseDetails]
ADD CONSTRAINT [FK_tbl_PurchaseDetails_tbl_PurchaseMaster]
    FOREIGN KEY ([purchaseID])
    REFERENCES [dbo].[tbl_PurchaseMaster]
        ([pId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tbl_PurchaseDetails_tbl_PurchaseMaster'
CREATE INDEX [IX_FK_tbl_PurchaseDetails_tbl_PurchaseMaster]
ON [dbo].[tbl_PurchaseDetails]
    ([purchaseID]);
GO

-- Creating foreign key on [prodTypeId] in table 'tblProducts'
ALTER TABLE [dbo].[tblProducts]
ADD CONSTRAINT [FK_tblProducts_tblProType]
    FOREIGN KEY ([prodTypeId])
    REFERENCES [dbo].[tblProTypes]
        ([proTypeID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_tblProducts_tblProType'
CREATE INDEX [IX_FK_tblProducts_tblProType]
ON [dbo].[tblProducts]
    ([prodTypeId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------