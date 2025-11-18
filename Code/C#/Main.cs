using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.IO.Ports;
using System.Reflection;

namespace CSConsole
{
    public partial class Main : Form
    {
        string[] comnamelist;
        string comname;
        byte[] combuffer;
        SerialPort SPort;
        string[] dummynamelist=new string[64];
        private readonly byte[] GetPSUdetail = new byte[] { 0x55, 0x7E, 0x02, 0x04, 0x06, 0xAE };
        private void InitDevicePortName()
        {
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher
                ("select * from Win32_PnPEntity where Name like '%(COM%'"))
            {
                var hardInfos = searcher.Get();
                int index_namelist = 0;
                int index_findlist = 0;
                foreach (var hardInfo in hardInfos)
                {
                    /*
                    List<string> list = new List<string>();
                    List<string> list2 = new List<string>();

                    foreach (var Info in hardInfo.Properties)
                    {
                        list.Add(Info.Name);
                        if (hardInfo.Properties[Info.Name].Value != null)
                        {
                            list2.Add(hardInfo.Properties[Info.Name].Value.ToString());
                        }
                        else
                        {
                            list2.Add("NULL");
                        }
                    }*/
                    if (hardInfo.Properties["Name"].Value != null && hardInfo.Properties["Status"].Value != null)
                    {
                        string deviceName = hardInfo.Properties["Name"].Value.ToString();
                        for(index_findlist = 0; index_findlist < comnamelist.Length; index_findlist++)
                        {
                            string findpattern = "(" + comnamelist[index_findlist] + ")";
                            if (deviceName.Contains(findpattern))
                            {
                                dummynamelist[index_findlist] = deviceName;
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    index_namelist++;
                }
            }
        }

        public Main()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            ClearTextBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cntdev_Click(object sender, EventArgs e)
        {
            if (comname != null)
            {
                if (SPort == null)
                {
                    SPort = new SerialPort(comname, 115200, Parity.None, 8, StopBits.One);
                }
                if (!SPort.IsOpen)
                {
                    try
                    {
                        SPort.Open();
                    }
                    catch
                    {
                        MessageBox.Show("端口被占用！", "警告:", MessageBoxButtons.OK);
                    }
                    cntdev.Text = "断开";
                    getcom.Enabled = false;
                    SPort.DataReceived += datareciveProcess;
                    SPort.Write(GetPSUdetail, 0, GetPSUdetail.Length);

                }
                else
                {
                    SPort.Close();
                    cntdev.Text = "连接";
                    getcom.Enabled = true;
                    SPort.DataReceived -= datareciveProcess;
                    ClearTextBox();
                    return;
                }
            }
            else
            {
                MessageBox.Show("请先刷新并选定串行端口！", "警告:", MessageBoxButtons.OK);
                return;
            }
        }

        private void ClearTextBox()
        {
            comlist.Items.Clear();
            typedetail.Text = "";
            verifylevel.Text = "";
            volt12v.Text = "";
            volt5v.Text = "";
            volt3v3.Text = "";
            volt5vsb.Text = "";
            fanmode.Text = "";
            fanspeed.Text = "";
            inputvolt.Text = "";
            inputcurrent.Text = "";
            inputpower.Text = "";
            acfreq.Text = "";
            actemp.Text = "";
            dctemp.Text = "";
            roomtemp.Text = "";
            errorcode.Text = "";
        }
        private void comlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            comname = comnamelist[comlist.SelectedIndex];
        }

        private void datareciveProcess(object port,SerialDataReceivedEventArgs e)
        {
            if (SPort.IsOpen)
            {
                combuffer = new byte[SPort.BytesToRead];
                SPort.Read(combuffer, 0, combuffer.Length);
                dataProcess(combuffer);
            }
            else
            {
                return;
            }
        }

        private void dataProcess(byte[] buffer)
        {
            if (buffer.Length > 3)
            {
                if (buffer[3] == 0x02)
                {
                    volt12v.Clear();
                    float v12v = (buffer[8] + (buffer[9] << 8)) / 1000f;
                    volt12v.AppendText(v12v.ToString("N3"));

                    volt5v.Clear();
                    float v5v = (buffer[6] + (buffer[7] << 8)) / 1000f;
                    volt5v.AppendText(v5v.ToString("N3"));

                    volt3v3.Clear();
                    float v3v3v = (buffer[4] + (buffer[5] << 8)) / 1000f;
                    volt3v3.AppendText(v3v3v.ToString("N3"));

                    volt5vsb.Clear();
                    float v5vsb = (buffer[10] + (buffer[11] << 8)) / 1000f;
                    volt5vsb.AppendText(v5vsb.ToString("N3"));

                    ////////////////////////////////////////////////////////

                    fanmode.Clear();
                    switch(buffer[12])
                    {
                        case 0:
                            fanmode.AppendText(v12v.ToString("自动"));
                            break;
                        case 1:
                            fanmode.AppendText(v12v.ToString("静音"));
                            break;
                        case 2:
                            fanmode.AppendText(v12v.ToString("超频"));
                            break;
                        case 3:
                            fanmode.AppendText(v12v.ToString("自定义"));
                            break;
                        case 4:
                            fanmode.AppendText(v12v.ToString("清灰"));
                            break;
                    }

                    fanspeed.Clear();
                    int fspeed = (buffer[28] + (buffer[29] << 8)) * 30;
                    fanspeed.AppendText(fspeed.ToString("N0"));

                    ///////////////////////////////////////////////////////

                    inputvolt.Clear();
                    float involt = (buffer[26] + (buffer[27] << 8)) * 0.1f;
                    inputvolt.AppendText(involt.ToString("N1"));
                    
                    /*inputcurrent.Clear();
                    float incurrent = (buffer[14] + (buffer[15] << 8)) / 200f;
                    inputcurrent.AppendText(incurrent.ToString("N1"));*/

                    inputcurrent.Clear();
                    inputcurrent.AppendText("参数不可用");

                    inputpower.Clear();
                    float inpower = (buffer[16] + (buffer[17] << 8)) / 20f;
                    inputpower.AppendText(inpower.ToString("N1"));

                    acfreq.Clear();
                    float infreq = (buffer[18] + (buffer[19] << 8)) * 0.1f;
                    acfreq.AppendText(infreq.ToString("N1"));

                    ///////////////////////////////////////////////////////

                    actemp.Clear();
                    float acdctemp = (buffer[20] + (buffer[21] << 8)) / 256f;
                    actemp.AppendText(acdctemp.ToString("N1"));

                    dctemp.Clear();
                    float dcdctemp = (buffer[22] + (buffer[23] << 8)) / 256f;
                    dctemp.AppendText(dcdctemp.ToString("N1"));

                    roomtemp.Clear();
                    float roomtemppoint = (buffer[24] + (buffer[25] << 8)) / 256f;
                    roomtemp.AppendText(roomtemppoint.ToString("N1"));

                    ///////////////////////////////////////////////////////

                    errorcode.Clear();
                    int err = buffer[30] + (buffer[31] << 8);
                    errorcode.AppendText(err.ToString("N0"));

                }

                if (buffer[3]==0x03)
                {
                    typedetail.Clear();
                    byte[] vendor = buffer.Skip(22).Take(7).ToArray();
                    byte[] type = buffer.Skip(4).Take(8).ToArray();
                    byte[] verify=buffer.Skip(21).Take(1).ToArray();
                    typedetail.AppendText(Encoding.UTF8.GetString(vendor).ToUpper() + ",\t" + Encoding.UTF8.GetString(type));
                    if (Encoding.UTF8.GetString(verify) == "P")
                    {
                        verifylevel.Clear();
                        verifylevel.AppendText("80PLUS 白金");
                    }
                }

                if (buffer[3] == 0x05)
                {
                    byte[] sn = buffer.Skip(4).Take(16).ToArray();
                    typedetail.AppendText(",\t" + Encoding.UTF8.GetString(sn));
                }

            }
        }

        private void getcom_Click(object sender, EventArgs e)
        {
            comlist.Items.Clear();
            comnamelist = System.IO.Ports.SerialPort.GetPortNames();
            InitDevicePortName();
            foreach (var name in dummynamelist)
            {
                if (name != null)
                {
                    comlist.Items.Add(name);
                }
                else
                {
                    break;
                }
            }
            return;
        }

        private void psudetail_Enter(object sender, EventArgs e)
        {
            return;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            return;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            return;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            return;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            return;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            return;
        }

        private void volt12v_TextChanged(object sender, EventArgs e)
        {
            return;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否退出?", "提示:", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.OK)   //如果单击“是”按钮
            {
                e.Cancel = false;                 //关闭窗体
                if (SPort != null)
                {
                    if (SPort.IsOpen)
                    {
                        SPort.Close();
                        cntdev.Text = "连接";
                        getcom.Enabled = true;
                        SPort.DataReceived -= datareciveProcess;
                    }
                }
                ClearTextBox();
            }
            else if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;                  //不执行操作
            }
        }
    }
}
