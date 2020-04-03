using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day07_CayleyTree
{
   
    public partial class Form1 : Form
    {
        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        int n = 40;
        double length = 10;

        public Form1()
        {
            InitializeComponent();
        }

        /**
         * 添加一组控件用以调节树的绘制参数。
         * 参数包括递归深度（n）、主干长度（leng）、
         * 右分支长度比（per1）、左分支长度比（per2）、
         * 右分支角度（th1）、左分支角度（th2）、
         * 画笔颜色（pen）。
         */

        private void btn_draw(object sender, EventArgs e)
        {  
            if (graphics == null)
                graphics = this.CreateGraphics();
            drawCayLeyTree(n, 200, 310, length, -Math.PI / 2);
        }

        void drawCayLeyTree( int n , double x0,double y0,double length,double th)
        {
            if (n == 0)
                return;
            double x1 = x0 + length * Math.Cos(th);
            double y1 = y0 + length * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayLeyTree(n - 1, x1, y1, per1 * length, th + th1);
            drawCayLeyTree(n - 1, x1, y1, per2 * length, th - th2);
        }

        void drawLine(double x0,double y0,double x1,double y1)
        {
            graphics.DrawLine(
                Pens.Blue,
                (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //panel.Controls.Add(new Button());
          //  panel.Controls.Add(new TextBox());
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void trackBar_deep_Scroll(object sender, EventArgs e)
        {
            deep.Text = $"递归深度：{trackBar_deep.Value}";
            n = trackBar_deep.Value;
        }

        private void trackBar_length_Scroll(object sender, EventArgs e)
        {

            TreeLength.Text = $"主干长度：{trackBar_length.Value}";
            length = trackBar_length.Value;
        }

        private void trackBar_Per1_Scroll(object sender, EventArgs e)
        {
            TreePer1.Text = $"左分支长度比：{((double)trackBar_Per1.Value)/100}";
            per1 = ((double)trackBar_Per1.Value) / 100;
        }

        private void trackBar_Per2_Scroll(object sender, EventArgs e)
        {
            TreePer2.Text = $"右分支长度比：{((double)trackBar_Per2.Value)/100}";
            per2 = ((double)trackBar_Per2.Value) / 100;
        }

        private void trackBar_Th1_Scroll(object sender, EventArgs e)
        {
            TreeTh1.Text = $"左分支角度：{trackBar_Th1.Value}";
            th1 = ((double)trackBar_Th1.Value) *Math.PI/ 180;
        }

        private void trackBar_Th2_Scroll(object sender, EventArgs e)
        {
            TreeTh2.Text = $"右分支角度：{trackBar_Th2.Value}";
            th2 = ((double)trackBar_Th2.Value) * Math.PI / 180;
        }
     
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
