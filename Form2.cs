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
	public partial class Form2 : Form
	{
		Thread th;
		Repository repo=new Repository();
		public Form2()
		{
			InitializeComponent();
		}
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void gestiuneConsultaiiToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void paginaPrincipalaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
			th = new Thread(opennewform);
			th.SetApartmentState(ApartmentState.STA);
			th.Start();
		}

		private void opennewform()
		{

			Application.Run(new Form1());
		}

		private void citireaListeiAflateInBDToolStripMenuItem_Click(object sender, EventArgs e)
		{
			String msg=repo.ReadFromFile();
			MessageBox.Show(msg);
		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void afiseazaConsultatieToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TableLayoutPanel dynamicTableLayoutPanel = new TableLayoutPanel();
			dynamicTableLayoutPanel.Location = new System.Drawing.Point(26, 12);
			dynamicTableLayoutPanel.Name = "TableLayoutPanel1";
			dynamicTableLayoutPanel.Size = new System.Drawing.Size(750, 700);
			dynamicTableLayoutPanel.BackColor = Color.LightBlue;
			// Add rows and columns  
			dynamicTableLayoutPanel.ColumnCount = 6;
			dynamicTableLayoutPanel.RowCount = 25;
			dynamicTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			dynamicTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
			dynamicTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
			dynamicTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
			dynamicTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 200F));
			dynamicTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 200F));
			for (int i = 1; i <= 25; i++)
				dynamicTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
			TextBox textBox1 = new TextBox();
			textBox1.Location = new Point(10, 10);
			textBox1.Text = "Nr.Crt";
			textBox1.Size = new Size(400, 30);
			TextBox textBox2 = new TextBox();
			textBox2.Location = new Point(10, 20);
			textBox2.Text = "Zi";
			textBox2.Size = new Size(400, 30);
			TextBox textBox3 = new TextBox();
			textBox3.Location = new Point(10, 30);
			textBox3.Text = "Luna";
			textBox3.Size = new Size(400, 30);
			TextBox textBox4 = new TextBox();
			textBox4.Location = new Point(10, 40);
			textBox4.Text = "An";
			textBox4.Size = new Size(400, 30);
			TextBox textBox5 = new TextBox();
			textBox5.Location = new Point(10, 50);
			textBox5.Text = "Nume";
			textBox5.Size = new Size(1200, 30);
			TextBox textBox6 = new TextBox();
			textBox6.Location = new Point(10, 60);
			textBox6.Text = "Prenume";
			textBox6.Size = new Size(1200, 30);
			// Add child controls to TableLayoutPanel and specify rows and column  
			dynamicTableLayoutPanel.Controls.Add(textBox1, 0, 1);
			dynamicTableLayoutPanel.Controls.Add(textBox2, 1, 1);
			dynamicTableLayoutPanel.Controls.Add(textBox3, 2, 1);
			dynamicTableLayoutPanel.Controls.Add(textBox4, 3, 1);
			dynamicTableLayoutPanel.Controls.Add(textBox5, 4, 1);
			dynamicTableLayoutPanel.Controls.Add(textBox6, 5, 1);
			Controls.Add(dynamicTableLayoutPanel);




			//Adaugam consultatiile


			for (int i = 0; i < repo.repo.Count(); i++)
			{
				textBox1 = new TextBox();
				textBox1.Location = new Point(10, 10);
				textBox1.Text = (i+1).ToString();
				textBox1.Size = new Size(400, 30);

				textBox2 = new TextBox();
				textBox2.Location = new Point(10, 20);
				textBox2.Text = repo.repo.ElementAt(i).getZi().ToString();
				textBox2.Size = new Size(400, 30);

				textBox3 = new TextBox();
				textBox3.Location = new Point(10, 30);
				textBox3.Text = repo.repo.ElementAt(i).getLuna().ToString();
				textBox3.Size = new Size(400, 30);

				textBox4 = new TextBox();
				textBox4.Location = new Point(10, 40);
				textBox4.Text = repo.repo.ElementAt(i).getAn().ToString();
				textBox4.Size = new Size(400, 30);

				textBox5 = new TextBox();
				textBox5.Location = new Point(10, 50);
				textBox5.Text = repo.repo.ElementAt(i).getP().getNume();
				textBox5.Size = new Size(1200, 30);

				textBox6 = new TextBox();
				textBox6.Location = new Point(10, 60);
				textBox6.Text = repo.repo.ElementAt(i).getP().getPrenume();
				textBox6.Size = new Size(1200, 30);
				dynamicTableLayoutPanel.Controls.Add(textBox1, 0, i + 2);
				dynamicTableLayoutPanel.Controls.Add(textBox2, 1, i + 2);
				dynamicTableLayoutPanel.Controls.Add(textBox3, 2, i + 2);
				dynamicTableLayoutPanel.Controls.Add(textBox4, 3, i + 2);
				dynamicTableLayoutPanel.Controls.Add(textBox5, 4, i + 2);
				dynamicTableLayoutPanel.Controls.Add(textBox6, 5, i + 2);
				Controls.Add(dynamicTableLayoutPanel);
			}
		}

		private void adaugaConsultatieToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TextBox textBox = new TextBox();
			textBox.Location = new System.Drawing.Point(100, 100);
			textBox.Name = "text";
			textBox.Size = new System.Drawing.Size(100, 200);
			textBox.BackColor = Color.Red;
			textBox.Text = "Zi";
			Controls.Add(textBox);

			TextBox textBox2 = new TextBox();
			textBox2.Location = new System.Drawing.Point(100, 140);
			textBox2.Name = "text";
			textBox2.Size = new System.Drawing.Size(100, 200);
			textBox2.BackColor = Color.Orange;
			textBox2.Text = "Luna";
			Controls.Add(textBox2);

			TextBox textBox3 = new TextBox();
			textBox3.Location = new System.Drawing.Point(100, 180);
			textBox3.Name = "text";
			textBox3.Size = new System.Drawing.Size(100, 200);
			textBox3.BackColor = Color.Yellow;
			textBox3.Text = "An";
			Controls.Add(textBox3);

			TextBox textBox4 = new TextBox();
			textBox4.Location = new System.Drawing.Point(100, 220);
			textBox4.Name = "text";
			textBox4.Size = new System.Drawing.Size(100, 200);
			textBox4.BackColor = Color.GreenYellow;
			textBox4.Text = "Nume";
			Controls.Add(textBox4);

			TextBox textBox5 = new TextBox();
			textBox5.Location = new System.Drawing.Point(100, 260);
			textBox5.Name = "text";
			textBox5.Size = new System.Drawing.Size(100, 200);
			textBox5.BackColor = Color.Green;
			textBox5.Text = "Prenume";
			Controls.Add(textBox5);

			TextBox textBox6 = new TextBox();
			textBox6.Location = new System.Drawing.Point(100, 300);
			textBox6.Name = "text";
			textBox6.Size = new System.Drawing.Size(100, 200);
			textBox6.BackColor = Color.Blue;
			textBox6.Text = "Varsta";
			Controls.Add(textBox6);

			TextBox textBox7 = new TextBox();
			textBox7.Location = new System.Drawing.Point(100, 340);
			textBox7.Name = "text";
			textBox7.Size = new System.Drawing.Size(100, 200);
			textBox7.BackColor = Color.BlueViolet;
			textBox7.Text = "Adresa";
			Controls.Add(textBox7);

			TextBox textBox8 = new TextBox();
			textBox8.Location = new System.Drawing.Point(100, 380);
			textBox8.Name = "text";
			textBox8.Size = new System.Drawing.Size(100, 200);
			textBox8.BackColor = Color.Violet;
			textBox8.Text = "Diagnostic";
			Controls.Add(textBox8);

			TextBox textBox9 = new TextBox();
			textBox9.Location = new System.Drawing.Point(100, 420);
			textBox9.Name = "text";
			textBox9.Size = new System.Drawing.Size(100, 200);
			textBox9.BackColor = Color.Pink;
			textBox9.Text = "Tratament";
			Controls.Add(textBox9);

			Button buton = new Button();
			buton.Location = new System.Drawing.Point(300, 60);
			buton.Name = "buton";
			buton.Size = new System.Drawing.Size(100, 25);
			buton.BackColor = Color.PeachPuff;
			buton.Text = "Adauga";
			Controls.Add(buton);


		}

		private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			float val =float.Parse(textBoxSize.Text);
			string font = this.Font.Name;
			this.Font = new Font(font,val);
		}
	}
}
