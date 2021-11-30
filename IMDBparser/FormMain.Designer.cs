namespace IMDBparser
{
    partial class FormMain
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
            this.dataGridViewFilmsTable = new System.Windows.Forms.DataGridView();
            this.buttonParseFilmsTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilmsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFilmsTable
            // 
            this.dataGridViewFilmsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFilmsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFilmsTable.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewFilmsTable.Name = "dataGridViewFilmsTable";
            this.dataGridViewFilmsTable.RowHeadersWidth = 51;
            this.dataGridViewFilmsTable.RowTemplate.Height = 24;
            this.dataGridViewFilmsTable.Size = new System.Drawing.Size(776, 397);
            this.dataGridViewFilmsTable.TabIndex = 0;
            // 
            // buttonParseFilmsTable
            // 
            this.buttonParseFilmsTable.Location = new System.Drawing.Point(12, 415);
            this.buttonParseFilmsTable.Name = "buttonParseFilmsTable";
            this.buttonParseFilmsTable.Size = new System.Drawing.Size(210, 23);
            this.buttonParseFilmsTable.TabIndex = 1;
            this.buttonParseFilmsTable.Text = "Parse Films Table";
            this.buttonParseFilmsTable.UseVisualStyleBackColor = true;
            this.buttonParseFilmsTable.Click += new System.EventHandler(this.buttonParseFilmsTable_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonParseFilmsTable);
            this.Controls.Add(this.dataGridViewFilmsTable);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFilmsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFilmsTable;
        private System.Windows.Forms.Button buttonParseFilmsTable;
    }
}

