
using System.Windows.Forms;

namespace VirtualDisplay
{
    partial class MessageBox
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
            this.Timer_Close_button = new System.Windows.Forms.Timer(this.components);
            this.App_Close = new System.Windows.Forms.PictureBox();
            this.Yes = new System.Windows.Forms.Button();
            this.No = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.Text = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.App_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer_Close_button
            // 
            this.Timer_Close_button.Interval = 8;
            this.Timer_Close_button.Tick += new System.EventHandler(this.Timer_Close_button_Tick);
            // 
            // App_Close
            // 
            this.App_Close.Image = global::VirtualDisplay.Properties.Resources.close;
            this.App_Close.Location = new System.Drawing.Point(275, 2);
            this.App_Close.Name = "App_Close";
            this.App_Close.Size = new System.Drawing.Size(40, 16);
            this.App_Close.TabIndex = 0;
            this.App_Close.TabStop = false;
            this.App_Close.Click += new System.EventHandler(this.App_Close_Click);
            this.App_Close.MouseEnter += new System.EventHandler(this.App_Close_MouseEnter);
            this.App_Close.MouseLeave += new System.EventHandler(this.App_Close_MouseLeave);
            // 
            // Yes
            // 
            this.Yes.BackColor = System.Drawing.Color.Transparent;
            this.Yes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Yes.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.Yes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Yes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Yes.ForeColor = System.Drawing.Color.White;
            this.Yes.Location = new System.Drawing.Point(59, 124);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(67, 23);
            this.Yes.TabIndex = 1;
            this.Yes.Text = "Да";
            this.Yes.UseVisualStyleBackColor = false;
            this.Yes.Visible = false;
            this.Yes.Click += new System.EventHandler(this.Yes_Click);
            // 
            // No
            // 
            this.No.BackColor = System.Drawing.Color.Transparent;
            this.No.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.No.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.No.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.No.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.No.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.No.ForeColor = System.Drawing.Color.White;
            this.No.Location = new System.Drawing.Point(189, 124);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(67, 23);
            this.No.TabIndex = 2;
            this.No.Text = "Нет";
            this.No.UseVisualStyleBackColor = false;
            this.No.Visible = false;
            this.No.Click += new System.EventHandler(this.No_Click);
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.Transparent;
            this.OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OK.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.OK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK.ForeColor = System.Drawing.Color.White;
            this.OK.Location = new System.Drawing.Point(123, 124);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(67, 23);
            this.OK.TabIndex = 3;
            this.OK.Text = "ОК";
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Visible = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Text
            // 
            this.Text.AutoEllipsis = true;
            this.Text.CausesValidation = false;
            this.Text.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Text.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Text.Location = new System.Drawing.Point(24, 26);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(267, 82);
            this.Text.TabIndex = 4;
            this.Text.Text = "Description";
            this.Text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Text.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Text_MouseDown_1);
            this.Text.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Text_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(318, 159);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.No);
            this.Controls.Add(this.Yes);
            this.Controls.Add(this.App_Close);
            this.Controls.Add(this.Text);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBox";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MessageBox_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.App_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Timer_Close_button;
        private System.Windows.Forms.PictureBox App_Close;
        private Button Yes;
        private Button No;
        private Button OK;
        private Label Text;
        private Label label1;
        private Timer timer1;
    }
}

