namespace CompanyManagement
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelCompany = new System.Windows.Forms.Label();
            this.buttonCompanyAdd = new System.Windows.Forms.Button();
            this.buttonCompanyUpdate = new System.Windows.Forms.Button();
            this.buttonCompanyDelete = new System.Windows.Forms.Button();
            this.dataGridViewCompany = new System.Windows.Forms.DataGridView();
            this.ColumnNameCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhoneCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddressCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textCompanyName = new System.Windows.Forms.TextBox();
            this.textCompanyPhone = new System.Windows.Forms.TextBox();
            this.textCompanyAddress = new System.Windows.Forms.TextBox();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.labelCompanyPhone = new System.Windows.Forms.Label();
            this.labelCompanyAddress = new System.Windows.Forms.Label();
            this.labelWorkerAddress = new System.Windows.Forms.Label();
            this.labelWorkerPhone = new System.Windows.Forms.Label();
            this.labelWorkerName = new System.Windows.Forms.Label();
            this.textWorkerAddress = new System.Windows.Forms.TextBox();
            this.textWorkerPhone = new System.Windows.Forms.TextBox();
            this.textWorkerName = new System.Windows.Forms.TextBox();
            this.dataGridViewWorker = new System.Windows.Forms.DataGridView();
            this.ColumnNameWorker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhoneWorker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddressWorker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonWorkerDelete = new System.Windows.Forms.Button();
            this.buttonWorkerUpdate = new System.Windows.Forms.Button();
            this.buttonWorkerAdd = new System.Windows.Forms.Button();
            this.labelWorker = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorker)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCompany
            // 
            this.labelCompany.AutoSize = true;
            this.labelCompany.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.labelCompany.Location = new System.Drawing.Point(21, 18);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(82, 16);
            this.labelCompany.TabIndex = 0;
            this.labelCompany.Text = "회사 선택";
            // 
            // buttonCompanyAdd
            // 
            this.buttonCompanyAdd.Location = new System.Drawing.Point(347, 524);
            this.buttonCompanyAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCompanyAdd.Name = "buttonCompanyAdd";
            this.buttonCompanyAdd.Size = new System.Drawing.Size(89, 26);
            this.buttonCompanyAdd.TabIndex = 2;
            this.buttonCompanyAdd.Text = "추 가";
            this.buttonCompanyAdd.UseVisualStyleBackColor = true;
            this.buttonCompanyAdd.Click += new System.EventHandler(this.buttonCompanyAdd_Click);
            // 
            // buttonCompanyUpdate
            // 
            this.buttonCompanyUpdate.Location = new System.Drawing.Point(347, 556);
            this.buttonCompanyUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCompanyUpdate.Name = "buttonCompanyUpdate";
            this.buttonCompanyUpdate.Size = new System.Drawing.Size(89, 26);
            this.buttonCompanyUpdate.TabIndex = 3;
            this.buttonCompanyUpdate.Text = "수 정";
            this.buttonCompanyUpdate.UseVisualStyleBackColor = true;
            this.buttonCompanyUpdate.Click += new System.EventHandler(this.buttonCompanyUpdate_Click);
            // 
            // buttonCompanyDelete
            // 
            this.buttonCompanyDelete.Location = new System.Drawing.Point(347, 590);
            this.buttonCompanyDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCompanyDelete.Name = "buttonCompanyDelete";
            this.buttonCompanyDelete.Size = new System.Drawing.Size(89, 26);
            this.buttonCompanyDelete.TabIndex = 4;
            this.buttonCompanyDelete.Text = "삭 제";
            this.buttonCompanyDelete.UseVisualStyleBackColor = true;
            this.buttonCompanyDelete.Click += new System.EventHandler(this.buttonCompanyDelete_Click);
            // 
            // dataGridViewCompany
            // 
            this.dataGridViewCompany.AllowUserToAddRows = false;
            this.dataGridViewCompany.AllowUserToDeleteRows = false;
            this.dataGridViewCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompany.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNameCompany,
            this.ColumnPhoneCompany,
            this.ColumnAddressCompany});
            this.dataGridViewCompany.Location = new System.Drawing.Point(23, 58);
            this.dataGridViewCompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewCompany.Name = "dataGridViewCompany";
            this.dataGridViewCompany.ReadOnly = true;
            this.dataGridViewCompany.RowTemplate.Height = 27;
            this.dataGridViewCompany.Size = new System.Drawing.Size(412, 452);
            this.dataGridViewCompany.TabIndex = 11;
            this.dataGridViewCompany.SelectionChanged += new System.EventHandler(this.dataGridViewCompany_SelectionChanged);
            // 
            // ColumnNameCompany
            // 
            this.ColumnNameCompany.HeaderText = "회사명";
            this.ColumnNameCompany.Name = "ColumnNameCompany";
            this.ColumnNameCompany.ReadOnly = true;
            // 
            // ColumnPhoneCompany
            // 
            this.ColumnPhoneCompany.HeaderText = "연락처";
            this.ColumnPhoneCompany.Name = "ColumnPhoneCompany";
            this.ColumnPhoneCompany.ReadOnly = true;
            // 
            // ColumnAddressCompany
            // 
            this.ColumnAddressCompany.HeaderText = "주 소";
            this.ColumnAddressCompany.Name = "ColumnAddressCompany";
            this.ColumnAddressCompany.ReadOnly = true;
            this.ColumnAddressCompany.Width = 150;
            // 
            // textCompanyName
            // 
            this.textCompanyName.Location = new System.Drawing.Point(80, 529);
            this.textCompanyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCompanyName.Name = "textCompanyName";
            this.textCompanyName.Size = new System.Drawing.Size(245, 21);
            this.textCompanyName.TabIndex = 13;
            // 
            // textCompanyPhone
            // 
            this.textCompanyPhone.Location = new System.Drawing.Point(80, 561);
            this.textCompanyPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCompanyPhone.Name = "textCompanyPhone";
            this.textCompanyPhone.Size = new System.Drawing.Size(245, 21);
            this.textCompanyPhone.TabIndex = 13;
            // 
            // textCompanyAddress
            // 
            this.textCompanyAddress.Location = new System.Drawing.Point(80, 594);
            this.textCompanyAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCompanyAddress.Name = "textCompanyAddress";
            this.textCompanyAddress.Size = new System.Drawing.Size(245, 21);
            this.textCompanyAddress.TabIndex = 13;
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Location = new System.Drawing.Point(22, 533);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(41, 12);
            this.labelCompanyName.TabIndex = 14;
            this.labelCompanyName.Text = "회사명";
            // 
            // labelCompanyPhone
            // 
            this.labelCompanyPhone.AutoSize = true;
            this.labelCompanyPhone.Location = new System.Drawing.Point(22, 565);
            this.labelCompanyPhone.Name = "labelCompanyPhone";
            this.labelCompanyPhone.Size = new System.Drawing.Size(41, 12);
            this.labelCompanyPhone.TabIndex = 15;
            this.labelCompanyPhone.Text = "연락처";
            // 
            // labelCompanyAddress
            // 
            this.labelCompanyAddress.AutoSize = true;
            this.labelCompanyAddress.Location = new System.Drawing.Point(22, 597);
            this.labelCompanyAddress.Name = "labelCompanyAddress";
            this.labelCompanyAddress.Size = new System.Drawing.Size(33, 12);
            this.labelCompanyAddress.TabIndex = 16;
            this.labelCompanyAddress.Text = "주 소";
            // 
            // labelWorkerAddress
            // 
            this.labelWorkerAddress.AutoSize = true;
            this.labelWorkerAddress.Location = new System.Drawing.Point(473, 597);
            this.labelWorkerAddress.Name = "labelWorkerAddress";
            this.labelWorkerAddress.Size = new System.Drawing.Size(33, 12);
            this.labelWorkerAddress.TabIndex = 27;
            this.labelWorkerAddress.Text = "주 소";
            // 
            // labelWorkerPhone
            // 
            this.labelWorkerPhone.AutoSize = true;
            this.labelWorkerPhone.Location = new System.Drawing.Point(473, 565);
            this.labelWorkerPhone.Name = "labelWorkerPhone";
            this.labelWorkerPhone.Size = new System.Drawing.Size(41, 12);
            this.labelWorkerPhone.TabIndex = 26;
            this.labelWorkerPhone.Text = "연락처";
            // 
            // labelWorkerName
            // 
            this.labelWorkerName.AutoSize = true;
            this.labelWorkerName.Location = new System.Drawing.Point(473, 533);
            this.labelWorkerName.Name = "labelWorkerName";
            this.labelWorkerName.Size = new System.Drawing.Size(33, 12);
            this.labelWorkerName.TabIndex = 25;
            this.labelWorkerName.Text = "이 름";
            // 
            // textWorkerAddress
            // 
            this.textWorkerAddress.Location = new System.Drawing.Point(532, 594);
            this.textWorkerAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textWorkerAddress.Name = "textWorkerAddress";
            this.textWorkerAddress.Size = new System.Drawing.Size(245, 21);
            this.textWorkerAddress.TabIndex = 23;
            // 
            // textWorkerPhone
            // 
            this.textWorkerPhone.Location = new System.Drawing.Point(532, 562);
            this.textWorkerPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textWorkerPhone.Name = "textWorkerPhone";
            this.textWorkerPhone.Size = new System.Drawing.Size(245, 21);
            this.textWorkerPhone.TabIndex = 24;
            // 
            // textWorkerName
            // 
            this.textWorkerName.Location = new System.Drawing.Point(532, 529);
            this.textWorkerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textWorkerName.Name = "textWorkerName";
            this.textWorkerName.Size = new System.Drawing.Size(245, 21);
            this.textWorkerName.TabIndex = 22;
            // 
            // dataGridViewWorker
            // 
            this.dataGridViewWorker.AllowUserToAddRows = false;
            this.dataGridViewWorker.AllowUserToDeleteRows = false;
            this.dataGridViewWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorker.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNameWorker,
            this.ColumnPhoneWorker,
            this.ColumnAddressWorker});
            this.dataGridViewWorker.Location = new System.Drawing.Point(476, 58);
            this.dataGridViewWorker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewWorker.Name = "dataGridViewWorker";
            this.dataGridViewWorker.ReadOnly = true;
            this.dataGridViewWorker.RowTemplate.Height = 27;
            this.dataGridViewWorker.Size = new System.Drawing.Size(412, 452);
            this.dataGridViewWorker.TabIndex = 21;
            this.dataGridViewWorker.SelectionChanged += new System.EventHandler(this.dataGridViewWorker_SelectionChanged);
            // 
            // ColumnNameWorker
            // 
            this.ColumnNameWorker.HeaderText = "이 름";
            this.ColumnNameWorker.Name = "ColumnNameWorker";
            this.ColumnNameWorker.ReadOnly = true;
            // 
            // ColumnPhoneWorker
            // 
            this.ColumnPhoneWorker.HeaderText = "연락처";
            this.ColumnPhoneWorker.Name = "ColumnPhoneWorker";
            this.ColumnPhoneWorker.ReadOnly = true;
            // 
            // ColumnAddressWorker
            // 
            this.ColumnAddressWorker.HeaderText = "주 소";
            this.ColumnAddressWorker.Name = "ColumnAddressWorker";
            this.ColumnAddressWorker.ReadOnly = true;
            this.ColumnAddressWorker.Width = 150;
            // 
            // buttonWorkerDelete
            // 
            this.buttonWorkerDelete.Location = new System.Drawing.Point(799, 590);
            this.buttonWorkerDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonWorkerDelete.Name = "buttonWorkerDelete";
            this.buttonWorkerDelete.Size = new System.Drawing.Size(89, 26);
            this.buttonWorkerDelete.TabIndex = 20;
            this.buttonWorkerDelete.Text = "삭 제";
            this.buttonWorkerDelete.UseVisualStyleBackColor = true;
            this.buttonWorkerDelete.Click += new System.EventHandler(this.buttonWorkerDelete_Click);
            // 
            // buttonWorkerUpdate
            // 
            this.buttonWorkerUpdate.Location = new System.Drawing.Point(799, 556);
            this.buttonWorkerUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonWorkerUpdate.Name = "buttonWorkerUpdate";
            this.buttonWorkerUpdate.Size = new System.Drawing.Size(89, 26);
            this.buttonWorkerUpdate.TabIndex = 19;
            this.buttonWorkerUpdate.Text = "수 정";
            this.buttonWorkerUpdate.UseVisualStyleBackColor = true;
            this.buttonWorkerUpdate.Click += new System.EventHandler(this.buttonWorkerUpdate_Click);
            // 
            // buttonWorkerAdd
            // 
            this.buttonWorkerAdd.Location = new System.Drawing.Point(799, 524);
            this.buttonWorkerAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonWorkerAdd.Name = "buttonWorkerAdd";
            this.buttonWorkerAdd.Size = new System.Drawing.Size(89, 26);
            this.buttonWorkerAdd.TabIndex = 18;
            this.buttonWorkerAdd.Text = "추 가";
            this.buttonWorkerAdd.UseVisualStyleBackColor = true;
            this.buttonWorkerAdd.Click += new System.EventHandler(this.buttonWorkerAdd_Click);
            // 
            // labelWorker
            // 
            this.labelWorker.AutoSize = true;
            this.labelWorker.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.labelWorker.Location = new System.Drawing.Point(474, 18);
            this.labelWorker.Name = "labelWorker";
            this.labelWorker.Size = new System.Drawing.Size(42, 16);
            this.labelWorker.TabIndex = 17;
            this.labelWorker.Text = "사원";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(787, 10);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(102, 36);
            this.buttonSave.TabIndex = 28;
            this.buttonSave.Text = "변경 내용\r\n저장하기";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 630);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelWorkerAddress);
            this.Controls.Add(this.labelWorkerPhone);
            this.Controls.Add(this.labelWorkerName);
            this.Controls.Add(this.textWorkerAddress);
            this.Controls.Add(this.textWorkerPhone);
            this.Controls.Add(this.textWorkerName);
            this.Controls.Add(this.dataGridViewWorker);
            this.Controls.Add(this.buttonWorkerDelete);
            this.Controls.Add(this.buttonWorkerUpdate);
            this.Controls.Add(this.buttonWorkerAdd);
            this.Controls.Add(this.labelWorker);
            this.Controls.Add(this.labelCompanyAddress);
            this.Controls.Add(this.labelCompanyPhone);
            this.Controls.Add(this.labelCompanyName);
            this.Controls.Add(this.textCompanyAddress);
            this.Controls.Add(this.textCompanyPhone);
            this.Controls.Add(this.textCompanyName);
            this.Controls.Add(this.dataGridViewCompany);
            this.Controls.Add(this.buttonCompanyDelete);
            this.Controls.Add(this.buttonCompanyUpdate);
            this.Controls.Add(this.buttonCompanyAdd);
            this.Controls.Add(this.labelCompany);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "사원 관리";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.Button buttonCompanyAdd;
        private System.Windows.Forms.Button buttonCompanyUpdate;
        private System.Windows.Forms.Button buttonCompanyDelete;
        private System.Windows.Forms.DataGridView dataGridViewCompany;
        private System.Windows.Forms.TextBox textCompanyName;
        private System.Windows.Forms.TextBox textCompanyPhone;
        private System.Windows.Forms.TextBox textCompanyAddress;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Label labelCompanyPhone;
        private System.Windows.Forms.Label labelCompanyAddress;
        private System.Windows.Forms.Label labelWorkerAddress;
        private System.Windows.Forms.Label labelWorkerPhone;
        private System.Windows.Forms.Label labelWorkerName;
        private System.Windows.Forms.TextBox textWorkerAddress;
        private System.Windows.Forms.TextBox textWorkerPhone;
        private System.Windows.Forms.TextBox textWorkerName;
        private System.Windows.Forms.DataGridView dataGridViewWorker;
        private System.Windows.Forms.Button buttonWorkerDelete;
        private System.Windows.Forms.Button buttonWorkerUpdate;
        private System.Windows.Forms.Button buttonWorkerAdd;
        private System.Windows.Forms.Label labelWorker;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNameWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhoneWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddressWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNameCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhoneCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddressCompany;
    }
}

