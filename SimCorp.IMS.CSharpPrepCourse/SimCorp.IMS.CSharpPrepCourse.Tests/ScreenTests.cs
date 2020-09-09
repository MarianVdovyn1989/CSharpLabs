//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using SimCorp.IMS.CSharpPrepCourse;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace SimCorp.IMS.CSharpPrepCourse.Tests
//{
//    [TestClass()]
//    public class ScreenTests
//    {
//        [TestMethod()]
//        public void Screen_ReturnParameters_SetViaConstructor_3Par()
//        {
//            //Assign
//            var ExpectedPixelHeight = 480;
//            var ExpectedPixelWidth = 720;
//            var ExpectedDiagonalInInches = 2.9;
//            var ExpectedAspectRatio = "3:2 - AspectRatio";

//            //Act
//            ScreenBase screen = new ScreenBase(pixelHeight: 480, pixelWidth: 720, diagonalInInches: 2.9);
//            //
//            Assert.AreEqual(ExpectedPixelHeight,screen.PixelHeight);
//            Assert.AreEqual(ExpectedPixelWidth, screen.PixelWidth);
//            Assert.AreEqual(ExpectedDiagonalInInches, screen.DiagonalInInches);
//            Assert.AreEqual(ExpectedAspectRatio, screen.AspectRatio);
//        }
//        [TestMethod()]
//        public void Screen_ReturnParameters_SetViaConstructor_2Par()
//        {
//            //Assign
//            var ExpectedPixelHeight = 480;
//            var ExpectedPixelWidth = 720;
//            var ExpectedDiagonalInInches = 4.7;
//            var ExpectedAspectRatio = "3:2 - AspectRatio";

//            //Act
//            ScreenBase screen = new ScreenBase(pixelHeight: 480, pixelWidth: 720);
//            //
//            Assert.AreEqual(ExpectedPixelHeight, screen.PixelHeight);
//            Assert.AreEqual(ExpectedPixelWidth, screen.PixelWidth);
//            Assert.AreEqual(ExpectedDiagonalInInches, screen.DiagonalInInches);
//            Assert.AreEqual(ExpectedAspectRatio, screen.AspectRatio);
//        }

//        [TestMethod()]
//        public void Screen_ReturnParameters_SetViaConstructor_0Par_DefaultValues()
//        {
//            //Assign
//            var ExpectedDefaultPixelHeight = 1080;
//            var ExpectedDefaultPixelWidth = 1920;
//            var ExpectedDiagonalInInches = 4.7;
//            var ExpectedDefaultAspectRatio = "16:9 - AspectRatio";

//            //Act
//            ScreenBase screen = new ScreenBase();
//            //
//            Assert.AreEqual(ExpectedDefaultPixelHeight, screen.PixelHeight);
//            Assert.AreEqual(ExpectedDefaultPixelWidth, screen.PixelWidth);
//            Assert.AreEqual(ExpectedDiagonalInInches, screen.DiagonalInInches);
//            Assert.AreEqual(ExpectedDefaultAspectRatio, screen.AspectRatio);
//        }
//    }
//}