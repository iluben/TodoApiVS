using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApiVS.Models
{
    /// <summary>
    /// Class use like model
    /// </summary>
    public class Films
    {
        //ID
        public long Id { get; set; }

        //Name
        public string Name { get; set; }

        //Category
        public string Category { get; set; }

        //Release date
        public DateTime ReleaseDate { get; set; }

        //
        public bool IsComplete { get; set; }

    }
}
