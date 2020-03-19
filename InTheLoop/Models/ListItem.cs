using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace InTheLoop.Models
{
    public enum Urgency
    {
        High,
        Moderate,
        Normal,
        Low,
        Lowest
    }

    /// <summary>
    /// The ListItem class represents the properties needed to add a ListItem to a list.
    /// </summary>
    public class ListItem
    {

        /// <summary>
        /// ListItemId will be the auto generated Id that will be used to reference a single
        /// list.
        /// </summary>
        [Required]
        public int ListItemId { get; set; }

        /// <summary>
        /// ListId is the Id of the list that the ListItem is being added to.
        /// </summary>
        [Required]
        public int ListId { get; set; }

        /// <summary>
        /// ListItemCreatorId will store the UserId of the User that is adding the ListItem
        /// to the list. This will allow us to keep truck of who added what.
        /// </summary>
        [Required]
        public int ListItemCreatorId { get; set; }

        /// <summary>
        /// ListItemTitle will be the title or name of the ListItem that is to be added to 
        /// the list.
        /// </summary>
        [Required]
        [StringLength(90)]
        public string ListItemTitle { get; set; }

        /// <summary>
        /// ListItemUrgency will use a bite value to correlate with a dropdown list
        /// on the website to store values of urgency with 0 being the most urgent
        /// and 4 being the least urgent.
        /// </summary>
        [Required]
        public Urgency ListItemUrgency { get; set; }

        /// <summary>
        /// ListItemChecked will return true or false for whether or not the 
        /// ListItem has been checked off or not (is no longer needed).
        /// </summary>
        [Required]
        public bool ListItemIsChecked { get; set; }

        /// <summary>
        /// ListItemDescription is a description of the ListItem to be added to the list.
        /// </summary>
        [StringLength(256)]
        public string ListItemDescription { get; set; }

        /// <summary>
        /// ListItemAddDate will store a date time value for when the ListItem
        /// was added to the list.
        /// </summary>
        [Required]
        public DateTime ListItemAddDate { get; set; }
    }
}
