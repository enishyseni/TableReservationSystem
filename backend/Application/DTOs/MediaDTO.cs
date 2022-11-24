using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class MediaDTO : BaseDTO
    {
        public string FilePath { get; set; }

        public int SortOrder { get; set; }
    }
}