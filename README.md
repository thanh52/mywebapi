USE [OMS.Tenant.bvsg]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TPromoGwpProdCat]') AND type in (N'U'))
ALTER TABLE [dbo].[TPromoGwpProdCat] DROP CONSTRAINT IF EXISTS [FK_TPromoGwpProdCat_TPromoGwp_PromoGwpId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TPromoGwpProdCat]') AND type in (N'U'))
ALTER TABLE [dbo].[TPromoGwpProdCat] DROP CONSTRAINT IF EXISTS [FK_TPromoGwpProdCat_TProduct_ProductId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TPromoGwpProdCat]') AND type in (N'U'))
ALTER TABLE [dbo].[TPromoGwpProdCat] DROP CONSTRAINT IF EXISTS [FK_TPromoGwpProdCat_TCategory_CategoryId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TPromoGwpGift]') AND type in (N'U'))
ALTER TABLE [dbo].[TPromoGwpGift] DROP CONSTRAINT IF EXISTS [FK_TPromoGwpGift_TPromoGwp_PromoGwpId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TPromoGwpGift]') AND type in (N'U'))
ALTER TABLE [dbo].[TPromoGwpGift] DROP CONSTRAINT IF EXISTS [FK_TPromoGwpGift_TProduct_ProductId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TPromoGwp]') AND type in (N'U'))
ALTER TABLE [dbo].[TPromoGwp] DROP CONSTRAINT IF EXISTS [FK_TPromoGwp_TChannel_ChannelId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TProductLog]') AND type in (N'U'))
ALTER TABLE [dbo].[TProductLog] DROP CONSTRAINT IF EXISTS [FK_TProductLog_TProduct_ProductId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TProductAttributeOption]') AND type in (N'U'))
ALTER TABLE [dbo].[TProductAttributeOption] DROP CONSTRAINT IF EXISTS [FK_TProductAttributeOption_TProductAttribute_ProductAttributeId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TProduct]') AND type in (N'U'))
ALTER TABLE [dbo].[TProduct] DROP CONSTRAINT IF EXISTS [FK_TProduct_TProductAttributeSet_AttributeSetId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TProduct]') AND type in (N'U'))
ALTER TABLE [dbo].[TProduct] DROP CONSTRAINT IF EXISTS [FK_TProduct_TProduct_ParentId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TProduct]') AND type in (N'U'))
ALTER TABLE [dbo].[TProduct] DROP CONSTRAINT IF EXISTS [FK_TProduct_TCategory_DefaultCategoryId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TProduct]') AND type in (N'U'))
ALTER TABLE [dbo].[TProduct] DROP CONSTRAINT IF EXISTS [FK_TProduct_TBrand_BrandId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TPriceBookVersioning]') AND type in (N'U'))
ALTER TABLE [dbo].[TPriceBookVersioning] DROP CONSTRAINT IF EXISTS [FK_TPriceBookVersioning_TPriceBook_PriceBookId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TPriceBookItem]') AND type in (N'U'))
ALTER TABLE [dbo].[TPriceBookItem] DROP CONSTRAINT IF EXISTS [FK_TPriceBookItem_TProduct_ProductId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TPriceBookItem]') AND type in (N'U'))
ALTER TABLE [dbo].[TPriceBookItem] DROP CONSTRAINT IF EXISTS [FK_TPriceBookItem_TPriceBook_PriceBookId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TPriceBookAddOnItem]') AND type in (N'U'))
ALTER TABLE [dbo].[TPriceBookAddOnItem] DROP CONSTRAINT IF EXISTS [FK_TPriceBookAddOnItem_TProduct_ProductId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TPriceBookAddOnItem]') AND type in (N'U'))
ALTER TABLE [dbo].[TPriceBookAddOnItem] DROP CONSTRAINT IF EXISTS [FK_TPriceBookAddOnItem_TPriceBook_PriceBookId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TPriceBook]') AND type in (N'U'))
ALTER TABLE [dbo].[TPriceBook] DROP CONSTRAINT IF EXISTS [FK_TPriceBook_TTaxType_TaxTypeId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TOrderShipment]') AND type in (N'U'))
ALTER TABLE [dbo].[TOrderShipment] DROP CONSTRAINT IF EXISTS [FK_TOrderShipment_TOrder_OrderId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TOrderPaymentInfo]') AND type in (N'U'))
ALTER TABLE [dbo].[TOrderPaymentInfo] DROP CONSTRAINT IF EXISTS [FK_TOrderPaymentInfo_TOrder_OrderId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TOrderLog]') AND type in (N'U'))
ALTER TABLE [dbo].[TOrderLog] DROP CONSTRAINT IF EXISTS [FK_TOrderLog_TOrder_OrderId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TOrderItem]') AND type in (N'U'))
ALTER TABLE [dbo].[TOrderItem] DROP CONSTRAINT IF EXISTS [FK_TOrderItem_TProduct_ProductId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TOrderItem]') AND type in (N'U'))
ALTER TABLE [dbo].[TOrderItem] DROP CONSTRAINT IF EXISTS [FK_TOrderItem_TOrder_OrderId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TOrderDiscountInfo]') AND type in (N'U'))
ALTER TABLE [dbo].[TOrderDiscountInfo] DROP CONSTRAINT IF EXISTS [FK_TOrderDiscountInfo_TOrder_OrderId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TOrderCustomerInfo]') AND type in (N'U'))
ALTER TABLE [dbo].[TOrderCustomerInfo] DROP CONSTRAINT IF EXISTS [FK_TOrderCustomerInfo_TOrder_OrderId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TOrder]') AND type in (N'U'))
ALTER TABLE [dbo].[TOrder] DROP CONSTRAINT IF EXISTS [FK_TOrder_TOrder_OriginalOrderId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TOrder]') AND type in (N'U'))
ALTER TABLE [dbo].[TOrder] DROP CONSTRAINT IF EXISTS [FK_TOrder_TChannel_PickUpChannelId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TOrder]') AND type in (N'U'))
ALTER TABLE [dbo].[TOrder] DROP CONSTRAINT IF EXISTS [FK_TOrder_TChannel_ChannelId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TInventoryTransferItem]') AND type in (N'U'))
ALTER TABLE [dbo].[TInventoryTransferItem] DROP CONSTRAINT IF EXISTS [FK_TInventoryTransferItem_TProduct_ProductId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TInventoryTransferItem]') AND type in (N'U'))
ALTER TABLE [dbo].[TInventoryTransferItem] DROP CONSTRAINT IF EXISTS [FK_TInventoryTransferItem_TInventoryTransfer_TransferId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TInventoryLedger]') AND type in (N'U'))
ALTER TABLE [dbo].[TInventoryLedger] DROP CONSTRAINT IF EXISTS [FK_TInventoryLedger_TProduct_ProductId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TInventoryLedger]') AND type in (N'U'))
ALTER TABLE [dbo].[TInventoryLedger] DROP CONSTRAINT IF EXISTS [FK_TInventoryLedger_TInventory_InventoryId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TInventoryItem]') AND type in (N'U'))
ALTER TABLE [dbo].[TInventoryItem] DROP CONSTRAINT IF EXISTS [FK_TInventoryItem_TProduct_ProductId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TInventoryItem]') AND type in (N'U'))
ALTER TABLE [dbo].[TInventoryItem] DROP CONSTRAINT IF EXISTS [FK_TInventoryItem_TInventory_InventoryId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TInventoryGoodsReceiptItem]') AND type in (N'U'))
ALTER TABLE [dbo].[TInventoryGoodsReceiptItem] DROP CONSTRAINT IF EXISTS [FK_TInventoryGoodsReceiptItem_TProduct_ProductId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TInventoryGoodsReceiptItem]') AND type in (N'U'))
ALTER TABLE [dbo].[TInventoryGoodsReceiptItem] DROP CONSTRAINT IF EXISTS [FK_TInventoryGoodsReceiptItem_TInventoryGoodsReceipt_GoodsReceiptId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TInventoryGoodsReceipt]') AND type in (N'U'))
ALTER TABLE [dbo].[TInventoryGoodsReceipt] DROP CONSTRAINT IF EXISTS [FK_TInventoryGoodsReceipt_TInventoryTransfer_TransferId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TInventoryAdjustmentItem]') AND type in (N'U'))
ALTER TABLE [dbo].[TInventoryAdjustmentItem] DROP CONSTRAINT IF EXISTS [FK_TInventoryAdjustmentItem_TProduct_ProductId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TInventoryAdjustmentItem]') AND type in (N'U'))
ALTER TABLE [dbo].[TInventoryAdjustmentItem] DROP CONSTRAINT IF EXISTS [FK_TInventoryAdjustmentItem_TInventoryAdjustment_AdjustmentId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TInventoryAdjustment]') AND type in (N'U'))
ALTER TABLE [dbo].[TInventoryAdjustment] DROP CONSTRAINT IF EXISTS [FK_TInventoryAdjustment_TInventory_InventoryId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TIntegrationLog]') AND type in (N'U'))
ALTER TABLE [dbo].[TIntegrationLog] DROP CONSTRAINT IF EXISTS [FK_TIntegrationLog_TIntegrationLog_ReferLogId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TIndexProductCategory]') AND type in (N'U'))
ALTER TABLE [dbo].[TIndexProductCategory] DROP CONSTRAINT IF EXISTS [FK_TIndexProductCategory_TIndexBrand_IndexBrandId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TEvent]') AND type in (N'U'))
ALTER TABLE [dbo].[TEvent] DROP CONSTRAINT IF EXISTS [FK_TEvent_TEventType_EventTypeId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TDiscountItem]') AND type in (N'U'))
ALTER TABLE [dbo].[TDiscountItem] DROP CONSTRAINT IF EXISTS [FK_TDiscountItem_TProduct_ProductId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TDiscountItem]') AND type in (N'U'))
ALTER TABLE [dbo].[TDiscountItem] DROP CONSTRAINT IF EXISTS [FK_TDiscountItem_TDiscountCampaign_CampaignId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TChannel]') AND type in (N'U'))
ALTER TABLE [dbo].[TChannel] DROP CONSTRAINT IF EXISTS [FK_TChannel_TPriceBook_PriceBookId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TChannel]') AND type in (N'U'))
ALTER TABLE [dbo].[TChannel] DROP CONSTRAINT IF EXISTS [FK_TChannel_TInventory_InventoryId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TCategory]') AND type in (N'U'))
ALTER TABLE [dbo].[TCategory] DROP CONSTRAINT IF EXISTS [FK_TCategory_TCategory_ParentId]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TPromoGwpProdCat]') AND type in (N'U'))
ALTER TABLE [dbo].[TPromoGwpProdCat] DROP CONSTRAINT IF EXISTS [DF__TPromoGwp__Promo__4A8310C6]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TPromoGwpProdCat]') AND type in (N'U'))
ALTER TABLE [dbo].[TPromoGwpProdCat] DROP CONSTRAINT IF EXISTS [DF__TPromoGwpP__Type__43D61337]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TPromoGwpGift]') AND type in (N'U'))
ALTER TABLE [dbo].[TPromoGwpGift] DROP CONSTRAINT IF EXISTS [DF__TPromoGwp__Promo__498EEC8D]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TPromoGwp]') AND type in (N'U'))
ALTER TABLE [dbo].[TPromoGwp] DROP CONSTRAINT IF EXISTS [DF__TPromoGwp__ProdC__4C6B5938]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TPromoGwp]') AND type in (N'U'))
ALTER TABLE [dbo].[TPromoGwp] DROP CONSTRAINT IF EXISTS [DF__TPromoGwp__MinPu__4B7734FF]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TProduct]') AND type in (N'U'))
ALTER TABLE [dbo].[TProduct] DROP CONSTRAINT IF EXISTS [DF__TProduct__Approv__22751F6C]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TOrderItem]') AND type in (N'U'))
ALTER TABLE [dbo].[TOrderItem] DROP CONSTRAINT IF EXISTS [DF__TOrderIte__IsBun__339FAB6E]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TOrder]') AND type in (N'U'))
ALTER TABLE [dbo].[TOrder] DROP CONSTRAINT IF EXISTS [DF_TOrder_PosStauts]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TInventoryTransfer]') AND type in (N'U'))
ALTER TABLE [dbo].[TInventoryTransfer] DROP CONSTRAINT IF EXISTS [DF__TInventor__Reque__25518C17]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TInventoryLedger]') AND type in (N'U'))
ALTER TABLE [dbo].[TInventoryLedger] DROP CONSTRAINT IF EXISTS [DF__TInventor__Perfo__245D67DE]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TInventoryItem]') AND type in (N'U'))
ALTER TABLE [dbo].[TInventoryItem] DROP CONSTRAINT IF EXISTS [DF__TInventor__Reser__367C1819]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TInventoryGoodsReceipt]') AND type in (N'U'))
ALTER TABLE [dbo].[TInventoryGoodsReceipt] DROP CONSTRAINT IF EXISTS [DF__TInventor__Recei__2645B050]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TInventoryAdjustmentItem]') AND type in (N'U'))
ALTER TABLE [dbo].[TInventoryAdjustmentItem] DROP CONSTRAINT IF EXISTS [DF__TInventor__Befor__32AB8735]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TInventoryAdjustment]') AND type in (N'U'))
ALTER TABLE [dbo].[TInventoryAdjustment] DROP CONSTRAINT IF EXISTS [DF__TInventor__Reque__2739D489]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TDiscountCampaign]') AND type in (N'U'))
ALTER TABLE [dbo].[TDiscountCampaign] DROP CONSTRAINT IF EXISTS [DF__TDiscount__Effec__31B762FC]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TDiscountCampaign]') AND type in (N'U'))
ALTER TABLE [dbo].[TDiscountCampaign] DROP CONSTRAINT IF EXISTS [DF__TDiscount__Effec__30C33EC3]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TDiscountCampaign]') AND type in (N'U'))
ALTER TABLE [dbo].[TDiscountCampaign] DROP CONSTRAINT IF EXISTS [DF__TDiscount__Appro__2FCF1A8A]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TChannel]') AND type in (N'U'))
ALTER TABLE [dbo].[TChannel] DROP CONSTRAINT IF EXISTS [DF__TChannel__StockS__37703C52]
GO
/****** Object:  Table [dbo].[TTaxType]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TTaxType]
GO
/****** Object:  Table [dbo].[TTaxonomy]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TTaxonomy]
GO
/****** Object:  Table [dbo].[TPromoGwpProdCat]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TPromoGwpProdCat]
GO
/****** Object:  Table [dbo].[TPromoGwpGift]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TPromoGwpGift]
GO
/****** Object:  Table [dbo].[TPromoGwp]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TPromoGwp]
GO
/****** Object:  Table [dbo].[TProductLog]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TProductLog]
GO
/****** Object:  Table [dbo].[TProductAttributeSet]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TProductAttributeSet]
GO
/****** Object:  Table [dbo].[TProductAttributeOption]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TProductAttributeOption]
GO
/****** Object:  Table [dbo].[TProductAttribute]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TProductAttribute]
GO
/****** Object:  Table [dbo].[TProduct]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TProduct]
GO
/****** Object:  Table [dbo].[TPriceBookVersioning]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TPriceBookVersioning]
GO
/****** Object:  Table [dbo].[TPriceBookItem]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TPriceBookItem]
GO
/****** Object:  Table [dbo].[TPriceBookAddOnItem]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TPriceBookAddOnItem]
GO
/****** Object:  Table [dbo].[TPriceBook]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TPriceBook]
GO
/****** Object:  Table [dbo].[TOrderShipment]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TOrderShipment]
GO
/****** Object:  Table [dbo].[TOrderPaymentInfo]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TOrderPaymentInfo]
GO
/****** Object:  Table [dbo].[TOrderLog]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TOrderLog]
GO
/****** Object:  Table [dbo].[TOrderItem]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TOrderItem]
GO
/****** Object:  Table [dbo].[TOrderDiscountInfo]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TOrderDiscountInfo]
GO
/****** Object:  Table [dbo].[TOrderCustomerInfo]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TOrderCustomerInfo]
GO
/****** Object:  Table [dbo].[TOrder]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TOrder]
GO
/****** Object:  Table [dbo].[TMarketplaceNotification]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TMarketplaceNotification]
GO
/****** Object:  Table [dbo].[TMarketplaceCategory]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TMarketplaceCategory]
GO
/****** Object:  Table [dbo].[TInventoryTransferItem]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TInventoryTransferItem]
GO
/****** Object:  Table [dbo].[TInventoryTransfer]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TInventoryTransfer]
GO
/****** Object:  Table [dbo].[TInventoryMap]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TInventoryMap]
GO
/****** Object:  Table [dbo].[TInventoryLedger]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TInventoryLedger]
GO
/****** Object:  Table [dbo].[TInventoryItem]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TInventoryItem]
GO
/****** Object:  Table [dbo].[TInventoryGoodsReceiptItem]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TInventoryGoodsReceiptItem]
GO
/****** Object:  Table [dbo].[TInventoryGoodsReceipt]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TInventoryGoodsReceipt]
GO
/****** Object:  Table [dbo].[TInventoryAdjustmentItem]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TInventoryAdjustmentItem]
GO
/****** Object:  Table [dbo].[TInventoryAdjustment]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TInventoryAdjustment]
GO
/****** Object:  Table [dbo].[TInventory]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TInventory]
GO
/****** Object:  Table [dbo].[TIntegrationLog]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TIntegrationLog]
GO
/****** Object:  Table [dbo].[TIndexProductInventory]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TIndexProductInventory]
GO
/****** Object:  Table [dbo].[TIndexProductCategory]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TIndexProductCategory]
GO
/****** Object:  Table [dbo].[TIndexBrand]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TIndexBrand]
GO
/****** Object:  Table [dbo].[TExtendedProductProperty]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TExtendedProductProperty]
GO
/****** Object:  Table [dbo].[TExchangeRate]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TExchangeRate]
GO
/****** Object:  Table [dbo].[TEventType]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TEventType]
GO
/****** Object:  Table [dbo].[TEvent]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TEvent]
GO
/****** Object:  Table [dbo].[TDiscountItem]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TDiscountItem]
GO
/****** Object:  Table [dbo].[TDiscountCampaign]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TDiscountCampaign]
GO
/****** Object:  Table [dbo].[TChannel]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TChannel]
GO
/****** Object:  Table [dbo].[TCategory]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TCategory]
GO
/****** Object:  Table [dbo].[TBrand]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[TBrand]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 8/11/2021 4:08:40 PM ******/
DROP TABLE IF EXISTS [dbo].[__EFMigrationsHistory]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 8/11/2021 4:08:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBrand]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBrand](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[Timestamp] [timestamp] NULL,
	[Name] [nvarchar](900) NOT NULL,
	[Code] [nvarchar](900) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[DisplayOrder] [int] NOT NULL,
	[PublishOnUtc] [datetime2](7) NOT NULL,
	[UnpublishOnUtc] [datetime2](7) NOT NULL,
	[Status] [nvarchar](900) NOT NULL,
	[Archived] [bit] NOT NULL,
	[Seo] [nvarchar](max) NOT NULL,
	[Localization] [nvarchar](max) NOT NULL,
	[Y3PartnerCode] [nvarchar](900) NULL,
 CONSTRAINT [PK_TBrand] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TCategory]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TCategory](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[Timestamp] [timestamp] NULL,
	[ParentId] [bigint] NULL,
	[Name] [nvarchar](900) NOT NULL,
	[Code] [nvarchar](900) NOT NULL,
	[Level] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[DisplayOrder] [int] NOT NULL,
	[PublishOnUtc] [datetime2](7) NOT NULL,
	[UnpublishOnUtc] [datetime2](7) NOT NULL,
	[Status] [nvarchar](900) NOT NULL,
	[Archived] [bit] NOT NULL,
	[Seo] [nvarchar](max) NOT NULL,
	[ProductAttributeSets] [nvarchar](max) NOT NULL,
	[Localization] [nvarchar](max) NOT NULL,
	[MarketplaceCategory] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TCategory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TChannel]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TChannel](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[Timestamp] [timestamp] NULL,
	[InventoryId] [bigint] NULL,
	[PriceBookId] [bigint] NOT NULL,
	[Name] [nvarchar](900) NOT NULL,
	[Type] [nvarchar](900) NOT NULL,
	[SubType] [nvarchar](900) NOT NULL,
	[Group] [nvarchar](max) NULL,
	[Timezone] [nvarchar](max) NOT NULL,
	[IntegrationSettings] [nvarchar](max) NULL,
	[Status] [nvarchar](900) NOT NULL,
	[CodePrefix] [nvarchar](max) NULL,
	[StockSyncWithReservedStock] [bit] NOT NULL,
	[StoreCode] [nvarchar](max) NULL,
 CONSTRAINT [PK_TChannel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TDiscountCampaign]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TDiscountCampaign](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[Timestamp] [timestamp] NULL,
	[Tag] [nvarchar](900) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[PublishOnUtc] [datetime2](7) NOT NULL,
	[UnpublishOnUtc] [datetime2](7) NOT NULL,
	[Status] [nvarchar](900) NOT NULL,
	[Deleted] [bit] NOT NULL,
	[Channels] [nvarchar](max) NOT NULL,
	[ApprovalStatus] [nvarchar](900) NOT NULL,
	[EffectiveFromUtc] [datetime2](7) NOT NULL,
	[EffectiveToUtc] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_TDiscountCampaign] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TDiscountItem]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TDiscountItem](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[Timestamp] [timestamp] NULL,
	[CampaignId] [bigint] NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[Price] [decimal](18, 4) NOT NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_TDiscountItem] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TEvent]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TEvent](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[Timestamp] [timestamp] NULL,
	[Key] [nvarchar](900) NOT NULL,
	[EventTypeId] [bigint] NOT NULL,
	[EventStatus] [int] NOT NULL,
	[Body] [nvarchar](max) NULL,
	[Started] [datetime2](7) NULL,
	[Completed] [datetime2](7) NULL,
	[Failed] [datetime2](7) NULL,
	[Notes] [nvarchar](max) NULL,
 CONSTRAINT [PK_TEvent] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TEventType]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TEventType](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[Timestamp] [timestamp] NULL,
	[Name] [nvarchar](450) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[NumberOfRetry] [int] NULL,
 CONSTRAINT [PK_TEventType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TExchangeRate]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TExchangeRate](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[Timestamp] [timestamp] NULL,
	[FromCurrency] [nvarchar](32) NOT NULL,
	[ToCurrency] [nvarchar](32) NOT NULL,
	[EffectiveFromUtc] [datetime2](7) NOT NULL,
	[EffectiveToUtc] [datetime2](7) NOT NULL,
	[ConversionRate] [decimal](18, 8) NOT NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_TExchangeRate] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TExtendedProductProperty]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TExtendedProductProperty](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[Timestamp] [timestamp] NULL,
	[Name] [nvarchar](900) NOT NULL,
	[Alias] [nvarchar](900) NOT NULL,
	[InputType] [nvarchar](900) NOT NULL,
	[Section] [nvarchar](900) NOT NULL,
	[DisplayOrder] [int] NOT NULL,
	[Status] [nvarchar](900) NOT NULL,
	[InputAttribute] [nvarchar](max) NULL,
 CONSTRAINT [PK_TExtendedProductProperty] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIndexBrand]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIndexBrand](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[Timestamp] [timestamp] NULL,
	[BrandId] [bigint] NOT NULL,
	[UpdatedOnUtc] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_TIndexBrand] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIndexProductCategory]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIndexProductCategory](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[Timestamp] [timestamp] NULL,
	[IndexBrandId] [bigint] NULL,
	[ProductId] [bigint] NOT NULL,
	[CategoryId] [bigint] NOT NULL,
	[UpdatedOnUtc] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_TIndexProductCategory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIndexProductInventory]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIndexProductInventory](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[Timestamp] [timestamp] NULL,
	[ProductId] [bigint] NOT NULL,
	[UpdatedOnUtc] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_TIndexProductInventory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIntegrationLog]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIntegrationLog](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[Timestamp] [timestamp] NULL,
	[ReferLogId] [bigint] NULL,
	[RefNo] [nvarchar](900) NOT NULL,
	[Destination] [nvarchar](max) NOT NULL,
	[Action] [nvarchar](max) NOT NULL,
	[Url] [nvarchar](max) NULL,
	[Request] [nvarchar](max) NULL,
	[RetryRequest] [nvarchar](max) NULL,
	[Response] [nvarchar](max) NULL,
	[IsSuccess] [bit] NOT NULL,
	[RetryCount] [int] NOT NULL,
 CONSTRAINT [PK_TIntegrationLog] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TInventory]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TInventory](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[Timestamp] [timestamp] NULL,
	[Name] [nvarchar](900) NOT NULL,
	[Type] [nvarchar](900) NOT NULL,
	[SafetyStockLevel] [int] NOT NULL,
	[LowStockNotificationThreshold] [int] NOT NULL,
	[Status] [nvarchar](900) NOT NULL,
	[DedicatedChannelId] [bigint] NULL,
 CONSTRAINT [PK_TInventory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TInventoryAdjustment]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TInventoryAdjustment](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[Timestamp] [timestamp] NULL,
	[InventoryId] [bigint] NOT NULL,
	[ReferenceNumber] [nvarchar](900) NOT NULL,
	[Approver] [nvarchar](max) NULL,
	[Remarks] [nvarchar](max) NULL,
	[Status] [nvarchar](900) NOT NULL,
	[Reasons] [nvarchar](max) NULL,
	[RequestOnUtc] [datetime2](7) NOT NULL,
	[Requestor] [nvarchar](max) NULL,
 CONSTRAINT [PK_TInventoryAdjustment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TInventoryAdjustmentItem]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TInventoryAdjustmentItem](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[Timestamp] [timestamp] NULL,
	[AdjustmentId] [bigint] NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Deleted] [bit] NOT NULL,
	[BeforeQuantity] [int] NOT NULL,
 CONSTRAINT [PK_TInventoryAdjustmentItem] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TInventoryGoodsReceipt]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TInventoryGoodsReceipt](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[Timestamp] [timestamp] NULL,
	[TransferId] [bigint] NOT NULL,
	[ReferenceNumber] [nvarchar](900) NOT NULL,
	[TransferReferenceNumber] [nvarchar](900) NOT NULL,
	[Remarks] [nvarchar](max) NULL,
	[Status] [nvarchar](900) NOT NULL,
	[DeliveryNote] [nvarchar](max) NULL,
	[ReceivedBy] [nvarchar](max) NULL,
	[ReceivedOnUtc] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_TInventoryGoodsReceipt] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TInventoryGoodsReceiptItem]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TInventoryGoodsReceiptItem](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[Timestamp] [timestamp] NULL,
	[GoodsReceiptId] [bigint] NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[ReceivedQuantity] [int] NOT NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_TInventoryGoodsReceiptItem] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TInventoryItem]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TInventoryItem](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[Timestamp] [timestamp] NULL,
	[InventoryId] [bigint] NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[SafetyStockLevel] [int] NULL,
	[LowStockNotificationThreshold] [int] NULL,
	[AvailableQuantity] [int] NOT NULL,
	[ReservedQuantity] [int] NOT NULL,
	[InTransitQuantity] [int] NOT NULL,
	[BackOrderQuantity] [int] NOT NULL,
	[Deleted] [bit] NOT NULL,
	[ReservedByChannel] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TInventoryItem] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TInventoryLedger]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TInventoryLedger](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[Timestamp] [timestamp] NULL,
	[InventoryId] [bigint] NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[Bucket] [nvarchar](max) NOT NULL,
	[Quantity] [int] NOT NULL,
	[DocumentType] [nvarchar](max) NOT NULL,
	[DocumentReferenceNumber] [nvarchar](max) NOT NULL,
	[DestinationInventoryId] [bigint] NULL,
	[PerformedOnUtc] [datetime2](7) NOT NULL,
	[ReferenceId] [bigint] NULL,
	[ChannelId] [bigint] NULL,
 CONSTRAINT [PK_TInventoryLedger] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TInventoryMap]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TInventoryMap](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[Timestamp] [timestamp] NULL,
	[VirtualInventoryId] [bigint] NOT NULL,
	[PhysicalInventoryId] [bigint] NOT NULL,
	[Deleted] [bit] NOT NULL,
	[LastDeductStockOnUtc] [datetime2](7) NULL,
 CONSTRAINT [PK_TInventoryMap] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TInventoryTransfer]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TInventoryTransfer](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[Timestamp] [timestamp] NULL,
	[SourceInventoryId] [bigint] NOT NULL,
	[DestinationInventoryId] [bigint] NOT NULL,
	[ReferenceNumber] [nvarchar](900) NOT NULL,
	[Approver] [nvarchar](max) NULL,
	[Remarks] [nvarchar](max) NULL,
	[Status] [nvarchar](900) NOT NULL,
	[Reason] [nvarchar](max) NULL,
	[RequestOnUtc] [datetime2](7) NOT NULL,
	[Requestor] [nvarchar](max) NULL,
 CONSTRAINT [PK_TInventoryTransfer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TInventoryTransferItem]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TInventoryTransferItem](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[Timestamp] [timestamp] NULL,
	[TransferId] [bigint] NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[Quantity] [int] NOT NULL,
	[ReceivedQuantity] [int] NOT NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_TInventoryTransferItem] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TMarketplaceCategory]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TMarketplaceCategory](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[Timestamp] [timestamp] NULL,
	[ChannelType] [nvarchar](900) NOT NULL,
	[CategoryCode] [nvarchar](900) NOT NULL,
	[CategoryName] [nvarchar](max) NOT NULL,
	[ParentCategoryCode] [nvarchar](max) NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_TMarketplaceCategory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TMarketplaceNotification]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TMarketplaceNotification](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[Timestamp] [timestamp] NULL,
	[Level] [nvarchar](900) NOT NULL,
	[Source] [nvarchar](max) NOT NULL,
	[Message] [nvarchar](max) NOT NULL,
	[DocRefNo] [nvarchar](max) NULL,
	[Status] [nvarchar](max) NULL,
	[LoggedOnUtc] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_TMarketplaceNotification] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TOrder]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TOrder](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[Timestamp] [timestamp] NULL,
	[OriginalOrderId] [bigint] NULL,
	[ChannelId] [bigint] NOT NULL,
	[OrderNumber] [nvarchar](900) NOT NULL,
	[OrderOnUtc] [datetime2](7) NOT NULL,
	[ChannelType] [nvarchar](max) NOT NULL,
	[Type] [nvarchar](900) NOT NULL,
	[DeliveryMethod] [nvarchar](max) NOT NULL,
	[ReferralCode] [nvarchar](max) NULL,
	[CustomerType] [int] NOT NULL,
	[Customer] [nvarchar](max) NULL,
	[Currency] [nvarchar](32) NOT NULL,
	[SubTotal] [decimal](18, 4) NOT NULL,
	[TotalCartDiscount] [decimal](18, 4) NOT NULL,
	[GrossSavings] [decimal](18, 4) NOT NULL,
	[ShippingFee] [decimal](18, 4) NOT NULL,
	[TotalAmountDue] [decimal](18, 4) NOT NULL,
	[TotalAmountPaid] [decimal](18, 4) NOT NULL,
	[BalanceAmountDue] [decimal](18, 4) NOT NULL,
	[TotalTaxAmount] [decimal](18, 4) NOT NULL,
	[Status] [nvarchar](900) NOT NULL,
	[CancelledReason] [nvarchar](max) NULL,
	[LastStatusUpdatedOnUtc] [datetime2](7) NULL,
	[ReturnAndExchangeOrders] [nvarchar](max) NOT NULL,
	[Comments] [nvarchar](max) NOT NULL,
	[StatusChangeLogs] [nvarchar](max) NOT NULL,
	[PickUpChannelId] [bigint] NULL,
	[Base_BalanceAmountDue] [decimal](18, 4) NULL,
	[Base_TotalAmountDue] [decimal](18, 4) NULL,
	[Base_TotalAmountPaid] [decimal](18, 4) NULL,
	[ExchangeRate] [decimal](18, 8) NULL,
	[Base_TotalTaxAmount] [decimal](18, 4) NULL,
	[ShippingServiceLevel] [nvarchar](max) NULL,
	[OrderInstructions] [nvarchar](max) NULL,
	[PosStatus] [bit] NOT NULL,
 CONSTRAINT [PK_TOrder] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TOrderCustomerInfo]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TOrderCustomerInfo](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[Timestamp] [timestamp] NULL,
	[OrderId] [bigint] NOT NULL,
	[Customer] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NOT NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[Region] [nvarchar](max) NULL,
	[PostCode] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
 CONSTRAINT [PK_TOrderCustomerInfo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TOrderDiscountInfo]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TOrderDiscountInfo](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[Timestamp] [timestamp] NULL,
	[OrderId] [bigint] NOT NULL,
	[Type] [int] NOT NULL,
	[CampaignCode] [nvarchar](max) NULL,
	[PromoCode] [nvarchar](max) NULL,
	[VoucherSerialNumber] [nvarchar](max) NULL,
	[DiscountAmount] [decimal](18, 4) NOT NULL,
	[DiscountApportionments] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TOrderDiscountInfo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TOrderItem]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TOrderItem](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[Timestamp] [timestamp] NULL,
	[OrderId] [bigint] NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[Code] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[SoldQuantity] [int] NOT NULL,
	[ShipQuantity] [int] NOT NULL,
	[ReturnQuantity] [int] NOT NULL,
	[UnitWeight] [decimal](18, 2) NULL,
	[UnitPrice] [decimal](18, 4) NOT NULL,
	[LineDiscount] [decimal](18, 4) NOT NULL,
	[TotalLineDiscount] [decimal](18, 4) NOT NULL,
	[TotalPriceAfterLineDiscount] [decimal](18, 4) NOT NULL,
	[TotalApportionedCartDiscount] [decimal](18, 4) NOT NULL,
	[FinalLineAmount] [decimal](18, 4) NOT NULL,
	[TaxAmount] [decimal](18, 4) NOT NULL,
	[Remarks] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[Base_FinalLineAmount] [decimal](18, 4) NULL,
	[IsBundled] [bit] NOT NULL,
 CONSTRAINT [PK_TOrderItem] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TOrderLog]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TOrderLog](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[Timestamp] [timestamp] NULL,
	[OrderId] [bigint] NOT NULL,
	[Action] [nvarchar](max) NULL,
	[Before] [nvarchar](max) NULL,
	[After] [nvarchar](max) NULL,
 CONSTRAINT [PK_TOrderLog] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TOrderPaymentInfo]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TOrderPaymentInfo](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[Timestamp] [timestamp] NULL,
	[OrderId] [bigint] NOT NULL,
	[Mode] [nvarchar](900) NOT NULL,
	[ReferenceNumber] [nvarchar](max) NULL,
	[Amount] [decimal](18, 4) NOT NULL,
	[Deleted] [bit] NOT NULL,
	[Remarks] [nvarchar](max) NULL,
 CONSTRAINT [PK_TOrderPaymentInfo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TOrderShipment]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TOrderShipment](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[Timestamp] [timestamp] NULL,
	[OrderId] [bigint] NOT NULL,
	[ShippingMethod] [nvarchar](max) NOT NULL,
	[RecipientName] [nvarchar](max) NOT NULL,
	[RecipientPhoneNumber] [nvarchar](max) NOT NULL,
	[DeliveryAddress] [nvarchar](max) NOT NULL,
	[Region] [nvarchar](max) NULL,
	[PostCode] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
	[PackageWeight] [decimal](18, 2) NULL,
	[PackageDimension] [decimal](18, 2) NULL,
	[ShippingLabel] [nvarchar](max) NULL,
	[TrackingNumber] [nvarchar](max) NULL,
	[ShippedOnUtc] [datetime2](7) NULL,
	[Status] [int] NOT NULL,
	[Items] [nvarchar](max) NOT NULL,
	[City] [nvarchar](max) NULL,
	[CountryCode] [nvarchar](max) NULL,
	[State] [nvarchar](max) NULL,
 CONSTRAINT [PK_TOrderShipment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TPriceBook]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TPriceBook](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[Timestamp] [timestamp] NULL,
	[TaxTypeId] [bigint] NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[IsMasterPriceList] [bit] NOT NULL,
	[Currency] [nvarchar](32) NOT NULL,
	[ItemPriceIncludeTax] [bit] NOT NULL,
	[DefaultFormula] [nvarchar](max) NULL,
	[ActiveVersion] [int] NOT NULL,
	[Status] [nvarchar](900) NOT NULL,
 CONSTRAINT [PK_TPriceBook] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TPriceBookAddOnItem]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TPriceBookAddOnItem](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[Timestamp] [timestamp] NULL,
	[PriceBookId] [bigint] NOT NULL,
	[ProductId] [bigint] NULL,
	[OptionKey] [nvarchar](max) NOT NULL,
	[Price] [decimal](18, 4) NOT NULL,
	[TaxAmount] [decimal](18, 4) NOT NULL,
	[Deleted] [bit] NOT NULL,
	[Code] [nvarchar](900) NULL,
	[Name] [nvarchar](900) NULL,
 CONSTRAINT [PK_TPriceBookAddOnItem] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TPriceBookItem]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TPriceBookItem](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[Timestamp] [timestamp] NULL,
	[PriceBookId] [bigint] NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[Version] [nvarchar](max) NOT NULL,
	[Price] [decimal](18, 4) NOT NULL,
	[TaxAmount] [decimal](18, 4) NOT NULL,
	[PublishStatus] [int] NOT NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_TPriceBookItem] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TPriceBookVersioning]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TPriceBookVersioning](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[Timestamp] [timestamp] NULL,
	[PriceBookId] [bigint] NOT NULL,
	[Version] [int] NOT NULL,
	[PublishOnUtc] [datetime2](7) NULL,
	[UnpublishOnUtc] [datetime2](7) NULL,
 CONSTRAINT [PK_TPriceBookVersioning] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TProduct]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TProduct](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[Timestamp] [timestamp] NULL,
	[ParentId] [bigint] NULL,
	[BrandId] [bigint] NULL,
	[DefaultCategoryId] [bigint] NOT NULL,
	[AttributeSetId] [bigint] NULL,
	[Name] [nvarchar](900) NOT NULL,
	[Code] [nvarchar](900) NOT NULL,
	[Type] [nvarchar](max) NOT NULL,
	[Price] [decimal](18, 4) NOT NULL,
	[Currency] [nvarchar](32) NOT NULL,
	[EnableInventoryTracking] [bit] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Specification] [nvarchar](max) NULL,
	[Permalink] [nvarchar](max) NULL,
	[PublishOnUtc] [datetime2](7) NOT NULL,
	[UnpublishOnUtc] [datetime2](7) NOT NULL,
	[PublishStatus] [nvarchar](900) NOT NULL,
	[Status] [nvarchar](900) NOT NULL,
	[Archived] [bit] NOT NULL,
	[DisplayCategories] [nvarchar](max) NOT NULL,
	[Attributes] [nvarchar](max) NOT NULL,
	[Tags] [nvarchar](max) NOT NULL,
	[Localization] [nvarchar](max) NOT NULL,
	[ImageVideos] [nvarchar](max) NOT NULL,
	[Seo] [nvarchar](max) NOT NULL,
	[ExtendedProperties] [nvarchar](max) NOT NULL,
	[AddOnItems] [nvarchar](max) NOT NULL,
	[BundledProducts] [nvarchar](max) NOT NULL,
	[RelatedProducts] [nvarchar](max) NOT NULL,
	[Channels] [nvarchar](max) NOT NULL,
	[Approvals] [nvarchar](max) NOT NULL,
	[ApprovalStatus] [nvarchar](900) NOT NULL,
	[ShortDescription] [nvarchar](max) NULL,
	[PackageContent] [nvarchar](max) NULL,
	[Model] [nvarchar](max) NULL,
	[Thumbnail] [nvarchar](max) NULL,
 CONSTRAINT [PK_TProduct] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TProductAttribute]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TProductAttribute](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[Timestamp] [timestamp] NULL,
	[Name] [nvarchar](900) NOT NULL,
	[Code] [nvarchar](900) NOT NULL,
	[Type] [nvarchar](max) NOT NULL,
	[Status] [nvarchar](450) NOT NULL,
	[Localization] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TProductAttribute] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TProductAttributeOption]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TProductAttributeOption](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[Timestamp] [timestamp] NULL,
	[ProductAttributeId] [bigint] NOT NULL,
	[Label] [nvarchar](max) NOT NULL,
	[Value] [nvarchar](max) NOT NULL,
	[Filter] [nvarchar](max) NULL,
	[Deleted] [bit] NOT NULL,
	[Localization] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TProductAttributeOption] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TProductAttributeSet]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TProductAttributeSet](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[Timestamp] [timestamp] NULL,
	[Name] [nvarchar](900) NOT NULL,
	[Status] [nvarchar](450) NOT NULL,
	[Localization] [nvarchar](max) NOT NULL,
	[ProductAttributes] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TProductAttributeSet] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TProductLog]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TProductLog](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[Timestamp] [timestamp] NULL,
	[ProductId] [bigint] NOT NULL,
	[Action] [nvarchar](max) NULL,
	[Before] [nvarchar](max) NULL,
	[After] [nvarchar](max) NULL,
 CONSTRAINT [PK_TProductLog] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TPromoGwp]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TPromoGwp](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[Timestamp] [timestamp] NULL,
	[CampaignName] [nvarchar](900) NOT NULL,
	[Type] [nvarchar](max) NOT NULL,
	[ChannelId] [bigint] NULL,
	[StartOnUtc] [datetime2](7) NOT NULL,
	[EndOnUtc] [datetime2](7) NOT NULL,
	[Inventory] [int] NULL,
	[InventoryBalance] [int] NULL,
	[MinimumPurchase] [decimal](18, 4) NULL,
	[Priority] [int] NOT NULL,
	[ContinueIfPass] [bit] NOT NULL,
	[SpecificProdCat] [bit] NOT NULL,
	[Deleted] [bit] NOT NULL,
	[Status] [nvarchar](max) NOT NULL,
	[MinPurchaseAmountStackable] [bit] NOT NULL,
	[ProdCatQtyStackable] [bit] NOT NULL,
	[Channels] [nvarchar](max) NULL,
 CONSTRAINT [PK_TPromoGwp] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TPromoGwpGift]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TPromoGwpGift](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[Timestamp] [timestamp] NULL,
	[PromoGwpId] [bigint] NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[PromoGwpGiftQuantity] [int] NOT NULL,
 CONSTRAINT [PK_TPromoGwpGift] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TPromoGwpProdCat]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TPromoGwpProdCat](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[Timestamp] [timestamp] NULL,
	[PromoGwpId] [bigint] NOT NULL,
	[ProductId] [bigint] NULL,
	[CategoryId] [bigint] NULL,
	[Type] [nvarchar](max) NULL,
	[PromoGwpProdCatQuantity] [int] NOT NULL,
 CONSTRAINT [PK_TPromoGwpProdCat] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TTaxonomy]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TTaxonomy](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[Timestamp] [timestamp] NULL,
	[Type] [nvarchar](900) NOT NULL,
	[Key] [nvarchar](900) NOT NULL,
	[Value] [nvarchar](900) NOT NULL,
	[Category] [nvarchar](900) NULL,
	[Deleted] [bit] NOT NULL,
 CONSTRAINT [PK_TTaxonomy] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TTaxType]    Script Date: 8/11/2021 4:08:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TTaxType](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Extra] [nvarchar](max) NULL,
	[CreatedOnUtc] [datetime2](7) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[LastUpdatedOnUtc] [datetime2](7) NULL,
	[LastUpdatedBy] [nvarchar](max) NULL,
	[Timestamp] [timestamp] NULL,
	[Name] [nvarchar](900) NOT NULL,
	[Code] [nvarchar](900) NOT NULL,
	[EffectiveFromUtc] [datetime2](7) NOT NULL,
	[EffectiveToUtc] [datetime2](7) NOT NULL,
	[TaxRate] [decimal](18, 8) NOT NULL,
	[Remarks] [nvarchar](max) NULL,
	[Status] [nvarchar](900) NOT NULL,
 CONSTRAINT [PK_TTaxType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190723070512_T1', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190906055523_T2', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190917102116_T3', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20190926065951_T4', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191001095823_T5', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191007081132_T6', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191017081507_T7', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191028084522_T8', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191104074205_T9', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191104101704_T10', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191111172906_T11', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191112074516_T12', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200116052125_T13', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200205094424_T14', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200311092917_T15', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200519085141_T16', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200618162217_T17', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200621014533_T18', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200623152315_T19', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200625021659_T20', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200629034941_T21', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200629080935_T22', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200629081417_T23', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200702073806_T24', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200708024110_T25', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200727040046_T26', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200729053751_T27', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200811083533_T28', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201223072211_T29', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210126065739_T30', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210313144601_T31', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210322071006_T32', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210403091410_T33', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210521060007_T34', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210614235707_T35', N'2.2.6-servicing-10079')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210620090340_T36', N'2.2.6-servicing-10079')
