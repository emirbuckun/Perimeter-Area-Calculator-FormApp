using System;
using System.Windows.Forms;

namespace Perimeter_AreaCalculatorFormApp
{
    public partial class PerimeterAreaCalculatorForm : Form
    {
        public PerimeterAreaCalculatorForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radiusBox.Show();
            sideLabel1.Hide();
            sideBox1.Hide();
            sideLabel2.Hide();
            sideBox2.Hide();
            sideLabel3.Hide();
            sideBox3.Hide();
            resultGroupBox.Hide();
        }

        #region radioButton Methods

        private void circleButton_CheckedChanged(object sender, EventArgs e)
        {
            if (circleButton.Checked) // Circle selected, show radiusBox
            {
                radiusLabel.Show();
                radiusBox.Show();
                sideLabel1.Hide();
                sideBox1.Hide();
                sideLabel2.Hide();
                sideBox2.Hide();
                sideLabel3.Hide();
                sideBox3.Hide();
            }
        }

        private void squareButton_CheckedChanged(object sender, EventArgs e)
        {
            if (squareButton.Checked) // Square selected, show side1
            {
                radiusLabel.Hide();
                radiusBox.Hide();
                sideLabel1.Show();
                sideBox1.Show();
                sideLabel2.Hide();
                sideBox2.Hide();
                sideLabel3.Hide();
                sideBox3.Hide();
            }
        }

        private void rectangleButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rectangleButton.Checked) // Rectangle selected, show side1 and side2
            {
                radiusLabel.Hide();
                radiusBox.Hide();
                sideLabel1.Show();
                sideBox1.Show();
                sideLabel2.Show();
                sideBox2.Show();
                sideLabel3.Hide();
                sideBox3.Hide();
            }
        }

        private void triangleButton_CheckedChanged(object sender, EventArgs e)
        {
            if (triangleButton.Checked) // Triangle selected, show all sides
            {
                radiusLabel.Hide();
                radiusBox.Hide();
                sideLabel1.Show();
                sideBox1.Show();
                sideLabel2.Show();
                sideBox2.Show();
                sideLabel3.Show();
                sideBox3.Show();
            }
        }

        #endregion

        // Check input valid or not
        #region textBox Methods

        private void radiusBox_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(radiusBox.Text, @"^[0-9]*(?:\,[0-9]*)?$"))
            {
                MessageBox.Show("Please enter a number.");
                radiusBox.Clear();
            }
        }

        private void sideBox1_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(sideBox1.Text, @"^[0-9]*(?:\,[0-9]*)?$"))
            {
                MessageBox.Show("Please enter a number.");
                sideBox1.Clear();
            }
        }

        private void sideBox2_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(sideBox2.Text, @"^[0-9]*(?:\,[0-9]*)?$"))
            {
                MessageBox.Show("Please enter a number.");
                sideBox2.Clear();
            }
        }

        private void sideBox3_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(sideBox3.Text, @"^[0-9]*(?:\,[0-9]*)?$"))
            {
                MessageBox.Show("Please enter a number.");
                sideBox3.Clear();
            }
        }

        #endregion

        // Calculates the perimeter and area
        private void calculateButton_Click(object sender, EventArgs e)
        {
            double perimeter = 0;
            double area = 0;

            if (circleButton.Checked && radiusBox.TextLength > 0) // Calculation for circle
            {
                if (double.TryParse(radiusBox.Text, out double radius) && radius > 0)
                {
                    perimeter = 2 * Math.PI * radius;
                    area = Math.PI * radius * radius;

                    perimeterBox.Text = perimeter.ToString();
                    areaBox.Text = area.ToString();

                    triangleTypeLabel.Hide();
                    triangleTypeBox.Hide();
                    resultGroupBox.Show();
                }
                else
                    MessageBox.Show("Please enter a valid radius length!");
            }
            else if (squareButton.Checked && sideBox1.TextLength > 0) // Calculation for square
            {
                if (double.TryParse(sideBox1.Text, out double side) && side > 0)
                {
                    perimeter = 4 * side;
                    area = side * side;

                    perimeterBox.Text = perimeter.ToString();
                    areaBox.Text = area.ToString();

                    triangleTypeLabel.Hide();
                    triangleTypeBox.Hide();
                    resultGroupBox.Show();
                }
                else
                    MessageBox.Show("Please enter a valid side length!");
            }
            else if (rectangleButton.Checked && sideBox1.TextLength > 0 &&
                sideBox2.TextLength > 0) // Calculation for rectangle
            {
                if (double.TryParse(sideBox1.Text, out double side1) && side1 > 0 &&
                    double.TryParse(sideBox2.Text, out double side2) && side2 > 0 && side1 != side2)
                {
                    perimeter = 2 * (side1 + side2);
                    area = side1 * side2;

                    perimeterBox.Text = perimeter.ToString();
                    areaBox.Text = area.ToString();

                    triangleTypeLabel.Hide();
                    triangleTypeBox.Hide();
                    resultGroupBox.Show();
                }
                else
                    MessageBox.Show("Please enter valid side lengthes!");
            }
            else if (triangleButton.Checked && sideBox1.TextLength > 0 &&
                sideBox2.TextLength > 0 && sideBox3.TextLength > 0) // Calculation for triangle
            {

                if (double.TryParse(sideBox1.Text, out double side1) && side1 > 0 &&
                    double.TryParse(sideBox2.Text, out double side2) && side2 > 0 &&
                    double.TryParse(sideBox3.Text, out double side3) && side3 > 0)
                {
                    perimeter = side1 + side2 + side3;
                    double u = perimeter / 2;
                    area = Math.Sqrt(u * (u - side1) * 
                        (u - side2) * (u - side3));

                    perimeterBox.Text = perimeter.ToString();
                    areaBox.Text = area.ToString();

                    // Determine the triangle type
                    String triangleType = "";
                    if (side1 + side2 <= side3 || side1 + side3 <= side2 ||
                            side2 + side3 <= side1)
                    {
                        triangleType = "Triangle Doesn't Form";
                        perimeterLabel.Hide();
                        perimeterBox.Hide();
                        areaLabel.Hide();
                        areaBox.Hide();
                    }
                    else if (side1 == side2 && side2 == side3) // Equilateral Triangle
                        triangleType = "Equilateral Triangle";
                    else if (side1 == side2 || side1 == side3 || side2 == side3)
                        triangleType = "Isosceles Triangle";
                    else
                        triangleType = "Scalene Triangle";

                    if (triangleType != "Triangle Doesn't Form")
                    {
                        perimeterLabel.Show();
                        perimeterBox.Show();
                        areaLabel.Show();
                        areaBox.Show();
                    }

                    triangleTypeBox.Text = triangleType;
                    triangleTypeLabel.Show();
                    triangleTypeBox.Show();
                    resultGroupBox.Show();
                }
                else
                    MessageBox.Show("Please enter valid side lengthes!");
            }
            else // Give a warning message if none of the required conditions are met
                MessageBox.Show("Please enter the appropriate lengths for the shape you choose!");
        }

    }
}
