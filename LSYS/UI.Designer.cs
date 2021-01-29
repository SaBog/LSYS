
namespace LSYS
{
    partial class UI
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.canvas = new System.Windows.Forms.PictureBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.metadata = new System.Windows.Forms.RichTextBox();
            this.ldata = new System.Windows.Forms.Button();
            this.varAction = new System.Windows.Forms.Button();
            this.iterationTrackBar = new System.Windows.Forms.TrackBar();
            this.iterationLabel = new System.Windows.Forms.Label();
            this.drawer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.canvas, "canvas");
            this.canvas.Name = "canvas";
            this.canvas.TabStop = false;
            this.canvas.Click += new System.EventHandler(this.CanvasClick);
            // 
            // btnGen
            // 
            resources.ApplyResources(this.btnGen, "btnGen");
            this.btnGen.Name = "btnGen";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.GenerateClick);
            // 
            // progressBar
            // 
            resources.ApplyResources(this.progressBar, "progressBar");
            this.progressBar.Name = "progressBar";
            // 
            // metadata
            // 
            resources.ApplyResources(this.metadata, "metadata");
            this.metadata.Name = "metadata";
            this.metadata.ReadOnly = true;
            // 
            // ldata
            // 
            resources.ApplyResources(this.ldata, "ldata");
            this.ldata.Name = "ldata";
            this.ldata.UseVisualStyleBackColor = true;
            this.ldata.Click += new System.EventHandler(this.DataDialogOpen);
            // 
            // varAction
            // 
            resources.ApplyResources(this.varAction, "varAction");
            this.varAction.Name = "varAction";
            this.varAction.UseVisualStyleBackColor = true;
            this.varAction.Click += new System.EventHandler(this.VarActionDialogOpen);
            // 
            // iterationTrackBar
            // 
            resources.ApplyResources(this.iterationTrackBar, "iterationTrackBar");
            this.iterationTrackBar.Maximum = 20;
            this.iterationTrackBar.Name = "iterationTrackBar";
            this.iterationTrackBar.Scroll += new System.EventHandler(this.IterationTrackBarScrolling);
            // 
            // iterationLabel
            // 
            resources.ApplyResources(this.iterationLabel, "iterationLabel");
            this.iterationLabel.Name = "iterationLabel";
            // 
            // drawer
            // 
            resources.ApplyResources(this.drawer, "drawer");
            this.drawer.Name = "drawer";
            this.drawer.UseVisualStyleBackColor = true;
            this.drawer.Click += new System.EventHandler(this.DrawClick);
            // 
            // UI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.drawer);
            this.Controls.Add(this.iterationLabel);
            this.Controls.Add(this.iterationTrackBar);
            this.Controls.Add(this.varAction);
            this.Controls.Add(this.ldata);
            this.Controls.Add(this.metadata);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.canvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "UI";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button btnGen;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.RichTextBox metadata;
        private System.Windows.Forms.Button ldata;
        private System.Windows.Forms.Button varAction;
        private System.Windows.Forms.TrackBar iterationTrackBar;
        private System.Windows.Forms.Label iterationLabel;
        private System.Windows.Forms.Button drawer;
    }
}

