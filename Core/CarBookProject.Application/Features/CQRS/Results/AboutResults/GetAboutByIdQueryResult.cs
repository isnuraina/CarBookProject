using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.CQRS.Results.AboutResults
{
    public class GetAboutByIdQueryResult
    {
        public int AboutID { get; set; }
        public int Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
