using Dreamer.HR.Models;
using System;

namespace Dreamer.HR.Service
{
    public class RoleAddServiceResult
    {
        public Guid Id { get; set; }

        public RoleAddServiceResult()
        {
        }

        public RoleAddServiceResult(RoleAddModel model)
        {
        }

        public RoleAddServiceResult(Guid id, RoleAddModel model)
        {
        }
    }
    
}
