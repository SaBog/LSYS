using LSYS.Paint;
using LSYS.Sys;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSYS
{
    public partial class UI : Form
    {

        private ModelData modelData;
        private PaintData paintData;
        private Model model;
        private DrawRanger drawRanger;

        public UI()
        {
            InitializeComponent();
            canvas.Image = new Bitmap(canvas.Size.Width, canvas.Size.Height);

            modelData = new ModelData();
            paintData = new PaintData()
            {
                size = canvas.Size
            };
        }

        private async void GenerateClick(object sender, EventArgs e)
        {
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();

            if (modelData.updated || !model.HasValue(iterationTrackBar.Value))
            {
                model = new Model(modelData);

                var iterationCount = iterationTrackBar.Value;
                await Task.Run(() => model.Start(iterationCount));
                modelData.updated = false;
            }


            //stopwatch.Stop();
            //MessageBox.Show((stopwatch.ElapsedMilliseconds).ToString());

            Draw();
        }

        public async void Draw()
        {
            if (model != null && model.HasValue(iterationTrackBar.Value))
            {
                paintData.instruction = model.GetValue(iterationTrackBar.Value);
                drawRanger = new DrawRanger(paintData);

                var result = await Task.Run(() => drawRanger.Draw(center));
                canvas.Image = result;
            }
        }

        public void SetMetaData()
        {
            metadata.Text = modelData.ToString();
        }

        private void IterationTrackBarScrolling(object sender, EventArgs e)
        {
            iterationLabel.Text = "Iter: " + iterationTrackBar.Value;
        }

        Point center;

        private void CanvasClick(object sender, EventArgs e)
        {
            
            //MessageBox.Show("Хотите открыть в новом окне?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            MouseEventArgs me = (MouseEventArgs)e;
            center = me.Location;

            Graphics g = canvas.CreateGraphics();
            g.Clear(SystemColors.ControlLight);

            var blackPen = new SolidBrush(Color.Black);
            g.FillEllipse(blackPen, center.X - 5, center.Y - 5, 10, 10);
        }

        private void DataDialogOpen(object sender, EventArgs e)
        {
            GetTextFromUserDialogMenu();
            SetMetaData();
        }

        private void GetTextFromUserDialogMenu()
        {
            using (TextDialog dialogForm = new TextDialog())
            {
                if (dialogForm.ShowDialog() == DialogResult.OK)
                {
                    modelData.axiom = dialogForm.Axiom;
                    var rules = dialogForm.Rules;

                    modelData.rules = SimpleRule.FromString(rules, new string[] { " ", "\n", ".", "\t" });
                    modelData.updated = true;

                }
            }
        }

        private void VarActionDialogOpen(object sender, EventArgs e)
        {
            using (DialogRules dialogForm = new DialogRules())
            {
                if (dialogForm.ShowDialog() == DialogResult.OK)
                {
                    paintData.drawingRules = dialogForm.GetDrawingRules();
                }
            }
        }

        private void DrawClick(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
