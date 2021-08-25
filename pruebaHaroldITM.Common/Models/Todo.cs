    using System;
using System.Collections.Generic;
using System.Text;

namespace pruebaHaroldITM.Common.Models
{
    public  class Todo
    {
        public DateTime CreateTime { get; set; }

        public string TaskDecription { get; set; }

        public bool IsCompleted { get; set; }
    }
}
