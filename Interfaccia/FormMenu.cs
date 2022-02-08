using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interfaccia
{
    public partial class FormMenu : Form
    {
        FormLogin padre;
        string istanza;
        public FormMenu(FormLogin p,string ist)
        {
            padre = p;
            istanza = ist;
            InitializeComponent();

        }

        private void btn_ricette_Click(object sender, EventArgs e)
        {
            FormRicette ricette = new FormRicette(istanza,this);
            ricette.Show();
            this.Hide();

        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_vetrina_Click(object sender, EventArgs e)
        {
            FormVetrina vetrina = new FormVetrina(istanza,this);
            vetrina.Show();
            this.Hide();
        }

    }
}
