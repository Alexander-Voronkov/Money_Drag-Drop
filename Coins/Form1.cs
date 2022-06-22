using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coins
{
    public partial class Form1 : Form
    {
        public int totalpounds { get; set; } = 0;
        public int totalpence { get; set; } = 0;
        public Form1()
        {
            InitializeComponent();            
        }

        private void moneylist2_DragDrop(object sender, DragEventArgs e)
        {
            label1.Text = "";
            moneylist2.Items.Add(new ListViewItem("",moneylist1.SelectedIndices[0]));
            totalpence = 0;
            totalpounds = 0;
            foreach (ListViewItem item in moneylist2.Items)
            {
                switch (item.ImageIndex)
                {
                    case 0: totalpounds += 1;break;
                    case 1: totalpounds += 2;break;
                    case 2:totalpounds += 5;break;
                    case 3:totalpence += 5;break;
                    case 4:totalpounds += 10;break;
                    case 5:totalpence += 10;break;
                    case 6:totalpence += 20;break;
                    case 7:totalpence += 50;break;
                }
                if (totalpence > 99)
                {
                    totalpence -= 100;
                    totalpounds++;
                }
            }
            totalmoneyamount.Text = $"{totalpounds} pounds, {totalpence} pence";            
        }

        private void moneylist2_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                label1.Text = "Отпустите мышь";
                e.Effect= DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void moneylist2_DragLeave(object sender, EventArgs e)
        {
            label1.Text = "Перетаскивайте сюда";
        }

        private void moneylist1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (moneylist1.SelectedIndices.Count > 0)
            {
                label1.Text = "Перетаскивайте сюда";
                moneylist1.DoDragDrop(moneylist1.Items[moneylist1.SelectedIndices[0]], DragDropEffects.Copy);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            moneylist2.Clear();
            label1.Text = "Перетаскивайте сюда";
            totalpounds = 0;
            totalpence = 0;
            totalmoneyamount.Text = $"{totalpounds} pounds, {totalpence} pence";
        }
    }
}
