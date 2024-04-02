using System.Runtime.Serialization;
using System.Text.Json.Nodes;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing.Text;
using System.Diagnostics.Eventing.Reader;

namespace Exchange_API_Forms
{
    public partial class Form1 : Form
    {
        private HttpClient client;
        long unixTimestamp;
        ExchangeRate exchangeRate;
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
            _ = getApi();

        }

        private string selectedValue = "";
        private string deletedValue = "";
        private List<string> savedValues = new List<string>();

        private async Task getApi()
        {
            string call = "https://openexchangerates.org/api/latest.json?app_id=6799573090ce4862adfe6f9e89f1f54b";
            string response = await client.GetStringAsync(call);
            exchangeRate = JsonSerializer.Deserialize<ExchangeRate>(response);
            unixTimestamp = exchangeRate.timestamp;
            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(unixTimestamp);
            string officialDate = dateTimeOffset.ToString("yyyy-MM-dd");
            
            label4.Text = "Day: " + officialDate;

            foreach (var rate in exchangeRate.rates)
            {
                //listBoxResponse.Items.Add($"{rate.Key}: {rate.Value}");
                comboBox2.Items.Add($"{rate.Key}: {rate.Value}");

            }
            foreach (var rate in exchangeRate.rates)
            {
                //listBoxResponse.Items.Add($"{rate.Key}: {rate.Value}");
                comboBox3.Items.Add($"{rate.Key}");

            }
            foreach (var rate in exchangeRate.rates)
            {
                //listBoxResponse.Items.Add($"{rate.Key}: {rate.Value}");
                comboBox4.Items.Add($"{rate.Key}");

            }



        }



        private async void button_download_Click(object sender, EventArgs e)
        {

            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(unixTimestamp);
            string officialDate = dateTimeOffset.ToString("yyyy-MM-dd");
            // listBox1.Items.Add($"Date: {officialDate}");
            listBoxResponse.Items.Add($"Date: {officialDate}");
            foreach (var rate in exchangeRate.rates)
            {
                listBoxResponse.Items.Add($"{rate.Key}: {rate.Value}");
                //comboBox1.Items.Add($"{rate.Key}: {rate.Value}");

            }

        }

        private void listBoxResponse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {


        }

        private void button6_Click(object sender, EventArgs e)
        {



        }

        private void button5_Click(object sender, EventArgs e)
        {

            listBox2.Items.Clear();
            foreach (string value in savedValues)
            {
                listBox2.Items.Add(value);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                selectedValue = comboBox2.SelectedItem.ToString();
                if (savedValues.Contains(selectedValue))
                {
                    MessageBox.Show("Wybrany element juz znajduje w siê w porównywarce.", "UWAGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    savedValues.Add(selectedValue);
                }
            }
            else { MessageBox.Show("Wybierz element z listy.", "UWAGA", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }

        private void button4_Click_1(object sender, EventArgs e)
        {


            if (comboBox2.SelectedItem != null)
            {
                deletedValue = comboBox2.SelectedItem.ToString();
                if (!savedValues.Contains(deletedValue))
                {
                    MessageBox.Show("Wybranego elementu nie mo¿na usun¹c, poniewa¿ nie ma w porównywarce.", "UWAGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    savedValues.Remove(deletedValue);
                }

            }
            else { MessageBox.Show("Wybierz element z listy.", "UWAGA", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {


            if (comboBox3.SelectedItem != null && comboBox4.SelectedItem != null)
            {
                var item1 = comboBox3.SelectedItem.ToString();
                var item2 = comboBox4.SelectedItem.ToString();

                decimal calculateValue = exchangeRate.rates[item1] / exchangeRate.rates[item2];
                decimal amount;
                decimal.TryParse(textBox1.Text, out amount);

                calculateValue *= amount;
                calculateValue = Math.Round(calculateValue, 2);

                textBox2.Text = calculateValue.ToString();
            }
            else
            {
                MessageBox.Show("Uzupe³nij wszystkie wartoœci.", "UWAGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}


        
    

