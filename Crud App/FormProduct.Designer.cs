namespace Crud_App
{
    partial class FormProduct
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
            this.lblText = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Panel();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCoin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.Label();
            this.lblText.SuspendLayout();
            this.btnSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblText.Controls.Add(this.label1);
            this.lblText.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblText.Location = new System.Drawing.Point(0, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(548, 125);
            this.lblText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Product";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Controls.Add(this.btnSave2);
            this.btnSave.Controls.Add(this.txtNote);
            this.btnSave.Controls.Add(this.label4);
            this.btnSave.Controls.Add(this.txtCoin);
            this.btnSave.Controls.Add(this.label3);
            this.btnSave.Controls.Add(this.txtModel);
            this.btnSave.Controls.Add(this.txtName);
            this.btnSave.Location = new System.Drawing.Point(48, 163);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(446, 336);
            this.btnSave.TabIndex = 0;
            // 
            // btnSave2
            // 
            this.btnSave2.Location = new System.Drawing.Point(36, 257);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(94, 29);
            this.btnSave2.TabIndex = 5;
            this.btnSave2.Text = "Save";
            this.btnSave2.UseVisualStyleBackColor = false;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(36, 195);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(365, 27);
            this.txtNote.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Recycling Note Capacity:";
            // 
            // txtCoin
            // 
            this.txtCoin.Location = new System.Drawing.Point(36, 132);
            this.txtCoin.Name = "txtCoin";
            this.txtCoin.Size = new System.Drawing.Size(365, 27);
            this.txtCoin.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Recycling Coin Capacity:";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(36, 69);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(365, 27);
            this.txtModel.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(36, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(55, 20);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Model:";
            this.txtName.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 530);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.lblText.ResumeLayout(false);
            this.lblText.PerformLayout();
            this.btnSave.ResumeLayout(false);
            this.btnSave.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel lblText;
        private Label label1;
        private Panel btnSave;
        private TextBox txtModel;
        private Label txtName;
        private TextBox txtNote;
        private Label label4;
        private TextBox txtCoin;
        private Label label3;
        private Button btnSave2;
    }
}