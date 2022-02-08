namespace Interfaccia
{
    partial class FormVetrina
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
            this.cb_dolci = new System.Windows.Forms.ComboBox();
            this.grd_vetrina = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_aggiungi = new System.Windows.Forms.Button();
            this.btn_elimina = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd_vetrina)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_dolci
            // 
            this.cb_dolci.FormattingEnabled = true;
            this.cb_dolci.Location = new System.Drawing.Point(73, 46);
            this.cb_dolci.Name = "cb_dolci";
            this.cb_dolci.Size = new System.Drawing.Size(205, 28);
            this.cb_dolci.TabIndex = 0;
            // 
            // grd_vetrina
            // 
            this.grd_vetrina.AllowUserToAddRows = false;
            this.grd_vetrina.AllowUserToDeleteRows = false;
            this.grd_vetrina.AllowUserToResizeColumns = false;
            this.grd_vetrina.AllowUserToResizeRows = false;
            this.grd_vetrina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_vetrina.Location = new System.Drawing.Point(12, 101);
            this.grd_vetrina.MultiSelect = false;
            this.grd_vetrina.Name = "grd_vetrina";
            this.grd_vetrina.RowHeadersWidth = 51;
            this.grd_vetrina.RowTemplate.Height = 29;
            this.grd_vetrina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_vetrina.Size = new System.Drawing.Size(613, 394);
            this.grd_vetrina.TabIndex = 3;
            this.grd_vetrina.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_vetrina_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dolce:";
            // 
            // btn_aggiungi
            // 
            this.btn_aggiungi.Location = new System.Drawing.Point(284, 45);
            this.btn_aggiungi.Name = "btn_aggiungi";
            this.btn_aggiungi.Size = new System.Drawing.Size(150, 29);
            this.btn_aggiungi.TabIndex = 5;
            this.btn_aggiungi.Text = "Aggiungi Dolce";
            this.btn_aggiungi.UseVisualStyleBackColor = true;
            this.btn_aggiungi.Click += new System.EventHandler(this.btn_aggiungi_Click);
            // 
            // btn_elimina
            // 
            this.btn_elimina.Location = new System.Drawing.Point(440, 46);
            this.btn_elimina.Name = "btn_elimina";
            this.btn_elimina.Size = new System.Drawing.Size(150, 29);
            this.btn_elimina.TabIndex = 6;
            this.btn_elimina.Text = "Elimina Dolce";
            this.btn_elimina.UseVisualStyleBackColor = true;
            this.btn_elimina.Click += new System.EventHandler(this.btn_elimina_Click);
            // 
            // FormVetrina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 507);
            this.Controls.Add(this.btn_elimina);
            this.Controls.Add(this.btn_aggiungi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grd_vetrina);
            this.Controls.Add(this.cb_dolci);
            this.MinimizeBox = false;
            this.Name = "FormVetrina";
            this.Text = "Vetrina Pasticceria";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormVetrina_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.grd_vetrina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_dolci;
        private System.Windows.Forms.DataGridView grd_vetrina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_aggiungi;
        private System.Windows.Forms.Button btn_elimina;
    }
}