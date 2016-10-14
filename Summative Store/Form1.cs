// Created by: Sahil Patel on Oct/07/2016
//The objective to create a fully functional register software 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace Summative_Store
{
    public partial class Form1 : Form
    {
        const double CHALUPA = 3.50;
        const double TACO = 2.50;
        const double FRIESSUPREME = 3.00;
        double chalupa;
        double taco;
        double friessupreme;
        double change;
        double changeBack;
        double totalCost;
        double cost;
        double tax;
        //Adds sounds in program 
        SoundPlayer chaChing = new SoundPlayer(Properties.Resources.Cha_Ching_Register_Muska666_173262285); 
        public Form1()
        {
            InitializeComponent();
        }
       
        private void TotalButton_Click(object sender, EventArgs e)
        {
            chalupa = Convert.ToInt32(chalupaText.Text);
            taco = Convert.ToInt32(tacoText.Text);
            friessupreme = Convert.ToInt32(friesText.Text);

            //Calcuates cost
            cost = chalupa * CHALUPA + taco * TACO + friessupreme * FRIESSUPREME;
            tax = cost * 0.13;
            totalCost = cost + tax; 

            //Prints out totals and tax with sound 
            chaChing.Play();
            subtotalOutput.Text = cost.ToString("C");
            subtotalOutput.Visible = true;
            subtotalOutput.Refresh();
            Thread.Sleep(1000);

            chaChing.Play();
            textOutput.Text = tax.ToString("C");
            textOutput.Visible = true;
            textOutput.Refresh();
            Thread.Sleep(1000);

            chaChing.Play();
            totalOutput.Text = totalCost.ToString("C");
            totalOutput.Visible = true;
            totalOutput.Refresh();
            Thread.Sleep(1000);
        }
        //Calculates and displays the change for the Customer
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            chaChing.Play();
            changeOutput.Visible = true;
            change = Convert.ToDouble(tenderedText.Text);
            changeBack = change - totalCost;
            changeOutput.Text = "$" + changeBack;
        }
        // Creates Receipt for Customer
        private void ReceiptButton_Click(object sender, EventArgs e)
        {
            Graphics formgraphics = this.CreateGraphics();
            SolidBrush ReceiptButton = new SolidBrush(Color.White);
            SolidBrush textBrush = new SolidBrush(Color.Black);
            Font ReciptFont = new Font("Arial", 7, FontStyle.Bold);
            formgraphics.FillRectangle(ReceiptButton, 240, 10, 270, 280);


        }

        private void newButton_Click(object sender, EventArgs e)
        {
            //clear labels and inputs
            subtotalOutput.Text = "";
            textOutput.Text = "";
            totalOutput.Text = "";
            chalupaText.Text = "";
            tacoText.Text = "";
            friesText.Text = "";
            tenderedText.Text = "";
            changeOutput.Text = "";
            //clear variables
            chalupa = 0;
            taco = 0; 
            friessupreme = 0;  
            
        }
    }
}
