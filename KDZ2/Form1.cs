using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using static ClassLibrary.CSVParser;
using System.IO;

namespace KDZ2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			prevGame.Visible = true;
			newGame.Visible = true;
		}

		private void prevGame_Click(object sender, EventArgs e)
		{
			//TODO сохраненный хмл с проверкой его наличия
		}

		private void newGame_Click(object sender, EventArgs e)
		{
			Initialize();
			newGame.Visible = false;
			prevGame.Visible = false;
		}

		void Initialize()
		{
			data.Visible = true;

			/// Блок try catch обрабатывает возможные исключения, 
			/// возникающие при работе с файлами.
			try
			{
				object[] info = CSVParser.Parse("../../../Overwatch.csv");
				data.ColumnCount = (info[0] as string[]).Length;

				for (int i = 0; i < data.ColumnCount; i++)
				{
					data.Columns[i].Name = (info[0] as string[])[i];
				}

				for (int i = 0; i < (info[1] as string[]).Length; i++)
				{
					data.Rows[i].HeaderCell.Value = (info[1] as string[])[i];
				}

				for (int i = 1; i < info.Length; i++)
				{
					data.Rows.Add((info[2] as double[][])[i]);
				}
				
			}
			catch (FileNotFoundException)
			{
				MessageBox.Show("Файл не существует, " +
					"добавьте его в папку с решением.");
			}
			catch (IOException)
			{
				MessageBox.Show("Ошибка в работе с файлом.");
			}
			catch (UnauthorizedAccessException)
			{
				MessageBox.Show("Ошибка доступа к файлу: у вас" +
					" нет разрешения на доступ.");
			}
			catch (System.Security.SecurityException)
			{
				MessageBox.Show("Ошибка безопасности при работе " +
					"с файлом.");
			}
		}

		private void data_CellValidating(object sender,
			DataGridViewCellValidatingEventArgs e)
		{
			if (e.ColumnIndex != 0 &&
				(!double.TryParse(e.FormattedValue.ToString(), out double v)))
			{
				if ((double.TryParse(e.FormattedValue.ToString(), out double x) &&
				(x < double.MinValue || x > double.MaxValue)))
				{
					MessageBox.Show("it");
				}
				MessageBox.Show("Вы не можете изменить значение " +
					$"ячейки на значение {e.FormattedValue}! Введите вещественное " +
	 "число в значениях от double.MinValue до double.MaxValue.") ;
				e.Cancel = true;

			}
		}
	}
}
