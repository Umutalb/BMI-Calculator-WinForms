using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                float height, weight;
                height = Convert.ToSingle(txtHeight.Text);
                weight = Convert.ToSingle(txtWeight.Text);
                lblOutput.Text = Calculate(height, weight).ToString("F2");
                lblOutput.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Incomplete or incorrect entry!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtHeight.Clear();
                txtWeight.Clear();
                txtHeight.Focus();
            }
        }

        private float Calculate(float height, float weight)
        {
            float result;
            result = weight / (height * height);

            if (result < 18.5)
            {
                lblStatus.Text = "Underweight";
                lblStatus.ForeColor = Color.Orange;

            }
            else if (result >= 18.5 && result < 25)
            {
                lblStatus.Text = "Normal Weight";
                lblStatus.ForeColor = Color.Green;

            }
            else if (result >= 25 && result < 30)
            {
                lblStatus.Text = "Overweight";
                lblStatus.ForeColor = Color.DarkOrange;

            }
            else
            {
                lblStatus.Text = "Obese";
                lblStatus.ForeColor = Color.Red;

            }

            lblStatus.Visible = true;

            return result;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.F5)
            {
                btnReset.PerformClick();
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtHeight.Clear();
            txtWeight.Clear();
            lblOutput.Visible = false;
            lblStatus.Visible = false;
            txtHeight.Focus();
        }
    }
}
