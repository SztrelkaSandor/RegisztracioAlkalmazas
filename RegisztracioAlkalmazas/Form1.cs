using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_hozzaad_Click(object sender, EventArgs e)
        {

            if (tb_uj_hobbi.Text.Trim()!="")
            {
                string szoveg = tb_uj_hobbi.Text;
                if (lib_hobbi.Items.Contains(szoveg))
                {
                       
                }
                else
                {
                    tb_uj_hobbi.Text.TrimEnd();
                    tb_uj_hobbi.Text.TrimStart();
                    lib_hobbi.Items.Add(tb_uj_hobbi.Text);
                }
                
                

                 
            }
        }

        private void btn_mentes_Click(object sender, EventArgs e)
        {
            if (tb_nev.Text.Trim() != "" && dtp_szuletesi_datum.Value<DateTime.Now)
            {


                var result = saveFileDialog1.ShowDialog();
                if (result != DialogResult.OK)
                {
                    return;

                }
                string fileName = saveFileDialog1.FileName;

                try
                {
                    if (lib_hobbi.SelectedIndex > -1)
                    {
                        using (var sw = new StreamWriter(fileName))
                        {
                        sw.WriteLine(tb_nev.Text);
                        sw.WriteLine(dtp_szuletesi_datum);
                            foreach (var item in lib_hobbi.Items)
                            {
                            sw.WriteLine(item);
                            }
                            sw.WriteLine(lib_hobbi.SelectedIndex);
                        }
                    

                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hiba a mentés során");
                }
            }
        }

        private void btn_betoltes_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }

            string fileName = openFileDialog1.FileName;
            try
            {
                using (var sr = new StreamReader(fileName))
                {
                    lib_hobbi.Items.Clear();
                    lbl_nev.Text = sr.ReadLine();
                    dtp_szuletesi_datum.Text = sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        lib_hobbi.Items.Add(sr.ReadLine());
                    }
                    lib_hobbi.SelectedIndex =Convert.ToInt32( sr.ReadLine());
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba a megnyitás során");
            }
        }
    }
}
