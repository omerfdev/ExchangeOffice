namespace ExchangeOffice
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			lblExchangeOffice = new Label();
			lblValue = new Label();
			lblCurrency = new Label();
			SuspendLayout();
			// 
			// lblExchangeOffice
			// 
			lblExchangeOffice.AutoSize = true;
			lblExchangeOffice.Location = new Point(21, 19);
			lblExchangeOffice.Name = "lblExchangeOffice";
			lblExchangeOffice.Size = new Size(0, 20);
			lblExchangeOffice.TabIndex = 0;
			// 
			// lblValue
			// 
			lblValue.AutoSize = true;
			lblValue.Location = new Point(422, 19);
			lblValue.Name = "lblValue";
			lblValue.Size = new Size(0, 20);
			lblValue.TabIndex = 1;
			// 
			// lblCurrency
			// 
			lblCurrency.AutoSize = true;
			lblCurrency.Location = new Point(213, 19);
			lblCurrency.Name = "lblCurrency";
			lblCurrency.Size = new Size(0, 20);
			lblCurrency.TabIndex = 2;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(lblCurrency);
			Controls.Add(lblValue);
			Controls.Add(lblExchangeOffice);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Form1";
			Text = "Exchange Office";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblExchangeOffice;
		private Label lblValue;
		private Label lblCurrency;
	}
}