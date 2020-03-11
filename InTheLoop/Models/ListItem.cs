using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace InTheLoop.Models
{
    /// <summary>
    /// The ListItem class represents the properties needed to add a ListItem to a list.
    /// </summary>
    public class ListItem
    {

        /// <summary>
        /// ListItemId will be the auto generated Id that will be used to reference a single
        /// list.
        /// </summary>
        public int ListItemId { get; set; }

        /// <summary>
        /// ListId is the Id of the list that the ListItem is being added to.
        /// </summary>
        public int  ListId { get; set; }

        /// <summary>
        /// ListItemCreatorId will store the UserId of the User that is adding the ListItem
        /// to the list. This will allow us to keep truck of who added what.
        /// </summary>
        public int ListItemCreatorId { get; set; }

        /// <summary>
        /// ListItemTitle will be the title or name of the ListItem that is to be added to 
        /// the list.
        /// </summary>
        public string ListItemTitle { get; set; }

        /// <summary>
        /// ListItemUrgency will use a bite value to correlate with a dropdown list
        /// on the website to store values of urgency with 0 being the least urgent
        /// and 4 being the most urgent.
        /// </summary>
        public byte ListItemUrgency { get; set; }

        /// <summary>
        /// ListItemChecked will return true or false for whether or not the 
        /// ListItem has been checked off or not (is no longer needed).
        /// </summary>
        public bool ListItemIsChecked { get; set; }

        /// <summary>
        /// ListItemDescription is a description of the ListItem to be added to the list.
        /// </summary>
        public string ListItemDescription { get; set; }

        /// <summary>
        /// ListItemAddDate will store a date time value for when the ListItem
        /// was added to the list.
        /// </summary>
        public DateTime ListItemAddDate { get; set; }
    }
}
