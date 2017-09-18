using NUnit.Framework;
using Ploeh.AutoFixture;
using Dreamer.HR.Service;
using Dreamer.HR.Models;
using Dreamer.HR;
using System.Linq;

namespace Dreamer.HR.Test
{
    [TestFixture]
    public class RoleInsertTest: BaseTest
    {
        [Test]
        public void Should_InsertData()
        {
            var roleModel = _fixture.Build<RoleAddModel>()
                        .With(x => x.RoleName, "Admin")
                        .With(x => x.RoleCode, "A")
                        .With(x => x.RoleDescription, "Admin user")
                        .Create();

            var service = new RoleAddService();

            var result = service.Execute(roleModel).Result;

            using (var ctx = new HRdbContext())
            {
                var roleData = ctx.Roles.SingleOrDefault(x => x.RoleId == result.Id);
                Assert.IsNotNull(roleData);
                Assert.IsNotNull(roleData.CreatedDate);
                Assert.IsNotNull(roleData.LastModifiedDate);

                Assert.AreEqual(roleModel.RoleCode, roleData.RoleCode);
                Assert.AreEqual(roleModel.RoleDescription, roleData.RoleDescription);
                Assert.AreEqual(roleModel.RoleName, roleData.RoleName);
            }
        }
    }
}


