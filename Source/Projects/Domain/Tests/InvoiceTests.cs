// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).

using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using FluentNHibernate.Testing;
using DSS5_SupplyChainFinancialsOptimisation.BO;
using DSS5_SupplyChainFinancialsOptimisation.BoTesting.Tests.Common;
using DSS5_SupplyChainFinancialsOptimisation.DAL;

namespace DSS5_SupplyChainFinancialsOptimisation.BoTesting.Tests
{
    /// <summary>
    ///This is a test class for InvoiceTest and is intended
    ///to contain all InvoiceTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("Invoice Repository Tests")]
    [Category("Invoice Repository Tests")]
    internal class InvoiceTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `Invoice`")]
        [Order(0)]
        public void Invoice_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _invoice_products_invoice = new DSS5_SupplyChainFinancialsOptimisation.BO.OrderProduct
            {
                Code = "OrderProduct_Code",
                Quantity = 222222.22M,
                Description = "OrderProduct_Description",
                UnitValue = "OrderProduct_UnitValue",
                MeasurementUnit = "OrderProduct_MeasurementUnit",
                Price = 222222.22M,
                LineTotalPrice = 222222.22M,
            };
            var _invoice_products_invoice2 = new DSS5_SupplyChainFinancialsOptimisation.BO.OrderProduct
            {
                Code = "OrderProduct_Code",
                Quantity = 222222.22M,
                Description = "OrderProduct_Description",
                UnitValue = "OrderProduct_UnitValue",
                MeasurementUnit = "OrderProduct_MeasurementUnit",
                Price = 222222.22M,
                LineTotalPrice = 222222.22M,
            };
            var _invoice_invoiceproducts_invoice = new DSS5_SupplyChainFinancialsOptimisation.BO.InvoiceProduct
            {
                Code = "InvoiceProduct_Code",
                Quantity = 222222.22M,
                Description = "InvoiceProduct_Description",
                UnitValue = "InvoiceProduct_UnitValue",
                MeasurementUnit = "InvoiceProduct_MeasurementUnit",
                Price = 222222.22M,
                LineTotalPrice = 222222.22M,
            };
            var _invoice_invoiceproducts_invoice2 = new DSS5_SupplyChainFinancialsOptimisation.BO.InvoiceProduct
            {
                Code = "InvoiceProduct_Code",
                Quantity = 222222.22M,
                Description = "InvoiceProduct_Description",
                UnitValue = "InvoiceProduct_UnitValue",
                MeasurementUnit = "InvoiceProduct_MeasurementUnit",
                Price = 222222.22M,
                LineTotalPrice = 222222.22M,
            };
            var _order_orders_invoices = new DSS5_SupplyChainFinancialsOptimisation.BO.Order
            {
                OrderNumber = "Order_OrderNumber",
                EstimatedDateOfDelivery = now,
                PaymentTerms = "Order_PaymentTerms",
                IntermediateParty = true,
                IsCancelled = true,
                DateOfOrder = now,
                OrderAmount = 2222222222.22222M,
                TotalPrice = 2222222222.22222M,
                From = "Order_From",
                DeliveryTo = "Order_DeliveryTo",
                OrderAttachment = "Order_OrderAttachment",
            };
            var _order_orders_invoices2 = new DSS5_SupplyChainFinancialsOptimisation.BO.Order
            {
                OrderNumber = "Order_OrderNumber",
                EstimatedDateOfDelivery = now,
                PaymentTerms = "Order_PaymentTerms",
                IntermediateParty = true,
                IsCancelled = true,
                DateOfOrder = now,
                OrderAmount = 2222222222.22222M,
                TotalPrice = 2222222222.22222M,
                From = "Order_From",
                DeliveryTo = "Order_DeliveryTo",
                OrderAttachment = "Order_OrderAttachment",
            };
            var _transaction_transaction_invoices = new DSS5_SupplyChainFinancialsOptimisation.BO.Transaction
            {
                TransactionDateOccured = now,
                TransactionValue = 2222222222.22222M,
                FundedAmount = 2222222222.22222M,
                ToBePaidAmount = 2222222222.22222M,
                InvoicedDate = now,
                PaymentStatus = "Transaction_PaymentStatus",
                PaymentDate = now,
                RestPaymentAmount = 2222222222.22222M,
                PaidByBuyer = true,
            };
            new PersistenceSpecification<DSS5_SupplyChainFinancialsOptimisation.BO.Invoice>(Session)
            .CheckProperty(p => p.InvoiceNumber, "Invoice_InvoiceNumber")
            .CheckProperty(p => p.Description, "Invoice_Description")
            .CheckProperty(p => p.DateIssued, now)
            .CheckProperty(p => p.Amount, 2222222222222.22M)
            .CheckProperty(p => p.CustomerType, "Invoice_CustomerType")
            .CheckProperty(p => p.CumulativeBalance, 222222.22M)
            .CheckProperty(p => p.TotalPrice, 222222.22M)
            .CheckProperty(p => p.DescriptionTwo, "Invoice_DescriptionTwo")
            .CheckProperty(p => p.Attribute, "Invoice_Attribute")
            .CheckProperty(p => p.InvoiceAttachment, "Invoice_InvoiceAttachment")
            .CheckBag(p => p.Products, (new List<DSS5_SupplyChainFinancialsOptimisation.BO.OrderProduct>
            {
                _invoice_products_invoice,
                _invoice_products_invoice2
            }))
            .CheckBag(p => p.InvoiceProducts, (new List<DSS5_SupplyChainFinancialsOptimisation.BO.InvoiceProduct>
            {
                _invoice_invoiceproducts_invoice,
                _invoice_invoiceproducts_invoice2
            }))
            .CheckBag(p => p.Orders, (new List<DSS5_SupplyChainFinancialsOptimisation.BO.Order>
            {
                _order_orders_invoices,
                _order_orders_invoices2
            }))
            .CheckReference(p => p.Transaction, _transaction_transaction_invoices)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `Invoice`")]
        [Order(1)]
        public void Invoice_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS5_SupplyChainFinancialsOptimisation.BO.Invoice> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Invoice>(
                              a => true
                              && (a.InvoiceNumber != string.Empty && a.InvoiceNumber != null)
                              && (a.Description != string.Empty && a.Description != null)
                              && a.DateIssued.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && (a.Amount + 123 > 0)
                              && (a.CustomerType != string.Empty && a.CustomerType != null)
                              && (a.CumulativeBalance + 123 > 0)
                              && (a.TotalPrice + 123 > 0)
                              && (a.DescriptionTwo != string.Empty && a.DescriptionTwo != null)
                              && (a.Attribute != string.Empty && a.Attribute != null)
                              && (a.InvoiceAttachment != string.Empty && a.InvoiceAttachment != null)
                              && a.Status == DSS5_SupplyChainFinancialsOptimisation.BO.Status.Initial
                              && a.Products.Any()
                              && a.InvoiceProducts.Any()
                              && a.Orders.Any()
                              && a.Transaction != null
                              ,
                              cacheQuery: true)
                          .OrderBy(a => a)
                          .Skip(0)
                          .Take(3)
                          .ToList();
            });
            Assert.AreNotEqual(null, results);
        }
    }
}