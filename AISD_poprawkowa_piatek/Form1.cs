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

            long wynik = fib2(liczban);

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

        long fib2(long n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            long[] wyrazy = new long[n + 1];

            wyrazy[0] = 0;
            wyrazy[1] = 1;

            for(int i=2; i<wyrazy.Length; i++)
            {
                wyrazy[i] = wyrazy[i - 1] + wyrazy[i - 2];
            }

            return wyrazy[n];

        }



        private void nudliczban_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnsort_Click(object sender, EventArgs e)
        {
            int[] tablica = {3, 2, 1, 4, 5};

            sortowanieB(tablica);

            MessageBox.Show(tablica.ToString());
        }

        void sortowanieB(int[] tab)
        {
            int tmp;

            for (int i = 0; i < tab.Length - 1; i++)
            {
                if (tab[i] > tab[i + 1])
                {
                    tmp = tab[i];
                    tab[i] = tab[i + 1];
                    tab[i + 1] = tmp;
                }
            }
        }
    }
}