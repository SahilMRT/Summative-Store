namespace Summative_Store
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
            this.ChalupaLabel = new System.Windows.Forms.Label();
            this.TacoLabel = new System.Windows.Forms.Label();
            this.friessupremeLabel = new System.Windows.Forms.Label();
            this.chalupaText = new System.Windows.Forms.TextBox();
            this.tacoText = new System.Windows.Forms.TextBox();
            this.friesText = new System.Windows.Forms.TextBox();
            this.TotalButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TenderedLabel = new System.Windows.Forms.Label();
            this.tenderedText = new System.Windows.Forms.TextBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.ChangeLabel = new System.Windows.Forms.Label();
            this.ReceiptButton = new System.Windows.Forms.Button();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.textOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.newButton = new System.Windows.Forms.Button();
            this.tryCatchOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChalupaLabel
            // 
            this.ChalupaLabel.AutoSize = true;
            this.ChalupaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChalupaLabel.Location = new System.Drawing.Point(13, 13);
            this.ChalupaLabel.Name = "ChalupaLabel";
            this.ChalupaLabel.Size = new System.Drawing.Size(53, 15);
            this.ChalupaLabel.TabIndex = 0;
            this.ChalupaLabel.Text = "Chalupa";
            // 
            // TacoLabel
            // 
            this.TacoLabel.AutoSize = true;
            this.TacoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TacoLabel.Location = new System.Drawing.Point(13, 44);
            this.TacoLabel.Name = "TacoLabel";
            this.TacoLabel.Size = new System.Drawing.Size(34, 15);
            this.TacoLabel.TabIndex = 1;
            this.TacoLabel.Text = "Taco";
            // 
            // friessupremeLabel
            // 
            this.friessupremeLabel.AutoSize = true;
            this.friessupremeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friessupremeLabel.Location = new System.Drawing.Point(12, 73);
            this.friessupremeLabel.Name = "friessupremeLabel";
            this.friessupremeLabel.Size = new System.Drawing.Size(88, 15);
            this.friessupremeLabel.TabIndex = 2;
            this.friessupremeLabel.Text = "Fries Supreme";
            // 
            // chalupaText
            // 
            this.chalupaText.Location = new System.Drawing.Point(132, 15);
            this.chalupaText.Name = "chalupaText";
            this.chalupaText.Size = new System.Drawing.Size(45, 20);
            this.chalupaText.TabIndex = 3;
            // 
            // tacoText
            // 
            this.tacoText.Location = new System.Drawing.Point(132, 44);
            this.tacoText.Name = "tacoText";
            this.tacoText.Size = new System.Drawing.Size(45, 20);
            this.tacoText.TabIndex = 4;
            // 
            // friesText
            // 
            this.friesText.Location = new System.Drawing.Point(132, 72);
            this.friesText.Name = "friesText";
            this.friesText.Size = new System.Drawing.Size(45, 20);
            this.friesText.TabIndex = 5;
            // 
            // TotalButton
            // 
            this.TotalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalButton.Location = new System.Drawing.Point(16, 98);
            this.TotalButton.Name = "TotalButton";
            this.TotalButton.Size = new System.Drawing.Size(161, 29);
            this.TotalButton.TabIndex = 6;
            this.TotalButton.Text = "Calulate Total";
            this.TotalButton.UseVisualStyleBackColor = true;
            this.TotalButton.Click += new System.EventHandler(this.TotalButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(13, 130);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(59, 15);
            this.subtotalLabel.TabIndex = 7;
            this.subtotalLabel.Text = "Sub Total";
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxLabel.Location = new System.Drawing.Point(20, 154);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(27, 15);
            this.TaxLabel.TabIndex = 8;
            this.TaxLabel.Text = "Tax";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(19, 178);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(34, 15);
            this.TotalLabel.TabIndex = 9;
            this.TotalLabel.Text = "Total";
            // 
            // TenderedLabel
            // 
            this.TenderedLabel.AutoSize = true;
            this.TenderedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenderedLabel.Location = new System.Drawing.Point(13, 210);
            this.TenderedLabel.Name = "TenderedLabel";
            this.TenderedLabel.Size = new System.Drawing.Size(60, 15);
            this.TenderedLabel.TabIndex = 10;
            this.TenderedLabel.Text = "Tendered";
            // 
            // tenderedText
            // 
            this.tenderedText.Location = new System.Drawing.Point(132, 209);
            this.tenderedText.Name = "tenderedText";
            this.tenderedText.Size = new System.Drawing.Size(45, 20);
            this.tenderedText.TabIndex = 11;
            // 
            // ChangeButton
            // 
            this.ChangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeButton.Location = new System.Drawing.Point(16, 235);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(162, 34);
            this.ChangeButton.TabIndex = 12;
            this.ChangeButton.Text = "Calulate Change";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // ChangeLabel
            // 
            this.ChangeLabel.AutoSize = true;
            this.ChangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeLabel.Location = new System.Drawing.Point(20, 286);
            this.ChangeLabel.Name = "ChangeLabel";
            this.ChangeLabel.Size = new System.Drawing.Size(53, 15);
            this.ChangeLabel.TabIndex = 13;
            this.ChangeLabel.Text = "Change ";
            // 
            // ReceiptButton
            // 
            this.ReceiptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiptButton.Location = new System.Drawing.Point(17, 316);
            this.ReceiptButton.Name = "ReceiptButton";
            this.ReceiptButton.Size = new System.Drawing.Size(161, 31);
            this.ReceiptButton.TabIndex = 14;
            this.ReceiptButton.Text = "Print Receipt";
            this.ReceiptButton.UseVisualStyleBackColor = true;
            this.ReceiptButton.Click += new System.EventHandler(this.ReceiptButton_Click);
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.AutoSize = true;
            this.subtotalOutput.BackColor = System.Drawing.Color.Silver;
            this.subtotalOutput.ForeColor = System.Drawing.Color.Black;
            this.subtotalOutput.Location = new System.Drawing.Point(142, 132);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(35, 13);
            this.subtotalOutput.TabIndex = 15;
            this.subtotalOutput.Text = "label1";
            this.subtotalOutput.Visible = false;
            // 
            // textOutput
            // 
            this.textOutput.AutoSize = true;
            this.textOutput.BackColor = System.Drawing.Color.Silver;
            this.textOutput.ForeColor = System.Drawing.Color.Black;
            this.textOutput.Location = new System.Drawing.Point(142, 154);
            this.textOutput.Name = "textOutput";
            this.textOutput.Size = new System.Drawing.Size(35, 13);
            this.textOutput.TabIndex = 16;
            this.textOutput.Text = "label2";
            this.textOutput.Visible = false;
            // 
            // totalOutput
            // 
            this.totalOutput.AutoSize = true;
            this.totalOutput.BackColor = System.Drawing.Color.Silver;
            this.totalOutput.ForeColor = System.Drawing.Color.Black;
            this.totalOutput.Location = new System.Drawing.Point(142, 178);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(35, 13);
            this.totalOutput.TabIndex = 17;
            this.totalOutput.Text = "label3";
            this.totalOutput.Visible = false;
            // 
            // changeOutput
            // 
            this.changeOutput.AutoSize = true;
            this.changeOutput.BackColor = System.Drawing.Color.Silver;
            this.changeOutput.ForeColor = System.Drawing.Color.Black;
            this.changeOutput.Location = new System.Drawing.Point(143, 286);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(35, 13);
            this.changeOutput.TabIndex = 18;
            this.changeOutput.Text = "label4";
            this.changeOutput.Visible = false;
            // 
            // newButton
            // 
            this.newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.Location = new System.Drawing.Point(261, 316);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(205, 31);
            this.newButton.TabIndex = 19;
            this.newButton.Text = "New Order";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // tryCatchOutput
            // 
            this.tryCatchOutput.AutoSize = true;
            this.tryCatchOutput.Location = new System.Drawing.Point(372, 73);
            this.tryCatchOutput.Name = "tryCatchOutput";
            this.tryCatchOutput.Size = new System.Drawing.Size(0, 13);
            this.tryCatchOutput.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(528, 380);
            this.Controls.Add(this.tryCatchOutput);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.ReceiptButton);
            this.Controls.Add(this.ChangeLabel);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.tenderedText);
            this.Controls.Add(this.TenderedLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.TaxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.TotalButton);
            this.Controls.Add(this.friesText);
            this.Controls.Add(this.tacoText);
            this.Controls.Add(this.chalupaText);
            this.Controls.Add(this.friessupremeLabel);
            this.Controls.Add(this.TacoLabel);
            this.Controls.Add(this.ChalupaLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Taco Bell";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChalupaLabel;
        private System.Windows.Forms.Label TacoLabel;
        private System.Windows.Forms.Label friessupremeLabel;
        private System.Windows.Forms.TextBox chalupaText;
        private System.Windows.Forms.TextBox tacoText;
        private System.Windows.Forms.TextBox friesText;
        private System.Windows.Forms.Button TotalButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label TenderedLabel;
        private System.Windows.Forms.TextBox tenderedText;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Label ChangeLabel;
        private System.Windows.Forms.Button ReceiptButton;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label textOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Label tryCatchOutput;
    }
}

