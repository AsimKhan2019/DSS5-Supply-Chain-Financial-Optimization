// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).

using System;
using log4net;
using NUnit.Framework;

namespace DSS5_SupplyChainFinancialsOptimisation.BoTesting.Tests.Common
{
    internal class BaseFixture
    {
        protected static ILog Log = new Func<ILog>(() =>
        {
#if NETFRAMEWORK
            log4net.Config.XmlConfigurator.Configure();
#else
            var logRepository = log4net.LogManager.GetRepository(System.Reflection.Assembly.GetEntryAssembly());
            log4net.Config.XmlConfigurator.Configure(logRepository, new System.IO.FileInfo("log4net.config"));
#endif
            return LogManager.GetLogger(typeof(BaseFixture));
        }).Invoke();
        protected virtual void OnFixtureSetup() { }
        protected virtual void OnFixtureTeardown() { }
        protected virtual void OnSetup() { }
        protected virtual void OnTeardown() { }
        [OneTimeSetUp]
        public void FixtureSetup()
        {
            OnFixtureSetup();
        }
        [OneTimeTearDown]
        public void FixtureTeardown()
        {
            OnFixtureTeardown();
        }
        [SetUp]
        public void Setup()
        {
            OnSetup();
        }
        [TearDown]
        public void Teardown()
        {
            OnTeardown();
        }
    }
}
