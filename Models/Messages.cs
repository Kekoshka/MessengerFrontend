using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengerWebAPIFrontend.Models
{
    class Messages
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ChatId { get; set; }
        DateTime Created { get; set; }
        public string Message { get; set; }
        public byte[] Image { get; set; }
        public byte[] Audio { get; set; }
        public byte[] Video { get; set; }
    }
}
