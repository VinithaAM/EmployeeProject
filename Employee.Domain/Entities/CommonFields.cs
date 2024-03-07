using System.ComponentModel.DataAnnotations.Schema;

namespace Employee.Domain.Entities
{
    public class CommonFields
    {
        [Column("CreatedBy")]
        public int? CreatedBy { get; set; }
        [Column("Created_Datetime")]
        public DateTime? CreatedDateTime {  get; set; }
        [Column("ModifiedBy")]
        public int? ModifiedBy { get; set;}
        [Column("Modified_Datetime")]
        public DateTime? ModifiedDateTime { get; set; }
        [Column("DeletedBy")]
        public int? DeletedBy { get; set;}
        [Column("Deleted_Datetime")]
        public DateTime? DeletedDateTime { get; set; }  

    }
}
