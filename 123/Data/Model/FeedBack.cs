using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _123
{
    public class FeedBack
    {
        [Key]
        public int FeedBackId { get; set; }

        [Required]
        public string FeedBackMessage { get; set; }
        public DateTime PostDate { get; set; }
        public byte[] FeedBackImage { get; set; }


        [Required]
        public int UsersId { get; set; }
        [ForeignKey("UsersId")]
        public Users Users { get; set; }

  
        //[Required]
        //public int IventsId { get; set; }
        //[ForeignKey("IventsId")]
        //public Ivents Ivents { get; set; }


        public FeedBack()
        {

        }

        public string GetShortDate()
        {
            return PostDate.ToShortDateString();
        }
    }
}
