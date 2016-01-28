using System;
using System.Threading;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.WindowItems;

namespace Library.GUI.Tests
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        private Application _appUnderTest;
        private Window _appWindow;

        [Given(@"I have started the application")]
        public void GivenIHaveStartedTheApplication()
        {
            _appUnderTest = Application.Launch(@"..\..\..\Library.GUI\bin\Debug\Library.GUI.exe");
            Assert.That(_appUnderTest, Is.Not.Null);
        }
        
        [Then(@"I can see application window")]
        public void ThenICanSeeApplicationWindow()
        {
            _appWindow = _appUnderTest.GetWindow("Login to Library Sytem");
            Assert.That(_appWindow.Visible, Is.True);
        }
    }
}
