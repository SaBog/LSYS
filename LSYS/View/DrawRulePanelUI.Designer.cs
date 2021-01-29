
namespace LSYS.View
{
    partial class DrawRulePanelUI
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.description = new System.Windows.Forms.Label();
            this.latterBox = new System.Windows.Forms.TextBox();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.actionSelecter = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.colorPicker = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.description.Location = new System.Drawing.Point(13, 13);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(48, 13);
            this.description.TabIndex = 3;
            this.description.Text = "Variable:";
            // 
            // latterBox
            // 
            this.latterBox.Location = new System.Drawing.Point(74, 10);
            this.latterBox.MaxLength = 0;
            this.latterBox.Name = "latterBox";
            this.latterBox.Size = new System.Drawing.Size(54, 20);
            this.latterBox.TabIndex = 2;
            // 
            // valueBox
            // 
            this.valueBox.Location = new System.Drawing.Point(74, 36);
            this.valueBox.MaxLength = 0;
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(54, 20);
            this.valueBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(172, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Type:";
            // 
            // actionSelecter
            // 
            this.actionSelecter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actionSelecter.FormattingEnabled = true;
            this.actionSelecter.Location = new System.Drawing.Point(214, 10);
            this.actionSelecter.Name = "actionSelecter";
            this.actionSelecter.Size = new System.Drawing.Size(132, 21);
            this.actionSelecter.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSubmit.Location = new System.Drawing.Point(229, 39);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(70, 23);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.Submit);
            // 
            // delete
            // 
            this.delete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.delete.Location = new System.Drawing.Point(305, 39);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(70, 23);
            this.delete.TabIndex = 10;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.Delete);
            // 
            // colorPicker
            // 
            this.colorPicker.BackColor = System.Drawing.Color.Red;
            this.colorPicker.Location = new System.Drawing.Point(354, 10);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(21, 21);
            this.colorPicker.TabIndex = 11;
            this.colorPicker.UseVisualStyleBackColor = false;
            this.colorPicker.Click += new System.EventHandler(this.СolorDialogOpen);
            // 
            // UserControl1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.colorPicker);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.actionSelecter);
            this.Controls.Add(this.valueBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.description);
            this.Controls.Add(this.latterBox);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(395, 67);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label description;
        private System.Windows.Forms.TextBox latterBox;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox actionSelecter;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button colorPicker;
    }
}
