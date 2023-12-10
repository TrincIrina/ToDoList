namespace ToDoList
{
    partial class MyForm
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
            this.todoListBox = new System.Windows.Forms.ListBox();
            this.todoTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.deleteAll = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // todoListBox
            // 
            this.todoListBox.BackColor = System.Drawing.Color.Gray;
            this.todoListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.todoListBox.ForeColor = System.Drawing.Color.White;
            this.todoListBox.FormattingEnabled = true;
            this.todoListBox.ItemHeight = 25;
            this.todoListBox.Location = new System.Drawing.Point(0, 0);
            this.todoListBox.Name = "todoListBox";
            this.todoListBox.Size = new System.Drawing.Size(542, 379);
            this.todoListBox.TabIndex = 0;
            this.todoListBox.SelectedIndexChanged += new System.EventHandler(this.todoListBox_SelectedIndexChanged);
            // 
            // todoTextBox
            // 
            this.todoTextBox.BackColor = System.Drawing.Color.Gray;
            this.todoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.todoTextBox.ForeColor = System.Drawing.Color.White;
            this.todoTextBox.Location = new System.Drawing.Point(548, 12);
            this.todoTextBox.Name = "todoTextBox";
            this.todoTextBox.Size = new System.Drawing.Size(390, 35);
            this.todoTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Silver;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.addButton.Location = new System.Drawing.Point(548, 64);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(390, 50);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add a case";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Silver;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.updateButton.Location = new System.Drawing.Point(548, 130);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(390, 50);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Update the item";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Silver;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.deleteButton.Location = new System.Drawing.Point(548, 199);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(390, 50);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete selected";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // deleteAll
            // 
            this.deleteAll.BackColor = System.Drawing.Color.Silver;
            this.deleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteAll.ForeColor = System.Drawing.Color.DarkGreen;
            this.deleteAll.Location = new System.Drawing.Point(548, 264);
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.Size = new System.Drawing.Size(390, 50);
            this.deleteAll.TabIndex = 5;
            this.deleteAll.Text = "Delete all";
            this.deleteAll.UseVisualStyleBackColor = false;
            this.deleteAll.Click += new System.EventHandler(this.deleteAll_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Silver;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.Color.Red;
            this.exitButton.Location = new System.Drawing.Point(548, 329);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(390, 50);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(950, 384);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.deleteAll);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.todoTextBox);
            this.Controls.Add(this.todoListBox);
            this.Name = "MyForm";
            this.Text = "To - do list";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox todoListBox;
        private System.Windows.Forms.TextBox todoTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button deleteAll;
        private System.Windows.Forms.Button exitButton;
    }
}

