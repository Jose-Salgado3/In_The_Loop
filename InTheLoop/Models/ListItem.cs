using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace InTheLoop.Models
{
    public class ListItem
    {

        public int ListItemId { get; set; }

        public int  ListId { get; set; }

        public int ListItemCreatorId { get; set; }

        public string ListItemTitle { get; set; }

        public byte ListItemUrgency { get; set; }

        public byte ListItemIsChecked { get; set; }

        public string ListItemDescription { get; set; }

        public DateTime ListItemAddDate { get; set; }
    }
}
