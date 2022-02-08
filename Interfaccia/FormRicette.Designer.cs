namespace Interfaccia
{
    partial class FormRicette
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
            this.cb_ricette = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grd_ingredienti = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ingredienti)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_ricette
            // 
            this.cb_ricette.FormattingEnabled = true;
            this.cb_ricette.Location = new System.Drawing.Point(12, 47);
            this.cb_ricette.Name = "cb_ricette";
            this.cb_ricette.Size = new System.Drawing.Size(391, 28);
            this.cb_ricette.TabIndex = 0;
            this.cb_ricette.SelectedIndexChanged += new System.EventHandler(this.cb_ricette_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ricette disponibili:";
            // 
            // grd_ingredienti
            // 
            this.grd_ingredienti.AllowUserToAddRows = false;
            this.grd_ingredienti.AllowUserToDeleteRows = false;
            this.grd_ingredienti.AllowUserToResizeColumns = false;
            this.grd_ingredienti.AllowUserToResizeRows = false;
            this.grd_ingredienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_ingredienti.Location = new System.Drawing.Point(12, 81);
            this.grd_ingredienti.MultiSelect = false;
            this.grd_ingredienti.Name = "grd_ingredienti";
            this.grd_ingredienti.RowHeadersWidth = 51;
            this.grd_ingredienti.RowTemplate.Height = 29;
            this.grd_ingredienti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_ingredienti.Size = new System.Drawing.Size(391, 357);
            this.grd_ingredienti.TabIndex = 2;
            // 
            // FormRicette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 450);
            this.Controls.Add(this.grd_ingredienti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_ricette);
            this.Name = "FormRicette";
            this.Text = "Ricette Pasticceria";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRicette_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.grd_ingredienti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_ricette;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grd_ingredienti;
    }
}