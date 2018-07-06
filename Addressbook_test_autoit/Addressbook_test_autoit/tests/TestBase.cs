﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Addressbook_test_white
{
    public class TestBase
    {
        protected ApplicationManager app;

        [SetUp]
        public void initApplication()
        {
            app = new ApplicationManager();
        }

        [TearDown]
        public void stopApplication()
        {
            app.Stop();
        }
    }
}