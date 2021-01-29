using System;
using System.Windows.Forms;

namespace LSYS
{
    public partial class TextDialog : Form
    {
        public string Axiom => FormatText(axiom.Text);
        public string Rules => FormatText(rules.Text);

        public TextDialog()
        {
            InitializeComponent();
            ReadSettings();
        }

        private void ReadSettings()
        {
            var conf = Properties.Settings.Default;

            axiom.Text = conf.axiom;
            rules.Text = conf.rules;
        }

        private void SaveSettings()
        {
            var conf = Properties.Settings.Default;

            conf.axiom = axiom.Text;
            conf.rules = rules.Text;
        }

        private void Cancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Apply(object sender, EventArgs e)
        {
            SaveSettings();
            DialogResult = DialogResult.OK;
            Close();
        }

        private string FormatText(string input)
        {
            string text = input;

            if (removeSpace.Checked)
            {
                text = string.Join("", text.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
            }

            return text;
        }
    }
}
