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
    ///This is a test class for PreferencesTest and is intended
    ///to contain all PreferencesTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("Preferences Repository Tests")]
    [Category("Preferences Repository Tests")]
    internal class PreferencesTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `Preferences`")]
        [Order(0)]
        public void Preferences_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            new PersistenceSpecification<DSS5_SupplyChainFinancialsOptimisation.BO.Preferences>(Session)
            .CheckProperty(p => p.Currency, "Preferences_Currency")
            .CheckProperty(p => p.UnitOfMeasure, "Preferences_UnitOfMeasure")
            .CheckProperty(p => p.Date, "Preferences_Date")
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `Preferences`")]
        [Order(1)]
        public void Preferences_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<DSS5_SupplyChainFinancialsOptimisation.BO.Preferences> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<DSS5_SupplyChainFinancialsOptimisation.BO.Preferences>(
                              a => true
                              && (a.Currency != string.Empty && a.Currency != null)
                              && (a.UnitOfMeasure != string.Empty && a.UnitOfMeasure != null)
                              && (a.Date != string.Empty && a.Date != null)
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