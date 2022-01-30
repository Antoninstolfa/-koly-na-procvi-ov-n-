using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Příklady_na_procvičovaní
{
    public partial class Priklad1 : Form
    {
        public Priklad1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int posloupnost = Convert.ToInt32(numericUpDown1.Value);
            for(int cislo;posloupnost !=0;posloupnost--)
            {
               
            }
        }
    }
}
