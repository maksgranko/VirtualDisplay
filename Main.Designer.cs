
using System.Windows.Forms;

namespace VirtualDisplay
{
    partial class Main
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.OSBit = new System.Windows.Forms.Label();
            this.InstallVMon = new System.Windows.Forms.Button();
            this.DeleteVMon = new System.Windows.Forms.Button();
            this.RemoveVMon = new System.Windows.Forms.Button();
            this.AddVMon = new System.Windows.Forms.Button();
            this.SetValuesRegedit = new System.Windows.Forms.Button();
            this.LogsLabel = new System.Windows.Forms.Label();
            this.VMonInstalled = new System.Windows.Forms.Label();
            this.SelectDisplays = new System.Windows.Forms.ComboBox();
            this.New_Width = new System.Windows.Forms.TextBox();
            this.New_Height = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.New_Hz = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.App_Close = new System.Windows.Forms.PictureBox();
            this.New_Orientation = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Old_Hz = new System.Windows.Forms.TextBox();
            this.Old_Height = new System.Windows.Forms.TextBox();
            this.Old_Width = new System.Windows.Forms.TextBox();
            this.Old_isEnabled = new System.Windows.Forms.TextBox();
            this.Old_Orientation = new System.Windows.Forms.TextBox();
            this.New_isEnabled = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.App_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer_Close_button
            // 
            this.Timer_Close_button.Interval = 8;
            this.Timer_Close_button.Tick += new System.EventHandler(this.Timer_Close_button_Tick);
            // 
            // OSBit
            // 
            this.OSBit.Font = new System.Drawing.Font("Leelawadee UI Semilight", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OSBit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OSBit.Location = new System.Drawing.Point(12, 370);
            this.OSBit.Name = "OSBit";
            this.OSBit.Size = new System.Drawing.Size(618, 15);
            this.OSBit.TabIndex = 1;
            this.OSBit.Text = "Ваша система: ";
            this.OSBit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnObjectMoveWind_MouseDown);
            this.OSBit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnObjectMoveWind_MouseMove);
            // 
            // InstallVMon
            // 
            this.InstallVMon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InstallVMon.Location = new System.Drawing.Point(136, 25);
            this.InstallVMon.Name = "InstallVMon";
            this.InstallVMon.Size = new System.Drawing.Size(128, 23);
            this.InstallVMon.TabIndex = 3;
            this.InstallVMon.Text = "Установить драйвер";
            this.InstallVMon.UseVisualStyleBackColor = true;
            this.InstallVMon.Click += new System.EventHandler(this.InstallVMon_Click);
            // 
            // DeleteVMon
            // 
            this.DeleteVMon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteVMon.Location = new System.Drawing.Point(136, 54);
            this.DeleteVMon.Name = "DeleteVMon";
            this.DeleteVMon.Size = new System.Drawing.Size(128, 23);
            this.DeleteVMon.TabIndex = 4;
            this.DeleteVMon.Text = "Удалить драйвер";
            this.DeleteVMon.UseVisualStyleBackColor = true;
            this.DeleteVMon.Click += new System.EventHandler(this.DeleteVMon_Click);
            // 
            // RemoveVMon
            // 
            this.RemoveVMon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RemoveVMon.Location = new System.Drawing.Point(12, 54);
            this.RemoveVMon.Name = "RemoveVMon";
            this.RemoveVMon.Size = new System.Drawing.Size(118, 23);
            this.RemoveVMon.TabIndex = 6;
            this.RemoveVMon.Text = "Удалить монитор";
            this.RemoveVMon.UseVisualStyleBackColor = true;
            this.RemoveVMon.Click += new System.EventHandler(this.RemoveVMon_Click);
            // 
            // AddVMon
            // 
            this.AddVMon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddVMon.Location = new System.Drawing.Point(12, 25);
            this.AddVMon.Name = "AddVMon";
            this.AddVMon.Size = new System.Drawing.Size(118, 23);
            this.AddVMon.TabIndex = 5;
            this.AddVMon.Text = "Добавить монитор";
            this.AddVMon.UseVisualStyleBackColor = true;
            this.AddVMon.Click += new System.EventHandler(this.AddVMon_Click);
            // 
            // SetValuesRegedit
            // 
            this.SetValuesRegedit.Location = new System.Drawing.Point(392, 198);
            this.SetValuesRegedit.Name = "SetValuesRegedit";
            this.SetValuesRegedit.Size = new System.Drawing.Size(238, 23);
            this.SetValuesRegedit.TabIndex = 17;
            this.SetValuesRegedit.Text = "Применить";
            this.SetValuesRegedit.UseVisualStyleBackColor = true;
            this.SetValuesRegedit.Click += new System.EventHandler(this.ApplyMonRes_Click);
            // 
            // LogsLabel
            // 
            this.LogsLabel.Font = new System.Drawing.Font("Leelawadee UI Semilight", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogsLabel.Location = new System.Drawing.Point(12, 385);
            this.LogsLabel.Name = "LogsLabel";
            this.LogsLabel.Size = new System.Drawing.Size(615, 56);
            this.LogsLabel.TabIndex = 18;
            this.LogsLabel.Text = "Важная информация будет показана здесь.";
            this.LogsLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnObjectMoveWind_MouseDown);
            this.LogsLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnObjectMoveWind_MouseMove);
            // 
            // VMonInstalled
            // 
            this.VMonInstalled.Font = new System.Drawing.Font("Leelawadee UI Semilight", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VMonInstalled.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.VMonInstalled.Location = new System.Drawing.Point(12, 355);
            this.VMonInstalled.Name = "VMonInstalled";
            this.VMonInstalled.Size = new System.Drawing.Size(615, 15);
            this.VMonInstalled.TabIndex = 29;
            this.VMonInstalled.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnObjectMoveWind_MouseDown);
            this.VMonInstalled.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnObjectMoveWind_MouseMove);
            // 
            // SelectDisplays
            // 
            this.SelectDisplays.FormattingEnabled = true;
            this.SelectDisplays.Location = new System.Drawing.Point(391, 41);
            this.SelectDisplays.Name = "SelectDisplays";
            this.SelectDisplays.Size = new System.Drawing.Size(238, 21);
            this.SelectDisplays.TabIndex = 31;
            this.SelectDisplays.SelectedIndexChanged += new System.EventHandler(this.SelectDisplays_SelectedIndexChanged);
            // 
            // New_Width
            // 
            this.New_Width.Location = new System.Drawing.Point(561, 68);
            this.New_Width.MaxLength = 5;
            this.New_Width.Name = "New_Width";
            this.New_Width.Size = new System.Drawing.Size(68, 20);
            this.New_Width.TabIndex = 32;
            this.New_Width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // New_Height
            // 
            this.New_Height.Location = new System.Drawing.Point(561, 94);
            this.New_Height.MaxLength = 5;
            this.New_Height.Name = "New_Height";
            this.New_Height.Size = new System.Drawing.Size(68, 20);
            this.New_Height.TabIndex = 33;
            this.New_Height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(466, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Ширина";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(466, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Высота";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(392, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Список дисплеев";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(136, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Отключить драйвер";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(466, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Hz";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // New_Hz
            // 
            this.New_Hz.Location = new System.Drawing.Point(561, 120);
            this.New_Hz.MaxLength = 5;
            this.New_Hz.Name = "New_Hz";
            this.New_Hz.Size = new System.Drawing.Size(68, 20);
            this.New_Hz.TabIndex = 38;
            this.New_Hz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.New_Hz.TextChanged += new System.EventHandler(this.New_Hz_TextChanged);
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(466, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Включён?";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // App_Close
            // 
            this.App_Close.Image = global::VirtualDisplay.Properties.Resources.close;
            this.App_Close.Location = new System.Drawing.Point(596, 6);
            this.App_Close.Name = "App_Close";
            this.App_Close.Size = new System.Drawing.Size(40, 16);
            this.App_Close.TabIndex = 0;
            this.App_Close.TabStop = false;
            this.App_Close.Click += new System.EventHandler(this.App_Close_Click);
            this.App_Close.MouseEnter += new System.EventHandler(this.App_Close_MouseEnter);
            this.App_Close.MouseLeave += new System.EventHandler(this.App_Close_MouseLeave);
            // 
            // New_Orientation
            // 
            this.New_Orientation.FormattingEnabled = true;
            this.New_Orientation.Location = new System.Drawing.Point(561, 146);
            this.New_Orientation.Name = "New_Orientation";
            this.New_Orientation.Size = new System.Drawing.Size(69, 21);
            this.New_Orientation.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(466, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Ориентация";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Old_Hz
            // 
            this.Old_Hz.Location = new System.Drawing.Point(391, 120);
            this.Old_Hz.MaxLength = 5;
            this.Old_Hz.Name = "Old_Hz";
            this.Old_Hz.Size = new System.Drawing.Size(68, 20);
            this.Old_Hz.TabIndex = 55;
            this.Old_Hz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Old_Height
            // 
            this.Old_Height.Enabled = false;
            this.Old_Height.Location = new System.Drawing.Point(391, 94);
            this.Old_Height.MaxLength = 5;
            this.Old_Height.Name = "Old_Height";
            this.Old_Height.Size = new System.Drawing.Size(68, 20);
            this.Old_Height.TabIndex = 51;
            this.Old_Height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Old_Width
            // 
            this.Old_Width.Enabled = false;
            this.Old_Width.Location = new System.Drawing.Point(391, 68);
            this.Old_Width.MaxLength = 5;
            this.Old_Width.Name = "Old_Width";
            this.Old_Width.Size = new System.Drawing.Size(68, 20);
            this.Old_Width.TabIndex = 50;
            this.Old_Width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Old_isEnabled
            // 
            this.Old_isEnabled.Enabled = false;
            this.Old_isEnabled.Location = new System.Drawing.Point(392, 172);
            this.Old_isEnabled.MaxLength = 5;
            this.Old_isEnabled.Name = "Old_isEnabled";
            this.Old_isEnabled.Size = new System.Drawing.Size(68, 20);
            this.Old_isEnabled.TabIndex = 61;
            this.Old_isEnabled.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Old_Orientation
            // 
            this.Old_Orientation.Enabled = false;
            this.Old_Orientation.Location = new System.Drawing.Point(392, 146);
            this.Old_Orientation.MaxLength = 5;
            this.Old_Orientation.Name = "Old_Orientation";
            this.Old_Orientation.Size = new System.Drawing.Size(68, 20);
            this.Old_Orientation.TabIndex = 62;
            this.Old_Orientation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // New_isEnabled
            // 
            this.New_isEnabled.Enabled = false;
            this.New_isEnabled.Location = new System.Drawing.Point(561, 173);
            this.New_isEnabled.MaxLength = 5;
            this.New_isEnabled.Name = "New_isEnabled";
            this.New_isEnabled.Size = new System.Drawing.Size(69, 20);
            this.New_isEnabled.TabIndex = 63;
            this.New_isEnabled.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(642, 441);
            this.Controls.Add(this.New_isEnabled);
            this.Controls.Add(this.Old_Orientation);
            this.Controls.Add(this.Old_isEnabled);
            this.Controls.Add(this.Old_Hz);
            this.Controls.Add(this.Old_Height);
            this.Controls.Add(this.Old_Width);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.New_Orientation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.New_Hz);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.New_Height);
            this.Controls.Add(this.New_Width);
            this.Controls.Add(this.SelectDisplays);
            this.Controls.Add(this.VMonInstalled);
            this.Controls.Add(this.LogsLabel);
            this.Controls.Add(this.SetValuesRegedit);
            this.Controls.Add(this.RemoveVMon);
            this.Controls.Add(this.AddVMon);
            this.Controls.Add(this.DeleteVMon);
            this.Controls.Add(this.InstallVMon);
            this.Controls.Add(this.OSBit);
            this.Controls.Add(this.App_Close);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Virtual Display";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.App_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Timer_Close_button;
        private System.Windows.Forms.PictureBox App_Close;
        private Timer timer1;
        private Label OSBit;
        private Button InstallVMon;
        private Button DeleteVMon;
        private Button RemoveVMon;
        private Button AddVMon;
        private Button SetValuesRegedit;
        private Label LogsLabel;
        private Label VMonInstalled;
        private ComboBox SelectDisplays;
        private TextBox New_Width;
        private TextBox New_Height;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private TextBox New_Hz;
        private Label label5;
        private ComboBox New_Orientation;
        private Label label6;
        private TextBox Old_Hz;
        private TextBox Old_Height;
        private TextBox Old_Width;
        private TextBox Old_isEnabled;
        private TextBox Old_Orientation;
        private TextBox New_isEnabled;
    }
}

