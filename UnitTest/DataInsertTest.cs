using NUnit.Framework;

namespace UnitTest
{
    [TestFixture]
    class DataInsertTest: BaseTest
    {
        [Test]
        public void Should_InsertData()
        {/*
            var model = _fixture.Build<Role>()
                        .With(x => x.RoleName, "Admin")
                        .With(x => x.RoleCode, "A")
                        .Create();
                /*
                Fixture.Build<Role>()
                        .With(x => x.RoleId, FakeUser.Id)
                        .Create();*/

        }
    }
}
