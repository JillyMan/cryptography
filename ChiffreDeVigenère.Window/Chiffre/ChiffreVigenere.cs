using ChiffreDeVigenère.Window.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiffreDeVigenère.Window.Chiffre
{
	public class ChiffreVigenere : IChiffre
	{
		private string _alphabet;
		private int _shift;
		private IDictionary<char, int> _dictionary;

		public string Alphabet { set => _alphabet = value; }

		public ChiffreVigenere(string alphabet)
		{
			_alphabet = alphabet ?? throw new ArgumentNullException(nameof(alphabet));
			_shift = -1;
			Init();
		}

		private void Init()
		{
			_dictionary = new Dictionary<char, int>(_alphabet.Length);
			for (int i = 0; i < _alphabet.Length; ++i)
			{
				char lowcase = char.ToLower(_alphabet[i]);
				char highcase = char.ToUpper(_alphabet[i]);
				_dictionary.Add(lowcase, i);
				_dictionary.Add(highcase, i);
			}
		}

		public async Task<string> Decrypt(string text, string key)
		{
			return await Task.Run(() =>
			{
				return Cycle(text, key, (x, y, l) =>
				{
					char result;
					if (x < y)
					{
						result = _alphabet[l - Math.Abs(x - y) - _shift];
					}
					else
					{
						result = _alphabet[x - y];
					}
					return result;
				});
			});
		}

		public async Task<string> Encrypt(string sourceText, string key)
		{
			return await Task.Run(() =>
			{
				return Cycle(sourceText, key, (x, y, l) =>
				{
					char result;
					if (x + y > l)
					{
						result = _alphabet[Math.Abs(x + y + _shift) % l];
					}
					else if(x + y == l)
					{
						result = _alphabet[Math.Abs(x + y + _shift + 1) % (l+1)];
					}
					else
					{
						result = _alphabet[Math.Abs(x + y + _shift+1) % l];
					}

					return result;
				});

			});
		}

		private string Cycle(string sourceText, string key, Func<int, int, int, char> action)
		{
			var result = new char[sourceText.Length];
			var length = _alphabet.Length - 1;

			for (var i = 0; i < sourceText.Length; ++i)
			{
				var keyChar = key[i % key.Length];
				var sourceChar = sourceText[i];

				if (!char.IsLetter(sourceChar))
				{
					result[i] = sourceChar;
					continue;
				}
				else
				{
					var y = _dictionary[keyChar];
					var x = _dictionary[sourceChar];

					result[i] = action(x, y, length);
				}
			}

			return new StringBuilder()
				.Append(result)
				.ToString()
				.ToUpper();
		}
	}
}