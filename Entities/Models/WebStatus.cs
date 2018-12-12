using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    [Table("status")]
    public class WebStatus
    {
        [Key]
        public Guid StatusId { get; set; }

        public string StatusText { get; set; }

        [StringLength(3, ErrorMessage = "StatusCode cannot be longer than 3 characters")]
        public string StatusCode { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [ForeignKey("WebSiteInfo")]
        public Guid? WebSiteId { get; set; }
        public virtual WebSiteInfo WebSiteInfo { get; set; }
    }
}
