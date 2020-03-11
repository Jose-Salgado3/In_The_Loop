using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InTheLoop.Models
{
    public class FriendsAssociation
    {
        /// <summary>
        /// FriendsAssociationId is the auto generated PK that will represent each
        /// individual relationship that is stored in the database. Each 
        /// FriendAssociation call will only compare two users at a time.
        /// </summary>
        public int FriendsAssociationId { get; set; }

        /// <summary>
        /// UserId will represent the first user that is being examined in the 
        /// FriendsAssociation table.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// FriendId will the UserId of the second user that is being examined in 
        /// the FriendsAssociation table.
        /// </summary>
        public int FriendId { get; set; }

        /// <summary>
        /// FriendsAssociationStatus is responsible for storing a variable 0 - 4 representing
        /// the relationship of two Users.
        /// 0 - represents a pending friend request
        /// 1 - represents an accepted friend request
        /// 2 - represents that a user is blocked by the other user
        /// 3 - represents that the user recieving the request has declined being friends.
        /// </summary>
        public byte FriendsAssociationStatus { get; set; }

        /// <summary>
        /// FriendsAssociationActionStatus will store the UserId of the last member to interact
        /// in the friend requesting process with another user. If User1 sent a request t User2
        /// and User2 has not responded then this property would be User1's UserId.
        /// </summary>
        public int FriendsAssociationActionStatus { get; set; }
    }
}
