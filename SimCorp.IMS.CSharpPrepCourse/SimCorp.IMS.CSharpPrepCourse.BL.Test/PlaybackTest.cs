using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;
using SimCorp.IMS.CSharpPrepCourse.BL.Playback;

namespace SimCorp.IMS.CSharpPrepCourse.BL.Test
{
    [TestClass]
    public class PlaybackTest
    {
        private class FakeOutput : IOutput
        {
            private string Text;
            public void WriteLine(string text)
            {
                Text=text;
            }
            public string GetText()
            {
                return Text;
            }

        }
        [TestMethod]
        public void Play_AirPods()
        {
            //Arrange
            FakeOutput fakeOutput = new FakeOutput();
            var expected = $"Do you hear this {nameof(AirPods)} sound? Me too\n";
            //Act
            AirPods airPods = new AirPods(volume:75, fakeOutput);
            airPods.Play();
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetText());
        }
        [TestMethod]
        public void Play_AirPodsPro()
        {
            //Arrange
            FakeOutput fakeOutput = new FakeOutput();
            var expected = $"Do you hear this {nameof(AirPodsPro)} sound? Me too\n";
            //Act
            var airPodsPro = new AirPodsPro(volume: 75, fakeOutput);
            airPodsPro.Play();
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetText());
        }
        [TestMethod]
        public void Play_GalaxyBuds()
        {
            //Arrange
            FakeOutput fakeOutput = new FakeOutput();
            var expected = $"Do you hear this {nameof(GalaxyBuds)} sound? Me too\n";
            //Act
            var galaxyBuds = new GalaxyBuds(volume: 75, fakeOutput);
            galaxyBuds.Play();
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetText());
        }
        [TestMethod]
        public void Play_GalaxyBudsLive()
        {
            //Arrange
            FakeOutput fakeOutput = new FakeOutput();
            var expected = $"Do you hear this {nameof(GalaxyBudsLive)} sound? Me too\n";
            //Act
            var galaxyBudsLive = new GalaxyBudsLive(volume: 75, fakeOutput);
            galaxyBudsLive.Play();
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetText());
        }
        [TestMethod]
        public void Play_HomePod()
        {
            //Arrange
            FakeOutput fakeOutput = new FakeOutput();
            var expected = $"Do you hear this {nameof(HomePod)} sound? Me too\n";
            //Act
            var homePod = new HomePod(volume: 75, fakeOutput);
            homePod.Play();
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetText());
        }
        [TestMethod]
        public void Play_NoNameHeadSet()
        {
            //Arrange
            FakeOutput fakeOutput = new FakeOutput();
            var expected = $"Do you hear this {nameof(NoNameHeadSet)} sound? Me too\n";
            //Act
            var noNameHeadSet = new NoNameHeadSet(volume: 75, fakeOutput);
            noNameHeadSet.Play();
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetText());
        }
        [TestMethod]
        public void Play_PhoneSpeaker()
        {
            //Arrange
            FakeOutput fakeOutput = new FakeOutput();
            var expected = $"Do you hear this {nameof(PhoneSpeaker)} sound? Me too\n";
            //Act
            var phoneSpeaker = new PhoneSpeaker(volume: 75, fakeOutput);
            phoneSpeaker.Play();
            //Assert
            Assert.AreEqual(expected, fakeOutput.GetText());
        }
    }
}
