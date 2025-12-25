using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace VirtualDisplay
{
    class Gradient_Float
    {
        private Color FadeToColor(Color first, Color second, float percent)
        {
            int r = (int)(second.R * percent + first.R * (1f - percent));
            int g = (int)(second.G * percent + first.G * (1f - percent));
            int b = (int)(second.B * percent + first.B * (1f - percent));
            return Color.FromArgb(r, g, b);
        }

        public Color targetColor;
        public Color originalColor;
        public static float percent = 0;
        private Color Timer1_Tick(Timer timer, object sender, EventArgs e)
        {
            Color OutputColor = FadeToColor(originalColor, targetColor, percent);
            percent += 0.01f;
            if (percent >= 1) timer.Enabled = false;
            return OutputColor;
        }

        public Image ChangeOpacity(Image image, float opacity)
        {
            Bitmap bitmap = new Bitmap(image.Width, image.Height);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                ImageAttributes attributes = new ImageAttributes();
                ColorMatrix matrix = new ColorMatrix { Matrix33 = opacity };
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                graphics.DrawImage(image, new Rectangle(0, 0, bitmap.Width, bitmap.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
            }
            return bitmap;
        }
    }
}
