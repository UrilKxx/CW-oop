using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123
{
    public class Ivents
    {
        [Key]
        public int IventId { get; set; }
        public string IventName { get; set; }
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public DateTime IventDate { get; set; }
        public DateTime IventDateBegin { get; set; }
        public DateTime IventDateEnd { get; set; }
        
        public int FeedBackId { get; set; }
        [ForeignKey("FeedBackId")]
        public FeedBack FeedBack { get; set; }

        public Ivents()
        {

        }

        public Ivents(string iventname, string description, byte[] image, DateTime iventDate)
        {
            IventName = iventname;
            Description = description;
            Image = image;
            IventDate = iventDate;
        }
    }
}
