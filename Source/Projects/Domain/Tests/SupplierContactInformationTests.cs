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
    ///This is a test class for SupplierContactInformationTest and is intended
    ///to contain all SupplierContactInformationTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("SupplierContactInformation Repository Tests")]
    [Category("SupplierContactInformation Repository Tests")]
    internal class SupplierContactInformationTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `SupplierContactInformation`")]
        [Order(0)]
        public void SupplierContactInformation_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            new PersistenceSpecification<DSS5_SupplyChainFinancialsOptimisation.BO.SupplierContactInformation>(Session)
            .CheckProperty(p => p.ContactPerson, "SupplierContactInformation_ContactPerson")
            .CheckProperty(p => p.AddressOne, "SupplierContactInformation_AddressOne")
            .CheckProperty(p => p.AddressTwo, "SupplierContactInformation_AddressTwo")
            .CheckProperty(p => p.Telephone, "SupplierContactInformation_Telephone")
            .CheckProperty(p => p.Email, "SupplierContactInformation_Email")
            .CheckProperty(p => p.ManagingDirector, "SupplierContactInformation_ManagingDirector")
            .CheckProperty(p => p.EstablishedIn, "SupplierContactInformation_EstablishedIn")
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `SupplierContactInformation`")]
        [Order(1)]
        public void SupplierContactInformation_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS5_SupplyChainFinancialsOptimisation.BO.SupplierContactInformation> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.SupplierContactInformation>(
                              a => true
                              && (a.ContactPerson != string.Empty && a.ContactPerson != null)
                              && (a.AddressOne != string.Empty && a.AddressOne != null)
                              && (a.AddressTwo != string.Empty && a.AddressTwo != null)
                              && (a.Telephone != string.Empty && a.Telephone != null)
                              && (a.Email != string.Empty && a.Email != null)
                              && (a.ManagingDirector != string.Empty && a.ManagingDirector != null)
                              && (a.EstablishedIn != string.Empty && a.EstablishedIn != null)
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