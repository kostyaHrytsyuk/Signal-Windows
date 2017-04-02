﻿using System;
using Windows.UI.Xaml.Media;

namespace Signal_Windows
{
    public class Utils
    {
        public static SolidColorBrush Red = GetSolidColorBrush(255, "#EF5350");
        public static SolidColorBrush Pink = GetSolidColorBrush(255, "#EC407A");
        public static SolidColorBrush Purple = GetSolidColorBrush(255, "#AB47BC");
        public static SolidColorBrush Deep_Purple = GetSolidColorBrush(255, "#7E57C2");
        public static SolidColorBrush Indigo = GetSolidColorBrush(255, "#5C6BC0");
        public static SolidColorBrush Blue = GetSolidColorBrush(255, "#2196F3");
        public static SolidColorBrush Light_Blue = GetSolidColorBrush(255, "#03A9F4");
        public static SolidColorBrush Cyan = GetSolidColorBrush(255, "#00BCD4");
        public static SolidColorBrush Teal = GetSolidColorBrush(255, "#009688");
        public static SolidColorBrush Green = GetSolidColorBrush(255, "#4CAF50");
        public static SolidColorBrush Light_Green = GetSolidColorBrush(255, "#7CB342");
        public static SolidColorBrush Orange = GetSolidColorBrush(255, "#FF9800");
        public static SolidColorBrush Deep_Orange = GetSolidColorBrush(255, "#FF5722");
        public static SolidColorBrush Amber = GetSolidColorBrush(255, "#FFB300");
        public static SolidColorBrush Blue_Grey = GetSolidColorBrush(255, "#607D8B");
        public static SolidColorBrush Grey = GetSolidColorBrush(255, "#999999");
        public static SolidColorBrush Default = GetSolidColorBrush(255, "#2090ea");

        public static SolidColorBrush GetSolidColorBrush(byte opacity, string hex)
        {
            hex = hex.Replace("#", string.Empty);
            byte r = (byte)(Convert.ToUInt32(hex.Substring(0, 2), 16));
            byte g = (byte)(Convert.ToUInt32(hex.Substring(2, 2), 16));
            byte b = (byte)(Convert.ToUInt32(hex.Substring(4, 2), 16));
            SolidColorBrush myBrush = new SolidColorBrush(Windows.UI.Color.FromArgb(opacity, r, g, b));
            return myBrush;
        }

        public static SolidColorBrush GetBrushFromColor(string signalcolor)
        {
            switch (signalcolor)
            {
                case "red": return Utils.Red;
                case "pink": return Utils.Pink;
                case "purple": return Utils.Purple;
                case "deep_purple": return Utils.Deep_Purple;
                case "indigo": return Utils.Indigo;
                case "blue": return Utils.Blue;
                case "light_blue": return Utils.Light_Blue;
                case "cyan": return Utils.Cyan;
                case "teal": return Utils.Teal;
                case "green": return Utils.Green;
                case "light_green": return Utils.Light_Green;
                case "orange": return Utils.Orange;
                case "deep_orange": return Utils.Deep_Orange;
                case "amber": return Utils.Amber;
                case "blue_grey": return Utils.Blue_Grey;
                case "grey": return Utils.Grey;
                default: return Utils.Default;
            }
        }
    }
}