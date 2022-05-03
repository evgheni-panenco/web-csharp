using Lab1.Dialog;
using Lab1.Model;
using Lab1.Service;
using Lab1.Sorter;
using System.Linq;
using System.Text;

namespace Lab1
{
    public partial class MainDialog : Form
    {

        private List<Book> books = new List<Book>();

        public MainDialog()
        {
            InitializeComponent();

            comboBox1.DataSource = new List<string>() { "Integer", "Name", "Book" };
            comboBox2.DataSource = new List<string>() { "BubbleSort", "InsertionSort", "SelectionSort" };
            comboBox3.DataSource = new List<string>() { "Title", "Pages" };

            input.Visible = false;
            label7.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedType = comboBox1.Text;
            SortDirection sortDirection = radioButton1.Checked
                ? SortDirection.ASC : SortDirection.DESC;

            switch (selectedType)
            {
                case "Integer":
                    {
                        var data = radioButton4.Checked ? getIntsFromKeyboard() : intAutoGenerationData();
                        var sortedData = Sort<int>(data, sortDirection);
                        showResult<int>(sortedData);
                        break;
                    }
                case "Name":
                    {
                        var data = radioButton4.Checked ? getNamesFromKeyboard() : nameAutoGenerationData();
                        var sortedData = Sort<string>(data, sortDirection);
                        showResult<string>(sortedData);
                        break;
                    }
                case "Book":
                    {
                        var data = radioButton4.Checked ? books.ToArray() : bookAutoGenerationData();
                        var sortedData = Sort<Book>(data, sortDirection);
                        showResult<Book>(sortedData);
                        break;
                    }
            }
        }

        private int[] getIntsFromKeyboard()
        {
            string[] valuse = input.Text.Split(",");
            int[] ints = new int[valuse.Length];
            for (int i = 0; i < valuse.Length; i++)
            {
                ints[i] = Convert.ToInt32(valuse[i]);   
            }
            return ints;
        }

        private string[] getNamesFromKeyboard()
        {
            return input.Text.Split(",");
        }

        private T[] Sort<T>(T[] arr, SortDirection direction = SortDirection.ASC) where T : IComparable<T>
        {
            string sortType = comboBox2.Text;  
            
            if (checkForCustomBounaries())
            {
                arr = arr.Skip((int) lowBound.Value)
                    .Take((int)(highBound.Value - lowBound.Value))
                    .ToArray();
            }

            switch(sortType)
            {
                case "BubbleSort":
                    return GenericSorter<T>.BubbleSort(arr, direction);
                case "InsertionSort":
                    return GenericSorter<T>.InsertionSort(arr, direction);
                case "SelectionSort":
                    return GenericSorter<T>.SelectionSort(arr, direction);
            }

            return arr;
        }

        private bool checkForCustomBounaries()
        {
            if (useCustomBoundaries.Checked)
            {
                bool c1 = lowBound.Value < highBound.Value;
                bool c2 = lowBound.Value >= 0;
                bool c3 = highBound.Value <= (int)numericUpDown1.Value;

                return c1 && c2 && c3;
            }

            return false;
        }

        private void showResult<T>(T[] dataToShow)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (T value in dataToShow)
            {
                stringBuilder.Append(value.ToString() + "\n");
            }

            resultLabel.Text = stringBuilder.ToString();
        }

        private Book[] bookAutoGenerationData()
        {
            return new Book[]
            {
                new Book("Wars of war", 1200, CompareCriteria.PAGES_AMOUNT),
                new Book("Great Romance", 850, CompareCriteria.PAGES_AMOUNT),
                new Book("Amazing Novel", 1525, CompareCriteria.PAGES_AMOUNT),
                new Book("Wonderful Story", 748, CompareCriteria.PAGES_AMOUNT)
            };
        }

        private string[] nameAutoGenerationData()
        {
            int size = (int)numericUpDown1.Value;
            string[] namesPool = NamesDictionary.GetNames();
            string[] data = new string[size];
            Random randNum = new Random();
            for (int i = 0; i < size; i++)
            {
                data[i] = namesPool[randNum.Next(0, namesPool.Length)];
            }
            return data;
        }

        private int[] intAutoGenerationData()
        {
            int size = (int) numericUpDown1.Value;
            int[] data = new int[size];
            Random randNum = new Random();
            for (int i = 0; i < size; i++)
            {
                data[i] = randNum.Next(0, 99);
            }
            return data;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = !label4.Visible;
            label5.Visible = !label5.Visible;
            
            highBound.Visible = !highBound.Visible;
            lowBound.Visible = !lowBound.Visible;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            input.Visible = !input.Visible;
            label7.Visible = !label7.Visible;
            label8.Visible = !label8.Visible;
            label9.Visible = !label9.Visible;
            textBox1.Visible = !textBox1.Visible;
            numericUpDown2.Visible = !numericUpDown2.Visible;
            comboBox3.Visible = !comboBox3.Visible;
            button2.Visible = !button2.Visible;
            button3.Visible = !button3.Visible;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            books.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            books.Add(new Book(textBox1.Text, (int)numericUpDown2.Value, comboBox3.Text == "Title" 
                ? CompareCriteria.TITLE : CompareCriteria.PAGES_AMOUNT));
        }
    }
}