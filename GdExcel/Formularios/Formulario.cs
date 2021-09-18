using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GdExcel
{
    public partial class Formulario : Form
    {

        public Formulario()
        {
            InitializeComponent();
        }

        private void filter_Check_CheckedChanged(object sender, EventArgs e)
        {
            if(filter_Check.Checked)
            {
                data_inicio.Visible = true;
                data_fim.Visible = true;
                label_data.Visible = true;
                btn_filter.Text = "Filtrar";
            } else
            {
                data_inicio.Visible = false;
                data_fim.Visible = false;
                label_data.Visible = false;
                btn_filter.Text = "Atualizar";
            }
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            Database.MostrarProcurar("SELECT id,nome,telefone,DATE_FORMAT(criacao,'%d/%m/%Y'),gastos FROM usuarios", data_view);
            if(filter_Check.Checked)
            {
                Database.MostrarProcurar("SELECT id,nome,telefone,DATE_FORMAT(criacao,'%d/%m/%Y'),gastos FROM usuarios WHERE DATE_FORMAT(criacao,'%d/%m/%Y') BETWEEN '" + data_inicio.Value.ToShortDateString() + "' AND '" + data_fim.Value.ToShortDateString() + "'", data_view);
            }
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            Database.MostrarProcurar("SELECT id,nome,telefone,DATE_FORMAT(criacao,'%d/%m/%Y'),gastos FROM usuarios", data_view);
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter="Arquivo Excel|*.xlsx" })
            {
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                        excel.Application.Workbooks.Add(Type.Missing);

                        excel.Columns.ColumnWidth = 28;
                        for (int i = 1; i < data_view.Columns.Count + 1; i++)
                        {
                            excel.Cells[1, i] = data_view.Columns[i - 1].HeaderText;
                        }
                        for (int i = 0; i < data_view.Rows.Count; i++)
                        {
                            for (int j = 0; j < data_view.Columns.Count; j++)
                            {
                                excel.Cells[i + 2, j + 1] = data_view.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                        excel.ActiveWorkbook.SaveCopyAs(saveFileDialog.FileName);
                        excel.ActiveWorkbook.Saved = true;
                        excel.Quit();

                        MessageBox.Show("Planilha Exportada");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
