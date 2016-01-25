using System;
using System.Data.Entity;
using NUnit.Framework;
using Library.Storage;

namespace Library.Tests.Integration.Storage
{
    public class BaseRepositoryTests
    {
        protected static Func<DbContext> DbContextFactory;

        [TestFixtureSetUp]
        public void FixtureSetUp()
        {
            DbContextFactory = () => new DbContext("IntegrationTestsConnectionString");
            Database.SetInitializer(new DropCreateDatabaseAlways<DbContext>());
            DbContextFactory().Database.Initialize(true);
        }
    }
}