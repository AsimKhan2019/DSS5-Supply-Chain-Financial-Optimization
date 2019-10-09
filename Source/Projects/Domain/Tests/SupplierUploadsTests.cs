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
    ///This is a test class for SupplierUploadsTest and is intended
    ///to contain all SupplierUploadsTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("SupplierUploads Repository Tests")]
    [Category("SupplierUploads Repository Tests")]
    internal class SupplierUploadsTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `SupplierUploads`")]
        [Order(0)]
        public void SupplierUploads_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _supplier_supplier_financialstatements = new DSS5_SupplyChainFinancialsOptimisation.BO.Supplier
            {
                SupplierId = 1873,
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
                EvaluationCountResult = 4982,
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
                UserName = "1c67809b-f206-4d50-95d6-09d31491d8f8Supplier_UserName",
                PasswordHash = "Supplier_PasswordHash",
                SecurityStamp = "Supplier_SecurityStamp",
                EmailConfirmed = true,
                LockoutEnabled = true,
                PhoneNumberConfirmed = true,
                TwoFactorEnabled = true,
                AccessFailedCount = 366,
                Name = "Supplier_Name",
                Email = "Supplier_Email",
                PhoneNumber = "Supplier_PhoneNumber",
                LockoutEndDate = now,
            };
            var _supplier_supplier2_economicevaluations = new DSS5_SupplyChainFinancialsOptimisation.BO.Supplier
            {
                SupplierId = 6413,
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
                EvaluationCountResult = 5337,
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
                UserName = "0423be72-be8a-41ee-807a-141fa18d973aSupplier_UserName",
                PasswordHash = "Supplier_PasswordHash",
                SecurityStamp = "Supplier_SecurityStamp",
                EmailConfirmed = true,
                LockoutEnabled = true,
                PhoneNumberConfirmed = true,
                TwoFactorEnabled = true,
                AccessFailedCount = 6184,
                Name = "Supplier_Name",
                Email = "Supplier_Email",
                PhoneNumber = "Supplier_PhoneNumber",
                LockoutEndDate = now,
            };
            new PersistenceSpecification<DSS5_SupplyChainFinancialsOptimisation.BO.SupplierUploads>(Session)
            .CheckProperty(p => p.Path, "SupplierUploads_Path")
            .CheckReference(p => p.Supplier, _supplier_supplier_financialstatements)
            .CheckReference(p => p.Supplier2, _supplier_supplier2_economicevaluations)
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `SupplierUploads`")]
        [Order(1)]
        public void SupplierUploads_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS5_SupplyChainFinancialsOptimisation.BO.SupplierUploads> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.SupplierUploads>(
                              a => true
                              && (a.Path != string.Empty && a.Path != null)
                              && a.Supplier != null
                              && a.Supplier2 != null
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