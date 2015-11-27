﻿using System;
using TechTalk.SpecFlow;
using Telerik.JustMock;
using System.Collections.Generic;
using System.Linq;
using Telerik.JustMock.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using static HackerFinder.Acceptance.ContextRepository;
using HackerFinder.Domain;
namespace HackerFinder.Acceptance
{
    [Binding]
    public class LocationSearchSteps
    {
        private const string WheelingLocationResult = @"{""total_count"":9,""incomplete_results"":false,""items"":[{""login"":""erikdietrich"",""id"":1232840,""avatar_url"":""https://avatars.githubusercontent.com/u/1232840?v=3"",""gravatar_id"":"""",""url"":""https://api.github.com/users/erikdietrich"",""html_url"":""https://github.com/erikdietrich"",""followers_url"":""https://api.github.com/users/erikdietrich/followers"",""following_url"":""https://api.github.com/users/erikdietrich/following{/other_user}"",""gists_url"":""https://api.github.com/users/erikdietrich/gists{/gist_id}"",""starred_url"":""https://api.github.com/users/erikdietrich/starred{/owner}{/repo}"",""subscriptions_url"":""https://api.github.com/users/erikdietrich/subscriptions"",""organizations_url"":""https://api.github.com/users/erikdietrich/orgs"",""repos_url"":""https://api.github.com/users/erikdietrich/repos"",""events_url"":""https://api.github.com/users/erikdietrich/events{/privacy}"",""received_events_url"":""https://api.github.com/users/erikdietrich/received_events"",""type"":""User"",""site_admin"":false,""score"":1.0},{""login"":""haobole"",""id"":361813,""avatar_url"":""https://avatars.githubusercontent.com/u/361813?v=3"",""gravatar_id"":"""",""url"":""https://api.github.com/users/haobole"",""html_url"":""https://github.com/haobole"",""followers_url"":""https://api.github.com/users/haobole/followers"",""following_url"":""https://api.github.com/users/haobole/following{/other_user}"",""gists_url"":""https://api.github.com/users/haobole/gists{/gist_id}"",""starred_url"":""https://api.github.com/users/haobole/starred{/owner}{/repo}"",""subscriptions_url"":""https://api.github.com/users/haobole/subscriptions"",""organizations_url"":""https://api.github.com/users/haobole/orgs"",""repos_url"":""https://api.github.com/users/haobole/repos"",""events_url"":""https://api.github.com/users/haobole/events{/privacy}"",""received_events_url"":""https://api.github.com/users/haobole/received_events"",""type"":""User"",""site_admin"":false,""score"":1.0},{""login"":""NightingaleConant"",""id"":2112348,""avatar_url"":""https://avatars.githubusercontent.com/u/2112348?v=3"",""gravatar_id"":"""",""url"":""https://api.github.com/users/NightingaleConant"",""html_url"":""https://github.com/NightingaleConant"",""followers_url"":""https://api.github.com/users/NightingaleConant/followers"",""following_url"":""https://api.github.com/users/NightingaleConant/following{/other_user}"",""gists_url"":""https://api.github.com/users/NightingaleConant/gists{/gist_id}"",""starred_url"":""https://api.github.com/users/NightingaleConant/starred{/owner}{/repo}"",""subscriptions_url"":""https://api.github.com/users/NightingaleConant/subscriptions"",""organizations_url"":""https://api.github.com/users/NightingaleConant/orgs"",""repos_url"":""https://api.github.com/users/NightingaleConant/repos"",""events_url"":""https://api.github.com/users/NightingaleConant/events{/privacy}"",""received_events_url"":""https://api.github.com/users/NightingaleConant/received_events"",""type"":""Organization"",""site_admin"":false,""score"":1.0},{""login"":""progsri"",""id"":8907364,""avatar_url"":""https://avatars.githubusercontent.com/u/8907364?v=3"",""gravatar_id"":"""",""url"":""https://api.github.com/users/progsri"",""html_url"":""https://github.com/progsri"",""followers_url"":""https://api.github.com/users/progsri/followers"",""following_url"":""https://api.github.com/users/progsri/following{/other_user}"",""gists_url"":""https://api.github.com/users/progsri/gists{/gist_id}"",""starred_url"":""https://api.github.com/users/progsri/starred{/owner}{/repo}"",""subscriptions_url"":""https://api.github.com/users/progsri/subscriptions"",""organizations_url"":""https://api.github.com/users/progsri/orgs"",""repos_url"":""https://api.github.com/users/progsri/repos"",""events_url"":""https://api.github.com/users/progsri/events{/privacy}"",""received_events_url"":""https://api.github.com/users/progsri/received_events"",""type"":""User"",""site_admin"":false,""score"":1.0},{""login"":""jlpartee"",""id"":1223505,""avatar_url"":""https://avatars.githubusercontent.com/u/1223505?v=3"",""gravatar_id"":"""",""url"":""https://api.github.com/users/jlpartee"",""html_url"":""https://github.com/jlpartee"",""followers_url"":""https://api.github.com/users/jlpartee/followers"",""following_url"":""https://api.github.com/users/jlpartee/following{/other_user}"",""gists_url"":""https://api.github.com/users/jlpartee/gists{/gist_id}"",""starred_url"":""https://api.github.com/users/jlpartee/starred{/owner}{/repo}"",""subscriptions_url"":""https://api.github.com/users/jlpartee/subscriptions"",""organizations_url"":""https://api.github.com/users/jlpartee/orgs"",""repos_url"":""https://api.github.com/users/jlpartee/repos"",""events_url"":""https://api.github.com/users/jlpartee/events{/privacy}"",""received_events_url"":""https://api.github.com/users/jlpartee/received_events"",""type"":""User"",""site_admin"":false,""score"":1.0},{""login"":""pracstrat"",""id"":1230068,""avatar_url"":""https://avatars.githubusercontent.com/u/1230068?v=3"",""gravatar_id"":"""",""url"":""https://api.github.com/users/pracstrat"",""html_url"":""https://github.com/pracstrat"",""followers_url"":""https://api.github.com/users/pracstrat/followers"",""following_url"":""https://api.github.com/users/pracstrat/following{/other_user}"",""gists_url"":""https://api.github.com/users/pracstrat/gists{/gist_id}"",""starred_url"":""https://api.github.com/users/pracstrat/starred{/owner}{/repo}"",""subscriptions_url"":""https://api.github.com/users/pracstrat/subscriptions"",""organizations_url"":""https://api.github.com/users/pracstrat/orgs"",""repos_url"":""https://api.github.com/users/pracstrat/repos"",""events_url"":""https://api.github.com/users/pracstrat/events{/privacy}"",""received_events_url"":""https://api.github.com/users/pracstrat/received_events"",""type"":""Organization"",""site_admin"":false,""score"":1.0},{""login"":""Ropebender"",""id"":10382972,""avatar_url"":""https://avatars.githubusercontent.com/u/10382972?v=3"",""gravatar_id"":"""",""url"":""https://api.github.com/users/Ropebender"",""html_url"":""https://github.com/Ropebender"",""followers_url"":""https://api.github.com/users/Ropebender/followers"",""following_url"":""https://api.github.com/users/Ropebender/following{/other_user}"",""gists_url"":""https://api.github.com/users/Ropebender/gists{/gist_id}"",""starred_url"":""https://api.github.com/users/Ropebender/starred{/owner}{/repo}"",""subscriptions_url"":""https://api.github.com/users/Ropebender/subscriptions"",""organizations_url"":""https://api.github.com/users/Ropebender/orgs"",""repos_url"":""https://api.github.com/users/Ropebender/repos"",""events_url"":""https://api.github.com/users/Ropebender/events{/privacy}"",""received_events_url"":""https://api.github.com/users/Ropebender/received_events"",""type"":""User"",""site_admin"":false,""score"":1.0},{""login"":""GifRun"",""id"":10580378,""avatar_url"":""https://avatars.githubusercontent.com/u/10580378?v=3"",""gravatar_id"":"""",""url"":""https://api.github.com/users/GifRun"",""html_url"":""https://github.com/GifRun"",""followers_url"":""https://api.github.com/users/GifRun/followers"",""following_url"":""https://api.github.com/users/GifRun/following{/other_user}"",""gists_url"":""https://api.github.com/users/GifRun/gists{/gist_id}"",""starred_url"":""https://api.github.com/users/GifRun/starred{/owner}{/repo}"",""subscriptions_url"":""https://api.github.com/users/GifRun/subscriptions"",""organizations_url"":""https://api.github.com/users/GifRun/orgs"",""repos_url"":""https://api.github.com/users/GifRun/repos"",""events_url"":""https://api.github.com/users/GifRun/events{/privacy}"",""received_events_url"":""https://api.github.com/users/GifRun/received_events"",""type"":""Organization"",""site_admin"":false,""score"":1.0},{""login"":""delmuro"",""id"":10599206,""avatar_url"":""https://avatars.githubusercontent.com/u/10599206?v=3"",""gravatar_id"":"""",""url"":""https://api.github.com/users/delmuro"",""html_url"":""https://github.com/delmuro"",""followers_url"":""https://api.github.com/users/delmuro/followers"",""following_url"":""https://api.github.com/users/delmuro/following{/other_user}"",""gists_url"":""https://api.github.com/users/delmuro/gists{/gist_id}"",""starred_url"":""https://api.github.com/users/delmuro/starred{/owner}{/repo}"",""subscriptions_url"":""https://api.github.com/users/delmuro/subscriptions"",""organizations_url"":""https://api.github.com/users/delmuro/orgs"",""repos_url"":""https://api.github.com/users/delmuro/repos"",""events_url"":""https://api.github.com/users/delmuro/events{/privacy}"",""received_events_url"":""https://api.github.com/users/delmuro/received_events"",""type"":""User"",""site_admin"":false,""score"":1.0}]}";
        private const string ErikResult = @"{""login"":""erikdietrich"",""id"":1232840,""avatar_url"":""https://avatars.githubusercontent.com/u/1232840?v=3"",""gravatar_id"":"""",""url"":""https://api.github.com/users/erikdietrich"",""html_url"":""https://github.com/erikdietrich"",""followers_url"":""https://api.github.com/users/erikdietrich/followers"",""following_url"":""https://api.github.com/users/erikdietrich/following{/other_user}"",""gists_url"":""https://api.github.com/users/erikdietrich/gists{/gist_id}"",""starred_url"":""https://api.github.com/users/erikdietrich/starred{/owner}{/repo}"",""subscriptions_url"":""https://api.github.com/users/erikdietrich/subscriptions"",""organizations_url"":""https://api.github.com/users/erikdietrich/orgs"",""repos_url"":""https://api.github.com/users/erikdietrich/repos"",""events_url"":""https://api.github.com/users/erikdietrich/events{/privacy}"",""received_events_url"":""https://api.github.com/users/erikdietrich/received_events"",""type"":""User"",""site_admin"":false,""name"":""Erik Dietrich"",""company"":""DaedTech"",""blog"":""http://www.daedtech.com"",""location"":""Wheeling,IL"",""email"":""erik@daedtech.com"",""hireable"":null,""bio"":null,""public_repos"":15,""public_gists"":35,""followers"":20,""following"":12,""created_at"":""2011-12-01T07:49:30Z"",""updated_at"":""2015-11-12T15:14:49Z""}";

