namespace LoginScreen
{
    public partial class Form1 : Form
    {
        int failCount = 0; // 로그인 실패 횟수 저장
        bool isLocked = false; // 잠금 여부
        int lockSeconds = 10; // 잠금 시간(초)
        private System.Windows.Forms.Timer lockTimer = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();

            lockTimer.Interval = 1000; // 1초마다 실행
            lockTimer.Tick += LockTimer_Tick;

        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "아이디")
            {
                txtID.Text = "";
                txtID.ForeColor = Color.Black;
            }
        }

        private void txtPW_Enter(object sender, EventArgs e)
        {
            if (txtPW.Text == "패스워드")
            {
                txtPW.Text = "";
                txtPW.ForeColor = Color.Black;
                txtPW.UseSystemPasswordChar = true;
            }
        }

        private void txtPW_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPW.Text))
            {
                txtPW.UseSystemPasswordChar = false;
                txtPW.Text = "패스워드";
                txtPW.ForeColor = Color.Silver;
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                txtID.Text = "아이디";
                txtID.ForeColor = Color.Silver;
            }
        }

        string myID = "admin";
        string myPW = "superman";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isLocked)
            {
                MessageBox.Show("현재 로그인 시도가 잠겨 있습니다. 잠시 후 다시 시도하세요.");
                return;
            }

            string inputID = txtID.Text;
            string inputPW = txtPW.Text;

            // 비밀번호 길이 검사
            if (inputPW.Length < 8)
            {
                lblerror.Text = "비밀번호는 8자 이상이어야 합니다.";
                lblerror.Visible = true;
                return;
            }

            if (inputID == myID && inputPW == myPW)
            {
                MessageBox.Show("로그인성공!");
                lblErrorMsg.Visible = false;
                failCount = 0; // 성공 시 실패 횟수 초기화
            }
            else
            {
                lblErrorMsg.Visible = true;
                failCount++;

                if (failCount >= 5)
                {
                    MessageBox.Show("로그인을 5번 실패하셨습니다. 10초 동안 로그인이 제한됩니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // 잠금 시작
                    isLocked = true;
                    lockSeconds = 10;
                    lockTimer.Start();

                    // 비밀번호창 초기화 및 빨간 글씨로 카운트다운 표시
                    txtPW.UseSystemPasswordChar = false;
                    txtPW.Text = lockSeconds.ToString() + "초 후 다시 시도하세요";
                    txtPW.ForeColor = Color.Red;
                }
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // 기본비프음방지
                txtPW.Focus(); // 패스워드입력창이포커스를갖게끔
            }
        }

        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // 기본비프음방지
                btnLogin.PerformClick(); // 버튼이눌린것처럼만들기
            }
        }

        private void label1_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // 아이디 초기화
            txtID.Text = "아이디";
            txtID.ForeColor = Color.Silver;

            // 패스워드 초기화
            txtPW.UseSystemPasswordChar = false;
            txtPW.Text = "패스워드";
            txtPW.ForeColor = Color.Silver;

            // 에러 메시지도 숨기기
            lblErrorMsg.Visible = false;

        }

        private void btnvisible_Click(object sender, EventArgs e)
        {
            // 현재 상태 반대로 토글
            txtPW.UseSystemPasswordChar = !txtPW.UseSystemPasswordChar;
        }
        private void LockTimer_Tick(object sender, EventArgs e)
        {
            lockSeconds--;

            if (lockSeconds > 0)
            {
                txtPW.Text = lockSeconds.ToString() + "초 후 다시 시도하세요";
            }
            else
            {
                // 잠금 해제
                lockTimer.Stop();
                isLocked = false;
                failCount = 0;

                // 비밀번호창 초기화
                txtPW.Text = "패스워드";
                txtPW.ForeColor = Color.Silver;
                txtPW.UseSystemPasswordChar = false;
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 한글 입력 차단
            if (char.GetUnicodeCategory(e.KeyChar) == System.Globalization.UnicodeCategory.OtherLetter)
            {
                e.Handled = true; // 입력 무효화
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
