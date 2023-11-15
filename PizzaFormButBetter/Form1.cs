using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaFormButBetter
{
    public partial class Form1 : Form
    {
        private bool allergyPrice = false;
        private bool saucePriced = false;
        private double cost = 10;
        private double sizeMod = 1;
        private double totalPrice;
        private int quantity = 1;
        public Form1()
        {
            InitializeComponent();
            totalPrice = (cost * sizeMod) * quantity;
            Quantity_lbl.Text = "Quantity: " + quantity;
            price_lbl.Text = "Price: " + totalPrice.ToString("C", CultureInfo.CurrentCulture);
        }

        private void quantityToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void glutenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!allergyPrice)
            {
                cost += 1;
                allergyPrice = true;
            }
            totalPrice = (cost * sizeMod) * quantity;
            price_lbl.Text = "Price: " + totalPrice.ToString("C", CultureInfo.CurrentCulture);
        }

        private void dairyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!allergyPrice)
            {
                cost += 1;
                allergyPrice = true;
            }
            totalPrice = (cost * sizeMod) * quantity;
            price_lbl.Text = "Price: " + totalPrice.ToString("C", CultureInfo.CurrentCulture);
        }

        private void eggsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!allergyPrice)
            {
                cost += 1;
                allergyPrice = true;
            }
            totalPrice = (cost * sizeMod) * quantity;
            price_lbl.Text = "Price: " + totalPrice.ToString("C", CultureInfo.CurrentCulture);
        }

        private void Sweet_CheckedChanged(object sender, EventArgs e)
        {
            if (!saucePriced)
            {
                cost += 1;
                saucePriced = true;
            }
            totalPrice = (cost * sizeMod) * quantity;
            price_lbl.Text = "Price: " + totalPrice.ToString("C", CultureInfo.CurrentCulture);
        }

        private void spicy_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (!saucePriced)
            {
                cost += 1;
                saucePriced = true;
            }
            totalPrice = (cost* sizeMod) * quantity;
            price_lbl.Text = "Price: " + totalPrice.ToString("C", CultureInfo.CurrentCulture);
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sizeMod = 0.75;
            totalPrice = (cost * sizeMod) * quantity;
            price_lbl.Text = "Price: " + totalPrice.ToString("C", CultureInfo.CurrentCulture);
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sizeMod = 1;
            totalPrice = (cost * sizeMod) * quantity;
            price_lbl.Text = "Price: " + totalPrice.ToString("C", CultureInfo.CurrentCulture);
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sizeMod = 1.5;
            totalPrice = (cost * sizeMod) * quantity;
            price_lbl.Text = "Price: " + totalPrice.ToString("C", CultureInfo.CurrentCulture);
        }

        private void extraLargeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sizeMod = 2;
            totalPrice = (cost * sizeMod) * quantity;
            price_lbl.Text = "Price: " + totalPrice.ToString("C", CultureInfo.CurrentCulture);
        }

        private void increase_btn_Click(object sender, EventArgs e)
        {
            quantity += 1;
            Quantity_lbl.Text = "Quantity: " + quantity;
            totalPrice = (cost * sizeMod) * quantity;
            price_lbl.Text = "Price: " + totalPrice.ToString("C", CultureInfo.CurrentCulture);
        }

        private void decrease_btn_Click(object sender, EventArgs e)
        {
            if (quantity > 1)
            {
                quantity -= 1;
                Quantity_lbl.Text = "Quantity: " + quantity;
                totalPrice = (cost * sizeMod) * quantity;
                price_lbl.Text = "Price: " + totalPrice.ToString("C", CultureInfo.CurrentCulture);
            }
        }

        private void noneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cost -= 1;
            allergyPrice = false;
            totalPrice = (cost * sizeMod) * quantity;
            price_lbl.Text = "Price: " + totalPrice.ToString("C", CultureInfo.CurrentCulture);
        }

        private void reg_btn_CheckedChanged(object sender, EventArgs e)
        {
            saucePriced = false;
            cost -= 1;
            totalPrice = (cost * sizeMod) * quantity;
            price_lbl.Text = "Price: " + totalPrice.ToString("C", CultureInfo.CurrentCulture);
        }
    }
}
