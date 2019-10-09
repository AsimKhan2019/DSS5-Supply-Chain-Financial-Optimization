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
    ///This is a test class for SupplierProductTest and is intended
    ///to contain all SupplierProductTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("SupplierProduct Repository Tests")]
    [Category("SupplierProduct Repository Tests")]
    internal class SupplierProductTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `SupplierProduct`")]
        [Order(0)]
        public void SupplierProduct_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _supplierproduct_productcategory_supplierproduct = new DSS5_SupplyChainFinancialsOptimisation.BO.ProductCategory
            {
                Type = "ProductCategory_Type",
            };
            var _supplierproduct_supplier_supplierproducts = new DSS5_SupplyChainFinancialsOptimisation.BO.Supplier
            {
                SupplierId = 3217,
                Company = "Supplier_Company",
                CompanyLogo = "Supplier_CompanyLogo",
                Business = "Supplier_Business",
                CurrentAmount = "Supplier_CurrentAmount",
                AverageAmount = "Supplier_AverageAmount",
                PercentageOfCreditNotes = "Supplier_PercentageOfCreditNotes",
                PrimaryPhone = "Supplier_PrimaryPhone",
                SecondaryPhone = "Supplier_SecondaryPhone",
                Fax = "Supplier_Fax",
                WebSite = "Supplier_WebSite",
                AcceptedPolicyTerms = true,
                SupplierStatus = "Supplier_SupplierStatus",
                DomainFocus = "Supplier_DomainFocus",
                EvaluationResult = "Supplier_EvaluationResult",
                EvaluationCountResult = 8885,
                AnnualTurnover = true,
                BEnvironment = true,
                PTerms = true,
                Average = true,
                InvoiceValue = true,
                EqRatio = true,
                Prefix = "Supplier_Prefix",
                VATNumber = "Supplier_VATNumber",
                MarketSegment = "Supplier_MarketSegment",
                AdditionalComments = "Supplier_AdditionalComments",
                AdditionalCommentsStep2 = "Supplier_AdditionalCommentsStep2",
                AdditionalCommentsStep3 = "Supplier_AdditionalCommentsStep3",
                UserName = "1a2b9df8-a834-44cb-bf83-26e1c7350cfcSupplier_UserName",
                PasswordHash = "Supplier_PasswordHash",
                SecurityStamp = "Supplier_SecurityStamp",
                EmailConfirmed = true,
                LockoutEnabled = true,
                PhoneNumberConfirmed = true,
                TwoFactorEnabled = true,
                AccessFailedCount = 6210,
                Name = "Supplier_Name",
                Email = "Supplier_Email",
                PhoneNumber = "Supplier_PhoneNumber",
                LockoutEndDate = now,
            };
            new PersistenceSpecification<DSS5_SupplyChainFinancialsOptimisation.BO.SupplierProduct>(Session)
            .CheckProperty(p => p.Code, "SupplierProduct_Code")
            .CheckProperty(p => p.Description, "SupplierProduct_Description")
            .CheckProperty(p => p.UnitValue, "SupplierProduct_UnitValue")
            .CheckProperty(p => p.MeasurementUnit, "SupplierProduct_MeasurementUnit")
            .CheckProperty(p => p.Price, 222222.22M)
            .CheckReference(p => p.ProductCategory, _supplierproduct_productcategory_supplierproduct)
            .CheckReference(p => p.Supplier, _supplierproduct_supplier_supplierproducts)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `SupplierProduct`")]
        [Order(1)]
        public void SupplierProduct_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS5_SupplyChainFinancialsOptimisation.BO.SupplierProduct> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.SupplierProduct>(
                              a => true
                              && (a.Code != string.Empty && a.Code != null)
                              && (a.Description != string.Empty && a.Description != null)
                              && (a.UnitValue != string.Empty && a.UnitValue != null)
                              && (a.MeasurementUnit != string.Empty && a.MeasurementUnit != null)
                              && (a.Price + 123 > 0)
                              && a.ProductCategory != null
                              && a.Supplier != null
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