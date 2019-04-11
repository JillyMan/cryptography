using ChiffreDeVigenère.Window.Chiffre;
using ChiffreDeVigenère.Window.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChiffreDeVigenère.Window
{
	public partial class Window : Form
	{
		private readonly string SPECIFY_KEY = "Specify key!";
		private readonly string SPECIFY_TEXT = "Specify text!";

		private IChiffre _chiffre;

		public Window(IChiffre chiffre)
		{
			InitializeComponent();
			_chiffre = chiffre;
			EncryptRadioButton.Checked = true;
		}

		private string ValidateInput()
		{
			if (string.IsNullOrEmpty(KeyBox.Text))
			{
				return SPECIFY_KEY;
			}

			if (string.IsNullOrEmpty(TextBox.Text))
			{
				return SPECIFY_TEXT;
			}

			return string.Empty;
		}

		private async void CalculateButton_Click(object sender, EventArgs e)
		{
			SetError(ValidateInput());

			if (EncryptRadioButton.Checked)
			{
				await TryEncrypt();
			}
			else
			{
				await TryDecrypt();
			}
		}

		private async Task TryEncrypt()
		{
			SetResult(await _chiffre.Encrypt(TextBox.Text, KeyBox.Text));
		}

		private async Task TryDecrypt()
		{
			SetResult(await _chiffre.Decrypt(TextBox.Text, KeyBox.Text));
		}

		private void SetResult(string result)
		{
			ResultTextBox.Text = result;
		}

		private void SetError(string message)
		{
			ErrorMessage.Text = message;
		}

		private void LoadAlphabetToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			using (var fileDialog = new OpenFileDialog())
			{
				var result = fileDialog.ShowDialog();
				if(result == DialogResult.OK)
				{
					_chiffre.Alphabet = AlphabetLoader.Load(fileDialog.FileName);
				}
			}
		}

		private void LoadTextToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (var fileDialog = new OpenFileDialog())
			{
				var result = fileDialog.ShowDialog();
				if (result == DialogResult.OK)
				{
					TextBox.Text = AlphabetLoader.Load(fileDialog.FileName);
				}
			}
		}
	}
}
