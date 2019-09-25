namespace Calculator1
{
    partial class Calculater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculater));
            this.Screentxt = new System.Windows.Forms.TextBox();
            this.CEbtn = new System.Windows.Forms.Button();
            this.Cbtn = new System.Windows.Forms.Button();
            this.divedbtn = new System.Windows.Forms.Button();
            this.mulbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.Eqlbtn = new System.Windows.Forms.Button();
            this.Zerobtn = new System.Windows.Forms.Button();
            this.Onebtn = new System.Windows.Forms.Button();
            this.Twobtn = new System.Windows.Forms.Button();
            this.threebtn = new System.Windows.Forms.Button();
            this.fourbtn = new System.Windows.Forms.Button();
            this.Fivebtn = new System.Windows.Forms.Button();
            this.Sixbtn = new System.Windows.Forms.Button();
            this.Sevenbtn = new System.Windows.Forms.Button();
            this.Eightbtn = new System.Windows.Forms.Button();
            this.Ninebtn = new System.Windows.Forms.Button();
            this.Dotbtn = new System.Windows.Forms.Button();
            this.Squarebtn = new System.Windows.Forms.Button();
            this.Rootbtn = new System.Windows.Forms.Button();
            this.Percentagebtn = new System.Windows.Forms.Button();
            this.PNbtn = new System.Windows.Forms.Button();
            this.DELbtn = new System.Windows.Forms.Button();
            this.labelCurrentOperation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Screentxt
            // 
            this.Screentxt.Location = new System.Drawing.Point(26, 38);
            this.Screentxt.Multiline = true;
            this.Screentxt.Name = "Screentxt";
            this.Screentxt.Size = new System.Drawing.Size(692, 64);
            this.Screentxt.TabIndex = 0;
            this.Screentxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Screentxt.TextChanged += new System.EventHandler(this.Screentxt_TextChanged);
            // 
            // CEbtn
            // 
            this.CEbtn.Location = new System.Drawing.Point(26, 142);
            this.CEbtn.Name = "CEbtn";
            this.CEbtn.Size = new System.Drawing.Size(75, 37);
            this.CEbtn.TabIndex = 1;
            this.CEbtn.Text = "CE";
            this.CEbtn.UseVisualStyleBackColor = true;
            this.CEbtn.Click += new System.EventHandler(this.CEbtn_Click);
            // 
            // Cbtn
            // 
            this.Cbtn.Location = new System.Drawing.Point(141, 142);
            this.Cbtn.Name = "Cbtn";
            this.Cbtn.Size = new System.Drawing.Size(75, 37);
            this.Cbtn.TabIndex = 2;
            this.Cbtn.Text = "C";
            this.Cbtn.UseVisualStyleBackColor = true;
            this.Cbtn.Click += new System.EventHandler(this.Cbtn_Click);
            // 
            // divedbtn
            // 
            this.divedbtn.Location = new System.Drawing.Point(260, 142);
            this.divedbtn.Name = "divedbtn";
            this.divedbtn.Size = new System.Drawing.Size(75, 37);
            this.divedbtn.TabIndex = 3;
            this.divedbtn.Text = "/";
            this.divedbtn.UseVisualStyleBackColor = true;
            this.divedbtn.Click += new System.EventHandler(this.divedbtn_Click);
            // 
            // mulbtn
            // 
            this.mulbtn.Location = new System.Drawing.Point(387, 142);
            this.mulbtn.Name = "mulbtn";
            this.mulbtn.Size = new System.Drawing.Size(75, 37);
            this.mulbtn.TabIndex = 4;
            this.mulbtn.Text = "x";
            this.mulbtn.UseVisualStyleBackColor = true;
            this.mulbtn.Click += new System.EventHandler(this.mulbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(495, 142);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 37);
            this.addbtn.TabIndex = 5;
            this.addbtn.Text = "+";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(608, 142);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(75, 37);
            this.minus.TabIndex = 6;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // Eqlbtn
            // 
            this.Eqlbtn.Location = new System.Drawing.Point(712, 142);
            this.Eqlbtn.Name = "Eqlbtn";
            this.Eqlbtn.Size = new System.Drawing.Size(75, 37);
            this.Eqlbtn.TabIndex = 7;
            this.Eqlbtn.Text = "=";
            this.Eqlbtn.UseVisualStyleBackColor = true;
            this.Eqlbtn.Click += new System.EventHandler(this.Eqlbtn_Click);
            // 
            // Zerobtn
            // 
            this.Zerobtn.Location = new System.Drawing.Point(26, 212);
            this.Zerobtn.Name = "Zerobtn";
            this.Zerobtn.Size = new System.Drawing.Size(75, 37);
            this.Zerobtn.TabIndex = 8;
            this.Zerobtn.Text = "0";
            this.Zerobtn.UseVisualStyleBackColor = true;
            this.Zerobtn.Click += new System.EventHandler(this.Zerobtn_Click);
            // 
            // Onebtn
            // 
            this.Onebtn.Location = new System.Drawing.Point(141, 212);
            this.Onebtn.Name = "Onebtn";
            this.Onebtn.Size = new System.Drawing.Size(75, 37);
            this.Onebtn.TabIndex = 9;
            this.Onebtn.Text = "1";
            this.Onebtn.UseVisualStyleBackColor = true;
            this.Onebtn.Click += new System.EventHandler(this.Onebtn_Click);
            // 
            // Twobtn
            // 
            this.Twobtn.Location = new System.Drawing.Point(260, 212);
            this.Twobtn.Name = "Twobtn";
            this.Twobtn.Size = new System.Drawing.Size(75, 37);
            this.Twobtn.TabIndex = 10;
            this.Twobtn.Text = "2";
            this.Twobtn.UseVisualStyleBackColor = true;
            this.Twobtn.Click += new System.EventHandler(this.Twobtn_Click);
            // 
            // threebtn
            // 
            this.threebtn.Location = new System.Drawing.Point(387, 212);
            this.threebtn.Name = "threebtn";
            this.threebtn.Size = new System.Drawing.Size(75, 37);
            this.threebtn.TabIndex = 11;
            this.threebtn.Text = "3";
            this.threebtn.UseVisualStyleBackColor = true;
            this.threebtn.Click += new System.EventHandler(this.threebtn_Click);
            // 
            // fourbtn
            // 
            this.fourbtn.Location = new System.Drawing.Point(495, 212);
            this.fourbtn.Name = "fourbtn";
            this.fourbtn.Size = new System.Drawing.Size(75, 37);
            this.fourbtn.TabIndex = 12;
            this.fourbtn.Text = "4";
            this.fourbtn.UseVisualStyleBackColor = true;
            this.fourbtn.Click += new System.EventHandler(this.fourbtn_Click);
            // 
            // Fivebtn
            // 
            this.Fivebtn.Location = new System.Drawing.Point(608, 212);
            this.Fivebtn.Name = "Fivebtn";
            this.Fivebtn.Size = new System.Drawing.Size(75, 37);
            this.Fivebtn.TabIndex = 13;
            this.Fivebtn.Text = "5";
            this.Fivebtn.UseVisualStyleBackColor = true;
            this.Fivebtn.Click += new System.EventHandler(this.Fivebtn_Click);
            // 
            // Sixbtn
            // 
            this.Sixbtn.Location = new System.Drawing.Point(712, 212);
            this.Sixbtn.Name = "Sixbtn";
            this.Sixbtn.Size = new System.Drawing.Size(75, 37);
            this.Sixbtn.TabIndex = 14;
            this.Sixbtn.Text = "6";
            this.Sixbtn.UseVisualStyleBackColor = true;
            this.Sixbtn.Click += new System.EventHandler(this.Sixbtn_Click);
            // 
            // Sevenbtn
            // 
            this.Sevenbtn.Location = new System.Drawing.Point(26, 294);
            this.Sevenbtn.Name = "Sevenbtn";
            this.Sevenbtn.Size = new System.Drawing.Size(75, 37);
            this.Sevenbtn.TabIndex = 15;
            this.Sevenbtn.Text = "7";
            this.Sevenbtn.UseVisualStyleBackColor = true;
            this.Sevenbtn.Click += new System.EventHandler(this.Sevenbtn_Click);
            // 
            // Eightbtn
            // 
            this.Eightbtn.Location = new System.Drawing.Point(141, 294);
            this.Eightbtn.Name = "Eightbtn";
            this.Eightbtn.Size = new System.Drawing.Size(75, 37);
            this.Eightbtn.TabIndex = 16;
            this.Eightbtn.Text = "8";
            this.Eightbtn.UseVisualStyleBackColor = true;
            this.Eightbtn.Click += new System.EventHandler(this.Eightbtn_Click);
            // 
            // Ninebtn
            // 
            this.Ninebtn.Location = new System.Drawing.Point(260, 294);
            this.Ninebtn.Name = "Ninebtn";
            this.Ninebtn.Size = new System.Drawing.Size(75, 37);
            this.Ninebtn.TabIndex = 17;
            this.Ninebtn.Text = "9";
            this.Ninebtn.UseVisualStyleBackColor = true;
            this.Ninebtn.Click += new System.EventHandler(this.Ninebtn_Click);
            // 
            // Dotbtn
            // 
            this.Dotbtn.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, ((System.Drawing.FontStyle)((((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dotbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Dotbtn.Location = new System.Drawing.Point(387, 294);
            this.Dotbtn.Name = "Dotbtn";
            this.Dotbtn.Size = new System.Drawing.Size(75, 37);
            this.Dotbtn.TabIndex = 18;
            this.Dotbtn.Text = ".";
            this.Dotbtn.UseVisualStyleBackColor = true;
            this.Dotbtn.Click += new System.EventHandler(this.Dotbtn_Click);
            // 
            // Squarebtn
            // 
            this.Squarebtn.Location = new System.Drawing.Point(495, 294);
            this.Squarebtn.Name = "Squarebtn";
            this.Squarebtn.Size = new System.Drawing.Size(75, 37);
            this.Squarebtn.TabIndex = 19;
            this.Squarebtn.Text = "x^2";
            this.Squarebtn.UseVisualStyleBackColor = true;
            this.Squarebtn.Click += new System.EventHandler(this.Squarebtn_Click);
            // 
            // Rootbtn
            // 
            this.Rootbtn.Location = new System.Drawing.Point(608, 294);
            this.Rootbtn.Name = "Rootbtn";
            this.Rootbtn.Size = new System.Drawing.Size(75, 37);
            this.Rootbtn.TabIndex = 20;
            this.Rootbtn.Text = "√";
            this.Rootbtn.UseVisualStyleBackColor = true;
            // 
            // Percentagebtn
            // 
            this.Percentagebtn.Location = new System.Drawing.Point(712, 294);
            this.Percentagebtn.Name = "Percentagebtn";
            this.Percentagebtn.Size = new System.Drawing.Size(75, 37);
            this.Percentagebtn.TabIndex = 21;
            this.Percentagebtn.Text = "%";
            this.Percentagebtn.UseVisualStyleBackColor = true;
            // 
            // PNbtn
            // 
            this.PNbtn.Location = new System.Drawing.Point(26, 374);
            this.PNbtn.Name = "PNbtn";
            this.PNbtn.Size = new System.Drawing.Size(75, 37);
            this.PNbtn.TabIndex = 22;
            this.PNbtn.Text = "+/-";
            this.PNbtn.UseVisualStyleBackColor = true;
            // 
            // DELbtn
            // 
            this.DELbtn.Location = new System.Drawing.Point(141, 374);
            this.DELbtn.Name = "DELbtn";
            this.DELbtn.Size = new System.Drawing.Size(75, 37);
            this.DELbtn.TabIndex = 23;
            this.DELbtn.Text = "DEL";
            this.DELbtn.UseVisualStyleBackColor = true;
            this.DELbtn.Click += new System.EventHandler(this.DELbtn_Click);
            // 
            // labelCurrentOperation
            // 
            this.labelCurrentOperation.AutoSize = true;
            this.labelCurrentOperation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelCurrentOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentOperation.Location = new System.Drawing.Point(21, 9);
            this.labelCurrentOperation.Name = "labelCurrentOperation";
            this.labelCurrentOperation.Size = new System.Drawing.Size(0, 25);
            this.labelCurrentOperation.TabIndex = 24;
            // 
            // Calculater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.labelCurrentOperation);
            this.Controls.Add(this.DELbtn);
            this.Controls.Add(this.PNbtn);
            this.Controls.Add(this.Percentagebtn);
            this.Controls.Add(this.Rootbtn);
            this.Controls.Add(this.Squarebtn);
            this.Controls.Add(this.Dotbtn);
            this.Controls.Add(this.Ninebtn);
            this.Controls.Add(this.Eightbtn);
            this.Controls.Add(this.Sevenbtn);
            this.Controls.Add(this.Sixbtn);
            this.Controls.Add(this.Fivebtn);
            this.Controls.Add(this.fourbtn);
            this.Controls.Add(this.threebtn);
            this.Controls.Add(this.Twobtn);
            this.Controls.Add(this.Onebtn);
            this.Controls.Add(this.Zerobtn);
            this.Controls.Add(this.Eqlbtn);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.mulbtn);
            this.Controls.Add(this.divedbtn);
            this.Controls.Add(this.Cbtn);
            this.Controls.Add(this.CEbtn);
            this.Controls.Add(this.Screentxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculater";
            this.Text = "Calculater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Screentxt;
        private System.Windows.Forms.Button CEbtn;
        private System.Windows.Forms.Button Cbtn;
        private System.Windows.Forms.Button divedbtn;
        private System.Windows.Forms.Button mulbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button Eqlbtn;
        private System.Windows.Forms.Button Zerobtn;
        private System.Windows.Forms.Button Onebtn;
        private System.Windows.Forms.Button Twobtn;
        private System.Windows.Forms.Button threebtn;
        private System.Windows.Forms.Button fourbtn;
        private System.Windows.Forms.Button Fivebtn;
        private System.Windows.Forms.Button Sixbtn;
        private System.Windows.Forms.Button Sevenbtn;
        private System.Windows.Forms.Button Eightbtn;
        private System.Windows.Forms.Button Ninebtn;
        private System.Windows.Forms.Button Dotbtn;
        private System.Windows.Forms.Button Squarebtn;
        private System.Windows.Forms.Button Rootbtn;
        private System.Windows.Forms.Button Percentagebtn;
        private System.Windows.Forms.Button PNbtn;
        private System.Windows.Forms.Button DELbtn;
        private System.Windows.Forms.Label labelCurrentOperation;
    }
}

