using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Strategypattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxType.Items.AddRange(new object[] { "正常收费", "打八折", "打七折", "打五折" });
            cbxType.SelectedIndex = 0;
        }

        double total = 0.0d;
        /// <summary>
        ///  version 1.0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
 
        //private void btnOk_Click(object sender, EventArgs e)
        //{
        //    double totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text);
        //    total += totalPrices;
        //    lbxList.Items.Add("单价:" + txtPrice.Text + " 数量:" + txtNum.Text + " 合计:" + totalPrices.ToString());
        //    lbResult.Text = total.ToString() + " 元";
        //}

        /// <summary>
        ///  version 1.1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        //private void btnOk_Click(object sender, EventArgs e)
        //{
        //    double totalPrices = 0d;
        //    switch (cbxType.SelectedIndex)
        //    {
        //        case 0:
        //            totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text);
        //            break;
        //        case 1:
        //            totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text) * 0.8;
        //            break;
        //        case 2:
        //            totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text) * 0.7;
        //            break;
        //        case 3:
        //            totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text) * 0.5;
        //            break;
        //    }
        //    total += totalPrices;
        //    lbxList.Items.Add("单价:" + txtPrice.Text + " 数量:" + txtNum.Text +" " +cbxType.SelectedItem+ "  合计:" + totalPrices.ToString());
        //    lbResult.Text = total.ToString() + " 元";
        //}


        /// <summary>
        ///  version 1.2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            CashSuper csuper = CashFactory.createCashAccept(cbxType.SelectedItem.ToString());
            double totalPrices = 0d;
            totalPrices = csuper.acceptCash(Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text));
            total += totalPrices;
            lbxList.Items.Add("单价:" + txtPrice.Text + " 数量:" + txtNum.Text + " " + cbxType.SelectedItem + "  合计:" + totalPrices.ToString());
            lbResult.Text = total.ToString() + " 元";
        }
    }
}
