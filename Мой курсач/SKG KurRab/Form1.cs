using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SKG_KurRab
{
    public partial class Form1 : Form    {
        //маштаб
        int mast = 10;
        //chastot
        float T;     float TT;
        //направление движения
        int dir = 1;
        //приращение по х
        float dx = 1;     float dy = 1;
        //скорость движения и время остановки
        int TransformSpeed, dT;
        //скорость вращения
        float RotateSpeed;
        //угол поворота
        float Angle = 0;
        //координаты центра изображения
        float xc;    double yc;
        public Form1() {  InitializeComponent();  }
        private void Form1_Load(object sender, EventArgs e)  {          
             xc = Convert.ToInt32(pictureBox1.Width / 2);
            yc = Convert.ToInt32(pictureBox1.Height / 2);
            TransformSpeed = 20-trackBar2.Minimum;
            RotateSpeed = trackBar3.Minimum;
            T = trackBar4.Minimum;
            TT = 0;
            ris();  }
        private int x1()        {
            return Convert.ToInt32( xc +((xc - 1.5f * mast)-xc)*Math.Cos(Angle)+(yc-(yc - 0.5f * mast))*Math.Sin(Angle));         
        }
        private int y1()        {
            return Convert.ToInt32(yc + ((xc - 1.5f * mast) - xc) * Math.Sin(Angle) + ((yc - 0.5f * mast) - yc) * Math.Cos(Angle));
        }
        private int x2()        {
            return Convert.ToInt32(xc +((xc - 0.5f * mast)-xc)*Math.Cos(Angle)+(yc-(yc-0.5f*mast))*Math.Sin(Angle));
        }
        private int y2()        {
            return Convert.ToInt32(yc + ((xc - 0.5f * mast) - xc) * Math.Sin(Angle) + ((yc - 0.5f * mast) - yc) * Math.Cos(Angle));
       }
        private int x3()        {
            return Convert.ToInt32(xc +((xc - 0.5f * mast)-xc)*Math.Cos(Angle)+(yc-(yc - 1.5f * mast))*Math.Sin(Angle));
         }
        private int y3()        {
            return  Convert.ToInt32(yc + ((xc - 0.5f * mast) - xc) * Math.Sin(Angle) + ((yc - 1.5f * mast) - yc) * Math.Cos(Angle));
        }
        private int x4()        {
            return Convert.ToInt32(xc +(xc-xc)*Math.Cos(Angle)+(yc-(yc - 0.5f * mast))*Math.Sin(Angle));
         }
        private int y4()        {
            return Convert.ToInt32(yc + (xc - xc) * Math.Sin(Angle) + ((yc - 0.5f * mast) - yc) * Math.Cos(Angle));
        }
        private int x5()        {
            return Convert.ToInt32(xc +((xc + 0.5f * mast)-xc)*Math.Cos(Angle)+(yc-(yc - 1.5f * mast))*Math.Sin(Angle));
        }
        private int y5()        {
            return Convert.ToInt32(yc + ((xc + 0.5f * mast) - xc) * Math.Sin(Angle) + ((yc - 1.5f * mast) - yc) * Math.Cos(Angle));
        }
        private int x6()        {
            return Convert.ToInt32(xc +((xc + 0.5f * mast)-xc)*Math.Cos(Angle)+(yc-(yc - 0.5f * mast))*Math.Sin(Angle));
        }
        private int y6()        {
            return Convert.ToInt32(yc + ((xc + 0.5f * mast) - xc) * Math.Sin(Angle) + ((yc - 0.5f * mast) - yc) * Math.Cos(Angle));
       }
        private int x7()        {
            return Convert.ToInt32(xc +((xc + 1.5f * mast)-xc)*Math.Cos(Angle)+(yc-(yc - 0.5f * mast))*Math.Sin(Angle));
        }
        private int y7()        {
            return Convert.ToInt32(yc + ((xc + 1.5f * mast) - xc) * Math.Sin(Angle) + ((yc - 0.5f * mast) - yc) * Math.Cos(Angle));
        }
        private int x8()        {
            return Convert.ToInt32(xc +((xc + 0.5f * mast)-xc)*Math.Cos(Angle)+(yc-yc)*Math.Sin(Angle));
        }
        private int y8()        {
            return Convert.ToInt32(yc + ((xc + 0.5f * mast) - xc) * Math.Sin(Angle) + (yc - yc) * Math.Cos(Angle));
        }
        private int x9()        {
            return Convert.ToInt32(xc +((xc + 1.5f * mast)-xc)*Math.Cos(Angle)+(yc-(yc + 0.5f * mast))*Math.Sin(Angle));
        }
        private int y9()        {
            return Convert.ToInt32(yc + ((xc + 1.5f * mast) - xc) * Math.Sin(Angle) + ((yc + 0.5f * mast) - yc) * Math.Cos(Angle));
         }
        private int x10()        {
            return Convert.ToInt32(xc +((xc + 0.5f * mast)-xc)*Math.Cos(Angle)+(yc-(yc + 0.5f * mast))*Math.Sin(Angle));
        }
        private int y10()        {
            return Convert.ToInt32(yc + ((xc + 0.5f * mast) - xc) * Math.Sin(Angle) + ((yc + 0.5f * mast) - yc) * Math.Cos(Angle));
        }
        private int x11()        {
            return Convert.ToInt32(xc +((xc + 0.5f * mast)-xc)*Math.Cos(Angle)+(yc-(yc + 1.5f * mast))*Math.Sin(Angle));
       }
        private int y11()        {
            return Convert.ToInt32(yc + ((xc + 0.5f * mast) - xc) * Math.Sin(Angle) + ((yc + 1.5f * mast) - yc) * Math.Cos(Angle));
        }
        private int x12()        {
            return Convert.ToInt32(xc + ((xc) - xc) * Math.Cos(Angle) + (yc - (yc + 0.5f * mast)) * Math.Sin(Angle));
        }
        private int y12()        {
            return Convert.ToInt32(yc + ((xc) - xc) * Math.Sin(Angle) + ((yc + 0.5f * mast) - yc) * Math.Cos(Angle));
        }
        private int x13()        {
            return Convert.ToInt32(xc +((xc - 0.5f * mast)-xc)*Math.Cos(Angle)+(yc-(yc + 1.5f * mast))*Math.Sin(Angle));
       }
        private int y13()        {
            return Convert.ToInt32(yc + ((xc - 0.5f * mast) - xc) * Math.Sin(Angle) + ((yc + 1.5f * mast) - yc) * Math.Cos(Angle));
        }
        private int x14()        {
            return Convert.ToInt32(xc +((xc - 0.5f * mast)-xc)*Math.Cos(Angle)+(yc-(yc + 0.5f * mast))*Math.Sin(Angle));
       }
        private int y14()        {
            return Convert.ToInt32(yc + ((xc - 0.5f * mast) - xc) * Math.Sin(Angle) + ((yc + 0.5f * mast) - yc) * Math.Cos(Angle));
        }
        private int x15()        {
            return Convert.ToInt32(xc +((xc - 1.5f * mast)-xc)*Math.Cos(Angle)+(yc-(yc + 0.5f * mast))*Math.Sin(Angle));
       }
        private int y15()        {
            return Convert.ToInt32(yc + ((xc - 1.5f * mast) - xc) * Math.Sin(Angle) + ((yc + 0.5f * mast) - yc) * Math.Cos(Angle));
        }
        private int x16()        {
            return Convert.ToInt32(xc +((xc - 0.5f * mast)-xc)*Math.Cos(Angle)+(yc-yc)*Math.Sin(Angle));
        }
        private int y16()        {
            return Convert.ToInt32(yc + ((xc - 0.5f * mast) - xc) * Math.Sin(Angle) + (yc - yc) * Math.Cos(Angle));
        }
        //кнопка старт
        private void button1_Click(object sender, EventArgs e)        {
            timer1.Start();
            timer2.Start();
        }
        private void ris()        {
            //присваиваю g рисование графиков
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //Graphics g = pictureBox1.CreateGraphics();
            Graphics g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
            //создаю ручку
            Pen pen = new Pen(Color.Green);
            //сброс
            g.Clear(SystemColors.Control);
            //точки фигуры для полигона
            Point point1 = new Point(x1(), y1());
            Point point2 = new Point(x2(), y2());
            Point point3 = new Point(x3(), y3());
            Point point4 = new Point(x4(), y4());
            Point point5 = new Point(x5(), y5());
            Point point6 = new Point(x6(), y6());
            Point point7 = new Point(x7(), y7());
            Point point8 = new Point(x8(), y8());
            Point point9 = new Point(x9(), y9());
            Point point10 = new Point(x10(), y10());
            Point point11 = new Point(x11(), y11());
            Point point12 = new Point(x12(), y12());
            Point point13 = new Point(x13(), y13());
            Point point14 = new Point(x14(), y14());
            Point point15 = new Point(x15(), y15());
            Point point16 = new Point(x16(), y16());
            //массив из точек для полигона фигуры
            Point[] curvePoints =    {
                 point1,
                 point2,
                 point3,
                 point4,
                 point5,
                 point6,
                 point7,
                 point8,
                 point9,
                 point10,
                 point11,
                 point12,
                 point13,
                 point14,
                 point15,
                 point16,             }; 
            //массив фигуры для заднего фона
            Point[] TrPoints =           {
                 point3,
                 point7,
                 point11,
                 point15            };
            //рисование заднего поле закрашенного
            Brush br1 = new SolidBrush(Color.FromArgb(0, colorDec(), colorInc()));
            Brush br2 = new SolidBrush(Color.FromArgb(colorInc(), colorDec(), 0));
            g.FillPolygon(br1, TrPoints);
            //рисование закрашенной фигуры
            g.FillPolygon(br2, curvePoints);        }
        //размер фигуры
        private void trackBar1_Scroll(object sender, EventArgs e)        {
            mast = trackBar1.Value;        
            ris();        }
        private void trackBar2_Scroll(object sender, EventArgs e)        {
            TransformSpeed = 20 - Convert.ToInt32(trackBar2.Value);
            ris();        }
        private void trackBar3_Scroll(object sender, EventArgs e)        {
            RotateSpeed = trackBar3.Value;
            ris();        }
        private void timer1_Tick(object sender, EventArgs e)        {
              if (x1() > pictureBox1.Width ||
                x2() > pictureBox1.Width ||
                x3() > pictureBox1.Width ||
                x4() > pictureBox1.Width ||
                x5() > pictureBox1.Width ||
                x6() > pictureBox1.Width ||
                x7() > pictureBox1.Width ||
                x8() > pictureBox1.Width ||
                x9() > pictureBox1.Width ||
                x10() > pictureBox1.Width ||
                x11() > pictureBox1.Width ||
                x12() > pictureBox1.Width ||
                x13() > pictureBox1.Width ||
                x14() > pictureBox1.Width ||
                x15() > pictureBox1.Width ||
                x16() > pictureBox1.Width)            {
                xc = xc - 2;
                dx = -dx;
                dir = -dir;
                timer3.Start();
            }
            if( y1() > pictureBox1.Height ||
                y2() > pictureBox1.Height ||
                y3() > pictureBox1.Height ||
                y4() > pictureBox1.Height ||
                y5() > pictureBox1.Height ||
                y6() > pictureBox1.Height ||
                y7() > pictureBox1.Height ||
                y8() > pictureBox1.Height ||
                y9() > pictureBox1.Height ||
                y10() > pictureBox1.Height ||
                y11() > pictureBox1.Height ||
                y12() > pictureBox1.Height ||
                y13() > pictureBox1.Height ||
                y14() > pictureBox1.Height ||
                y15() > pictureBox1.Height ||
                y16() > pictureBox1.Height)            {
                yc = yc - 2;
                dy = -dy;           }
            if (            x1() < 0 ||
                            x2() < 0 ||
                            x3() < 0 ||
                            x4() < 0 ||
                            x5() < 0 ||
                            x6() < 0 ||
                            x7() < 0 ||
                            x8() < 0 ||
                            x9() < 0 ||
                            x10() < 0 ||
                            x11() < 0 ||
                            x12() < 0 ||
                            x13() < 0 ||
                            x14() < 0 ||
                            x15() < 0 ||
                            x16() < 0)            {
                xc = xc + 2;
                dx = -dx;
                dir = -dir; timer3.Start();;            }
            if (            y1() < 0 ||
                            y2() < 0 ||
                            y3() < 0 ||
                            y4() < 0 ||
                            y5() < 0 ||
                            y6() < 0 ||
                            y7() < 0 ||
                            y8() < 0 ||
                            y9() < 0 ||
                            y10() < 0 ||
                            y11() < 0 ||
                            y12() < 0 ||
                            y13() < 0 ||
                            y14() < 0 ||
                            y15() < 0 ||
                            y16() < 0)            {
                yc = yc + 2;
                dy = -dy;           }
            ris();           
            xc = xc + dx;
            yc = (pictureBox1.Height / 2 + ((pictureBox1.Height - 3 * mast) / 2) * Math.Sin(21 * (TT/10)))-2;
            Angle += 0.01f * RotateSpeed * dir;
            TT += 0.01f * T;        }
        private void button2_Click(object sender, EventArgs e)        {
            timer1.Stop();
            timer2.Stop();
            xc = Convert.ToInt32(pictureBox1.Width / 2);
            yc = Convert.ToInt32(pictureBox1.Height / 2);
            TransformSpeed = 20 - trackBar2.Minimum;
            trackBar2.Value = trackBar2.Minimum;
            RotateSpeed = trackBar3.Minimum;
            trackBar3.Value = trackBar3.Minimum;
            mast = trackBar1.Minimum;
            trackBar1.Value = trackBar1.Minimum;
            trackBar4.Value = trackBar4.Minimum;
            trackBar5.Value = trackBar5.Minimum;
            Angle = 0;TT = 0;
            T = trackBar4.Minimum;
            ris();        }
        private void button3_Click(object sender, EventArgs e)        {
            Application.Exit();        }
        private void timer2_Tick(object sender, EventArgs e)        {      
            timer1.Interval = TransformSpeed;       }
        private void trackBar4_Scroll(object sender, EventArgs e)        {
            T = trackBar4.Value;        }
        private byte colorInc()        {
            try           {
                double col = 255 * (xc - 1.5 * mast) / (pictureBox1.Width - 1.5 * mast - 1.5 * mast);
                return Convert.ToByte(col);            }
            catch { return 0; }        }
        private byte colorDec()        {
            try            {
                double col = -255 * (xc - 1.5 * mast) / (pictureBox1.Width - 1.5 * mast - 1.5 * mast) + 255;
                return Convert.ToByte(col);            }
            catch { return 0; }        }
        private void timer3_Tick(object sender, EventArgs e){if (dT > 100) {
                timer1.Start(); timer2.Start(); dT = 0; timer3.Stop(); }  else{
                timer1.Stop(); timer2.Stop(); dT+=11-trackBar5.Value; }}}}
