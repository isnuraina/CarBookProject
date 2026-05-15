using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.CQRS.Commands.AboutCommands
{
    public class CreateAboutCommand
    {
        public int Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
