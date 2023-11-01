namespace EjemplosWindowsForm
{
    partial class frmInteres
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
            this.txtTotalInteres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMontoFinal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Interés:";
            // 
            // txtTotalInteres
            // 
            this.txtTotalInteres.Location = new System.Drawing.Point(101, 22);
            this.txtTotalInteres.Name = "txtTotalInteres";
            this.txtTotalInteres.Size = new System.Drawing.Size(152, 23);
            this.txtTotalInteres.TabIndex = 1;
            this.txtTotalInteres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTotalInteres_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monto Final:";
            // 
            // txtMontoFinal
            // 
            this.txtMontoFinal.Location = new System.Drawing.Point(101, 63);
            this.txtMontoFinal.Name = "txtMontoFinal";
            this.txtMontoFinal.Size = new System.Drawing.Size(152, 23);
            this.txtMontoFinal.TabIndex = 3;
            // 
            // frmInteres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 126);
            this.Controls.Add(this.txtMontoFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalInteres);
            this.Controls.Add(this.label1);
            this.Name = "frmInteres";
            this.Text = "frmInteres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtTotalInteres;
        private Label label2;
        private TextBox txtMontoFinal;
    }
}