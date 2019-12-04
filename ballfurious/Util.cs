using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ballfurious
{
  static  class Util
    {
        /// <summary>
        /// Rotates an image to given angle
        /// </summary>
        /// <param name="pImage">
        /// </param>
        /// <param name="pAngle">
        /// </param>
        /// <returns>
        /// </returns>
        public static Image RotateImage(Image pImage, int pAngle)
        {
            // Validate input
            if (pImage == null)
                return null;

            Bitmap b = new Bitmap(pImage.Width, pImage.Height);

            using (Graphics g = Graphics.FromImage(b))
            {
                // Set rotation point
                g.TranslateTransform(b.Width / 2, b.Height / 2);

                g.RotateTransform(pAngle);

                g.TranslateTransform(-b.Width / 2, -b.Height / 2);

                g.DrawImage(pImage, new Point(0, 0));
            }

            return b;
        }
    }
}
