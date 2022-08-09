
namespace EXERCISE_4
{
    partial class TransactionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AppliancesListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CashButton = new System.Windows.Forms.Button();
            this.ChargeButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.NewButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ComputeButton = new System.Windows.Forms.Button();
            this.ApplianceSoldListBox = new System.Windows.Forms.ListBox();
            this.UnitPriceListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SubtotalTextBox = new System.Windows.Forms.TextBox();
            this.TotalAmountTextBox = new System.Windows.Forms.TextBox();
            this.AmountTendered = new System.Windows.Forms.Label();
            this.AmountTenderedTextBox = new System.Windows.Forms.TextBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.ChangeTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Appliances:";
            // 
            // AppliancesListBox
            // 
            this.AppliancesListBox.FormattingEnabled = true;
            this.AppliancesListBox.ItemHeight = 16;
            this.AppliancesListBox.Items.AddRange(new object[] {
            "Air Conditioner",
            "Electric Fan",
            "Electric Pot",
            "Electric Stove",
            "Flat Iron",
            "Karaoke",
            "Microwave Oven",
            "Mini Component",
            "Oven Toaster",
            "Refrigerator",
            "Rice Cooker",
            "Television",
            "VCD Player",
            "Washing Machine"});
            this.AppliancesListBox.Location = new System.Drawing.Point(12, 111);
            this.AppliancesListBox.Name = "AppliancesListBox";
            this.AppliancesListBox.Size = new System.Drawing.Size(166, 244);
            this.AppliancesListBox.TabIndex = 3;
            this.AppliancesListBox.DoubleClick += new System.EventHandler(this.AppliancesListBox_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Type of Payment";
            // 
            // CashButton
            // 
            this.CashButton.Location = new System.Drawing.Point(12, 408);
            this.CashButton.Name = "CashButton";
            this.CashButton.Size = new System.Drawing.Size(75, 30);
            this.CashButton.TabIndex = 5;
            this.CashButton.Text = "Cash";
            this.CashButton.UseVisualStyleBackColor = true;
            this.CashButton.Click += new System.EventHandler(this.CashButton_Click);
            // 
            // ChargeButton
            // 
            this.ChargeButton.Location = new System.Drawing.Point(103, 408);
            this.ChargeButton.Name = "ChargeButton";
            this.ChargeButton.Size = new System.Drawing.Size(75, 30);
            this.ChargeButton.TabIndex = 5;
            this.ChargeButton.Text = "Charge";
            this.ChargeButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quantity";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(201, 111);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(75, 22);
            this.numericUpDown1.TabIndex = 7;
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(201, 156);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(75, 37);
            this.NewButton.TabIndex = 8;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(201, 221);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 37);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(201, 291);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 37);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // ComputeButton
            // 
            this.ComputeButton.Location = new System.Drawing.Point(201, 354);
            this.ComputeButton.Name = "ComputeButton";
            this.ComputeButton.Size = new System.Drawing.Size(75, 57);
            this.ComputeButton.TabIndex = 8;
            this.ComputeButton.Text = "Compute";
            this.ComputeButton.UseVisualStyleBackColor = true;
            this.ComputeButton.Click += new System.EventHandler(this.ComputeButton_Click);
            // 
            // ApplianceSoldListBox
            // 
            this.ApplianceSoldListBox.FormattingEnabled = true;
            this.ApplianceSoldListBox.ItemHeight = 16;
            this.ApplianceSoldListBox.Location = new System.Drawing.Point(298, 111);
            this.ApplianceSoldListBox.Name = "ApplianceSoldListBox";
            this.ApplianceSoldListBox.Size = new System.Drawing.Size(139, 180);
            this.ApplianceSoldListBox.TabIndex = 9;
            // 
            // UnitPriceListBox
            // 
            this.UnitPriceListBox.FormattingEnabled = true;
            this.UnitPriceListBox.ItemHeight = 16;
            this.UnitPriceListBox.Location = new System.Drawing.Point(438, 111);
            this.UnitPriceListBox.Name = "UnitPriceListBox";
            this.UnitPriceListBox.Size = new System.Drawing.Size(139, 180);
            this.UnitPriceListBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Appliance Sold:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Unit Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(321, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Total Amount:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(607, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Amount";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(593, 111);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(112, 22);
            this.AmountTextBox.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(607, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Sub-total:";
            // 
            // SubtotalTextBox
            // 
            this.SubtotalTextBox.Enabled = false;
            this.SubtotalTextBox.Location = new System.Drawing.Point(593, 268);
            this.SubtotalTextBox.Name = "SubtotalTextBox";
            this.SubtotalTextBox.Size = new System.Drawing.Size(112, 22);
            this.SubtotalTextBox.TabIndex = 16;
            // 
            // TotalAmountTextBox
            // 
            this.TotalAmountTextBox.Enabled = false;
            this.TotalAmountTextBox.Location = new System.Drawing.Point(574, 325);
            this.TotalAmountTextBox.Name = "TotalAmountTextBox";
            this.TotalAmountTextBox.Size = new System.Drawing.Size(131, 22);
            this.TotalAmountTextBox.TabIndex = 17;
            // 
            // AmountTendered
            // 
            this.AmountTendered.AutoSize = true;
            this.AmountTendered.Location = new System.Drawing.Point(321, 354);
            this.AmountTendered.Name = "AmountTendered";
            this.AmountTendered.Size = new System.Drawing.Size(126, 17);
            this.AmountTendered.TabIndex = 12;
            this.AmountTendered.Text = "Amount Tendered:";
            // 
            // AmountTenderedTextBox
            // 
            this.AmountTenderedTextBox.Location = new System.Drawing.Point(574, 354);
            this.AmountTenderedTextBox.Name = "AmountTenderedTextBox";
            this.AmountTenderedTextBox.Size = new System.Drawing.Size(131, 22);
            this.AmountTenderedTextBox.TabIndex = 18;
            // 
            // ChangeButton
            // 
            this.ChangeButton.Location = new System.Drawing.Point(324, 399);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(93, 28);
            this.ChangeButton.TabIndex = 19;
            this.ChangeButton.Text = "Change";
            this.ChangeButton.UseVisualStyleBackColor = true;
            // 
            // ChangeTextBox
            // 
            this.ChangeTextBox.Enabled = false;
            this.ChangeTextBox.Location = new System.Drawing.Point(574, 399);
            this.ChangeTextBox.Name = "ChangeTextBox";
            this.ChangeTextBox.Size = new System.Drawing.Size(131, 22);
            this.ChangeTextBox.TabIndex = 20;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(435, 354);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "label11";
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 462);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ChangeTextBox);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.AmountTenderedTextBox);
            this.Controls.Add(this.TotalAmountTextBox);
            this.Controls.Add(this.SubtotalTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AmountTendered);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UnitPriceListBox);
            this.Controls.Add(this.ApplianceSoldListBox);
            this.Controls.Add(this.ComputeButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ChargeButton);
            this.Controls.Add(this.CashButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AppliancesListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TransactionForm";
            this.Text = "Transaction";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox AppliancesListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CashButton;
        private System.Windows.Forms.Button ChargeButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ComputeButton;
        private System.Windows.Forms.ListBox ApplianceSoldListBox;
        private System.Windows.Forms.ListBox UnitPriceListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SubtotalTextBox;
        private System.Windows.Forms.TextBox TotalAmountTextBox;
        private System.Windows.Forms.Label AmountTendered;
        private System.Windows.Forms.TextBox AmountTenderedTextBox;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.TextBox ChangeTextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label11;
    }
}