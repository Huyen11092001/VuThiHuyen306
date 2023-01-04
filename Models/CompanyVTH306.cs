using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VuThiHuyen306.Models{
    public class CompanyVTH306
    {
         [Key]
    [StringLength(20)]
    public String? CompanyId { get; set; }
    [StringLength(50)]
    public string? CompanyName { get; set; }
    
       
    }
}