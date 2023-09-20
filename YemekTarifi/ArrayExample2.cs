using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YemekTarifi
{
    public partial class ArrayExample2 : Form
    {
        public ArrayExample2()
        {
            InitializeComponent();
        }

        string[] stages = { "1- Tenceredesuyu kaynatın.", "2- Kaynar suya makarnaları dökün.", "3- Tuz atın.", "4- Makarnalar bitince süzgece atın.", "5- Tencereye biraz yağ koyduktan sonra makarnaları içine dökün.", "6- Afiyet olsun." };

        int index = 0;      // sayaç
        private void btnAddStage_Click(object sender, EventArgs e)
        {
            if (index <= stages.Length -1)
            {
                lstStages.Items.Add(stages[index]);
                index++;
            }
            else
            {
                MessageBox.Show("Tarif tamamlanmıştır.");
            }
        }
    }
}
