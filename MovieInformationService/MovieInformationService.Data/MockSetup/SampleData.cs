using MovieInformationService.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieInformationService.Data.MockSetup
{
    public class SampleData
    {
        public MovieInformationGetAllResponse Movieinfo()
        {

            MovieInformationGetAllResponse movieInfoDataModel = new MovieInformationGetAllResponse()
            {
                GetAllMovieInformations = new List<MovieInformationGetAllDto>()
                    {
                        new MovieInformationGetAllDto()
                        {
                            MovieId = 2,
                            MovieName = "Don",
                            DateOfrelease = "20/12/2022",
                            Producer = "Cibi",
                            Actors = new List<Domain.Actors>()
                            {
                                new Domain.Actors()
                                {
                                    ActorsName = "Siva"
                                },
                                new Domain.Actors()
                                {
                                    ActorsName = "Vijay"
                                },
                                new Domain.Actors()
                                {
                                    ActorsName = "Bala"
                                },
                                new Domain.Actors()
                                {
                                    ActorsName = "SJ Surya"
                                },
                            }

                        },
                        new MovieInformationGetAllDto()
                        {
                            MovieId = 2,
                            MovieName = "KGF 3",
                            DateOfrelease = "20/12/2022",
                            Producer = "Prashanth Neel",
                            Actors = new List<Domain.Actors>()
                            {
                                new Domain.Actors()
                                {
                                    ActorsName = "Yash"
                                },
                                new Domain.Actors()
                                {
                                    ActorsName = "Ravi"
                                },
                                new Domain.Actors()
                                {
                                    ActorsName = "PrakashRaj"
                                },
                                new Domain.Actors()
                                {
                                    ActorsName = "Srinidhi Shetty"
                                },
                            }

                        }
                    }
            };

            return movieInfoDataModel;
        }
    }
}
