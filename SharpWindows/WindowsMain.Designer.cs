namespace SharpWindows
{
    partial class WindowsMain
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
            this.list_galaxys = new System.Windows.Forms.ListBox();
            this.btnGetExistGalaxys = new System.Windows.Forms.Button();
            this.txtGalaxyRep = new System.Windows.Forms.TextBox();
            this.txtGalaxyName = new System.Windows.Forms.TextBox();
            this.lblNodeG = new System.Windows.Forms.Label();
            this.lblNameG = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNameE = new System.Windows.Forms.Label();
            this.txtNameE = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.lstFounded = new System.Windows.Forms.ListBox();
            this.btnGetTemplate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblResMsgConnect = new System.Windows.Forms.Label();
            this.btnDisconect = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.txtStatusResQ = new System.Windows.Forms.TextBox();
            this.btnCOut = new System.Windows.Forms.Button();
            this.btnCIn = new System.Windows.Forms.Button();
            this.btnDep = new System.Windows.Forms.Button();
            this.btnUnDep = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.brnCreateObjOrInst = new System.Windows.Forms.Button();
            this.txtCreateFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // list_galaxys
            // 
            this.list_galaxys.FormattingEnabled = true;
            this.list_galaxys.ItemHeight = 16;
            this.list_galaxys.Location = new System.Drawing.Point(12, 12);
            this.list_galaxys.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.list_galaxys.Name = "list_galaxys";
            this.list_galaxys.Size = new System.Drawing.Size(315, 100);
            this.list_galaxys.TabIndex = 0;
            this.list_galaxys.SelectedIndexChanged += new System.EventHandler(this.list_galaxys_SelectedIndexChanged);
            // 
            // btnGetExistGalaxys
            // 
            this.btnGetExistGalaxys.Location = new System.Drawing.Point(12, 121);
            this.btnGetExistGalaxys.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetExistGalaxys.Name = "btnGetExistGalaxys";
            this.btnGetExistGalaxys.Size = new System.Drawing.Size(85, 23);
            this.btnGetExistGalaxys.TabIndex = 1;
            this.btnGetExistGalaxys.Text = "Запрос";
            this.btnGetExistGalaxys.UseVisualStyleBackColor = true;
            this.btnGetExistGalaxys.Click += new System.EventHandler(this.btnGetExistGalaxys_Click);
            // 
            // txtGalaxyRep
            // 
            this.txtGalaxyRep.Location = new System.Drawing.Point(333, 39);
            this.txtGalaxyRep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGalaxyRep.Name = "txtGalaxyRep";
            this.txtGalaxyRep.Size = new System.Drawing.Size(153, 22);
            this.txtGalaxyRep.TabIndex = 2;
            // 
            // txtGalaxyName
            // 
            this.txtGalaxyName.Location = new System.Drawing.Point(504, 39);
            this.txtGalaxyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGalaxyName.Name = "txtGalaxyName";
            this.txtGalaxyName.Size = new System.Drawing.Size(144, 22);
            this.txtGalaxyName.TabIndex = 3;
            // 
            // lblNodeG
            // 
            this.lblNodeG.AutoSize = true;
            this.lblNodeG.Location = new System.Drawing.Point(333, 18);
            this.lblNodeG.Name = "lblNodeG";
            this.lblNodeG.Size = new System.Drawing.Size(152, 17);
            this.lblNodeG.TabIndex = 4;
            this.lblNodeG.Text = "Расположение Galaxy";
            // 
            // lblNameG
            // 
            this.lblNameG.AutoSize = true;
            this.lblNameG.Location = new System.Drawing.Point(533, 18);
            this.lblNameG.Name = "lblNameG";
            this.lblNameG.Size = new System.Drawing.Size(82, 17);
            this.lblNameG.TabIndex = 5;
            this.lblNameG.Text = "Имя Galaxy";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(505, 69);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(144, 23);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(333, 80);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(86, 17);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Disconected";
            // 
            // lblNameE
            // 
            this.lblNameE.AutoSize = true;
            this.lblNameE.Location = new System.Drawing.Point(1203, 165);
            this.lblNameE.Name = "lblNameE";
            this.lblNameE.Size = new System.Drawing.Size(102, 17);
            this.lblNameE.TabIndex = 8;
            this.lblNameE.Text = "Имя элемента";
            // 
            // txtNameE
            // 
            this.txtNameE.Location = new System.Drawing.Point(1207, 192);
            this.txtNameE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameE.Name = "txtNameE";
            this.txtNameE.Size = new System.Drawing.Size(100, 22);
            this.txtNameE.TabIndex = 9;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(1207, 224);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(100, 23);
            this.btnFind.TabIndex = 10;
            this.btnFind.Text = "FInd";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lstFounded
            // 
            this.lstFounded.FormattingEnabled = true;
            this.lstFounded.ItemHeight = 16;
            this.lstFounded.Items.AddRange(new object[] {
            "             ALL FOUNDED IN GALAXIES"});
            this.lstFounded.Location = new System.Drawing.Point(16, 151);
            this.lstFounded.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstFounded.Name = "lstFounded";
            this.lstFounded.Size = new System.Drawing.Size(360, 692);
            this.lstFounded.TabIndex = 11;
            this.lstFounded.SelectedIndexChanged += new System.EventHandler(this.lstFounded_SelectedIndexChanged);
            // 
            // btnGetTemplate
            // 
            this.btnGetTemplate.Location = new System.Drawing.Point(385, 151);
            this.btnGetTemplate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetTemplate.Name = "btnGetTemplate";
            this.btnGetTemplate.Size = new System.Drawing.Size(100, 30);
            this.btnGetTemplate.TabIndex = 12;
            this.btnGetTemplate.Text = "Get";
            this.btnGetTemplate.UseVisualStyleBackColor = true;
            this.btnGetTemplate.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(720, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(691, 73);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(132, 22);
            this.txtPassword.TabIndex = 14;
            // 
            // lblResMsgConnect
            // 
            this.lblResMsgConnect.AutoSize = true;
            this.lblResMsgConnect.Location = new System.Drawing.Point(357, 127);
            this.lblResMsgConnect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResMsgConnect.Name = "lblResMsgConnect";
            this.lblResMsgConnect.Size = new System.Drawing.Size(93, 17);
            this.lblResMsgConnect.TabIndex = 15;
            this.lblResMsgConnect.Text = "-----------------";
            // 
            // btnDisconect
            // 
            this.btnDisconect.Location = new System.Drawing.Point(683, 103);
            this.btnDisconect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDisconect.Name = "btnDisconect";
            this.btnDisconect.Size = new System.Drawing.Size(145, 26);
            this.btnDisconect.TabIndex = 16;
            this.btnDisconect.Text = "Disconnect";
            this.btnDisconect.UseVisualStyleBackColor = true;
            this.btnDisconect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(504, 98);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(145, 28);
            this.btnExport.TabIndex = 19;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // txtStatusResQ
            // 
            this.txtStatusResQ.Location = new System.Drawing.Point(1124, 50);
            this.txtStatusResQ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStatusResQ.Name = "txtStatusResQ";
            this.txtStatusResQ.Size = new System.Drawing.Size(184, 22);
            this.txtStatusResQ.TabIndex = 20;
            // 
            // btnCOut
            // 
            this.btnCOut.Location = new System.Drawing.Point(863, 81);
            this.btnCOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCOut.Name = "btnCOut";
            this.btnCOut.Size = new System.Drawing.Size(100, 28);
            this.btnCOut.TabIndex = 21;
            this.btnCOut.Text = "CheckOut";
            this.btnCOut.UseVisualStyleBackColor = true;
            this.btnCOut.Click += new System.EventHandler(this.btnCOut_Click);
            // 
            // btnCIn
            // 
            this.btnCIn.Location = new System.Drawing.Point(975, 80);
            this.btnCIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCIn.Name = "btnCIn";
            this.btnCIn.Size = new System.Drawing.Size(100, 28);
            this.btnCIn.TabIndex = 22;
            this.btnCIn.Text = "CheckIn";
            this.btnCIn.UseVisualStyleBackColor = true;
            this.btnCIn.Click += new System.EventHandler(this.btnCIn_Click);
            // 
            // btnDep
            // 
            this.btnDep.Location = new System.Drawing.Point(863, 32);
            this.btnDep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDep.Name = "btnDep";
            this.btnDep.Size = new System.Drawing.Size(100, 28);
            this.btnDep.TabIndex = 23;
            this.btnDep.Text = "Deploy";
            this.btnDep.UseVisualStyleBackColor = true;
            this.btnDep.Click += new System.EventHandler(this.btnDep_Click);
            // 
            // btnUnDep
            // 
            this.btnUnDep.Location = new System.Drawing.Point(975, 32);
            this.btnUnDep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUnDep.Name = "btnUnDep";
            this.btnUnDep.Size = new System.Drawing.Size(100, 28);
            this.btnUnDep.TabIndex = 24;
            this.btnUnDep.Text = "Undeploy";
            this.btnUnDep.UseVisualStyleBackColor = true;
            this.btnUnDep.Click += new System.EventHandler(this.btnUnDep_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(691, 32);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(132, 22);
            this.txtUser.TabIndex = 25;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(720, 11);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(38, 17);
            this.lblUser.TabIndex = 13;
            this.lblUser.Text = "User";
            // 
            // brnCreateObjOrInst
            // 
            this.brnCreateObjOrInst.Location = new System.Drawing.Point(1064, 224);
            this.brnCreateObjOrInst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.brnCreateObjOrInst.Name = "brnCreateObjOrInst";
            this.brnCreateObjOrInst.Size = new System.Drawing.Size(100, 28);
            this.brnCreateObjOrInst.TabIndex = 26;
            this.brnCreateObjOrInst.Text = "Create";
            this.brnCreateObjOrInst.UseVisualStyleBackColor = true;
            this.brnCreateObjOrInst.Click += new System.EventHandler(this.brnCreateObjOrInst_Click);
            // 
            // txtCreateFrom
            // 
            this.txtCreateFrom.Location = new System.Drawing.Point(1041, 192);
            this.txtCreateFrom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCreateFrom.Name = "txtCreateFrom";
            this.txtCreateFrom.Size = new System.Drawing.Size(132, 22);
            this.txtCreateFrom.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1050, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Унаследовно от";
            // 
            // WindowsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 860);
            this.Controls.Add(this.txtCreateFrom);
            this.Controls.Add(this.brnCreateObjOrInst);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnUnDep);
            this.Controls.Add(this.btnDep);
            this.Controls.Add(this.btnCIn);
            this.Controls.Add(this.btnCOut);
            this.Controls.Add(this.txtStatusResQ);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnDisconect);
            this.Controls.Add(this.lblResMsgConnect);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetTemplate);
            this.Controls.Add(this.lstFounded);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtNameE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNameE);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblNameG);
            this.Controls.Add(this.lblNodeG);
            this.Controls.Add(this.txtGalaxyName);
            this.Controls.Add(this.txtGalaxyRep);
            this.Controls.Add(this.btnGetExistGalaxys);
            this.Controls.Add(this.list_galaxys);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WindowsMain";
            this.Text = "GRAccess";
            this.Load += new System.EventHandler(this.WindowsMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_galaxys;
        private System.Windows.Forms.Button btnGetExistGalaxys;
        private System.Windows.Forms.TextBox txtGalaxyRep;
        private System.Windows.Forms.TextBox txtGalaxyName;
        private System.Windows.Forms.Label lblNodeG;
        private System.Windows.Forms.Label lblNameG;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblNameE;
        private System.Windows.Forms.TextBox txtNameE;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ListBox lstFounded;
        private System.Windows.Forms.Button btnGetTemplate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblResMsgConnect;
        private System.Windows.Forms.Button btnDisconect;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TextBox txtStatusResQ;
        private System.Windows.Forms.Button btnCOut;
        private System.Windows.Forms.Button btnCIn;
        private System.Windows.Forms.Button btnDep;
        private System.Windows.Forms.Button btnUnDep;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button brnCreateObjOrInst;
        private System.Windows.Forms.TextBox txtCreateFrom;
        private System.Windows.Forms.Label label2;
    }
}

