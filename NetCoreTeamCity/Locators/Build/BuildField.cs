﻿using System.Collections.Generic;

namespace NetCoreTeamCity.Locators.Build
{
    public class BuildField
    {
        private readonly List<string> _fields;

        internal BuildField()
        {
            _fields = new List<string>() { "buildTypeId", "href", "id", "number", "state", "status", "webUrl" };
        }

        public BuildField BranchName()
        {
            _fields.Add("branchName");
            return this;
        }

        public BuildField QueuedDate()
        {
            _fields.Add("queuedDate");
            return this;
        }

        public BuildField StartDate()
        {
            _fields.Add("startDate");
            return this;
        }

        public BuildField FinishDate()
        {
            _fields.Add("finishDate");
            return this;
        }

        public BuildField StatusText()
        {
            _fields.Add("statusText");
            return this;
        }

        public BuildField Revisions()
        {
            _fields.Add("revisions");
            return this;
        }

        public BuildField BuildType()
        {
            _fields.Add("buildType");
            return this;
        }

        public BuildField Triggered()
        {
            _fields.Add("triggered");
            return this;
        }

        public BuildField LastChanges()
        {
            _fields.Add("lastChanges(change)");
            return this;
        }

        public BuildField Agent()
        {
            _fields.Add("agent");
            return this;
        }

        public BuildField Properties()
        {
            _fields.Add("properties(property)");
            return this;
        }

        public BuildField TestOccurrences()
        {
            _fields.Add("testOccurrences");
            return this;
        }

        public BuildField PersonalFlag()
        {
            _fields.Add("personal");
            return this;
        }

        public BuildField Comment()
        {
            _fields.Add("comment");
            return this;
        }

        public BuildField RunningInfo()
        {
            _fields.Add("running-info");
            return this;
        }

        internal string GetFieldsQueryString()
        {
            return $"build({string.Join(",", _fields)})";
        }
    }
}
