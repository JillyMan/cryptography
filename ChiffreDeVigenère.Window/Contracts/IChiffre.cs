using System.Threading.Tasks;

namespace ChiffreDeVigenère.Window.Contracts
{
	public interface IChiffre
	{
		string Alphabet { set; }
		Task<string> Encrypt(string text, string key);
		Task<string> Decrypt(string text, string key);
	}
}
