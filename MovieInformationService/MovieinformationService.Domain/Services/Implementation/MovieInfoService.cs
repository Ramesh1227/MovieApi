using MovieinformationService.Domain.Data;
using MovieinformationService.Domain.Services.Interfaces;
using MovieInformationService.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieinformationService.Domain.Services.Implementation
{
    public class MovieInfoService : IMovieInfoService
    {
        private readonly IMovieInfoData _movieInfoData;

        public MovieInfoService (IMovieInfoData movieInfoData)
        {
            _movieInfoData = movieInfoData;
        }

        public async Task<MovieInformationGetAllResponse> GetAllMovieInformation()
        {
            var result = await _movieInfoData.GetAllMovieInformationData();
            return result;
        }
    }
}
