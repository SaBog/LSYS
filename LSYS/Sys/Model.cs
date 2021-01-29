using System.Collections.Generic;
using System.Text;

namespace LSYS.Sys
{
    class Model
    {
        private readonly SimpleRule[] rules;
        private string currentLine;
        private int step;
        private List<string> iterationValues;

        public string ResultValue => currentLine;

        public bool HasValue(int step)
        {
            return step > 0 && step < iterationValues.Count;
        }

        public string GetValue(int step)
        {
            return iterationValues[step];
        }

        public Model(ModelData data)
        {
            currentLine = data.axiom;
            rules = data.rules;
        }

        public void Start(int iteration)
        {
            iterationValues = new List<string>();
            step = iteration;


            Recursive();
        }

        private void Recursive()
        {
            iterationValues.Add(currentLine);

            if (step-- <= 0)
            {
                return;
            }

            currentLine = SimpleLineSplitting(currentLine);
            Recursive();
        }

        private string SimpleLineSplitting(string line)
        {
            StringBuilder stringBuilder = new StringBuilder();
            bool fl;

            foreach (var latter in line)
            {
                fl = true;

                foreach (var rule in rules)
                {
                    if (latter.Equals(rule.from))
                    {
                        stringBuilder.Append(rule.to);
                        fl = false;
                        break;
                    }
                }

                if (fl)
                {
                    stringBuilder.Append(latter);
                }
            }

            return stringBuilder.ToString();
        }
    }


}
