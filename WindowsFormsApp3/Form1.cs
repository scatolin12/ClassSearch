using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Diagnostics;
using sapfewse;

namespace WindowsFormsApp3
{
    public partial class ClassSearch : Form
    {
        public ClassSearch()
        {
            InitializeComponent();
        }

        private void btn_carregarclasse_Click(object sender, EventArgs e)
        {

            lbl_status.Text = "Loading Class...";

            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();

            StreamReader sr = new StreamReader(@"Q:\APPS\_NONSTD\WMO_SDP\DIMC\Classes.txt");

            Boolean classeExiste = false;
            string nome = tb_classe.Text.ToUpper();

            while (!sr.EndOfStream)
            {
                var texto = sr.ReadLine();

                if (texto.Contains(nome))
                {
                    classeExiste = true;
                }

            }

            if (classeExiste == false || tb_classe.Text=="")
            {
                MessageBox.Show("Classe não encontrada");
                return;
            }

            #region Check is Excel is installed in the PC on which program is executed

            _Application excel = new _Excel.Application();
            if (excel == null)
            {

                string errorMessage = "EXCEL could not be started." + "\n" +
                    "This program is able to form reports only on PC with installed Excel. " + "\n" +
                    "Check that your office installation is correct.";
                MessageBox.Show(errorMessage);

            }

            #endregion

            excel.Visible = false;

            string fileName = "Busca DE-PARA.xlsm";
            string pathToExcelXlsmFile = Path.Combine("Q:/APPS/_NONSTD/WMO_SDP/DIMC", fileName);

            Workbook wb;
            Worksheet ws;
            wb = excel.Workbooks.Open(pathToExcelXlsmFile);
            ws = wb.Sheets["Material Modelo"];

            bool mesmaclasse = ws.Cells[1, 2].Value == tb_classe.Text.ToUpper();

            

                if (mesmaclasse)
                    //Call VBA code
                    excel.GetType().InvokeMember("Run", System.Reflection.BindingFlags.Default | System.Reflection.BindingFlags.InvokeMethod, null, excel, new Object[] { "atualizardados" });

                else
                {
                    excel.GetType().InvokeMember("Run", System.Reflection.BindingFlags.Default | System.Reflection.BindingFlags.InvokeMethod, null, excel, new Object[] { "BaixarMateriaisClasse", tb_classe.Text });
                }

                ws.Cells[1, 2].Value = tb_classe.Text.ToUpper();
            
            if (ws.Cells[1,4].value == "ERRO AO CONECTAR SAP")
            {
                excel.DisplayAlerts = false;
                //wb.Save();
                wb.Close();
                excel.Quit();
                MessageBox.Show("ERROR: make sure you have an open SAP instance");
                lbl_status.Text = "Open a SAP instance";
                return;
            }
               
            

            ////Call VBA code
            //excel.GetType().InvokeMember("Run", System.Reflection.BindingFlags.Default | System.Reflection.BindingFlags.InvokeMethod, null, excel, new Object[] { "BaixarMateriaisClasse", tb_classe.Text });


            int Rcount = 0;

            _Excel.Range Range = (_Excel.Range)ws.Columns[1];
            Rcount = Range.CurrentRegion.Rows.Count - 3;

            for (int i = 0; i < Rcount; i++)
            {
                dataGridView1.Rows.Add(ws.Cells[i + 4, 1].Value);
            }

            #region Close excel object - release memory from this application

            excel.DisplayAlerts = false;
            wb.Save();
            wb.Close(true);
            excel.Quit();
            System.Runtime.InteropServices.Marshal.FinalReleaseComObject(excel);

            lbl_status.Text = "Done";

            #endregion
        }


        /////////////////////////////////
        ////////////////////////////////
        /// BUSCAR



