﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LayoutEngine
{
    class Utils
    {
        [DllImport("gdi32.dll")]
        static extern int GetDeviceCaps(IntPtr hdc, int nIndex);
        [DllImport("user32.dll")]
        static extern IntPtr GetDC(IntPtr hWnd);

        public static List<int> getIndexes(string parent, string str)
        {
            List<int> indexes = new List<int>();
            int i = -1;

            while ((i = parent.IndexOf(str, i + 1)) != -1)
            {
                indexes.Add(i);
            }

            return indexes;
        }

        public static int getDPI ()
        {
            return 96; //GetDeviceCaps(GetDC(IntPtr.Zero), 88);
        }
    }
}