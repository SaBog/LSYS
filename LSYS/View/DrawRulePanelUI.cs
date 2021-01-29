using System;
using System.Drawing;
using System.Windows.Forms;
using LSYS.Paint;

namespace LSYS.View
{
    public partial class DrawRulePanelUI : UserControl
    {
        private RuleControlState diesabledState;
        private RuleControlState enabledState;

        private bool formEnabled = false;
        public bool IsEnabled => formEnabled;

        public DrawRulePanelUI()
        {
            InitializeComponent();
            InsideBuild();

        }
        private void InsideBuild()
        {
            diesabledState = new RuleControlState()
            {
                color = Color.FromKnownColor(KnownColor.ActiveBorder),
                buttonCaption = "Submit"
            };

            enabledState = new RuleControlState()
            {
                color = Color.FromKnownColor(KnownColor.LimeGreen),
                buttonCaption = "Cancel"
            };

            var drawRulesModes = SimpleActionHelper.EnumProperties();
            actionSelecter.Items.AddRange(drawRulesModes);
            actionSelecter.SelectedIndex = 0;
        }

        public DrawRulePanelUI(DrawingRule rule): this()
        {
            latterBox.Text = rule.cause.ToString();
            valueBox.Text = rule.value.ToString();
            actionSelecter.Text = rule.action.ToString();
            colorPicker.BackColor = rule.PenColor;

            formEnabled = true;
            ApplyStateConfuguration(enabledState);
        }


        public DrawingRule FormDrawRuleFromUI()
        {
            float.TryParse(valueBox.Text, out float value);

            DrawingRule dr = new DrawingRule()
            {
                cause = latterBox.Text[0],
                value = value,
                action = SimpleActionHelper.PropertyFromString(actionSelecter.Text),
                PenColor = colorPicker.BackColor
            };

            return dr;
        }

        private void Submit(object sender, EventArgs e)
        {
            formEnabled = !formEnabled;
            ApplyStateConfuguration(formEnabled ? enabledState : diesabledState);
        }

        private void ApplyStateConfuguration(RuleControlState state)
        {
            BackColor = state.color;
            btnSubmit.Text = state.buttonCaption;
        }

        private void Delete(object sender, EventArgs e)
        {
            Dispose();
        }

        private void СolorDialogOpen(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                colorPicker.BackColor = colorDialog.Color;
            }
        }
    }

    public class RuleControlState
    {
        public Color color;
        public string buttonCaption;
    }
}
