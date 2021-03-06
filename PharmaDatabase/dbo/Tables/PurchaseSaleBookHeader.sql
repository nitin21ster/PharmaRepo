﻿CREATE TABLE [dbo].[PurchaseSaleBookHeader] (
    [PurchaseSaleBookHeaderID] BIGINT          IDENTITY (1, 1) NOT NULL,
    [VoucherNumber]            NVARCHAR (8)    NOT NULL,
    [VoucherTypeCode]          NVARCHAR (50)   NOT NULL,
    [VoucherDate]              DATETIME        NOT NULL,
    [DueDate]                  DATETIME        NULL,
    [PurchaseBillNo]           NVARCHAR (20)   NULL,
    [LedgerType]               NVARCHAR (50)   NULL,
    [LedgerTypeCode]           NVARCHAR (10)   NULL,
    [Amount01]                 DECIMAL (18, 2) NULL,
    [Amount02]                 DECIMAL (18, 2) NULL,
    [Amount03]                 DECIMAL (18, 2) NULL,
    [Amount04]                 DECIMAL (18, 2) NULL,
    [Amount05]                 DECIMAL (18, 2) NULL,
    [Amount06]                 DECIMAL (18, 2) NULL,
    [Amount07]                 DECIMAL (18, 2) NULL,
    [SGST01]                   DECIMAL (18, 2) NULL,
    [SGST02]                   DECIMAL (18, 2) NULL,
    [SGST03]                   DECIMAL (18, 2) NULL,
    [SGST04]                   DECIMAL (18, 2) NULL,
    [SGST05]                   DECIMAL (18, 2) NULL,
    [SGST06]                   DECIMAL (18, 2) NULL,
    [SGST07]                   DECIMAL (18, 2) NULL,
    [IGST01]                   DECIMAL (18, 2) NULL,
    [IGST02]                   DECIMAL (18, 2) NULL,
    [IGST03]                   DECIMAL (18, 2) NULL,
    [IGST04]                   DECIMAL (18, 2) NULL,
    [IGST05]                   DECIMAL (18, 2) NULL,
    [IGST06]                   DECIMAL (18, 2) NULL,
    [IGST07]                   DECIMAL (18, 2) NULL,
    [CGST01]                   DECIMAL (18, 2) NULL,
    [CGST02]                   DECIMAL (18, 2) NULL,
    [CGST03]                   DECIMAL (18, 2) NULL,
    [CGST04]                   DECIMAL (18, 2) NULL,
    [CGST05]                   DECIMAL (18, 2) NULL,
    [CGST06]                   DECIMAL (18, 2) NULL,
    [CGST07]                   DECIMAL (18, 2) NULL,
    [TotalTaxAmount]           DECIMAL (18, 2) NOT NULL,
    [SurchargeAmount]          DECIMAL (18, 2) NULL,
    [TotalBillAmount]          DECIMAL (18, 2) NULL,
    [TotalCostAmount]          DECIMAL (18, 2) NULL,
    [TotalGrossAmount]         DECIMAL (18, 2) NULL,
    [TotalSchemeAmount]        DECIMAL (18, 2) NULL,
    [TotalDiscountAmount]      DECIMAL (18, 2) NULL,
    [OtherAmount]              DECIMAL (18, 2) NULL,
    [ZSMId]                    INT             NULL,
    [ASMId]                    INT             NULL,
    [RSMId]                    INT             NULL,
    [AreaId]                   INT             NULL,
    [SalesManId]               INT             NULL,
    [RouteId]                  INT             NULL,
    [FreshBreakageExcess]      NVARCHAR (1)    NULL,
    [ReturnBillNo]             NVARCHAR (20)   NULL,
    [ReturBillDate]            DATETIME        NULL,
    [CustomerTypeId]           INT             NULL,
    [LocalCentral]             NVARCHAR (1)    NULL,
    [RateTypeId]               INT             NULL,
    [OrderNumber]              NVARCHAR (500)  NULL,
    [ChallanNumber]            NVARCHAR (500)  NULL,
    [Message]                  NVARCHAR (500)  NULL,
    [Deliveryddress]           NVARCHAR (500)  NULL,
    [DeliveredBy]              NVARCHAR (150)  NULL,
    [CourierName]              NVARCHAR (150)  NULL,
    [CourierDate]              DATETIME        NULL,
    [CourierWeight]            DECIMAL (18, 2) NULL,
    [PurchaseSaleEntryFormID]  INT             NULL,
    [LastBalance]              DECIMAL (18, 2) NULL,
    [CreatedBy]                NVARCHAR (50)   NOT NULL,
    [CreatedOn]                DATETIME        NOT NULL,
    [ModifiedBy]               NVARCHAR (50)   NULL,
    [ModifiedOn]               DATETIME        NULL,
    CONSTRAINT [PK_PurchaseSaleBookHeader] PRIMARY KEY CLUSTERED ([PurchaseSaleBookHeaderID] ASC)
);

