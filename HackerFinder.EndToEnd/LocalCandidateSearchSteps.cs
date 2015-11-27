﻿using HackerFinder.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

using static HackerFinder.Acceptance.ContextRepository;

namespace HackerFinder.EndToEnd
{
    [Binding]
    public class LocalCandidateSearchSteps
    {
        public IList<Profile> ReturnedProfiles
        {
            get { return GetFromContext<IList<Profile>>(); }
            set { SetInContext(value); }
        }

        [When(@"I search (.*) and (.*)")]
        public void WhenISearchAnd(string location, string language)
        {
            var searcher = new ProfileSearcher(new GithubInquisitor());
            ReturnedProfiles = searcher.SearchForLocalCandidates(location, language);
        }
        
        [Then(@"The result should include (.*)")]
        public void ThenTheResultShouldIncludeErikdietrich(string githubUsername)
        {
            Assert.IsTrue(ReturnedProfiles.Any(p => p.Username == githubUsername));
        }
    }
}
