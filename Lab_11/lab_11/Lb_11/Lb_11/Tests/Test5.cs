﻿using Lb_11.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Lb_11.BrowserManager.BrowserManager;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Lb_11.Tests
{
    //searching products on sale
    [TestClass]
    public class Test5
    {
        private MainPage _mainPage;
        private SearchResultPage _searchResultPage;

        [SetUp]
        public void Setup()
        {
            _mainPage = new MainPage(Driver);
            _searchResultPage = new SearchResultPage(Driver);
        }

        [Test]
        public void Test()
        {
            _mainPage.Open();
            _mainPage.Search("Радио-Няна.");
            _searchResultPage.EnableSales();
            Assert.IsTrue(_searchResultPage.isFound());
        }

        [TestCleanup]
        public void Cleanup()
        {
            QuitDriver();
        }
    }
}
