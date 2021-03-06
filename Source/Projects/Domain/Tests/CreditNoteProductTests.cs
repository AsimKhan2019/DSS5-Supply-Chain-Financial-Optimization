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
    ///This is a test class for CreditNoteProductTest and is intended
    ///to contain all CreditNoteProductTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("CreditNoteProduct Repository Tests")]
    [Category("CreditNoteProduct Repository Tests")]
    internal class CreditNoteProductTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `CreditNoteProduct`")]
        [Order(0)]
        public void CreditNoteProduct_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _order_creditnote_creditnoteproducts = new DSS5_SupplyChainFinancialsOptimisation.BO.CreditNote
            {
                CreditNoteNumber = "CreditNote_CreditNoteNumber",
                Description = "CreditNote_Description",
                DateIssued = now,
                Amount = 2222222222.22222M,
                TotalPrice = 2222222222.22222M,
                CreditNoteDocument = "CreditNote_CreditNoteDocument",
                CNoteAttachment = "CreditNote_CNoteAttachment",
            };
            new PersistenceSpecification<DSS5_SupplyChainFinancialsOptimisation.BO.CreditNoteProduct>(Session)
            .CheckProperty(p => p.Code, "CreditNoteProduct_Code")
            .CheckProperty(p => p.Quantity, 222222.22M)
            .CheckProperty(p => p.Description, "CreditNoteProduct_Description")
            .CheckProperty(p => p.UnitValue, "CreditNoteProduct_UnitValue")
            .CheckProperty(p => p.MeasurementUnit, "CreditNoteProduct_MeasurementUnit")
            .CheckProperty(p => p.Price, 222222.22M)
            .CheckProperty(p => p.LineTotalPrice, 222222.22M)
            .CheckReference(p => p.CreditNote, _order_creditnote_creditnoteproducts)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `CreditNoteProduct`")]
        [Order(1)]
        public void CreditNoteProduct_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS5_SupplyChainFinancialsOptimisation.BO.CreditNoteProduct> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.CreditNoteProduct>(
                              a => true
                              && (a.Code != string.Empty && a.Code != null)
                              && (a.Quantity + 123 > 0)
                              && (a.Description != string.Empty && a.Description != null)
                              && (a.UnitValue != string.Empty && a.UnitValue != null)
                              && (a.MeasurementUnit != string.Empty && a.MeasurementUnit != null)
                              && (a.Price + 123 > 0)
                              && (a.LineTotalPrice + 123 > 0)
                              && a.CreditNote != null
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