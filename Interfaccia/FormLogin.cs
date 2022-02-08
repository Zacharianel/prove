using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Win32;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBPasticceria.Model;

namespace Interfaccia
{
    
    public partial class FormLogin : Form
    {
        public void cancellaCampi()
        {
            txt_password.Text = String.Empty;
            txt_user.Text = String.Empty;
        }
        public FormLogin()
        {
            InitializeComponent();
            List<string> istanze = new List<string>();
            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                RegistryKey istanzaKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (istanzaKey != null)
                {
                    foreach (var istanzaNome in istanzaKey.GetValueNames())
                    {
                        if(istanzaNome == "MSSQLSERVER")
                        {
                            istanze.Add(Environment.MachineName);
                        }
                        else
                        {
                            istanze.Add(Environment.MachineName + @"\" + istanzaNome);
                        }
                        
                    }
                }
            }
            cb_istanze.DataSource = istanze;
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            string istanza = cb_istanze.SelectedValue.ToString();
            var db = new PASTICCERIAContext(istanza);
            

            var tipo = db.User.Where(x=> x.Nome == txt_user.Text && txt_password.Text == txt_password.Text).FirstOrDefault();

            if(tipo == null)
            {
                MessageBox.Show("Impossibile accedere, credenziali errate", "ERRORE");
            }
            else
            {
                Interfaccia.FormMenu form = new Interfaccia.FormMenu(this,istanza);
                form.Show();
                this.Hide();
            }

        }


    }
}
