using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FinalProject.Win;

namespace FinalProject.Test
{
    [TestFixture]
    class WhenRunningApplication
    {
        [Test]
        public void When_UserEnteredNumber_NumberCheck_ResultShouldBeTrue()
        {
            var expected = true;
            var actual = AddFlightView.NumberCheck("1234");
            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void When_UserEnteredChar_NumberCheck_ResultShouldBeFalse()
        {
            var expected = false;

            var actual = AddFlightView.NumberCheck("ssr");

            Assert.That(expected, Is.EqualTo(actual));
        }
    }

}
