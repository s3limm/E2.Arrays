using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ucak_bıletı_operasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] cities = { "İstanbul", "Ankara", "İzmir", "Antalya", "Bursa", "Van", "Denizli", "Adana", "Mersin", "Diyarbakır", "Zonguldak", "Çanakkale", "Muğla", "Aydın", "Kocaeli", "Edirne" };


        private void Form1_Load(object sender, EventArgs e)
        {
            cmbFrom.Items.Add(cities[0]);
            cmbFrom.Items.Add(cities[1]);
            cmbFrom.Items.Add(cities[2]);
            cmbFrom.Items.Add(cities[3]);

        }

        private void cmbFrom_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbTo.Items.Clear();

            if (cmbFrom.Text == cities[0])
            {
                cmbTo.Items.Add(cities[4]);
                cmbTo.Items.Add(cities[5]);
                cmbTo.Items.Add(cities[6]);
            }

            else if (cmbFrom.Text == cities[1])
            {
                cmbTo.Items.Add(cities[7]);
                cmbTo.Items.Add(cities[8]);
                cmbTo.Items.Add(cities[9]);
            }

            else if (cmbFrom.Text == cities[2])
            {
                cmbTo.Items.Add(cities[10]);
                cmbTo.Items.Add(cities[11]);
                cmbTo.Items.Add(cities[12]);
            }
            else
            {
                cmbTo.Items.Add(cities[13]);
                cmbTo.Items.Add(cities[14]);
                cmbTo.Items.Add(cities[15]);
            }


        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (cmbFrom.Text == "")
            {
                MessageBox.Show("Lütfen bulunduğunuz şehri seçiniz. ");
            }

            else if(cmbTo.Text == "")
            {
                MessageBox.Show("Lütfen gitmek istediğiniz yeri seçiniz");
            }

            else
            {
                string from = cmbFrom.Text;
                string to = cmbTo.Text;
                MessageBox.Show($"{from} ile {to} arası olan seyahatinizde sizlere iyi yolculuklar dileriz.");
            }

        }
    }
}
