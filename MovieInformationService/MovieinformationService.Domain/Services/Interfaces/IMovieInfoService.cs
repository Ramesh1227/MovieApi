﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieInformationService.Domain;

namespace MovieinformationService.Domain.Services.Interfaces
{
    public interface IMovieInfoService
    {
        Task<MovieInformationGetAllResponse> GetAllMovieInformation();

        Task<MovieInformationCreateResponse> CreateMovieInformation(MovieInformationCreateRequest request);

        Task<MovieInformationEditResponse> EditMovieInformation(MovieInformationEditRequest request);
    }
}

