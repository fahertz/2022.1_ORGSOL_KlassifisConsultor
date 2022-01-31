using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace kLib
{
    public class Parametros_Excel
    {
        private string mMessage;
        private string mTittle;
        private MessageBoxIcon mIcon;
        private MessageBoxButtons mButton;


        //Abrir em excel
        //Copiar todos os dados do DataGridView        

        public void abrir_Grid_Excel(DataGridView dgv, string name_Archive, string name_Sheet)
        {
            CopyToClipboardWithHeaders(dgv);
            Excel.Application app;
            Excel.Workbook wkBook;
            Excel.Worksheet wkSheet;

            String range_Min = dgv.Columns[0].HeaderText;
            String range_Max = dgv.Columns[dgv.Columns.Count - 1].Name;


            object misValue = System.Reflection.Missing.Value;
            app = new Excel.Application();
            app.Visible = true;
            wkBook = app.Workbooks.Add(misValue);
            wkSheet = (Excel.Worksheet)wkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)wkSheet.Cells[1, 1];
            CR.Rows.AutoFit();
            CR.Select();

            wkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            wkSheet.Name = name_Sheet; //AdicionA ND o o nome a planilha
            foreach (Excel.Worksheet wrkst in wkBook.Worksheets)
            {
                Excel.Range usedrange = wrkst.UsedRange;
                usedrange.Columns.AutoFit();

            }

        }
        private void CopyToClipboardWithHeaders(DataGridView dgv)
        {
            //Copy to clipboard
            dgv.SelectAll();
            dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

            DataObject dataObj = dgv.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        //Exportar para XLS ou XLSX        
        public void exportar_ParaExcel(string _nomeArquivo, DataGridView _dgv)
        {
            SaveFileDialog salvar = new SaveFileDialog();
            Excel.Application App; // Aplicação Excel 
            Excel.Workbook WorkBook; // Pasta 
            Excel.Worksheet WorkSheet; // Planilha 
            object misValue = System.Reflection.Missing.Value;

            App = new Excel.Application();
            WorkBook = App.Workbooks.Add(misValue);
            WorkSheet = (Excel.Worksheet)WorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;

            for (int c = 1; c < _dgv.Columns.Count + 1; c++)
            {
                WorkSheet.Cells[1, c] = _dgv.Columns[c - 1].HeaderText;
            }

            // passa as celulas do DataGridView para a Pasta do Excel 
            for (i = 0; i <= _dgv.RowCount - 1; i++)
            {

                for (j = 0; j <= _dgv.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = _dgv[j, i];
                    WorkSheet.Cells[i + 2, j + 1] = cell.Value;
                }
            }

            // define algumas propriedades da caixa salvar 
            salvar.Title = _nomeArquivo;
            salvar.Filter = "Arquivo do Excel *.xls | *.xls |Arquivo do Excel *.xlsx | *.xlsx";
            salvar.FilterIndex = 2;
            salvar.ShowDialog(); // mostra 

            if (!salvar.FileName.Equals(String.Empty))
            {
                //Salvar como XLSX
                if (salvar.FilterIndex == 2)
                {
                    WorkBook.SaveAs(salvar.FileName, Excel.XlFileFormat.xlOpenXMLWorkbook, misValue, misValue, misValue, misValue,

                              Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

                    WorkBook.Close(true, misValue, misValue);
                    App.Quit(); // encerra o excel 
                }
                //Salvar como XLS
                else
                {
                    // salva o arquivo 
                    WorkBook.SaveAs(salvar.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,

                    Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

                    WorkBook.Close(true, misValue, misValue);
                    App.Quit(); // encerra o excel                     
                }
                mMessage = "Arquivo salvo com sucesso!";
                mTittle = "Klassifis Information";
                mIcon = MessageBoxIcon.Information;
                mButton = MessageBoxButtons.OK;
                MessageBox.Show(mMessage, mTittle, mButton, mIcon);
            }



        }

    }
}
