using MovieInformationService.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieinformationService.Domain.Data
{
    public interface IMovieInfoData
    {
       Task<MovieInformationGetAllResponse> GetAllMovieInformationData();

        Task<MovieInformationCreateResponse> CreateMovieInformationData( MovieInformationCreateRequest request);

        Task<MovieInformationEditResponse> EditMovieInformationData(MovieInformationEditRequest request);
    }
}
