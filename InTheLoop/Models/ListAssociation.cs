using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InTheLoop.Models
{
    /// <summary>
    /// Any user of this application that is invited to a list or creates a list will have
    /// a table referencing the list they are associated with and what the status of the 
    /// user with the list is (Pending, Accepted, Declined).
    /// </summary>
    public class ListAssociation
    {
        /// <summary>
        /// The auto generated int that also serves as the Primary Key of this class. This
        /// property stores a reference of a List to User relationship.
        /// </summary>
        [Required]
        public int ListAssociationId { get; set; }

        /// <summary>
        /// The Id of the list that you will be referenceing through this data table.
        /// </summary>
        [Required]
        public int ListId { get; set; }

        /// <summary>
        /// The Users Id that is being checked in reference to the list
        /// </summary>
        [Required]
        public int UserID { get; set; }

        /// <summary>
        /// Using a value between 0 and 2 we can reference whether or not the user
        /// has been invited to the list and what there status is in respect to 
        /// being a member of a list.
        /// 0 - Pending
        /// 1 - Accepted(part of the list)
        /// 2 - Denied ( rejected the invite to the list)
        /// </summary>
        [Required]
        public byte ListAssociationStatus { get; set; }

        /// <summary>
        /// ListAssociationActionStatus will show the UserId of the last person to interact with
        /// the invitation to a list. IE if someone invites someone else to a list the person who invited
        /// the other user will have their Id displayed. When that person responds to that invitation then it
        /// will show the user who responded. Whoever is last to interact. I am not sure if this property is
        /// completely neccessary but if not it will not affect functionality of the DB.
        /// </summary>
        [Required]
        public int ListAssociationActionStatus { get; set; }
    }
}
