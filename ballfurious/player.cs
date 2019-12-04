using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
namespace ballfurious
{
    class player
    {
               private string Pcommand;
        private bool isOpen;

        [ DllImport ("winmm.dll")]

        private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);

        public player()
        {

        }

        public void Close()
        {

            Pcommand = "close MediaFile";
            mciSendString(Pcommand, null, 0, IntPtr.Zero);
            isOpen = false;

        }

        public void Open(string sFileName)
        {

            Pcommand = "open \"" + sFileName + "\" type mpegvideo alias MediaFile";

            mciSendString(Pcommand, null, 0, IntPtr.Zero);

            isOpen = true;

        }

        public void Play(bool loop)
        {

            if (isOpen)
            {

                Pcommand = "play MediaFile";

                if (loop)

                    Pcommand += " REPEAT";

                mciSendString(Pcommand, null, 0, IntPtr.Zero);

            }

        }
    }
}
