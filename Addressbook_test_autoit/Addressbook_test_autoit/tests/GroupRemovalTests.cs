﻿using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Addressbook_test_white
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {       
        [Test]
        public void RemovalGroupTest()
        {
            List<GroupData> oldGroups = app.Groups.GetGroupList();
            GroupData toBeRemoved = oldGroups[0];

            app.Groups.Del(toBeRemoved);

            List<GroupData> newGroups = app.Groups.GetGroupList();

            oldGroups.RemoveAt(0);

            Assert.AreEqual(oldGroups, newGroups);
        } 
    }
}