using System;
using InTheLoop.Models;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InTheLoop.Models
{
    public class List
    {
        /// <summary>
        /// The auto-generated Id for the list being used or created
        /// </summary>

        [Key]
        public int ListId { get; set; }

        /// <summary>
        /// The Id(User) for the User that created the list
        /// </summary>
        [Required]
        public int ListCreatorId { get; set; }

        /// <summary>
        /// The Title or name of the list being used or created.
        /// </summary>
        [Required]
        [StringLength(90)]
        public string ListTitle { get; set; }

        /// <summary>
        /// The date and time that the specific list was created
        /// </summary>
        [Required]
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// The date and time the list is due or time is up to complete the list.
        /// </summary>
        public DateTime EndDate { get; set; }
    }
}
