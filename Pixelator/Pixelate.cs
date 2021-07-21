using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Pixelator
{
    class Pixelate
    {

        public static Bitmap PixelateImage(Bitmap originalImage, Rectangle rectangle, Int32 pixelateSize)
        {
            Bitmap pixelatedImage = new Bitmap(originalImage.Width, originalImage.Height);

            using (Graphics graphics = Graphics.FromImage(pixelatedImage))
                graphics.DrawImage(originalImage, new Rectangle(0, 0, originalImage.Width, originalImage.Height),
                    new Rectangle(0, 0, originalImage.Width, originalImage.Height), GraphicsUnit.Pixel);

            for (Int32 xIndex = rectangle.X; xIndex < rectangle.X + rectangle.Width && xIndex < originalImage.Width; xIndex += pixelateSize)
            {
                for (Int32 yIndex = rectangle.Y; yIndex < rectangle.Y + rectangle.Height && yIndex < originalImage.Height; yIndex += pixelateSize)
                {
                    // set the offset to half the pixelate size
                    Int32 offsetX = pixelateSize / 2;
                    Int32 offsetY = pixelateSize / 2;

                    // make sure the offset is within the image, if not decrease the offset
                    while (xIndex + offsetX >= originalImage.Width) offsetX--;
                    while (yIndex + offsetY >= originalImage.Height) offsetY--;

                    // find the colour of the pixel in the center of the pixelate area
                    Color pixelColour = pixelatedImage.GetPixel(xIndex + offsetX, yIndex + offsetY);

                    // set each pixel in the pixelate size to the center colour
                    for (Int32 pixelXIndex = xIndex; pixelXIndex < xIndex + pixelateSize && pixelXIndex < originalImage.Width; pixelXIndex++)
                        for (Int32 pixelYIndex = yIndex; pixelYIndex < yIndex + pixelateSize && pixelYIndex < originalImage.Height; pixelYIndex++)
                            pixelatedImage.SetPixel(pixelXIndex, pixelYIndex, pixelColour);
                }
            }

            return pixelatedImage;
        }

    }
}
