namespace Perimeter_AreaCalculatorFormApp
{
    partial class PerimeterAreaCalculatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioLabel = new System.Windows.Forms.Label();
            this.circleButton = new System.Windows.Forms.RadioButton();
            this.squareButton = new System.Windows.Forms.RadioButton();
            this.rectangleButton = new System.Windows.Forms.RadioButton();
            this.triangleButton = new System.Windows.Forms.RadioButton();
            this.radiusBox = new System.Windows.Forms.TextBox();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.lengthGroupBox = new System.Windows.Forms.GroupBox();
            this.sideBox3 = new System.Windows.Forms.TextBox();
            this.sideLabel3 = new System.Windows.Forms.Label();
            this.sideBox2 = new System.Windows.Forms.TextBox();
            this.sideBox1 = new System.Windows.Forms.TextBox();
            this.sideLabel2 = new System.Windows.Forms.Label();
            this.sideLabel1 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.triangleTypeBox = new System.Windows.Forms.TextBox();
            this.triangleTypeLabel = new System.Windows.Forms.Label();
            this.areaBox = new System.Windows.Forms.TextBox();
            this.areaLabel = new System.Windows.Forms.Label();
            this.perimeterLabel = new System.Windows.Forms.Label();
            this.perimeterBox = new System.Windows.Forms.TextBox();
            this.resultGroupBox = new System.Windows.Forms.GroupBox();
            this.lengthGroupBox.SuspendLayout();
            this.resultGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioLabel
            // 
            this.radioLabel.AutoSize = true;
            this.radioLabel.Location = new System.Drawing.Point(34, 13);
            this.radioLabel.Name = "radioLabel";
            this.radioLabel.Size = new System.Drawing.Size(84, 15);
            this.radioLabel.TabIndex = 0;
            this.radioLabel.Text = "Select a shape:";
            // 
            // circleButton
            // 
            this.circleButton.AutoSize = true;
            this.circleButton.Location = new System.Drawing.Point(34, 36);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(55, 19);
            this.circleButton.TabIndex = 1;
            this.circleButton.TabStop = true;
            this.circleButton.Text = "Circle";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.CheckedChanged += new System.EventHandler(this.circleButton_CheckedChanged);
            // 
            // squareButton
            // 
            this.squareButton.AutoSize = true;
            this.squareButton.Location = new System.Drawing.Point(34, 62);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(61, 19);
            this.squareButton.TabIndex = 2;
            this.squareButton.TabStop = true;
            this.squareButton.Text = "Square";
            this.squareButton.UseVisualStyleBackColor = true;
            this.squareButton.CheckedChanged += new System.EventHandler(this.squareButton_CheckedChanged);
            // 
            // rectangleButton
            // 
            this.rectangleButton.AutoSize = true;
            this.rectangleButton.Location = new System.Drawing.Point(34, 88);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(77, 19);
            this.rectangleButton.TabIndex = 3;
            this.rectangleButton.TabStop = true;
            this.rectangleButton.Text = "Rectangle";
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.CheckedChanged += new System.EventHandler(this.rectangleButton_CheckedChanged);
            // 
            // triangleButton
            // 
            this.triangleButton.AutoSize = true;
            this.triangleButton.Location = new System.Drawing.Point(34, 114);
            this.triangleButton.Name = "triangleButton";
            this.triangleButton.Size = new System.Drawing.Size(66, 19);
            this.triangleButton.TabIndex = 4;
            this.triangleButton.TabStop = true;
            this.triangleButton.Text = "Triangle";
            this.triangleButton.UseVisualStyleBackColor = true;
            this.triangleButton.CheckedChanged += new System.EventHandler(this.triangleButton_CheckedChanged);
            // 
            // radiusBox
            // 
            this.radiusBox.Location = new System.Drawing.Point(66, 27);
            this.radiusBox.Name = "radiusBox";
            this.radiusBox.Size = new System.Drawing.Size(110, 23);
            this.radiusBox.TabIndex = 6;
            this.radiusBox.TextChanged += new System.EventHandler(this.radiusBox_TextChanged);
            // 
            // radiusLabel
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Location = new System.Drawing.Point(15, 30);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(42, 15);
            this.radiusLabel.TabIndex = 7;
            this.radiusLabel.Text = "Radius";
            // 
            // lengthGroupBox
            // 
            this.lengthGroupBox.Controls.Add(this.sideBox3);
            this.lengthGroupBox.Controls.Add(this.sideLabel3);
            this.lengthGroupBox.Controls.Add(this.sideBox2);
            this.lengthGroupBox.Controls.Add(this.sideBox1);
            this.lengthGroupBox.Controls.Add(this.sideLabel2);
            this.lengthGroupBox.Controls.Add(this.sideLabel1);
            this.lengthGroupBox.Controls.Add(this.radiusLabel);
            this.lengthGroupBox.Controls.Add(this.radiusBox);
            this.lengthGroupBox.Location = new System.Drawing.Point(143, 13);
            this.lengthGroupBox.Name = "lengthGroupBox";
            this.lengthGroupBox.Size = new System.Drawing.Size(195, 175);
            this.lengthGroupBox.TabIndex = 8;
            this.lengthGroupBox.TabStop = false;
            this.lengthGroupBox.Text = "Lengthes";
            // 
            // sideBox3
            // 
            this.sideBox3.Location = new System.Drawing.Point(67, 128);
            this.sideBox3.Name = "sideBox3";
            this.sideBox3.Size = new System.Drawing.Size(109, 23);
            this.sideBox3.TabIndex = 6;
            this.sideBox3.TextChanged += new System.EventHandler(this.sideBox3_TextChanged);
            // 
            // sideLabel3
            // 
            this.sideLabel3.AutoSize = true;
            this.sideLabel3.Location = new System.Drawing.Point(15, 131);
            this.sideLabel3.Name = "sideLabel3";
            this.sideLabel3.Size = new System.Drawing.Size(38, 15);
            this.sideLabel3.TabIndex = 7;
            this.sideLabel3.Text = "Side 3";
            // 
            // sideBox2
            // 
            this.sideBox2.Location = new System.Drawing.Point(66, 95);
            this.sideBox2.Name = "sideBox2";
            this.sideBox2.Size = new System.Drawing.Size(110, 23);
            this.sideBox2.TabIndex = 6;
            this.sideBox2.TextChanged += new System.EventHandler(this.sideBox2_TextChanged);
            // 
            // sideBox1
            // 
            this.sideBox1.Location = new System.Drawing.Point(66, 62);
            this.sideBox1.Name = "sideBox1";
            this.sideBox1.Size = new System.Drawing.Size(110, 23);
            this.sideBox1.TabIndex = 6;
            this.sideBox1.TextChanged += new System.EventHandler(this.sideBox1_TextChanged);
            // 
            // sideLabel2
            // 
            this.sideLabel2.AutoSize = true;
            this.sideLabel2.Location = new System.Drawing.Point(15, 98);
            this.sideLabel2.Name = "sideLabel2";
            this.sideLabel2.Size = new System.Drawing.Size(38, 15);
            this.sideLabel2.TabIndex = 7;
            this.sideLabel2.Text = "Side 2";
            // 
            // sideLabel1
            // 
            this.sideLabel1.AutoSize = true;
            this.sideLabel1.Location = new System.Drawing.Point(15, 65);
            this.sideLabel1.Name = "sideLabel1";
            this.sideLabel1.Size = new System.Drawing.Size(38, 15);
            this.sideLabel1.TabIndex = 7;
            this.sideLabel1.Text = "Side 1";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(11, 150);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(126, 38);
            this.calculateButton.TabIndex = 9;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // triangleTypeBox
            // 
            this.triangleTypeBox.Location = new System.Drawing.Point(96, 95);
            this.triangleTypeBox.Name = "triangleTypeBox";
            this.triangleTypeBox.ReadOnly = true;
            this.triangleTypeBox.Size = new System.Drawing.Size(122, 23);
            this.triangleTypeBox.TabIndex = 6;
            // 
            // triangleTypeLabel
            // 
            this.triangleTypeLabel.AutoSize = true;
            this.triangleTypeLabel.Location = new System.Drawing.Point(15, 98);
            this.triangleTypeLabel.Name = "triangleTypeLabel";
            this.triangleTypeLabel.Size = new System.Drawing.Size(75, 15);
            this.triangleTypeLabel.TabIndex = 7;
            this.triangleTypeLabel.Text = "Triangle Type";
            // 
            // areaBox
            // 
            this.areaBox.Location = new System.Drawing.Point(84, 62);
            this.areaBox.Name = "areaBox";
            this.areaBox.ReadOnly = true;
            this.areaBox.Size = new System.Drawing.Size(133, 23);
            this.areaBox.TabIndex = 6;
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Location = new System.Drawing.Point(15, 65);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(31, 15);
            this.areaLabel.TabIndex = 7;
            this.areaLabel.Text = "Area";
            // 
            // perimeterLabel
            // 
            this.perimeterLabel.AutoSize = true;
            this.perimeterLabel.Location = new System.Drawing.Point(15, 30);
            this.perimeterLabel.Name = "perimeterLabel";
            this.perimeterLabel.Size = new System.Drawing.Size(58, 15);
            this.perimeterLabel.TabIndex = 7;
            this.perimeterLabel.Text = "Perimeter";
            // 
            // perimeterBox
            // 
            this.perimeterBox.Location = new System.Drawing.Point(84, 27);
            this.perimeterBox.Name = "perimeterBox";
            this.perimeterBox.ReadOnly = true;
            this.perimeterBox.Size = new System.Drawing.Size(134, 23);
            this.perimeterBox.TabIndex = 6;
            // 
            // resultGroupBox
            // 
            this.resultGroupBox.Controls.Add(this.triangleTypeBox);
            this.resultGroupBox.Controls.Add(this.triangleTypeLabel);
            this.resultGroupBox.Controls.Add(this.areaBox);
            this.resultGroupBox.Controls.Add(this.areaLabel);
            this.resultGroupBox.Controls.Add(this.perimeterLabel);
            this.resultGroupBox.Controls.Add(this.perimeterBox);
            this.resultGroupBox.Location = new System.Drawing.Point(344, 13);
            this.resultGroupBox.Name = "resultGroupBox";
            this.resultGroupBox.Size = new System.Drawing.Size(233, 175);
            this.resultGroupBox.TabIndex = 8;
            this.resultGroupBox.TabStop = false;
            this.resultGroupBox.Text = "Results";
            // 
            // PerimeterAreaCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(596, 208);
            this.Controls.Add(this.resultGroupBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.lengthGroupBox);
            this.Controls.Add(this.triangleButton);
            this.Controls.Add(this.rectangleButton);
            this.Controls.Add(this.squareButton);
            this.Controls.Add(this.circleButton);
            this.Controls.Add(this.radioLabel);
            this.Name = "PerimeterAreaCalculatorForm";
            this.Text = "Perimeter and Area Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.lengthGroupBox.ResumeLayout(false);
            this.lengthGroupBox.PerformLayout();
            this.resultGroupBox.ResumeLayout(false);
            this.resultGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label radioLabel;
        private System.Windows.Forms.RadioButton circleButton;
        private System.Windows.Forms.RadioButton squareButton;
        private System.Windows.Forms.RadioButton rectangleButton;
        private System.Windows.Forms.TextBox radiusBox;
        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.GroupBox lengthGroupBox;
        private System.Windows.Forms.TextBox areaBox;
        private System.Windows.Forms.Label sideLabel2;
        private System.Windows.Forms.Label sideLabel1;
        private System.Windows.Forms.Label sideLabel3;
        private System.Windows.Forms.TextBox perimeterBox;
        private System.Windows.Forms.RadioButton triangleButton;
        private System.Windows.Forms.TextBox sideBox1;
        private System.Windows.Forms.TextBox sideBox2;
        private System.Windows.Forms.TextBox sideBox3;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox triangleTypeBox;
        private System.Windows.Forms.Label triangleTypeLabel;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.Label perimeterLabel;
        private System.Windows.Forms.GroupBox resultGroupBox;
    }
}

