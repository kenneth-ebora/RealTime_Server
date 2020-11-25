using System;
using System.ComponentModel.DataAnnotations;

namespace DHP.Core.Entities
{
    public class ChatBasic
    {
        [Key]
        public int ChatId { get; set; }

        [StringLength(50)]
        public string User { get; set; }

        public string Message { get; set; }

        public DateTime SendDate { get; set; }
    }

    public class Chat : ChatBasic
    {
        public string ConnectionId { get; set; }
    }
}
