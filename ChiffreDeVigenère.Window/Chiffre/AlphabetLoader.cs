using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiffreDeVigenère.Window.Chiffre
{
	class AlphabetLoader
	{
		public static string Load(string path)
		{
			if(!File.Exists(path))
			{
				throw new FileNotFoundException(path);
			}

			return File.ReadAllText(path).ToLower();
		}
	}
}