        private static IList<Profile> ReturnedProfiles { get { return GetFromContext<IList<Profile>>(); } }

        [When(@"I supply location (.*)")]
        public void WhenISupplyLocationWheelingIL(string locationText)
        {
            var mockInquisitor = Mock.Create<IGithubInquisitor>();
            mockInquisitor.Arrange(inquisitor => inquisitor.GetLocationSearchResults(Arg.AnyString)).Returns(WheelingLocationResult);
            mockInquisitor.Arrange(inquisitor => inquisitor.GetVerbatimSearchResults(Arg.AnyString)).Returns(ErikResult);

            var target = new ProfileSearcher(mockInquisitor);

            var profiles = target.GetProfilesForLocation(locationText);

            SetInContext(profiles);
        }

        [Then(@"I should have a user named (.*)")]
        public void ThenIShouldHaveAUserNamedErik(string firstName)
        {
            Assert.IsTrue(ReturnedProfiles.Any(p => p.FirstName == firstName));

        }

        [Then(@"I should have a user with email address (.*)")]
        public void ThenIShouldHaveAUserWithEmailAddressErikDaedtech_Com(string emailAddress)
        {
            Assert.IsTrue(ReturnedProfiles.Any(p => p.EmailAddress == emailAddress));
        }

        [Then(@"I should get back (.*) total results")]
        public void ThenIShouldGetBackTotalResults(int resultCount)
        {
            Assert.AreEqual<int>(resultCount, ReturnedProfiles.Count);
        }

        [Then(@"I should have a user with profile url ""(.*)""")]
        public void ThenIShouldHaveAUserWithProfileUrl(string profileUrl)
        {
            Assert.IsTrue(ReturnedProfiles.Any(p => p.ProfileUrl == profileUrl));
        }

        [Then(@"I should have a user with username (.*)")]
        public void ThenIShouldHaveAUserWithUsernameErikdietrich(string expectedUsername)
        {
            Assert.IsTrue(ReturnedProfiles.Any(p => p.Username == expectedUsername));
        }

    }
}
