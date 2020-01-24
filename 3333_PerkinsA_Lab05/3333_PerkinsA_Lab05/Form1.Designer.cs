namespace _3333_PerkinsA_Lab05
{
    partial class Form1
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
            this.vehicleSpeedLabel = new System.Windows.Forms.Label();
            this.hoursTraveledLabel = new System.Windows.Forms.Label();
            this.hoursTraveledTextBox = new System.Windows.Forms.TextBox();
            this.vehicleSpeedTextBox = new System.Windows.Forms.TextBox();
            this.distanceListBox = new System.Windows.Forms.ListBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.summaryGroupBox = new System.Windows.Forms.GroupBox();
            this.totalTripsOutputLabel = new System.Windows.Forms.Label();
            this.totalHoursTraveledOutputLabel = new System.Windows.Forms.Label();
            this.totalDistanceOutputLabel = new System.Windows.Forms.Label();
            this.totalTripsLabel = new System.Windows.Forms.Label();
            this.totalHoursLabel = new System.Windows.Forms.Label();
            this.totalDistanceLabel = new System.Windows.Forms.Label();
            this.averageDistanceLabel = new System.Windows.Forms.Label();
            this.averageDistanceOutputLabel = new System.Windows.Forms.Label();
            this.summaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // vehicleSpeedLabel
            // 
            this.vehicleSpeedLabel.AutoSize = true;
            this.vehicleSpeedLabel.Location = new System.Drawing.Point(12, 24);
            this.vehicleSpeedLabel.Name = "vehicleSpeedLabel";
            this.vehicleSpeedLabel.Size = new System.Drawing.Size(171, 20);
            this.vehicleSpeedLabel.TabIndex = 11;
            this.vehicleSpeedLabel.Text = "Vehicle Speed in MPH:";
            // 
            // hoursTraveledLabel
            // 
            this.hoursTraveledLabel.AutoSize = true;
            this.hoursTraveledLabel.Location = new System.Drawing.Point(12, 83);
            this.hoursTraveledLabel.Name = "hoursTraveledLabel";
            this.hoursTraveledLabel.Size = new System.Drawing.Size(120, 20);
            this.hoursTraveledLabel.TabIndex = 12;
            this.hoursTraveledLabel.Text = "Hours Traveled:";
            // 
            // hoursTraveledTextBox
            // 
            this.hoursTraveledTextBox.Location = new System.Drawing.Point(271, 83);
            this.hoursTraveledTextBox.Name = "hoursTraveledTextBox";
            this.hoursTraveledTextBox.Size = new System.Drawing.Size(165, 26);
            this.hoursTraveledTextBox.TabIndex = 2;
            // 
            // vehicleSpeedTextBox
            // 
            this.vehicleSpeedTextBox.Location = new System.Drawing.Point(271, 24);
            this.vehicleSpeedTextBox.Name = "vehicleSpeedTextBox";
            this.vehicleSpeedTextBox.Size = new System.Drawing.Size(165, 26);
            this.vehicleSpeedTextBox.TabIndex = 1;
            // 
            // distanceListBox
            // 
            this.distanceListBox.FormattingEnabled = true;
            this.distanceListBox.ItemHeight = 20;
            this.distanceListBox.Location = new System.Drawing.Point(40, 148);
            this.distanceListBox.Name = "distanceListBox";
            this.distanceListBox.Size = new System.Drawing.Size(569, 164);
            this.distanceListBox.TabIndex = 6;
            // 
            // calculateButton
            // 
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculateButton.Location = new System.Drawing.Point(40, 573);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(126, 33);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(423, 573);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(126, 33);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Location = new System.Drawing.Point(244, 573);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(126, 33);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "C&lear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // summaryGroupBox
            // 
            this.summaryGroupBox.Controls.Add(this.totalTripsOutputLabel);
            this.summaryGroupBox.Controls.Add(this.totalHoursTraveledOutputLabel);
            this.summaryGroupBox.Controls.Add(this.totalDistanceOutputLabel);
            this.summaryGroupBox.Controls.Add(this.totalTripsLabel);
            this.summaryGroupBox.Controls.Add(this.totalHoursLabel);
            this.summaryGroupBox.Controls.Add(this.totalDistanceLabel);
            this.summaryGroupBox.Location = new System.Drawing.Point(16, 343);
            this.summaryGroupBox.Name = "summaryGroupBox";
            this.summaryGroupBox.Size = new System.Drawing.Size(617, 156);
            this.summaryGroupBox.TabIndex = 8;
            this.summaryGroupBox.TabStop = false;
            this.summaryGroupBox.Text = "Summary";
            // 
            // totalTripsOutputLabel
            // 
            this.totalTripsOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalTripsOutputLabel.Location = new System.Drawing.Point(283, 110);
            this.totalTripsOutputLabel.Name = "totalTripsOutputLabel";
            this.totalTripsOutputLabel.Size = new System.Drawing.Size(199, 26);
            this.totalTripsOutputLabel.TabIndex = 9;
            // 
            // totalHoursTraveledOutputLabel
            // 
            this.totalHoursTraveledOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalHoursTraveledOutputLabel.Location = new System.Drawing.Point(283, 62);
            this.totalHoursTraveledOutputLabel.Name = "totalHoursTraveledOutputLabel";
            this.totalHoursTraveledOutputLabel.Size = new System.Drawing.Size(199, 26);
            this.totalHoursTraveledOutputLabel.TabIndex = 8;
            // 
            // totalDistanceOutputLabel
            // 
            this.totalDistanceOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalDistanceOutputLabel.Location = new System.Drawing.Point(283, 22);
            this.totalDistanceOutputLabel.Name = "totalDistanceOutputLabel";
            this.totalDistanceOutputLabel.Size = new System.Drawing.Size(199, 26);
            this.totalDistanceOutputLabel.TabIndex = 7;
            // 
            // totalTripsLabel
            // 
            this.totalTripsLabel.AutoSize = true;
            this.totalTripsLabel.Location = new System.Drawing.Point(6, 110);
            this.totalTripsLabel.Name = "totalTripsLabel";
            this.totalTripsLabel.Size = new System.Drawing.Size(86, 20);
            this.totalTripsLabel.TabIndex = 15;
            this.totalTripsLabel.Text = "Total Trips:";
            // 
            // totalHoursLabel
            // 
            this.totalHoursLabel.AutoSize = true;
            this.totalHoursLabel.Location = new System.Drawing.Point(6, 62);
            this.totalHoursLabel.Name = "totalHoursLabel";
            this.totalHoursLabel.Size = new System.Drawing.Size(159, 20);
            this.totalHoursLabel.TabIndex = 14;
            this.totalHoursLabel.Text = "Total Hours Traveled:";
            // 
            // totalDistanceLabel
            // 
            this.totalDistanceLabel.AutoSize = true;
            this.totalDistanceLabel.Location = new System.Drawing.Point(3, 22);
            this.totalDistanceLabel.Name = "totalDistanceLabel";
            this.totalDistanceLabel.Size = new System.Drawing.Size(115, 20);
            this.totalDistanceLabel.TabIndex = 13;
            this.totalDistanceLabel.Text = "Total Distance:";
            // 
            // averageDistanceLabel
            // 
            this.averageDistanceLabel.AutoSize = true;
            this.averageDistanceLabel.Location = new System.Drawing.Point(36, 521);
            this.averageDistanceLabel.Name = "averageDistanceLabel";
            this.averageDistanceLabel.Size = new System.Drawing.Size(139, 20);
            this.averageDistanceLabel.TabIndex = 16;
            this.averageDistanceLabel.Text = "Average Distance:";
            // 
            // averageDistanceOutputLabel
            // 
            this.averageDistanceOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.averageDistanceOutputLabel.Location = new System.Drawing.Point(299, 521);
            this.averageDistanceOutputLabel.Name = "averageDistanceOutputLabel";
            this.averageDistanceOutputLabel.Size = new System.Drawing.Size(193, 23);
            this.averageDistanceOutputLabel.TabIndex = 10;
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(742, 618);
            this.Controls.Add(this.averageDistanceOutputLabel);
            this.Controls.Add(this.averageDistanceLabel);
            this.Controls.Add(this.summaryGroupBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.distanceListBox);
            this.Controls.Add(this.vehicleSpeedTextBox);
            this.Controls.Add(this.hoursTraveledTextBox);
            this.Controls.Add(this.hoursTraveledLabel);
            this.Controls.Add(this.vehicleSpeedLabel);
            this.Name = "Form1";
            this.Text = "Distance Calculator";
            this.summaryGroupBox.ResumeLayout(false);
            this.summaryGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vehicleSpeedLabel;
        private System.Windows.Forms.Label hoursTraveledLabel;
        private System.Windows.Forms.TextBox hoursTraveledTextBox;
        private System.Windows.Forms.TextBox vehicleSpeedTextBox;
        private System.Windows.Forms.ListBox distanceListBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox summaryGroupBox;
        private System.Windows.Forms.Label totalTripsLabel;
        private System.Windows.Forms.Label totalHoursLabel;
        private System.Windows.Forms.Label totalDistanceLabel;
        private System.Windows.Forms.Label totalDistanceOutputLabel;
        private System.Windows.Forms.Label totalTripsOutputLabel;
        private System.Windows.Forms.Label totalHoursTraveledOutputLabel;
        private System.Windows.Forms.Label averageDistanceLabel;
        private System.Windows.Forms.Label averageDistanceOutputLabel;
    }
}

