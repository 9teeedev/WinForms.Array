namespace WinForms.Array
{
    public partial class txtAvg : Form
    {
        public txtAvg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] data = textBox1.Lines;
                int[] number = new int[data.Length];
                for (int i = 0; i < data.Length; i++)
                {
                    if (int.TryParse(data[i], out int value))
                    {
                        number[i] = value;
                    }
                    else
                    {
                        number[i] = 0; // Default to 0 if กรณีแปลงไม่สำเร็จ
                    }
                }
                int sum = 0;
                int max = number[0];
                int min = number[0];
                for (int i = 0; i < number.Length; i++)
                {
                    sum += number[i];
                    if (number[i] > max)
                    {
                        max = number[i];
                    }
                    if (number[i] < min)
                    {
                        min = number[i];
                    }
                }
                double avg = (double)sum / number.Length;

                txtLength.Text = number.Length.ToString();
                txtSum.Text = sum.ToString();
                txtAverrage.Text = avg.ToString("F2");
                txtMax.Text = max.ToString();
                txtMin.Text = min.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[,] data = new string[5, 3] 
            { 
                { "USA", "Alice", "Wick"},
                { "Japan", "Bob", "Smith"},
                { "UK", "Charlie", "Johnson"},
                { "Brazil", "Diana", "Brown"},
                { "Canada", "Ethan", "Davis"}
            };
            int rows = data.GetLength(0); // จำนวนแถว
            int cols = data.GetLength(1); // จำนวนคอลัมน์
            string result = "";
            for (int i = 0; i < rows; i++)
            {
                result += "ข้อมูลแถวที่ " + (i + 1) + " : ";
                result += "ชื่อจริง : " + data[i, 1] + ", ";
                result += "นามสกุล : " + data[i, 2] + ", ";
                result += "ประเทศ : " + data[i, 0] + Environment.NewLine;
            }
            textBox2.Text = result;
        }
    }
}
