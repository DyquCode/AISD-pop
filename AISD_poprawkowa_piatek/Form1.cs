namespace AISD_poprawkowa_piatek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            int liczban = (int)nudliczban.Value;

            int wynik = fib(liczban);

            MessageBox.Show(wynik.ToString());
        }

        
        int fib(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            return fib(n - 1) + fib(n - 2);
        }

        private void nudliczban_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}