﻿using NUnit.Framework;
using System;

namespace GalaCasino
{
    class TestCases : Program
    {
        [Test]
        public void LoginGoodFlow()
        {
            reporter = extent.CreateTest("Login, Good-Flow");
            HomePageObject page = new HomePageObject();
            page.LoginGood(reporter);
        }

        [Test]
        public void LoginMissingCredentials()
        {
            reporter = extent.CreateTest("Login, Missing Credentials");
            HomePageObject page = new HomePageObject();
            page.LoginMissingCredentials(reporter);
        }
    }
}
