using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("website")]
    public class WebSiteInfo
    {
        [Key]
        public Guid WebId { get; set; }

        [Required(ErrorMessage = "Url is required")]
        [DataType(DataType.Url)]
        public string Url { get; set; }

        //add more options
        [ForeignKey("User")]
        public Guid? UserId { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<WebStatus> WebStatus { get; set; }
    }
}
