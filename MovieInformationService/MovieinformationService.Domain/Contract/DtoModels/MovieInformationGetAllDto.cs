using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieInformationService.Domain
{
    public  class MovieInformationGetAllDto
    {

        public int MovieId { get; set; }

        public string MovieName { get; set; }

        public string DateOfrelease { get; set; }

        public string Producer { get; set; }

        public List<Actors> Actors { get; set; }

    }

    public class Actors
    {
        public string ActorsName { get; set; }
    }
}
