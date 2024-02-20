using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_BSA
{
    public partial class BSA : Form
    {
        clCTI mCTI;

        string Calling;

        public BSA()
        {
            InitializeComponent();
            mCTI = new clCTI();
            mCTI.ParentForm = this;

            mCTI.InitOk += MCTI_InitOk;
            mCTI.MonitorOk += MCTI_MonitorOk;
            mCTI.CallOk += MCTI_CallOk;
            mCTI.Delivered += MCTI_Delivered;
            mCTI.ConnectedCall += MCTI_ConnectedCall;
            mCTI.LoginOk += MCTI_LogInOk;
            mCTI.PauseOk += MCTI_PauseOk;
            mCTI.ReadyOk += MCTI_ReadyOk;
            mCTI.Logout += MCTI_LogOut;
            mCTI.Disconnect += MCTI_Disconnect;
            mCTI.CallCleared += MCTI_DisconnectedCall;
            mCTI.AnswerCallConf += MCTI_AnswerCallConf;
            mCTI.ConsultationCallConf += MCTI_ConsultationCallConf;
            mCTI.TransferCallConf += MCTI_TransferCallConf;
            mCTI.Retrieved += MCTI_Retrieved;
            mCTI.Held += MCTI_Held;
            mCTI.AlternateCallConf += MCTI_AlternateCallConf;
            mCTI.ConnectionCleared += MCTI_ConnectionCleared;
            mCTI.ConferenceCompleteConf += MCTI_ConferenceCompleteConf;

            mCTI.InitFailed += MCTI_InitFailed;
            mCTI.Failure += MCTI_Failure;

            txtPauseCode.Items.AddRange(new object[]
            {
                "1 - Lanche", "2 - Almoço",
                "3 - Banheiro", "4 - Descanso",
                "5 - Reunião", "6 - Treinamento"
            });
            txtPauseCode.SelectedIndex = 0;
        }

        #region Events

        private void MCTI_InitOk()
        {
            listBox1.Items.Add("Inicialização concluída.");
            btnInit.Enabled = false;
            btnMonitor.Enabled = true;
            btnEnd.Enabled = true;
        }

        private void MCTI_InitFailed()
        {
            listBox1.Items.Add("Inicialização falhou.");
        }

        private void MCTI_MonitorOk()
        {
            listBox1.Items.Add("Monitoramento funcionou.");
            btnMonitor.Enabled = false;
            btnLogin.Enabled = true;
        }

        private void MCTI_Disconnect()
        {
            listBox1.Items.Add("Conexão encerrada.");
            btnEnd.Enabled = false;
            btnLogin.Enabled = false;
            btnMonitor.Enabled = false;
            btnInit.Enabled = true;
        }

        private void MCTI_CallOk()
        {
            listBox1.Items.Add("Ligando para: " + txtDestination.Text + ".");
            btnMakeCall.Enabled = false;
        }

        private void MCTI_Delivered(string Calling)
        {
            this.Calling = Calling;
            listBox1.Items.Add("> Dispositivo " + Calling + " chamando...");
            if (btnMakeCall.Enabled)
            {
                btnAnswer.Enabled = true;
            }
        }

        private void MCTI_ConnectedCall()
        {
            btnStatus.BackColor = Color.Red;
            listBox1.Items.Add("Chamada conectada.");
            if (!btnTransferComplete.Enabled)
            {
                btnAnswer.Enabled = false;
                btnMakeCall.Enabled = false;
                btnDropCall.Enabled = true;
                btnTransferInit.Enabled = true;
            }
        }

        //desuso
        private void MCTI_DisconnectedCall(int CallID, string Device, int Cause, int Reason)
        {
            btnStatus.BackColor = Color.DarkGreen;
            listBox1.Items.Add("Chamada desconectada");
        }

        private void MCTI_ConnectionCleared(int CallID, string RealeasingDevice, string Device, int Cause)
        {
            btnStatus.BackColor = Color.DarkGreen;
            listBox1.Items.Add("Chamada desconectada no: " + Device);

            if (btnTransferInit.Enabled)
            {
                btnMakeCall.Enabled = true;
                btnDropCall.Enabled = false;
                btnTransferInit.Enabled = false;
            }
            else if(btnConferenceComplete.Enabled)
            {
                btnAnswer.Enabled = true;
                btnMakeCall.Enabled = false;
                btnTransferComplete.Enabled = false;
                btnTransferCancel.Enabled = false;
                btnAlternateCall.Enabled = false;
                btnConferenceComplete.Enabled = false;
            }
            else if(!btnAnswer.Enabled)
            {
                btnMakeCall.Enabled = true;
                btnDropCall.Enabled = false;
            }
            else
            {
                btnAnswer.Enabled = false;
            }
        }

        private void MCTI_AnswerCallConf(int InvokeID)
        {
            listBox1.Items.Add("> Chamada atendida.");
            btnAnswer.Enabled = false;
        }

        private void MCTI_ConsultationCallConf(int CallID)
        {
            listBox1.Items.Add("Transferência com CallID: " + CallID + ".");
            btnTransferInit.Enabled = false;
            btnTransferCancel.Enabled = true;
            btnTransferComplete.Enabled = true;
            btnAlternateCall.Enabled = true;
            btnConferenceComplete.Enabled = true;
        }

        private void MCTI_TransferCallConf(int InvokeID, int CallID, string Device)
        {
            btnStatus.BackColor = Color.DarkGreen;
            listBox1.Items.Add("Transferência realizada.");
            btnMakeCall.Enabled = true;
            btnDropCall.Enabled = false;
            btnTransferCancel.Enabled = false;
            btnTransferComplete.Enabled = false;
            btnAlternateCall.Enabled = false;
            btnConferenceComplete.Enabled = false;
        }

        private void MCTI_Retrieved(int CallID, string Device, string RetrievedDevice, int Cause)
        {
            listBox1.Items.Add("Chamada recuperada em: " + RetrievedDevice);
            btnStatus.BackColor = Color.Red;
            btnAnswer.Enabled = false;
            if (!btnAlternateCall.Enabled)
            {
                btnDropCall.Enabled = true;
                btnTransferInit.Enabled = true;
            }
        }

        private void MCTI_Held(int CallID, string Device, string HoldingDevice, int Cause)
        {
            listBox1.Items.Add("Dispositivo em espera: " + HoldingDevice);
        }

        private void MCTI_AlternateCallConf(int InvokeID)
        {
            listBox1.Items.Add("Chamada alternada");
        }

        private void MCTI_ConferenceCompleteConf(string Device)
        {
            listBox1.Items.Add("Conferência iniciada com: " + Device);
            btnTransferCancel.Enabled = false;
            btnTransferComplete.Enabled = false;
            btnAlternateCall.Enabled = false;
            btnConferenceComplete.Enabled = false;
        }

        private void MCTI_LogInOk()
        {
            listBox1.Items.Add("Agente conectado.");
            btnStatus.BackColor = Color.Gold;
            btnLogin.Enabled = false;
            btnReady.Enabled = true;
            btnLogout.Enabled = true;
            btnMakeCall.Enabled = true;
        }

        private void MCTI_LogOut()
        {
            listBox1.Items.Add("Agente desconectado.");
            btnStatus.BackColor = Color.Gray;
            btnLogout.Enabled = false;
            btnPause.Enabled = false;
            btnReady.Enabled = false;
            btnLogin.Enabled = true;
            btnMakeCall.Enabled = false;
        }

        private void MCTI_PauseOk()
        {
            listBox1.Items.Add("Agente indisponível: " + txtPauseCode.Text + ".");
            btnStatus.BackColor = Color.Gold;
            btnPause.Enabled = false;
            btnReady.Enabled = true;
        }

        private void MCTI_ReadyOk()
        {
            listBox1.Items.Add("Agente disponível.");
            btnStatus.BackColor = Color.DarkGreen;
            btnPause.Enabled = true;
            btnReady.Enabled = false;
        }

        private void MCTI_Failure()
        {
            listBox1.Items.Add("Não foi possível concluir a operação.");
        }

        private void btn_EnabledChanged(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            btn.ForeColor = btn.Enabled == true ? Color.Red : Color.White;
        }

        private void BSA_Load(object sender, EventArgs e)
        {
            btn_EnabledChanged(btnInit, e);
        }

        #endregion

        #region Methods

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            mCTI.Init(txtConnection.Text, txtUser.Text, txtPassword.Text, txtExtension.Text);
            listBox1.Items.Add("Botão INIT clicado.");
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            mCTI.End();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            mCTI.End();
            Application.Exit();
        }

        private void btnMonitor_Click(object sender, EventArgs e)
        {
            mCTI.Monitor();
        }

        private void btnMakeCall_Click(object sender, EventArgs e)
        {
            mCTI.MakeCall(txtDestination.Text);
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            mCTI.AnswerCall();
        }

        private void btnTransferInit_Click(object sender, EventArgs e)
        {
            mCTI.TransferInit(txtDestination.Text);
        }

        private void btnTransferComplete_Click(object sender, EventArgs e)
        {
            mCTI.TransferCall();
        }

        private void btnTransferCancel_Click(object sender, EventArgs e)
        {
            mCTI.TransferCancel();
        }

        private void btnAlternateCall_Click(object sender, EventArgs e)
        {
            mCTI.AlternateCall();
        }

        private void btnConferenceComplete_Click(object sender, EventArgs e)
        {
            mCTI.ConferenceComplete();
        }

        private void btnDropCall_Click(object sender, EventArgs e)
        {
            mCTI.CallClear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            mCTI.LogIn(txtAgent.Text, txtAgentPassword.Text);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            mCTI.LogOut();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            mCTI.Pause(txtPauseCode.Text);
        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            mCTI.Ready();
        }

        #endregion
    }
}