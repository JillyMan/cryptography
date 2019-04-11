using ChiffreDeVigenère.Window.Chiffre;
using System;
using System.Windows.Forms;

namespace ChiffreDeVigenère.Window
{
	static class Program
	{
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(
				new Window(
					new ChiffreVigenere(
						alphabet: AlphabetLoader.Load(Properties.Resources.Alphabet)
					)));
		}
	}
}
