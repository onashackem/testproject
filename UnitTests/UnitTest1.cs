﻿using System;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }

        [Test]
        public void TestMethod2()
        {
            Assert.AreEqual(2, 2);
        }
    }
}
