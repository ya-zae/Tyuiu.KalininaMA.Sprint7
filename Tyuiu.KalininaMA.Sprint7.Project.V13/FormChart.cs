using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.KalininaMA.Sprint7.Project.V13.Lib;

namespace Tyuiu.KalininaMA.Sprint7.Project.V13
{
    public partial class FormChart : Form
    {
        DataService ds = new DataService();
        public FormChart()
        {
            InitializeComponent();
            chartStats_KMA.Legends.Clear();
        }

        public static string path = @"C:\Project_KMA\Main_KMA.csv";


        private void buttonStats_KMA_Click(object sender, EventArgs e)
        {
            try
            {
                string[,] DataTable = ds.GetMatrix(path);
                double AverageArea = ds.Average(DataTable, 3);
                double AveragePopulation = ds.Average(DataTable, 5);

                // Показываем средние значения в MessageBox
                MessageBox.Show(
                    $"📊 СТАТИСТИКА СТРАН:\n\n" +
                    $"📏 Средняя площадь: {AverageArea:F1} км²\n" +
                    $"👥 Среднее население: {AveragePopulation:F0} чел.",
                    "Общая статистика",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при построении статистики: {ex.Message}",
                               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOk_KMA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDevelop_KMA_Click(object sender, EventArgs e)
        {

            chartStats_KMA.Series[0].Points.Clear();

            this.chartStats_KMA.ChartAreas[0].AxisX.Title = "Является ли страна развитой";
            this.chartStats_KMA.ChartAreas[0].AxisY.Title = "Количество стран";

            string[,] DataTable = ds.GetMatrix(path);

            string[] ArrayWords = ds.ArrayStrWordsElements(DataTable, 4);

            int[] ArraySumWords = ds.ArraySumWords(DataTable, ArrayWords, 4);

            for (int i = 0; i < ArrayWords.Length; i++)
            {
                chartStats_KMA.Series[0].Points.AddXY(ArrayWords[i], ArraySumWords[i]);
            }

            // Добавляем подпись с общим количеством
            chartStats_KMA.Titles.Clear();
            chartStats_KMA.Titles.Add($"Всего стран: {DataTable.GetLength(0) - 1}");
        }

        private void buttonDevelopNot_KMA_Click(object sender, EventArgs e)
        {
            chartStats_KMA.Series[0].Points.Clear();
            chartStats_KMA.Series[0].Name = "";

            this.chartStats_KMA.ChartAreas[0].AxisX.Title = "Является ли страна развитой";
            this.chartStats_KMA.ChartAreas[0].AxisY.Title = "Количество стран";

            string[,] DataTable = ds.GetMatrix(path);

            // Считаем вручную
            int nonDevelopedCount = 0;
            for (int i = 1; i < DataTable.GetLength(0); i++)
            {
                if (DataTable[i, 4].ToLower() == "нет")
                {
                    nonDevelopedCount++;
                }
            }

            // Добавляем столбец
            chartStats_KMA.Series[0].Points.AddXY("Нет", nonDevelopedCount);


        }
    }
}
