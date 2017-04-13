﻿using NetCoreTeamCity.Clients;
using NetCoreTeamCity.Exceptions;

namespace NetCoreTeamCity.Services
{
    internal class BuildPinningService : IBuildPinningService
    {
        private readonly ITeamCityApiClient _apiClient;

        public BuildPinningService(ITeamCityApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public void Pin(long buildId, string comment = null)
        {
            _apiClient.Put(GetUri(buildId), comment);
        }

        public void UnPin(long buildId, string comment = null)
        {
            _apiClient.Delete(GetUri(buildId), comment);
        }

        public bool IsPinned(long buildId)
        {
            var result = _apiClient.Get<string>(GetUri(buildId));
            bool isPinned;
            if (bool.TryParse(result, out isPinned)) return isPinned;
            throw new UnexpectedApiResponseException($"TeamCity API response was \"{result}\", exptected it to be \"true\"/\"false\"");
        }

        private string GetUri(long buildId)
        {
            return $"builds/{buildId}/pin/";
        }
    }
}
