using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoFibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void txtBrClanova_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnGenerisi_Click(object sender, EventArgs e)
        {
            try
            {
                int brClanova = Convert.ToInt32(txtBrClanova.Text);

                Zadatak2.clsMath x = new Zadatak2.clsMath();

                long[] niz = new long[brClanova];

                niz = x.GenFibonacci(brClanova);

                txtRichPrikazi.Text = String.Join(Environment.NewLine, niz);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        
    }
}
