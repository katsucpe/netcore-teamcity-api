﻿using System.Net;
using NetCoreTeamCity.Clients;
using NetCoreTeamCity.Exceptions;
using NetCoreTeamCity.Models;

namespace NetCoreTeamCity.Services
{
    internal class BuildService : IBuildService
    {
        private readonly ITeamCityApiClient _apiClient;

        public BuildService(ITeamCityApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public Build Get(long buildId)
        {
            try
            {
                return _apiClient.Get<Build>($"builds/id:{buildId}");
            }
            catch (HttpException exception)
            {
                if (exception.StatusCode == HttpStatusCode.NotFound) return null;
                throw;
            }
        }
    }
}
