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

using Tyuiu.KalininaMA.Sprint7.Project.V13.Lib;
namespace Tyuiu.KalininaMA.Sprint7.Project.V13
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
            dataGridViewResult_KMA.RowCount = 100;
            dataGridViewResult_KMA.ColumnCount = 100;
            for (int i = 0; i < 100; i++)
            {
                dataGridViewResult_KMA.Columns[i].Width = 150;
            }
        }

        DataService ds = new DataService();
        public static string path = @"C:\Project_KMA\Main_KMA.csv";

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void labelAddArea_KMA_Click(object sender, EventArgs e)
        {

        }

        private void buttonOpenFile_KMA_Click(object sender, EventArgs e)
        {



            openFileDialogMain_KMA.ShowDialog();
            string FileName = openFileDialogMain_KMA.FileName;


            string[,] DataMatrix = ds.GetMatrix(FileName);

            int rows = DataMatrix.GetLength(0);
            int columns = DataMatrix.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewResult_KMA.Rows[r].Cells[c].Value = DataMatrix[r, c];
                }
            }
            ToolStripMenuItemSortMax_KMA.Enabled = true;
            ToolStripMenuItemSortMin_KMA.Enabled = true;
            buttonSearch_KMA.Enabled = true;
            textBoxWhatSearch_KMA.Enabled = true;
            textBoxColumns_KMA.Enabled = true;
        }

        private void ReadFile_KMA()
        {
            throw new NotImplementedException();
        }

        private void buttonAccept_KMA_Click(object sender, EventArgs e)
        {
            if ((textBoxAddArea_KMA.Text == "") || (textBoxAddCapital_KMA.Text == "") || (textBoxAddCountry_KMA.Text == "") || (textBoxAddNational_KMA.Text == "") || (textBoxAddPopulation_KMA.Text == "") || ((radioButtonNo_KMA.Checked == false) && (radioButtonYes_KMA.Checked == false)))
                MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string str = "";

                string[,] DataTable = ds.GetMatrix(path);

                bool CountryBusy = ds.CountryExist(DataTable, textBoxAddCountry_KMA.Text);

                if (CountryBusy)
                    MessageBox.Show("Данная Страна уже есть в базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {

                    for (int i = 0; i < 7; i++)
                    {
                        if (radioButtonYes_KMA.Checked == true)
                            str = $"{DataTable.GetLength(0)};{textBoxAddCountry_KMA.Text};{textBoxAddCapital_KMA.Text};{textBoxAddArea_KMA.Text};да;{textBoxAddPopulation_KMA.Text};{textBoxAddNational_KMA.Text}";
                        else
                            str = $"{DataTable.GetLength(0)};{textBoxAddCountry_KMA.Text};{textBoxAddCapital_KMA.Text};{textBoxAddArea_KMA.Text};нет;{textBoxAddPopulation_KMA.Text};{textBoxAddNational_KMA.Text}";
                    }
                    File.AppendAllText(path, str + "\n");


                    textBoxAddArea_KMA.Text = "";
                    textBoxAddCapital_KMA.Text = "";
                    textBoxAddCountry_KMA.Text = "";
                    textBoxAddNational_KMA.Text = "";
                    textBoxAddPopulation_KMA.Text = "";
                    radioButtonNo_KMA.Checked = false;
                    radioButtonYes_KMA.Checked = false;

                    string[,] DataMatrix = ds.GetMatrix(path);

                    int rows = DataMatrix.GetLength(0);
                    int columns = DataMatrix.GetLength(1);

                    for (int r = 0; r <= rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            dataGridViewResult_KMA.Rows[r].Cells[c].Value = "";
                        }
                    }

                    for (int r = 0; r < rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            dataGridViewResult_KMA.Rows[r].Cells[c].Value = DataMatrix[r, c];
                        }
                    }


                    MessageBox.Show("Страна занесена в базу данных", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonChart_KMA_Click(object sender, EventArgs e)
        {
            FormChart formChart = new FormChart();
            formChart.Show();
        }

        private void buttonReturn_KMA_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);

            int rows = DataMatrix.GetLength(0);
            int columns = DataMatrix.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewResult_KMA.Rows[r].Cells[c].Value = DataMatrix[r, c];
                }
            }

            // 3. ОЧИСТКА ПОЛЕЙ ПОИСКА (добавьте этот код)
            textBoxWhatSearch_KMA.Text = "";
            textBoxColumns_KMA.Text = "";

            // 4. Деактивируем кнопку "Вернуться" (если нужно)
            buttonReturn_KMA.Enabled = false;

            // 5. Очистка поля результата поиска (если есть)
            // labelSearchResult_KMA.Text = "";

        }

        private void buttonHelp_KMA_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.Show();
        }

        private void buttonInfo_KMA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.Show();
        }

        private void buttonOpenFile_KMA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KMA.ToolTipTitle = "открыть файл";
        }

        private void buttonReturn_KMA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KMA.ToolTipTitle = "обновить";
        }

        private void buttonChart_KMA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KMA.ToolTipTitle = "перейти в статистику";
        }

        private void buttonHelp_KMA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KMA.ToolTipTitle = "руководство";
        }

        private void buttonInfo_KMA_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KMA.ToolTipTitle = "о разработчике";
        }

        private void buttonDelete_KMA_Click(object sender, EventArgs e)
        {
            if (textBoxDelete_KMA.Text == "")
            {
                MessageBox.Show("Поле пустое!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string[,] DataTable = ds.GetMatrix(path);
                bool CountryBusy = ds.CountryExist(DataTable, textBoxDelete_KMA.Text);

                if (CountryBusy == false)
                    MessageBox.Show("Такой страны нет в базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {

                    for (int i = 0; i < DataTable.GetLength(0); i++)
                    {
                        if (DataTable[i, 1] == textBoxDelete_KMA.Text)
                            for (int j = 0; j < DataTable.GetLength(1); j++)
                            {
                                DataTable[i, j] = "";
                            }
                    }
                    bool b = false;
                    string[,] NewDataTable = new string[DataTable.GetLength(0) - 1, DataTable.GetLength(1)];
                    for (int i = 0; i < NewDataTable.GetLength(0); i++)
                    {
                        for (int j = 0; j < NewDataTable.GetLength(1); j++)
                        {
                            if (DataTable[i, j] == "")
                            {
                                b = true;
                                NewDataTable[i, j] = DataTable[i + 1, j];
                            }
                            if (b)
                                NewDataTable[i, j] = DataTable[i + 1, j];
                            else
                                NewDataTable[i, j] = DataTable[i, j];
                        }
                    }
                    for (int i = 1; i < NewDataTable.GetLength(0); i++)
                    {
                        NewDataTable[i, 0] = Convert.ToString(i);
                    }
                    string[] strRows = new string[NewDataTable.GetLength(0)];
                    for (int i = 0; i < strRows.Length; i++)
                    {
                        for (int j = 0; j < NewDataTable.GetLength(1); j++)
                        {
                            if (j == NewDataTable.GetLength(1) - 1)
                                strRows[i] += NewDataTable[i, j];
                            else
                                strRows[i] += NewDataTable[i, j] + ";";

                        }
                    }


                    File.Delete("Main_KMA.csv");

                    saveFileDialogMain_KMA.FileName = "Main_KMA.csv";
                    saveFileDialogMain_KMA.ShowDialog();

                    path = saveFileDialogMain_KMA.FileName;

                    File.WriteAllLines(path, strRows, Encoding.UTF8);

                    string[,] DataMatrix = ds.GetMatrix(path);

                    int rows = DataMatrix.GetLength(0);
                    int columns = DataMatrix.GetLength(1);

                    for (int r = 0; r <= rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            dataGridViewResult_KMA.Rows[r].Cells[c].Value = "";
                        }
                    }

                    for (int r = 0; r < rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            dataGridViewResult_KMA.Rows[r].Cells[c].Value = DataMatrix[r, c];
                        }
                    }
                    MessageBox.Show("Страна удалена из базы", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            textBoxDelete_KMA.Text = "";
        }

        private void ToolStripMenuItemSortMax_KMA_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMax(DataMatrix, 3);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    dataGridViewResult_KMA.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
            buttonReturn_KMA.Enabled = true;
        }

        private void ToolStripMenuItemSortMin_KMA_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMin(DataMatrix, 3);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    dataGridViewResult_KMA.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
            buttonReturn_KMA.Enabled = true;



        }

        private void textBoxAddNational_KMA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_KMA_Click(object sender, EventArgs e)
        {
            // Проверка заполнения
            if (string.IsNullOrWhiteSpace(textBoxWhatSearch_KMA.Text) ||
                string.IsNullOrWhiteSpace(textBoxColumns_KMA.Text))
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка номера столбца
            if (!int.TryParse(textBoxColumns_KMA.Text, out int columnNumber))
            {
                MessageBox.Show("Номер столбца должен быть числом!", "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Загрузка данных
            string[,] DataMatrix = ds.GetMatrix(path);
            int totalColumns = DataMatrix.GetLength(1);

            // Проверка диапазона
            if (columnNumber < 1 || columnNumber > totalColumns)
            {
                MessageBox.Show($"Нет такого столбца! Допустимо: 1-{totalColumns}",
                               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxColumns_KMA.Clear();
                return;
            }

            // Поиск
            string[,] searchResults = ds.Search(DataMatrix,
                                               textBoxWhatSearch_KMA.Text,
                                               columnNumber - 1);

            // Проверка результатов
            if (searchResults == null || searchResults.GetLength(0) == 0)
            {
                MessageBox.Show("Не нашлось совпадений!", "Информация",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 1. Очистка таблицы (кроме заголовков)
            for (int r = 1; r < dataGridViewResult_KMA.Rows.Count; r++)
            {
                for (int c = 0; c < totalColumns; c++)
                {
                    dataGridViewResult_KMA.Rows[r].Cells[c].Value = "";
                }
            }

            // 2. Восстановление заголовков (первая строка)
            for (int i = 0; i < totalColumns; i++)
            {
                dataGridViewResult_KMA.Rows[0].Cells[i].Value = DataMatrix[0, i];
            }

            // 3. Вывод найденных строк
            for (int r = 0; r < searchResults.GetLength(0); r++)
            {
                for (int c = 0; c < searchResults.GetLength(1); c++)
                {
                    // +1 потому что первая строка занята заголовками
                    dataGridViewResult_KMA.Rows[r + 1].Cells[c].Value = searchResults[r, c];
                }
            }

            // 4. Активация кнопки возврата
            buttonReturn_KMA.Enabled = true;

        }

        private void textBoxWhatSearch_KMA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxColumns_KMA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
