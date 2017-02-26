﻿using FluentAssertions;
using NetCoreTeamCity.Api;
using NUnit.Framework;

namespace NetCoreTeamCity.Tests.Locators.TestOccurrences
{
    [TestFixture]
    [Category("TestOccurrenceField")]
    public class TestOccurrenceFieldTests
    {
        [Test]
        public void Include_TestOccurrenceFieldDefault()
        {
            // Arrange
            var fields = Include.TestOccurrenceField;
            // Act
            var query = fields.GetFieldsQueryString();
            // Assert
            query.Should().Be("testOccurrence(id,name,status,duration,href)");
        }
        [Test]
        public void Include_Test()
        {
            var fields = Include.TestOccurrenceField.Test();
            var query = fields.GetFieldsQueryString();

            query.Should().Be("testOccurrence(test)");
        }
        [Test]
        public void Include_Build()
        {
            var fields = Include.TestOccurrenceField.Build();
            var query = fields.GetFieldsQueryString();

            query.Should().Be("testOccurrence(build)");
        }
        [Test]
        public void Include_CurrentlyInvestigated()
        {
            var fields = Include.TestOccurrenceField.CurrentlyInvestigated();
            var query = fields.GetFieldsQueryString();

            query.Should().Be("testOccurrence(currentlyInvestigated)");
        }
        [Test]
        public void Include_CurrentlyMuted()
        {
            var fields = Include.TestOccurrenceField.CurrentlyMuted();
            var query = fields.GetFieldsQueryString();

            query.Should().Be("testOccurrence(currentlyMuted)");
        }
        [Test]
        public void Include_Details()
        {
            var fields = Include.TestOccurrenceField.Details();
            var query = fields.GetFieldsQueryString();

            query.Should().Be("testOccurrence(details)");
        }
        [Test]
        public void Include_Duration()
        {
            var fields = Include.TestOccurrenceField.Duration();
            var query = fields.GetFieldsQueryString();

            query.Should().Be("testOccurrence(duration)");
        }
        [Test]
        public void Include_Href()
        {
            var fields = Include.TestOccurrenceField.Href();
            var query = fields.GetFieldsQueryString();

            query.Should().Be("testOccurrence(href)");
        }
        [Test]
        public void Include_Id()
        {
            var fields = Include.TestOccurrenceField.Id();
            var query = fields.GetFieldsQueryString();

            query.Should().Be("testOccurrence(id)");
        }
        [Test]
        public void Include_Ignored()
        {
            var fields = Include.TestOccurrenceField.Ignored();
            var query = fields.GetFieldsQueryString();

            query.Should().Be("testOccurrence(ignored)");
        }
        [Test]
        public void Include_Muted()
        {
            var fields = Include.TestOccurrenceField.Muted();
            var query = fields.GetFieldsQueryString();

            query.Should().Be("testOccurrence(muted)");
        }
        [Test]
        public void Include_Name()
        {
            var fields = Include.TestOccurrenceField.Name();
            var query = fields.GetFieldsQueryString();

            query.Should().Be("testOccurrence(name)");
        }
        [Test]
        public void Include_RunOrder()
        {
            var fields = Include.TestOccurrenceField.RunOrder();
            var query = fields.GetFieldsQueryString();

            query.Should().Be("testOccurrence(runOrder)");
        }
        [Test]
        public void Include_Status()
        {
            var fields = Include.TestOccurrenceField.Status();
            var query = fields.GetFieldsQueryString();

            query.Should().Be("testOccurrence(status)");
        }
        
    }
}
