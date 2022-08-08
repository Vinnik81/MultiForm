
namespace HomeWork_Dictionary
{
    partial class Form2
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
            this.labelRu = new System.Windows.Forms.Label();
            this.labelDe = new System.Windows.Forms.Label();
            this.labelEn = new System.Windows.Forms.Label();
            this.listBoxRu = new System.Windows.Forms.ListBox();
            this.listBoxEn = new System.Windows.Forms.ListBox();
            this.listBoxDe = new System.Windows.Forms.ListBox();
            this.textBoxRu = new System.Windows.Forms.TextBox();
            this.textBoxEn = new System.Windows.Forms.TextBox();
            this.textBoxDe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelRu
            // 
            this.labelRu.AutoSize = true;
            this.labelRu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRu.Location = new System.Drawing.Point(78, 75);
            this.labelRu.Name = "labelRu";
            this.labelRu.Size = new System.Drawing.Size(67, 21);
            this.labelRu.TabIndex = 0;
            this.labelRu.Text = "Русский";
            // 
            // labelDe
            // 
            this.labelDe.AutoSize = true;
            this.labelDe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDe.Location = new System.Drawing.Point(489, 75);
            this.labelDe.Name = "labelDe";
            this.labelDe.Size = new System.Drawing.Size(84, 21);
            this.labelDe.TabIndex = 1;
            this.labelDe.Text = "Немецкий";
            // 
            // labelEn
            // 
            this.labelEn.AutoSize = true;
            this.labelEn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEn.Location = new System.Drawing.Point(275, 75);
            this.labelEn.Name = "labelEn";
            this.labelEn.Size = new System.Drawing.Size(94, 21);
            this.labelEn.TabIndex = 2;
            this.labelEn.Text = "Английский";
            // 
            // listBoxRu
            // 
            this.listBoxRu.FormattingEnabled = true;
            this.listBoxRu.ItemHeight = 15;
            this.listBoxRu.Location = new System.Drawing.Point(29, 161);
            this.listBoxRu.Name = "listBoxRu";
            this.listBoxRu.Size = new System.Drawing.Size(182, 259);
            this.listBoxRu.TabIndex = 3;
            // 
            // listBoxEn
            // 
            this.listBoxEn.FormattingEnabled = true;
            this.listBoxEn.ItemHeight = 15;
            this.listBoxEn.Location = new System.Drawing.Point(234, 161);
            this.listBoxEn.Name = "listBoxEn";
            this.listBoxEn.Size = new System.Drawing.Size(194, 259);
            this.listBoxEn.TabIndex = 4;
            // 
            // listBoxDe
            // 
            this.listBoxDe.FormattingEnabled = true;
            this.listBoxDe.ItemHeight = 15;
            this.listBoxDe.Location = new System.Drawing.Point(449, 161);
            this.listBoxDe.Name = "listBoxDe";
            this.listBoxDe.Size = new System.Drawing.Size(178, 259);
            this.listBoxDe.TabIndex = 5;
            // 
            // textBoxRu
            // 
            this.textBoxRu.Location = new System.Drawing.Point(29, 110);
            this.textBoxRu.Name = "textBoxRu";
            this.textBoxRu.Size = new System.Drawing.Size(182, 23);
            this.textBoxRu.TabIndex = 6;
            this.textBoxRu.TextChanged += new System.EventHandler(this.textBoxRu_TextChanged);
            this.textBoxRu.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxRu_KeyUp);
            // 
            // textBoxEn
            // 
            this.textBoxEn.Location = new System.Drawing.Point(234, 110);
            this.textBoxEn.Name = "textBoxEn";
            this.textBoxEn.Size = new System.Drawing.Size(194, 23);
            this.textBoxEn.TabIndex = 7;
            this.textBoxEn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxEn_KeyUp);
            // 
            // textBoxDe
            // 
            this.textBoxDe.Location = new System.Drawing.Point(449, 110);
            this.textBoxDe.Name = "textBoxDe";
            this.textBoxDe.Size = new System.Drawing.Size(182, 23);
            this.textBoxDe.TabIndex = 8;
            this.textBoxDe.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxDe_KeyUp);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 450);
            this.Controls.Add(this.textBoxDe);
            this.Controls.Add(this.textBoxEn);
            this.Controls.Add(this.textBoxRu);
            this.Controls.Add(this.listBoxDe);
            this.Controls.Add(this.listBoxEn);
            this.Controls.Add(this.listBoxRu);
            this.Controls.Add(this.labelEn);
            this.Controls.Add(this.labelDe);
            this.Controls.Add(this.labelRu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "AddWords";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRu;
        private System.Windows.Forms.Label labelDe;
        private System.Windows.Forms.Label labelEn;
        public System.Windows.Forms.ListBox listBoxRu;
        public System.Windows.Forms.ListBox listBoxEn;
        public System.Windows.Forms.ListBox listBoxDe;
        private System.Windows.Forms.TextBox textBoxRu;
        private System.Windows.Forms.TextBox textBoxEn;
        private System.Windows.Forms.TextBox textBoxDe;
    }
}