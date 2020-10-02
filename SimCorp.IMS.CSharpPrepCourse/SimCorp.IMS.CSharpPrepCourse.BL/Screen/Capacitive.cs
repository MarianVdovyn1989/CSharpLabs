﻿using SimCorp.IMS.CSharpPrepCourse.BL.ConsoleUserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimCorp.IMS.CSharpPrepCourse.BL.Screen
{
    public class Capacitive : ScreenMultipleTouchBase
    {
        IOutput Output;
        #region Ctor
        public Capacitive(int pixelHeight, int pixelWidth, double diagonalInInches, int numberOfMultipleTouches, IOutput output) : base(pixelHeight, pixelWidth, diagonalInInches, numberOfMultipleTouches)
        {
            Output = output;
            Output.WriteLine($"Setting {nameof(Capacitive)} screen to Mobile Phone");
        }

        public override void Show()
        {
            Output.WriteLine($"If you read this text then Show method of {nameof(IScreen)} interface works for {nameof(Capacitive)} Screen\n");
        }

        public override string ToString()
        {
            return nameof(Capacitive);
        }
        #endregion
        public override void Touch()
        {
            Output.WriteLine($"This touch was made on {nameof(Capacitive)} screen");
            Output.WriteLine("Isn't it fantastic?\n");
        }
    }
}