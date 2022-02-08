namespace Interfaccia
{
    partial class FormMenu
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
            this.btn_ricette = new System.Windows.Forms.Button();
            this.btn_vetrina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ricette
            // 
            this.btn_ricette.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ricette.Location = new System.Drawing.Point(12, 12);
            this.btn_ricette.Name = "btn_ricette";
            this.btn_ricette.Size = new System.Drawing.Size(316, 69);
            this.btn_ricette.TabIndex = 0;
            this.btn_ricette.Text = "MOSTRA RICETTE";
            this.btn_ricette.UseVisualStyleBackColor = true;
            this.btn_ricette.Click += new System.EventHandler(this.btn_ricette_Click);
            // 
            // btn_vetrina
            // 
            this.btn_vetrina.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_vetrina.Location = new System.Drawing.Point(12, 109);
            this.btn_vetrina.Name = "btn_vetrina";
            this.btn_vetrina.Size = new System.Drawing.Size(316, 69);
            this.btn_vetrina.TabIndex = 1;
            this.btn_vetrina.Text = "VETRINA NEGOZIO";
            this.btn_vetrina.UseVisualStyleBackColor = true;
            this.btn_vetrina.Click += new System.EventHandler(this.btn_vetrina_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 190);
            this.Controls.Add(this.btn_vetrina);
            this.Controls.Add(this.btn_ricette);
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.Text = "Menu Pasticceria";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMenu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ricette;
        private System.Windows.Forms.Button btn_vetrina;
    }
}