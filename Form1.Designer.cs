namespace LoginScreen
{
    partial class Form1
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
            lblAppName = new Label();
            txtPW = new TextBox();
            btnLogin = new Button();
            txtID = new TextBox();
            lblErrorMsg = new Label();
            btnRemove = new Button();
            btnvisible = new Button();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("휴먼둥근헤드라인", 48F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.Location = new Point(146, 40);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(465, 134);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Login";
            // 
            // txtPW
            // 
            txtPW.Font = new Font("맑은 고딕", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtPW.ForeColor = Color.Silver;
            txtPW.Location = new Point(112, 375);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(508, 107);
            txtPW.TabIndex = 3;
            txtPW.Text = "패스워드";
            txtPW.Enter += txtPW_Enter;
            txtPW.KeyDown += txtPW_KeyDown;
            txtPW.Leave += txtPW_Leave;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("맑은 고딕", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnLogin.Location = new Point(235, 579);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(255, 82);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtID
            // 
            txtID.Font = new Font("맑은 고딕", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtID.ForeColor = Color.Silver;
            txtID.Location = new Point(112, 242);
            txtID.Name = "txtID";
            txtID.Size = new Size(508, 107);
            txtID.TabIndex = 2;
            txtID.Text = "아이디";
            txtID.Enter += txtID_Enter;
            txtID.KeyDown += txtID_KeyDown;
            txtID.KeyPress += txtID_KeyPress;
            txtID.Leave += txtID_Leave;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.ForeColor = Color.Red;
            lblErrorMsg.Location = new Point(146, 496);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(438, 36);
            lblErrorMsg.TabIndex = 5;
            lblErrorMsg.Text = "ID 또는 비밀번호가 잘못되었습니다.";
            lblErrorMsg.Visible = false;
            lblErrorMsg.VisibleChanged += label1_VisibleChanged;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnRemove.Location = new Point(579, 496);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(178, 67);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "모두 삭제";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnvisible
            // 
            btnvisible.Font = new Font("나눔고딕 ExtraBold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnvisible.Location = new Point(641, 416);
            btnvisible.Name = "btnvisible";
            btnvisible.Size = new Size(107, 56);
            btnvisible.TabIndex = 7;
            btnvisible.Text = "보이기";
            btnvisible.UseVisualStyleBackColor = true;
            btnvisible.Click += btnvisible_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 36F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 741);
            Controls.Add(btnvisible);
            Controls.Add(btnRemove);
            Controls.Add(lblErrorMsg);
            Controls.Add(txtID);
            Controls.Add(btnLogin);
            Controls.Add(txtPW);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Login Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private TextBox txtPW;
        private Button btnLogin;
        private TextBox txtID;
        private Label lblErrorMsg;
        private Button btnRemove;
        private Button btnvisible;
    }
}
