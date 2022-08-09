﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXERCISE_4
{
    public partial class TransactionForm : Form
    {
        public TransactionForm()
        {
            InitializeComponent();
			label6.Visible = false;
		}

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        private void AppliancesListBox_DoubleClick(object sender, EventArgs e)
        {
			if (AppliancesListBox.SelectedItem.ToString() == "Air Conditioner")
			{
				ApplianceSoldListBox.Items.Add(AppliancesListBox.SelectedItem);
				UnitPriceListBox.Items.Add("10000");

			}
			else if (AppliancesListBox.SelectedItem.ToString() == "Electric Fan")
			{
				ApplianceSoldListBox.Items.Add(AppliancesListBox.SelectedItem);
				UnitPriceListBox.Items.Add("500");

			}
			else if (AppliancesListBox.SelectedItem.ToString() == "Electric Pot")
			{
				ApplianceSoldListBox.Items.Add(AppliancesListBox.SelectedItem);
				UnitPriceListBox.Items.Add("800");
			}
			else if (AppliancesListBox.SelectedItem.ToString() == "Electric Stove")
			{
				ApplianceSoldListBox.Items.Add(AppliancesListBox.SelectedItem);
				UnitPriceListBox.Items.Add("1000");
			}
			else if (AppliancesListBox.SelectedItem.ToString() == "Flat Iron")
			{
				ApplianceSoldListBox.Items.Add(AppliancesListBox.SelectedItem);
				UnitPriceListBox.Items.Add("350");
			}
			else if (AppliancesListBox.SelectedItem.ToString() == "Karaoke")
			{
				ApplianceSoldListBox.Items.Add(AppliancesListBox.SelectedItem);
				UnitPriceListBox.Items.Add("2500");
			}
			else if (AppliancesListBox.SelectedItem.ToString() == "Microwave Oven")
			{
				ApplianceSoldListBox.Items.Add(AppliancesListBox.SelectedItem);
				UnitPriceListBox.Items.Add("3000");
			}
			else if (AppliancesListBox.SelectedItem.ToString() == "Mini Component")
			{
				ApplianceSoldListBox.Items.Add(AppliancesListBox.SelectedItem);
				UnitPriceListBox.Items.Add("3500");
			}
			else if (AppliancesListBox.SelectedItem.ToString() == "Oven Toaster")
			{
				ApplianceSoldListBox.Items.Add(AppliancesListBox.SelectedItem);
				UnitPriceListBox.Items.Add("550");
			}
			else if (AppliancesListBox.SelectedItem.ToString() == "Refrigerator")
			{
				ApplianceSoldListBox.Items.Add(AppliancesListBox.SelectedItem);
				UnitPriceListBox.Items.Add("9000");
			}
			else if (AppliancesListBox.SelectedItem.ToString() == "Rice Cooker")
			{
				ApplianceSoldListBox.Items.Add(AppliancesListBox.SelectedItem);
				UnitPriceListBox.Items.Add("600");
			}
			else if (AppliancesListBox.SelectedItem.ToString() == "Television")
			{
				ApplianceSoldListBox.Items.Add(AppliancesListBox.SelectedItem);
				UnitPriceListBox.Items.Add("5000");
			}
			else if (AppliancesListBox.SelectedItem.ToString() == "VCD Player")
			{
				ApplianceSoldListBox.Items.Add(AppliancesListBox.SelectedItem);
				UnitPriceListBox.Items.Add("1200");
			}
			else if (AppliancesListBox.SelectedItem.ToString() == "Washing Machine")
			{
				ApplianceSoldListBox.Items.Add(AppliancesListBox.SelectedItem);
				UnitPriceListBox.Items.Add("4000");
			}
		}
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
			decimal amount = 0;

			if (numericUpDown1.Value <= 0)
			{
				MessageBox.Show("Please input a quantity");
			}
			else
			{
				for (int i = 0; i < UnitPriceListBox.Items.Count; i++)
				{
					amount = Convert.ToDecimal(UnitPriceListBox.Items[i]) * numericUpDown1.Value;
				}
				AmountTextBox.Text = amount.ToString();
			}
		}

        private void ComputeButton_Click(object sender, EventArgs e)
        {
			decimal sum = 0;
			for (int i = 0; i < UnitPriceListBox.Items.Count; i++)
			{
				sum += Convert.ToDecimal(UnitPriceListBox.Items[i]) * numericUpDown1.Value;
			}
			SubtotalTextBox.Text = sum.ToString();

			ComputeButton.Enabled = false;
		}

        private void CashButton_Click(object sender, EventArgs e)
        {
			double subtotal = Convert.ToDouble(SubtotalTextBox.Text);
			double totalamount = subtotal - (subtotal * 0.5);
			TotalAmountTextBox.Text = totalamount.ToString();

			NewButton.Enabled = true;
			ClearButton.Enabled = true;
			CloseButton.Enabled = true;
			ComputeButton.Enabled = true;
			CashButton.Enabled = false;
		}
    }
}
