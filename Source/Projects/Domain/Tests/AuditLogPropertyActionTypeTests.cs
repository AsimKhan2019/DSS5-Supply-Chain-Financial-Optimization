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
    ///This is a test class for AuditLogPropertyActionTypeTest and is intended
    ///to contain all AuditLogPropertyActionTypeTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("AuditLogPropertyActionType Repository Tests")]
    [Category("AuditLogPropertyActionType Repository Tests")]
    internal class AuditLogPropertyActionTypeTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `AuditLogPropertyActionType`")]
        [Order(0)]
        public void AuditLogPropertyActionType_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            new PersistenceSpecification<zAppDev.DotNet.Framework.Auditing.Model.AuditLogPropertyActionType>(Session)
            .CheckProperty(p => p.Code, "AuditLogPropertyActionType_Code")
            .CheckProperty(p => p.Name, "AuditLogPropertyActionType_Name")
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `AuditLogPropertyActionType`")]
        [Order(1)]
        public void AuditLogPropertyActionType_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<zAppDev.DotNet.Framework.Auditing.Model.AuditLogPropertyActionType> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<zAppDev.DotNet.Framework.Auditing.Model.AuditLogPropertyActionType>(
                              a => true
                              && (a.Code != string.Empty && a.Code != null)
                              && (a.Name != string.Empty && a.Name != null)
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