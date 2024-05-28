using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aircraftName = textBox1.Text;
            string departureTime = dateTimePicker1.Value.ToString();
            string departureTimeTime = comboBox3.Text;
            string departureFrom = comboBox1.Text;
            string arrivalTo = comboBox2.Text;
            string place = comboBox4.Text;
            string fullName = textBox2.Text;

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "Чек.txt");

            using (StreamWriter write = new StreamWriter(filePath))
            {
                write.WriteLine(string.Format("Название самолета: {0}", aircraftName));
                write.WriteLine(string.Format("Дата отправления: {0}", departureTime));
                write.WriteLine(string.Format("Время отправления: {0}", departureTimeTime));
                write.WriteLine(string.Format("Отправление из: {0}", departureFrom));
                write.WriteLine(string.Format("Прибытие в: {0}", arrivalTo));
                write.WriteLine(string.Format("Ваше место: {0}", place));
                write.WriteLine(string.Format("ФИО: {0}", fullName));
            }
            MessageBox.Show("Файл успешно создан на рабочем столе!");
        }
    }
}
