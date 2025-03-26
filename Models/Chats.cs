using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengerWebAPIFrontend.Models
{
    public class Chats
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Users> Users { get; set; }
        public bool FaceToFace { get; set; }
    }
}
