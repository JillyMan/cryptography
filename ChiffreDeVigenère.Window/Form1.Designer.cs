namespace ChiffreDeVigenère.Window
{
	partial class Window
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
			this.TextBox = new System.Windows.Forms.RichTextBox();
			this.TextLabel = new System.Windows.Forms.Label();
			this.KeyBox = new System.Windows.Forms.TextBox();
			this.KeyLabel = new System.Windows.Forms.Label();
			this.CalculateButton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.DecryptRadioButton = new System.Windows.Forms.RadioButton();
			this.EncryptRadioButton = new System.Windows.Forms.RadioButton();
			this.ResultTextBox = new System.Windows.Forms.RichTextBox();
			this.ResultText = new System.Windows.Forms.Label();
			this.ErrorMessage = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.loadAlphabetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadAlphabetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.loadTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// TextBox
			// 
			this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			resources.ApplyResources(this.TextBox, "TextBox");
			this.TextBox.Name = "TextBox";
			// 
			// TextLabel
			// 
			resources.ApplyResources(this.TextLabel, "TextLabel");
			this.TextLabel.Name = "TextLabel";
			// 
			// KeyBox
			// 
			this.KeyBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			resources.ApplyResources(this.KeyBox, "KeyBox");
			this.KeyBox.Name = "KeyBox";
			// 
			// KeyLabel
			// 
			resources.ApplyResources(this.KeyLabel, "KeyLabel");
			this.KeyLabel.Name = "KeyLabel";
			// 
			// CalculateButton
			// 
			resources.ApplyResources(this.CalculateButton, "CalculateButton");
			this.CalculateButton.Name = "CalculateButton";
			this.CalculateButton.UseVisualStyleBackColor = true;
			this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.DecryptRadioButton);
			this.panel1.Controls.Add(this.EncryptRadioButton);
			resources.ApplyResources(this.panel1, "panel1");
			this.panel1.Name = "panel1";
			// 
			// DecryptRadioButton
			// 
			resources.ApplyResources(this.DecryptRadioButton, "DecryptRadioButton");
			this.DecryptRadioButton.Name = "DecryptRadioButton";
			this.DecryptRadioButton.TabStop = true;
			this.DecryptRadioButton.UseVisualStyleBackColor = true;
			// 
			// EncryptRadioButton
			// 
			resources.ApplyResources(this.EncryptRadioButton, "EncryptRadioButton");
			this.EncryptRadioButton.Name = "EncryptRadioButton";
			this.EncryptRadioButton.TabStop = true;
			this.EncryptRadioButton.UseVisualStyleBackColor = true;
			// 
			// ResultTextBox
			// 
			this.ResultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			resources.ApplyResources(this.ResultTextBox, "ResultTextBox");
			this.ResultTextBox.Name = "ResultTextBox";
			this.ResultTextBox.ReadOnly = true;
			// 
			// ResultText
			// 
			resources.ApplyResources(this.ResultText, "ResultText");
			this.ResultText.Name = "ResultText";
			// 
			// ErrorMessage
			// 
			resources.ApplyResources(this.ErrorMessage, "ErrorMessage");
			this.ErrorMessage.BackColor = System.Drawing.Color.Red;
			this.ErrorMessage.Name = "ErrorMessage";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadAlphabetToolStripMenuItem});
			resources.ApplyResources(this.menuStrip1, "menuStrip1");
			this.menuStrip1.Name = "menuStrip1";
			// 
			// loadAlphabetToolStripMenuItem
			// 
			this.loadAlphabetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadAlphabetToolStripMenuItem1,
            this.loadTextToolStripMenuItem});
			this.loadAlphabetToolStripMenuItem.Name = "loadAlphabetToolStripMenuItem";
			resources.ApplyResources(this.loadAlphabetToolStripMenuItem, "loadAlphabetToolStripMenuItem");
			// 
			// loadAlphabetToolStripMenuItem1
			// 
			this.loadAlphabetToolStripMenuItem1.Name = "loadAlphabetToolStripMenuItem1";
			resources.ApplyResources(this.loadAlphabetToolStripMenuItem1, "loadAlphabetToolStripMenuItem1");
			this.loadAlphabetToolStripMenuItem1.Click += new System.EventHandler(this.LoadAlphabetToolStripMenuItem1_Click);
			// 
			// loadTextToolStripMenuItem
			// 
			this.loadTextToolStripMenuItem.Name = "loadTextToolStripMenuItem";
			resources.ApplyResources(this.loadTextToolStripMenuItem, "loadTextToolStripMenuItem");
			this.loadTextToolStripMenuItem.Click += new System.EventHandler(this.LoadTextToolStripMenuItem_Click);
			// 
			// Window
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.Controls.Add(this.ErrorMessage);
			this.Controls.Add(this.ResultText);
			this.Controls.Add(this.ResultTextBox);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.CalculateButton);
			this.Controls.Add(this.KeyLabel);
			this.Controls.Add(this.KeyBox);
			this.Controls.Add(this.TextLabel);
			this.Controls.Add(this.TextBox);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Window";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox TextBox;
		private System.Windows.Forms.Label TextLabel;
		private System.Windows.Forms.TextBox KeyBox;
		private System.Windows.Forms.Label KeyLabel;
		private System.Windows.Forms.Button CalculateButton;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton DecryptRadioButton;
		private System.Windows.Forms.RadioButton EncryptRadioButton;
		private System.Windows.Forms.RichTextBox ResultTextBox;
		private System.Windows.Forms.Label ResultText;
		private System.Windows.Forms.Label ErrorMessage;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem loadAlphabetToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadAlphabetToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem loadTextToolStripMenuItem;
	}
}
