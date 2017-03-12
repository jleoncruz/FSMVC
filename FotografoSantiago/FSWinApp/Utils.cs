using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace FSWinApp
{
    public static class Utils
    {
        public static void PreviewImage(string imageLocation)
        {
            Form form = new Form();
            form.Text = "Image Preview";
            form.WindowState = FormWindowState.Maximized;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Image = Image.FromFile(imageLocation);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            form.Controls.Add(pictureBox);

            form.ShowDialog();
        }

        #region Working with Images

        public static string ResizeAndMovePhoto(string sourceDirectory, string photoLocation, string photoFileName)
        {
            string returnValue = string.Empty;

            try
            {
                DirectoryInfo targetDirectory = new DirectoryInfo($"{sourceDirectory}\\Converted\\");
                if (!targetDirectory.Exists) { targetDirectory.Create(); }

                JpegBitmapDecoder decoder = new JpegBitmapDecoder(File.OpenRead(photoLocation), BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);
                BitmapFrame bitmapFrame = decoder.Frames[0];
                ScaleTransform scale = new ScaleTransform(0.25, 0.25);
                TransformedBitmap scaledBitMap = new TransformedBitmap(bitmapFrame, scale);
                JpegBitmapEncoder encoder = new JpegBitmapEncoder();

                encoder.Frames.Add(BitmapFrame.Create(scaledBitMap));
                returnValue = $"{sourceDirectory}\\Converted\\{photoFileName}";

                MemoryStream mStream = new MemoryStream();
                encoder.Save(mStream);

                Image processingImage = Image.FromStream(mStream);
                Graphics g = Graphics.FromImage(processingImage);

                string waterMarkString = "Fotógrafo Santiago";
                //Font font = new Font("Arial", 64);
                //
                //Font font = new Font("Brush Script MT", 24, FontStyle.Italic);
                Font font = new Font("Comic Sans MS", 24, FontStyle.Italic);
                SizeF sizeF = g.VisibleClipBounds.Size;
                g.TranslateTransform(sizeF.Width / 2, sizeF.Height / 2);
                //g.Save();
                g.RotateTransform(35);
                sizeF = g.MeasureString(waterMarkString, font);
                g.DrawString(waterMarkString, font, System.Drawing.Brushes.Gray, -(sizeF.Width / 2), -(sizeF.Height / 2));

                processingImage.Save(returnValue);

                g.Dispose();
                processingImage.Dispose();
                mStream.Dispose();
            }
            catch (Exception ex)
            {
                throw;
            }

            return returnValue;
        }

        #endregion
    }
}
