namespace Desafio_BSA
{
    partial class BSA
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BSA));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.btnMakeCall = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConnection = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTransferInit = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnConferenceComplete = new System.Windows.Forms.Button();
            this.btnTransferCancel = new System.Windows.Forms.Button();
            this.btnTransferComplete = new System.Windows.Forms.Button();
            this.btnDropCall = new System.Windows.Forms.Button();
            this.txtPauseCode = new System.Windows.Forms.ComboBox();
            this.btnAlternateCall = new System.Windows.Forms.Button();
            this.btnReady = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAgentPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAgent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnMonitor);
            this.groupBox1.Controls.Add(this.btnMakeCall);
            this.groupBox1.Controls.Add(this.btnEnd);
            this.groupBox1.Controls.Add(this.btnInit);
            this.groupBox1.Controls.Add(this.txtDestination);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtExtension);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtConnection);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(247, 361);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TSAPI Connection";
            // 
            // btnMonitor
            // 
            this.btnMonitor.BackColor = System.Drawing.Color.White;
            this.btnMonitor.Enabled = false;
            this.btnMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonitor.Location = new System.Drawing.Point(143, 262);
            this.btnMonitor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(96, 32);
            this.btnMonitor.TabIndex = 14;
            this.btnMonitor.Text = "Monitor";
            this.btnMonitor.UseVisualStyleBackColor = false;
            this.btnMonitor.EnabledChanged += new System.EventHandler(this.btn_EnabledChanged);
            this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
            // 
            // btnMakeCall
            // 
            this.btnMakeCall.BackColor = System.Drawing.Color.White;
            this.btnMakeCall.Enabled = false;
            this.btnMakeCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeCall.Location = new System.Drawing.Point(143, 310);
            this.btnMakeCall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMakeCall.Name = "btnMakeCall";
            this.btnMakeCall.Size = new System.Drawing.Size(95, 32);
            this.btnMakeCall.TabIndex = 13;
            this.btnMakeCall.Text = "Make Call";
            this.btnMakeCall.UseVisualStyleBackColor = false;
            this.btnMakeCall.EnabledChanged += new System.EventHandler(this.btn_EnabledChanged);
            this.btnMakeCall.Click += new System.EventHandler(this.btnMakeCall_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.White;
            this.btnEnd.Enabled = false;
            this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.Location = new System.Drawing.Point(8, 310);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(96, 32);
            this.btnEnd.TabIndex = 11;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.EnabledChanged += new System.EventHandler(this.btn_EnabledChanged);
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnInit
            // 
            this.btnInit.BackColor = System.Drawing.Color.White;
            this.btnInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInit.Location = new System.Drawing.Point(8, 262);
            this.btnInit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(96, 32);
            this.btnInit.TabIndex = 10;
            this.btnInit.Text = "Init";
            this.btnInit.UseVisualStyleBackColor = false;
            this.btnInit.EnabledChanged += new System.EventHandler(this.btn_EnabledChanged);
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // txtDestination
            // 
            this.txtDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDestination.Location = new System.Drawing.Point(106, 222);
            this.txtDestination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(133, 21);
            this.txtDestination.TabIndex = 9;
            this.txtDestination.Text = "40107";
            this.txtDestination.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Destination:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(93, 176);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(145, 21);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Text = "M1d14v0x@";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password:";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(58, 132);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(181, 21);
            this.txtUser.TabIndex = 5;
            this.txtUser.Text = "ctiuser";
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "User:";
            // 
            // txtExtension
            // 
            this.txtExtension.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtension.Location = new System.Drawing.Point(94, 87);
            this.txtExtension.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(145, 21);
            this.txtExtension.TabIndex = 3;
            this.txtExtension.Text = "40402";
            this.txtExtension.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Extension:";
            // 
            // txtConnection
            // 
            this.txtConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConnection.Location = new System.Drawing.Point(105, 48);
            this.txtConnection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConnection.Name = "txtConnection";
            this.txtConnection.Size = new System.Drawing.Size(135, 21);
            this.txtConnection.TabIndex = 1;
            this.txtConnection.Text = "AVAYA#CM7#CSTA#AESIP84";
            this.txtConnection.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connection:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(12, 438);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 32);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(277, 322);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(511, 148);
            this.listBox1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnTransferInit);
            this.groupBox2.Controls.Add(this.btnStatus);
            this.groupBox2.Controls.Add(this.btnConferenceComplete);
            this.groupBox2.Controls.Add(this.btnTransferCancel);
            this.groupBox2.Controls.Add(this.btnTransferComplete);
            this.groupBox2.Controls.Add(this.btnDropCall);
            this.groupBox2.Controls.Add(this.txtPauseCode);
            this.groupBox2.Controls.Add(this.btnAlternateCall);
            this.groupBox2.Controls.Add(this.btnReady);
            this.groupBox2.Controls.Add(this.btnLogout);
            this.groupBox2.Controls.Add(this.btnAnswer);
            this.groupBox2.Controls.Add(this.btnPause);
            this.groupBox2.Controls.Add(this.btnLogin);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtAgentPassword);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtAgent);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(277, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(511, 294);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agent Control";
            // 
            // btnTransferInit
            // 
            this.btnTransferInit.BackColor = System.Drawing.Color.White;
            this.btnTransferInit.Enabled = false;
            this.btnTransferInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferInit.Location = new System.Drawing.Point(269, 63);
            this.btnTransferInit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTransferInit.Name = "btnTransferInit";
            this.btnTransferInit.Size = new System.Drawing.Size(235, 32);
            this.btnTransferInit.TabIndex = 20;
            this.btnTransferInit.Text = "Transfer Init";
            this.btnTransferInit.UseVisualStyleBackColor = false;
            this.btnTransferInit.EnabledChanged += new System.EventHandler(this.btn_EnabledChanged);
            this.btnTransferInit.Click += new System.EventHandler(this.btnTransferInit_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStatus.BackColor = System.Drawing.Color.Gray;
            this.btnStatus.Enabled = false;
            this.btnStatus.Location = new System.Drawing.Point(120, 0);
            this.btnStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(47, 17);
            this.btnStatus.TabIndex = 18;
            this.btnStatus.UseVisualStyleBackColor = false;
            // 
            // btnConferenceComplete
            // 
            this.btnConferenceComplete.BackColor = System.Drawing.Color.White;
            this.btnConferenceComplete.Enabled = false;
            this.btnConferenceComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConferenceComplete.Location = new System.Drawing.Point(269, 243);
            this.btnConferenceComplete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConferenceComplete.Name = "btnConferenceComplete";
            this.btnConferenceComplete.Size = new System.Drawing.Size(235, 32);
            this.btnConferenceComplete.TabIndex = 18;
            this.btnConferenceComplete.Text = "Conference Complete";
            this.btnConferenceComplete.UseVisualStyleBackColor = false;
            this.btnConferenceComplete.EnabledChanged += new System.EventHandler(this.btn_EnabledChanged);
            this.btnConferenceComplete.Click += new System.EventHandler(this.btnConferenceComplete_Click);
            // 
            // btnTransferCancel
            // 
            this.btnTransferCancel.BackColor = System.Drawing.Color.White;
            this.btnTransferCancel.Enabled = false;
            this.btnTransferCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferCancel.Location = new System.Drawing.Point(269, 154);
            this.btnTransferCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTransferCancel.Name = "btnTransferCancel";
            this.btnTransferCancel.Size = new System.Drawing.Size(235, 32);
            this.btnTransferCancel.TabIndex = 21;
            this.btnTransferCancel.Text = "Transfer Cancel";
            this.btnTransferCancel.UseVisualStyleBackColor = false;
            this.btnTransferCancel.EnabledChanged += new System.EventHandler(this.btn_EnabledChanged);
            this.btnTransferCancel.Click += new System.EventHandler(this.btnTransferCancel_Click);
            // 
            // btnTransferComplete
            // 
            this.btnTransferComplete.BackColor = System.Drawing.Color.White;
            this.btnTransferComplete.Enabled = false;
            this.btnTransferComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferComplete.Location = new System.Drawing.Point(269, 107);
            this.btnTransferComplete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTransferComplete.Name = "btnTransferComplete";
            this.btnTransferComplete.Size = new System.Drawing.Size(235, 32);
            this.btnTransferComplete.TabIndex = 16;
            this.btnTransferComplete.Text = "Transfer Complete";
            this.btnTransferComplete.UseVisualStyleBackColor = false;
            this.btnTransferComplete.EnabledChanged += new System.EventHandler(this.btn_EnabledChanged);
            this.btnTransferComplete.Click += new System.EventHandler(this.btnTransferComplete_Click);
            // 
            // btnDropCall
            // 
            this.btnDropCall.BackColor = System.Drawing.Color.White;
            this.btnDropCall.Enabled = false;
            this.btnDropCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDropCall.Location = new System.Drawing.Point(397, 22);
            this.btnDropCall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDropCall.Name = "btnDropCall";
            this.btnDropCall.Size = new System.Drawing.Size(107, 32);
            this.btnDropCall.TabIndex = 19;
            this.btnDropCall.Text = "Drop Call";
            this.btnDropCall.UseVisualStyleBackColor = false;
            this.btnDropCall.EnabledChanged += new System.EventHandler(this.btn_EnabledChanged);
            this.btnDropCall.Click += new System.EventHandler(this.btnDropCall_Click);
            // 
            // txtPauseCode
            // 
            this.txtPauseCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPauseCode.FormattingEnabled = true;
            this.txtPauseCode.Location = new System.Drawing.Point(108, 160);
            this.txtPauseCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPauseCode.Name = "txtPauseCode";
            this.txtPauseCode.Size = new System.Drawing.Size(144, 23);
            this.txtPauseCode.TabIndex = 17;
            // 
            // btnAlternateCall
            // 
            this.btnAlternateCall.BackColor = System.Drawing.Color.White;
            this.btnAlternateCall.Enabled = false;
            this.btnAlternateCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlternateCall.Location = new System.Drawing.Point(269, 197);
            this.btnAlternateCall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlternateCall.Name = "btnAlternateCall";
            this.btnAlternateCall.Size = new System.Drawing.Size(235, 32);
            this.btnAlternateCall.TabIndex = 17;
            this.btnAlternateCall.Text = "Alternate Call";
            this.btnAlternateCall.UseVisualStyleBackColor = false;
            this.btnAlternateCall.EnabledChanged += new System.EventHandler(this.btn_EnabledChanged);
            this.btnAlternateCall.Click += new System.EventHandler(this.btnAlternateCall_Click);
            // 
            // btnReady
            // 
            this.btnReady.BackColor = System.Drawing.Color.White;
            this.btnReady.Enabled = false;
            this.btnReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReady.Location = new System.Drawing.Point(10, 243);
            this.btnReady.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(97, 32);
            this.btnReady.TabIndex = 16;
            this.btnReady.Text = "Ready";
            this.btnReady.UseVisualStyleBackColor = false;
            this.btnReady.EnabledChanged += new System.EventHandler(this.btn_EnabledChanged);
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.Enabled = false;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(159, 243);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(93, 32);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.EnabledChanged += new System.EventHandler(this.btn_EnabledChanged);
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAnswer
            // 
            this.btnAnswer.BackColor = System.Drawing.Color.White;
            this.btnAnswer.Enabled = false;
            this.btnAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer.Location = new System.Drawing.Point(269, 22);
            this.btnAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(105, 32);
            this.btnAnswer.TabIndex = 15;
            this.btnAnswer.Text = "Answer";
            this.btnAnswer.UseVisualStyleBackColor = false;
            this.btnAnswer.EnabledChanged += new System.EventHandler(this.btn_EnabledChanged);
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.White;
            this.btnPause.Enabled = false;
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(159, 197);
            this.btnPause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(93, 32);
            this.btnPause.TabIndex = 14;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.EnabledChanged += new System.EventHandler(this.btn_EnabledChanged);
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.Enabled = false;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(10, 197);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(97, 32);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.EnabledChanged += new System.EventHandler(this.btn_EnabledChanged);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Pause Code:";
            // 
            // txtAgentPassword
            // 
            this.txtAgentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgentPassword.Location = new System.Drawing.Point(90, 113);
            this.txtAgentPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAgentPassword.Name = "txtAgentPassword";
            this.txtAgentPassword.PasswordChar = '*';
            this.txtAgentPassword.Size = new System.Drawing.Size(162, 21);
            this.txtAgentPassword.TabIndex = 14;
            this.txtAgentPassword.Text = "1234";
            this.txtAgentPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Password:";
            // 
            // txtAgent
            // 
            this.txtAgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgent.Location = new System.Drawing.Point(68, 69);
            this.txtAgent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAgent.Name = "txtAgent";
            this.txtAgent.Size = new System.Drawing.Size(184, 21);
            this.txtAgent.TabIndex = 14;
            this.txtAgent.Text = "50402";
            this.txtAgent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Agent:";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(166, 438);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 32);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // BSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::Desafio_BSA.Properties.Resources.pxfuel11;
            this.ClientSize = new System.Drawing.Size(802, 485);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BSA";
            this.Text = "BSA";
            this.Load += new System.EventHandler(this.BSA_Load);
            this.EnabledChanged += new System.EventHandler(this.btn_EnabledChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConnection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAgent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAgentPassword;
        private System.Windows.Forms.ComboBox txtPauseCode;
        public System.Windows.Forms.Button btnEnd;
        public System.Windows.Forms.Button btnMakeCall;
        public System.Windows.Forms.Button btnReady;
        public System.Windows.Forms.Button btnLogout;
        public System.Windows.Forms.Button btnPause;
        public System.Windows.Forms.Button btnLogin;
        public System.Windows.Forms.Button btnStatus;
        public System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button btnInit;
        public System.Windows.Forms.Button btnTransferCancel;
        public System.Windows.Forms.Button btnTransferInit;
        public System.Windows.Forms.Button btnDropCall;
        public System.Windows.Forms.Button btnConferenceComplete;
        public System.Windows.Forms.Button btnAlternateCall;
        public System.Windows.Forms.Button btnTransferComplete;
        public System.Windows.Forms.Button btnAnswer;
    }
}

