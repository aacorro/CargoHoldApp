namespace CargoHold
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.track_motorCycle = new System.Windows.Forms.TrackBar();
			this.track_cars = new System.Windows.Forms.TrackBar();
			this.track_Trucks = new System.Windows.Forms.TrackBar();
			this.track_trains = new System.Windows.Forms.TrackBar();
			this.label_cycleCount = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label_carCount = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btn_newShip = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.label_truckCount = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label_trainCount = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label_shipLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.track_motorCycle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.track_cars)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.track_Trucks)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.track_trains)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(42, 13);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(695, 175);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// track_motorCycle
			// 
			this.track_motorCycle.Location = new System.Drawing.Point(42, 221);
			this.track_motorCycle.Name = "track_motorCycle";
			this.track_motorCycle.Size = new System.Drawing.Size(284, 45);
			this.track_motorCycle.TabIndex = 1;
			this.track_motorCycle.Scroll += new System.EventHandler(this.track_motorCycle_Scroll);
			// 
			// track_cars
			// 
			this.track_cars.Location = new System.Drawing.Point(42, 317);
			this.track_cars.Name = "track_cars";
			this.track_cars.Size = new System.Drawing.Size(284, 45);
			this.track_cars.TabIndex = 2;
			this.track_cars.Scroll += new System.EventHandler(this.track_cars_Scroll);
			// 
			// track_Trucks
			// 
			this.track_Trucks.Location = new System.Drawing.Point(436, 224);
			this.track_Trucks.Name = "track_Trucks";
			this.track_Trucks.Size = new System.Drawing.Size(301, 45);
			this.track_Trucks.TabIndex = 3;
			this.track_Trucks.Scroll += new System.EventHandler(this.track_Trucks_Scroll);
			// 
			// track_trains
			// 
			this.track_trains.Location = new System.Drawing.Point(436, 317);
			this.track_trains.Name = "track_trains";
			this.track_trains.Size = new System.Drawing.Size(302, 45);
			this.track_trains.TabIndex = 4;
			this.track_trains.Scroll += new System.EventHandler(this.track_trains_Scroll);
			// 
			// label_cycleCount
			// 
			this.label_cycleCount.AutoSize = true;
			this.label_cycleCount.Location = new System.Drawing.Point(98, 205);
			this.label_cycleCount.Name = "label_cycleCount";
			this.label_cycleCount.Size = new System.Drawing.Size(13, 13);
			this.label_cycleCount.TabIndex = 5;
			this.label_cycleCount.Text = "0";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(123, 256);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Motorcycle (3 units)";
			// 
			// label_carCount
			// 
			this.label_carCount.AutoSize = true;
			this.label_carCount.Location = new System.Drawing.Point(98, 297);
			this.label_carCount.Name = "label_carCount";
			this.label_carCount.Size = new System.Drawing.Size(13, 13);
			this.label_carCount.TabIndex = 7;
			this.label_carCount.Text = "0";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(123, 349);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Cars (5 units)";
			// 
			// btn_newShip
			// 
			this.btn_newShip.Location = new System.Drawing.Point(326, 366);
			this.btn_newShip.Name = "btn_newShip";
			this.btn_newShip.Size = new System.Drawing.Size(102, 44);
			this.btn_newShip.TabIndex = 9;
			this.btn_newShip.Text = "New Ship";
			this.btn_newShip.UseVisualStyleBackColor = true;
			this.btn_newShip.Click += new System.EventHandler(this.btn_newShip_Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(180, 22);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(527, 93);
			this.progressBar1.TabIndex = 10;
			this.progressBar1.Value = 15;
			// 
			// label_truckCount
			// 
			this.label_truckCount.AutoSize = true;
			this.label_truckCount.Location = new System.Drawing.Point(500, 205);
			this.label_truckCount.Name = "label_truckCount";
			this.label_truckCount.Size = new System.Drawing.Size(13, 13);
			this.label_truckCount.TabIndex = 11;
			this.label_truckCount.Text = "0";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(538, 253);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(86, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Trucks (11 units)";
			// 
			// label_trainCount
			// 
			this.label_trainCount.AutoSize = true;
			this.label_trainCount.Location = new System.Drawing.Point(500, 297);
			this.label_trainCount.Name = "label_trainCount";
			this.label_trainCount.Size = new System.Drawing.Size(13, 13);
			this.label_trainCount.TabIndex = 13;
			this.label_trainCount.Text = "0";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(538, 349);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(82, 13);
			this.label8.TabIndex = 14;
			this.label8.Text = "Trains (17 units)";
			// 
			// label_shipLabel
			// 
			this.label_shipLabel.AutoSize = true;
			this.label_shipLabel.Location = new System.Drawing.Point(180, 132);
			this.label_shipLabel.Name = "label_shipLabel";
			this.label_shipLabel.Size = new System.Drawing.Size(35, 13);
			this.label_shipLabel.TabIndex = 15;
			this.label_shipLabel.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(778, 450);
			this.Controls.Add(this.label_shipLabel);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label_trainCount);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label_truckCount);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.btn_newShip);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label_carCount);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label_cycleCount);
			this.Controls.Add(this.track_trains);
			this.Controls.Add(this.track_Trucks);
			this.Controls.Add(this.track_cars);
			this.Controls.Add(this.track_motorCycle);
			this.Controls.Add(this.pictureBox1);
			this.ForeColor = System.Drawing.SystemColors.WindowText;
			this.Name = "Form1";
			this.Text = "Load the Ship";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.track_motorCycle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.track_cars)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.track_Trucks)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.track_trains)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TrackBar track_motorCycle;
		private System.Windows.Forms.TrackBar track_cars;
		private System.Windows.Forms.TrackBar track_Trucks;
		private System.Windows.Forms.TrackBar track_trains;
		private System.Windows.Forms.Label label_cycleCount;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label_carCount;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btn_newShip;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label label_truckCount;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label_trainCount;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label_shipLabel;
	}
}