        private void button1_Click(object sender, EventArgs e)
        {

            lbl_status.Text = "Searching for equivalent materials...";

            _Application excel = new _Excel.Application();

            int dtcount1 = dataGridView1.Rows.Count;
            int dtcount2 = dataGridView2.Rows.Count;

            if (dtcount1 <= 1)
            {
                MessageBox.Show("Classe dos materiais não carregada!");
                return;
            }

            int cont = 0;
            for (int i = 0; i < dtcount1; i++)
            {

                if (dataGridView1.Rows[i].Cells[1].Value != null || dataGridView1.Rows[i].Cells[2].Value != null)
                    cont = cont + 1;
            }

            if (cont == 0)
            {
                MessageBox.Show("Não há valores diferenciando os materiais!");
                return;
            }

            if (dtcount2 <= 1)
            {
                return;
            }

            excel.Visible = false;

            string fileName = "Busca DE-PARA.xlsm";
            string pathToExcelXlsmFile = Path.Combine("Q:/APPS/_NONSTD/WMO_SDP/DIMC", fileName);

            Workbook wb; 
            Worksheet ws;

            wb = excel.Workbooks.Open(pathToExcelXlsmFile);

            ws = wb.Sheets["Material Modelo"];

            bool mesmaclasse = ws.Cells[1, 2].Value == tb_classe.Text.ToUpper();


            if (mesmaclasse)
                //Call VBA code
                excel.GetType().InvokeMember("Run", System.Reflection.BindingFlags.Default | System.Reflection.BindingFlags.InvokeMethod, null, excel, new Object[] { "atualizardados" });

            else
            {
                MessageBox.Show("Carregue novamente a classe");
            }


            for (int i = 0; i < dtcount2; i++)
            {
                dataGridView2.Rows[i].Cells[1].Value = null;
            }


            for (int i = 0; i < dtcount1; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value != null)
                    ws.Cells[i + 4, 2].Value = dataGridView1.Rows[i].Cells[1].Value;
                if (dataGridView1.Rows[i].Cells[2].Value != null)
                {
                    ws.Cells[i + 4, 3].Value = "X";
                }
            }
           
                for (int i = 0; i < dtcount2; i++)
                {
                    ws.Cells[i + 4, 5].Value = dataGridView2.Rows[i].Cells[0].Value;
                }
                //Call VBA code
                excel.GetType().InvokeMember("Run", System.Reflection.BindingFlags.Default | System.Reflection.BindingFlags.InvokeMethod, null, excel, new Object[] { "Buscar" });

         

            if (ws.Cells[1, 4].value == "ERRO AO CONECTAR SAP")
            {
                excel.DisplayAlerts = false;
                //wb.Save();
                wb.Close();
                excel.Quit();
                MessageBox.Show("ERROR: make sure you have an open SAP instance");
                return;
            }

            for (int i = 0; i < dtcount2; i++)
            {
                dataGridView2.Rows[i].Cells[1].Value = ws.Cells[i + 4, 6].Value;
            }

            excel.DisplayAlerts = false;
            wb.Save();
            wb.Close(true);


            excel.Quit();
            #region Close excel object - release memory from this application


            System.Runtime.InteropServices.Marshal.FinalReleaseComObject(excel);

            lbl_status.Text = "Done";

            #endregion
        }



        // copiar colar
        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Shift && e.KeyCode == Keys.Insert) || (e.Control && e.KeyCode == Keys.V))

            {

                char[] rowSplitter = { '\r', '\n' };

                char[] columnSplitter = { '\t' };

                //get the text from clipboard

                IDataObject dataInClipboard = Clipboard.GetDataObject();

                string stringInClipboard = (string)dataInClipboard.GetData(DataFormats.Text);

                //split it into lines

                string[] rowsInClipboard = stringInClipboard.Split(rowSplitter, StringSplitOptions.RemoveEmptyEntries);

                //get the row and column of selected cell in grid

                int r = dataGridView2.SelectedCells[0].RowIndex;

                int c = dataGridView2.SelectedCells[0].ColumnIndex;

                //add rows into grid to fit clipboard lines

                if (dataGridView2.Rows.Count < (r + rowsInClipboard.Length))

                {

                    dataGridView2.Rows.Add(r + rowsInClipboard.Length - dataGridView2.Rows.Count + 1);

                }

                //loop through the lines, split them into cells and place the values in the corresponding cell.

                for (int iRow = 0; iRow < rowsInClipboard.Length; iRow++)

                {

                    //split row into cell values

                    string[] valuesInRow = rowsInClipboard[iRow].Split(columnSplitter);

                    //cycle through cell values

                    for (int iCol = 0; iCol < valuesInRow.Length; iCol++)

                    {

                        //assign cell value, only if it within columns of the grid

                        if (dataGridView2.ColumnCount - 1 >= c + iCol)

                        {

                            dataGridView2.Rows[r + iRow].Cells[c + iCol].Value = valuesInRow[iCol];

                        }

                    }

                }
                //label5.Text = (dataGridView2.Rows.Count - 1).ToString() + " " + "linhas";

                //if (dataGridView2.Rows.Count < 40)
                //{
                //    label6.Text = "Tempo Aprox. = " + ((dataGridView2.Rows.Count - 1) * 1.5).ToString() + " " + "segundos";
                //}
                //else
                //{
                //    label6.Text = "Tempo Aprox. = " + ((dataGridView2.Rows.Count - 1) * 0.025).ToString() + " " + "minutos";
                //}

            }
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For help ou sugestions, contact scatolin@weg.net  \n\n Developed by: Alexandre Scatolin Tem-Pass \n Product Engineer - WMO");
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            tb_classe.Text = null;
            lbl_status.Text = "";
        }
    }
}
