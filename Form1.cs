using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MedicDeFamilie
{
	public partial class Form1 : Form
	{
		Thread th;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
			th = new Thread(opennewform);
			th.SetApartmentState(ApartmentState.STA);
			th.Start();
		}

		private void opennewform()
		{
			Application.Run(new Form2());
		}

		private void button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Bine atunci nu mai suntem prieteni :(");
			this.Close();
		}
		public void MainWindow()
		{
			// This button needs to exist on your form.
			button2.Click += button2_Click;
			button1.Click += button1_Click;
		}
	}
	
	}
