using System.Collections.Generic;

namespace LSYS.Sys
{
    public class ModelData
    {
        public bool updated;

        public char[] constraints;
        public char[] variables;
        public SimpleRule[] rules;

        public string axiom;

        public string GetConstraints()
            => GetCollection(collection: constraints);

        public string GetVariables()
            => GetCollection(collection: variables);

        public string GetRules()
            => GetCollection(collection: rules, delimiter: '\n');

        public override string ToString()
        {
            var output = "Program detected:\n" +
                $"Variables: {GetVariables()}\n" +
                $"Constants: {GetConstraints()}\n" +
                $"Axiom: {axiom}\n" +
                $"Rules:\n{GetRules()}";

            return output;
        }


        private string GetCollection<T>(ICollection<T> collection, char delimiter = ' ')
        {
            string output = "";


            if (collection != null)
            {
                foreach (var item in collection)
                {
                    output += $"{item}{delimiter}";
                }

            }
            return output;
        }
    }
}
