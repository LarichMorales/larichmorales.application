using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LarichMorales.LM.Web.Infrastructure.Helpers
{
    public class BaseModels
    {
         public Guid? Id { get; set; }
         public DateTime Timestamp { get; set; }
        public BaseModels()
        {
            this.Timestamp = DateTime.UtcNow;
        }
    }
}
