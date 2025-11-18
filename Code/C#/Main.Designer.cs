using System.Windows.Forms;

namespace CSConsole
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cntdev = new System.Windows.Forms.Button();
            this.comlist = new System.Windows.Forms.ComboBox();
            this.getcom = new System.Windows.Forms.Button();
            this.psudetail = new System.Windows.Forms.GroupBox();
            this.volt = new System.Windows.Forms.Label();
            this.verifylevel = new System.Windows.Forms.TextBox();
            this.typedetail = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.roomtemp = new System.Windows.Forms.TextBox();
            this.roomtemplab = new System.Windows.Forms.Label();
            this.errorcode = new System.Windows.Forms.TextBox();
            this.errorcodelab = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fanmodelab = new System.Windows.Forms.Label();
            this.fanmode = new System.Windows.Forms.TextBox();
            this.fanspeed = new System.Windows.Forms.TextBox();
            this.fanspeedlab = new System.Windows.Forms.Label();
            this.dcpart = new System.Windows.Forms.GroupBox();
            this.dctemplab = new System.Windows.Forms.Label();
            this.dctemp = new System.Windows.Forms.TextBox();
            this.volt5vlab = new System.Windows.Forms.Label();
            this.volt5v = new System.Windows.Forms.TextBox();
            this.volt5vsblab = new System.Windows.Forms.Label();
            this.volt12v = new System.Windows.Forms.TextBox();
            this.volt12vlab = new System.Windows.Forms.Label();
            this.volt5vsb = new System.Windows.Forms.TextBox();
            this.volt3v3 = new System.Windows.Forms.TextBox();
            this.volt3v3lab = new System.Windows.Forms.Label();
            this.acpart = new System.Windows.Forms.GroupBox();
            this.actemp = new System.Windows.Forms.TextBox();
            this.actemplab = new System.Windows.Forms.Label();
            this.inputcurrentlab = new System.Windows.Forms.Label();
            this.inputpower = new System.Windows.Forms.TextBox();
            this.inputcurrent = new System.Windows.Forms.TextBox();
            this.acfreqlab = new System.Windows.Forms.Label();
            this.inputpowlab = new System.Windows.Forms.Label();
            this.acfreq = new System.Windows.Forms.TextBox();
            this.inputvolt = new System.Windows.Forms.TextBox();
            this.inputvoltlab = new System.Windows.Forms.Label();
            this.psudetail.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.dcpart.SuspendLayout();
            this.acpart.SuspendLayout();
            this.SuspendLayout();
            // 
            // cntdev
            // 
            this.cntdev.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cntdev.Location = new System.Drawing.Point(515, 12);
            this.cntdev.Name = "cntdev";
            this.cntdev.Size = new System.Drawing.Size(69, 27);
            this.cntdev.TabIndex = 0;
            this.cntdev.Text = "连接";
            this.cntdev.UseVisualStyleBackColor = true;
            this.cntdev.Click += new System.EventHandler(this.cntdev_Click);
            // 
            // comlist
            // 
            this.comlist.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comlist.FormattingEnabled = true;
            this.comlist.Location = new System.Drawing.Point(99, 12);
            this.comlist.Name = "comlist";
            this.comlist.Size = new System.Drawing.Size(410, 27);
            this.comlist.TabIndex = 1;
            this.comlist.SelectedIndexChanged += new System.EventHandler(this.comlist_SelectedIndexChanged);
            // 
            // getcom
            // 
            this.getcom.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.getcom.Location = new System.Drawing.Point(24, 12);
            this.getcom.Name = "getcom";
            this.getcom.Size = new System.Drawing.Size(69, 27);
            this.getcom.TabIndex = 2;
            this.getcom.Text = "刷新";
            this.getcom.UseVisualStyleBackColor = true;
            this.getcom.Click += new System.EventHandler(this.getcom_Click);
            // 
            // psudetail
            // 
            this.psudetail.Controls.Add(this.volt);
            this.psudetail.Controls.Add(this.verifylevel);
            this.psudetail.Controls.Add(this.typedetail);
            this.psudetail.Controls.Add(this.type);
            this.psudetail.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.psudetail.Location = new System.Drawing.Point(24, 58);
            this.psudetail.Name = "psudetail";
            this.psudetail.Size = new System.Drawing.Size(560, 109);
            this.psudetail.TabIndex = 3;
            this.psudetail.TabStop = false;
            this.psudetail.Text = "电源参数";
            this.psudetail.Enter += new System.EventHandler(this.psudetail_Enter);
            // 
            // volt
            // 
            this.volt.AutoSize = true;
            this.volt.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.volt.Location = new System.Drawing.Point(18, 65);
            this.volt.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.volt.Name = "volt";
            this.volt.Size = new System.Drawing.Size(66, 19);
            this.volt.TabIndex = 15;
            this.volt.Text = "认证：";
            // 
            // verifylevel
            // 
            this.verifylevel.Location = new System.Drawing.Point(80, 65);
            this.verifylevel.Name = "verifylevel";
            this.verifylevel.ReadOnly = true;
            this.verifylevel.Size = new System.Drawing.Size(450, 24);
            this.verifylevel.TabIndex = 13;
            // 
            // typedetail
            // 
            this.typedetail.Location = new System.Drawing.Point(80, 26);
            this.typedetail.Name = "typedetail";
            this.typedetail.ReadOnly = true;
            this.typedetail.Size = new System.Drawing.Size(450, 24);
            this.typedetail.TabIndex = 12;
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.type.Location = new System.Drawing.Point(18, 28);
            this.type.Margin = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(66, 19);
            this.type.TabIndex = 0;
            this.type.Text = "型号：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dcpart);
            this.groupBox1.Controls.Add(this.acpart);
            this.groupBox1.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(24, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 391);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "电源状态";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.roomtemp);
            this.groupBox3.Controls.Add(this.roomtemplab);
            this.groupBox3.Controls.Add(this.errorcode);
            this.groupBox3.Controls.Add(this.errorcodelab);
            this.groupBox3.Location = new System.Drawing.Point(289, 266);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 109);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DEBUG";
            // 
            // roomtemp
            // 
            this.roomtemp.Location = new System.Drawing.Point(108, 68);
            this.roomtemp.Name = "roomtemp";
            this.roomtemp.ReadOnly = true;
            this.roomtemp.Size = new System.Drawing.Size(133, 24);
            this.roomtemp.TabIndex = 14;
            // 
            // roomtemplab
            // 
            this.roomtemplab.AutoSize = true;
            this.roomtemplab.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.roomtemplab.Location = new System.Drawing.Point(18, 70);
            this.roomtemplab.Margin = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.roomtemplab.Name = "roomtemplab";
            this.roomtemplab.Size = new System.Drawing.Size(85, 19);
            this.roomtemplab.TabIndex = 13;
            this.roomtemplab.Text = "环境温度";
            // 
            // errorcode
            // 
            this.errorcode.Location = new System.Drawing.Point(108, 26);
            this.errorcode.Name = "errorcode";
            this.errorcode.ReadOnly = true;
            this.errorcode.Size = new System.Drawing.Size(133, 24);
            this.errorcode.TabIndex = 12;
            // 
            // errorcodelab
            // 
            this.errorcodelab.AutoSize = true;
            this.errorcodelab.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.errorcodelab.Location = new System.Drawing.Point(18, 28);
            this.errorcodelab.Margin = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.errorcodelab.Name = "errorcodelab";
            this.errorcodelab.Size = new System.Drawing.Size(85, 19);
            this.errorcodelab.TabIndex = 0;
            this.errorcodelab.Text = "错误代码";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fanmodelab);
            this.groupBox2.Controls.Add(this.fanmode);
            this.groupBox2.Controls.Add(this.fanspeed);
            this.groupBox2.Controls.Add(this.fanspeedlab);
            this.groupBox2.Location = new System.Drawing.Point(22, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 109);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FAN";
            // 
            // fanmodelab
            // 
            this.fanmodelab.AutoSize = true;
            this.fanmodelab.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fanmodelab.Location = new System.Drawing.Point(18, 65);
            this.fanmodelab.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.fanmodelab.Name = "fanmodelab";
            this.fanmodelab.Size = new System.Drawing.Size(85, 19);
            this.fanmodelab.TabIndex = 15;
            this.fanmodelab.Text = "风扇模式";
            // 
            // fanmode
            // 
            this.fanmode.Location = new System.Drawing.Point(108, 65);
            this.fanmode.Name = "fanmode";
            this.fanmode.ReadOnly = true;
            this.fanmode.Size = new System.Drawing.Size(133, 24);
            this.fanmode.TabIndex = 13;
            // 
            // fanspeed
            // 
            this.fanspeed.Location = new System.Drawing.Point(108, 26);
            this.fanspeed.Name = "fanspeed";
            this.fanspeed.ReadOnly = true;
            this.fanspeed.Size = new System.Drawing.Size(133, 24);
            this.fanspeed.TabIndex = 12;
            // 
            // fanspeedlab
            // 
            this.fanspeedlab.AutoSize = true;
            this.fanspeedlab.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fanspeedlab.Location = new System.Drawing.Point(18, 28);
            this.fanspeedlab.Margin = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.fanspeedlab.Name = "fanspeedlab";
            this.fanspeedlab.Size = new System.Drawing.Size(85, 19);
            this.fanspeedlab.TabIndex = 0;
            this.fanspeedlab.Text = "风扇转速";
            // 
            // dcpart
            // 
            this.dcpart.Controls.Add(this.dctemplab);
            this.dcpart.Controls.Add(this.dctemp);
            this.dcpart.Controls.Add(this.volt5vlab);
            this.dcpart.Controls.Add(this.volt5v);
            this.dcpart.Controls.Add(this.volt5vsblab);
            this.dcpart.Controls.Add(this.volt12v);
            this.dcpart.Controls.Add(this.volt12vlab);
            this.dcpart.Controls.Add(this.volt5vsb);
            this.dcpart.Controls.Add(this.volt3v3);
            this.dcpart.Controls.Add(this.volt3v3lab);
            this.dcpart.Location = new System.Drawing.Point(289, 23);
            this.dcpart.Name = "dcpart";
            this.dcpart.Size = new System.Drawing.Size(250, 224);
            this.dcpart.TabIndex = 21;
            this.dcpart.TabStop = false;
            this.dcpart.Text = "DC";
            // 
            // dctemplab
            // 
            this.dctemplab.AutoSize = true;
            this.dctemplab.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dctemplab.Location = new System.Drawing.Point(18, 182);
            this.dctemplab.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.dctemplab.Name = "dctemplab";
            this.dctemplab.Size = new System.Drawing.Size(72, 19);
            this.dctemplab.TabIndex = 21;
            this.dctemplab.Text = "DC温度";
            // 
            // dctemp
            // 
            this.dctemp.Location = new System.Drawing.Point(108, 182);
            this.dctemp.Name = "dctemp";
            this.dctemp.ReadOnly = true;
            this.dctemp.Size = new System.Drawing.Size(133, 24);
            this.dctemp.TabIndex = 20;
            // 
            // volt5vlab
            // 
            this.volt5vlab.AutoSize = true;
            this.volt5vlab.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.volt5vlab.Location = new System.Drawing.Point(18, 65);
            this.volt5vlab.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.volt5vlab.Name = "volt5vlab";
            this.volt5vlab.Size = new System.Drawing.Size(44, 19);
            this.volt5vlab.TabIndex = 15;
            this.volt5vlab.Text = "+5V";
            // 
            // volt5v
            // 
            this.volt5v.Location = new System.Drawing.Point(108, 65);
            this.volt5v.Name = "volt5v";
            this.volt5v.ReadOnly = true;
            this.volt5v.Size = new System.Drawing.Size(133, 24);
            this.volt5v.TabIndex = 13;
            // 
            // volt5vsblab
            // 
            this.volt5vsblab.AutoSize = true;
            this.volt5vsblab.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.volt5vsblab.Location = new System.Drawing.Point(18, 143);
            this.volt5vsblab.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.volt5vsblab.Name = "volt5vsblab";
            this.volt5vsblab.Size = new System.Drawing.Size(57, 19);
            this.volt5vsblab.TabIndex = 19;
            this.volt5vsblab.Text = "5V SB";
            // 
            // volt12v
            // 
            this.volt12v.Location = new System.Drawing.Point(108, 26);
            this.volt12v.Name = "volt12v";
            this.volt12v.ReadOnly = true;
            this.volt12v.Size = new System.Drawing.Size(133, 24);
            this.volt12v.TabIndex = 12;
            this.volt12v.TextChanged += new System.EventHandler(this.volt12v_TextChanged);
            // 
            // volt12vlab
            // 
            this.volt12vlab.AutoSize = true;
            this.volt12vlab.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.volt12vlab.Location = new System.Drawing.Point(18, 28);
            this.volt12vlab.Margin = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.volt12vlab.Name = "volt12vlab";
            this.volt12vlab.Size = new System.Drawing.Size(54, 19);
            this.volt12vlab.TabIndex = 0;
            this.volt12vlab.Text = "+12V";
            // 
            // volt5vsb
            // 
            this.volt5vsb.Location = new System.Drawing.Point(108, 143);
            this.volt5vsb.Name = "volt5vsb";
            this.volt5vsb.ReadOnly = true;
            this.volt5vsb.Size = new System.Drawing.Size(133, 24);
            this.volt5vsb.TabIndex = 18;
            // 
            // volt3v3
            // 
            this.volt3v3.Location = new System.Drawing.Point(108, 104);
            this.volt3v3.Name = "volt3v3";
            this.volt3v3.ReadOnly = true;
            this.volt3v3.Size = new System.Drawing.Size(133, 24);
            this.volt3v3.TabIndex = 16;
            // 
            // volt3v3lab
            // 
            this.volt3v3lab.AutoSize = true;
            this.volt3v3lab.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.volt3v3lab.Location = new System.Drawing.Point(18, 104);
            this.volt3v3lab.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.volt3v3lab.Name = "volt3v3lab";
            this.volt3v3lab.Size = new System.Drawing.Size(58, 19);
            this.volt3v3lab.TabIndex = 17;
            this.volt3v3lab.Text = "+3.3V";
            // 
            // acpart
            // 
            this.acpart.Controls.Add(this.actemp);
            this.acpart.Controls.Add(this.actemplab);
            this.acpart.Controls.Add(this.inputcurrentlab);
            this.acpart.Controls.Add(this.inputpower);
            this.acpart.Controls.Add(this.inputcurrent);
            this.acpart.Controls.Add(this.acfreqlab);
            this.acpart.Controls.Add(this.inputpowlab);
            this.acpart.Controls.Add(this.acfreq);
            this.acpart.Controls.Add(this.inputvolt);
            this.acpart.Controls.Add(this.inputvoltlab);
            this.acpart.Location = new System.Drawing.Point(22, 23);
            this.acpart.Name = "acpart";
            this.acpart.Size = new System.Drawing.Size(250, 224);
            this.acpart.TabIndex = 20;
            this.acpart.TabStop = false;
            this.acpart.Text = "AC";
            // 
            // actemp
            // 
            this.actemp.Location = new System.Drawing.Point(121, 180);
            this.actemp.Name = "actemp";
            this.actemp.ReadOnly = true;
            this.actemp.Size = new System.Drawing.Size(122, 24);
            this.actemp.TabIndex = 28;
            // 
            // actemplab
            // 
            this.actemplab.AutoSize = true;
            this.actemplab.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.actemplab.Location = new System.Drawing.Point(18, 180);
            this.actemplab.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.actemplab.Name = "actemplab";
            this.actemplab.Size = new System.Drawing.Size(71, 19);
            this.actemplab.TabIndex = 29;
            this.actemplab.Text = "AC温度";
            // 
            // inputcurrentlab
            // 
            this.inputcurrentlab.AutoSize = true;
            this.inputcurrentlab.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputcurrentlab.Location = new System.Drawing.Point(18, 63);
            this.inputcurrentlab.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.inputcurrentlab.Name = "inputcurrentlab";
            this.inputcurrentlab.Size = new System.Drawing.Size(85, 19);
            this.inputcurrentlab.TabIndex = 23;
            this.inputcurrentlab.Text = "输入电流";
            // 
            // inputpower
            // 
            this.inputpower.Location = new System.Drawing.Point(121, 141);
            this.inputpower.Name = "inputpower";
            this.inputpower.ReadOnly = true;
            this.inputpower.Size = new System.Drawing.Size(122, 24);
            this.inputpower.TabIndex = 26;
            this.inputpower.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // inputcurrent
            // 
            this.inputcurrent.Location = new System.Drawing.Point(121, 63);
            this.inputcurrent.Name = "inputcurrent";
            this.inputcurrent.ReadOnly = true;
            this.inputcurrent.Size = new System.Drawing.Size(122, 24);
            this.inputcurrent.TabIndex = 22;
            this.inputcurrent.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // acfreqlab
            // 
            this.acfreqlab.AutoSize = true;
            this.acfreqlab.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.acfreqlab.Location = new System.Drawing.Point(18, 102);
            this.acfreqlab.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.acfreqlab.Name = "acfreqlab";
            this.acfreqlab.Size = new System.Drawing.Size(85, 19);
            this.acfreqlab.TabIndex = 25;
            this.acfreqlab.Text = "交流频率";
            // 
            // inputpowlab
            // 
            this.inputpowlab.AutoSize = true;
            this.inputpowlab.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputpowlab.Location = new System.Drawing.Point(18, 141);
            this.inputpowlab.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.inputpowlab.Name = "inputpowlab";
            this.inputpowlab.Size = new System.Drawing.Size(85, 19);
            this.inputpowlab.TabIndex = 27;
            this.inputpowlab.Text = "输入功率";
            // 
            // acfreq
            // 
            this.acfreq.Location = new System.Drawing.Point(122, 102);
            this.acfreq.Name = "acfreq";
            this.acfreq.ReadOnly = true;
            this.acfreq.Size = new System.Drawing.Size(122, 24);
            this.acfreq.TabIndex = 24;
            this.acfreq.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // inputvolt
            // 
            this.inputvolt.Location = new System.Drawing.Point(121, 25);
            this.inputvolt.Name = "inputvolt";
            this.inputvolt.ReadOnly = true;
            this.inputvolt.Size = new System.Drawing.Size(122, 24);
            this.inputvolt.TabIndex = 21;
            // 
            // inputvoltlab
            // 
            this.inputvoltlab.AutoSize = true;
            this.inputvoltlab.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.inputvoltlab.Location = new System.Drawing.Point(18, 26);
            this.inputvoltlab.Margin = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.inputvoltlab.Name = "inputvoltlab";
            this.inputvoltlab.Size = new System.Drawing.Size(85, 19);
            this.inputvoltlab.TabIndex = 20;
            this.inputvoltlab.Text = "输入电压";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(608, 595);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.psudetail);
            this.Controls.Add(this.getcom);
            this.Controls.Add(this.comlist);
            this.Controls.Add(this.cntdev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "鑫谷九重电源";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.psudetail.ResumeLayout(false);
            this.psudetail.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.dcpart.ResumeLayout(false);
            this.dcpart.PerformLayout();
            this.acpart.ResumeLayout(false);
            this.acpart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cntdev;
        private System.Windows.Forms.ComboBox comlist;
        private System.Windows.Forms.Button getcom;
        private System.Windows.Forms.GroupBox psudetail;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label volt;
        private System.Windows.Forms.TextBox verifylevel;
        private System.Windows.Forms.TextBox typedetail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label volt5vlab;
        private System.Windows.Forms.TextBox volt5v;
        private System.Windows.Forms.TextBox volt12v;
        private System.Windows.Forms.Label volt12vlab;
        private System.Windows.Forms.GroupBox dcpart;
        private System.Windows.Forms.Label volt5vsblab;
        private System.Windows.Forms.TextBox volt5vsb;
        private System.Windows.Forms.TextBox volt3v3;
        private System.Windows.Forms.Label volt3v3lab;
        private System.Windows.Forms.GroupBox acpart;
        private System.Windows.Forms.Label inputcurrentlab;
        private System.Windows.Forms.TextBox inputpower;
        private System.Windows.Forms.TextBox inputcurrent;
        private System.Windows.Forms.Label acfreqlab;
        private System.Windows.Forms.Label inputpowlab;
        private System.Windows.Forms.TextBox acfreq;
        private System.Windows.Forms.TextBox inputvolt;
        private System.Windows.Forms.Label inputvoltlab;
        private System.Windows.Forms.Label dctemplab;
        private System.Windows.Forms.TextBox dctemp;
        private System.Windows.Forms.TextBox actemp;
        private System.Windows.Forms.Label actemplab;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label fanmodelab;
        private System.Windows.Forms.TextBox fanmode;
        private System.Windows.Forms.TextBox fanspeed;
        private System.Windows.Forms.Label fanspeedlab;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox errorcode;
        private System.Windows.Forms.Label errorcodelab;
        private System.Windows.Forms.TextBox roomtemp;
        private System.Windows.Forms.Label roomtemplab;
    }
}

