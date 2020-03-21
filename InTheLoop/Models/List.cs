using System;
using InTheLoop.Models;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

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
        
        public int ListCreatorId { get; set; }

        /// <summary>
        /// The Title or name of the list being used or created.
        /// </summary>
        [Required]
        [StringLength(90)]
        public string ListTitle { get; set; }

        /// <summary>
        /// Private Nullable datetime helper for the DateCreated Property
        /// </summary>
        private DateTime? dateCreated;

        /// <summary>
        /// The DateCreated uses helper method above to set DateCreated to the datetime.now
        /// that the file was added to the database.
        /// </summary>
        public DateTime DateCreated
        { 
            get{ return dateCreated ?? DateTime.Now; } 
            set{ dateCreated = value; }
        }
        /// <summary>
        /// The date and time the list is due or time is up to complete the list.
        /// </summary>
        public DateTime EndDate { get; set; }
    }
}
