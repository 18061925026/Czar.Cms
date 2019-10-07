using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simple001.Models
{
    public class Content
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ContentData { get; set; }
        public int Status { get; set; }
        public DateTime AddTime { get; set; }
        public DateTime ModifyTime { get; set; }
    }
}
