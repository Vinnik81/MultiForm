
namespace HomeWork_Dictionary
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBoxFrom = new System.Windows.Forms.RichTextBox();
            this.richTextBoxTo = new System.Windows.Forms.RichTextBox();
            this.buttonSwitch = new System.Windows.Forms.Button();
            this.buttonTranslate = new System.Windows.Forms.Button();
            this.comboBoxFrom = new System.Windows.Forms.ComboBox();
            this.comboBoxTo = new System.Windows.Forms.ComboBox();
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxFrom
            // 
            this.richTextBoxFrom.Location = new System.Drawing.Point(12, 110);
            this.richTextBoxFrom.Name = "richTextBoxFrom";
            this.richTextBoxFrom.Size = new System.Drawing.Size(246, 294);
            this.richTextBoxFrom.TabIndex = 0;
            this.richTextBoxFrom.Text = "";
            this.richTextBoxFrom.MouseClick += new System.Windows.Forms.MouseEventHandler(this.richTextBoxFrom_MouseClick);
            // 
            // richTextBoxTo
            // 
            this.richTextBoxTo.Location = new System.Drawing.Point(335, 110);
            this.richTextBoxTo.Name = "richTextBoxTo";
            this.richTextBoxTo.Size = new System.Drawing.Size(246, 294);
            this.richTextBoxTo.TabIndex = 1;
            this.richTextBoxTo.Text = "";
            // 
            // buttonSwitch
            // 
            this.buttonSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSwitch.Font = new System.Drawing.Font("Elephant", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSwitch.Location = new System.Drawing.Point(271, 50);
            this.buttonSwitch.Name = "buttonSwitch";
            this.buttonSwitch.Size = new System.Drawing.Size(56, 50);
            this.buttonSwitch.TabIndex = 2;
            this.buttonSwitch.Text = "->\r\n<-";
            this.buttonSwitch.UseVisualStyleBackColor = true;
            this.buttonSwitch.Click += new System.EventHandler(this.buttonSwitch_Click);
            // 
            // buttonTranslate
            // 
            this.buttonTranslate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTranslate.Location = new System.Drawing.Point(228, 426);
            this.buttonTranslate.Name = "buttonTranslate";
            this.buttonTranslate.Size = new System.Drawing.Size(119, 36);
            this.buttonTranslate.TabIndex = 3;
            this.buttonTranslate.Text = "Перевести";
            this.buttonTranslate.UseVisualStyleBackColor = true;
            this.buttonTranslate.Click += new System.EventHandler(this.buttonTranslate_Click);
            // 
            // comboBoxFrom
            // 
            this.comboBoxFrom.FormattingEnabled = true;
            this.comboBoxFrom.Items.AddRange(new object[] {
            "Русский",
            "Английский",
            "Немецкий"});
            this.comboBoxFrom.Location = new System.Drawing.Point(22, 72);
            this.comboBoxFrom.Name = "comboBoxFrom";
            this.comboBoxFrom.Size = new System.Drawing.Size(215, 23);
            this.comboBoxFrom.TabIndex = 4;
            // 
            // comboBoxTo
            // 
            this.comboBoxTo.FormattingEnabled = true;
            this.comboBoxTo.Items.AddRange(new object[] {
            "Русский",
            "Английский",
            "Немецкий"});
            this.comboBoxTo.Location = new System.Drawing.Point(348, 72);
            this.comboBoxTo.Name = "comboBoxTo";
            this.comboBoxTo.Size = new System.Drawing.Size(215, 23);
            this.comboBoxTo.TabIndex = 5;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Font = new System.Drawing.Font("Stencil", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFrom.Location = new System.Drawing.Point(22, 28);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(49, 26);
            this.labelFrom.TabIndex = 6;
            this.labelFrom.Text = "Из:";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Stencil", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTo.Location = new System.Drawing.Point(348, 28);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(50, 26);
            this.labelTo.TabIndex = 7;
            this.labelTo.Text = "На:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 474);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.comboBoxTo);
            this.Controls.Add(this.comboBoxFrom);
            this.Controls.Add(this.buttonTranslate);
            this.Controls.Add(this.buttonSwitch);
            this.Controls.Add(this.richTextBoxTo);
            this.Controls.Add(this.richTextBoxFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxFrom;
        private System.Windows.Forms.RichTextBox richTextBoxTo;
        private System.Windows.Forms.Button buttonSwitch;
        private System.Windows.Forms.Button buttonTranslate;
        private System.Windows.Forms.ComboBox comboBoxFrom;
        private System.Windows.Forms.ComboBox comboBoxTo;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
    }
}

