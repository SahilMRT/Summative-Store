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
        const double TAX = 0.13;

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

        //Adds Arial Font 
        Graphics formGraphics;
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        Font arialFont9 = new Font("Arial", 9, FontStyle.Bold);

        public Form1()
        {
            InitializeComponent();
            formGraphics = this.CreateGraphics();
        }

        //Calculates Total for Order 
        private void TotalButton_Click(object sender, EventArgs e)
        {
            try
            {
                chalupa = Convert.ToInt32(chalupaText.Text);
                taco = Convert.ToInt32(tacoText.Text);
                friessupreme = Convert.ToInt32(friesText.Text);

                //Calcuates cost
                cost = chalupa * CHALUPA + taco * TACO + friessupreme * FRIESSUPREME;
                tax = cost * TAX;
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

            catch
            { tryCatchOutput.Text = "Invalid Input";}
            tryCatchOutput.Visible = true;
        }
        //Calculates and displays the change for the Customer
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                chaChing.Play();
                changeOutput.Visible = true;
                change = Convert.ToDouble(tenderedText.Text);
                changeBack = change - totalCost;
                changeOutput.Text = "$" + changeBack;
            }
            catch
            { tryCatchOutput.Text = "Invalid Cash"; }
            tryCatchOutput.Visible = true;

            // Creates Receipt for Customer
        } private void ReceiptButton_Click(object sender, EventArgs e)
        {
            try
            {
                Graphics formgraphics = this.CreateGraphics();
                SolidBrush ReceiptButton = new SolidBrush(Color.White);
                SolidBrush textBrush = new SolidBrush(Color.Black);
                Font receiptFont = new Font("Consolas", 9, FontStyle.Bold);
                formgraphics.FillRectangle(ReceiptButton, 240, 10, 270, 280);
               
        //Makes everything in the Receipt 
        formgraphics.DrawString("Taco Bell Inc.", receiptFont, blackBrush, 315, 10);
                formgraphics.DrawString("Order Number 1096", receiptFont, blackBrush, 315, 30);
                formgraphics.DrawString("October/31/2016", receiptFont, blackBrush, 315, 50);
                formgraphics.DrawString("Chalupa        x @   " + chalupa, receiptFont, blackBrush, 315, 70);
                formgraphics.DrawString("Taco           x @   " + taco, receiptFont, blackBrush, 315, 90);
                formgraphics.DrawString("Fries Supreme  x @   " + friessupreme, receiptFont, blackBrush, 315, 110);
                formgraphics.DrawString("Subtotal       $     " + cost, receiptFont, blackBrush, 315, 130);
                formgraphics.DrawString("Tax            $     " + tax, receiptFont, blackBrush, 315, 150);
                formgraphics.DrawString("Total          $     " + totalCost, receiptFont, blackBrush, 315, 170);
                formgraphics.DrawString("Tendered       $     " + change, receiptFont, blackBrush, 315, 190);
                formgraphics.DrawString("Change         $     " + changeBack, receiptFont, blackBrush, 315, 210);
                formgraphics.DrawString("Have a nice day!!!   ", receiptFont, blackBrush, 315, 230);
                chaChing.Play();
            }
            catch
            { tryCatchOutput.Text = "Invalid Input"; }
            tryCatchOutput.Visible = false;
        }
        private void newButton_Click(object sender, EventArgs e)
        { 
            try
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
                change = 0;
                changeBack = 0;
                totalCost = 0;
                cost = 0;
                tax = 0;

                Graphics formgraphics = this.CreateGraphics();
                SolidBrush ReceiptButton = new SolidBrush(Color.White);
                formgraphics.FillRectangle(ReceiptButton, 240, 10, 270, 280);
            }
            catch
            { tryCatchOutput.Text = "Invalid Input"; }
            tryCatchOutput.Visible = false;
        }
    }
    }

