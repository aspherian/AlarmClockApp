namespace AlarmClockApp.Forms
{
    partial class Awake
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AwakeText = new System.Windows.Forms.Label();
            this.awakenButton = new System.Windows.Forms.Button();
            this.delay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AwakeText
            // 
            this.AwakeText.AutoSize = true;
            this.AwakeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.AwakeText.ForeColor = System.Drawing.Color.Black;
            this.AwakeText.Location = new System.Drawing.Point(149, 58);
            this.AwakeText.Name = "AwakeText";
            this.AwakeText.Size = new System.Drawing.Size(70, 25);
            this.AwakeText.TabIndex = 0;
            this.AwakeText.Text = "label1";
            // 
            // awakenButton
            // 
            this.awakenButton.Location = new System.Drawing.Point(123, 110);
            this.awakenButton.Name = "awakenButton";
            this.awakenButton.Size = new System.Drawing.Size(117, 23);
            this.awakenButton.TabIndex = 1;
            this.awakenButton.Text = "я проснулся";
            this.awakenButton.UseVisualStyleBackColor = true;
            this.awakenButton.Click += new System.EventHandler(this.awakenButton_Click);
            // 
            // delay
            // 
            this.delay.Location = new System.Drawing.Point(123, 139);
            this.delay.Name = "delay";
            this.delay.Size = new System.Drawing.Size(117, 23);
            this.delay.TabIndex = 2;
            this.delay.Text = "ну дай 5 минут а";
            this.delay.UseVisualStyleBackColor = true;
            this.delay.Click += new System.EventHandler(this.button1_Click);
            // 
            // Awake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 166);
            this.Controls.Add(this.delay);
            this.Controls.Add(this.awakenButton);
            this.Controls.Add(this.AwakeText);
            this.Name = "Awake";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Awake_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AwakeText;
        private System.Windows.Forms.Button awakenButton;
        private System.Windows.Forms.Button delay;
    }
}