GO
SET IDENTITY_INSERT [dbo].[TBrand] ON 

INSERT [dbo].[TBrand] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [Name], [Code], [Description], [DisplayOrder], [PublishOnUtc], [UnpublishOnUtc], [Status], [Archived], [Seo], [Localization], [Y3PartnerCode]) VALUES (6234, NULL, CAST(N'2021-07-29T07:35:12.2211513' AS DateTime2), N'Steven', CAST(N'2021-07-29T07:35:12.2237180' AS DateTime2), N'Steven', N'Bondi-vite', N'bondi-vite', NULL, 0, CAST(N'2021-07-29T07:36:00.0000000' AS DateTime2), CAST(N'2121-07-29T07:36:00.0000000' AS DateTime2), N'Active', 0, N'{}', N'{"en-us":{"Description":null,"Label":null,"Name":"Bondi-vite","Specification":null,"Value":null,"Filter":null,"ShortDescription":null}}', NULL)
SET IDENTITY_INSERT [dbo].[TBrand] OFF
GO
SET IDENTITY_INSERT [dbo].[TCategory] ON 

INSERT [dbo].[TCategory] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [ParentId], [Name], [Code], [Level], [Description], [DisplayOrder], [PublishOnUtc], [UnpublishOnUtc], [Status], [Archived], [Seo], [ProductAttributeSets], [Localization], [MarketplaceCategory]) VALUES (9888, NULL, CAST(N'2021-07-29T07:55:33.4699499' AS DateTime2), N'Steven', CAST(N'2021-07-29T07:55:33.4743288' AS DateTime2), N'Steven', NULL, N'Default L1', N'default-l1', N'MainCategory', NULL, 1, CAST(N'2021-07-29T07:55:00.0000000' AS DateTime2), CAST(N'2121-07-29T07:55:00.0000000' AS DateTime2), N'Active', 0, N'{}', N'[9236]', N'{"en-us":{"Description":null,"Label":null,"Name":"Default L1","Specification":null,"Value":null,"Filter":null,"ShortDescription":null}}', N'{}')
INSERT [dbo].[TCategory] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [ParentId], [Name], [Code], [Level], [Description], [DisplayOrder], [PublishOnUtc], [UnpublishOnUtc], [Status], [Archived], [Seo], [ProductAttributeSets], [Localization], [MarketplaceCategory]) VALUES (9889, NULL, CAST(N'2021-07-29T07:56:52.8073508' AS DateTime2), N'Steven', CAST(N'2021-07-29T07:56:52.8076134' AS DateTime2), N'Steven', 9888, N'Default L2', N'default-l2', N'SubCategory', NULL, 1, CAST(N'2021-07-29T08:00:00.0000000' AS DateTime2), CAST(N'2121-07-29T08:00:00.0000000' AS DateTime2), N'Active', 0, N'{}', N'[9236]', N'{"en-us":{"Description":null,"Label":null,"Name":"Default L2","Specification":null,"Value":null,"Filter":null,"ShortDescription":null}}', N'{}')
SET IDENTITY_INSERT [dbo].[TCategory] OFF
GO
SET IDENTITY_INSERT [dbo].[TChannel] ON 

INSERT [dbo].[TChannel] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [InventoryId], [PriceBookId], [Name], [Type], [SubType], [Group], [Timezone], [IntegrationSettings], [Status], [CodePrefix], [StockSyncWithReservedStock], [StoreCode]) VALUES (1578, NULL, CAST(N'2021-07-29T07:25:44.3670610' AS DateTime2), N'Steven', CAST(N'2021-07-29T07:25:44.3696357' AS DateTime2), N'Steven', 2072, 1053, N'Lazada-Sg', N'Marketplace', N'lazada-sg', NULL, N'(UTC+08:00) Kuala Lumpur, Singapore', NULL, N'Active', N'LZSG', 1, NULL)
INSERT [dbo].[TChannel] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [InventoryId], [PriceBookId], [Name], [Type], [SubType], [Group], [Timezone], [IntegrationSettings], [Status], [CodePrefix], [StockSyncWithReservedStock], [StoreCode]) VALUES (1579, NULL, CAST(N'2021-07-29T07:27:41.2688514' AS DateTime2), N'Steven', CAST(N'2021-07-29T07:27:41.2692475' AS DateTime2), N'Steven', 2073, 1053, N'Ysg', N'Marketplace', N'ysg-sg', NULL, N'(UTC+08:00) Kuala Lumpur, Singapore', NULL, N'Active', N'YSGSG', 0, NULL)
SET IDENTITY_INSERT [dbo].[TChannel] OFF
GO
SET IDENTITY_INSERT [dbo].[TIndexBrand] ON 

INSERT [dbo].[TIndexBrand] ([Id], [Extra], [CreatedBy], [CreatedOnUtc], [LastUpdatedBy], [LastUpdatedOnUtc], [BrandId], [UpdatedOnUtc]) VALUES (9635, NULL, N'Steven', CAST(N'2021-07-29T11:09:23.1541901' AS DateTime2), N'Steven', CAST(N'2021-07-29T11:09:23.1556362' AS DateTime2), 6234, CAST(N'2021-07-29T11:09:23.1039579' AS DateTime2))
SET IDENTITY_INSERT [dbo].[TIndexBrand] OFF
GO
SET IDENTITY_INSERT [dbo].[TIndexProductCategory] ON 

INSERT [dbo].[TIndexProductCategory] ([Id], [Extra], [CreatedBy], [CreatedOnUtc], [LastUpdatedBy], [LastUpdatedOnUtc], [IndexBrandId], [ProductId], [CategoryId], [UpdatedOnUtc]) VALUES (3007, NULL, N'Steven', CAST(N'2021-07-29T11:09:23.2344630' AS DateTime2), N'Steven', CAST(N'2021-07-29T11:09:23.2359837' AS DateTime2), 9635, 7466, 9889, CAST(N'2021-07-29T11:09:23.1039579' AS DateTime2))
SET IDENTITY_INSERT [dbo].[TIndexProductCategory] OFF
GO
SET IDENTITY_INSERT [dbo].[TIndexProductInventory] ON 

