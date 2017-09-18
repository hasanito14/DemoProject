using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dreamer.HR
{
    [Table ("Employee", Schema = "HRdbContext")]
    public partial class Employee : BaseData
    {
        [Key]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string EmployeeId { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Email { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Password { get; set; }

        [NotMapped]
        public string ConfirmPassword { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public DateTime DOJ { get; set; }
        public string Designation { get; set; }
        public double? TotalExp { get; set; }
        public double? RelevantExp { get; set; }
        public string BankName { get; set; }
        public string IFSCCode { get; set; }
        public string AcNo { get; set; }
        public string PAN { get; set; }
        public Guid RoleId { get; set; }

        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }
    }
}


