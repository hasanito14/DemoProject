using NUnit.Framework;
using Ploeh.AutoFixture;
using BOL;
using BLL;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Collections;

namespace DTPTest
{
    [TestFixture]
    public class DataInsertTest: BaseTest
    {
        [Test]
        public async Task Should_InsertData()
        {
            
            var roleModel = _fixture.Build<Role>()
                        .With(x => x.RoleName, "Admin")
                        .With(x => x.RoleCode, "A")
                        .With(x => x.RoleDescription, "Admin user")
                        .Without(x => x.Employees)
                        .Create();

            var ctx = new RoleBs();
            ctx.Insert(roleModel);

            var result = await LongRunningTaskAsync();


            

            Assert.AreEqual(1, result);
        }

        private  Task <int> LongRunningTaskAsync()
        {
            var ctx = new RoleBs();
            var result = Task.Run(() => ctx.GetALL().Count);
            
            //int listCount = ((IList)result).Count;
            return result;// Task.FromResult(result.Result);
        }

        
    }
}


/*
 *  var result = await service.Execute(model);
 *  
 *   public async Task<EntityReviewGetAllServiceResult> Execute(EntityReviewGetAllModel model)
        {
            var validator = new EntityReviewGetAllModelValidator();

            await validator.ValidateAndThrowAsync(model);

            var result = new EntityReviewGetAllServiceResult(model);

            result.Items = await _context.EntityReviews.ToListAsync();

            return result;
        }


 * public async Task MyMethodAsync()
{
    Task<int> longRunningTask = LongRunningOperationAsync();
    // independent work which doesn't need the result of LongRunningOperationAsync can be done here

    //and now we call await on the task 
    int result = await longRunningTask;
    //use the result 
    Console.WriteLine(result);
}

public async Task<int> LongRunningOperationAsync() // assume we return an int from this long running operation 
{
    await Task.Delay(1000); //1 seconds delay
    return 1;
}
 * */
