using MovieinformationService.Domain.Data;
using MovieinformationService.Domain.DataEntities;
using MovieInformationService.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieInformationService.Data.Data
{
    public class MovieInfoData : IMovieInfoData
    {

        public async Task<MovieInformationGetAllResponse> GetAllMovieInformationData()
        {
            return new MovieInformationGetAllResponse();
        }
    }
}
