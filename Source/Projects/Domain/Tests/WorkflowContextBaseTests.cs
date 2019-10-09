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
    ///This is a test class for WorkflowContextBaseTest and is intended
    ///to contain all WorkflowContextBaseTest NUnit Tests
    ///</summary>
    [TestFixture]
    [Description("WorkflowContextBase Repository Tests")]
    [Category("WorkflowContextBase Repository Tests")]
    internal class WorkflowContextBaseTests : NHibernateFixture
    {
        /// <summary>
        ///A test for testing the persistence of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the persistence of `WorkflowContextBase`")]
        [Order(0)]
        public void WorkflowContextBase_persistence_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var _workflowbo_result_context = new zAppDev.DotNet.Framework.Workflow.WorkflowExecutionResult
            {
            };
            new PersistenceSpecification<zAppDev.DotNet.Framework.Workflow.WorkflowContextBase>(Session)
            .CheckProperty(p => p.Name, "WorkflowContextBase_Name")
            .CheckProperty(p => p.Error, "WorkflowContextBase_Error")
            .CheckProperty(p => p.Expires, true)
            .CheckProperty(p => p.ExpirationDateTime, now)
            .CheckProperty(p => p.PendingSince, now)
            .CheckProperty(p => p.PendingJobCreatedBy, "WorkflowContextBase_PendingJobCreatedBy")
            .CheckProperty(p => p.PendingStep, "WorkflowContextBase_PendingStep")
            .VerifyTheMappings();
        }

        /// <summary>
        ///A test for testing the filtering of an object from Db
        ///</summary>
        [Test]
        [Description("This tests the filtering of `WorkflowContextBase`")]
        [Order(1)]
        public void WorkflowContextBase_filtering_test()
        {
            DateTime now = DateTime.Now;
            // Get datetime without milliseconds
            now = new DateTime(now.Ticks - (now.Ticks % TimeSpan.TicksPerSecond), now.Kind);
            var repo = new Repository(Session);
            List<zAppDev.DotNet.Framework.Workflow.WorkflowContextBase> results = null;
            Assert.DoesNotThrow(() =>
            {
                results = repo.GetAsQueryable<zAppDev.DotNet.Framework.Workflow.WorkflowContextBase>(
                              a => true
                              && (a.Name != string.Empty && a.Name != null)
                              && (a.Error != string.Empty && a.Error != null)
                              && !a.Expires
                              && a.ExpirationDateTime.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && a.PendingSince.GetValueOrDefault().Date <= DateTime.UtcNow.Date
                              && (a.PendingJobCreatedBy != string.Empty && a.PendingJobCreatedBy != null)
                              && (a.PendingStep != string.Empty && a.PendingStep != null)
                              && a.Status == zAppDev.DotNet.Framework.Workflow.WorkflowStatus.None
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