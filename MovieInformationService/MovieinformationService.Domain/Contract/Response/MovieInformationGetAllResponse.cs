using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieInformationService.Domain
{
    public class MovieInformationGetAllResponse
    {
        public  List<MovieInformationGetAllDto> GetAllMovieInformations { get; set; }
    }
}
