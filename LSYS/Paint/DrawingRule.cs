using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Xml.Serialization;

namespace LSYS.Paint
{
    public enum SimpleAction
    {
        None,
        DrawLine,
        Rotate,
        Save,
        Back
    }

    public class SimpleActionHelper
    {
        private static Dictionary<string, SimpleAction> pairs = new Dictionary<string, SimpleAction>()
            {
                { "None", SimpleAction.None },
                { "Rotate", SimpleAction.Rotate },
                { "DrawLine", SimpleAction.DrawLine },
                { "Save", SimpleAction.Save },
                { "Back", SimpleAction.Back }
            };

        public static string[] EnumProperties()
        {
            return pairs.Keys.ToArray();
        }

        public static SimpleAction PropertyFromString(string key)
        {
            return pairs[key];
        }
    }

    public struct DrawingRule
    {
        public char cause;
        public SimpleAction action;

        public float value;

        [XmlIgnore]
        public Pen pen;

        [XmlIgnore]
        public Color PenColor
        {
            get => pen.Color;
            set => pen = new Pen(value);
        }

        [XmlElement("XmlColor")]
        public int ColorAsArgb
        {
            get { return PenColor.ToArgb(); }
            set { PenColor = Color.FromArgb(value); }
        }

    }
}
