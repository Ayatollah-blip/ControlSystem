namespace ControlSytem
{
    public partial class Form1 : Form
    {
        double Ts = 0.1;
        double xk = 0;
        double u = 1;
        public Form1()
        {
            InitializeComponent();
            Input.Text = u.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            u = Convert.ToDouble(Input.Text);
            xk = DiscreteModel(xk, u);
            Output.Text = xk.ToString();
        }
        double LinearModel(double x)
        {
            double a = 2;
            double b = 4;
            double y;

            y = a * x + b;

            return y;
        }
        double DiscreteModel(double xk, double u)
        {
            double a = 0.25;
            double b = 2;
            double xk1;

            xk1 = (1 - Ts * a) * xk + Ts * b * u;

            return xk1;
        }
    }
}