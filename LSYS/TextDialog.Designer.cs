
namespace LSYS
{
    partial class TextDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rules = new System.Windows.Forms.RichTextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.apply = new System.Windows.Forms.Button();
            this.caption = new System.Windows.Forms.Label();
            this.removeSpace = new System.Windows.Forms.CheckBox();
            this.axiom = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rules
            // 
            this.rules.Location = new System.Drawing.Point(117, 122);
            this.rules.Name = "rules";
            this.rules.Size = new System.Drawing.Size(374, 203);
            this.rules.TabIndex = 0;
            this.rules.Text = "";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(14, 346);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(87, 27);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.Cancel);
            // 
            // apply
            // 
            this.apply.Location = new System.Drawing.Point(404, 346);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(87, 27);
            this.apply.TabIndex = 2;
            this.apply.Text = "Apply";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.Apply);
            // 
            // caption
            // 
            this.caption.Location = new System.Drawing.Point(14, 9);
            this.caption.Name = "caption";
            this.caption.Size = new System.Drawing.Size(636, 20);
            this.caption.TabIndex = 3;
            // 
            // removeSpace
            // 
            this.removeSpace.AutoSize = true;
            this.removeSpace.Location = new System.Drawing.Point(14, 306);
            this.removeSpace.Name = "removeSpace";
            this.removeSpace.Size = new System.Drawing.Size(94, 19);
            this.removeSpace.TabIndex = 4;
            this.removeSpace.Text = "Space is evil";
            this.removeSpace.UseVisualStyleBackColor = true;
            // 
            // axiom
            // 
            this.axiom.Location = new System.Drawing.Point(117, 12);
            this.axiom.Name = "axiom";
            this.axiom.Size = new System.Drawing.Size(374, 104);
            this.axiom.TabIndex = 5;
            this.axiom.Text = "";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Axiom:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Rules:";
            // 
            // TextDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 381);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.axiom);
            this.Controls.Add(this.removeSpace);
            this.Controls.Add(this.caption);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.rules);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "TextDialog";
            this.Text = "TextDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rules;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.Label caption;
        private System.Windows.Forms.CheckBox removeSpace;
        private System.Windows.Forms.RichTextBox axiom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}