INSERT [dbo].[TIndexProductInventory] ([Id], [Extra], [CreatedBy], [CreatedOnUtc], [LastUpdatedBy], [LastUpdatedOnUtc], [ProductId], [UpdatedOnUtc]) VALUES (8649, NULL, N'Steven', CAST(N'2021-07-29T11:09:23.3310853' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:46.0204758' AS DateTime2), 7466, CAST(N'2021-08-06T06:29:46.0186742' AS DateTime2))
SET IDENTITY_INSERT [dbo].[TIndexProductInventory] OFF
GO
SET IDENTITY_INSERT [dbo].[TIntegrationLog] ON 

INSERT [dbo].[TIntegrationLog] ([Id], [Extra], [CreatedBy], [CreatedOnUtc], [LastUpdatedBy], [LastUpdatedOnUtc], [ReferLogId], [RefNo], [Destination], [Action], [Url], [Request], [RetryRequest], [Response], [IsSuccess], [RetryCount]) VALUES (3820, NULL, NULL, CAST(N'2021-07-29T11:57:37.8172234' AS DateTime2), NULL, CAST(N'2021-07-29T11:57:37.8196086' AS DateTime2), NULL, N'0173c6e5-fa50-4ce2-b410-2077600db0d1', N'YCH MX3', N'Push Order', N'https://uatmx3.ych.com/mx3/messageService?messageType=AscentisPushOrderRequest&partnerCode=ASCENTIS&securityKey=bnfUVKwTeshCXDa8utGxCab4IYwLunSX', N'{"accountCode":"SGECOMM","ownerCode":"ASCENTIS","orderType":"B2C","orderNo":"YSGSG_BVSG_20210729-0000000","transactionType":"DELIVERY","transactionNo":"","status":"Paid","priority":"","serviceLevel":"3DA","salesChannel":"ysg-sg","orderTime":"2021-07-29T11:20:00.000+00:00","orderEdd":"2021-07-29T11:20:00.000+00:00","paymentTerm":"PREPAID","currencyCode":"SGD","orderValue":120.00,"customValue":120.00,"codAmount":0.0,"totalWeight":0.0,"totalVolume":0.0,"totalPackages":1,"orderItems":[{"lineNo":"1","status":"","productCode":"GGWP-S","orderUom":"PC","weight":0.0,"volume":0.0,"batchNo":"","varietyCode":"","supplierCode":"","orderQty":6,"itemValue":120.00,"itemMiscInfos":[{"miscFieldCode":"ITEM_DISCOUNT","value":"0.00"},{"miscFieldCode":"PARENT_SKU_CODE","value":"GGWP-S"},{"miscFieldCode":"PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"VOUCHER_AMOUNT","value":"0.00"}],"itemReferences":[],"itemInstructions":[],"productProperties":[]}],"orderContacts":[{"purposeCode":"PICKUP","contact":{"firstName":"Y3Contact","middleName":"","lastName":"","gender":"","title":"","contactMethods":[{"methodCode":"MOBILE","contactInfo":"00000000"},{"methodCode":"EMAIL","contactInfo":"default@email.com"}]},"address":{"addressLine1":"","addressLine2":"","addressLine3":"","addressLine4":"","addressLine5":"","company":"","unitNo":"","building":"","street1":"","street2":"","zone":"","city":"","region":"","state":"","countryCode":"","postcode":""}},{"purposeCode":"DELIVERY","contact":{"firstName":"Dev Steven","middleName":"","lastName":"","gender":"","title":"","contactMethods":[{"methodCode":"MOBILE","contactInfo":"123456789"},{"methodCode":"EMAIL","contactInfo":"default@email.com"}]},"address":{"addressLine1":"8 Bulim Ave","addressLine2":"SG","addressLine3":"","addressLine4":"","addressLine5":"","company":"","unitNo":"","building":"","street1":"8 Bulim Ave","street2":"SG","zone":"","city":"","region":"","state":"","countryCode":"SG","postcode":"123456"}},{"purposeCode":"BUYER","contact":{"firstName":"Dev Steven","middleName":"","lastName":"","gender":"","title":"","contactMethods":[{"methodCode":"MOBILE","contactInfo":"123456789"},{"methodCode":"EMAIL","contactInfo":"default@email.com"}]},"address":{"addressLine1":"","addressLine2":"","addressLine3":"","addressLine4":"","addressLine5":"","company":"","unitNo":"#05-07A","building":"YCH Supply Chain City Office Building","street1":"8 Bulim Avenue","street2":"","zone":"","city":"","region":"","state":"","countryCode":"SG","postcode":"648166"}}],"orderMiscInfos":[{"miscFieldCode":"ORDER_DISCOUNT","value":"0.00"},{"miscFieldCode":"MP_STORE_CODE","value":"default"},{"miscFieldCode":"TOTAL_PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"SHIPPING_AMOUNT","value":"0.00"}],"orderPartners":[{"partnerRole":"SELLER","partnerCode":"BVSG"}],"orderInstructions":[],"orderReferences":[{"referenceType":"CUSTREF","referenceKey1":"20210729-0000000","referenceKey2":"","referenceKey3":"","referenceKey4":"","referenceKey5":""}],"packingPackages":[]}', NULL, N'{"result":"SUCCESS","responseData":{"accountCode":"SGECOMM","ownerCode":"ASCENTIS","orderType":"B2C","orderNo":"YSGSG_BVSG_20210729-0000000","transactionType":"DELIVERY","transactionNo":"YCHSG21072900331","serviceLevel":"3DA","salesChannel":"ysg-sg","orderTime":"2021-07-29T11:20:00.000+0000","orderEdd":"2021-08-03T11:57:38.000+0000","paymentTerm":"PREPAID","currencyCode":"SGD","orderValue":120.00,"customValue":120.00,"codAmount":0.0,"totalWeight":0.0,"totalVolume":0.0,"totalPackages":1,"orderItems":[{"lineNo":"1","productCode":"GGWP-S","orderQty":6,"cancelQty":0,"itemValue":120.00,"orderUom":"PC","weight":0.0,"volume":0.0,"itemMiscInfos":[{"miscFieldCode":"ITEM_DISCOUNT","value":"0.00"},{"miscFieldCode":"PARENT_SKU_CODE","value":"GGWP-S"},{"miscFieldCode":"PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"VOUCHER_AMOUNT","value":"0.00"}]}],"orderPartners":[{"partnerRole":"SELLER","partnerCode":"BVSG"},{"partnerRole":"TRANSPORTER","partnerCode":"J&T"}],"orderContacts":[{"purposeCode":"PICKUP","contact":{"firstName":"Y3Contact"},"address":{}},{"purposeCode":"DELIVERY","contact":{"firstName":"Dev Steven"},"address":{"addressLine1":"8 Bulim Ave","addressLine2":"SG","unitNo":"8 Bulim Ave","building":"SG","street2":"SG","countryCode":"SG","postcode":"123456"}},{"purposeCode":"BUYER","contact":{"firstName":"Dev Steven"},"address":{"countryCode":"SG","postcode":"648166"}}],"orderReferences":[{"referenceType":"CUSTREF","referenceKey1":"20210729-0000000"}],"orderMiscInfos":[{"miscFieldCode":"ORDER_DISCOUNT","value":"0.00"},{"miscFieldCode":"MP_STORE_CODE","value":"default"},{"miscFieldCode":"TOTAL_PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"SHIPPING_AMOUNT","value":"0.00"}],"tptReqInd":true,"locale":"en"}}', 1, 0)
INSERT [dbo].[TIntegrationLog] ([Id], [Extra], [CreatedBy], [CreatedOnUtc], [LastUpdatedBy], [LastUpdatedOnUtc], [ReferLogId], [RefNo], [Destination], [Action], [Url], [Request], [RetryRequest], [Response], [IsSuccess], [RetryCount]) VALUES (3821, NULL, NULL, CAST(N'2021-08-06T06:28:18.5976305' AS DateTime2), NULL, CAST(N'2021-08-06T06:28:18.6003436' AS DateTime2), NULL, N'e17e6035-67e8-4d0a-97a4-c5cff8f9b457', N'YCH MX3', N'Push Order', N'https://uatmx3.ych.com/mx3/messageService?messageType=AscentisPushOrderRequest&partnerCode=ASCENTIS&securityKey=bnfUVKwTeshCXDa8utGxCab4IYwLunSX', N'{"accountCode":"SGECOMM","ownerCode":"ASCENTIS","orderType":"B2C","orderNo":"YSGSG_BVSG_20210896-0000000","transactionType":"DELIVERY","transactionNo":"","status":"Paid","priority":"","serviceLevel":"3DA","salesChannel":"ysg-sg","orderTime":"2021-07-29T11:20:00.000+00:00","orderEdd":"2021-07-29T11:20:00.000+00:00","paymentTerm":"PREPAID","currencyCode":"SGD","orderValue":120.00,"customValue":120.00,"codAmount":0.0,"totalWeight":0.0,"totalVolume":0.0,"totalPackages":1,"orderItems":[{"lineNo":"1","status":"","productCode":"GGWP-S","orderUom":"PC","weight":0.0,"volume":0.0,"batchNo":"","varietyCode":"","supplierCode":"","orderQty":6,"itemValue":120.00,"itemMiscInfos":[{"miscFieldCode":"ITEM_DISCOUNT","value":"0.00"},{"miscFieldCode":"PARENT_SKU_CODE","value":"GGWP-S"},{"miscFieldCode":"PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"VOUCHER_AMOUNT","value":"0.00"}],"itemReferences":[],"itemInstructions":[],"productProperties":[]}],"orderContacts":[{"purposeCode":"PICKUP","contact":{"firstName":"Y3Contact","middleName":"","lastName":"","gender":"","title":"","contactMethods":[{"methodCode":"MOBILE","contactInfo":"00000000"},{"methodCode":"EMAIL","contactInfo":"default@email.com"}]},"address":{"addressLine1":"","addressLine2":"","addressLine3":"","addressLine4":"","addressLine5":"","company":"","unitNo":"","building":"","street1":"","street2":"","zone":"","city":"","region":"","state":"","countryCode":"","postcode":""}},{"purposeCode":"DELIVERY","contact":{"firstName":"Dev Steven","middleName":"","lastName":"","gender":"","title":"","contactMethods":[{"methodCode":"MOBILE","contactInfo":"123456789"},{"methodCode":"EMAIL","contactInfo":"default@email.com"}]},"address":{"addressLine1":"8 Bulim Ave","addressLine2":"SG","addressLine3":"","addressLine4":"","addressLine5":"","company":"","unitNo":"","building":"","street1":"8 Bulim Ave","street2":"SG","zone":"","city":"","region":"","state":"","countryCode":"SG","postcode":"123456"}},{"purposeCode":"BUYER","contact":{"firstName":"Dev Steven","middleName":"","lastName":"","gender":"","title":"","contactMethods":[{"methodCode":"MOBILE","contactInfo":"123456789"},{"methodCode":"EMAIL","contactInfo":"default@email.com"}]},"address":{"addressLine1":"","addressLine2":"","addressLine3":"","addressLine4":"","addressLine5":"","company":"","unitNo":"#05-07A","building":"YCH Supply Chain City Office Building","street1":"8 Bulim Avenue","street2":"","zone":"","city":"","region":"","state":"","countryCode":"SG","postcode":"648166"}}],"orderMiscInfos":[{"miscFieldCode":"ORDER_DISCOUNT","value":"0.00"},{"miscFieldCode":"MP_STORE_CODE","value":"default"},{"miscFieldCode":"TOTAL_PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"SHIPPING_AMOUNT","value":"0.00"}],"orderPartners":[{"partnerRole":"SELLER","partnerCode":"BVSG"}],"orderInstructions":[],"orderReferences":[{"referenceType":"CUSTREF","referenceKey1":"20210896-0000000","referenceKey2":"","referenceKey3":"","referenceKey4":"","referenceKey5":""}],"packingPackages":[]}', NULL, N'{"result":"SUCCESS","responseData":{"accountCode":"SGECOMM","ownerCode":"ASCENTIS","orderType":"B2C","orderNo":"YSGSG_BVSG_20210896-0000000","transactionType":"DELIVERY","transactionNo":"YCHSG21080600341","serviceLevel":"3DA","salesChannel":"ysg-sg","orderTime":"2021-07-29T11:20:00.000+0000","orderEdd":"2021-08-11T06:28:20.000+0000","paymentTerm":"PREPAID","currencyCode":"SGD","orderValue":120.00,"customValue":120.00,"codAmount":0.0,"totalWeight":0.0,"totalVolume":0.0,"totalPackages":1,"orderItems":[{"lineNo":"1","productCode":"GGWP-S","orderQty":6,"cancelQty":0,"itemValue":120.00,"orderUom":"PC","weight":0.0,"volume":0.0,"itemMiscInfos":[{"miscFieldCode":"ITEM_DISCOUNT","value":"0.00"},{"miscFieldCode":"PARENT_SKU_CODE","value":"GGWP-S"},{"miscFieldCode":"PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"VOUCHER_AMOUNT","value":"0.00"}]}],"orderPartners":[{"partnerRole":"SELLER","partnerCode":"BVSG"},{"partnerRole":"TRANSPORTER","partnerCode":"J&T"}],"orderContacts":[{"purposeCode":"PICKUP","contact":{"firstName":"Y3Contact"},"address":{}},{"purposeCode":"DELIVERY","contact":{"firstName":"Dev Steven"},"address":{"addressLine1":"8 Bulim Ave","addressLine2":"SG","unitNo":"8 Bulim Ave","building":"SG","street2":"SG","countryCode":"SG","postcode":"123456"}},{"purposeCode":"BUYER","contact":{"firstName":"Dev Steven"},"address":{"countryCode":"SG","postcode":"648166"}}],"orderReferences":[{"referenceType":"CUSTREF","referenceKey1":"20210896-0000000"}],"orderMiscInfos":[{"miscFieldCode":"ORDER_DISCOUNT","value":"0.00"},{"miscFieldCode":"MP_STORE_CODE","value":"default"},{"miscFieldCode":"TOTAL_PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"SHIPPING_AMOUNT","value":"0.00"}],"tptReqInd":true,"locale":"en"}}', 1, 0)
INSERT [dbo].[TIntegrationLog] ([Id], [Extra], [CreatedBy], [CreatedOnUtc], [LastUpdatedBy], [LastUpdatedOnUtc], [ReferLogId], [RefNo], [Destination], [Action], [Url], [Request], [RetryRequest], [Response], [IsSuccess], [RetryCount]) VALUES (3822, NULL, NULL, CAST(N'2021-08-06T06:28:29.4249237' AS DateTime2), NULL, CAST(N'2021-08-06T06:28:29.4251035' AS DateTime2), NULL, N'5ca2db72-e64a-4471-8d7f-9d67a3408ba1', N'YCH MX3', N'Push Order', N'https://uatmx3.ych.com/mx3/messageService?messageType=AscentisPushOrderRequest&partnerCode=ASCENTIS&securityKey=bnfUVKwTeshCXDa8utGxCab4IYwLunSX', N'{"accountCode":"SGECOMM","ownerCode":"ASCENTIS","orderType":"B2C","orderNo":"YSGSG_BVSG_20210806-0000000","transactionType":"DELIVERY","transactionNo":"","status":"Paid","priority":"","serviceLevel":"3DA","salesChannel":"ysg-sg","orderTime":"2021-07-29T11:20:00.000+00:00","orderEdd":"2021-07-29T11:20:00.000+00:00","paymentTerm":"PREPAID","currencyCode":"SGD","orderValue":120.00,"customValue":120.00,"codAmount":0.0,"totalWeight":0.0,"totalVolume":0.0,"totalPackages":1,"orderItems":[{"lineNo":"1","status":"","productCode":"GGWP-S","orderUom":"PC","weight":0.0,"volume":0.0,"batchNo":"","varietyCode":"","supplierCode":"","orderQty":6,"itemValue":120.00,"itemMiscInfos":[{"miscFieldCode":"ITEM_DISCOUNT","value":"0.00"},{"miscFieldCode":"PARENT_SKU_CODE","value":"GGWP-S"},{"miscFieldCode":"PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"VOUCHER_AMOUNT","value":"0.00"}],"itemReferences":[],"itemInstructions":[],"productProperties":[]}],"orderContacts":[{"purposeCode":"PICKUP","contact":{"firstName":"Y3Contact","middleName":"","lastName":"","gender":"","title":"","contactMethods":[{"methodCode":"MOBILE","contactInfo":"00000000"},{"methodCode":"EMAIL","contactInfo":"default@email.com"}]},"address":{"addressLine1":"","addressLine2":"","addressLine3":"","addressLine4":"","addressLine5":"","company":"","unitNo":"","building":"","street1":"","street2":"","zone":"","city":"","region":"","state":"","countryCode":"","postcode":""}},{"purposeCode":"DELIVERY","contact":{"firstName":"Dev Steven","middleName":"","lastName":"","gender":"","title":"","contactMethods":[{"methodCode":"MOBILE","contactInfo":"123456789"},{"methodCode":"EMAIL","contactInfo":"default@email.com"}]},"address":{"addressLine1":"8 Bulim Ave","addressLine2":"SG","addressLine3":"","addressLine4":"","addressLine5":"","company":"","unitNo":"","building":"","street1":"8 Bulim Ave","street2":"SG","zone":"","city":"","region":"","state":"","countryCode":"SG","postcode":"123456"}},{"purposeCode":"BUYER","contact":{"firstName":"Dev Steven","middleName":"","lastName":"","gender":"","title":"","contactMethods":[{"methodCode":"MOBILE","contactInfo":"123456789"},{"methodCode":"EMAIL","contactInfo":"default@email.com"}]},"address":{"addressLine1":"","addressLine2":"","addressLine3":"","addressLine4":"","addressLine5":"","company":"","unitNo":"#05-07A","building":"YCH Supply Chain City Office Building","street1":"8 Bulim Avenue","street2":"","zone":"","city":"","region":"","state":"","countryCode":"SG","postcode":"648166"}}],"orderMiscInfos":[{"miscFieldCode":"ORDER_DISCOUNT","value":"0.00"},{"miscFieldCode":"MP_STORE_CODE","value":"default"},{"miscFieldCode":"TOTAL_PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"SHIPPING_AMOUNT","value":"0.00"}],"orderPartners":[{"partnerRole":"SELLER","partnerCode":"BVSG"}],"orderInstructions":[],"orderReferences":[{"referenceType":"CUSTREF","referenceKey1":"20210806-0000000","referenceKey2":"","referenceKey3":"","referenceKey4":"","referenceKey5":""}],"packingPackages":[]}', NULL, N'{"result":"SUCCESS","responseData":{"accountCode":"SGECOMM","ownerCode":"ASCENTIS","orderType":"B2C","orderNo":"YSGSG_BVSG_20210806-0000000","transactionType":"DELIVERY","transactionNo":"YCHSG21080600342","serviceLevel":"3DA","salesChannel":"ysg-sg","orderTime":"2021-07-29T11:20:00.000+0000","orderEdd":"2021-08-11T06:28:31.000+0000","paymentTerm":"PREPAID","currencyCode":"SGD","orderValue":120.00,"customValue":120.00,"codAmount":0.0,"totalWeight":0.0,"totalVolume":0.0,"totalPackages":1,"orderItems":[{"lineNo":"1","productCode":"GGWP-S","orderQty":6,"cancelQty":0,"itemValue":120.00,"orderUom":"PC","weight":0.0,"volume":0.0,"itemMiscInfos":[{"miscFieldCode":"ITEM_DISCOUNT","value":"0.00"},{"miscFieldCode":"PARENT_SKU_CODE","value":"GGWP-S"},{"miscFieldCode":"PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"VOUCHER_AMOUNT","value":"0.00"}]}],"orderPartners":[{"partnerRole":"SELLER","partnerCode":"BVSG"},{"partnerRole":"TRANSPORTER","partnerCode":"J&T"}],"orderContacts":[{"purposeCode":"PICKUP","contact":{"firstName":"Y3Contact"},"address":{}},{"purposeCode":"DELIVERY","contact":{"firstName":"Dev Steven"},"address":{"addressLine1":"8 Bulim Ave","addressLine2":"SG","unitNo":"8 Bulim Ave","building":"SG","street2":"SG","countryCode":"SG","postcode":"123456"}},{"purposeCode":"BUYER","contact":{"firstName":"Dev Steven"},"address":{"countryCode":"SG","postcode":"648166"}}],"orderReferences":[{"referenceType":"CUSTREF","referenceKey1":"20210806-0000000"}],"orderMiscInfos":[{"miscFieldCode":"ORDER_DISCOUNT","value":"0.00"},{"miscFieldCode":"MP_STORE_CODE","value":"default"},{"miscFieldCode":"TOTAL_PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"SHIPPING_AMOUNT","value":"0.00"}],"tptReqInd":true,"locale":"en"}}', 1, 0)
INSERT [dbo].[TIntegrationLog] ([Id], [Extra], [CreatedBy], [CreatedOnUtc], [LastUpdatedBy], [LastUpdatedOnUtc], [ReferLogId], [RefNo], [Destination], [Action], [Url], [Request], [RetryRequest], [Response], [IsSuccess], [RetryCount]) VALUES (3823, NULL, NULL, CAST(N'2021-08-06T06:28:37.0182930' AS DateTime2), NULL, CAST(N'2021-08-06T06:28:37.0184717' AS DateTime2), NULL, N'f896c799-fc3f-4975-beac-b5433453913f', N'YCH MX3', N'Push Order', N'https://uatmx3.ych.com/mx3/messageService?messageType=AscentisPushOrderRequest&partnerCode=ASCENTIS&securityKey=bnfUVKwTeshCXDa8utGxCab4IYwLunSX', N'{"accountCode":"SGECOMM","ownerCode":"ASCENTIS","orderType":"B2C","orderNo":"YSGSG_BVSG_20210806-0000002","transactionType":"DELIVERY","transactionNo":"","status":"Paid","priority":"","serviceLevel":"3DA","salesChannel":"ysg-sg","orderTime":"2021-07-29T11:20:00.000+00:00","orderEdd":"2021-07-29T11:20:00.000+00:00","paymentTerm":"PREPAID","currencyCode":"SGD","orderValue":120.00,"customValue":120.00,"codAmount":0.0,"totalWeight":0.0,"totalVolume":0.0,"totalPackages":1,"orderItems":[{"lineNo":"1","status":"","productCode":"GGWP-S","orderUom":"PC","weight":0.0,"volume":0.0,"batchNo":"","varietyCode":"","supplierCode":"","orderQty":6,"itemValue":120.00,"itemMiscInfos":[{"miscFieldCode":"ITEM_DISCOUNT","value":"0.00"},{"miscFieldCode":"PARENT_SKU_CODE","value":"GGWP-S"},{"miscFieldCode":"PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"VOUCHER_AMOUNT","value":"0.00"}],"itemReferences":[],"itemInstructions":[],"productProperties":[]}],"orderContacts":[{"purposeCode":"PICKUP","contact":{"firstName":"Y3Contact","middleName":"","lastName":"","gender":"","title":"","contactMethods":[{"methodCode":"MOBILE","contactInfo":"00000000"},{"methodCode":"EMAIL","contactInfo":"default@email.com"}]},"address":{"addressLine1":"","addressLine2":"","addressLine3":"","addressLine4":"","addressLine5":"","company":"","unitNo":"","building":"","street1":"","street2":"","zone":"","city":"","region":"","state":"","countryCode":"","postcode":""}},{"purposeCode":"DELIVERY","contact":{"firstName":"Dev Steven","middleName":"","lastName":"","gender":"","title":"","contactMethods":[{"methodCode":"MOBILE","contactInfo":"123456789"},{"methodCode":"EMAIL","contactInfo":"default@email.com"}]},"address":{"addressLine1":"8 Bulim Ave","addressLine2":"SG","addressLine3":"","addressLine4":"","addressLine5":"","company":"","unitNo":"","building":"","street1":"8 Bulim Ave","street2":"SG","zone":"","city":"","region":"","state":"","countryCode":"SG","postcode":"123456"}},{"purposeCode":"BUYER","contact":{"firstName":"Dev Steven","middleName":"","lastName":"","gender":"","title":"","contactMethods":[{"methodCode":"MOBILE","contactInfo":"123456789"},{"methodCode":"EMAIL","contactInfo":"default@email.com"}]},"address":{"addressLine1":"","addressLine2":"","addressLine3":"","addressLine4":"","addressLine5":"","company":"","unitNo":"#05-07A","building":"YCH Supply Chain City Office Building","street1":"8 Bulim Avenue","street2":"","zone":"","city":"","region":"","state":"","countryCode":"SG","postcode":"648166"}}],"orderMiscInfos":[{"miscFieldCode":"ORDER_DISCOUNT","value":"0.00"},{"miscFieldCode":"MP_STORE_CODE","value":"default"},{"miscFieldCode":"TOTAL_PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"SHIPPING_AMOUNT","value":"0.00"}],"orderPartners":[{"partnerRole":"SELLER","partnerCode":"BVSG"}],"orderInstructions":[],"orderReferences":[{"referenceType":"CUSTREF","referenceKey1":"20210806-0000002","referenceKey2":"","referenceKey3":"","referenceKey4":"","referenceKey5":""}],"packingPackages":[]}', NULL, N'{"result":"SUCCESS","responseData":{"accountCode":"SGECOMM","ownerCode":"ASCENTIS","orderType":"B2C","orderNo":"YSGSG_BVSG_20210806-0000002","transactionType":"DELIVERY","transactionNo":"YCHSG21080600343","serviceLevel":"3DA","salesChannel":"ysg-sg","orderTime":"2021-07-29T11:20:00.000+0000","orderEdd":"2021-08-11T06:28:39.000+0000","paymentTerm":"PREPAID","currencyCode":"SGD","orderValue":120.00,"customValue":120.00,"codAmount":0.0,"totalWeight":0.0,"totalVolume":0.0,"totalPackages":1,"orderItems":[{"lineNo":"1","productCode":"GGWP-S","orderQty":6,"cancelQty":0,"itemValue":120.00,"orderUom":"PC","weight":0.0,"volume":0.0,"itemMiscInfos":[{"miscFieldCode":"ITEM_DISCOUNT","value":"0.00"},{"miscFieldCode":"PARENT_SKU_CODE","value":"GGWP-S"},{"miscFieldCode":"PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"VOUCHER_AMOUNT","value":"0.00"}]}],"orderPartners":[{"partnerRole":"SELLER","partnerCode":"BVSG"},{"partnerRole":"TRANSPORTER","partnerCode":"J&T"}],"orderContacts":[{"purposeCode":"PICKUP","contact":{"firstName":"Y3Contact"},"address":{}},{"purposeCode":"DELIVERY","contact":{"firstName":"Dev Steven"},"address":{"addressLine1":"8 Bulim Ave","addressLine2":"SG","unitNo":"8 Bulim Ave","building":"SG","street2":"SG","countryCode":"SG","postcode":"123456"}},{"purposeCode":"BUYER","contact":{"firstName":"Dev Steven"},"address":{"countryCode":"SG","postcode":"648166"}}],"orderReferences":[{"referenceType":"CUSTREF","referenceKey1":"20210806-0000002"}],"orderMiscInfos":[{"miscFieldCode":"ORDER_DISCOUNT","value":"0.00"},{"miscFieldCode":"MP_STORE_CODE","value":"default"},{"miscFieldCode":"TOTAL_PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"SHIPPING_AMOUNT","value":"0.00"}],"tptReqInd":true,"locale":"en"}}', 1, 0)
INSERT [dbo].[TIntegrationLog] ([Id], [Extra], [CreatedBy], [CreatedOnUtc], [LastUpdatedBy], [LastUpdatedOnUtc], [ReferLogId], [RefNo], [Destination], [Action], [Url], [Request], [RetryRequest], [Response], [IsSuccess], [RetryCount]) VALUES (3824, NULL, NULL, CAST(N'2021-08-06T06:29:20.3291430' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:20.3294988' AS DateTime2), NULL, N'c1cdeda1-b96e-44df-8767-a761a34bb688', N'YCH MX3', N'Push Order', N'https://uatmx3.ych.com/mx3/messageService?messageType=AscentisPushOrderRequest&partnerCode=ASCENTIS&securityKey=bnfUVKwTeshCXDa8utGxCab4IYwLunSX', N'{"accountCode":"SGECOMM","ownerCode":"ASCENTIS","orderType":"B2C","orderNo":"YSGSG_BVSG_20210806-0000003","transactionType":"DELIVERY","transactionNo":"","status":"Paid","priority":"","serviceLevel":"3DA","salesChannel":"ysg-sg","orderTime":"2021-07-29T11:20:00.000+00:00","orderEdd":"2021-07-29T11:20:00.000+00:00","paymentTerm":"PREPAID","currencyCode":"SGD","orderValue":120.00,"customValue":120.00,"codAmount":0.0,"totalWeight":0.0,"totalVolume":0.0,"totalPackages":1,"orderItems":[{"lineNo":"1","status":"","productCode":"GGWP-S","orderUom":"PC","weight":0.0,"volume":0.0,"batchNo":"","varietyCode":"","supplierCode":"","orderQty":6,"itemValue":120.00,"itemMiscInfos":[{"miscFieldCode":"ITEM_DISCOUNT","value":"0.00"},{"miscFieldCode":"PARENT_SKU_CODE","value":"GGWP-S"},{"miscFieldCode":"PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"VOUCHER_AMOUNT","value":"0.00"}],"itemReferences":[],"itemInstructions":[],"productProperties":[]}],"orderContacts":[{"purposeCode":"PICKUP","contact":{"firstName":"Y3Contact","middleName":"","lastName":"","gender":"","title":"","contactMethods":[{"methodCode":"MOBILE","contactInfo":"00000000"},{"methodCode":"EMAIL","contactInfo":"default@email.com"}]},"address":{"addressLine1":"","addressLine2":"","addressLine3":"","addressLine4":"","addressLine5":"","company":"","unitNo":"","building":"","street1":"","street2":"","zone":"","city":"","region":"","state":"","countryCode":"","postcode":""}},{"purposeCode":"DELIVERY","contact":{"firstName":"Dev Steven","middleName":"","lastName":"","gender":"","title":"","contactMethods":[{"methodCode":"MOBILE","contactInfo":"123456789"},{"methodCode":"EMAIL","contactInfo":"default@email.com"}]},"address":{"addressLine1":"8 Bulim Ave","addressLine2":"SG","addressLine3":"","addressLine4":"","addressLine5":"","company":"","unitNo":"","building":"","street1":"8 Bulim Ave","street2":"SG","zone":"","city":"","region":"","state":"","countryCode":"SG","postcode":"123456"}},{"purposeCode":"BUYER","contact":{"firstName":"Dev Steven","middleName":"","lastName":"","gender":"","title":"","contactMethods":[{"methodCode":"MOBILE","contactInfo":"123456789"},{"methodCode":"EMAIL","contactInfo":"default@email.com"}]},"address":{"addressLine1":"","addressLine2":"","addressLine3":"","addressLine4":"","addressLine5":"","company":"","unitNo":"#05-07A","building":"YCH Supply Chain City Office Building","street1":"8 Bulim Avenue","street2":"","zone":"","city":"","region":"","state":"","countryCode":"SG","postcode":"648166"}}],"orderMiscInfos":[{"miscFieldCode":"ORDER_DISCOUNT","value":"0.00"},{"miscFieldCode":"MP_STORE_CODE","value":"default"},{"miscFieldCode":"TOTAL_PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"SHIPPING_AMOUNT","value":"0.00"}],"orderPartners":[{"partnerRole":"SELLER","partnerCode":"BVSG"}],"orderInstructions":[],"orderReferences":[{"referenceType":"CUSTREF","referenceKey1":"20210806-0000003","referenceKey2":"","referenceKey3":"","referenceKey4":"","referenceKey5":""}],"packingPackages":[]}', NULL, N'{"result":"SUCCESS","responseData":{"accountCode":"SGECOMM","ownerCode":"ASCENTIS","orderType":"B2C","orderNo":"YSGSG_BVSG_20210806-0000003","transactionType":"DELIVERY","transactionNo":"YCHSG21080600344","serviceLevel":"3DA","salesChannel":"ysg-sg","orderTime":"2021-07-29T11:20:00.000+0000","orderEdd":"2021-08-11T06:29:22.000+0000","paymentTerm":"PREPAID","currencyCode":"SGD","orderValue":120.00,"customValue":120.00,"codAmount":0.0,"totalWeight":0.0,"totalVolume":0.0,"totalPackages":1,"orderItems":[{"lineNo":"1","productCode":"GGWP-S","orderQty":6,"cancelQty":0,"itemValue":120.00,"orderUom":"PC","weight":0.0,"volume":0.0,"itemMiscInfos":[{"miscFieldCode":"ITEM_DISCOUNT","value":"0.00"},{"miscFieldCode":"PARENT_SKU_CODE","value":"GGWP-S"},{"miscFieldCode":"PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"VOUCHER_AMOUNT","value":"0.00"}]}],"orderPartners":[{"partnerRole":"SELLER","partnerCode":"BVSG"},{"partnerRole":"TRANSPORTER","partnerCode":"J&T"}],"orderContacts":[{"purposeCode":"PICKUP","contact":{"firstName":"Y3Contact"},"address":{}},{"purposeCode":"DELIVERY","contact":{"firstName":"Dev Steven"},"address":{"addressLine1":"8 Bulim Ave","addressLine2":"SG","unitNo":"8 Bulim Ave","building":"SG","street2":"SG","countryCode":"SG","postcode":"123456"}},{"purposeCode":"BUYER","contact":{"firstName":"Dev Steven"},"address":{"countryCode":"SG","postcode":"648166"}}],"orderReferences":[{"referenceType":"CUSTREF","referenceKey1":"20210806-0000003"}],"orderMiscInfos":[{"miscFieldCode":"ORDER_DISCOUNT","value":"0.00"},{"miscFieldCode":"MP_STORE_CODE","value":"default"},{"miscFieldCode":"TOTAL_PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"SHIPPING_AMOUNT","value":"0.00"}],"tptReqInd":true,"locale":"en"}}', 1, 0)
INSERT [dbo].[TIntegrationLog] ([Id], [Extra], [CreatedBy], [CreatedOnUtc], [LastUpdatedBy], [LastUpdatedOnUtc], [ReferLogId], [RefNo], [Destination], [Action], [Url], [Request], [RetryRequest], [Response], [IsSuccess], [RetryCount]) VALUES (3825, NULL, NULL, CAST(N'2021-08-06T06:29:23.8222600' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:23.8227119' AS DateTime2), NULL, N'7cfdf129-36b9-4f28-a106-2c74a1637ea5', N'YCH MX3', N'Push Order', N'https://uatmx3.ych.com/mx3/messageService?messageType=AscentisPushOrderRequest&partnerCode=ASCENTIS&securityKey=bnfUVKwTeshCXDa8utGxCab4IYwLunSX', N'{"accountCode":"SGECOMM","ownerCode":"ASCENTIS","orderType":"B2C","orderNo":"YSGSG_BVSG_20210806-0000004","transactionType":"DELIVERY","transactionNo":"","status":"Paid","priority":"","serviceLevel":"3DA","salesChannel":"ysg-sg","orderTime":"2021-07-29T11:20:00.000+00:00","orderEdd":"2021-07-29T11:20:00.000+00:00","paymentTerm":"PREPAID","currencyCode":"SGD","orderValue":120.00,"customValue":120.00,"codAmount":0.0,"totalWeight":0.0,"totalVolume":0.0,"totalPackages":1,"orderItems":[{"lineNo":"1","status":"","productCode":"GGWP-S","orderUom":"PC","weight":0.0,"volume":0.0,"batchNo":"","varietyCode":"","supplierCode":"","orderQty":6,"itemValue":120.00,"itemMiscInfos":[{"miscFieldCode":"ITEM_DISCOUNT","value":"0.00"},{"miscFieldCode":"PARENT_SKU_CODE","value":"GGWP-S"},{"miscFieldCode":"PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"VOUCHER_AMOUNT","value":"0.00"}],"itemReferences":[],"itemInstructions":[],"productProperties":[]}],"orderContacts":[{"purposeCode":"PICKUP","contact":{"firstName":"Y3Contact","middleName":"","lastName":"","gender":"","title":"","contactMethods":[{"methodCode":"MOBILE","contactInfo":"00000000"},{"methodCode":"EMAIL","contactInfo":"default@email.com"}]},"address":{"addressLine1":"","addressLine2":"","addressLine3":"","addressLine4":"","addressLine5":"","company":"","unitNo":"","building":"","street1":"","street2":"","zone":"","city":"","region":"","state":"","countryCode":"","postcode":""}},{"purposeCode":"DELIVERY","contact":{"firstName":"Dev Steven","middleName":"","lastName":"","gender":"","title":"","contactMethods":[{"methodCode":"MOBILE","contactInfo":"123456789"},{"methodCode":"EMAIL","contactInfo":"default@email.com"}]},"address":{"addressLine1":"8 Bulim Ave","addressLine2":"SG","addressLine3":"","addressLine4":"","addressLine5":"","company":"","unitNo":"","building":"","street1":"8 Bulim Ave","street2":"SG","zone":"","city":"","region":"","state":"","countryCode":"SG","postcode":"123456"}},{"purposeCode":"BUYER","contact":{"firstName":"Dev Steven","middleName":"","lastName":"","gender":"","title":"","contactMethods":[{"methodCode":"MOBILE","contactInfo":"123456789"},{"methodCode":"EMAIL","contactInfo":"default@email.com"}]},"address":{"addressLine1":"","addressLine2":"","addressLine3":"","addressLine4":"","addressLine5":"","company":"","unitNo":"#05-07A","building":"YCH Supply Chain City Office Building","street1":"8 Bulim Avenue","street2":"","zone":"","city":"","region":"","state":"","countryCode":"SG","postcode":"648166"}}],"orderMiscInfos":[{"miscFieldCode":"ORDER_DISCOUNT","value":"0.00"},{"miscFieldCode":"MP_STORE_CODE","value":"default"},{"miscFieldCode":"TOTAL_PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"SHIPPING_AMOUNT","value":"0.00"}],"orderPartners":[{"partnerRole":"SELLER","partnerCode":"BVSG"}],"orderInstructions":[],"orderReferences":[{"referenceType":"CUSTREF","referenceKey1":"20210806-0000004","referenceKey2":"","referenceKey3":"","referenceKey4":"","referenceKey5":""}],"packingPackages":[]}', NULL, N'{"result":"SUCCESS","responseData":{"accountCode":"SGECOMM","ownerCode":"ASCENTIS","orderType":"B2C","orderNo":"YSGSG_BVSG_20210806-0000004","transactionType":"DELIVERY","transactionNo":"YCHSG21080600345","serviceLevel":"3DA","salesChannel":"ysg-sg","orderTime":"2021-07-29T11:20:00.000+0000","orderEdd":"2021-08-11T06:29:25.000+0000","paymentTerm":"PREPAID","currencyCode":"SGD","orderValue":120.00,"customValue":120.00,"codAmount":0.0,"totalWeight":0.0,"totalVolume":0.0,"totalPackages":1,"orderItems":[{"lineNo":"1","productCode":"GGWP-S","orderQty":6,"cancelQty":0,"itemValue":120.00,"orderUom":"PC","weight":0.0,"volume":0.0,"itemMiscInfos":[{"miscFieldCode":"ITEM_DISCOUNT","value":"0.00"},{"miscFieldCode":"PARENT_SKU_CODE","value":"GGWP-S"},{"miscFieldCode":"PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"VOUCHER_AMOUNT","value":"0.00"}]}],"orderPartners":[{"partnerRole":"SELLER","partnerCode":"BVSG"},{"partnerRole":"TRANSPORTER","partnerCode":"J&T"}],"orderContacts":[{"purposeCode":"PICKUP","contact":{"firstName":"Y3Contact"},"address":{}},{"purposeCode":"DELIVERY","contact":{"firstName":"Dev Steven"},"address":{"addressLine1":"8 Bulim Ave","addressLine2":"SG","unitNo":"8 Bulim Ave","building":"SG","street2":"SG","countryCode":"SG","postcode":"123456"}},{"purposeCode":"BUYER","contact":{"firstName":"Dev Steven"},"address":{"countryCode":"SG","postcode":"648166"}}],"orderReferences":[{"referenceType":"CUSTREF","referenceKey1":"20210806-0000004"}],"orderMiscInfos":[{"miscFieldCode":"ORDER_DISCOUNT","value":"0.00"},{"miscFieldCode":"MP_STORE_CODE","value":"default"},{"miscFieldCode":"TOTAL_PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"SHIPPING_AMOUNT","value":"0.00"}],"tptReqInd":true,"locale":"en"}}', 1, 0)
INSERT [dbo].[TIntegrationLog] ([Id], [Extra], [CreatedBy], [CreatedOnUtc], [LastUpdatedBy], [LastUpdatedOnUtc], [ReferLogId], [RefNo], [Destination], [Action], [Url], [Request], [RetryRequest], [Response], [IsSuccess], [RetryCount]) VALUES (3826, NULL, NULL, CAST(N'2021-08-06T06:29:27.4358645' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:27.4360290' AS DateTime2), NULL, N'6c8991f9-6926-47e6-82b5-f53c20e97f8a', N'YCH MX3', N'Push Order', N'https://uatmx3.ych.com/mx3/messageService?messageType=AscentisPushOrderRequest&partnerCode=ASCENTIS&securityKey=bnfUVKwTeshCXDa8utGxCab4IYwLunSX', N'{"accountCode":"SGECOMM","ownerCode":"ASCENTIS","orderType":"B2C","orderNo":"YSGSG_BVSG_20210806-0000005","transactionType":"DELIVERY","transactionNo":"","status":"Paid","priority":"","serviceLevel":"3DA","salesChannel":"ysg-sg","orderTime":"2021-07-29T11:20:00.000+00:00","orderEdd":"2021-07-29T11:20:00.000+00:00","paymentTerm":"PREPAID","currencyCode":"SGD","orderValue":120.00,"customValue":120.00,"codAmount":0.0,"totalWeight":0.0,"totalVolume":0.0,"totalPackages":1,"orderItems":[{"lineNo":"1","status":"","productCode":"GGWP-S","orderUom":"PC","weight":0.0,"volume":0.0,"batchNo":"","varietyCode":"","supplierCode":"","orderQty":6,"itemValue":120.00,"itemMiscInfos":[{"miscFieldCode":"ITEM_DISCOUNT","value":"0.00"},{"miscFieldCode":"PARENT_SKU_CODE","value":"GGWP-S"},{"miscFieldCode":"PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"VOUCHER_AMOUNT","value":"0.00"}],"itemReferences":[],"itemInstructions":[],"productProperties":[]}],"orderContacts":[{"purposeCode":"PICKUP","contact":{"firstName":"Y3Contact","middleName":"","lastName":"","gender":"","title":"","contactMethods":[{"methodCode":"MOBILE","contactInfo":"00000000"},{"methodCode":"EMAIL","contactInfo":"default@email.com"}]},"address":{"addressLine1":"","addressLine2":"","addressLine3":"","addressLine4":"","addressLine5":"","company":"","unitNo":"","building":"","street1":"","street2":"","zone":"","city":"","region":"","state":"","countryCode":"","postcode":""}},{"purposeCode":"DELIVERY","contact":{"firstName":"Dev Steven","middleName":"","lastName":"","gender":"","title":"","contactMethods":[{"methodCode":"MOBILE","contactInfo":"123456789"},{"methodCode":"EMAIL","contactInfo":"default@email.com"}]},"address":{"addressLine1":"8 Bulim Ave","addressLine2":"SG","addressLine3":"","addressLine4":"","addressLine5":"","company":"","unitNo":"","building":"","street1":"8 Bulim Ave","street2":"SG","zone":"","city":"","region":"","state":"","countryCode":"SG","postcode":"123456"}},{"purposeCode":"BUYER","contact":{"firstName":"Dev Steven","middleName":"","lastName":"","gender":"","title":"","contactMethods":[{"methodCode":"MOBILE","contactInfo":"123456789"},{"methodCode":"EMAIL","contactInfo":"default@email.com"}]},"address":{"addressLine1":"","addressLine2":"","addressLine3":"","addressLine4":"","addressLine5":"","company":"","unitNo":"#05-07A","building":"YCH Supply Chain City Office Building","street1":"8 Bulim Avenue","street2":"","zone":"","city":"","region":"","state":"","countryCode":"SG","postcode":"648166"}}],"orderMiscInfos":[{"miscFieldCode":"ORDER_DISCOUNT","value":"0.00"},{"miscFieldCode":"MP_STORE_CODE","value":"default"},{"miscFieldCode":"TOTAL_PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"SHIPPING_AMOUNT","value":"0.00"}],"orderPartners":[{"partnerRole":"SELLER","partnerCode":"BVSG"}],"orderInstructions":[],"orderReferences":[{"referenceType":"CUSTREF","referenceKey1":"20210806-0000005","referenceKey2":"","referenceKey3":"","referenceKey4":"","referenceKey5":""}],"packingPackages":[]}', NULL, N'{"result":"SUCCESS","responseData":{"accountCode":"SGECOMM","ownerCode":"ASCENTIS","orderType":"B2C","orderNo":"YSGSG_BVSG_20210806-0000005","transactionType":"DELIVERY","transactionNo":"YCHSG21080600346","serviceLevel":"3DA","salesChannel":"ysg-sg","orderTime":"2021-07-29T11:20:00.000+0000","orderEdd":"2021-08-11T06:29:29.000+0000","paymentTerm":"PREPAID","currencyCode":"SGD","orderValue":120.00,"customValue":120.00,"codAmount":0.0,"totalWeight":0.0,"totalVolume":0.0,"totalPackages":1,"orderItems":[{"lineNo":"1","productCode":"GGWP-S","orderQty":6,"cancelQty":0,"itemValue":120.00,"orderUom":"PC","weight":0.0,"volume":0.0,"itemMiscInfos":[{"miscFieldCode":"ITEM_DISCOUNT","value":"0.00"},{"miscFieldCode":"PARENT_SKU_CODE","value":"GGWP-S"},{"miscFieldCode":"PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"VOUCHER_AMOUNT","value":"0.00"}]}],"orderPartners":[{"partnerRole":"SELLER","partnerCode":"BVSG"},{"partnerRole":"TRANSPORTER","partnerCode":"J&T"}],"orderContacts":[{"purposeCode":"PICKUP","contact":{"firstName":"Y3Contact"},"address":{}},{"purposeCode":"DELIVERY","contact":{"firstName":"Dev Steven"},"address":{"addressLine1":"8 Bulim Ave","addressLine2":"SG","unitNo":"8 Bulim Ave","building":"SG","street2":"SG","countryCode":"SG","postcode":"123456"}},{"purposeCode":"BUYER","contact":{"firstName":"Dev Steven"},"address":{"countryCode":"SG","postcode":"648166"}}],"orderReferences":[{"referenceType":"CUSTREF","referenceKey1":"20210806-0000005"}],"orderMiscInfos":[{"miscFieldCode":"ORDER_DISCOUNT","value":"0.00"},{"miscFieldCode":"MP_STORE_CODE","value":"default"},{"miscFieldCode":"TOTAL_PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"SHIPPING_AMOUNT","value":"0.00"}],"tptReqInd":true,"locale":"en"}}', 1, 0)
INSERT [dbo].[TIntegrationLog] ([Id], [Extra], [CreatedBy], [CreatedOnUtc], [LastUpdatedBy], [LastUpdatedOnUtc], [ReferLogId], [RefNo], [Destination], [Action], [Url], [Request], [RetryRequest], [Response], [IsSuccess], [RetryCount]) VALUES (3827, NULL, NULL, CAST(N'2021-08-06T06:29:31.0106234' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:31.0108036' AS DateTime2), NULL, N'75abf8f2-4d58-43f6-8884-01462508206c', N'YCH MX3', N'Push Order', N'https://uatmx3.ych.com/mx3/messageService?messageType=AscentisPushOrderRequest&partnerCode=ASCENTIS&securityKey=bnfUVKwTeshCXDa8utGxCab4IYwLunSX', N'{"accountCode":"SGECOMM","ownerCode":"ASCENTIS","orderType":"B2C","orderNo":"YSGSG_BVSG_20210806-0000006","transactionType":"DELIVERY","transactionNo":"","status":"Paid","priority":"","serviceLevel":"3DA","salesChannel":"ysg-sg","orderTime":"2021-07-29T11:20:00.000+00:00","orderEdd":"2021-07-29T11:20:00.000+00:00","paymentTerm":"PREPAID","currencyCode":"SGD","orderValue":120.00,"customValue":120.00,"codAmount":0.0,"totalWeight":0.0,"totalVolume":0.0,"totalPackages":1,"orderItems":[{"lineNo":"1","status":"","productCode":"GGWP-S","orderUom":"PC","weight":0.0,"volume":0.0,"batchNo":"","varietyCode":"","supplierCode":"","orderQty":6,"itemValue":120.00,"itemMiscInfos":[{"miscFieldCode":"ITEM_DISCOUNT","value":"0.00"},{"miscFieldCode":"PARENT_SKU_CODE","value":"GGWP-S"},{"miscFieldCode":"PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"VOUCHER_AMOUNT","value":"0.00"}],"itemReferences":[],"itemInstructions":[],"productProperties":[]}],"orderContacts":[{"purposeCode":"PICKUP","contact":{"firstName":"Y3Contact","middleName":"","lastName":"","gender":"","title":"","contactMethods":[{"methodCode":"MOBILE","contactInfo":"00000000"},{"methodCode":"EMAIL","contactInfo":"default@email.com"}]},"address":{"addressLine1":"","addressLine2":"","addressLine3":"","addressLine4":"","addressLine5":"","company":"","unitNo":"","building":"","street1":"","street2":"","zone":"","city":"","region":"","state":"","countryCode":"","postcode":""}},{"purposeCode":"DELIVERY","contact":{"firstName":"Dev Steven","middleName":"","lastName":"","gender":"","title":"","contactMethods":[{"methodCode":"MOBILE","contactInfo":"123456789"},{"methodCode":"EMAIL","contactInfo":"default@email.com"}]},"address":{"addressLine1":"8 Bulim Ave","addressLine2":"SG","addressLine3":"","addressLine4":"","addressLine5":"","company":"","unitNo":"","building":"","street1":"8 Bulim Ave","street2":"SG","zone":"","city":"","region":"","state":"","countryCode":"SG","postcode":"123456"}},{"purposeCode":"BUYER","contact":{"firstName":"Dev Steven","middleName":"","lastName":"","gender":"","title":"","contactMethods":[{"methodCode":"MOBILE","contactInfo":"123456789"},{"methodCode":"EMAIL","contactInfo":"default@email.com"}]},"address":{"addressLine1":"","addressLine2":"","addressLine3":"","addressLine4":"","addressLine5":"","company":"","unitNo":"#05-07A","building":"YCH Supply Chain City Office Building","street1":"8 Bulim Avenue","street2":"","zone":"","city":"","region":"","state":"","countryCode":"SG","postcode":"648166"}}],"orderMiscInfos":[{"miscFieldCode":"ORDER_DISCOUNT","value":"0.00"},{"miscFieldCode":"MP_STORE_CODE","value":"default"},{"miscFieldCode":"TOTAL_PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"SHIPPING_AMOUNT","value":"0.00"}],"orderPartners":[{"partnerRole":"SELLER","partnerCode":"BVSG"}],"orderInstructions":[],"orderReferences":[{"referenceType":"CUSTREF","referenceKey1":"20210806-0000006","referenceKey2":"","referenceKey3":"","referenceKey4":"","referenceKey5":""}],"packingPackages":[]}', NULL, N'{"result":"SUCCESS","responseData":{"accountCode":"SGECOMM","ownerCode":"ASCENTIS","orderType":"B2C","orderNo":"YSGSG_BVSG_20210806-0000006","transactionType":"DELIVERY","transactionNo":"YCHSG21080600347","serviceLevel":"3DA","salesChannel":"ysg-sg","orderTime":"2021-07-29T11:20:00.000+0000","orderEdd":"2021-08-11T06:29:32.000+0000","paymentTerm":"PREPAID","currencyCode":"SGD","orderValue":120.00,"customValue":120.00,"codAmount":0.0,"totalWeight":0.0,"totalVolume":0.0,"totalPackages":1,"orderItems":[{"lineNo":"1","productCode":"GGWP-S","orderQty":6,"cancelQty":0,"itemValue":120.00,"orderUom":"PC","weight":0.0,"volume":0.0,"itemMiscInfos":[{"miscFieldCode":"ITEM_DISCOUNT","value":"0.00"},{"miscFieldCode":"PARENT_SKU_CODE","value":"GGWP-S"},{"miscFieldCode":"PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"VOUCHER_AMOUNT","value":"0.00"}]}],"orderPartners":[{"partnerRole":"SELLER","partnerCode":"BVSG"},{"partnerRole":"TRANSPORTER","partnerCode":"J&T"}],"orderContacts":[{"purposeCode":"PICKUP","contact":{"firstName":"Y3Contact"},"address":{}},{"purposeCode":"DELIVERY","contact":{"firstName":"Dev Steven"},"address":{"addressLine1":"8 Bulim Ave","addressLine2":"SG","unitNo":"8 Bulim Ave","building":"SG","street2":"SG","countryCode":"SG","postcode":"123456"}},{"purposeCode":"BUYER","contact":{"firstName":"Dev Steven"},"address":{"countryCode":"SG","postcode":"648166"}}],"orderReferences":[{"referenceType":"CUSTREF","referenceKey1":"20210806-0000006"}],"orderMiscInfos":[{"miscFieldCode":"ORDER_DISCOUNT","value":"0.00"},{"miscFieldCode":"MP_STORE_CODE","value":"default"},{"miscFieldCode":"TOTAL_PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"SHIPPING_AMOUNT","value":"0.00"}],"tptReqInd":true,"locale":"en"}}', 1, 0)
INSERT [dbo].[TIntegrationLog] ([Id], [Extra], [CreatedBy], [CreatedOnUtc], [LastUpdatedBy], [LastUpdatedOnUtc], [ReferLogId], [RefNo], [Destination], [Action], [Url], [Request], [RetryRequest], [Response], [IsSuccess], [RetryCount]) VALUES (3828, NULL, NULL, CAST(N'2021-08-06T06:29:34.5645964' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:34.5647697' AS DateTime2), NULL, N'cb5c78b8-5b51-4a56-b3a0-8e5c878279ac', N'YCH MX3', N'Push Order', N'https://uatmx3.ych.com/mx3/messageService?messageType=AscentisPushOrderRequest&partnerCode=ASCENTIS&securityKey=bnfUVKwTeshCXDa8utGxCab4IYwLunSX', N'{"accountCode":"SGECOMM","ownerCode":"ASCENTIS","orderType":"B2C","orderNo":"YSGSG_BVSG_20210806-0000007","transactionType":"DELIVERY","transactionNo":"","status":"Paid","priority":"","serviceLevel":"3DA","salesChannel":"ysg-sg","orderTime":"2021-07-29T11:20:00.000+00:00","orderEdd":"2021-07-29T11:20:00.000+00:00","paymentTerm":"PREPAID","currencyCode":"SGD","orderValue":120.00,"customValue":120.00,"codAmount":0.0,"totalWeight":0.0,"totalVolume":0.0,"totalPackages":1,"orderItems":[{"lineNo":"1","status":"","productCode":"GGWP-S","orderUom":"PC","weight":0.0,"volume":0.0,"batchNo":"","varietyCode":"","supplierCode":"","orderQty":6,"itemValue":120.00,"itemMiscInfos":[{"miscFieldCode":"ITEM_DISCOUNT","value":"0.00"},{"miscFieldCode":"PARENT_SKU_CODE","value":"GGWP-S"},{"miscFieldCode":"PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"VOUCHER_AMOUNT","value":"0.00"}],"itemReferences":[],"itemInstructions":[],"productProperties":[]}],"orderContacts":[{"purposeCode":"PICKUP","contact":{"firstName":"Y3Contact","middleName":"","lastName":"","gender":"","title":"","contactMethods":[{"methodCode":"MOBILE","contactInfo":"00000000"},{"methodCode":"EMAIL","contactInfo":"default@email.com"}]},"address":{"addressLine1":"","addressLine2":"","addressLine3":"","addressLine4":"","addressLine5":"","company":"","unitNo":"","building":"","street1":"","street2":"","zone":"","city":"","region":"","state":"","countryCode":"","postcode":""}},{"purposeCode":"DELIVERY","contact":{"firstName":"Dev Steven","middleName":"","lastName":"","gender":"","title":"","contactMethods":[{"methodCode":"MOBILE","contactInfo":"123456789"},{"methodCode":"EMAIL","contactInfo":"default@email.com"}]},"address":{"addressLine1":"8 Bulim Ave","addressLine2":"SG","addressLine3":"","addressLine4":"","addressLine5":"","company":"","unitNo":"","building":"","street1":"8 Bulim Ave","street2":"SG","zone":"","city":"","region":"","state":"","countryCode":"SG","postcode":"123456"}},{"purposeCode":"BUYER","contact":{"firstName":"Dev Steven","middleName":"","lastName":"","gender":"","title":"","contactMethods":[{"methodCode":"MOBILE","contactInfo":"123456789"},{"methodCode":"EMAIL","contactInfo":"default@email.com"}]},"address":{"addressLine1":"","addressLine2":"","addressLine3":"","addressLine4":"","addressLine5":"","company":"","unitNo":"#05-07A","building":"YCH Supply Chain City Office Building","street1":"8 Bulim Avenue","street2":"","zone":"","city":"","region":"","state":"","countryCode":"SG","postcode":"648166"}}],"orderMiscInfos":[{"miscFieldCode":"ORDER_DISCOUNT","value":"0.00"},{"miscFieldCode":"MP_STORE_CODE","value":"default"},{"miscFieldCode":"TOTAL_PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"SHIPPING_AMOUNT","value":"0.00"}],"orderPartners":[{"partnerRole":"SELLER","partnerCode":"BVSG"}],"orderInstructions":[],"orderReferences":[{"referenceType":"CUSTREF","referenceKey1":"20210806-0000007","referenceKey2":"","referenceKey3":"","referenceKey4":"","referenceKey5":""}],"packingPackages":[]}', NULL, N'{"result":"SUCCESS","responseData":{"accountCode":"SGECOMM","ownerCode":"ASCENTIS","orderType":"B2C","orderNo":"YSGSG_BVSG_20210806-0000007","transactionType":"DELIVERY","transactionNo":"YCHSG21080600348","serviceLevel":"3DA","salesChannel":"ysg-sg","orderTime":"2021-07-29T11:20:00.000+0000","orderEdd":"2021-08-11T06:29:36.000+0000","paymentTerm":"PREPAID","currencyCode":"SGD","orderValue":120.00,"customValue":120.00,"codAmount":0.0,"totalWeight":0.0,"totalVolume":0.0,"totalPackages":1,"orderItems":[{"lineNo":"1","productCode":"GGWP-S","orderQty":6,"cancelQty":0,"itemValue":120.00,"orderUom":"PC","weight":0.0,"volume":0.0,"itemMiscInfos":[{"miscFieldCode":"ITEM_DISCOUNT","value":"0.00"},{"miscFieldCode":"PARENT_SKU_CODE","value":"GGWP-S"},{"miscFieldCode":"PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"VOUCHER_AMOUNT","value":"0.00"}]}],"orderPartners":[{"partnerRole":"SELLER","partnerCode":"BVSG"},{"partnerRole":"TRANSPORTER","partnerCode":"J&T"}],"orderContacts":[{"purposeCode":"PICKUP","contact":{"firstName":"Y3Contact"},"address":{}},{"purposeCode":"DELIVERY","contact":{"firstName":"Dev Steven"},"address":{"addressLine1":"8 Bulim Ave","addressLine2":"SG","unitNo":"8 Bulim Ave","building":"SG","street2":"SG","countryCode":"SG","postcode":"123456"}},{"purposeCode":"BUYER","contact":{"firstName":"Dev Steven"},"address":{"countryCode":"SG","postcode":"648166"}}],"orderReferences":[{"referenceType":"CUSTREF","referenceKey1":"20210806-0000007"}],"orderMiscInfos":[{"miscFieldCode":"ORDER_DISCOUNT","value":"0.00"},{"miscFieldCode":"MP_STORE_CODE","value":"default"},{"miscFieldCode":"TOTAL_PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"SHIPPING_AMOUNT","value":"0.00"}],"tptReqInd":true,"locale":"en"}}', 1, 0)
INSERT [dbo].[TIntegrationLog] ([Id], [Extra], [CreatedBy], [CreatedOnUtc], [LastUpdatedBy], [LastUpdatedOnUtc], [ReferLogId], [RefNo], [Destination], [Action], [Url], [Request], [RetryRequest], [Response], [IsSuccess], [RetryCount]) VALUES (3829, NULL, NULL, CAST(N'2021-08-06T06:29:38.8248509' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:38.8250129' AS DateTime2), NULL, N'bdeccec8-aef6-477a-9aed-561875d9576c', N'YCH MX3', N'Push Order', N'https://uatmx3.ych.com/mx3/messageService?messageType=AscentisPushOrderRequest&partnerCode=ASCENTIS&securityKey=bnfUVKwTeshCXDa8utGxCab4IYwLunSX', N'{"accountCode":"SGECOMM","ownerCode":"ASCENTIS","orderType":"B2C","orderNo":"YSGSG_BVSG_20210806-0000008","transactionType":"DELIVERY","transactionNo":"","status":"Paid","priority":"","serviceLevel":"3DA","salesChannel":"ysg-sg","orderTime":"2021-07-29T11:20:00.000+00:00","orderEdd":"2021-07-29T11:20:00.000+00:00","paymentTerm":"PREPAID","currencyCode":"SGD","orderValue":120.00,"customValue":120.00,"codAmount":0.0,"totalWeight":0.0,"totalVolume":0.0,"totalPackages":1,"orderItems":[{"lineNo":"1","status":"","productCode":"GGWP-S","orderUom":"PC","weight":0.0,"volume":0.0,"batchNo":"","varietyCode":"","supplierCode":"","orderQty":6,"itemValue":120.00,"itemMiscInfos":[{"miscFieldCode":"ITEM_DISCOUNT","value":"0.00"},{"miscFieldCode":"PARENT_SKU_CODE","value":"GGWP-S"},{"miscFieldCode":"PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"VOUCHER_AMOUNT","value":"0.00"}],"itemReferences":[],"itemInstructions":[],"productProperties":[]}],"orderContacts":[{"purposeCode":"PICKUP","contact":{"firstName":"Y3Contact","middleName":"","lastName":"","gender":"","title":"","contactMethods":[{"methodCode":"MOBILE","contactInfo":"00000000"},{"methodCode":"EMAIL","contactInfo":"default@email.com"}]},"address":{"addressLine1":"","addressLine2":"","addressLine3":"","addressLine4":"","addressLine5":"","company":"","unitNo":"","building":"","street1":"","street2":"","zone":"","city":"","region":"","state":"","countryCode":"","postcode":""}},{"purposeCode":"DELIVERY","contact":{"firstName":"Dev Steven","middleName":"","lastName":"","gender":"","title":"","contactMethods":[{"methodCode":"MOBILE","contactInfo":"123456789"},{"methodCode":"EMAIL","contactInfo":"default@email.com"}]},"address":{"addressLine1":"8 Bulim Ave","addressLine2":"SG","addressLine3":"","addressLine4":"","addressLine5":"","company":"","unitNo":"","building":"","street1":"8 Bulim Ave","street2":"SG","zone":"","city":"","region":"","state":"","countryCode":"SG","postcode":"123456"}},{"purposeCode":"BUYER","contact":{"firstName":"Dev Steven","middleName":"","lastName":"","gender":"","title":"","contactMethods":[{"methodCode":"MOBILE","contactInfo":"123456789"},{"methodCode":"EMAIL","contactInfo":"default@email.com"}]},"address":{"addressLine1":"","addressLine2":"","addressLine3":"","addressLine4":"","addressLine5":"","company":"","unitNo":"#05-07A","building":"YCH Supply Chain City Office Building","street1":"8 Bulim Avenue","street2":"","zone":"","city":"","region":"","state":"","countryCode":"SG","postcode":"648166"}}],"orderMiscInfos":[{"miscFieldCode":"ORDER_DISCOUNT","value":"0.00"},{"miscFieldCode":"MP_STORE_CODE","value":"default"},{"miscFieldCode":"TOTAL_PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"SHIPPING_AMOUNT","value":"0.00"}],"orderPartners":[{"partnerRole":"SELLER","partnerCode":"BVSG"}],"orderInstructions":[],"orderReferences":[{"referenceType":"CUSTREF","referenceKey1":"20210806-0000008","referenceKey2":"","referenceKey3":"","referenceKey4":"","referenceKey5":""}],"packingPackages":[]}', NULL, N'{"result":"SUCCESS","responseData":{"accountCode":"SGECOMM","ownerCode":"ASCENTIS","orderType":"B2C","orderNo":"YSGSG_BVSG_20210806-0000008","transactionType":"DELIVERY","transactionNo":"YCHSG21080600349","serviceLevel":"3DA","salesChannel":"ysg-sg","orderTime":"2021-07-29T11:20:00.000+0000","orderEdd":"2021-08-11T06:29:40.000+0000","paymentTerm":"PREPAID","currencyCode":"SGD","orderValue":120.00,"customValue":120.00,"codAmount":0.0,"totalWeight":0.0,"totalVolume":0.0,"totalPackages":1,"orderItems":[{"lineNo":"1","productCode":"GGWP-S","orderQty":6,"cancelQty":0,"itemValue":120.00,"orderUom":"PC","weight":0.0,"volume":0.0,"itemMiscInfos":[{"miscFieldCode":"ITEM_DISCOUNT","value":"0.00"},{"miscFieldCode":"PARENT_SKU_CODE","value":"GGWP-S"},{"miscFieldCode":"PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"VOUCHER_AMOUNT","value":"0.00"}]}],"orderPartners":[{"partnerRole":"SELLER","partnerCode":"BVSG"},{"partnerRole":"TRANSPORTER","partnerCode":"J&T"}],"orderContacts":[{"purposeCode":"PICKUP","contact":{"firstName":"Y3Contact"},"address":{}},{"purposeCode":"DELIVERY","contact":{"firstName":"Dev Steven"},"address":{"addressLine1":"8 Bulim Ave","addressLine2":"SG","unitNo":"8 Bulim Ave","building":"SG","street2":"SG","countryCode":"SG","postcode":"123456"}},{"purposeCode":"BUYER","contact":{"firstName":"Dev Steven"},"address":{"countryCode":"SG","postcode":"648166"}}],"orderReferences":[{"referenceType":"CUSTREF","referenceKey1":"20210806-0000008"}],"orderMiscInfos":[{"miscFieldCode":"ORDER_DISCOUNT","value":"0.00"},{"miscFieldCode":"MP_STORE_CODE","value":"default"},{"miscFieldCode":"TOTAL_PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"SHIPPING_AMOUNT","value":"0.00"}],"tptReqInd":true,"locale":"en"}}', 1, 0)
INSERT [dbo].[TIntegrationLog] ([Id], [Extra], [CreatedBy], [CreatedOnUtc], [LastUpdatedBy], [LastUpdatedOnUtc], [ReferLogId], [RefNo], [Destination], [Action], [Url], [Request], [RetryRequest], [Response], [IsSuccess], [RetryCount]) VALUES (3830, NULL, NULL, CAST(N'2021-08-06T06:29:42.1440462' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:42.1442374' AS DateTime2), NULL, N'5e7b2815-8ac7-49ba-be58-d60be236069e', N'YCH MX3', N'Push Order', N'https://uatmx3.ych.com/mx3/messageService?messageType=AscentisPushOrderRequest&partnerCode=ASCENTIS&securityKey=bnfUVKwTeshCXDa8utGxCab4IYwLunSX', N'{"accountCode":"SGECOMM","ownerCode":"ASCENTIS","orderType":"B2C","orderNo":"YSGSG_BVSG_20210806-0000009","transactionType":"DELIVERY","transactionNo":"","status":"Paid","priority":"","serviceLevel":"3DA","salesChannel":"ysg-sg","orderTime":"2021-07-29T11:20:00.000+00:00","orderEdd":"2021-07-29T11:20:00.000+00:00","paymentTerm":"PREPAID","currencyCode":"SGD","orderValue":120.00,"customValue":120.00,"codAmount":0.0,"totalWeight":0.0,"totalVolume":0.0,"totalPackages":1,"orderItems":[{"lineNo":"1","status":"","productCode":"GGWP-S","orderUom":"PC","weight":0.0,"volume":0.0,"batchNo":"","varietyCode":"","supplierCode":"","orderQty":6,"itemValue":120.00,"itemMiscInfos":[{"miscFieldCode":"ITEM_DISCOUNT","value":"0.00"},{"miscFieldCode":"PARENT_SKU_CODE","value":"GGWP-S"},{"miscFieldCode":"PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"VOUCHER_AMOUNT","value":"0.00"}],"itemReferences":[],"itemInstructions":[],"productProperties":[]}],"orderContacts":[{"purposeCode":"PICKUP","contact":{"firstName":"Y3Contact","middleName":"","lastName":"","gender":"","title":"","contactMethods":[{"methodCode":"MOBILE","contactInfo":"00000000"},{"methodCode":"EMAIL","contactInfo":"default@email.com"}]},"address":{"addressLine1":"","addressLine2":"","addressLine3":"","addressLine4":"","addressLine5":"","company":"","unitNo":"","building":"","street1":"","street2":"","zone":"","city":"","region":"","state":"","countryCode":"","postcode":""}},{"purposeCode":"DELIVERY","contact":{"firstName":"Dev Steven","middleName":"","lastName":"","gender":"","title":"","contactMethods":[{"methodCode":"MOBILE","contactInfo":"123456789"},{"methodCode":"EMAIL","contactInfo":"default@email.com"}]},"address":{"addressLine1":"8 Bulim Ave","addressLine2":"SG","addressLine3":"","addressLine4":"","addressLine5":"","company":"","unitNo":"","building":"","street1":"8 Bulim Ave","street2":"SG","zone":"","city":"","region":"","state":"","countryCode":"SG","postcode":"123456"}},{"purposeCode":"BUYER","contact":{"firstName":"Dev Steven","middleName":"","lastName":"","gender":"","title":"","contactMethods":[{"methodCode":"MOBILE","contactInfo":"123456789"},{"methodCode":"EMAIL","contactInfo":"default@email.com"}]},"address":{"addressLine1":"","addressLine2":"","addressLine3":"","addressLine4":"","addressLine5":"","company":"","unitNo":"#05-07A","building":"YCH Supply Chain City Office Building","street1":"8 Bulim Avenue","street2":"","zone":"","city":"","region":"","state":"","countryCode":"SG","postcode":"648166"}}],"orderMiscInfos":[{"miscFieldCode":"ORDER_DISCOUNT","value":"0.00"},{"miscFieldCode":"MP_STORE_CODE","value":"default"},{"miscFieldCode":"TOTAL_PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"SHIPPING_AMOUNT","value":"0.00"}],"orderPartners":[{"partnerRole":"SELLER","partnerCode":"BVSG"}],"orderInstructions":[],"orderReferences":[{"referenceType":"CUSTREF","referenceKey1":"20210806-0000009","referenceKey2":"","referenceKey3":"","referenceKey4":"","referenceKey5":""}],"packingPackages":[]}', NULL, N'{"result":"SUCCESS","responseData":{"accountCode":"SGECOMM","ownerCode":"ASCENTIS","orderType":"B2C","orderNo":"YSGSG_BVSG_20210806-0000009","transactionType":"DELIVERY","transactionNo":"YCHSG21080600350","serviceLevel":"3DA","salesChannel":"ysg-sg","orderTime":"2021-07-29T11:20:00.000+0000","orderEdd":"2021-08-11T06:29:44.000+0000","paymentTerm":"PREPAID","currencyCode":"SGD","orderValue":120.00,"customValue":120.00,"codAmount":0.0,"totalWeight":0.0,"totalVolume":0.0,"totalPackages":1,"orderItems":[{"lineNo":"1","productCode":"GGWP-S","orderQty":6,"cancelQty":0,"itemValue":120.00,"orderUom":"PC","weight":0.0,"volume":0.0,"itemMiscInfos":[{"miscFieldCode":"ITEM_DISCOUNT","value":"0.00"},{"miscFieldCode":"PARENT_SKU_CODE","value":"GGWP-S"},{"miscFieldCode":"PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"VOUCHER_AMOUNT","value":"0.00"}]}],"orderPartners":[{"partnerRole":"SELLER","partnerCode":"BVSG"},{"partnerRole":"TRANSPORTER","partnerCode":"J&T"}],"orderContacts":[{"purposeCode":"PICKUP","contact":{"firstName":"Y3Contact"},"address":{}},{"purposeCode":"DELIVERY","contact":{"firstName":"Dev Steven"},"address":{"addressLine1":"8 Bulim Ave","addressLine2":"SG","unitNo":"8 Bulim Ave","building":"SG","street2":"SG","countryCode":"SG","postcode":"123456"}},{"purposeCode":"BUYER","contact":{"firstName":"Dev Steven"},"address":{"countryCode":"SG","postcode":"648166"}}],"orderReferences":[{"referenceType":"CUSTREF","referenceKey1":"20210806-0000009"}],"orderMiscInfos":[{"miscFieldCode":"ORDER_DISCOUNT","value":"0.00"},{"miscFieldCode":"MP_STORE_CODE","value":"default"},{"miscFieldCode":"TOTAL_PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"SHIPPING_AMOUNT","value":"0.00"}],"tptReqInd":true,"locale":"en"}}', 1, 0)
INSERT [dbo].[TIntegrationLog] ([Id], [Extra], [CreatedBy], [CreatedOnUtc], [LastUpdatedBy], [LastUpdatedOnUtc], [ReferLogId], [RefNo], [Destination], [Action], [Url], [Request], [RetryRequest], [Response], [IsSuccess], [RetryCount]) VALUES (3831, NULL, NULL, CAST(N'2021-08-06T06:29:46.7046758' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:46.7048351' AS DateTime2), NULL, N'80218318-b9d3-49ee-a5bc-bd3b3877a272', N'YCH MX3', N'Push Order', N'https://uatmx3.ych.com/mx3/messageService?messageType=AscentisPushOrderRequest&partnerCode=ASCENTIS&securityKey=bnfUVKwTeshCXDa8utGxCab4IYwLunSX', N'{"accountCode":"SGECOMM","ownerCode":"ASCENTIS","orderType":"B2C","orderNo":"YSGSG_BVSG_20210806-0000010","transactionType":"DELIVERY","transactionNo":"","status":"Paid","priority":"","serviceLevel":"3DA","salesChannel":"ysg-sg","orderTime":"2021-07-29T11:20:00.000+00:00","orderEdd":"2021-07-29T11:20:00.000+00:00","paymentTerm":"PREPAID","currencyCode":"SGD","orderValue":120.00,"customValue":120.00,"codAmount":0.0,"totalWeight":0.0,"totalVolume":0.0,"totalPackages":1,"orderItems":[{"lineNo":"1","status":"","productCode":"GGWP-S","orderUom":"PC","weight":0.0,"volume":0.0,"batchNo":"","varietyCode":"","supplierCode":"","orderQty":6,"itemValue":120.00,"itemMiscInfos":[{"miscFieldCode":"ITEM_DISCOUNT","value":"0.00"},{"miscFieldCode":"PARENT_SKU_CODE","value":"GGWP-S"},{"miscFieldCode":"PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"VOUCHER_AMOUNT","value":"0.00"}],"itemReferences":[],"itemInstructions":[],"productProperties":[]}],"orderContacts":[{"purposeCode":"PICKUP","contact":{"firstName":"Y3Contact","middleName":"","lastName":"","gender":"","title":"","contactMethods":[{"methodCode":"MOBILE","contactInfo":"00000000"},{"methodCode":"EMAIL","contactInfo":"default@email.com"}]},"address":{"addressLine1":"","addressLine2":"","addressLine3":"","addressLine4":"","addressLine5":"","company":"","unitNo":"","building":"","street1":"","street2":"","zone":"","city":"","region":"","state":"","countryCode":"","postcode":""}},{"purposeCode":"DELIVERY","contact":{"firstName":"Dev Steven","middleName":"","lastName":"","gender":"","title":"","contactMethods":[{"methodCode":"MOBILE","contactInfo":"123456789"},{"methodCode":"EMAIL","contactInfo":"default@email.com"}]},"address":{"addressLine1":"8 Bulim Ave","addressLine2":"SG","addressLine3":"","addressLine4":"","addressLine5":"","company":"","unitNo":"","building":"","street1":"8 Bulim Ave","street2":"SG","zone":"","city":"","region":"","state":"","countryCode":"SG","postcode":"123456"}},{"purposeCode":"BUYER","contact":{"firstName":"Dev Steven","middleName":"","lastName":"","gender":"","title":"","contactMethods":[{"methodCode":"MOBILE","contactInfo":"123456789"},{"methodCode":"EMAIL","contactInfo":"default@email.com"}]},"address":{"addressLine1":"","addressLine2":"","addressLine3":"","addressLine4":"","addressLine5":"","company":"","unitNo":"#05-07A","building":"YCH Supply Chain City Office Building","street1":"8 Bulim Avenue","street2":"","zone":"","city":"","region":"","state":"","countryCode":"SG","postcode":"648166"}}],"orderMiscInfos":[{"miscFieldCode":"ORDER_DISCOUNT","value":"0.00"},{"miscFieldCode":"MP_STORE_CODE","value":"default"},{"miscFieldCode":"TOTAL_PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"SHIPPING_AMOUNT","value":"0.00"}],"orderPartners":[{"partnerRole":"SELLER","partnerCode":"BVSG"}],"orderInstructions":[],"orderReferences":[{"referenceType":"CUSTREF","referenceKey1":"20210806-0000010","referenceKey2":"","referenceKey3":"","referenceKey4":"","referenceKey5":""}],"packingPackages":[]}', NULL, N'{"result":"SUCCESS","responseData":{"accountCode":"SGECOMM","ownerCode":"ASCENTIS","orderType":"B2C","orderNo":"YSGSG_BVSG_20210806-0000010","transactionType":"DELIVERY","transactionNo":"YCHSG21080600351","serviceLevel":"3DA","salesChannel":"ysg-sg","orderTime":"2021-07-29T11:20:00.000+0000","orderEdd":"2021-08-11T06:29:48.000+0000","paymentTerm":"PREPAID","currencyCode":"SGD","orderValue":120.00,"customValue":120.00,"codAmount":0.0,"totalWeight":0.0,"totalVolume":0.0,"totalPackages":1,"orderItems":[{"lineNo":"1","productCode":"GGWP-S","orderQty":6,"cancelQty":0,"itemValue":120.00,"orderUom":"PC","weight":0.0,"volume":0.0,"itemMiscInfos":[{"miscFieldCode":"ITEM_DISCOUNT","value":"0.00"},{"miscFieldCode":"PARENT_SKU_CODE","value":"GGWP-S"},{"miscFieldCode":"PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"VOUCHER_AMOUNT","value":"0.00"}]}],"orderPartners":[{"partnerRole":"SELLER","partnerCode":"BVSG"},{"partnerRole":"TRANSPORTER","partnerCode":"J&T"}],"orderContacts":[{"purposeCode":"PICKUP","contact":{"firstName":"Y3Contact"},"address":{}},{"purposeCode":"DELIVERY","contact":{"firstName":"Dev Steven"},"address":{"addressLine1":"8 Bulim Ave","addressLine2":"SG","unitNo":"8 Bulim Ave","building":"SG","street2":"SG","countryCode":"SG","postcode":"123456"}},{"purposeCode":"BUYER","contact":{"firstName":"Dev Steven"},"address":{"countryCode":"SG","postcode":"648166"}}],"orderReferences":[{"referenceType":"CUSTREF","referenceKey1":"20210806-0000010"}],"orderMiscInfos":[{"miscFieldCode":"ORDER_DISCOUNT","value":"0.00"},{"miscFieldCode":"MP_STORE_CODE","value":"default"},{"miscFieldCode":"TOTAL_PAID_AMOUNT","value":"120.00"},{"miscFieldCode":"SHIPPING_AMOUNT","value":"0.00"}],"tptReqInd":true,"locale":"en"}}', 1, 0)
SET IDENTITY_INSERT [dbo].[TIntegrationLog] OFF
GO
SET IDENTITY_INSERT [dbo].[TInventory] ON 

INSERT [dbo].[TInventory] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [Name], [Type], [SafetyStockLevel], [LowStockNotificationThreshold], [Status], [DedicatedChannelId]) VALUES (2071, NULL, CAST(N'2021-07-29T07:20:44.7633953' AS DateTime2), N'Steven', CAST(N'2021-07-29T07:20:44.7651519' AS DateTime2), N'Steven', N'SCC_L5', N'PhysicalInventory', 0, 10, N'Active', NULL)
INSERT [dbo].[TInventory] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [Name], [Type], [SafetyStockLevel], [LowStockNotificationThreshold], [Status], [DedicatedChannelId]) VALUES (2072, NULL, CAST(N'2021-07-29T07:21:09.4360994' AS DateTime2), N'Steven', CAST(N'2021-07-29T07:21:09.4362933' AS DateTime2), N'Steven', N'SCC_L5_Geek', N'PhysicalInventory', 0, 10, N'Active', NULL)
INSERT [dbo].[TInventory] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [Name], [Type], [SafetyStockLevel], [LowStockNotificationThreshold], [Status], [DedicatedChannelId]) VALUES (2073, NULL, CAST(N'2021-07-29T07:21:44.7430155' AS DateTime2), N'Steven', CAST(N'2021-07-29T07:21:44.7431930' AS DateTime2), N'Steven', N'YCH', N'VirtualInventory', 0, 0, N'Active', NULL)
INSERT [dbo].[TInventory] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [Name], [Type], [SafetyStockLevel], [LowStockNotificationThreshold], [Status], [DedicatedChannelId]) VALUES (2074, NULL, CAST(N'2021-07-29T07:25:44.4733254' AS DateTime2), N'Steven', CAST(N'2021-07-29T07:25:44.4734847' AS DateTime2), N'Steven', N'Lazada-Sg', N'DedicatedChannel', 0, 0, N'Active', 1578)
INSERT [dbo].[TInventory] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [Name], [Type], [SafetyStockLevel], [LowStockNotificationThreshold], [Status], [DedicatedChannelId]) VALUES (2075, NULL, CAST(N'2021-07-29T07:27:41.3010585' AS DateTime2), N'Steven', CAST(N'2021-07-29T07:27:41.3012244' AS DateTime2), N'Steven', N'Ysg', N'DedicatedChannel', 0, 0, N'Active', 1579)
SET IDENTITY_INSERT [dbo].[TInventory] OFF
GO
SET IDENTITY_INSERT [dbo].[TInventoryItem] ON 

INSERT [dbo].[TInventoryItem] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [InventoryId], [ProductId], [SafetyStockLevel], [LowStockNotificationThreshold], [AvailableQuantity], [ReservedQuantity], [InTransitQuantity], [BackOrderQuantity], [Deleted], [ReservedByChannel]) VALUES (5574, NULL, CAST(N'2021-07-29T11:57:35.8651321' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:41.6048903' AS DateTime2), NULL, 2072, 7466, NULL, NULL, -36, 36, 0, 0, 0, N'{}')
INSERT [dbo].[TInventoryItem] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [InventoryId], [ProductId], [SafetyStockLevel], [LowStockNotificationThreshold], [AvailableQuantity], [ReservedQuantity], [InTransitQuantity], [BackOrderQuantity], [Deleted], [ReservedByChannel]) VALUES (5575, NULL, CAST(N'2021-08-06T06:28:16.8052451' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:45.9714073' AS DateTime2), NULL, 2071, 7466, NULL, NULL, -36, 36, 0, 0, 0, N'{}')
SET IDENTITY_INSERT [dbo].[TInventoryItem] OFF
GO
SET IDENTITY_INSERT [dbo].[TInventoryLedger] ON 

INSERT [dbo].[TInventoryLedger] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [InventoryId], [ProductId], [Bucket], [Quantity], [DocumentType], [DocumentReferenceNumber], [DestinationInventoryId], [PerformedOnUtc], [ReferenceId], [ChannelId]) VALUES (3375, NULL, CAST(N'2021-07-29T11:57:35.8651533' AS DateTime2), NULL, CAST(N'2021-07-29T11:57:35.8677186' AS DateTime2), NULL, 2072, 7466, N'Available', -6, N'Sales', N'YSGSG_BVSG_20210729-0000000', NULL, CAST(N'2021-07-29T11:57:35.7356436' AS DateTime2), 4638, NULL)
INSERT [dbo].[TInventoryLedger] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [InventoryId], [ProductId], [Bucket], [Quantity], [DocumentType], [DocumentReferenceNumber], [DestinationInventoryId], [PerformedOnUtc], [ReferenceId], [ChannelId]) VALUES (3376, NULL, CAST(N'2021-07-29T11:57:35.8651632' AS DateTime2), NULL, CAST(N'2021-07-29T11:57:35.8677253' AS DateTime2), NULL, 2072, 7466, N'Reserved', 6, N'Sales', N'YSGSG_BVSG_20210729-0000000', NULL, CAST(N'2021-07-29T11:57:35.7854556' AS DateTime2), 4638, NULL)
INSERT [dbo].[TInventoryLedger] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [InventoryId], [ProductId], [Bucket], [Quantity], [DocumentType], [DocumentReferenceNumber], [DestinationInventoryId], [PerformedOnUtc], [ReferenceId], [ChannelId]) VALUES (3377, NULL, CAST(N'2021-08-06T06:28:16.8052548' AS DateTime2), NULL, CAST(N'2021-08-06T06:28:16.8079356' AS DateTime2), NULL, 2071, 7466, N'Available', -6, N'Sales', N'YSGSG_BVSG_20210896-0000000', NULL, CAST(N'2021-08-06T06:28:16.6784354' AS DateTime2), 4639, NULL)
INSERT [dbo].[TInventoryLedger] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [InventoryId], [ProductId], [Bucket], [Quantity], [DocumentType], [DocumentReferenceNumber], [DestinationInventoryId], [PerformedOnUtc], [ReferenceId], [ChannelId]) VALUES (3378, NULL, CAST(N'2021-08-06T06:28:16.8052625' AS DateTime2), NULL, CAST(N'2021-08-06T06:28:16.8079431' AS DateTime2), NULL, 2071, 7466, N'Reserved', 6, N'Sales', N'YSGSG_BVSG_20210896-0000000', NULL, CAST(N'2021-08-06T06:28:16.7270007' AS DateTime2), 4639, NULL)
INSERT [dbo].[TInventoryLedger] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [InventoryId], [ProductId], [Bucket], [Quantity], [DocumentType], [DocumentReferenceNumber], [DestinationInventoryId], [PerformedOnUtc], [ReferenceId], [ChannelId]) VALUES (3379, NULL, CAST(N'2021-08-06T06:28:28.6553805' AS DateTime2), NULL, CAST(N'2021-08-06T06:28:28.6558550' AS DateTime2), NULL, 2072, 7466, N'Available', -6, N'Sales', N'YSGSG_BVSG_20210806-0000000', NULL, CAST(N'2021-08-06T06:28:28.6544615' AS DateTime2), 4640, NULL)
INSERT [dbo].[TInventoryLedger] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [InventoryId], [ProductId], [Bucket], [Quantity], [DocumentType], [DocumentReferenceNumber], [DestinationInventoryId], [PerformedOnUtc], [ReferenceId], [ChannelId]) VALUES (3380, NULL, CAST(N'2021-08-06T06:28:28.6553886' AS DateTime2), NULL, CAST(N'2021-08-06T06:28:28.6558619' AS DateTime2), NULL, 2072, 7466, N'Reserved', 6, N'Sales', N'YSGSG_BVSG_20210806-0000000', NULL, CAST(N'2021-08-06T06:28:28.6546698' AS DateTime2), 4640, NULL)
INSERT [dbo].[TInventoryLedger] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [InventoryId], [ProductId], [Bucket], [Quantity], [DocumentType], [DocumentReferenceNumber], [DestinationInventoryId], [PerformedOnUtc], [ReferenceId], [ChannelId]) VALUES (3381, NULL, CAST(N'2021-08-06T06:28:36.3504188' AS DateTime2), NULL, CAST(N'2021-08-06T06:28:36.3510615' AS DateTime2), NULL, 2071, 7466, N'Available', -6, N'Sales', N'YSGSG_BVSG_20210806-0000002', NULL, CAST(N'2021-08-06T06:28:36.3495633' AS DateTime2), 4641, NULL)
INSERT [dbo].[TInventoryLedger] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [InventoryId], [ProductId], [Bucket], [Quantity], [DocumentType], [DocumentReferenceNumber], [DestinationInventoryId], [PerformedOnUtc], [ReferenceId], [ChannelId]) VALUES (3382, NULL, CAST(N'2021-08-06T06:28:36.3504263' AS DateTime2), NULL, CAST(N'2021-08-06T06:28:36.3510685' AS DateTime2), NULL, 2071, 7466, N'Reserved', 6, N'Sales', N'YSGSG_BVSG_20210806-0000002', NULL, CAST(N'2021-08-06T06:28:36.3497680' AS DateTime2), 4641, NULL)
INSERT [dbo].[TInventoryLedger] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [InventoryId], [ProductId], [Bucket], [Quantity], [DocumentType], [DocumentReferenceNumber], [DestinationInventoryId], [PerformedOnUtc], [ReferenceId], [ChannelId]) VALUES (3383, NULL, CAST(N'2021-08-06T06:29:19.5243776' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:19.5248489' AS DateTime2), NULL, 2072, 7466, N'Available', -6, N'Sales', N'YSGSG_BVSG_20210806-0000003', NULL, CAST(N'2021-08-06T06:29:19.5234887' AS DateTime2), 4642, NULL)
INSERT [dbo].[TInventoryLedger] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [InventoryId], [ProductId], [Bucket], [Quantity], [DocumentType], [DocumentReferenceNumber], [DestinationInventoryId], [PerformedOnUtc], [ReferenceId], [ChannelId]) VALUES (3384, NULL, CAST(N'2021-08-06T06:29:19.5243853' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:19.5248560' AS DateTime2), NULL, 2072, 7466, N'Reserved', 6, N'Sales', N'YSGSG_BVSG_20210806-0000003', NULL, CAST(N'2021-08-06T06:29:19.5237235' AS DateTime2), 4642, NULL)
INSERT [dbo].[TInventoryLedger] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [InventoryId], [ProductId], [Bucket], [Quantity], [DocumentType], [DocumentReferenceNumber], [DestinationInventoryId], [PerformedOnUtc], [ReferenceId], [ChannelId]) VALUES (3385, NULL, CAST(N'2021-08-06T06:29:23.1953494' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:23.1960002' AS DateTime2), NULL, 2071, 7466, N'Available', -6, N'Sales', N'YSGSG_BVSG_20210806-0000004', NULL, CAST(N'2021-08-06T06:29:23.1943429' AS DateTime2), 4643, NULL)
INSERT [dbo].[TInventoryLedger] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [InventoryId], [ProductId], [Bucket], [Quantity], [DocumentType], [DocumentReferenceNumber], [DestinationInventoryId], [PerformedOnUtc], [ReferenceId], [ChannelId]) VALUES (3386, NULL, CAST(N'2021-08-06T06:29:23.1953569' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:23.1960070' AS DateTime2), NULL, 2071, 7466, N'Reserved', 6, N'Sales', N'YSGSG_BVSG_20210806-0000004', NULL, CAST(N'2021-08-06T06:29:23.1946646' AS DateTime2), 4643, NULL)
INSERT [dbo].[TInventoryLedger] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [InventoryId], [ProductId], [Bucket], [Quantity], [DocumentType], [DocumentReferenceNumber], [DestinationInventoryId], [PerformedOnUtc], [ReferenceId], [ChannelId]) VALUES (3387, NULL, CAST(N'2021-08-06T06:29:26.7687559' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:26.7692262' AS DateTime2), NULL, 2072, 7466, N'Available', -6, N'Sales', N'YSGSG_BVSG_20210806-0000005', NULL, CAST(N'2021-08-06T06:29:26.7678971' AS DateTime2), 4644, NULL)
INSERT [dbo].[TInventoryLedger] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [InventoryId], [ProductId], [Bucket], [Quantity], [DocumentType], [DocumentReferenceNumber], [DestinationInventoryId], [PerformedOnUtc], [ReferenceId], [ChannelId]) VALUES (3388, NULL, CAST(N'2021-08-06T06:29:26.7687779' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:26.7692331' AS DateTime2), NULL, 2072, 7466, N'Reserved', 6, N'Sales', N'YSGSG_BVSG_20210806-0000005', NULL, CAST(N'2021-08-06T06:29:26.7681087' AS DateTime2), 4644, NULL)
INSERT [dbo].[TInventoryLedger] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [InventoryId], [ProductId], [Bucket], [Quantity], [DocumentType], [DocumentReferenceNumber], [DestinationInventoryId], [PerformedOnUtc], [ReferenceId], [ChannelId]) VALUES (3389, NULL, CAST(N'2021-08-06T06:29:30.2514978' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:30.2520065' AS DateTime2), NULL, 2071, 7466, N'Available', -6, N'Sales', N'YSGSG_BVSG_20210806-0000006', NULL, CAST(N'2021-08-06T06:29:30.2503983' AS DateTime2), 4645, NULL)
INSERT [dbo].[TInventoryLedger] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [InventoryId], [ProductId], [Bucket], [Quantity], [DocumentType], [DocumentReferenceNumber], [DestinationInventoryId], [PerformedOnUtc], [ReferenceId], [ChannelId]) VALUES (3390, NULL, CAST(N'2021-08-06T06:29:30.2515054' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:30.2520134' AS DateTime2), NULL, 2071, 7466, N'Reserved', 6, N'Sales', N'YSGSG_BVSG_20210806-0000006', NULL, CAST(N'2021-08-06T06:29:30.2505910' AS DateTime2), 4645, NULL)
INSERT [dbo].[TInventoryLedger] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [InventoryId], [ProductId], [Bucket], [Quantity], [DocumentType], [DocumentReferenceNumber], [DestinationInventoryId], [PerformedOnUtc], [ReferenceId], [ChannelId]) VALUES (3391, NULL, CAST(N'2021-08-06T06:29:33.9068592' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:33.9073863' AS DateTime2), NULL, 2072, 7466, N'Available', -6, N'Sales', N'YSGSG_BVSG_20210806-0000007', NULL, CAST(N'2021-08-06T06:29:33.9058987' AS DateTime2), 4646, NULL)
INSERT [dbo].[TInventoryLedger] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [InventoryId], [ProductId], [Bucket], [Quantity], [DocumentType], [DocumentReferenceNumber], [DestinationInventoryId], [PerformedOnUtc], [ReferenceId], [ChannelId]) VALUES (3392, NULL, CAST(N'2021-08-06T06:29:33.9068898' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:33.9073932' AS DateTime2), NULL, 2072, 7466, N'Reserved', 6, N'Sales', N'YSGSG_BVSG_20210806-0000007', NULL, CAST(N'2021-08-06T06:29:33.9061002' AS DateTime2), 4646, NULL)
INSERT [dbo].[TInventoryLedger] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [InventoryId], [ProductId], [Bucket], [Quantity], [DocumentType], [DocumentReferenceNumber], [DestinationInventoryId], [PerformedOnUtc], [ReferenceId], [ChannelId]) VALUES (3393, NULL, CAST(N'2021-08-06T06:29:38.2155506' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:38.2165507' AS DateTime2), NULL, 2071, 7466, N'Available', -6, N'Sales', N'YSGSG_BVSG_20210806-0000008', NULL, CAST(N'2021-08-06T06:29:38.2134622' AS DateTime2), 4647, NULL)
INSERT [dbo].[TInventoryLedger] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [InventoryId], [ProductId], [Bucket], [Quantity], [DocumentType], [DocumentReferenceNumber], [DestinationInventoryId], [PerformedOnUtc], [ReferenceId], [ChannelId]) VALUES (3394, NULL, CAST(N'2021-08-06T06:29:38.2155686' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:38.2165584' AS DateTime2), NULL, 2071, 7466, N'Reserved', 6, N'Sales', N'YSGSG_BVSG_20210806-0000008', NULL, CAST(N'2021-08-06T06:29:38.2139307' AS DateTime2), 4647, NULL)
INSERT [dbo].[TInventoryLedger] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [InventoryId], [ProductId], [Bucket], [Quantity], [DocumentType], [DocumentReferenceNumber], [DestinationInventoryId], [PerformedOnUtc], [ReferenceId], [ChannelId]) VALUES (3395, NULL, CAST(N'2021-08-06T06:29:41.6044401' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:41.6048975' AS DateTime2), NULL, 2072, 7466, N'Available', -6, N'Sales', N'YSGSG_BVSG_20210806-0000009', NULL, CAST(N'2021-08-06T06:29:41.6036638' AS DateTime2), 4648, NULL)
INSERT [dbo].[TInventoryLedger] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [InventoryId], [ProductId], [Bucket], [Quantity], [DocumentType], [DocumentReferenceNumber], [DestinationInventoryId], [PerformedOnUtc], [ReferenceId], [ChannelId]) VALUES (3396, NULL, CAST(N'2021-08-06T06:29:41.6044478' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:41.6049044' AS DateTime2), NULL, 2072, 7466, N'Reserved', 6, N'Sales', N'YSGSG_BVSG_20210806-0000009', NULL, CAST(N'2021-08-06T06:29:41.6038562' AS DateTime2), 4648, NULL)
INSERT [dbo].[TInventoryLedger] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [InventoryId], [ProductId], [Bucket], [Quantity], [DocumentType], [DocumentReferenceNumber], [DestinationInventoryId], [PerformedOnUtc], [ReferenceId], [ChannelId]) VALUES (3397, NULL, CAST(N'2021-08-06T06:29:45.9709764' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:45.9715789' AS DateTime2), NULL, 2071, 7466, N'Available', -6, N'Sales', N'YSGSG_BVSG_20210806-0000010', NULL, CAST(N'2021-08-06T06:29:45.9693738' AS DateTime2), 4649, NULL)
INSERT [dbo].[TInventoryLedger] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [InventoryId], [ProductId], [Bucket], [Quantity], [DocumentType], [DocumentReferenceNumber], [DestinationInventoryId], [PerformedOnUtc], [ReferenceId], [ChannelId]) VALUES (3398, NULL, CAST(N'2021-08-06T06:29:45.9709839' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:45.9715984' AS DateTime2), NULL, 2071, 7466, N'Reserved', 6, N'Sales', N'YSGSG_BVSG_20210806-0000010', NULL, CAST(N'2021-08-06T06:29:45.9700354' AS DateTime2), 4649, NULL)
SET IDENTITY_INSERT [dbo].[TInventoryLedger] OFF
GO
SET IDENTITY_INSERT [dbo].[TInventoryMap] ON 

INSERT [dbo].[TInventoryMap] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [VirtualInventoryId], [PhysicalInventoryId], [Deleted], [LastDeductStockOnUtc]) VALUES (2227, NULL, CAST(N'2021-07-29T07:21:44.8090977' AS DateTime2), N'Steven', CAST(N'2021-08-06T06:29:41.6048840' AS DateTime2), NULL, 2073, 2072, 0, CAST(N'2021-08-06T06:29:41.6039514' AS DateTime2))
INSERT [dbo].[TInventoryMap] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [VirtualInventoryId], [PhysicalInventoryId], [Deleted], [LastDeductStockOnUtc]) VALUES (2228, NULL, CAST(N'2021-07-29T07:21:44.8091355' AS DateTime2), N'Steven', CAST(N'2021-08-06T06:29:45.9714015' AS DateTime2), NULL, 2073, 2071, 0, CAST(N'2021-08-06T06:29:45.9702202' AS DateTime2))
SET IDENTITY_INSERT [dbo].[TInventoryMap] OFF
GO
SET IDENTITY_INSERT [dbo].[TOrder] ON 

INSERT [dbo].[TOrder] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OriginalOrderId], [ChannelId], [OrderNumber], [OrderOnUtc], [ChannelType], [Type], [DeliveryMethod], [ReferralCode], [CustomerType], [Customer], [Currency], [SubTotal], [TotalCartDiscount], [GrossSavings], [ShippingFee], [TotalAmountDue], [TotalAmountPaid], [BalanceAmountDue], [TotalTaxAmount], [Status], [CancelledReason], [LastStatusUpdatedOnUtc], [ReturnAndExchangeOrders], [Comments], [StatusChangeLogs], [PickUpChannelId], [Base_BalanceAmountDue], [Base_TotalAmountDue], [Base_TotalAmountPaid], [ExchangeRate], [Base_TotalTaxAmount], [ShippingServiceLevel], [OrderInstructions], [PosStatus]) VALUES (4638, NULL, CAST(N'2021-07-29T19:20:00.0000000' AS DateTime2), NULL, CAST(N'2021-08-11T01:05:44.4073956' AS DateTime2), NULL, NULL, 1579, N'YSGSG_BVSG_20210729-0000000', CAST(N'2021-07-29T11:20:00.0000000' AS DateTime2), N'Marketplace', N'SaleOrder', N'HomeDelivery', NULL, 0, N'Dev Steven', N'SGD', CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), N'Paid', NULL, NULL, N'[]', N'[]', N'[{"Status":2,"UpdatedBy":null,"UpdatedOnUtc":"2021-07-29T11:57:34.0958843Z"}]', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[TOrder] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OriginalOrderId], [ChannelId], [OrderNumber], [OrderOnUtc], [ChannelType], [Type], [DeliveryMethod], [ReferralCode], [CustomerType], [Customer], [Currency], [SubTotal], [TotalCartDiscount], [GrossSavings], [ShippingFee], [TotalAmountDue], [TotalAmountPaid], [BalanceAmountDue], [TotalTaxAmount], [Status], [CancelledReason], [LastStatusUpdatedOnUtc], [ReturnAndExchangeOrders], [Comments], [StatusChangeLogs], [PickUpChannelId], [Base_BalanceAmountDue], [Base_TotalAmountDue], [Base_TotalAmountPaid], [ExchangeRate], [Base_TotalTaxAmount], [ShippingServiceLevel], [OrderInstructions], [PosStatus]) VALUES (4639, NULL, CAST(N'2021-07-29T19:20:00.0000000' AS DateTime2), NULL, CAST(N'2021-08-11T01:05:44.4074085' AS DateTime2), NULL, NULL, 1579, N'YSGSG_BVSG_20210896-0000000', CAST(N'2021-07-29T11:20:00.0000000' AS DateTime2), N'Marketplace', N'SaleOrder', N'HomeDelivery', NULL, 0, N'Dev Steven', N'SGD', CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), N'Paid', NULL, NULL, N'[]', N'[]', N'[{"Status":2,"UpdatedBy":null,"UpdatedOnUtc":"2021-08-06T06:28:14.9877775Z"}]', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[TOrder] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OriginalOrderId], [ChannelId], [OrderNumber], [OrderOnUtc], [ChannelType], [Type], [DeliveryMethod], [ReferralCode], [CustomerType], [Customer], [Currency], [SubTotal], [TotalCartDiscount], [GrossSavings], [ShippingFee], [TotalAmountDue], [TotalAmountPaid], [BalanceAmountDue], [TotalTaxAmount], [Status], [CancelledReason], [LastStatusUpdatedOnUtc], [ReturnAndExchangeOrders], [Comments], [StatusChangeLogs], [PickUpChannelId], [Base_BalanceAmountDue], [Base_TotalAmountDue], [Base_TotalAmountPaid], [ExchangeRate], [Base_TotalTaxAmount], [ShippingServiceLevel], [OrderInstructions], [PosStatus]) VALUES (4640, NULL, CAST(N'2021-07-29T19:20:00.0000000' AS DateTime2), NULL, CAST(N'2021-08-11T01:05:44.4074195' AS DateTime2), NULL, NULL, 1579, N'YSGSG_BVSG_20210806-0000000', CAST(N'2021-07-29T11:20:00.0000000' AS DateTime2), N'Marketplace', N'SaleOrder', N'HomeDelivery', NULL, 0, N'Dev Steven', N'SGD', CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), N'Paid', NULL, NULL, N'[]', N'[]', N'[{"Status":2,"UpdatedBy":null,"UpdatedOnUtc":"2021-08-06T06:28:28.5858959Z"}]', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[TOrder] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OriginalOrderId], [ChannelId], [OrderNumber], [OrderOnUtc], [ChannelType], [Type], [DeliveryMethod], [ReferralCode], [CustomerType], [Customer], [Currency], [SubTotal], [TotalCartDiscount], [GrossSavings], [ShippingFee], [TotalAmountDue], [TotalAmountPaid], [BalanceAmountDue], [TotalTaxAmount], [Status], [CancelledReason], [LastStatusUpdatedOnUtc], [ReturnAndExchangeOrders], [Comments], [StatusChangeLogs], [PickUpChannelId], [Base_BalanceAmountDue], [Base_TotalAmountDue], [Base_TotalAmountPaid], [ExchangeRate], [Base_TotalTaxAmount], [ShippingServiceLevel], [OrderInstructions], [PosStatus]) VALUES (4641, NULL, CAST(N'2021-07-29T19:20:00.0000000' AS DateTime2), NULL, CAST(N'2021-08-11T01:05:44.4074299' AS DateTime2), NULL, NULL, 1579, N'YSGSG_BVSG_20210806-0000002', CAST(N'2021-07-29T11:20:00.0000000' AS DateTime2), N'Marketplace', N'SaleOrder', N'HomeDelivery', NULL, 0, N'Dev Steven', N'SGD', CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), N'Paid', NULL, NULL, N'[]', N'[]', N'[{"Status":2,"UpdatedBy":null,"UpdatedOnUtc":"2021-08-06T06:28:36.2702019Z"}]', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[TOrder] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OriginalOrderId], [ChannelId], [OrderNumber], [OrderOnUtc], [ChannelType], [Type], [DeliveryMethod], [ReferralCode], [CustomerType], [Customer], [Currency], [SubTotal], [TotalCartDiscount], [GrossSavings], [ShippingFee], [TotalAmountDue], [TotalAmountPaid], [BalanceAmountDue], [TotalTaxAmount], [Status], [CancelledReason], [LastStatusUpdatedOnUtc], [ReturnAndExchangeOrders], [Comments], [StatusChangeLogs], [PickUpChannelId], [Base_BalanceAmountDue], [Base_TotalAmountDue], [Base_TotalAmountPaid], [ExchangeRate], [Base_TotalTaxAmount], [ShippingServiceLevel], [OrderInstructions], [PosStatus]) VALUES (4642, NULL, CAST(N'2021-07-29T19:20:00.0000000' AS DateTime2), NULL, CAST(N'2021-08-11T01:05:44.4074411' AS DateTime2), NULL, NULL, 1579, N'YSGSG_BVSG_20210806-0000003', CAST(N'2021-07-29T11:20:00.0000000' AS DateTime2), N'Marketplace', N'SaleOrder', N'HomeDelivery', NULL, 0, N'Dev Steven', N'SGD', CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), N'Paid', NULL, NULL, N'[]', N'[]', N'[{"Status":2,"UpdatedBy":null,"UpdatedOnUtc":"2021-08-06T06:29:19.3642059Z"}]', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[TOrder] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OriginalOrderId], [ChannelId], [OrderNumber], [OrderOnUtc], [ChannelType], [Type], [DeliveryMethod], [ReferralCode], [CustomerType], [Customer], [Currency], [SubTotal], [TotalCartDiscount], [GrossSavings], [ShippingFee], [TotalAmountDue], [TotalAmountPaid], [BalanceAmountDue], [TotalTaxAmount], [Status], [CancelledReason], [LastStatusUpdatedOnUtc], [ReturnAndExchangeOrders], [Comments], [StatusChangeLogs], [PickUpChannelId], [Base_BalanceAmountDue], [Base_TotalAmountDue], [Base_TotalAmountPaid], [ExchangeRate], [Base_TotalTaxAmount], [ShippingServiceLevel], [OrderInstructions], [PosStatus]) VALUES (4643, NULL, CAST(N'2021-07-29T19:20:00.0000000' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:23.1461887' AS DateTime2), NULL, NULL, 1579, N'YSGSG_BVSG_20210806-0000004', CAST(N'2021-07-29T11:20:00.0000000' AS DateTime2), N'Marketplace', N'SaleOrder', N'HomeDelivery', NULL, 0, N'Dev Steven', N'SGD', CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), N'Paid', NULL, NULL, N'[]', N'[]', N'[{"Status":2,"UpdatedBy":null,"UpdatedOnUtc":"2021-08-06T06:29:23.1397156Z"}]', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[TOrder] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OriginalOrderId], [ChannelId], [OrderNumber], [OrderOnUtc], [ChannelType], [Type], [DeliveryMethod], [ReferralCode], [CustomerType], [Customer], [Currency], [SubTotal], [TotalCartDiscount], [GrossSavings], [ShippingFee], [TotalAmountDue], [TotalAmountPaid], [BalanceAmountDue], [TotalTaxAmount], [Status], [CancelledReason], [LastStatusUpdatedOnUtc], [ReturnAndExchangeOrders], [Comments], [StatusChangeLogs], [PickUpChannelId], [Base_BalanceAmountDue], [Base_TotalAmountDue], [Base_TotalAmountPaid], [ExchangeRate], [Base_TotalTaxAmount], [ShippingServiceLevel], [OrderInstructions], [PosStatus]) VALUES (4644, NULL, CAST(N'2021-07-29T19:20:00.0000000' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:26.7261583' AS DateTime2), NULL, NULL, 1579, N'YSGSG_BVSG_20210806-0000005', CAST(N'2021-07-29T11:20:00.0000000' AS DateTime2), N'Marketplace', N'SaleOrder', N'HomeDelivery', NULL, 0, N'Dev Steven', N'SGD', CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), N'Paid', NULL, NULL, N'[]', N'[]', N'[{"Status":2,"UpdatedBy":null,"UpdatedOnUtc":"2021-08-06T06:29:26.7210511Z"}]', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[TOrder] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OriginalOrderId], [ChannelId], [OrderNumber], [OrderOnUtc], [ChannelType], [Type], [DeliveryMethod], [ReferralCode], [CustomerType], [Customer], [Currency], [SubTotal], [TotalCartDiscount], [GrossSavings], [ShippingFee], [TotalAmountDue], [TotalAmountPaid], [BalanceAmountDue], [TotalTaxAmount], [Status], [CancelledReason], [LastStatusUpdatedOnUtc], [ReturnAndExchangeOrders], [Comments], [StatusChangeLogs], [PickUpChannelId], [Base_BalanceAmountDue], [Base_TotalAmountDue], [Base_TotalAmountPaid], [ExchangeRate], [Base_TotalTaxAmount], [ShippingServiceLevel], [OrderInstructions], [PosStatus]) VALUES (4645, NULL, CAST(N'2021-07-29T19:20:00.0000000' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:30.2020155' AS DateTime2), NULL, NULL, 1579, N'YSGSG_BVSG_20210806-0000006', CAST(N'2021-07-29T11:20:00.0000000' AS DateTime2), N'Marketplace', N'SaleOrder', N'HomeDelivery', NULL, 0, N'Dev Steven', N'SGD', CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), N'Paid', NULL, NULL, N'[]', N'[]', N'[{"Status":2,"UpdatedBy":null,"UpdatedOnUtc":"2021-08-06T06:29:30.1974765Z"}]', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[TOrder] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OriginalOrderId], [ChannelId], [OrderNumber], [OrderOnUtc], [ChannelType], [Type], [DeliveryMethod], [ReferralCode], [CustomerType], [Customer], [Currency], [SubTotal], [TotalCartDiscount], [GrossSavings], [ShippingFee], [TotalAmountDue], [TotalAmountPaid], [BalanceAmountDue], [TotalTaxAmount], [Status], [CancelledReason], [LastStatusUpdatedOnUtc], [ReturnAndExchangeOrders], [Comments], [StatusChangeLogs], [PickUpChannelId], [Base_BalanceAmountDue], [Base_TotalAmountDue], [Base_TotalAmountPaid], [ExchangeRate], [Base_TotalTaxAmount], [ShippingServiceLevel], [OrderInstructions], [PosStatus]) VALUES (4646, NULL, CAST(N'2021-07-29T19:20:00.0000000' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:33.8629331' AS DateTime2), NULL, NULL, 1579, N'YSGSG_BVSG_20210806-0000007', CAST(N'2021-07-29T11:20:00.0000000' AS DateTime2), N'Marketplace', N'SaleOrder', N'HomeDelivery', NULL, 0, N'Dev Steven', N'SGD', CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), N'Paid', NULL, NULL, N'[]', N'[]', N'[{"Status":2,"UpdatedBy":null,"UpdatedOnUtc":"2021-08-06T06:29:33.8542211Z"}]', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[TOrder] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OriginalOrderId], [ChannelId], [OrderNumber], [OrderOnUtc], [ChannelType], [Type], [DeliveryMethod], [ReferralCode], [CustomerType], [Customer], [Currency], [SubTotal], [TotalCartDiscount], [GrossSavings], [ShippingFee], [TotalAmountDue], [TotalAmountPaid], [BalanceAmountDue], [TotalTaxAmount], [Status], [CancelledReason], [LastStatusUpdatedOnUtc], [ReturnAndExchangeOrders], [Comments], [StatusChangeLogs], [PickUpChannelId], [Base_BalanceAmountDue], [Base_TotalAmountDue], [Base_TotalAmountPaid], [ExchangeRate], [Base_TotalTaxAmount], [ShippingServiceLevel], [OrderInstructions], [PosStatus]) VALUES (4647, NULL, CAST(N'2021-07-29T19:20:00.0000000' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:38.1753230' AS DateTime2), NULL, NULL, 1579, N'YSGSG_BVSG_20210806-0000008', CAST(N'2021-07-29T11:20:00.0000000' AS DateTime2), N'Marketplace', N'SaleOrder', N'HomeDelivery', NULL, 0, N'Dev Steven', N'SGD', CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), N'Paid', NULL, NULL, N'[]', N'[]', N'[{"Status":2,"UpdatedBy":null,"UpdatedOnUtc":"2021-08-06T06:29:38.1704147Z"}]', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[TOrder] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OriginalOrderId], [ChannelId], [OrderNumber], [OrderOnUtc], [ChannelType], [Type], [DeliveryMethod], [ReferralCode], [CustomerType], [Customer], [Currency], [SubTotal], [TotalCartDiscount], [GrossSavings], [ShippingFee], [TotalAmountDue], [TotalAmountPaid], [BalanceAmountDue], [TotalTaxAmount], [Status], [CancelledReason], [LastStatusUpdatedOnUtc], [ReturnAndExchangeOrders], [Comments], [StatusChangeLogs], [PickUpChannelId], [Base_BalanceAmountDue], [Base_TotalAmountDue], [Base_TotalAmountPaid], [ExchangeRate], [Base_TotalTaxAmount], [ShippingServiceLevel], [OrderInstructions], [PosStatus]) VALUES (4648, NULL, CAST(N'2021-07-29T19:20:00.0000000' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:41.5572872' AS DateTime2), NULL, NULL, 1579, N'YSGSG_BVSG_20210806-0000009', CAST(N'2021-07-29T11:20:00.0000000' AS DateTime2), N'Marketplace', N'SaleOrder', N'HomeDelivery', NULL, 0, N'Dev Steven', N'SGD', CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), N'Paid', NULL, NULL, N'[]', N'[]', N'[{"Status":2,"UpdatedBy":null,"UpdatedOnUtc":"2021-08-06T06:29:41.5511191Z"}]', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0)
INSERT [dbo].[TOrder] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OriginalOrderId], [ChannelId], [OrderNumber], [OrderOnUtc], [ChannelType], [Type], [DeliveryMethod], [ReferralCode], [CustomerType], [Customer], [Currency], [SubTotal], [TotalCartDiscount], [GrossSavings], [ShippingFee], [TotalAmountDue], [TotalAmountPaid], [BalanceAmountDue], [TotalTaxAmount], [Status], [CancelledReason], [LastStatusUpdatedOnUtc], [ReturnAndExchangeOrders], [Comments], [StatusChangeLogs], [PickUpChannelId], [Base_BalanceAmountDue], [Base_TotalAmountDue], [Base_TotalAmountPaid], [ExchangeRate], [Base_TotalTaxAmount], [ShippingServiceLevel], [OrderInstructions], [PosStatus]) VALUES (4649, NULL, CAST(N'2021-07-29T19:20:00.0000000' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:45.8861027' AS DateTime2), NULL, NULL, 1579, N'YSGSG_BVSG_20210806-0000010', CAST(N'2021-07-29T11:20:00.0000000' AS DateTime2), N'Marketplace', N'SaleOrder', N'HomeDelivery', NULL, 0, N'Dev Steven', N'SGD', CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), N'Paid', NULL, NULL, N'[]', N'[]', N'[{"Status":2,"UpdatedBy":null,"UpdatedOnUtc":"2021-08-06T06:29:45.8827414Z"}]', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[TOrder] OFF
GO
SET IDENTITY_INSERT [dbo].[TOrderCustomerInfo] ON 

INSERT [dbo].[TOrderCustomerInfo] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [Customer], [Name], [PhoneNumber], [Email], [Address], [Region], [PostCode], [Country]) VALUES (6776, NULL, CAST(N'2021-07-29T11:57:34.8399087' AS DateTime2), NULL, CAST(N'2021-07-29T11:57:34.8581728' AS DateTime2), NULL, 4638, N'Dev Steven', N'Dev Steven', N'12345678', NULL, N'8 Bulim Ave', N'SG', N'123456', N'SG')
INSERT [dbo].[TOrderCustomerInfo] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [Customer], [Name], [PhoneNumber], [Email], [Address], [Region], [PostCode], [Country]) VALUES (6777, NULL, CAST(N'2021-08-06T06:28:15.6405321' AS DateTime2), NULL, CAST(N'2021-08-06T06:28:15.6571831' AS DateTime2), NULL, 4639, N'Dev Steven', N'Dev Steven', N'12345678', NULL, N'8 Bulim Ave', N'SG', N'123456', N'SG')
INSERT [dbo].[TOrderCustomerInfo] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [Customer], [Name], [PhoneNumber], [Email], [Address], [Region], [PostCode], [Country]) VALUES (6778, NULL, CAST(N'2021-08-06T06:28:28.5891991' AS DateTime2), NULL, CAST(N'2021-08-06T06:28:28.5910145' AS DateTime2), NULL, 4640, N'Dev Steven', N'Dev Steven', N'12345678', NULL, N'8 Bulim Ave', N'SG', N'123456', N'SG')
INSERT [dbo].[TOrderCustomerInfo] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [Customer], [Name], [PhoneNumber], [Email], [Address], [Region], [PostCode], [Country]) VALUES (6779, NULL, CAST(N'2021-08-06T06:28:36.2728370' AS DateTime2), NULL, CAST(N'2021-08-06T06:28:36.2742203' AS DateTime2), NULL, 4641, N'Dev Steven', N'Dev Steven', N'12345678', NULL, N'8 Bulim Ave', N'SG', N'123456', N'SG')
INSERT [dbo].[TOrderCustomerInfo] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [Customer], [Name], [PhoneNumber], [Email], [Address], [Region], [PostCode], [Country]) VALUES (6780, NULL, CAST(N'2021-08-06T06:29:19.3665273' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:19.3673270' AS DateTime2), NULL, 4642, N'Dev Steven', N'Dev Steven', N'12345678', NULL, N'8 Bulim Ave', N'SG', N'123456', N'SG')
INSERT [dbo].[TOrderCustomerInfo] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [Customer], [Name], [PhoneNumber], [Email], [Address], [Region], [PostCode], [Country]) VALUES (6781, NULL, CAST(N'2021-08-06T06:29:23.1445394' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:23.1462111' AS DateTime2), NULL, 4643, N'Dev Steven', N'Dev Steven', N'12345678', NULL, N'8 Bulim Ave', N'SG', N'123456', N'SG')
INSERT [dbo].[TOrderCustomerInfo] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [Customer], [Name], [PhoneNumber], [Email], [Address], [Region], [PostCode], [Country]) VALUES (6782, NULL, CAST(N'2021-08-06T06:29:26.7248848' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:26.7261802' AS DateTime2), NULL, 4644, N'Dev Steven', N'Dev Steven', N'12345678', NULL, N'8 Bulim Ave', N'SG', N'123456', N'SG')
INSERT [dbo].[TOrderCustomerInfo] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [Customer], [Name], [PhoneNumber], [Email], [Address], [Region], [PostCode], [Country]) VALUES (6783, NULL, CAST(N'2021-08-06T06:29:30.2001477' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:30.2020374' AS DateTime2), NULL, 4645, N'Dev Steven', N'Dev Steven', N'12345678', NULL, N'8 Bulim Ave', N'SG', N'123456', N'SG')
INSERT [dbo].[TOrderCustomerInfo] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [Customer], [Name], [PhoneNumber], [Email], [Address], [Region], [PostCode], [Country]) VALUES (6784, NULL, CAST(N'2021-08-06T06:29:33.8612816' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:33.8629529' AS DateTime2), NULL, 4646, N'Dev Steven', N'Dev Steven', N'12345678', NULL, N'8 Bulim Ave', N'SG', N'123456', N'SG')
INSERT [dbo].[TOrderCustomerInfo] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [Customer], [Name], [PhoneNumber], [Email], [Address], [Region], [PostCode], [Country]) VALUES (6785, NULL, CAST(N'2021-08-06T06:29:38.1740036' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:38.1753314' AS DateTime2), NULL, 4647, N'Dev Steven', N'Dev Steven', N'12345678', NULL, N'8 Bulim Ave', N'SG', N'123456', N'SG')
INSERT [dbo].[TOrderCustomerInfo] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [Customer], [Name], [PhoneNumber], [Email], [Address], [Region], [PostCode], [Country]) VALUES (6786, NULL, CAST(N'2021-08-06T06:29:41.5555981' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:41.5573051' AS DateTime2), NULL, 4648, N'Dev Steven', N'Dev Steven', N'12345678', NULL, N'8 Bulim Ave', N'SG', N'123456', N'SG')
INSERT [dbo].[TOrderCustomerInfo] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [Customer], [Name], [PhoneNumber], [Email], [Address], [Region], [PostCode], [Country]) VALUES (6787, NULL, CAST(N'2021-08-06T06:29:45.8852707' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:45.8861107' AS DateTime2), NULL, 4649, N'Dev Steven', N'Dev Steven', N'12345678', NULL, N'8 Bulim Ave', N'SG', N'123456', N'SG')
SET IDENTITY_INSERT [dbo].[TOrderCustomerInfo] OFF
GO
SET IDENTITY_INSERT [dbo].[TOrderItem] ON 

INSERT [dbo].[TOrderItem] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [ProductId], [Code], [Name], [SoldQuantity], [ShipQuantity], [ReturnQuantity], [UnitWeight], [UnitPrice], [LineDiscount], [TotalLineDiscount], [TotalPriceAfterLineDiscount], [TotalApportionedCartDiscount], [FinalLineAmount], [TaxAmount], [Remarks], [Status], [Base_FinalLineAmount], [IsBundled]) VALUES (6821, NULL, CAST(N'2021-07-29T11:57:34.8399313' AS DateTime2), NULL, CAST(N'2021-07-29T11:57:34.8581801' AS DateTime2), NULL, 4638, 7466, N'GGWP-S', N'GGWP-S', 6, 6, 0, CAST(0.00 AS Decimal(18, 2)), CAST(20.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), NULL, 2, CAST(120.0000 AS Decimal(18, 4)), 0)
INSERT [dbo].[TOrderItem] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [ProductId], [Code], [Name], [SoldQuantity], [ShipQuantity], [ReturnQuantity], [UnitWeight], [UnitPrice], [LineDiscount], [TotalLineDiscount], [TotalPriceAfterLineDiscount], [TotalApportionedCartDiscount], [FinalLineAmount], [TaxAmount], [Remarks], [Status], [Base_FinalLineAmount], [IsBundled]) VALUES (6822, NULL, CAST(N'2021-08-06T06:28:15.6405596' AS DateTime2), NULL, CAST(N'2021-08-06T06:28:15.6571912' AS DateTime2), NULL, 4639, 7466, N'GGWP-S', N'GGWP-S', 6, 6, 0, CAST(0.00 AS Decimal(18, 2)), CAST(20.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), NULL, 2, CAST(120.0000 AS Decimal(18, 4)), 0)
INSERT [dbo].[TOrderItem] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [ProductId], [Code], [Name], [SoldQuantity], [ShipQuantity], [ReturnQuantity], [UnitWeight], [UnitPrice], [LineDiscount], [TotalLineDiscount], [TotalPriceAfterLineDiscount], [TotalApportionedCartDiscount], [FinalLineAmount], [TaxAmount], [Remarks], [Status], [Base_FinalLineAmount], [IsBundled]) VALUES (6823, NULL, CAST(N'2021-08-06T06:28:28.5892139' AS DateTime2), NULL, CAST(N'2021-08-06T06:28:28.5910343' AS DateTime2), NULL, 4640, 7466, N'GGWP-S', N'GGWP-S', 6, 6, 0, CAST(0.00 AS Decimal(18, 2)), CAST(20.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), NULL, 2, CAST(120.0000 AS Decimal(18, 4)), 0)
INSERT [dbo].[TOrderItem] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [ProductId], [Code], [Name], [SoldQuantity], [ShipQuantity], [ReturnQuantity], [UnitWeight], [UnitPrice], [LineDiscount], [TotalLineDiscount], [TotalPriceAfterLineDiscount], [TotalApportionedCartDiscount], [FinalLineAmount], [TaxAmount], [Remarks], [Status], [Base_FinalLineAmount], [IsBundled]) VALUES (6824, NULL, CAST(N'2021-08-06T06:28:36.2728454' AS DateTime2), NULL, CAST(N'2021-08-06T06:28:36.2742299' AS DateTime2), NULL, 4641, 7466, N'GGWP-S', N'GGWP-S', 6, 6, 0, CAST(0.00 AS Decimal(18, 2)), CAST(20.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), NULL, 2, CAST(120.0000 AS Decimal(18, 4)), 0)
INSERT [dbo].[TOrderItem] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [ProductId], [Code], [Name], [SoldQuantity], [ShipQuantity], [ReturnQuantity], [UnitWeight], [UnitPrice], [LineDiscount], [TotalLineDiscount], [TotalPriceAfterLineDiscount], [TotalApportionedCartDiscount], [FinalLineAmount], [TaxAmount], [Remarks], [Status], [Base_FinalLineAmount], [IsBundled]) VALUES (6825, NULL, CAST(N'2021-08-06T06:29:19.3665367' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:19.3673341' AS DateTime2), NULL, 4642, 7466, N'GGWP-S', N'GGWP-S', 6, 6, 0, CAST(0.00 AS Decimal(18, 2)), CAST(20.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), NULL, 2, CAST(120.0000 AS Decimal(18, 4)), 0)
INSERT [dbo].[TOrderItem] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [ProductId], [Code], [Name], [SoldQuantity], [ShipQuantity], [ReturnQuantity], [UnitWeight], [UnitPrice], [LineDiscount], [TotalLineDiscount], [TotalPriceAfterLineDiscount], [TotalApportionedCartDiscount], [FinalLineAmount], [TaxAmount], [Remarks], [Status], [Base_FinalLineAmount], [IsBundled]) VALUES (6826, NULL, CAST(N'2021-08-06T06:29:23.1445635' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:23.1462290' AS DateTime2), NULL, 4643, 7466, N'GGWP-S', N'GGWP-S', 6, 6, 0, CAST(0.00 AS Decimal(18, 2)), CAST(20.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), NULL, 2, CAST(120.0000 AS Decimal(18, 4)), 0)
INSERT [dbo].[TOrderItem] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [ProductId], [Code], [Name], [SoldQuantity], [ShipQuantity], [ReturnQuantity], [UnitWeight], [UnitPrice], [LineDiscount], [TotalLineDiscount], [TotalPriceAfterLineDiscount], [TotalApportionedCartDiscount], [FinalLineAmount], [TaxAmount], [Remarks], [Status], [Base_FinalLineAmount], [IsBundled]) VALUES (6827, NULL, CAST(N'2021-08-06T06:29:26.7248946' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:26.7261945' AS DateTime2), NULL, 4644, 7466, N'GGWP-S', N'GGWP-S', 6, 6, 0, CAST(0.00 AS Decimal(18, 2)), CAST(20.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), NULL, 2, CAST(120.0000 AS Decimal(18, 4)), 0)
INSERT [dbo].[TOrderItem] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [ProductId], [Code], [Name], [SoldQuantity], [ShipQuantity], [ReturnQuantity], [UnitWeight], [UnitPrice], [LineDiscount], [TotalLineDiscount], [TotalPriceAfterLineDiscount], [TotalApportionedCartDiscount], [FinalLineAmount], [TaxAmount], [Remarks], [Status], [Base_FinalLineAmount], [IsBundled]) VALUES (6828, NULL, CAST(N'2021-08-06T06:29:30.2001683' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:30.2021747' AS DateTime2), NULL, 4645, 7466, N'GGWP-S', N'GGWP-S', 6, 6, 0, CAST(0.00 AS Decimal(18, 2)), CAST(20.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), NULL, 2, CAST(120.0000 AS Decimal(18, 4)), 0)
INSERT [dbo].[TOrderItem] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [ProductId], [Code], [Name], [SoldQuantity], [ShipQuantity], [ReturnQuantity], [UnitWeight], [UnitPrice], [LineDiscount], [TotalLineDiscount], [TotalPriceAfterLineDiscount], [TotalApportionedCartDiscount], [FinalLineAmount], [TaxAmount], [Remarks], [Status], [Base_FinalLineAmount], [IsBundled]) VALUES (6829, NULL, CAST(N'2021-08-06T06:29:33.8612996' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:33.8629702' AS DateTime2), NULL, 4646, 7466, N'GGWP-S', N'GGWP-S', 6, 6, 0, CAST(0.00 AS Decimal(18, 2)), CAST(20.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), NULL, 2, CAST(120.0000 AS Decimal(18, 4)), 0)
INSERT [dbo].[TOrderItem] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [ProductId], [Code], [Name], [SoldQuantity], [ShipQuantity], [ReturnQuantity], [UnitWeight], [UnitPrice], [LineDiscount], [TotalLineDiscount], [TotalPriceAfterLineDiscount], [TotalApportionedCartDiscount], [FinalLineAmount], [TaxAmount], [Remarks], [Status], [Base_FinalLineAmount], [IsBundled]) VALUES (6830, NULL, CAST(N'2021-08-06T06:29:38.1740224' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:38.1753385' AS DateTime2), NULL, 4647, 7466, N'GGWP-S', N'GGWP-S', 6, 6, 0, CAST(0.00 AS Decimal(18, 2)), CAST(20.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), NULL, 2, CAST(120.0000 AS Decimal(18, 4)), 0)
INSERT [dbo].[TOrderItem] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [ProductId], [Code], [Name], [SoldQuantity], [ShipQuantity], [ReturnQuantity], [UnitWeight], [UnitPrice], [LineDiscount], [TotalLineDiscount], [TotalPriceAfterLineDiscount], [TotalApportionedCartDiscount], [FinalLineAmount], [TaxAmount], [Remarks], [Status], [Base_FinalLineAmount], [IsBundled]) VALUES (6831, NULL, CAST(N'2021-08-06T06:29:41.5556152' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:41.5573206' AS DateTime2), NULL, 4648, 7466, N'GGWP-S', N'GGWP-S', 6, 6, 0, CAST(0.00 AS Decimal(18, 2)), CAST(20.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), NULL, 2, CAST(120.0000 AS Decimal(18, 4)), 0)
INSERT [dbo].[TOrderItem] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [ProductId], [Code], [Name], [SoldQuantity], [ShipQuantity], [ReturnQuantity], [UnitWeight], [UnitPrice], [LineDiscount], [TotalLineDiscount], [TotalPriceAfterLineDiscount], [TotalApportionedCartDiscount], [FinalLineAmount], [TaxAmount], [Remarks], [Status], [Base_FinalLineAmount], [IsBundled]) VALUES (6832, NULL, CAST(N'2021-08-06T06:29:45.8852785' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:45.8861178' AS DateTime2), NULL, 4649, 7466, N'GGWP-S', N'GGWP-S', 6, 6, 0, CAST(0.00 AS Decimal(18, 2)), CAST(20.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), CAST(120.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), NULL, 2, CAST(120.0000 AS Decimal(18, 4)), 0)
SET IDENTITY_INSERT [dbo].[TOrderItem] OFF
GO
SET IDENTITY_INSERT [dbo].[TOrderLog] ON 

INSERT [dbo].[TOrderLog] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [Action], [Before], [After]) VALUES (1292, NULL, CAST(N'2021-07-29T11:57:35.3482088' AS DateTime2), NULL, CAST(N'2021-07-29T11:57:35.3501860' AS DateTime2), NULL, 4638, N'ADD', NULL, N'{"OriginalOrderId":null,"ChannelId":1579,"PickUpChannelId":null,"OrderNumber":"YSGSG_BVSG_20210729-0000000","OrderOnUtc":"2021-07-29T11:20:00Z","ChannelType":"Marketplace","Type":0,"DeliveryMethod":1,"ReturnAndExchangeOrders":[],"OrderInstructions":null,"ReferralCode":null,"CustomerType":0,"Customer":"Dev Steven","Currency":"SGD","ExchangeRate":null,"SubTotal":120.00,"TotalCartDiscount":0.00,"GrossSavings":0.0,"ShippingFee":0.00,"TotalAmountDue":120.00,"TotalAmountPaid":120.00,"BalanceAmountDue":120.00,"TotalTaxAmount":0.00,"Base_TotalAmountDue":null,"Base_TotalAmountPaid":null,"Base_BalanceAmountDue":null,"Base_TotalTaxAmount":null,"Comments":[],"StatusChangeLogs":[{"Status":2,"UpdatedBy":null,"UpdatedOnUtc":"2021-07-29T11:57:34.0958843Z"}],"Status":2,"CancelledReason":null,"LastStatusUpdatedOnUtc":null,"ShippingServiceLevel":null,"CreatedBy":null,"CreatedOnUtc":"2021-07-29T19:20:00+08:00","Extra":null,"Id":4638,"LastUpdatedBy":null,"LastUpdatedOnUtc":"2021-07-29T11:57:34.8581644Z","Timestamp":"AAAAAAAAJyk="}')
INSERT [dbo].[TOrderLog] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [Action], [Before], [After]) VALUES (1293, NULL, CAST(N'2021-08-06T06:28:16.3210311' AS DateTime2), NULL, CAST(N'2021-08-06T06:28:16.3238177' AS DateTime2), NULL, 4639, N'ADD', NULL, N'{"OriginalOrderId":null,"ChannelId":1579,"PickUpChannelId":null,"OrderNumber":"YSGSG_BVSG_20210896-0000000","OrderOnUtc":"2021-07-29T11:20:00Z","ChannelType":"Marketplace","Type":0,"DeliveryMethod":1,"ReturnAndExchangeOrders":[],"OrderInstructions":null,"ReferralCode":null,"CustomerType":0,"Customer":"Dev Steven","Currency":"SGD","ExchangeRate":null,"SubTotal":120.00,"TotalCartDiscount":0.00,"GrossSavings":0.0,"ShippingFee":0.00,"TotalAmountDue":120.00,"TotalAmountPaid":120.00,"BalanceAmountDue":120.00,"TotalTaxAmount":0.00,"Base_TotalAmountDue":null,"Base_TotalAmountPaid":null,"Base_BalanceAmountDue":null,"Base_TotalTaxAmount":null,"Comments":[],"StatusChangeLogs":[{"Status":2,"UpdatedBy":null,"UpdatedOnUtc":"2021-08-06T06:28:14.9877775Z"}],"Status":2,"CancelledReason":null,"LastStatusUpdatedOnUtc":null,"ShippingServiceLevel":null,"CreatedBy":null,"CreatedOnUtc":"2021-07-29T19:20:00+08:00","Extra":null,"Id":4639,"LastUpdatedBy":null,"LastUpdatedOnUtc":"2021-08-06T06:28:15.6571738Z","Timestamp":"AAAAAAAARlE="}')
INSERT [dbo].[TOrderLog] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [Action], [Before], [After]) VALUES (1294, NULL, CAST(N'2021-08-06T06:28:28.6290612' AS DateTime2), NULL, CAST(N'2021-08-06T06:28:28.6293351' AS DateTime2), NULL, 4640, N'ADD', NULL, N'{"OriginalOrderId":null,"ChannelId":1579,"PickUpChannelId":null,"OrderNumber":"YSGSG_BVSG_20210806-0000000","OrderOnUtc":"2021-07-29T11:20:00Z","ChannelType":"Marketplace","Type":0,"DeliveryMethod":1,"ReturnAndExchangeOrders":[],"OrderInstructions":null,"ReferralCode":null,"CustomerType":0,"Customer":"Dev Steven","Currency":"SGD","ExchangeRate":null,"SubTotal":120.00,"TotalCartDiscount":0.00,"GrossSavings":0.0,"ShippingFee":0.00,"TotalAmountDue":120.00,"TotalAmountPaid":120.00,"BalanceAmountDue":120.00,"TotalTaxAmount":0.00,"Base_TotalAmountDue":null,"Base_TotalAmountPaid":null,"Base_BalanceAmountDue":null,"Base_TotalTaxAmount":null,"Comments":[],"StatusChangeLogs":[{"Status":2,"UpdatedBy":null,"UpdatedOnUtc":"2021-08-06T06:28:28.5858959Z"}],"Status":2,"CancelledReason":null,"LastStatusUpdatedOnUtc":null,"ShippingServiceLevel":null,"CreatedBy":null,"CreatedOnUtc":"2021-07-29T19:20:00+08:00","Extra":null,"Id":4640,"LastUpdatedBy":null,"LastUpdatedOnUtc":"2021-08-06T06:28:28.5909934Z","Timestamp":"AAAAAAAARl4="}')
INSERT [dbo].[TOrderLog] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [Action], [Before], [After]) VALUES (1295, NULL, CAST(N'2021-08-06T06:28:36.3005996' AS DateTime2), NULL, CAST(N'2021-08-06T06:28:36.3009006' AS DateTime2), NULL, 4641, N'ADD', NULL, N'{"OriginalOrderId":null,"ChannelId":1579,"PickUpChannelId":null,"OrderNumber":"YSGSG_BVSG_20210806-0000002","OrderOnUtc":"2021-07-29T11:20:00Z","ChannelType":"Marketplace","Type":0,"DeliveryMethod":1,"ReturnAndExchangeOrders":[],"OrderInstructions":null,"ReferralCode":null,"CustomerType":0,"Customer":"Dev Steven","Currency":"SGD","ExchangeRate":null,"SubTotal":120.00,"TotalCartDiscount":0.00,"GrossSavings":0.0,"ShippingFee":0.00,"TotalAmountDue":120.00,"TotalAmountPaid":120.00,"BalanceAmountDue":120.00,"TotalTaxAmount":0.00,"Base_TotalAmountDue":null,"Base_TotalAmountPaid":null,"Base_BalanceAmountDue":null,"Base_TotalTaxAmount":null,"Comments":[],"StatusChangeLogs":[{"Status":2,"UpdatedBy":null,"UpdatedOnUtc":"2021-08-06T06:28:36.2702019Z"}],"Status":2,"CancelledReason":null,"LastStatusUpdatedOnUtc":null,"ShippingServiceLevel":null,"CreatedBy":null,"CreatedOnUtc":"2021-07-29T19:20:00+08:00","Extra":null,"Id":4641,"LastUpdatedBy":null,"LastUpdatedOnUtc":"2021-08-06T06:28:36.2742103Z","Timestamp":"AAAAAAAARms="}')
INSERT [dbo].[TOrderLog] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [Action], [Before], [After]) VALUES (1296, NULL, CAST(N'2021-08-06T06:29:19.4393069' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:19.4397984' AS DateTime2), NULL, 4642, N'ADD', NULL, N'{"OriginalOrderId":null,"ChannelId":1579,"PickUpChannelId":null,"OrderNumber":"YSGSG_BVSG_20210806-0000003","OrderOnUtc":"2021-07-29T11:20:00Z","ChannelType":"Marketplace","Type":0,"DeliveryMethod":1,"ReturnAndExchangeOrders":[],"OrderInstructions":null,"ReferralCode":null,"CustomerType":0,"Customer":"Dev Steven","Currency":"SGD","ExchangeRate":null,"SubTotal":120.00,"TotalCartDiscount":0.00,"GrossSavings":0.0,"ShippingFee":0.00,"TotalAmountDue":120.00,"TotalAmountPaid":120.00,"BalanceAmountDue":120.00,"TotalTaxAmount":0.00,"Base_TotalAmountDue":null,"Base_TotalAmountPaid":null,"Base_BalanceAmountDue":null,"Base_TotalTaxAmount":null,"Comments":[],"StatusChangeLogs":[{"Status":2,"UpdatedBy":null,"UpdatedOnUtc":"2021-08-06T06:29:19.3642059Z"}],"Status":2,"CancelledReason":null,"LastStatusUpdatedOnUtc":null,"ShippingServiceLevel":null,"CreatedBy":null,"CreatedOnUtc":"2021-07-29T19:20:00+08:00","Extra":null,"Id":4642,"LastUpdatedBy":null,"LastUpdatedOnUtc":"2021-08-06T06:29:19.367319Z","Timestamp":"AAAAAAAARng="}')
INSERT [dbo].[TOrderLog] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [Action], [Before], [After]) VALUES (1297, NULL, CAST(N'2021-08-06T06:29:23.1785656' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:23.1788111' AS DateTime2), NULL, 4643, N'ADD', NULL, N'{"OriginalOrderId":null,"ChannelId":1579,"PickUpChannelId":null,"OrderNumber":"YSGSG_BVSG_20210806-0000004","OrderOnUtc":"2021-07-29T11:20:00Z","ChannelType":"Marketplace","Type":0,"DeliveryMethod":1,"ReturnAndExchangeOrders":[],"OrderInstructions":null,"ReferralCode":null,"CustomerType":0,"Customer":"Dev Steven","Currency":"SGD","ExchangeRate":null,"SubTotal":120.00,"TotalCartDiscount":0.00,"GrossSavings":0.0,"ShippingFee":0.00,"TotalAmountDue":120.00,"TotalAmountPaid":120.00,"BalanceAmountDue":120.00,"TotalTaxAmount":0.00,"Base_TotalAmountDue":null,"Base_TotalAmountPaid":null,"Base_BalanceAmountDue":null,"Base_TotalTaxAmount":null,"Comments":[],"StatusChangeLogs":[{"Status":2,"UpdatedBy":null,"UpdatedOnUtc":"2021-08-06T06:29:23.1397156Z"}],"Status":2,"CancelledReason":null,"LastStatusUpdatedOnUtc":null,"ShippingServiceLevel":null,"CreatedBy":null,"CreatedOnUtc":"2021-07-29T19:20:00+08:00","Extra":null,"Id":4643,"LastUpdatedBy":null,"LastUpdatedOnUtc":"2021-08-06T06:29:23.1461887Z","Timestamp":"AAAAAAAARoU="}')
INSERT [dbo].[TOrderLog] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [Action], [Before], [After]) VALUES (1298, NULL, CAST(N'2021-08-06T06:29:26.7530313' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:26.7532784' AS DateTime2), NULL, 4644, N'ADD', NULL, N'{"OriginalOrderId":null,"ChannelId":1579,"PickUpChannelId":null,"OrderNumber":"YSGSG_BVSG_20210806-0000005","OrderOnUtc":"2021-07-29T11:20:00Z","ChannelType":"Marketplace","Type":0,"DeliveryMethod":1,"ReturnAndExchangeOrders":[],"OrderInstructions":null,"ReferralCode":null,"CustomerType":0,"Customer":"Dev Steven","Currency":"SGD","ExchangeRate":null,"SubTotal":120.00,"TotalCartDiscount":0.00,"GrossSavings":0.0,"ShippingFee":0.00,"TotalAmountDue":120.00,"TotalAmountPaid":120.00,"BalanceAmountDue":120.00,"TotalTaxAmount":0.00,"Base_TotalAmountDue":null,"Base_TotalAmountPaid":null,"Base_BalanceAmountDue":null,"Base_TotalTaxAmount":null,"Comments":[],"StatusChangeLogs":[{"Status":2,"UpdatedBy":null,"UpdatedOnUtc":"2021-08-06T06:29:26.7210511Z"}],"Status":2,"CancelledReason":null,"LastStatusUpdatedOnUtc":null,"ShippingServiceLevel":null,"CreatedBy":null,"CreatedOnUtc":"2021-07-29T19:20:00+08:00","Extra":null,"Id":4644,"LastUpdatedBy":null,"LastUpdatedOnUtc":"2021-08-06T06:29:26.7261583Z","Timestamp":"AAAAAAAARpI="}')
INSERT [dbo].[TOrderLog] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [Action], [Before], [After]) VALUES (1299, NULL, CAST(N'2021-08-06T06:29:30.2350639' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:30.2354927' AS DateTime2), NULL, 4645, N'ADD', NULL, N'{"OriginalOrderId":null,"ChannelId":1579,"PickUpChannelId":null,"OrderNumber":"YSGSG_BVSG_20210806-0000006","OrderOnUtc":"2021-07-29T11:20:00Z","ChannelType":"Marketplace","Type":0,"DeliveryMethod":1,"ReturnAndExchangeOrders":[],"OrderInstructions":null,"ReferralCode":null,"CustomerType":0,"Customer":"Dev Steven","Currency":"SGD","ExchangeRate":null,"SubTotal":120.00,"TotalCartDiscount":0.00,"GrossSavings":0.0,"ShippingFee":0.00,"TotalAmountDue":120.00,"TotalAmountPaid":120.00,"BalanceAmountDue":120.00,"TotalTaxAmount":0.00,"Base_TotalAmountDue":null,"Base_TotalAmountPaid":null,"Base_BalanceAmountDue":null,"Base_TotalTaxAmount":null,"Comments":[],"StatusChangeLogs":[{"Status":2,"UpdatedBy":null,"UpdatedOnUtc":"2021-08-06T06:29:30.1974765Z"}],"Status":2,"CancelledReason":null,"LastStatusUpdatedOnUtc":null,"ShippingServiceLevel":null,"CreatedBy":null,"CreatedOnUtc":"2021-07-29T19:20:00+08:00","Extra":null,"Id":4645,"LastUpdatedBy":null,"LastUpdatedOnUtc":"2021-08-06T06:29:30.2020155Z","Timestamp":"AAAAAAAARp8="}')
INSERT [dbo].[TOrderLog] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [Action], [Before], [After]) VALUES (1300, NULL, CAST(N'2021-08-06T06:29:33.8912958' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:33.8915714' AS DateTime2), NULL, 4646, N'ADD', NULL, N'{"OriginalOrderId":null,"ChannelId":1579,"PickUpChannelId":null,"OrderNumber":"YSGSG_BVSG_20210806-0000007","OrderOnUtc":"2021-07-29T11:20:00Z","ChannelType":"Marketplace","Type":0,"DeliveryMethod":1,"ReturnAndExchangeOrders":[],"OrderInstructions":null,"ReferralCode":null,"CustomerType":0,"Customer":"Dev Steven","Currency":"SGD","ExchangeRate":null,"SubTotal":120.00,"TotalCartDiscount":0.00,"GrossSavings":0.0,"ShippingFee":0.00,"TotalAmountDue":120.00,"TotalAmountPaid":120.00,"BalanceAmountDue":120.00,"TotalTaxAmount":0.00,"Base_TotalAmountDue":null,"Base_TotalAmountPaid":null,"Base_BalanceAmountDue":null,"Base_TotalTaxAmount":null,"Comments":[],"StatusChangeLogs":[{"Status":2,"UpdatedBy":null,"UpdatedOnUtc":"2021-08-06T06:29:33.8542211Z"}],"Status":2,"CancelledReason":null,"LastStatusUpdatedOnUtc":null,"ShippingServiceLevel":null,"CreatedBy":null,"CreatedOnUtc":"2021-07-29T19:20:00+08:00","Extra":null,"Id":4646,"LastUpdatedBy":null,"LastUpdatedOnUtc":"2021-08-06T06:29:33.8629331Z","Timestamp":"AAAAAAAARqw="}')
INSERT [dbo].[TOrderLog] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [Action], [Before], [After]) VALUES (1301, NULL, CAST(N'2021-08-06T06:29:38.1986419' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:38.1988843' AS DateTime2), NULL, 4647, N'ADD', NULL, N'{"OriginalOrderId":null,"ChannelId":1579,"PickUpChannelId":null,"OrderNumber":"YSGSG_BVSG_20210806-0000008","OrderOnUtc":"2021-07-29T11:20:00Z","ChannelType":"Marketplace","Type":0,"DeliveryMethod":1,"ReturnAndExchangeOrders":[],"OrderInstructions":null,"ReferralCode":null,"CustomerType":0,"Customer":"Dev Steven","Currency":"SGD","ExchangeRate":null,"SubTotal":120.00,"TotalCartDiscount":0.00,"GrossSavings":0.0,"ShippingFee":0.00,"TotalAmountDue":120.00,"TotalAmountPaid":120.00,"BalanceAmountDue":120.00,"TotalTaxAmount":0.00,"Base_TotalAmountDue":null,"Base_TotalAmountPaid":null,"Base_BalanceAmountDue":null,"Base_TotalTaxAmount":null,"Comments":[],"StatusChangeLogs":[{"Status":2,"UpdatedBy":null,"UpdatedOnUtc":"2021-08-06T06:29:38.1704147Z"}],"Status":2,"CancelledReason":null,"LastStatusUpdatedOnUtc":null,"ShippingServiceLevel":null,"CreatedBy":null,"CreatedOnUtc":"2021-07-29T19:20:00+08:00","Extra":null,"Id":4647,"LastUpdatedBy":null,"LastUpdatedOnUtc":"2021-08-06T06:29:38.175323Z","Timestamp":"AAAAAAAARrk="}')
INSERT [dbo].[TOrderLog] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [Action], [Before], [After]) VALUES (1302, NULL, CAST(N'2021-08-06T06:29:41.5808531' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:41.5810742' AS DateTime2), NULL, 4648, N'ADD', NULL, N'{"OriginalOrderId":null,"ChannelId":1579,"PickUpChannelId":null,"OrderNumber":"YSGSG_BVSG_20210806-0000009","OrderOnUtc":"2021-07-29T11:20:00Z","ChannelType":"Marketplace","Type":0,"DeliveryMethod":1,"ReturnAndExchangeOrders":[],"OrderInstructions":null,"ReferralCode":null,"CustomerType":0,"Customer":"Dev Steven","Currency":"SGD","ExchangeRate":null,"SubTotal":120.00,"TotalCartDiscount":0.00,"GrossSavings":0.0,"ShippingFee":0.00,"TotalAmountDue":120.00,"TotalAmountPaid":120.00,"BalanceAmountDue":120.00,"TotalTaxAmount":0.00,"Base_TotalAmountDue":null,"Base_TotalAmountPaid":null,"Base_BalanceAmountDue":null,"Base_TotalTaxAmount":null,"Comments":[],"StatusChangeLogs":[{"Status":2,"UpdatedBy":null,"UpdatedOnUtc":"2021-08-06T06:29:41.5511191Z"}],"Status":2,"CancelledReason":null,"LastStatusUpdatedOnUtc":null,"ShippingServiceLevel":null,"CreatedBy":null,"CreatedOnUtc":"2021-07-29T19:20:00+08:00","Extra":null,"Id":4648,"LastUpdatedBy":null,"LastUpdatedOnUtc":"2021-08-06T06:29:41.5572872Z","Timestamp":"AAAAAAAARsY="}')
INSERT [dbo].[TOrderLog] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [Action], [Before], [After]) VALUES (1303, NULL, CAST(N'2021-08-06T06:29:45.9196560' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:45.9199305' AS DateTime2), NULL, 4649, N'ADD', NULL, N'{"OriginalOrderId":null,"ChannelId":1579,"PickUpChannelId":null,"OrderNumber":"YSGSG_BVSG_20210806-0000010","OrderOnUtc":"2021-07-29T11:20:00Z","ChannelType":"Marketplace","Type":0,"DeliveryMethod":1,"ReturnAndExchangeOrders":[],"OrderInstructions":null,"ReferralCode":null,"CustomerType":0,"Customer":"Dev Steven","Currency":"SGD","ExchangeRate":null,"SubTotal":120.00,"TotalCartDiscount":0.00,"GrossSavings":0.0,"ShippingFee":0.00,"TotalAmountDue":120.00,"TotalAmountPaid":120.00,"BalanceAmountDue":120.00,"TotalTaxAmount":0.00,"Base_TotalAmountDue":null,"Base_TotalAmountPaid":null,"Base_BalanceAmountDue":null,"Base_TotalTaxAmount":null,"Comments":[],"StatusChangeLogs":[{"Status":2,"UpdatedBy":null,"UpdatedOnUtc":"2021-08-06T06:29:45.8827414Z"}],"Status":2,"CancelledReason":null,"LastStatusUpdatedOnUtc":null,"ShippingServiceLevel":null,"CreatedBy":null,"CreatedOnUtc":"2021-07-29T19:20:00+08:00","Extra":null,"Id":4649,"LastUpdatedBy":null,"LastUpdatedOnUtc":"2021-08-06T06:29:45.8861027Z","Timestamp":"AAAAAAAARtM="}')
SET IDENTITY_INSERT [dbo].[TOrderLog] OFF
GO
SET IDENTITY_INSERT [dbo].[TOrderPaymentInfo] ON 

INSERT [dbo].[TOrderPaymentInfo] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [Mode], [ReferenceNumber], [Amount], [Deleted], [Remarks]) VALUES (5160, NULL, CAST(N'2021-07-29T11:57:34.8399394' AS DateTime2), NULL, CAST(N'2021-07-29T11:57:34.8581871' AS DateTime2), NULL, 4638, N'MIXEDCARD', NULL, CAST(120.0000 AS Decimal(18, 4)), 0, NULL)
INSERT [dbo].[TOrderPaymentInfo] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [Mode], [ReferenceNumber], [Amount], [Deleted], [Remarks]) VALUES (5161, NULL, CAST(N'2021-08-06T06:28:15.6405698' AS DateTime2), NULL, CAST(N'2021-08-06T06:28:15.6572006' AS DateTime2), NULL, 4639, N'MIXEDCARD', NULL, CAST(120.0000 AS Decimal(18, 4)), 0, NULL)
INSERT [dbo].[TOrderPaymentInfo] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [Mode], [ReferenceNumber], [Amount], [Deleted], [Remarks]) VALUES (5162, NULL, CAST(N'2021-08-06T06:28:28.5892422' AS DateTime2), NULL, CAST(N'2021-08-06T06:28:28.5910545' AS DateTime2), NULL, 4640, N'MIXEDCARD', NULL, CAST(120.0000 AS Decimal(18, 4)), 0, NULL)
INSERT [dbo].[TOrderPaymentInfo] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [Mode], [ReferenceNumber], [Amount], [Deleted], [Remarks]) VALUES (5163, NULL, CAST(N'2021-08-06T06:28:36.2728528' AS DateTime2), NULL, CAST(N'2021-08-06T06:28:36.2742513' AS DateTime2), NULL, 4641, N'MIXEDCARD', NULL, CAST(120.0000 AS Decimal(18, 4)), 0, NULL)
INSERT [dbo].[TOrderPaymentInfo] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [Mode], [ReferenceNumber], [Amount], [Deleted], [Remarks]) VALUES (5164, NULL, CAST(N'2021-08-06T06:29:19.3665439' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:19.3673410' AS DateTime2), NULL, 4642, N'MIXEDCARD', NULL, CAST(120.0000 AS Decimal(18, 4)), 0, NULL)
INSERT [dbo].[TOrderPaymentInfo] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [Mode], [ReferenceNumber], [Amount], [Deleted], [Remarks]) VALUES (5165, NULL, CAST(N'2021-08-06T06:29:23.1445831' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:23.1462442' AS DateTime2), NULL, 4643, N'MIXEDCARD', NULL, CAST(120.0000 AS Decimal(18, 4)), 0, NULL)
INSERT [dbo].[TOrderPaymentInfo] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [Mode], [ReferenceNumber], [Amount], [Deleted], [Remarks]) VALUES (5166, NULL, CAST(N'2021-08-06T06:29:26.7249037' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:26.7262085' AS DateTime2), NULL, 4644, N'MIXEDCARD', NULL, CAST(120.0000 AS Decimal(18, 4)), 0, NULL)
INSERT [dbo].[TOrderPaymentInfo] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [Mode], [ReferenceNumber], [Amount], [Deleted], [Remarks]) VALUES (5167, NULL, CAST(N'2021-08-06T06:29:30.2001859' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:30.2022080' AS DateTime2), NULL, 4645, N'MIXEDCARD', NULL, CAST(120.0000 AS Decimal(18, 4)), 0, NULL)
INSERT [dbo].[TOrderPaymentInfo] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [Mode], [ReferenceNumber], [Amount], [Deleted], [Remarks]) VALUES (5168, NULL, CAST(N'2021-08-06T06:29:33.8613176' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:33.8629861' AS DateTime2), NULL, 4646, N'MIXEDCARD', NULL, CAST(120.0000 AS Decimal(18, 4)), 0, NULL)
INSERT [dbo].[TOrderPaymentInfo] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [Mode], [ReferenceNumber], [Amount], [Deleted], [Remarks]) VALUES (5169, NULL, CAST(N'2021-08-06T06:29:38.1741706' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:38.1753584' AS DateTime2), NULL, 4647, N'MIXEDCARD', NULL, CAST(120.0000 AS Decimal(18, 4)), 0, NULL)
INSERT [dbo].[TOrderPaymentInfo] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [Mode], [ReferenceNumber], [Amount], [Deleted], [Remarks]) VALUES (5170, NULL, CAST(N'2021-08-06T06:29:41.5556315' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:41.5573358' AS DateTime2), NULL, 4648, N'MIXEDCARD', NULL, CAST(120.0000 AS Decimal(18, 4)), 0, NULL)
INSERT [dbo].[TOrderPaymentInfo] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [Mode], [ReferenceNumber], [Amount], [Deleted], [Remarks]) VALUES (5171, NULL, CAST(N'2021-08-06T06:29:45.8852853' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:45.8861245' AS DateTime2), NULL, 4649, N'MIXEDCARD', NULL, CAST(120.0000 AS Decimal(18, 4)), 0, NULL)
SET IDENTITY_INSERT [dbo].[TOrderPaymentInfo] OFF
GO
SET IDENTITY_INSERT [dbo].[TOrderShipment] ON 

INSERT [dbo].[TOrderShipment] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [ShippingMethod], [RecipientName], [RecipientPhoneNumber], [DeliveryAddress], [Region], [PostCode], [Country], [PackageWeight], [PackageDimension], [ShippingLabel], [TrackingNumber], [ShippedOnUtc], [Status], [Items], [City], [CountryCode], [State]) VALUES (3551, NULL, CAST(N'2021-07-29T11:57:34.8399482' AS DateTime2), NULL, CAST(N'2021-07-29T11:57:37.9467055' AS DateTime2), NULL, 4638, N'Dropshipping', N'Dev Steven', N'123456789', N'8 Bulim Ave', N'SG', N'123456', N'SG', NULL, NULL, N'{}', N'YCHSG21072900331', NULL, 0, N'[{"ProductId":7466,"ReceivedOnUtc":null,"ReceivedQuantity":0,"ShipQuantity":6}]', NULL, NULL, NULL)
INSERT [dbo].[TOrderShipment] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [ShippingMethod], [RecipientName], [RecipientPhoneNumber], [DeliveryAddress], [Region], [PostCode], [Country], [PackageWeight], [PackageDimension], [ShippingLabel], [TrackingNumber], [ShippedOnUtc], [Status], [Items], [City], [CountryCode], [State]) VALUES (3552, NULL, CAST(N'2021-08-06T06:28:15.6405779' AS DateTime2), NULL, CAST(N'2021-08-06T06:28:18.7885870' AS DateTime2), NULL, 4639, N'Dropshipping', N'Dev Steven', N'123456789', N'8 Bulim Ave', N'SG', N'123456', N'SG', NULL, NULL, N'{}', N'YCHSG21080600341', NULL, 0, N'[{"ProductId":7466,"ReceivedOnUtc":null,"ReceivedQuantity":0,"ShipQuantity":6}]', NULL, NULL, NULL)
INSERT [dbo].[TOrderShipment] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [ShippingMethod], [RecipientName], [RecipientPhoneNumber], [DeliveryAddress], [Region], [PostCode], [Country], [PackageWeight], [PackageDimension], [ShippingLabel], [TrackingNumber], [ShippedOnUtc], [Status], [Items], [City], [CountryCode], [State]) VALUES (3553, NULL, CAST(N'2021-08-06T06:28:28.5892611' AS DateTime2), NULL, CAST(N'2021-08-06T06:28:29.5884232' AS DateTime2), NULL, 4640, N'Dropshipping', N'Dev Steven', N'123456789', N'8 Bulim Ave', N'SG', N'123456', N'SG', NULL, NULL, N'{}', N'YCHSG21080600342', NULL, 0, N'[{"ProductId":7466,"ReceivedOnUtc":null,"ReceivedQuantity":0,"ShipQuantity":6}]', NULL, NULL, NULL)
INSERT [dbo].[TOrderShipment] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [ShippingMethod], [RecipientName], [RecipientPhoneNumber], [DeliveryAddress], [Region], [PostCode], [Country], [PackageWeight], [PackageDimension], [ShippingLabel], [TrackingNumber], [ShippedOnUtc], [Status], [Items], [City], [CountryCode], [State]) VALUES (3554, NULL, CAST(N'2021-08-06T06:28:36.2728598' AS DateTime2), NULL, CAST(N'2021-08-06T06:28:37.0608824' AS DateTime2), NULL, 4641, N'Dropshipping', N'Dev Steven', N'123456789', N'8 Bulim Ave', N'SG', N'123456', N'SG', NULL, NULL, N'{}', N'YCHSG21080600343', NULL, 0, N'[{"ProductId":7466,"ReceivedOnUtc":null,"ReceivedQuantity":0,"ShipQuantity":6}]', NULL, NULL, NULL)
INSERT [dbo].[TOrderShipment] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [ShippingMethod], [RecipientName], [RecipientPhoneNumber], [DeliveryAddress], [Region], [PostCode], [Country], [PackageWeight], [PackageDimension], [ShippingLabel], [TrackingNumber], [ShippedOnUtc], [Status], [Items], [City], [CountryCode], [State]) VALUES (3555, NULL, CAST(N'2021-08-06T06:29:19.3665509' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:20.3611837' AS DateTime2), NULL, 4642, N'Dropshipping', N'Dev Steven', N'123456789', N'8 Bulim Ave', N'SG', N'123456', N'SG', NULL, NULL, N'{}', N'YCHSG21080600344', NULL, 0, N'[{"ProductId":7466,"ReceivedOnUtc":null,"ReceivedQuantity":0,"ShipQuantity":6}]', NULL, NULL, NULL)
INSERT [dbo].[TOrderShipment] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [ShippingMethod], [RecipientName], [RecipientPhoneNumber], [DeliveryAddress], [Region], [PostCode], [Country], [PackageWeight], [PackageDimension], [ShippingLabel], [TrackingNumber], [ShippedOnUtc], [Status], [Items], [City], [CountryCode], [State]) VALUES (3556, NULL, CAST(N'2021-08-06T06:29:23.1445996' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:23.8470756' AS DateTime2), NULL, 4643, N'Dropshipping', N'Dev Steven', N'123456789', N'8 Bulim Ave', N'SG', N'123456', N'SG', NULL, NULL, N'{}', N'YCHSG21080600345', NULL, 0, N'[{"ProductId":7466,"ReceivedOnUtc":null,"ReceivedQuantity":0,"ShipQuantity":6}]', NULL, NULL, NULL)
INSERT [dbo].[TOrderShipment] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [ShippingMethod], [RecipientName], [RecipientPhoneNumber], [DeliveryAddress], [Region], [PostCode], [Country], [PackageWeight], [PackageDimension], [ShippingLabel], [TrackingNumber], [ShippedOnUtc], [Status], [Items], [City], [CountryCode], [State]) VALUES (3557, NULL, CAST(N'2021-08-06T06:29:26.7249124' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:27.4543880' AS DateTime2), NULL, 4644, N'Dropshipping', N'Dev Steven', N'123456789', N'8 Bulim Ave', N'SG', N'123456', N'SG', NULL, NULL, N'{}', N'YCHSG21080600346', NULL, 0, N'[{"ProductId":7466,"ReceivedOnUtc":null,"ReceivedQuantity":0,"ShipQuantity":6}]', NULL, NULL, NULL)
INSERT [dbo].[TOrderShipment] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [ShippingMethod], [RecipientName], [RecipientPhoneNumber], [DeliveryAddress], [Region], [PostCode], [Country], [PackageWeight], [PackageDimension], [ShippingLabel], [TrackingNumber], [ShippedOnUtc], [Status], [Items], [City], [CountryCode], [State]) VALUES (3558, NULL, CAST(N'2021-08-06T06:29:30.2002034' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:31.0281334' AS DateTime2), NULL, 4645, N'Dropshipping', N'Dev Steven', N'123456789', N'8 Bulim Ave', N'SG', N'123456', N'SG', NULL, NULL, N'{}', N'YCHSG21080600347', NULL, 0, N'[{"ProductId":7466,"ReceivedOnUtc":null,"ReceivedQuantity":0,"ShipQuantity":6}]', NULL, NULL, NULL)
INSERT [dbo].[TOrderShipment] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [ShippingMethod], [RecipientName], [RecipientPhoneNumber], [DeliveryAddress], [Region], [PostCode], [Country], [PackageWeight], [PackageDimension], [ShippingLabel], [TrackingNumber], [ShippedOnUtc], [Status], [Items], [City], [CountryCode], [State]) VALUES (3559, NULL, CAST(N'2021-08-06T06:29:33.8613328' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:34.5852344' AS DateTime2), NULL, 4646, N'Dropshipping', N'Dev Steven', N'123456789', N'8 Bulim Ave', N'SG', N'123456', N'SG', NULL, NULL, N'{}', N'YCHSG21080600348', NULL, 0, N'[{"ProductId":7466,"ReceivedOnUtc":null,"ReceivedQuantity":0,"ShipQuantity":6}]', NULL, NULL, NULL)
INSERT [dbo].[TOrderShipment] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [ShippingMethod], [RecipientName], [RecipientPhoneNumber], [DeliveryAddress], [Region], [PostCode], [Country], [PackageWeight], [PackageDimension], [ShippingLabel], [TrackingNumber], [ShippedOnUtc], [Status], [Items], [City], [CountryCode], [State]) VALUES (3560, NULL, CAST(N'2021-08-06T06:29:38.1742478' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:38.8494255' AS DateTime2), NULL, 4647, N'Dropshipping', N'Dev Steven', N'123456789', N'8 Bulim Ave', N'SG', N'123456', N'SG', NULL, NULL, N'{}', N'YCHSG21080600349', NULL, 0, N'[{"ProductId":7466,"ReceivedOnUtc":null,"ReceivedQuantity":0,"ShipQuantity":6}]', NULL, NULL, NULL)
INSERT [dbo].[TOrderShipment] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [ShippingMethod], [RecipientName], [RecipientPhoneNumber], [DeliveryAddress], [Region], [PostCode], [Country], [PackageWeight], [PackageDimension], [ShippingLabel], [TrackingNumber], [ShippedOnUtc], [Status], [Items], [City], [CountryCode], [State]) VALUES (3561, NULL, CAST(N'2021-08-06T06:29:41.5556557' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:42.1740459' AS DateTime2), NULL, 4648, N'Dropshipping', N'Dev Steven', N'123456789', N'8 Bulim Ave', N'SG', N'123456', N'SG', NULL, NULL, N'{}', N'YCHSG21080600350', NULL, 0, N'[{"ProductId":7466,"ReceivedOnUtc":null,"ReceivedQuantity":0,"ShipQuantity":6}]', NULL, NULL, NULL)
INSERT [dbo].[TOrderShipment] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [OrderId], [ShippingMethod], [RecipientName], [RecipientPhoneNumber], [DeliveryAddress], [Region], [PostCode], [Country], [PackageWeight], [PackageDimension], [ShippingLabel], [TrackingNumber], [ShippedOnUtc], [Status], [Items], [City], [CountryCode], [State]) VALUES (3562, NULL, CAST(N'2021-08-06T06:29:45.8852923' AS DateTime2), NULL, CAST(N'2021-08-06T06:29:46.7304173' AS DateTime2), NULL, 4649, N'Dropshipping', N'Dev Steven', N'123456789', N'8 Bulim Ave', N'SG', N'123456', N'SG', NULL, NULL, N'{}', N'YCHSG21080600351', NULL, 0, N'[{"ProductId":7466,"ReceivedOnUtc":null,"ReceivedQuantity":0,"ShipQuantity":6}]', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[TOrderShipment] OFF
GO
SET IDENTITY_INSERT [dbo].[TPriceBook] ON 

INSERT [dbo].[TPriceBook] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [TaxTypeId], [Name], [Description], [IsMasterPriceList], [Currency], [ItemPriceIncludeTax], [DefaultFormula], [ActiveVersion], [Status]) VALUES (1053, NULL, CAST(N'2021-07-29T07:16:44.7517155' AS DateTime2), N'Steven', CAST(N'2021-07-29T07:16:44.7538788' AS DateTime2), N'Steven', 7663, N'Default', NULL, 1, N'SGD', 1, N'', 0, N'Active')
INSERT [dbo].[TPriceBook] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [TaxTypeId], [Name], [Description], [IsMasterPriceList], [Currency], [ItemPriceIncludeTax], [DefaultFormula], [ActiveVersion], [Status]) VALUES (1054, NULL, CAST(N'2021-07-29T07:18:03.3035447' AS DateTime2), N'Steven', CAST(N'2021-07-29T07:18:03.3037329' AS DateTime2), N'Steven', 7663, N'Default1', NULL, 0, N'THB', 1, N'', 0, N'Active')
SET IDENTITY_INSERT [dbo].[TPriceBook] OFF
GO
SET IDENTITY_INSERT [dbo].[TProduct] ON 

INSERT [dbo].[TProduct] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [ParentId], [BrandId], [DefaultCategoryId], [AttributeSetId], [Name], [Code], [Type], [Price], [Currency], [EnableInventoryTracking], [Description], [Specification], [Permalink], [PublishOnUtc], [UnpublishOnUtc], [PublishStatus], [Status], [Archived], [DisplayCategories], [Attributes], [Tags], [Localization], [ImageVideos], [Seo], [ExtendedProperties], [AddOnItems], [BundledProducts], [RelatedProducts], [Channels], [Approvals], [ApprovalStatus], [ShortDescription], [PackageContent], [Model], [Thumbnail]) VALUES (7466, NULL, CAST(N'2021-07-29T11:09:21.6814711' AS DateTime2), N'Steven', CAST(N'2021-07-29T11:09:21.6876548' AS DateTime2), N'Steven', NULL, 6234, 9889, 9236, N'GGWP-S', N'GGWP-S', N'SimpleProduct', CAST(100.0000 AS Decimal(18, 4)), N'', 1, NULL, NULL, NULL, CAST(N'2021-07-29T11:10:23.2470000' AS DateTime2), CAST(N'2021-07-29T11:10:23.2470000' AS DateTime2), N'Published', N'Active', 0, N'[9889]', N'[]', N'[]', N'{"en-us":{"Description":"","Label":null,"Name":"GGWP-S","Specification":"<table width=\"100%\"><tr><td style=\"width:30%;\"></td><td style=\"width:30%;\"></td></tr><tr><td></td><td></td></tr><tr><td></td><td></td></tr><tr><td></td><td></td></tr></table>","Value":null,"Filter":null,"ShortDescription":null},"zh-cn":{"Description":"","Label":null,"Name":null,"Specification":"<table width=\"100%\"><tr><td style=\"width:30%;\"></td><td style=\"width:30%;\"></td></tr><tr><td></td><td></td></tr><tr><td></td><td></td></tr><tr><td></td><td></td></tr></table>","Value":null,"Filter":null,"ShortDescription":null},"th-TH":{"Description":"","Label":null,"Name":null,"Specification":"<table width=\"100%\"><tr><td style=\"width:30%;\"></td><td style=\"width:30%;\"></td></tr><tr><td></td><td></td></tr><tr><td></td><td></td></tr><tr><td></td><td></td></tr></table>","Value":null,"Filter":null,"ShortDescription":null}}', N'[]', N'{}', N'{}', N'[]', N'[]', N'[]', N'[]', N'[]', N'Approved', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[TProduct] OFF
GO
SET IDENTITY_INSERT [dbo].[TProductAttribute] ON 

INSERT [dbo].[TProductAttribute] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [Name], [Code], [Type], [Status], [Localization]) VALUES (5869, NULL, CAST(N'2021-07-29T07:46:41.8002478' AS DateTime2), N'Steven', CAST(N'2021-07-29T07:46:41.8022750' AS DateTime2), N'Steven', N'pa-test color1', N'pa-test color1', N'Swatch', N'Active', N'{"en-us":{"Description":null,"Label":"PA test Color1","Name":"pa-test color1","Specification":null,"Value":null,"Filter":null,"ShortDescription":null}}')
INSERT [dbo].[TProductAttribute] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [Name], [Code], [Type], [Status], [Localization]) VALUES (5870, NULL, CAST(N'2021-07-29T07:47:30.5784121' AS DateTime2), N'Steven', CAST(N'2021-07-29T07:47:30.5786052' AS DateTime2), N'Steven', N'PA test Color2', N'pa-test2', N'Color', N'Active', N'{"en-us":{"Description":null,"Label":"PA test Color2","Name":"PA test Color2","Specification":null,"Value":null,"Filter":null,"ShortDescription":null}}')
SET IDENTITY_INSERT [dbo].[TProductAttribute] OFF
GO
SET IDENTITY_INSERT [dbo].[TProductAttributeSet] ON 

INSERT [dbo].[TProductAttributeSet] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [Name], [Status], [Localization], [ProductAttributes]) VALUES (9236, NULL, CAST(N'2021-07-29T07:50:24.2827506' AS DateTime2), N'Steven', CAST(N'2021-07-29T07:50:24.2845080' AS DateTime2), N'Steven', N'pa set1', N'Active', N'{}', N'[{"IsMandatory":false,"ProductAttributeId":5869,"Order":1},{"IsMandatory":false,"ProductAttributeId":5870,"Order":2}]')
SET IDENTITY_INSERT [dbo].[TProductAttributeSet] OFF
GO
SET IDENTITY_INSERT [dbo].[TProductLog] ON 

INSERT [dbo].[TProductLog] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [ProductId], [Action], [Before], [After]) VALUES (7572, NULL, CAST(N'2021-07-29T11:09:21.8787322' AS DateTime2), N'Steven', CAST(N'2021-07-29T11:09:21.8806862' AS DateTime2), N'Steven', 7466, N'ADD', NULL, N'{"ParentId":null,"BrandId":6234,"DefaultCategoryId":9889,"AttributeSetId":9236,"Name":"GGWP-S","Code":"GGWP-S","Type":1,"DisplayCategories":[9889],"Attributes":[],"Tags":[],"Price":100.0,"Currency":"","EnableInventoryTracking":true,"Description":null,"Specification":null,"Localization":{"en-us":{"Description":"","Label":null,"Name":"GGWP-S","Specification":"<table width=\"100%\"><tr><td style=\"width:30%;\"></td><td style=\"width:30%;\"></td></tr><tr><td></td><td></td></tr><tr><td></td><td></td></tr><tr><td></td><td></td></tr></table>","Value":null,"Filter":null,"ShortDescription":null},"zh-cn":{"Description":"","Label":null,"Name":null,"Specification":"<table width=\"100%\"><tr><td style=\"width:30%;\"></td><td style=\"width:30%;\"></td></tr><tr><td></td><td></td></tr><tr><td></td><td></td></tr><tr><td></td><td></td></tr></table>","Value":null,"Filter":null,"ShortDescription":null},"th-TH":{"Description":"","Label":null,"Name":null,"Specification":"<table width=\"100%\"><tr><td style=\"width:30%;\"></td><td style=\"width:30%;\"></td></tr><tr><td></td><td></td></tr><tr><td></td><td></td></tr><tr><td></td><td></td></tr></table>","Value":null,"Filter":null,"ShortDescription":null}},"ImageVideos":[],"Permalink":null,"Seo":{},"ExtendedProperties":{},"AddOnItems":[],"BundledProducts":[],"RelatedProducts":[],"Channels":[],"PublishOnUtc":"2021-07-29T11:10:23.247Z","UnpublishOnUtc":"2021-07-29T11:10:23.247Z","PublishStatus":1,"ApprovalStatus":2,"Status":1,"Archived":false,"Approvals":[],"ShortDescription":null,"PackageContent":null,"Model":null,"Thumbnail":null,"CreatedBy":"Steven","CreatedOnUtc":"2021-07-29T11:09:21.6814711Z","Extra":null,"Id":7466,"LastUpdatedBy":"Steven","LastUpdatedOnUtc":"2021-07-29T11:09:21.6876548Z","Timestamp":"AAAAAAAAJyQ="}')
SET IDENTITY_INSERT [dbo].[TProductLog] OFF
GO
SET IDENTITY_INSERT [dbo].[TTaxonomy] ON 

INSERT [dbo].[TTaxonomy] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [Type], [Key], [Value], [Category], [Deleted]) VALUES (2295, NULL, CAST(N'2021-07-28T14:23:08.0388857' AS DateTime2), NULL, CAST(N'2021-07-28T14:23:08.0415064' AS DateTime2), NULL, N'ChannelType', N'brick-mortal', N'BRICK_&_MORTAL_STORE', N'PhysicalStore', 0)
INSERT [dbo].[TTaxonomy] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [Type], [Key], [Value], [Category], [Deleted]) VALUES (2296, NULL, CAST(N'2021-07-28T14:23:08.0389106' AS DateTime2), NULL, CAST(N'2021-07-28T14:23:08.0415099' AS DateTime2), NULL, N'ChannelType', N'temporary-kiosk', N'TEMPORARY_KIOSK', N'PhysicalStore', 0)
INSERT [dbo].[TTaxonomy] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [Type], [Key], [Value], [Category], [Deleted]) VALUES (2297, NULL, CAST(N'2021-07-28T14:23:08.0389135' AS DateTime2), NULL, CAST(N'2021-07-28T14:23:08.0415126' AS DateTime2), NULL, N'ChannelType', N'lazada-sg', N'Lazada SG', N'Marketplace', 0)
INSERT [dbo].[TTaxonomy] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [Type], [Key], [Value], [Category], [Deleted]) VALUES (2298, NULL, CAST(N'2021-07-28T14:23:08.0389163' AS DateTime2), NULL, CAST(N'2021-07-28T14:23:08.0415154' AS DateTime2), NULL, N'ChannelType', N'shopee-sg', N'Shopee SG', N'Marketplace', 0)
INSERT [dbo].[TTaxonomy] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [Type], [Key], [Value], [Category], [Deleted]) VALUES (2299, NULL, CAST(N'2021-07-28T14:23:08.0389190' AS DateTime2), NULL, CAST(N'2021-07-28T14:23:08.0415181' AS DateTime2), NULL, N'ChannelType', N'qoo10-sg', N'Qoo10 SG', N'Marketplace', 0)
INSERT [dbo].[TTaxonomy] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [Type], [Key], [Value], [Category], [Deleted]) VALUES (2300, NULL, CAST(N'2021-07-28T14:23:08.0389217' AS DateTime2), NULL, CAST(N'2021-07-28T14:23:08.0415207' AS DateTime2), NULL, N'ChannelType', N'zalora-sg', N'Zalora SG', N'Marketplace', 0)
INSERT [dbo].[TTaxonomy] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [Type], [Key], [Value], [Category], [Deleted]) VALUES (2301, NULL, CAST(N'2021-07-28T14:23:08.0389244' AS DateTime2), NULL, CAST(N'2021-07-28T14:23:08.0415234' AS DateTime2), NULL, N'ChannelType', N'ysg-sg', N'Ysg SG', N'Marketplace', 0)
INSERT [dbo].[TTaxonomy] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [Type], [Key], [Value], [Category], [Deleted]) VALUES (2302, NULL, CAST(N'2021-07-28T14:23:08.0389306' AS DateTime2), NULL, CAST(N'2021-07-28T14:23:08.0415259' AS DateTime2), NULL, N'ChannelType', N'shopify', N'Shopify', N'ECommerce', 0)
INSERT [dbo].[TTaxonomy] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [Type], [Key], [Value], [Category], [Deleted]) VALUES (2303, NULL, CAST(N'2021-07-28T14:23:08.0389333' AS DateTime2), NULL, CAST(N'2021-07-28T14:23:08.0415287' AS DateTime2), NULL, N'Language', N'en-us', N'English', NULL, 0)
INSERT [dbo].[TTaxonomy] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [Type], [Key], [Value], [Category], [Deleted]) VALUES (2304, NULL, CAST(N'2021-07-28T14:23:08.0389362' AS DateTime2), NULL, CAST(N'2021-07-28T14:23:08.0415313' AS DateTime2), NULL, N'Language', N'zh-cn', N'简体中文', NULL, 0)
INSERT [dbo].[TTaxonomy] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [Type], [Key], [Value], [Category], [Deleted]) VALUES (2305, NULL, CAST(N'2021-07-28T14:23:08.0389388' AS DateTime2), NULL, CAST(N'2021-07-28T14:23:08.0415340' AS DateTime2), NULL, N'Currency', N'sgd', N'SGD', NULL, 0)
INSERT [dbo].[TTaxonomy] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [Type], [Key], [Value], [Category], [Deleted]) VALUES (2306, NULL, CAST(N'2021-07-28T14:23:08.0389416' AS DateTime2), NULL, CAST(N'2021-07-28T14:23:08.0415365' AS DateTime2), NULL, N'Currency', N'usd', N'USD', NULL, 0)
INSERT [dbo].[TTaxonomy] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [Type], [Key], [Value], [Category], [Deleted]) VALUES (2307, NULL, CAST(N'2021-07-29T07:15:21.3462532' AS DateTime2), N'Steven', CAST(N'2021-07-29T07:15:21.3481748' AS DateTime2), N'Steven', N'Language', N'th-TH', N'ไทย (ไทย)', NULL, 0)
SET IDENTITY_INSERT [dbo].[TTaxonomy] OFF
GO
SET IDENTITY_INSERT [dbo].[TTaxType] ON 

INSERT [dbo].[TTaxType] ([Id], [Extra], [CreatedOnUtc], [CreatedBy], [LastUpdatedOnUtc], [LastUpdatedBy], [Name], [Code], [EffectiveFromUtc], [EffectiveToUtc], [TaxRate], [Remarks], [Status]) VALUES (7663, NULL, CAST(N'2021-07-29T07:14:15.0407040' AS DateTime2), N'Steven', CAST(N'2021-07-29T07:14:15.0488832' AS DateTime2), N'Steven', N'GST', N'GST', CAST(N'2020-10-13T16:00:00.0000000' AS DateTime2), CAST(N'2120-10-13T16:00:00.0000000' AS DateTime2), CAST(9.00000000 AS Decimal(18, 8)), NULL, N'Active')
SET IDENTITY_INSERT [dbo].[TTaxType] OFF
GO
ALTER TABLE [dbo].[TChannel] ADD  DEFAULT ((0)) FOR [StockSyncWithReservedStock]
GO
ALTER TABLE [dbo].[TDiscountCampaign] ADD  DEFAULT (N'') FOR [ApprovalStatus]
GO
ALTER TABLE [dbo].[TDiscountCampaign] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [EffectiveFromUtc]
GO
ALTER TABLE [dbo].[TDiscountCampaign] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [EffectiveToUtc]
GO
ALTER TABLE [dbo].[TInventoryAdjustment] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [RequestOnUtc]
GO
ALTER TABLE [dbo].[TInventoryAdjustmentItem] ADD  DEFAULT ((0)) FOR [BeforeQuantity]
GO
ALTER TABLE [dbo].[TInventoryGoodsReceipt] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [ReceivedOnUtc]
GO
ALTER TABLE [dbo].[TInventoryItem] ADD  DEFAULT (N'') FOR [ReservedByChannel]
GO
ALTER TABLE [dbo].[TInventoryLedger] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [PerformedOnUtc]
GO
ALTER TABLE [dbo].[TInventoryTransfer] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [RequestOnUtc]
GO
ALTER TABLE [dbo].[TOrder] ADD  CONSTRAINT [DF_TOrder_PosStauts]  DEFAULT ((0)) FOR [PosStatus]
GO
ALTER TABLE [dbo].[TOrderItem] ADD  DEFAULT ((0)) FOR [IsBundled]
GO
ALTER TABLE [dbo].[TProduct] ADD  DEFAULT (N'') FOR [ApprovalStatus]
GO
ALTER TABLE [dbo].[TPromoGwp] ADD  DEFAULT ((0)) FOR [MinPurchaseAmountStackable]
GO
ALTER TABLE [dbo].[TPromoGwp] ADD  DEFAULT ((0)) FOR [ProdCatQtyStackable]
GO
ALTER TABLE [dbo].[TPromoGwpGift] ADD  DEFAULT ((1)) FOR [PromoGwpGiftQuantity]
GO
ALTER TABLE [dbo].[TPromoGwpProdCat] ADD  DEFAULT (N'Inclusion') FOR [Type]
GO
ALTER TABLE [dbo].[TPromoGwpProdCat] ADD  DEFAULT ((1)) FOR [PromoGwpProdCatQuantity]
GO
ALTER TABLE [dbo].[TCategory]  WITH CHECK ADD  CONSTRAINT [FK_TCategory_TCategory_ParentId] FOREIGN KEY([ParentId])
REFERENCES [dbo].[TCategory] ([Id])
GO
ALTER TABLE [dbo].[TCategory] CHECK CONSTRAINT [FK_TCategory_TCategory_ParentId]
GO
ALTER TABLE [dbo].[TChannel]  WITH CHECK ADD  CONSTRAINT [FK_TChannel_TInventory_InventoryId] FOREIGN KEY([InventoryId])
REFERENCES [dbo].[TInventory] ([Id])
GO
ALTER TABLE [dbo].[TChannel] CHECK CONSTRAINT [FK_TChannel_TInventory_InventoryId]
GO
ALTER TABLE [dbo].[TChannel]  WITH CHECK ADD  CONSTRAINT [FK_TChannel_TPriceBook_PriceBookId] FOREIGN KEY([PriceBookId])
REFERENCES [dbo].[TPriceBook] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TChannel] CHECK CONSTRAINT [FK_TChannel_TPriceBook_PriceBookId]
GO
ALTER TABLE [dbo].[TDiscountItem]  WITH CHECK ADD  CONSTRAINT [FK_TDiscountItem_TDiscountCampaign_CampaignId] FOREIGN KEY([CampaignId])
REFERENCES [dbo].[TDiscountCampaign] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TDiscountItem] CHECK CONSTRAINT [FK_TDiscountItem_TDiscountCampaign_CampaignId]
GO
ALTER TABLE [dbo].[TDiscountItem]  WITH CHECK ADD  CONSTRAINT [FK_TDiscountItem_TProduct_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[TProduct] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TDiscountItem] CHECK CONSTRAINT [FK_TDiscountItem_TProduct_ProductId]
GO
ALTER TABLE [dbo].[TEvent]  WITH CHECK ADD  CONSTRAINT [FK_TEvent_TEventType_EventTypeId] FOREIGN KEY([EventTypeId])
REFERENCES [dbo].[TEventType] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TEvent] CHECK CONSTRAINT [FK_TEvent_TEventType_EventTypeId]
GO
ALTER TABLE [dbo].[TIndexProductCategory]  WITH CHECK ADD  CONSTRAINT [FK_TIndexProductCategory_TIndexBrand_IndexBrandId] FOREIGN KEY([IndexBrandId])
REFERENCES [dbo].[TIndexBrand] ([Id])
GO
ALTER TABLE [dbo].[TIndexProductCategory] CHECK CONSTRAINT [FK_TIndexProductCategory_TIndexBrand_IndexBrandId]
GO
ALTER TABLE [dbo].[TIntegrationLog]  WITH CHECK ADD  CONSTRAINT [FK_TIntegrationLog_TIntegrationLog_ReferLogId] FOREIGN KEY([ReferLogId])
REFERENCES [dbo].[TIntegrationLog] ([Id])
GO
ALTER TABLE [dbo].[TIntegrationLog] CHECK CONSTRAINT [FK_TIntegrationLog_TIntegrationLog_ReferLogId]
GO
ALTER TABLE [dbo].[TInventoryAdjustment]  WITH CHECK ADD  CONSTRAINT [FK_TInventoryAdjustment_TInventory_InventoryId] FOREIGN KEY([InventoryId])
REFERENCES [dbo].[TInventory] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TInventoryAdjustment] CHECK CONSTRAINT [FK_TInventoryAdjustment_TInventory_InventoryId]
GO
ALTER TABLE [dbo].[TInventoryAdjustmentItem]  WITH CHECK ADD  CONSTRAINT [FK_TInventoryAdjustmentItem_TInventoryAdjustment_AdjustmentId] FOREIGN KEY([AdjustmentId])
REFERENCES [dbo].[TInventoryAdjustment] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TInventoryAdjustmentItem] CHECK CONSTRAINT [FK_TInventoryAdjustmentItem_TInventoryAdjustment_AdjustmentId]
GO
ALTER TABLE [dbo].[TInventoryAdjustmentItem]  WITH CHECK ADD  CONSTRAINT [FK_TInventoryAdjustmentItem_TProduct_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[TProduct] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TInventoryAdjustmentItem] CHECK CONSTRAINT [FK_TInventoryAdjustmentItem_TProduct_ProductId]
GO
ALTER TABLE [dbo].[TInventoryGoodsReceipt]  WITH CHECK ADD  CONSTRAINT [FK_TInventoryGoodsReceipt_TInventoryTransfer_TransferId] FOREIGN KEY([TransferId])
REFERENCES [dbo].[TInventoryTransfer] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TInventoryGoodsReceipt] CHECK CONSTRAINT [FK_TInventoryGoodsReceipt_TInventoryTransfer_TransferId]
GO
ALTER TABLE [dbo].[TInventoryGoodsReceiptItem]  WITH CHECK ADD  CONSTRAINT [FK_TInventoryGoodsReceiptItem_TInventoryGoodsReceipt_GoodsReceiptId] FOREIGN KEY([GoodsReceiptId])
REFERENCES [dbo].[TInventoryGoodsReceipt] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TInventoryGoodsReceiptItem] CHECK CONSTRAINT [FK_TInventoryGoodsReceiptItem_TInventoryGoodsReceipt_GoodsReceiptId]
GO
ALTER TABLE [dbo].[TInventoryGoodsReceiptItem]  WITH CHECK ADD  CONSTRAINT [FK_TInventoryGoodsReceiptItem_TProduct_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[TProduct] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TInventoryGoodsReceiptItem] CHECK CONSTRAINT [FK_TInventoryGoodsReceiptItem_TProduct_ProductId]
GO
ALTER TABLE [dbo].[TInventoryItem]  WITH CHECK ADD  CONSTRAINT [FK_TInventoryItem_TInventory_InventoryId] FOREIGN KEY([InventoryId])
REFERENCES [dbo].[TInventory] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TInventoryItem] CHECK CONSTRAINT [FK_TInventoryItem_TInventory_InventoryId]
GO
ALTER TABLE [dbo].[TInventoryItem]  WITH CHECK ADD  CONSTRAINT [FK_TInventoryItem_TProduct_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[TProduct] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TInventoryItem] CHECK CONSTRAINT [FK_TInventoryItem_TProduct_ProductId]
GO
ALTER TABLE [dbo].[TInventoryLedger]  WITH CHECK ADD  CONSTRAINT [FK_TInventoryLedger_TInventory_InventoryId] FOREIGN KEY([InventoryId])
REFERENCES [dbo].[TInventory] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TInventoryLedger] CHECK CONSTRAINT [FK_TInventoryLedger_TInventory_InventoryId]
GO
ALTER TABLE [dbo].[TInventoryLedger]  WITH CHECK ADD  CONSTRAINT [FK_TInventoryLedger_TProduct_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[TProduct] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TInventoryLedger] CHECK CONSTRAINT [FK_TInventoryLedger_TProduct_ProductId]
GO
ALTER TABLE [dbo].[TInventoryTransferItem]  WITH CHECK ADD  CONSTRAINT [FK_TInventoryTransferItem_TInventoryTransfer_TransferId] FOREIGN KEY([TransferId])
REFERENCES [dbo].[TInventoryTransfer] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TInventoryTransferItem] CHECK CONSTRAINT [FK_TInventoryTransferItem_TInventoryTransfer_TransferId]
GO
ALTER TABLE [dbo].[TInventoryTransferItem]  WITH CHECK ADD  CONSTRAINT [FK_TInventoryTransferItem_TProduct_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[TProduct] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TInventoryTransferItem] CHECK CONSTRAINT [FK_TInventoryTransferItem_TProduct_ProductId]
GO
ALTER TABLE [dbo].[TOrder]  WITH CHECK ADD  CONSTRAINT [FK_TOrder_TChannel_ChannelId] FOREIGN KEY([ChannelId])
REFERENCES [dbo].[TChannel] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TOrder] CHECK CONSTRAINT [FK_TOrder_TChannel_ChannelId]
GO
ALTER TABLE [dbo].[TOrder]  WITH CHECK ADD  CONSTRAINT [FK_TOrder_TChannel_PickUpChannelId] FOREIGN KEY([PickUpChannelId])
REFERENCES [dbo].[TChannel] ([Id])
GO
ALTER TABLE [dbo].[TOrder] CHECK CONSTRAINT [FK_TOrder_TChannel_PickUpChannelId]
GO
ALTER TABLE [dbo].[TOrder]  WITH CHECK ADD  CONSTRAINT [FK_TOrder_TOrder_OriginalOrderId] FOREIGN KEY([OriginalOrderId])
REFERENCES [dbo].[TOrder] ([Id])
GO
ALTER TABLE [dbo].[TOrder] CHECK CONSTRAINT [FK_TOrder_TOrder_OriginalOrderId]
GO
ALTER TABLE [dbo].[TOrderCustomerInfo]  WITH CHECK ADD  CONSTRAINT [FK_TOrderCustomerInfo_TOrder_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[TOrder] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TOrderCustomerInfo] CHECK CONSTRAINT [FK_TOrderCustomerInfo_TOrder_OrderId]
GO
ALTER TABLE [dbo].[TOrderDiscountInfo]  WITH CHECK ADD  CONSTRAINT [FK_TOrderDiscountInfo_TOrder_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[TOrder] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TOrderDiscountInfo] CHECK CONSTRAINT [FK_TOrderDiscountInfo_TOrder_OrderId]
GO
ALTER TABLE [dbo].[TOrderItem]  WITH CHECK ADD  CONSTRAINT [FK_TOrderItem_TOrder_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[TOrder] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TOrderItem] CHECK CONSTRAINT [FK_TOrderItem_TOrder_OrderId]
GO
ALTER TABLE [dbo].[TOrderItem]  WITH CHECK ADD  CONSTRAINT [FK_TOrderItem_TProduct_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[TProduct] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TOrderItem] CHECK CONSTRAINT [FK_TOrderItem_TProduct_ProductId]
GO
ALTER TABLE [dbo].[TOrderLog]  WITH CHECK ADD  CONSTRAINT [FK_TOrderLog_TOrder_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[TOrder] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TOrderLog] CHECK CONSTRAINT [FK_TOrderLog_TOrder_OrderId]
GO
ALTER TABLE [dbo].[TOrderPaymentInfo]  WITH CHECK ADD  CONSTRAINT [FK_TOrderPaymentInfo_TOrder_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[TOrder] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TOrderPaymentInfo] CHECK CONSTRAINT [FK_TOrderPaymentInfo_TOrder_OrderId]
GO
ALTER TABLE [dbo].[TOrderShipment]  WITH CHECK ADD  CONSTRAINT [FK_TOrderShipment_TOrder_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[TOrder] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TOrderShipment] CHECK CONSTRAINT [FK_TOrderShipment_TOrder_OrderId]
GO
ALTER TABLE [dbo].[TPriceBook]  WITH CHECK ADD  CONSTRAINT [FK_TPriceBook_TTaxType_TaxTypeId] FOREIGN KEY([TaxTypeId])
REFERENCES [dbo].[TTaxType] ([Id])
GO
ALTER TABLE [dbo].[TPriceBook] CHECK CONSTRAINT [FK_TPriceBook_TTaxType_TaxTypeId]
GO
ALTER TABLE [dbo].[TPriceBookAddOnItem]  WITH CHECK ADD  CONSTRAINT [FK_TPriceBookAddOnItem_TPriceBook_PriceBookId] FOREIGN KEY([PriceBookId])
REFERENCES [dbo].[TPriceBook] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TPriceBookAddOnItem] CHECK CONSTRAINT [FK_TPriceBookAddOnItem_TPriceBook_PriceBookId]
GO
ALTER TABLE [dbo].[TPriceBookAddOnItem]  WITH CHECK ADD  CONSTRAINT [FK_TPriceBookAddOnItem_TProduct_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[TProduct] ([Id])
GO
ALTER TABLE [dbo].[TPriceBookAddOnItem] CHECK CONSTRAINT [FK_TPriceBookAddOnItem_TProduct_ProductId]
GO
ALTER TABLE [dbo].[TPriceBookItem]  WITH CHECK ADD  CONSTRAINT [FK_TPriceBookItem_TPriceBook_PriceBookId] FOREIGN KEY([PriceBookId])
REFERENCES [dbo].[TPriceBook] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TPriceBookItem] CHECK CONSTRAINT [FK_TPriceBookItem_TPriceBook_PriceBookId]
GO
ALTER TABLE [dbo].[TPriceBookItem]  WITH CHECK ADD  CONSTRAINT [FK_TPriceBookItem_TProduct_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[TProduct] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TPriceBookItem] CHECK CONSTRAINT [FK_TPriceBookItem_TProduct_ProductId]
GO
ALTER TABLE [dbo].[TPriceBookVersioning]  WITH CHECK ADD  CONSTRAINT [FK_TPriceBookVersioning_TPriceBook_PriceBookId] FOREIGN KEY([PriceBookId])
REFERENCES [dbo].[TPriceBook] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TPriceBookVersioning] CHECK CONSTRAINT [FK_TPriceBookVersioning_TPriceBook_PriceBookId]
GO
ALTER TABLE [dbo].[TProduct]  WITH CHECK ADD  CONSTRAINT [FK_TProduct_TBrand_BrandId] FOREIGN KEY([BrandId])
REFERENCES [dbo].[TBrand] ([Id])
GO
ALTER TABLE [dbo].[TProduct] CHECK CONSTRAINT [FK_TProduct_TBrand_BrandId]
GO
ALTER TABLE [dbo].[TProduct]  WITH CHECK ADD  CONSTRAINT [FK_TProduct_TCategory_DefaultCategoryId] FOREIGN KEY([DefaultCategoryId])
REFERENCES [dbo].[TCategory] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TProduct] CHECK CONSTRAINT [FK_TProduct_TCategory_DefaultCategoryId]
GO
ALTER TABLE [dbo].[TProduct]  WITH CHECK ADD  CONSTRAINT [FK_TProduct_TProduct_ParentId] FOREIGN KEY([ParentId])
REFERENCES [dbo].[TProduct] ([Id])
GO
ALTER TABLE [dbo].[TProduct] CHECK CONSTRAINT [FK_TProduct_TProduct_ParentId]
GO
ALTER TABLE [dbo].[TProduct]  WITH CHECK ADD  CONSTRAINT [FK_TProduct_TProductAttributeSet_AttributeSetId] FOREIGN KEY([AttributeSetId])
REFERENCES [dbo].[TProductAttributeSet] ([Id])
GO
ALTER TABLE [dbo].[TProduct] CHECK CONSTRAINT [FK_TProduct_TProductAttributeSet_AttributeSetId]
GO
ALTER TABLE [dbo].[TProductAttributeOption]  WITH CHECK ADD  CONSTRAINT [FK_TProductAttributeOption_TProductAttribute_ProductAttributeId] FOREIGN KEY([ProductAttributeId])
REFERENCES [dbo].[TProductAttribute] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TProductAttributeOption] CHECK CONSTRAINT [FK_TProductAttributeOption_TProductAttribute_ProductAttributeId]
GO
ALTER TABLE [dbo].[TProductLog]  WITH CHECK ADD  CONSTRAINT [FK_TProductLog_TProduct_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[TProduct] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TProductLog] CHECK CONSTRAINT [FK_TProductLog_TProduct_ProductId]
GO
ALTER TABLE [dbo].[TPromoGwp]  WITH CHECK ADD  CONSTRAINT [FK_TPromoGwp_TChannel_ChannelId] FOREIGN KEY([ChannelId])
REFERENCES [dbo].[TChannel] ([Id])
GO
ALTER TABLE [dbo].[TPromoGwp] CHECK CONSTRAINT [FK_TPromoGwp_TChannel_ChannelId]
GO
ALTER TABLE [dbo].[TPromoGwpGift]  WITH CHECK ADD  CONSTRAINT [FK_TPromoGwpGift_TProduct_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[TProduct] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TPromoGwpGift] CHECK CONSTRAINT [FK_TPromoGwpGift_TProduct_ProductId]
GO
ALTER TABLE [dbo].[TPromoGwpGift]  WITH CHECK ADD  CONSTRAINT [FK_TPromoGwpGift_TPromoGwp_PromoGwpId] FOREIGN KEY([PromoGwpId])
REFERENCES [dbo].[TPromoGwp] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TPromoGwpGift] CHECK CONSTRAINT [FK_TPromoGwpGift_TPromoGwp_PromoGwpId]
GO
ALTER TABLE [dbo].[TPromoGwpProdCat]  WITH CHECK ADD  CONSTRAINT [FK_TPromoGwpProdCat_TCategory_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[TCategory] ([Id])
GO
ALTER TABLE [dbo].[TPromoGwpProdCat] CHECK CONSTRAINT [FK_TPromoGwpProdCat_TCategory_CategoryId]
GO
ALTER TABLE [dbo].[TPromoGwpProdCat]  WITH CHECK ADD  CONSTRAINT [FK_TPromoGwpProdCat_TProduct_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[TProduct] ([Id])
GO
ALTER TABLE [dbo].[TPromoGwpProdCat] CHECK CONSTRAINT [FK_TPromoGwpProdCat_TProduct_ProductId]
GO
ALTER TABLE [dbo].[TPromoGwpProdCat]  WITH CHECK ADD  CONSTRAINT [FK_TPromoGwpProdCat_TPromoGwp_PromoGwpId] FOREIGN KEY([PromoGwpId])
REFERENCES [dbo].[TPromoGwp] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TPromoGwpProdCat] CHECK CONSTRAINT [FK_TPromoGwpProdCat_TPromoGwp_PromoGwpId]
GO
