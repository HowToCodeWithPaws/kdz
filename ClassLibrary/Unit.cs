using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
	/// <summary>
	/// Класс для объекта в игре, имеется доступ к его полям через свойства 
	/// для обеспечения возможности редактирования параметров.
	/// </summary>
	public class Unit
	{
		// Поля объекта.
		private string hero;
		private double dps;
		private double headshotDPS;
		private double singleShot;
		private double life;
		private double reload;

		/// <summary>
		/// Публичное свойство для поля hero с сеттером и геттером.
		/// </summary>
		public string Hero
		{
			get { return hero; }
			//set
			//{
			//	if (value.Trim() != String.Empty)
			//	{
			//		hero = value;
			//	}
			//	else { throw new FormatException("Вы попытались ввести " +
			//		"неподходящую строку, не делайте так."); }
			//}
		}

		/// <summary>
		/// Публичное свойство для поля dps с сеттером и геттером.
		/// </summary>
		public double DPS
		{
			get { return dps; }
			//set
			//{
			//	dps = value > 0 ? value < double.MaxValue ?
			//			dps = value : dps = double.MaxValue : dps = 0;
			//}
		}

		/// <summary>
		/// Публичное свойство для поля headshotDPS с сеттером и геттером.
		/// </summary>
		public double HeadshotDPS
		{
			get { return headshotDPS; }
			//set
			//{
			//	headshotDPS = value > 0 ? value < double.MaxValue ?
			//		headshotDPS = value : headshotDPS = double.MaxValue : headshotDPS = 0;
			//}
		}

		///// <summary>
		///// Публичное свойство для поля singleShot с сеттером и геттером.
		///// </summary>
		//public double SingleShot
		//{
		//	get { return singleShot; }
		//	set { singleShot = value; }
		//}

		/// <summary>
		/// Публичное свойство для поля life с сеттером и геттером.
		/// </summary>
		public double Life
		{
			get { return life; }
			set
			{
				life = value > 0 ? value < double.MaxValue ?
					life = value : life = double.MaxValue : life = 0;
			}
		}

		///// <summary>
		///// Публичное свойство для поля reload с сеттером и геттером.
		///// </summary>
		//public double Reload
		//{
		//	get { return reload; }
		//	set { reload = value; }
		//}

		/// <summary>
		/// Конструктор для объекта с параметрами 
		/// </summary>
		/// <param name="hero_"></param>
		/// <param name="dps_"></param>
		/// <param name="headshotDPS_"></param>
		/// <param name="singleShot_"></param>
		/// <param name="life_"></param>
		/// <param name="reload_"></param>
		public Unit(string hero_, double dps_, double headshotDPS_,
			double singleShot_, double life_, double reload_)
		{
			hero = hero_;
			dps = dps_;
			headshotDPS = headshotDPS_;
			singleShot = singleShot_;
			life = life_;
			reload = reload_;
		}
	}
}
