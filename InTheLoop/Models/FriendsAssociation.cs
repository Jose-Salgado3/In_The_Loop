using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InTheLoop.Models
{
    public class FriendsAssociation
    {

        public int FriendsAssociationId { get; set; }

        public int UserId { get; set; }

        public int FriendId { get; set; }

        public byte FriendsAssociationStatus { get; set; }

        /// <summary>
        /// FriendsAssociationActionStatus will store the UserId of the last member to interact
        /// in the friend requesting process with another user. If User1 sent a request t User2
        /// and User2 has not responded then this property would be User1's UserId.
        /// </summary>
        public int FriendsAssociationActionStatus { get; set; }
    }
}
