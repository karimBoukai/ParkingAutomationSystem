using System;

namespace ParkingAutomationSystem
{
    partial class VehicleParkingExitPage
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
            this.ComboPlate = new System.Windows.Forms.ComboBox();
            this.TxtParkingSpace = new System.Windows.Forms.TextBox();
            this.TxtParkSpace = new System.Windows.Forms.TextBox();
            this.ComboParkingSpace = new System.Windows.Forms.ComboBox();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Plate = new System.Windows.Forms.Label();
            this.TxtPlate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtSerial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtBrand = new System.Windows.Forms.TextBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblExitDate = new System.Windows.Forms.Label();
            this.lblEntryDate = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboPlate
            // 
            this.ComboPlate.FormattingEnabled = true;
            this.ComboPlate.Location = new System.Drawing.Point(83, 18);
            this.ComboPlate.Name = "ComboPlate";
            this.ComboPlate.Size = new System.Drawing.Size(121, 21);
            this.ComboPlate.TabIndex = 0;
            this.ComboPlate.SelectedIndexChanged += new System.EventHandler(this.ComboPlate_SelectedIndexChanged);
            // 
            // TxtParkingSpace
            // 
            this.TxtParkingSpace.Location = new System.Drawing.Point(83, 50);
            this.TxtParkingSpace.Name = "TxtParkingSpace";
            this.TxtParkingSpace.Size = new System.Drawing.Size(121, 20);
            this.TxtParkingSpace.TabIndex = 1;
            // 
            // TxtParkSpace
            // 
            this.TxtParkSpace.Location = new System.Drawing.Point(113, 40);
            this.TxtParkSpace.Name = "TxtParkSpace";
            this.TxtParkSpace.Size = new System.Drawing.Size(121, 20);
            this.TxtParkSpace.TabIndex = 3;
            this.TxtParkSpace.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ComboParkingSpace
            // 
            this.ComboParkingSpace.FormattingEnabled = true;
            this.ComboParkingSpace.Location = new System.Drawing.Point(113, 13);
            this.ComboParkingSpace.Name = "ComboParkingSpace";
            this.ComboParkingSpace.Size = new System.Drawing.Size(121, 21);
            this.ComboParkingSpace.TabIndex = 2;
            this.ComboParkingSpace.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(113, 66);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(121, 20);
            this.TxtID.TabIndex = 4;
            this.TxtID.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Plate Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Parking Space";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Parking Space ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Parking Space ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtParkingSpace);
            this.groupBox1.Controls.Add(this.ComboPlate);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 101);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parking Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Plate);
            this.groupBox2.Controls.Add(this.TxtPlate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TxtSerial);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtBrand);
            this.groupBox2.Controls.Add(this.TxtSurname);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TxtName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TxtID);
            this.groupBox2.Controls.Add(this.TxtParkSpace);
            this.groupBox2.Controls.Add(this.ComboParkingSpace);
            this.groupBox2.Location = new System.Drawing.Point(24, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 132);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Car Information";
            // 
            // Plate
            // 
            this.Plate.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Plate.AutoSize = true;
            this.Plate.Location = new System.Drawing.Point(295, 95);
            this.Plate.Name = "Plate";
            this.Plate.Size = new System.Drawing.Size(31, 13);
            this.Plate.TabIndex = 25;
            this.Plate.Text = "Plate";
            // 
            // TxtPlate
            // 
            this.TxtPlate.Location = new System.Drawing.Point(340, 95);
            this.TxtPlate.Name = "TxtPlate";
            this.TxtPlate.Size = new System.Drawing.Size(121, 20);
            this.TxtPlate.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Serial";
            // 
            // TxtSerial
            // 
            this.TxtSerial.Location = new System.Drawing.Point(340, 65);
            this.TxtSerial.Name = "TxtSerial";
            this.TxtSerial.Size = new System.Drawing.Size(121, 20);
            this.TxtSerial.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Brand";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Surname";
            // 
            // TxtBrand
            // 
            this.TxtBrand.Location = new System.Drawing.Point(340, 39);
            this.TxtBrand.Name = "TxtBrand";
            this.TxtBrand.Size = new System.Drawing.Size(121, 20);
            this.TxtBrand.TabIndex = 19;
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(340, 13);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(121, 20);
            this.TxtSurname.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Name";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(113, 92);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(121, 20);
            this.TxtName.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.lblTotal);
            this.groupBox3.Controls.Add(this.lblDuration);
            this.groupBox3.Controls.Add(this.lblExitDate);
            this.groupBox3.Controls.Add(this.lblEntryDate);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(285, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 101);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pricing";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(159, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "USD";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(81, 70);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 13);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "label18";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.ForeColor = System.Drawing.Color.Red;
            this.lblDuration.Location = new System.Drawing.Point(81, 53);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(41, 13);
            this.lblDuration.TabIndex = 6;
            this.lblDuration.Text = "label17";
            // 
            // lblExitDate
            // 
            this.lblExitDate.AutoSize = true;
            this.lblExitDate.ForeColor = System.Drawing.Color.Red;
            this.lblExitDate.Location = new System.Drawing.Point(81, 40);
            this.lblExitDate.Name = "lblExitDate";
            this.lblExitDate.Size = new System.Drawing.Size(41, 13);
            this.lblExitDate.TabIndex = 5;
            this.lblExitDate.Text = "label16";
            // 
            // lblEntryDate
            // 
            this.lblEntryDate.AutoSize = true;
            this.lblEntryDate.ForeColor = System.Drawing.Color.Red;
            this.lblEntryDate.Location = new System.Drawing.Point(81, 21);
            this.lblEntryDate.Name = "lblEntryDate";
            this.lblEntryDate.Size = new System.Drawing.Size(41, 13);
            this.lblEntryDate.TabIndex = 4;
            this.lblEntryDate.Text = "label15";
            this.lblEntryDate.Click += new System.EventHandler(this.label15_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Total";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Duration";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Exit Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Entry Date";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Car Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(364, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // VehicleParkingExitPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(627, 368);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "VehicleParkingExitPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VehicleParkingExitPage";
            this.Load += new System.EventHandler(this.VehicleParkingExitPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

      
        #endregion

        private System.Windows.Forms.ComboBox ComboPlate;
        private System.Windows.Forms.TextBox TxtParkingSpace;
        private System.Windows.Forms.TextBox TxtParkSpace;
        private System.Windows.Forms.ComboBox ComboParkingSpace;
        private System.Windows.Forms.TextBox TxtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Plate;
        private System.Windows.Forms.TextBox TxtPlate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtSerial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtBrand;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblEntryDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblExitDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label16;
    }
}