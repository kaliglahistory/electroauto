using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ScreenShotCapture
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(
                "Скриншот создан! Он в папке Debug или Release проекта или рядом с исполняемым файлом"
          
             );
            //{
                MakeScreenshot();
            //}
            Console.ReadLine();
        }


        // метод, который делает скриншот и записывает его в файл
        public static void MakeScreenshot()
        {
            DateTime localDate = DateTime.Now;
            string data= localDate.ToString();
            // получаем размеры окна рабочего стола
            Rectangle bounds = Screen.GetBounds(Point.Empty);

            // создаем пустое изображения размером с экран устройства
            using (var bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                // создаем объект на котором можно рисовать
                using (var g = Graphics.FromImage(bitmap))
                {
                    // перерисовываем экран на наш графический объект
                    g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
                }
                string put = $"screandata.jpg";
                // сохраняем в файл с форматом JPG
                bitmap.Save(put, ImageFormat.Jpeg);
            }
        }
    }
}