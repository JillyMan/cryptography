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
		private readonly string SPECIFY_SHIFT = "Specify shift!";
		private readonly string SPECIFY_TEXT = "Specify text!";

		private IChiffre _chiffre;

		public Window(IChiffre chiffre)
		{
			InitializeComponent();
			_chiffre = chiffre;
			EncryptRadioButton.Checked = true;
			//TextBox.Text = "ATTACKATDAWN";
			//KeyBox.Text = "LEMON";
		}

		private void ValidateInput()
		{
			if (string.IsNullOrEmpty(KeyBox.Text))
			{
				throw new Exception(SPECIFY_KEY);
			}

			if (string.IsNullOrEmpty(TextBox.Text))
			{
				throw new Exception(SPECIFY_TEXT);
			}

			SetError(string.Empty);
		}

		private async void CalculateButton_Click(object sender, EventArgs e)
		{
			try
			{
				ValidateInput();
			}
			catch(Exception ex)
			{
				SetError(ex.Message);
				return;
			}

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
			var encriptingText = TextBox.Text;
			var encriptingKey = KeyBox.Text;

			var result = await _chiffre.Encrypt(encriptingText, encriptingKey);
			ResultTextBox.Text = result;
		}

		private async Task TryDecrypt()
		{
			var encriptedText = TextBox.Text;
			var decriptingKey = KeyBox.Text;

			var result = await _chiffre.Decrypt(encriptedText, decriptingKey);
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
