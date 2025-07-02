using LAKERS_SUCK.Models;
using LAKERS_SUCK.Repositories; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAKERS_SUCK
{
    public partial class AddEtailer : Form
    {
        public AddEtailer()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        public void EditEtailer(Etailer etailer)
        {
            this.Text = "Edit E-Tailer";
            this.label1.Text = "Edit E-Tailer";



            this.textBox1.Text = etailer.Website;
            this.textBox2.Text = etailer.Brand;


        }


        private void button1_Click(object sender, EventArgs e)
        {
            Etailer etailer = new Etailer();
            etailer.Website = this.textBox1.Text;
            etailer.Brand = this.textBox2.Text;

            var repo = new E_TailerRepo();
            if (repo.GetEtailerByWebsite(etailer.Website) == null)
            {
                repo.UpdateEtailer(etailer);
            }
            repo.AddEtailer(etailer);
            this.DialogResult = DialogResult.OK;    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
