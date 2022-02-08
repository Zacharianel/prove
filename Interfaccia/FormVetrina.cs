using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Interfaccia
{
    public partial class FormVetrina : Form
    {
        DBPasticceria.Model.PASTICCERIAContext db;
        string istanza;
        FormMenu padre;
        public FormVetrina(string ist,FormMenu p)
        {
            padre = p;
            istanza = ist;
            db = new DBPasticceria.Model.PASTICCERIAContext(istanza);
            InitializeComponent();
            cb_dolci.DataSource = db.Dolci.ToList();
            cb_dolci.DisplayMember = "Nome";
            cb_dolci.ValueMember = "CodD";

            grd_vetrina.Columns.Add("nome", "Dolce");
            grd_vetrina.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grd_vetrina.Columns.Add("data", "Data Produzione");
            grd_vetrina.Columns.Add("costo", "Costo");
            grd_vetrina.Columns.Add("scaduto", "Scaduto");
            grd_vetrina.Columns.Add("codD", "Codice Dolce");
            grd_vetrina.Columns[4].Visible = false;
            leggiDb();
        }

        public void leggiDb()
        {
            grd_vetrina.Rows.Clear();
            grd_vetrina.Refresh();
            var dolciVetrina = from dolci in db.Dolci
                                     from vetrina in db.Vetrina
                                     where dolci.CodD == vetrina.CodD
                                     select new
                                     {
                                         dolce = dolci.Nome,
                                         data = parseData(vetrina.Data),
                                         costo = costoDolce(vetrina.Data,dolci.Costo),
                                         scaduto = statoDolce(vetrina.Data),
                                         codD =vetrina.CodD
                                     };
            
            foreach (var obj in dolciVetrina)
            {
                grd_vetrina.Rows.Add(obj.dolce, obj.data, obj.costo + " €",obj.scaduto, obj.codD);
            }
        }

        public static string parseData(DateTime data)
        {
            return data.ToShortDateString();
        }
        public static string statoDolce(DateTime data)
        {
            DateTime dataOdierna = DateTime.Now;
            TimeSpan differenza = dataOdierna - data;
            if (differenza.Days < 3)
                return "Disponibile";
            else
                return "Scaduto";
        }

        public static double costoDolce(DateTime data,double costo)
        {
            DateTime dataOdierna = DateTime.Now;
            TimeSpan differenza = dataOdierna - data;
            switch(true)
            {
                case var expr when differenza.Days == 2:
                    {
                        costo = (costo * 80) / 100;
                        return costo;
                    }
                case var expr when differenza.Days == 3:
                    {
                        costo = (costo * 20) / 100;
                        return costo;
                    }
                case var expr when differenza.Days == 3:
                    {
                        costo = 0;
                        return costo;
                    }
                default:
                    {
                        return costo;
                    }
            }
        }


        private void btn_aggiungi_Click(object sender, EventArgs e)
        {
            DBPasticceria.Model.Dolci nuovoDolce = (DBPasticceria.Model.Dolci)cb_dolci.SelectedItem;
            DBPasticceria.Model.Vetrina nuovoDolceInVetrina = new DBPasticceria.Model.Vetrina();
            nuovoDolceInVetrina.CodD = nuovoDolce.CodD;
            nuovoDolceInVetrina.Data = DateTime.Now;
            db.Vetrina.Add(nuovoDolceInVetrina);
            db.SaveChanges();
            leggiDb();
        }

        private void FormVetrina_FormClosed(object sender, FormClosedEventArgs e)
        {
            padre.Show();
        }

        private void btn_elimina_Click(object sender, EventArgs e)
        {
            int codiceDolce = (int)grd_vetrina.Rows[grd_vetrina.SelectedRows[0].Index].Cells[4].Value;
            DBPasticceria.Model.Vetrina elemento = db.Vetrina.Where(x => x.CodV == codiceDolce).FirstOrDefault();
            if(elemento != null)
            {
                db.Vetrina.Remove(elemento);
                db.SaveChanges();
                leggiDb();
            }

        }

        private void grd_vetrina_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int codiceDolce = (int)grd_vetrina.Rows[grd_vetrina.SelectedRows[0].Index].Cells[4].Value;
            DBPasticceria.Model.Dolci elemento = db.Dolci.Where(x => x.CodD == codiceDolce).FirstOrDefault();
            FormRicette formRicette = new FormRicette(istanza,this, elemento.Nome);
            formRicette.Show();
            
            this.Hide();
        }
    }
}
