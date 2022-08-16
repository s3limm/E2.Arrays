namespace ucak_bıletı_operasyonu
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "kalkış";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(422, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "varış";
            // 
            // cmbFrom
            // 
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Location = new System.Drawing.Point(195, 200);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(170, 21);
            this.cmbFrom.TabIndex = 1;
            this.cmbFrom.SelectedValueChanged += new System.EventHandler(this.cmbFrom_SelectedValueChanged);
            // 
            // cmbTo
            // 
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Location = new System.Drawing.Point(521, 200);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(180, 21);
            this.cmbTo.TabIndex = 1;
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Tai Le", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.Location = new System.Drawing.Point(556, 333);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(145, 50);
            this.btnBuy.TabIndex = 2;
            this.btnBuy.Text = "Satın Al";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.cmbTo);
            this.Controls.Add(this.cmbFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFrom;
        private System.Windows.Forms.ComboBox cmbTo;
        private System.Windows.Forms.Button btnBuy;
    }
}

