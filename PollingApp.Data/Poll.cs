using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PollingApp.Data
{
    public class Poll
    {
        [Key]
        public int PollId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        //[Required]
        //public int OwnerId { get; set; }

        [Required]
        public string PollQuestion { get; set; }

        [Required]
        public bool PublishFlag { get; set; }

        [Required]
        public int ResponseMultiFlag { get; set; }// 0 means unlimited responses, 1 and up to max is how many the user can choose
        //Response_multiFlag
    }
}
