using LSYS.View;
using LSYS.Paint;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace LSYS
{
    public partial class DialogRules : Form
    {
        private string fileName;

        public DialogRules(string configurationFileName = "file.xml")
        {
            InitializeComponent();
            fileName = configurationFileName;
            DesirializeRules();
        }

        private void CreateNewForm(object sender, EventArgs e)
        {
            new DrawRulePanelUI().Parent = flowLayoutPanel1;
        }

        public List<DrawingRule> GetDrawingRules()
        {
            List<DrawingRule> rules = new List<DrawingRule>();

            foreach (var item in flowLayoutPanel1.Controls)
            {
                if (item is DrawRulePanelUI)
                {
                    var formRule = item as DrawRulePanelUI;

                    if (formRule.IsEnabled)
                    {
                        var drawRule = formRule.FormDrawRuleFromUI();   
                        rules.Add(drawRule);
                    }

                }

            }

            return rules;
        }

        private void Exit(object sender, EventArgs e)
        {
            SerializeRules();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void SerializeRules()
        {             
            try
            {
                List<DrawingRule> rules = GetDrawingRules();

                XmlSerializer formatter = new XmlSerializer(typeof(List<DrawingRule>));

                using (FileStream fs = new FileStream(fileName, FileMode.Create))
                {
                    formatter.Serialize(fs, rules);
                }

            }
            catch
            {

            }

        }

        private void DesirializeRules()
        {
            try
            {
                List<DrawingRule> rules;

                XmlSerializer formatter = new XmlSerializer(typeof(List<DrawingRule>));

                using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
                {
                    rules = (List<DrawingRule>)formatter.Deserialize(fs);
                }

                foreach (var item in rules)
                {
                    new DrawRulePanelUI(item).Parent = flowLayoutPanel1;

                }
            }
            catch
            {

            }
        }
    }
}
