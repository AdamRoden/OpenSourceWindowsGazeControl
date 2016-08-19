﻿using System.Drawing;
using System.Windows.Forms;

namespace GazeToolBar
{
    /*
        Date: 17/05/2016
        Name: Derek Dai
        Description: Put all the constant value or method in here
    */
    static class ValueNeverChange
    {
        public static readonly int DELAY_MILLISECONDS = 1500;
        public static readonly double FORM_WEIGTH_PERCENTAGE = 0.1;
        public static readonly string RES_NAME = "GazeToolBar";
        public static readonly string AUTO_START_ON = "Auto Start Is On";
        public static readonly string AUTO_START_OFF = "Auto Start Is OFF";
        public static readonly int FIXED_HEIGHT = 800;
        public static readonly int FIXED_WIDTH = 600;
        public static readonly Size SCREEN_SIZE = Screen.PrimaryScreen.WorkingArea.Size;
        public static readonly Rectangle PRIMARY_SCREEN = Screen.PrimaryScreen.Bounds;
        public static readonly Color SelectedColor = Color.FromArgb(115, 220, 255);
        public static readonly Color SettingButtonColor = Color.Black;


    }
}
