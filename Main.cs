using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using WindowsDisplayAPI;
namespace VirtualDisplay
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            getMachineConfiguration();
            InitializeConfiguration();
        }

        private bool isInstalled = false;
        private bool Close_IsOverlapped;
        private float Close_Opacity = 0f;
        private IEnumerable<Display> Displays;

        private void App_Close_MouseEnter(object sender, System.EventArgs e)
        {
            Close_IsOverlapped = true;
            Timer_Close_button.Start();
        }

        private void App_Close_MouseLeave(object sender, System.EventArgs e)
        {
            Close_IsOverlapped = false;
            Timer_Close_button.Start();
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void Timer_Close_button_Tick(object sender, EventArgs e)
        {
            Gradient_Float gf = new Gradient_Float();
            if (Close_IsOverlapped == true) Close_Opacity += 0.1f;
            else if (Close_IsOverlapped == false) Close_Opacity -= 0.1f;

            if (Close_Opacity >= 1f)
            {
                Close_Opacity = 1f;
                Timer_Close_button.Stop();
            }
            else if (Close_Opacity <= 0f)
            {
                Close_Opacity = 0f;
                Timer_Close_button.Stop();
            }

            App_Close.BackgroundImage = gf.ChangeOpacity(Properties.Resources.hovered, Close_Opacity);
        }

        private string x32 = $"{Environment.CurrentDirectory}/VirtualDisplay/deviceinstaller.exe";
        private string x64 = $"{Environment.CurrentDirectory}/VirtualDisplay/deviceinstaller64.exe";

        public bool OSx64 = Environment.Is64BitOperatingSystem;
        private void LogWrite(string value)
        {
            try
            {
                LogsLabel.Text = value;
                if (!Directory.Exists("logs"))
                {
                    Directory.CreateDirectory("logs");
                }
                StreamWriter streamWriter = File.AppendText("logs/logs.log");
                streamWriter.WriteLine(DateTime.Now + " || " + value);
                streamWriter.Close();
            }
            catch { }
        }

        private void InitializeConfiguration()
        {
            string configuredstring = "";
            string[] o = System.Reflection.Assembly.GetExecutingAssembly().Location.Split('\\');
            for (int i = 0; i < o.Length - 1; i++)
            {
                configuredstring += o[i] + "\\";
            }

            Environment.CurrentDirectory = configuredstring;

            UpdateConfiguration();
        }
        private void UpdateInterface()
        {
            if (isInstalled == true)
            {
                VMonInstalled.Text = "Виртуальный драйвер: " + "Установлен";
            }
            else
            {
                VMonInstalled.Text = "Виртуальный драйвер: " + "Не установлен";
            }
            if (SelectDisplays.SelectedItem != null)
            {
                string selDispInList = SelectDisplays.SelectedItem.ToString();
            }
            SelectDisplays.Items.Clear();

            foreach (Display disp in Displays)
            {
                SelectDisplays.Items.Add(disp.DisplayFullName);
            }
        }
        private void UpdateConfiguration()
        {
            Displays = Display.GetDisplays();

            string tmp = "";
            foreach (Display disp in Displays)
            {
                tmp += " " + disp.Adapter.DeviceName;
            }
            if (tmp.Contains("Mobile Monitor"))
            {
                isInstalled = true;
            }
            else
            {
                isInstalled = false;
            }
            UpdateInterface();
        }
        private List<string> runProcess(string[] args)
        {
            List<string> result = new List<string>();
            Process a = new Process();
            a.StartInfo.WorkingDirectory = "VirtualDisplay/";
            a.StartInfo.Verb = "runas";
            a.StartInfo.CreateNoWindow = true;
            a.StartInfo.RedirectStandardOutput = true;
            a.StartInfo.UseShellExecute = false;
            if (OSx64 == false)
            {
                a.StartInfo.FileName = x32;
            }
            else
            {
                a.StartInfo.FileName = x64;
            }
            for (int i = 0; i < args.Length; i++)
            {
                a.StartInfo.Arguments = args[i];
                a.Start();
                a.WaitForExit();
            }
            while (!a.StandardOutput.EndOfStream)
            {
                result.Add(a.StandardOutput.ReadLine());
            }
            return result;
        }
        private void getMachineConfiguration()
        {
            OSBit.Text += Environment.OSVersion;
            if (OSx64 == false)
            {
                OSBit.Text += " 32 bit";
            }
            else
            {
                OSBit.Text += " 64 bit";
            }
        }
        private void App_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DeleteVMon_Click(object sender, EventArgs e)
        {
            List<string> logs = new List<string>();
            string[] args = { "stop usbmmidd", "remove usbmmidd" };
            logs = runProcess(args);
        }

        private void InstallVMon_Click(object sender, EventArgs e)
        {
            List<string> logs = new List<string>();
            string[] args = { "install usbmmidd.inf usbmmidd" };
            logs = runProcess(args);
            logs.Contains("success");
            UpdateConfiguration();
        }

        private void ReloadVMon_Click(object sender, EventArgs e)
        {
            List<string> logs = new List<string>();
            string[] args = { "enableidd 0", "enableidd 1" };
            logs = runProcess(args);
            UpdateConfiguration();
        }

        private void RemoveVMon_Click(object sender, EventArgs e)
        {
            List<string> logs = new List<string>();
            string[] args = { "enableidd 0" };
            logs = runProcess(args);
            UpdateConfiguration();
        }

        private void AddVMon_Click(object sender, EventArgs e)
        {
            List<string> logs = new List<string>();
            string[] args = { "enableidd 1" };
            logs = runProcess(args);
            UpdateConfiguration();
        }

        private void ApplyMonRes_Click(object sender, EventArgs e)
        {
            Display selectedDisplay = null;

            foreach (Display disp in Displays)
            {
                if (SelectDisplays.Text == disp.DisplayFullName)
                {
                    selectedDisplay = disp;
                }
            }

            if (SelectDisplays.Text != "")
            {
                try
                {
                    DisplaySetting oldSettings = selectedDisplay.SavedSetting;
                    System.Drawing.Size oldResolution = oldSettings.Resolution;
                    int oldHz = oldSettings.Frequency;
                    System.Drawing.Size newResolution = System.Drawing.Size.Empty;
                    newResolution.Width = Convert.ToInt16(New_Width.Text);
                    newResolution.Height = Convert.ToInt16(New_Height.Text);
                    DisplaySetting dset = new DisplaySetting(newResolution, Convert.ToInt16(New_Hz.Text));
                    selectedDisplay.SetSettings(dset, true);

                    MessageBox a = new MessageBox("Применить разрешение?", "Ваше разрешение экрана верно? Нажмите \"Да\" если это так. По истечении времени разрешение автоматически вернётся на старое.", true, false, true, 15);
                    a.Location = MousePosition;
                    a.ShowDialog();
                    if (a.result == false)
                    {
                        dset = new DisplaySetting(oldResolution, oldHz);
                        selectedDisplay.SetSettings(dset, true);
                    }
                    LogWrite(Convert.ToString(a.result));
                }
                catch (WindowsDisplayAPI.Exceptions.ModeChangeException f)
                {
                    LogWrite("Невозможно применить данные настройки. \n" + f.InnerException);
                }
                catch (System.FormatException)
                {
                    LogWrite("Неверно/не заполнены строки(а).");
                }
            }
            else
            {
                LogWrite("Выделите монитор в списке!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> logs = new List<string>();
            string[] args = { "stop usbmmidd" };
            logs = runProcess(args);
        }

        private void SelectDisplays_SelectedIndexChanged(object sender, EventArgs e)
        {


            Display selectedDisplay = null;

            foreach (Display disp in Displays)
            {
                if (SelectDisplays.Text == disp.DisplayFullName)
                {
                    selectedDisplay = disp;
                }
            }
            Old_Width.Text = selectedDisplay.SavedSetting.Resolution.Width.ToString();
            Old_Height.Text = selectedDisplay.SavedSetting.Resolution.Height.ToString();
            Old_Hz.Text = selectedDisplay.SavedSetting.Frequency.ToString();
            Old_isEnabled.Text = selectedDisplay.SavedSetting.IsEnable.ToString();

            New_Width.Text = selectedDisplay.SavedSetting.Resolution.Width.ToString();
            New_Height.Text = selectedDisplay.SavedSetting.Resolution.Height.ToString();
            New_Hz.Text = selectedDisplay.SavedSetting.Frequency.ToString();
            New_isEnabled.Text = selectedDisplay.SavedSetting.IsEnable.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private int x, y;
        private void OnObjectMoveWind_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }

        private void New_Hz_TextChanged(object sender, EventArgs e)
        {
        }

        private void OnObjectMoveWind_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left = Left + e.X - x;
                Top = Top + e.Y - y;
            }
        }
    }
}

/* EDIT THIS PLEASE ###################################################
System.Drawing.Size a = System.Drawing.Size.Empty;
a.Width = 800;
a.Height = 600;
DisplaySetting dset = new DisplaySetting(a, 60);
disp.SetSettings(dset, true);
Thread.Sleep(5000);
a.Width = 1920;
a.Height = 1080; 
dset = new DisplaySetting(a, 60);
disp.SetSettings(dset, true);
*/