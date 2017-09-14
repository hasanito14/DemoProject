using NUnit.Framework;
using Ploeh.AutoFixture;
using BLL.Models;
using BLL.Service;

namespace DTPTest
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

            var service = new RoleBs();
            var result = service.Insert(roleModel).Result;
           
            Assert.IsTrue(result);

        }
        
    }
}


