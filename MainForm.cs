/*
 * Created by SharpDevelop.
 * User: User
 * Date: 26/02/2022
 * Time: 11:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace tugaspertemuan3
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			listBox1.Items.Add(textBox1.Text);

			textBox1.Clear();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
		}
	}
}
