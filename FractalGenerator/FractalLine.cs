using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalGenerator
{
    class FractalLine
    {
        public FractalLine(Point Start, int Length,double Degrees, FractalLine parent)
        {
            m_Children = new List<FractalLine>();
            m_Start = Start;

            m_Angle = Degrees;
            double Radians = (Math.PI / 180.0) * Degrees;
            int Y = (int)(Math.Sin(Radians) * Length);
            int X = (int)(Math.Cos(Radians) * Length);
            m_End = new Point(Start.X + X,Start.Y-Y);

            m_Parent = parent;
            if (m_Parent != null)
                m_Parent.m_Children.Add(this);
        }

        public int CalcLength()
        {
            return (int)Math.Sqrt(Math.Pow(m_End.X - m_Start.X, 2) + Math.Pow(m_End.Y - m_Start.Y, 2));
        }

        public void Draw(Graphics g, Pen color)
        {
            g.DrawLine(color, m_Start, m_End);
            foreach(FractalLine line in m_Children)
            {
                line.Draw(g,color);
            }
        }

        public Point m_Start;
        public Point m_End;
        public FractalLine m_Parent;
        public List<FractalLine> m_Children;
        public double m_Angle;
    }
}
