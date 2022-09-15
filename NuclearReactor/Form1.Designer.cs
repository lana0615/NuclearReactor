namespace NuclearReactor
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
            this.titlelabel = new System.Windows.Forms.Label();
            this.reactor1label = new System.Windows.Forms.Label();
            this.reactor2label = new System.Windows.Forms.Label();
            this.reactor1statelabel = new System.Windows.Forms.Label();
            this.reactor2statelabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titlelabel
            // 
            this.titlelabel.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelabel.Location = new System.Drawing.Point(248, 19);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(349, 82);
            this.titlelabel.TabIndex = 0;
            this.titlelabel.Text = "Nuclear Reactor Control";
            this.titlelabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // reactor1label
            // 
            this.reactor1label.AutoSize = true;
            this.reactor1label.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactor1label.Location = new System.Drawing.Point(100, 116);
            this.reactor1label.Name = "reactor1label";
            this.reactor1label.Size = new System.Drawing.Size(91, 34);
            this.reactor1label.TabIndex = 1;
            this.reactor1label.Text = "Reactor 1";
            // 
            // reactor2label
            // 
            this.reactor2label.AutoSize = true;
            this.reactor2label.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactor2label.Location = new System.Drawing.Point(506, 116);
            this.reactor2label.Name = "reactor2label";
            this.reactor2label.Size = new System.Drawing.Size(91, 34);
            this.reactor2label.TabIndex = 2;
            this.reactor2label.Text = "Reactor 2";
            // 
            // reactor1statelabel
            // 
            this.reactor1statelabel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.reactor1statelabel.Location = new System.Drawing.Point(82, 187);
            this.reactor1statelabel.Name = "reactor1statelabel";
            this.reactor1statelabel.Size = new System.Drawing.Size(127, 120);
            this.reactor1statelabel.TabIndex = 3;
            // 
            // reactor2statelabel
            // 
            this.reactor2statelabel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.reactor2statelabel.Location = new System.Drawing.Point(486, 187);
            this.reactor2statelabel.Name = "reactor2statelabel";
            this.reactor2statelabel.Size = new System.Drawing.Size(134, 125);
            this.reactor2statelabel.TabIndex = 4;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.White;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(305, 339);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(144, 23);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "Start Reactor";
            this.StartButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StartButton.Click += new System.EventHandler(this.StartReactor_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(169, 389);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(403, 23);
            this.outputLabel.TabIndex = 6;
            this.outputLabel.Text = "Reactor Stable";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.outputLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(297, 325);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 51);
            this.button3.TabIndex = 7;
            this.button3.Text = "Start Reactor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.reactor2statelabel);
            this.Controls.Add(this.reactor1statelabel);
            this.Controls.Add(this.reactor2label);
            this.Controls.Add(this.reactor1label);
            this.Controls.Add(this.titlelabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.Label reactor1label;
        private System.Windows.Forms.Label reactor2label;
        private System.Windows.Forms.Label reactor1statelabel;
        private System.Windows.Forms.Label reactor2statelabel;
        private System.Windows.Forms.Label StartButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button button3;
    }
}

