using AutoMapper;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class Visitor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(50)", Order = 2)]
        public string Ip { get; set; }

        [Column(TypeName = "nvarchar(50)", Order = 3)]
        public string PlatformName { get; set; }

        [Column(TypeName = "nvarchar(20)", Order = 4)]
        public string PlatformType { get; set; }

        [Column(TypeName = "nvarchar(10)", Order = 5)]
        public string PlatformVersion { get; set; }

        [Column(TypeName = "nvarchar(50)", Order = 6)]
        public string BrowserName { get; set; }

        [Column(TypeName = "nvarchar(10)", Order = 7)]
        public string BrowserVersion { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "datetime2", Order = 8)]
        [Required]
        public DateTime CreatedAt { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "datetime2", Order = 9)]
        public DateTime? ModifiedAt { get; set; }

        [Column(TypeName = "int", Order = 10)]
        [Required]
        [DefaultValue(1)]
        public int Status { get; set; }
    }
}
