using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.IO;
using System.Web.SessionState;
using System.Threading;

namespace MVCpart
{
    /// <summary>
    /// Pic 的摘要说明
    /// 使用方法:
    /// 在循环中使用以下语句
    ///             <%          
    ///          i++;
    ///          path = "path" + i ;    
    ///           Session[path] = item.Version_IMG; 
    ///          %>
    ///            <img src="../../Pic.ashx?ID=<%=i %>"  />
    /// 原理:
    /// 将图片2进制数据全部放进Session里然后根据用GET的方式传过来的图片序号进行对应的图片解析返回,
    /// 之后删除Session中的数据
    /// </summary>
    public class Pic : IHttpHandler, IRequiresSessionState
    {
        public void ProcessRequest(HttpContext context)
        {
            start(context);
        }
        public void start(HttpContext context)
        {
            //int length = Convert.ToInt32(context.Session["length"]);
            int id = Convert.ToInt32(context.Request.QueryString["ID"]);
            string path = "path" + id;
            string[] imgArr = context.Session[path].ToString().Split(new char[] { ',' });
            byte[] bty = Array.ConvertAll<string, byte>(imgArr, delegate(string s) { return byte.Parse(s); });
            Image img = FromBytes(bty);
            Bitmap bmp = new Bitmap(img);
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            context.Response.ClearContent();
            context.Response.ContentType = "image/Gif";
            context.Response.BinaryWrite(ms.ToArray());
            //context.Session.Remove(path);
        }
        public Image FromBytes(byte[] bs)
        {
            if (bs == null) return null;
            try
            {
                MemoryStream ms = new MemoryStream(bs);
                Image returnImage = Image.FromStream(ms);
                ms.Close();
                return returnImage;
            }
            catch { return null; }
        }
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}