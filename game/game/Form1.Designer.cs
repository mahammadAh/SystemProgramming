
namespace game
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.TeLabel = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.Pointlabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.Bestlabel = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "A";
            // 
            // TeLabel
            // 
            this.TeLabel.Location = new System.Drawing.Point(12, 396);
            this.TeLabel.Name = "TeLabel";
            this.TeLabel.Size = new System.Drawing.Size(50, 23);
            this.TeLabel.TabIndex = 1;
            this.TeLabel.Text = "Time :";
            // 
            // label
            // 
            this.label.Location = new System.Drawing.Point(12, 419);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(50, 23);
            this.label.TabIndex = 2;
            this.label.Text = "Score :";
            // 
            // TimeLabel
            // 
            this.TimeLabel.Location = new System.Drawing.Point(68, 396);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(50, 23);
            this.TimeLabel.TabIndex = 3;
            this.TimeLabel.Text = "0";
            // 
            // Pointlabel
            // 
            this.Pointlabel.Location = new System.Drawing.Point(68, 418);
            this.Pointlabel.Name = "Pointlabel";
            this.Pointlabel.Size = new System.Drawing.Size(50, 23);
            this.Pointlabel.TabIndex = 4;
            this.Pointlabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Best Result :";
            // 
            // Bestlabel
            // 
            this.Bestlabel.AutoSize = true;
            this.Bestlabel.Location = new System.Drawing.Point(207, 396);
            this.Bestlabel.Name = "Bestlabel";
            this.Bestlabel.Size = new System.Drawing.Size(13, 13);
            this.Bestlabel.TabIndex = 6;
            this.Bestlabel.Text = "0";
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(526, 413);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 7;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(429, 413);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 8;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.Location = new System.Drawing.Point(619, 413);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(75, 23);
            this.RestartButton.TabIndex = 9;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(713, 413);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.Bestlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pointlabel);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.label);
            this.Controls.Add(this.TeLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TeLabel;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label Pointlabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Bestlabel;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Button CloseButton;
    }
}

