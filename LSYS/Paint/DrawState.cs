using System.Drawing;

namespace LSYS.Paint
{
    public struct DrawState
    {
        public PointF point;
        public float angle;

        public DrawState(PointF pt, float ang)
        {
            point = pt;
            angle = ang;
        }

    }

}
