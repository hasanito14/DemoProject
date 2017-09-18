using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dreamer.HR
{
    [Table("Role", Schema = "HRdbContext")]
    public partial class Role : BaseData
    {
        [Key]
        public Guid RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleCode { get; set; }
        public string RoleDescription { get; set; }

        public virtual IEnumerable<Employee> Employees { get; set; }
    }
}
