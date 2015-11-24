﻿Feature: RepoSearch

Scenario: Get repo count for user
	When I do a repo search for user erikdietrich
	Then I should have 15 repos
	And First repo should have the following properties
	| Name                | Url                                                 | Language   |
	| ASPNETWebAPISamples | https://github.com/erikdietrich/ASPNETWebAPISamples | JavaScript |
