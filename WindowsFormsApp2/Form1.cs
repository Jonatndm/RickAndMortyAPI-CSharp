using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp2.Apis;

namespace WindowsFormsApp2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		Api api = new Api();
		private void button1_Click_1(object sender, EventArgs e)
		{
			
			Random rnd = new Random();
			int random = rnd.Next(0, 20);
			
			dynamic response = api.Get("https://rickandmortyapi.com/api/character");
			//Obtenemos la foto
			pictureBox1.ImageLocation = response.results[random].image;

			
			textBox1.Text = response.results[random].name;

			textBox2.Text = response.results[random].species;

			textBox3.Text = response.results[random].gender;

			if (response.results[random].type != string.Empty)
			{
				textBox4.Text = response.results[random].type;
			}
			else
			{
				textBox4.Text = "No Type";
			}

		}
	}
}
