using System.ComponentModel.DataAnnotations;

namespace BlazorLearning.Domain
{
    public class Master_Inventory_Record
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string PartCode { get; set; }
        [Required]
        public string NameOfPart { get; set; }
        public int? Qty { get; set; }
        public decimal? CostPerUnit { get; set; }
        [Required]
        public DateTime LastEditedTime { get; set; }
        public string? EmployeeId { get; set; }

        public string? Category1 { get; set; }
        public string? Category2 { get; set; }
        public string? Category3 { get; set; }
        public string? Category4 { get; set; }
        public string? DescriptionB { get; set; }

        public string? Division { get; set; }
        public string? QSLGroup { get; set; }

        public string? Location { get; set; }
        public string? SubLocation { get; set; }
    }
}
