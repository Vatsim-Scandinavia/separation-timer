
namespace Separation_Timer
{
    partial class TimerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerForm));
            this.labelTimeOne = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.timerOne = new System.Windows.Forms.Timer(this.components);
            this.buttonTimerOne1 = new System.Windows.Forms.Button();
            this.buttonTimerOne2 = new System.Windows.Forms.Button();
            this.labelTimeTwo = new System.Windows.Forms.Label();
            this.buttonTimerTwo2 = new System.Windows.Forms.Button();
            this.buttonTimerTwo1 = new System.Windows.Forms.Button();
            this.timerTwo = new System.Windows.Forms.Timer(this.components);
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTimeOne
            // 
            this.labelTimeOne.AutoSize = true;
            this.labelTimeOne.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTimeOne.ForeColor = System.Drawing.Color.White;
            this.labelTimeOne.Location = new System.Drawing.Point(23, 12);
            this.labelTimeOne.Name = "labelTimeOne";
            this.labelTimeOne.Size = new System.Drawing.Size(48, 18);
            this.labelTimeOne.TabIndex = 3;
            this.labelTimeOne.Text = "02:00";
            this.labelTimeOne.Visible = false;
            this.labelTimeOne.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTimeOne_MouseDown);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(54)))));
            this.buttonExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(54)))));
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(201, 10);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(24, 22);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // timerOne
            // 
            this.timerOne.Interval = 1000;
            this.timerOne.Tick += new System.EventHandler(this.timerOne_Tick);
            // 
            // buttonTimerOne1
            // 
            this.buttonTimerOne1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(54)))));
            this.buttonTimerOne1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonTimerOne1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimerOne1.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTimerOne1.ForeColor = System.Drawing.Color.White;
            this.buttonTimerOne1.Location = new System.Drawing.Point(17, 10);
            this.buttonTimerOne1.Name = "buttonTimerOne1";
            this.buttonTimerOne1.Size = new System.Drawing.Size(29, 22);
            this.buttonTimerOne1.TabIndex = 1;
            this.buttonTimerOne1.Text = "1";
            this.buttonTimerOne1.UseVisualStyleBackColor = false;
            this.buttonTimerOne1.Click += new System.EventHandler(this.buttonTimerOne1_Click);
            // 
            // buttonTimerOne2
            // 
            this.buttonTimerOne2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(54)))));
            this.buttonTimerOne2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonTimerOne2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimerOne2.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTimerOne2.ForeColor = System.Drawing.Color.White;
            this.buttonTimerOne2.Location = new System.Drawing.Point(47, 10);
            this.buttonTimerOne2.Name = "buttonTimerOne2";
            this.buttonTimerOne2.Size = new System.Drawing.Size(29, 22);
            this.buttonTimerOne2.TabIndex = 2;
            this.buttonTimerOne2.Text = "2";
            this.buttonTimerOne2.UseVisualStyleBackColor = false;
            this.buttonTimerOne2.Click += new System.EventHandler(this.buttonTimerOne2_Click);
            // 
            // labelTimeTwo
            // 
            this.labelTimeTwo.AutoSize = true;
            this.labelTimeTwo.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTimeTwo.ForeColor = System.Drawing.Color.White;
            this.labelTimeTwo.Location = new System.Drawing.Point(105, 12);
            this.labelTimeTwo.Name = "labelTimeTwo";
            this.labelTimeTwo.Size = new System.Drawing.Size(48, 18);
            this.labelTimeTwo.TabIndex = 4;
            this.labelTimeTwo.Text = "02:00";
            this.labelTimeTwo.Visible = false;
            this.labelTimeTwo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTimeTwo_MouseDown);
            // 
            // buttonTimerTwo2
            // 
            this.buttonTimerTwo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(54)))));
            this.buttonTimerTwo2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonTimerTwo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimerTwo2.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTimerTwo2.ForeColor = System.Drawing.Color.White;
            this.buttonTimerTwo2.Location = new System.Drawing.Point(129, 10);
            this.buttonTimerTwo2.Name = "buttonTimerTwo2";
            this.buttonTimerTwo2.Size = new System.Drawing.Size(29, 22);
            this.buttonTimerTwo2.TabIndex = 5;
            this.buttonTimerTwo2.Text = "2";
            this.buttonTimerTwo2.UseVisualStyleBackColor = false;
            this.buttonTimerTwo2.Click += new System.EventHandler(this.buttonTimerTwo2_Click);
            // 
            // buttonTimerTwo1
            // 
            this.buttonTimerTwo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(54)))));
            this.buttonTimerTwo1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonTimerTwo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimerTwo1.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTimerTwo1.ForeColor = System.Drawing.Color.White;
            this.buttonTimerTwo1.Location = new System.Drawing.Point(98, 10);
            this.buttonTimerTwo1.Name = "buttonTimerTwo1";
            this.buttonTimerTwo1.Size = new System.Drawing.Size(29, 22);
            this.buttonTimerTwo1.TabIndex = 4;
            this.buttonTimerTwo1.Text = "1";
            this.buttonTimerTwo1.UseVisualStyleBackColor = false;
            this.buttonTimerTwo1.Click += new System.EventHandler(this.buttonTimerTwo1_Click);
            // 
            // timerTwo
            // 
            this.timerTwo.Interval = 1000;
            this.timerTwo.Tick += new System.EventHandler(this.timerTwo_Tick);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(54)))));
            this.buttonMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(54)))));
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMinimize.ForeColor = System.Drawing.Color.White;
            this.buttonMinimize.Location = new System.Drawing.Point(177, 10);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(24, 22);
            this.buttonMinimize.TabIndex = 6;
            this.buttonMinimize.Text = "_";
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(65)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(237, 44);
            this.Controls.Add(this.buttonMinimize);
            this.Controls.Add(this.buttonTimerTwo2);
            this.Controls.Add(this.buttonTimerTwo1);
            this.Controls.Add(this.labelTimeTwo);
            this.Controls.Add(this.buttonTimerOne2);
            this.Controls.Add(this.buttonTimerOne1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelTimeOne);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(237, 44);
            this.MinimumSize = new System.Drawing.Size(237, 44);
            this.Name = "TimerForm";
            this.Text = "Separation Timer";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TimerForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTimeOne;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Timer timerOne;
        private System.Windows.Forms.Button buttonTimerOne1;
        private System.Windows.Forms.Button buttonTimerOne2;
        private System.Windows.Forms.Label labelTimeTwo;
        private System.Windows.Forms.Button buttonTimerTwo2;
        private System.Windows.Forms.Button buttonTimerTwo1;
        private System.Windows.Forms.Timer timerTwo;
        private System.Windows.Forms.Button buttonMinimize;
    }
}

