using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Measurement
{
    class HighFrequencyCode
    {
        void OpenText()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "文本文件|*.txt|所有文件|*.*";
            string targetpath;
            if (ofd.ShowDialog() == true)  //WPF
            {
                targetpath = ofd.FileName;
                string[] all = File.ReadAllLines(ofd.FileName);
                if (all == null) return;
            }
        }

        void SaveText()
        {              
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "文本文件|*.txt|所有文件|*.*";
            if (sfd.ShowDialog() == DialogResult.OK) //WinForm
            {
               string targetpath = sfd.FileName;
               File.WriteAllLines(targetpath, vps);
            }
        }
        
        
             
        
        //将ddd.mmss转为弧度
	    static public double DEG(double ang)
        {
            int fuhao = (int)(ang / Math.Abs(ang));
            ang = Math.Abs(ang) + 1.0E-13;
            int d = (int)ang;
            int m = (int)((ang * 100) - d * 100);
            double s = ang * 10000 - m * 100 - d * 10000;
            return ((d + m / 60.0 + s / 3600.0) * fuhao) / 180.0 * Math.PI;
        }
        
 	    //将弧度转为ddd.mmss
        static public double DMS(double ang)
        {
            ang += 1.0E-13;//加上一个小量，以保证进位
            int fuhao = (int)(ang / Math.Abs(ang));
            ang = Math.Abs(ang) * 180.0 / Math.PI;
            int d = (int)ang;
            ang = (ang - d) * 60.0;
            int m = (int)ang;
            double s = (ang - m) * 60.0;
            return (d + m / 100.0 + s / 10000.0) * fuhao;
        }
        
	    
	    
	    
        /// <summary>
        /// 多边形面积计算(不论凸凹)
        /// </summary>
        /// <param name="count">坐标点数</param>
        /// <param name="X">坐标的横坐标集合</param>
        /// <param name="Y">坐标的纵坐标集合</param>
        /// <returns></returns>
        private double AoArea(int count,double [] X,double [] Y) 
        {
            double area;
            if (count < 3) 
                return 0;
            area= Y[0] * (X[count - 1] - X[1]);
            for (int i = 1; i <count; i++)
                area+= Y[i] * (X[(i - 1)] - X[(i + 1)%count]);
            return area/2;
        }
	    
	    
    }
}
