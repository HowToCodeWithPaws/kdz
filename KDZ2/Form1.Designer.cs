namespace KDZ2
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.data = new System.Windows.Forms.DataGridView();
			this.newGame = new System.Windows.Forms.Button();
			this.prevGame = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
			this.SuspendLayout();
			// 
			// data
			// 
			this.data.AllowUserToAddRows = false;
			this.data.AllowUserToDeleteRows = false;
			this.data.AllowUserToOrderColumns = true;
			this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.data.Location = new System.Drawing.Point(12, 6);
			this.data.Name = "data";
			this.data.RowHeadersWidth = 62;
			this.data.RowTemplate.Height = 28;
			this.data.Size = new System.Drawing.Size(1028, 540);
			this.data.TabIndex = 0;
			this.data.Visible = false;
			this.data.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.data_CellValidating);
			// 
			// newGame
			// 
			this.newGame.Location = new System.Drawing.Point(724, 207);
			this.newGame.Name = "newGame";
			this.newGame.Size = new System.Drawing.Size(316, 127);
			this.newGame.TabIndex = 1;
			this.newGame.Text = "новая игра";
			this.newGame.UseVisualStyleBackColor = true;
			this.newGame.Visible = false;
			this.newGame.Click += new System.EventHandler(this.newGame_Click);
			// 
			// prevGame
			// 
			this.prevGame.Location = new System.Drawing.Point(118, 207);
			this.prevGame.Name = "prevGame";
			this.prevGame.Size = new System.Drawing.Size(325, 127);
			this.prevGame.TabIndex = 2;
			this.prevGame.Text = "продолжить игру с последнего сохранения";
			this.prevGame.UseVisualStyleBackColor = true;
			this.prevGame.Visible = false;
			this.prevGame.Click += new System.EventHandler(this.prevGame_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1421, 558);
			this.Controls.Add(this.prevGame);
			this.Controls.Add(this.newGame);
			this.Controls.Add(this.data);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView data;
		private System.Windows.Forms.Button newGame;
		private System.Windows.Forms.Button prevGame;
	}
}

