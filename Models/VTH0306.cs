using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace VuThiHuyen306.Models{
    public class VTH0306
    {
         [Key]
    [StringLength(20)]
    public String? VTHId { get; set; }
    [StringLength(50)]
    public string? VTHName { get; set; }
    public Boolean VTHGender { get; set; }
    
       
    }
}