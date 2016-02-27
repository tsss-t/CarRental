using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Web;
using System.Web.Mvc;
/*
 * 编写人 :杜天行
 * 编写时间:2012年4月21日12:48:29
 * 编写版本:v0.7
 * */
namespace MVCpart
{
    public static class EX_Fuction
    {
        /// <summary>
        /// ActionLink不Encode的扩展方法
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static IHtmlString WriteHtml(this MvcHtmlString str)
        {
            return new HtmlString(HttpUtility.HtmlDecode(str.ToString()));
        }

        /// <summary>
        /// 将数据流转换为位图的缩略图版本
        /// </summary>
        /// <param name="bs"></param>
        /// <param name="Width">输出时规定的宽度</param>
        /// <param name="Height">输出时规定的高度</param>
        /// <returns></returns>
        public static Image FromBytes(this byte[] bs,int? Width,int? Height)
        {
            if (bs == null) return null;
            
            try
            {
                MemoryStream ms = new MemoryStream(bs);

                Image returnImage = Image.FromStream(ms);
                if (Width != null||Height!=null)
                {
                    int srcWidth = returnImage.Width;
                    int srcHeight = returnImage.Height;
                    int thumbWidth;
                    int thumbHeight;
           
                    if (Width == null)
                    {
                        thumbHeight =(int) Height;
                        thumbWidth = Width ?? (int)(((double)srcWidth / (double)srcHeight) * (double)thumbHeight);
                    }
                    if (Height == null)
                    {
                        thumbWidth = (int)Width;
                        thumbHeight = Height ?? (int)(((double)srcHeight / (double)srcWidth) * (double)thumbWidth);
                    }
                    else
                    {
                        thumbHeight = (int)Height;
                        thumbWidth = (int)Width;
                    }
                        Bitmap bmp = new Bitmap(thumbWidth, thumbHeight);
                    //从Bitmap创建一个System.Drawing.Graphics对象，用来绘制高质量的缩小图。
                    System.Drawing.Graphics gr = System.Drawing.Graphics.FromImage(bmp);
                    //设置 System.Drawing.Graphics对象的SmoothingMode属性为HighQuality
                    gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    //下面这个也设成高质量
                    gr.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                    //下面这个设成High
                    gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
                    //把原始图像绘制成上面所设置宽高的缩小图
                    System.Drawing.Rectangle rectDestination = new System.Drawing.Rectangle(0, 0, thumbWidth, thumbHeight);
                    gr.DrawImage(returnImage, rectDestination, 0, 0, srcWidth, srcHeight, GraphicsUnit.Pixel);
                    //保存图像，大功告成！

                    ms.Close();
                    return bmp;
                }
                else
                {
                    ms.Close();

                    return returnImage;
                }
            }

            catch { return null; }
        }

        /// <summary>
        /// 从地址提取将图片转换为2进制流
        /// </summary>
        /// <param name="Image"></param>
        /// <param name="Patch"></param>
        /// <returns></returns>
        public static String ImagePatchToBaniryString(this String Patch)
        {
            Image img = Image.FromFile(Patch);
            ImageConverter converter = new ImageConverter();

            byte[] bmpSrc = (byte[])converter.ConvertTo(img, typeof(byte[]));

            MemoryStream ms = new MemoryStream(bmpSrc);

            MemoryStream msjpg = new MemoryStream();

            Bitmap myBitmap = new Bitmap(ms);

            myBitmap.Save(msjpg, ImageFormat.Jpeg);

            byte[] bjpeg = msjpg.GetBuffer();
            //获得2进制图片数据流
            String imgString = String.Join(",", Array.ConvertAll(bjpeg, (Converter<byte, string>)Convert.ToString));

            return imgString;
        }
    }
}
