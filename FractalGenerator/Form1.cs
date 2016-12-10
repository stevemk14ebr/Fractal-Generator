using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalGenerator
{
    public partial class Form1 : Form
    {
        int StartHeight = 100;
        FractalLine Trunk = null;
        bool Draw = false;

        double ShrinkRate;
        double AngleDelta;
        int SplitDepth;
        public Form1()
        {
            InitializeComponent();
            UpdateParameters();
        }

        //Invoke an action on the UI thread
        public void InvokeUI(Action a)
        {
            this.Invoke(a);
        }

        private void UpdateParameters()
        {
            AngleDelta = TrackAngleDelta.Value;
            ShrinkRate = (double)TrackShrinkRatio.Value / TrackShrinkRatio.Maximum;
            SplitDepth = TrackSplitDepth.Value;
        }

        private void DrawCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (Draw == false)
                return;

            Pen pen = new Pen(Color.Black, 2);
            Trunk.Draw(e.Graphics, pen);
        }

        private void AddBranch(FractalLine parent,int Depth)
        {
            if (Depth > SplitDepth || Draw == false)
                return;

            double Angle1 = parent.m_Angle - AngleDelta;
            double Angle2 = parent.m_Angle + AngleDelta;

            FractalLine line = new FractalLine(parent.m_End, (int)(parent.CalcLength() * ShrinkRate), Angle1, parent);
            FractalLine line2 = new FractalLine(parent.m_End, (int)(parent.CalcLength() * ShrinkRate), Angle2, parent);

            System.Threading.Thread.Sleep(Int32.Parse(txtAnimDelay.Text));

            //UI commands must be invoked on ui thread
            Action a = () => DrawCanvas.Refresh();
            InvokeUI(a);

            /*Take turns on which side goes first,
             * This prevents one side of the tree from completing first*/
            if(Depth % 2 ==0)
            {
                AddBranch(line, Depth + 1);
                AddBranch(line2, Depth + 1);
            }else{
                AddBranch(line2, Depth + 1);
                AddBranch(line, Depth + 1);
            }
        }

        private void BtnDraw_Click(object sender, EventArgs e)
        {
            Draw = true;
            UpdateParameters();
            //Run in new thread to keep UI responsive
            Task.Run( () =>
            {
                int MiddleCanvasX = DrawCanvas.Size.Width / 2;
                Trunk = new FractalLine(new Point(MiddleCanvasX, DrawCanvas.Size.Height), StartHeight, 90, null);

                AddBranch(Trunk, 0);
                DrawCanvas.Invalidate();
            });
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Draw = false;
        }
    }
}
