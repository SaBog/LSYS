using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

namespace LSYS.Paint
{
    public class DrawRanger
    {
        private Graphics canvas;

        private List<DrawingRule> drawingRules;
        private Stack<DrawState> points;

        private Bitmap image;
        private string instruction;

        public DrawRanger(PaintData paintData)
        {
            var size = paintData.size;
            image = new Bitmap(size.Width, size.Height);

            drawingRules = paintData.drawingRules;
            instruction = paintData.instruction;

            points = new Stack<DrawState>();
            canvas = Graphics.FromImage(image);
        }

        public Bitmap Draw(PointF startPoint)
        {
            x = startPoint.X;
            y = startPoint.Y;

            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();

            Dictionary<char, DrawingRule> pairs = new Dictionary<char, DrawingRule>();
            drawingRules.ForEach(e => pairs.Add(e.cause, e));

            foreach (var latter in instruction)
            {
                if (pairs.ContainsKey(latter))
                {
                    MakeAction(pairs[latter]);
                }
            }

            //stopwatch.Stop();
            //System.Windows.Forms.MessageBox.Show((stopwatch.ElapsedMilliseconds).ToString());

            return image;
        }

        float angle = 0f;
        double rad;

        float onx;
        float ony;

        float x;
        float y;

        float xNew;
        float yNew;

        private bool angleUpdated = true;
        private const double euler2rad = Math.PI / 180;

        private void MakeAction(DrawingRule rule)
        {

            switch (rule.action)
            {
                case SimpleAction.None:
                    break;
                case SimpleAction.DrawLine:
                    var len = rule.value;

                    if (angleUpdated)
                    {
                        rad = angle * euler2rad;

                        onx = (float)Math.Cos(rad);
                        ony = (float)Math.Sin(rad);

                        angleUpdated = false;
                    }

                    xNew = x + len * onx;
                    yNew = y + len * ony;

                    if (!(xNew > image.Width || yNew > image.Height || xNew < -1 || yNew < -1))
                    {
                        canvas.DrawLine(rule.pen, x, y, xNew, yNew);

                    }

                    x = xNew;
                    y = yNew;

                    break;

                case SimpleAction.Rotate:
                    angle += rule.value;
                    angleUpdated = true;
                    break;

                case SimpleAction.Save:
                    var pushState = new DrawState(new PointF(x, y), angle);
                    points.Push(pushState);
                    break;

                case SimpleAction.Back:
                    if (points.Count > 0)
                    {
                        var popState = points.Pop();
                        x = popState.point.X;
                        y = popState.point.Y;
                        angle = popState.angle;
                    }
                    break;
            }

        }
    }
}
