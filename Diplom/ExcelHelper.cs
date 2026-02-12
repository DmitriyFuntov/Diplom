using Microsoft.Office.Interop.Excel;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;




namespace predDiplom
{
    internal class Excelhelper : IDisposable     
    {
       // Person person = null;
        private Excel.Application _excel;
        private Workbook _workbook;
        private string _filePath;
        private Range _cells;
        private Worksheets _sheets;
       
       
        public Excelhelper() 
        {
           _excel = new Excel.Application();
        }

        public void Dispose()
        {
            _workbook.Close();
        }

        internal bool Open(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    _workbook = _excel.Workbooks.Open(filePath);
                }
                else
                {
                    _workbook = _excel.Workbooks.Add();
                    _filePath = filePath;
                }

                return true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); } 
            return false;
        }

        internal void Save()
        {
           if(!string.IsNullOrEmpty(_filePath)) 
            {
                _workbook.SaveAs(_filePath);
                _filePath = null;
            }
           else
            {
                _workbook.Save();
            }
        }

        internal bool Set(int coloumn, int row, string dat)
        {
            try
            {
                ((Excel.Worksheet)_excel.ActiveSheet).Cells[row, coloumn].Value = dat;
            }
           catch (Exception ex) { MessageBox.Show(ex.Message); }
            return false;
        }

        internal void Show()
        {
           _excel.Visible = true;
        }

        internal void Read()
        {
            
            try
            {
                int totalrows = 0;
               
                int i = 2;
                _excel = new Excel.Application();
                Worksheet _worksheet;
                _worksheet = _workbook.Worksheets[1];
                while (_worksheet.Cells[i, 1].Value != null) //подсчет строк в таблице, столбцов по условию должно быть 2
                {
                    totalrows++;
                    i++;
                }
                Person[] people = new Person[totalrows]; // массив данных имя-возраст
                var Cells = _worksheet.Cells[1,2];

                for ( i =0; i < totalrows; i++) // чтение таблицы и заполнение массива данных имя-возраст
                {
                    people[i] = new Person(Convert.ToString(Cells[i + 2, 0].Value), Convert.ToDouble(Cells[i + 2, 1].Value));                  
                }

                Person[] Sortpeople = people.OrderBy(x => x).ToArray(); // сортровка по алфавиту
                

                if (Open(filePath: Path.Combine(Environment.CurrentDirectory, "Result.xlsx")))
                {
                    //Show();
                    Set(1, 1, "Имя"); Set(2, 1, "Возраст");

                    double Sum = 0;
                    for (i = 0; i < totalrows; i++) // выгрузка массива данных имя-возраст в таблицу
                    {
                        Set(1, i+2, Sortpeople[i].Name); Set(2, i+2, Convert.ToString(Sortpeople[i].Age));
                        Sum += Sortpeople[i].Age;
                    }
                    Set(2, totalrows + 2, "Средний Возраст");
                    int averege = Convert.ToInt32(Sum)/totalrows;
                    Set(2, totalrows + 3, Convert.ToString(averege));

                }
               
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
            
        }

    
    }
}
