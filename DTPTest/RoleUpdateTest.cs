
using Dreamer.HR;
using NUnit.Framework;
using Ploeh.AutoFixture;

namespace Dreamer.HR.Test
{
    [TestFixture]
    public class RoleUpdateTest : BaseTest
    {
        [Test]
        public void Should_UpdateData()
        {
            var roleModel = _fixture.Build<Role>()
                        .With(x => x.RoleName, "Admin")
                        .With(x => x.RoleCode, "A")
                        .With(x => x.RoleDescription, "Admin user")
                        .Create();

         
        }
    }
}
