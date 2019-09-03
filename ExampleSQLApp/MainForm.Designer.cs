namespace ExampleSQLApp
{
    partial class MainForm
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
            this.button_exit = new System.Windows.Forms.Button();
            this.listLabels = new System.Windows.Forms.ListBox();
            this.label_informer = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_message = new System.Windows.Forms.Label();
            this.textBox_message = new System.Windows.Forms.TextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.AutoSize = true;
            this.button_exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_exit.Location = new System.Drawing.Point(663, 313);
            this.button_exit.Name = "button_exit";
            this.button_exit.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.button_exit.Size = new System.Drawing.Size(109, 40);
            this.button_exit.TabIndex = 4;
            this.button_exit.Text = "Выход";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // listLabels
            // 
            this.listLabels.FormattingEnabled = true;
            this.listLabels.Location = new System.Drawing.Point(12, 37);
            this.listLabels.Name = "listLabels";
            this.listLabels.Size = new System.Drawing.Size(760, 212);
            this.listLabels.TabIndex = 1;
            this.listLabels.TabStop = false;
            // 
            // label_informer
            // 
            this.label_informer.AutoSize = true;
            this.label_informer.Location = new System.Drawing.Point(12, 9);
            this.label_informer.Name = "label_informer";
            this.label_informer.Size = new System.Drawing.Size(24, 13);
            this.label_informer.TabIndex = 2;
            this.label_informer.Text = "n/a";
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_name.Location = new System.Drawing.Point(92, 255);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(134, 26);
            this.textBox_name.TabIndex = 1;
            // 
            // label_name
            // 
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.Location = new System.Drawing.Point(12, 258);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(78, 20);
            this.label_name.TabIndex = 4;
            this.label_name.Text = "Имя:";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_message
            // 
            this.label_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_message.Location = new System.Drawing.Point(12, 284);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(78, 20);
            this.label_message.TabIndex = 4;
            this.label_message.Text = "Сообщение:";
            // 
            // textBox_message
            // 
            this.textBox_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_message.Location = new System.Drawing.Point(92, 281);
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.Size = new System.Drawing.Size(680, 26);
            this.textBox_message.TabIndex = 2;
            // 
            // button_send
            // 
            this.button_send.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_send.Location = new System.Drawing.Point(92, 313);
            this.button_send.Name = "button_send";
            this.button_send.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.button_send.Size = new System.Drawing.Size(134, 40);
            this.button_send.TabIndex = 3;
            this.button_send.Text = "Отправить";
            this.button_send.UseVisualStyleBackColor = false;
            this.button_send.Click += new System.EventHandler(this.Button_send_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.label_message);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_message);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_informer);
            this.Controls.Add(this.listLabels);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.button_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Лучшее приложение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.ListBox listLabels;
        private System.Windows.Forms.Label label_informer;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_message;
        private System.Windows.Forms.TextBox textBox_message;
        private System.Windows.Forms.Button button_send;
    }
}

