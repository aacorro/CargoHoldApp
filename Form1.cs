using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargoHold
{
	public partial class Form1 : Form
	{

		Ship ship = new Ship();
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			progressBar1.Style = ProgressBarStyle.Continuous;
		}

		private void btn_newShip_Click(object sender, EventArgs e)
		{
			ship = new Ship();
			updateUI();
		}

		private void updateUI()
		{
			//set all of the controls ot match the ship properties
			progressBar1.Maximum = ship.Capacity;

			if(ship.getShipLoaded() <= ship.Capacity) 
			progressBar1.Value = ship.getShipLoaded();


			label_shipLabel.Text = ship.ToString();

			label_cycleCount.Text = ship.CycleCount.ToString();
			label_carCount.Text = ship.CarCount.ToString();
			label_truckCount.Text = ship.TruckCount.ToString();
			label_trainCount.Text = ship.TrainCount.ToString();

			if(ship.overUnder() == 0)
			{
				progressBar1.ForeColor = Color.Green;
			}
			if(ship.overUnder() > 1) 
			{ 
				progressBar1.ForeColor = Color.Yellow;
			}
			if(ship.overUnder() <0)
			{
				progressBar1.ForeColor = Color.Red;
			}

		}

		private void track_motorCycle_Scroll(object sender, EventArgs e)
		{
			ship.CycleCount = track_motorCycle.Value;
			updateUI();
		}

		private void track_cars_Scroll(object sender, EventArgs e)
		{
			ship.CarCount = track_cars.Value;
			updateUI();
		}

		private void track_Trucks_Scroll(object sender, EventArgs e)
		{
			ship.TruckCount = track_Trucks.Value;
			updateUI();
		}

		private void track_trains_Scroll(object sender, EventArgs e)
		{
			ship.TrainCount = track_trains.Value;
			updateUI();
		}
	}
}
