namespace Trabajo_de_campo_final.Vista
{
    partial class test
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
            this.btnDevolverPersona = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDevolverPersona
            // 
            this.btnDevolverPersona.Location = new System.Drawing.Point(371, 102);
            this.btnDevolverPersona.Name = "btnDevolverPersona";
            this.btnDevolverPersona.Size = new System.Drawing.Size(75, 23);
            this.btnDevolverPersona.TabIndex = 0;
            this.btnDevolverPersona.Text = "devolver persona";
            this.btnDevolverPersona.UseVisualStyleBackColor = true;
            this.btnDevolverPersona.Click += new System.EventHandler(this.btnDevolverPersona_Click);
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDevolverPersona);
            this.Name = "test";
            this.Text = "test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDevolverPersona;
    }
}