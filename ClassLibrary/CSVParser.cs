using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ClassLibrary
{
	public static class CSVParser
	{
		public static object[] Parse(string source)
		{
			/// Блок try catch обрабатывает возможные исключения, возникающие при работе с файлами.
			try
			{
				string[] lines = File.ReadAllLines(source);

				string[][] positions = new string[lines.Length-1][];

				string[] head = lines[0].Split(';');

				for (int i = 0; i < lines.Length-1; i++)
				{
					positions[i] = lines[i+1].Split(';');
				}

				string[] names = new string[lines.Length-1];

				for (int i = 0; i < positions.Length; i++)
				{
					names[i] = positions[i][0];
				}

				double[][] numbers = new double[lines.Length-1][];

				for (int i = 0; i < lines.Length-1; i++)
				{
					for (int j = 0; j < positions[0].Length-1; j++)
					{
						if (string.IsNullOrEmpty(positions[i][j+1]))
						{
							numbers[i][j] = 0;
						}

						if (positions[i][j+1] == "infinity")
						{
							numbers[i][j] = double.MaxValue;
						}

						if (double.TryParse(positions[i][j + 1].Trim(), out double v))
						{
							numbers[i][j] = v;
						}

						//if (!double.TryParse(positions[i][j+1].Trim(), out numbers[i][j]))
						//{
						//	throw new FormatException("В таблице находятся неверные данные");
						//}

					}
				}

				object[] outs = new string[3][][];
				outs[0] = head;
				outs[1] = names;
				outs[2] = numbers;

				return outs;
			}
			catch (FileNotFoundException e)
			{
				throw e;
			}
			catch (IOException e)
			{
				throw e;
			}
			catch (System.Security.SecurityException e)
			{
				throw e;
			}
		}
	}
}
