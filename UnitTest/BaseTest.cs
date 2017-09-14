using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Ploeh.AutoFixture;
using Respawn;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;


namespace UnitTest
{

    [ExcludeFromCodeCoverage]
    public class BaseTest
    {
        protected readonly Fixture _fixture;

        public BaseTest()
        {
            _fixture = new Fixture();
        }

        [SetUp]
        public void SetUp()
        {
            this.DeleteData();
            this.SeedData();
        }

        private void DeleteData()
        {
            var _checkpoint = new Checkpoint
            {
                TablesToIgnore = new[]
                {
                    "sysdiagrams",
                    "_migrationHistory"
                }
            };

            _checkpoint.Reset(ConfigurationManager.ConnectionStrings["DTPdb"].ConnectionString);
        }

        private void SeedData()
        {/*
            using (var ctx = new DTPdbContext())
            {
                var userData = _fixture.Build<UserData>()
                    .With(x => x.Id, FakeUser.Id)
                    .With(x => x.Email, FakeUser.Email)
                    .Create();

                ctx.Users.Add(userData);

                ctx.SaveChanges();
            }*/
        }
    }
}
