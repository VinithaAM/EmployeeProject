using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Employee.Domain.Entities
{
    public class User:CommonFields
    {
        [Key,Column("Id")]
        public int Id { get; set; }
        [ Column("FirstName")]
        public string? FirstName { get; set; }
        [Column("LastName")]
        public string? LastName { get; set; }
        [Column("EmployeeId")]
        public string? EmployeeId {  get; set; }
        [Column("DateOfBirth")]
        public DateTime? DateOfBirth { get; set; }
        [Column("Age")]
        public int? Age { get; set; }
        [Column("Gender")]
        public string? Gender { get; set; }
        [Column("PhoneNumber")]
        public string? PhoneNumber {  get; set; }
        [Column("Email")]
        public string? Email { get; set; }
        [Column("User_Status")]
        public bool? UserStatus { get; set; }
        [Column("Account_Type")]
        public string? AccountType {  get; set; }
        [Column("Password")]
        public string? Password {  get; set; }
        [Column("Enable_TwoFactor")]
        public bool? EnableTwoFactor { get; set; }
        [Column("Status")]
        public bool? Status { get;set; }

    }
}
