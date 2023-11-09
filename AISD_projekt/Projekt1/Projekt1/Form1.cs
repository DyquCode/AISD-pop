using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projekt1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Maximum = 2000000;
            checkBox1.Checked = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Losuj";
            } else
            {
                checkBox1.Text = "Wprowadź";
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
  
        }

        private void text_box1_TextChanged(object sender, EventArgs e)
        {
            string napis = text_box1.Text;

            string inputText = text_box1.Text;

            string[] numberStrings = inputText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int[] manualArray = Array.ConvertAll(numberStrings, int.Parse);

            currentArray = manualArray;
        }

        private void btn_sb_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            if (sortingInProgress)
            {
                MessageBox.Show("Sortowanie jest już w trakcie. Poczekaj na zakończenie.");
                return;
            }

            sortingInProgress = true;

            if (currentArray != null)
            {
                currentArray = BubbleSort(currentArray);
                label1.Text = "Bubble Sort";
                label2.Text = string.Join(" ", currentArray);
            }
            else
            {
                MessageBox.Show("Wprowadź tablicę liczb przed próbą sortowania.");
            }

            sortingInProgress = false;
            stopwatch.Stop();

            TimeSpan elapsed = stopwatch.Elapsed;

            label_czas.Text = "Czas: " + elapsed.TotalMilliseconds.ToString() + " ms";
        }

        private void btn_ss_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            if (sortingInProgress)
            {
                MessageBox.Show("Sortowanie jest już w trakcie. Poczekaj na zakończenie.");
                return;
            }

            sortingInProgress = true;

            if (currentArray != null)
            {
                currentArray = SelectionSwap(currentArray);
                label1.Text = "Selection Swap";
                label2.Text = string.Join(" ", currentArray);
            }
            else
            {
                MessageBox.Show("Wprowadź tablicę liczb przed próbą sortowania.");
            }

            sortingInProgress = false;

            stopwatch.Stop();

            TimeSpan elapsed = stopwatch.Elapsed;

            label_czas.Text = "Czas: " + elapsed.TotalMilliseconds.ToString() + " ms";
        }

        private void btn_si_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            if (sortingInProgress)
            {
                MessageBox.Show("Sortowanie jest już w trakcie. Poczekaj na zakończenie.");
                return;
            }

            sortingInProgress = true;

            if (currentArray != null)
            {
                currentArray = InsertionSort(currentArray);
                label1.Text = "Insertion Sort";
                label2.Text = string.Join(" ", currentArray);
            }
            else
            {
                MessageBox.Show("Wprowadź tablicę liczb przed próbą sortowania.");
            }

            sortingInProgress = false;

            stopwatch.Stop();

            TimeSpan elapsed = stopwatch.Elapsed;

            label_czas.Text = "Czas: " + elapsed.TotalMilliseconds.ToString() + " ms";
        }

        private void btn_sm_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            if (sortingInProgress)
            {
                MessageBox.Show("Sortowanie jest już w trakcie. Poczekaj na zakończenie.");
                return;
            }

            sortingInProgress = true;

            if (currentArray != null)
            {
                currentArray = MergeSort(currentArray);
                label1.Text = "Merge Sort";
                label2.Text = string.Join(" ", currentArray);
            }
            else
            {
                MessageBox.Show("Wprowadź tablicę liczb przed próbą sortowania.");
            }

            sortingInProgress = false;

            stopwatch.Stop();

            TimeSpan elapsed = stopwatch.Elapsed;

            label_czas.Text = "Czas: " + elapsed.TotalMilliseconds.ToString() + " ms";
        }

        private void btn_sq_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            if (sortingInProgress)
            {
                MessageBox.Show("Sortowanie jest już w trakcie. Poczekaj na zakończenie.");
                return;
            }

            sortingInProgress = true;

            if (currentArray != null)
            {
                currentArray = QuickSort(currentArray);
                label1.Text = "Quick Sort";
                label2.Text = string.Join(" ", currentArray);
            }
            else
            {
                MessageBox.Show("Wprowadź tablicę liczb przed próbą sortowania.");
            }

            sortingInProgress = false;

            stopwatch.Stop();

            TimeSpan elapsed = stopwatch.Elapsed;

            label_czas.Text = "Czas: " + elapsed.TotalMilliseconds.ToString() + " ms";
        }

        private void btn_generuj_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                int arraySize = (int)numericUpDown1.Value;
                int[] randomArray = GenerateRandomArray(arraySize);
                currentArray = randomArray;
                text_box1.Text = string.Join(" ", randomArray);
            }
        }

        private bool sortingInProgress = false;
        private int[] currentArray;
        private Stopwatch stopwatch = new Stopwatch();

        private int[] GenerateRandomArray(int size)
        {
            Random random = new Random();
            int[] randomArray = new int[size];

            for (int i = 0; i < size; i++)
            {
                randomArray[i] = random.Next(1, 100);
            }

            return randomArray;
        }

        int[] BubbleSort(int[] tab)
        {
            bool zmiana;
            int temp;
            do
            {
                zmiana = false;
                for (int i = 0; i < tab.Length - 1; i++)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        temp = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = temp;
                        zmiana = true;
                    }
                }
            } while (zmiana);
            return tab;
        }

        int[] SelectionSwap(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < tab.Length; j++)
                {
                    if (tab[j] < tab[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = tab[i];
                tab[i] = tab[minIndex];
                tab[minIndex] = temp;
            }
            return tab;
        }

        int[] InsertionSort(int[] tab)
        {
            for (int i = 1; i < tab.Length; i++)
            {
                int currentElement = tab[i];
                int j = i - 1;

                while (j >= 0 && tab[j] > currentElement)
                {
                    tab[j + 1] = tab[j];
                    j--;
                }

                tab[j + 1] = currentElement;
            }

            return tab;
        }

        int[] MergeSort(int[] tab)
        {
            if (tab.Length <= 1)
            {
                return tab;
            }

            int middle = tab.Length / 2;
            int[] left = new int[middle];
            int[] right = new int[tab.Length - middle];

            for (int i = 0; i < middle; i++)
            {
                left[i] = tab[i];
            }

            for (int i = middle; i < tab.Length; i++)
            {
                right[i - middle] = tab[i];
            }

            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);
        }

        int[] Merge(int[] left, int[] right)
        {
            int leftLength = left.Length;
            int rightLength = right.Length;
            int[] result = new int[leftLength + rightLength];

            int i = 0, j = 0, k = 0;

            while (i < leftLength && j < rightLength)
            {
                if (left[i] <= right[j])
                {
                    result[k++] = left[i++];
                }
                else
                {
                    result[k++] = right[j++];
                }
            }

            while (i < leftLength)
            {
                result[k++] = left[i++];
            }

            while (j < rightLength)
            {
                result[k++] = right[j++];
            }

            return result;
        }

        int[] QuickSort(int[] tab)
        {
            if (tab.Length <= 1)
            {
                return tab;
            }

            int pivotIndex = tab.Length / 2;
            int pivot = tab[pivotIndex];

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            for (int i = 0; i < tab.Length; i++)
            {
                if (i == pivotIndex)
                {
                    continue;
                }
                if (tab[i] <= pivot)
                {
                    left.Add(tab[i]);
                }
                else
                {
                    right.Add(tab[i]);
                }
            }

            List<int> sortedList = new List<int>();
            sortedList.AddRange(QuickSort(left.ToArray()));
            sortedList.Add(pivot);
            sortedList.AddRange(QuickSort(right.ToArray()));

            return sortedList.ToArray();
        }
    }
}
