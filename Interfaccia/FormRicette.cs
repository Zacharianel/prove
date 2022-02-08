using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interfaccia
{
    public partial class FormRicette : Form
    {
        FormMenu padre;
        FormVetrina padreVetrina;
        string istanza;
        DBPasticceria.Model.PASTICCERIAContext db;
        public FormRicette(string ist,FormMenu p)
        {
            padre = p;
            istanza = ist;
            
            InitializeComponent();
            startupForm();

        }

        public FormRicette(string ist,FormVetrina p, string nomeDolce)
        {
            padreVetrina = p;
            istanza = ist;
            InitializeComponent();
            startupForm();

            cb_ricette.SelectedIndex = cb_ricette.FindString(nomeDolce);
        }

        public void startupForm()
        {
            db = new DBPasticceria.Model.PASTICCERIAContext(istanza);
            grd_ingredienti.Columns.Add("nomeIngrediente", "Nome Ingrediente");
            grd_ingredienti.Columns.Add("quantità", "Quantità");

            cb_ricette.DataSource = db.Dolci.ToList();
            cb_ricette.DisplayMember = "Nome";
            cb_ricette.ValueMember = "CodD";
        }


        private void cb_ricette_SelectedIndexChanged(object sender, EventArgs e)
        {
            grd_ingredienti.Rows.Clear();
            grd_ingredienti.Refresh();
            DBPasticceria.Model.Dolci dolce = (DBPasticceria.Model.Dolci)cb_ricette.SelectedItem;
            var ingredientiRicetta = from ricette in db.Ricette
                                  from dolci in db.Dolci
                                  from ingredienti in db.Ingredienti
                                  where dolci.CodD == ricette.CodD
                                  where ingredienti.CodI == ricette.CodI
                                  where ricette.CodD == dolce.CodD
                                  select new
                                  {
                                      nomeIngrediente = ingredienti.Nome,
                                      quantità = ricette.QtaIngredienti + " " + ingredienti.Um
                                  };

            
            //grd_ingredienti.DataSource = ingredientiRicetta;
            foreach(var obj in ingredientiRicetta)
            {
                grd_ingredienti.Rows.Add(obj.nomeIngrediente, obj.quantità);
            }
            
        }

        private void FormRicette_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(padre == null)
            {
                padreVetrina.Show();
            }
            else
            {
                padre.Show();
            }
            
        }

    }
}
