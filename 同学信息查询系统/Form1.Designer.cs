namespace 同学信息查询系统
{
    partial class Form1
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
            this.lstMessage = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxhight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxmajor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxhobby = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxhomeplace = new System.Windows.Forms.TextBox();
            this.sqlconnection = new System.Windows.Forms.Button();
            this.formclose = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstMessage
            // 
            this.lstMessage.FormattingEnabled = true;
            this.lstMessage.ItemHeight = 12;
            this.lstMessage.Location = new System.Drawing.Point(12, 100);
            this.lstMessage.Name = "lstMessage";
            this.lstMessage.Size = new System.Drawing.Size(89, 232);
            this.lstMessage.TabIndex = 0;
            this.lstMessage.SelectedIndexChanged += new System.EventHandler(this.lstMessage_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(265, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "同学信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "姓名：";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(208, 103);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(115, 21);
            this.tbxName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "编号：";
            // 
            // tbxID
            // 
            this.tbxID.Location = new System.Drawing.Point(59, 53);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(42, 21);
            this.tbxID.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "年龄：";
            // 
            // tbxage
            // 
            this.tbxage.Location = new System.Drawing.Point(430, 100);
            this.tbxage.Name = "tbxage";
            this.tbxage.Size = new System.Drawing.Size(115, 21);
            this.tbxage.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "身高：";
            // 
            // tbxhight
            // 
            this.tbxhight.Location = new System.Drawing.Point(213, 171);
            this.tbxhight.Name = "tbxhight";
            this.tbxhight.Size = new System.Drawing.Size(115, 21);
            this.tbxhight.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "专业：";
            // 
            // tbxmajor
            // 
            this.tbxmajor.Location = new System.Drawing.Point(430, 168);
            this.tbxmajor.Name = "tbxmajor";
            this.tbxmajor.Size = new System.Drawing.Size(115, 21);
            this.tbxmajor.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "游戏爱好：";
            // 
            // tbxhobby
            // 
            this.tbxhobby.Location = new System.Drawing.Point(213, 238);
            this.tbxhobby.Name = "tbxhobby";
            this.tbxhobby.Size = new System.Drawing.Size(332, 21);
            this.tbxhobby.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "家乡：";
            // 
            // tbxhomeplace
            // 
            this.tbxhomeplace.Location = new System.Drawing.Point(213, 295);
            this.tbxhomeplace.Name = "tbxhomeplace";
            this.tbxhomeplace.Size = new System.Drawing.Size(332, 21);
            this.tbxhomeplace.TabIndex = 15;
            // 
            // sqlconnection
            // 
            this.sqlconnection.Location = new System.Drawing.Point(213, 360);
            this.sqlconnection.Name = "sqlconnection";
            this.sqlconnection.Size = new System.Drawing.Size(93, 23);
            this.sqlconnection.TabIndex = 16;
            this.sqlconnection.Text = "连接数据库";
            this.sqlconnection.UseVisualStyleBackColor = true;
            this.sqlconnection.Click += new System.EventHandler(this.sqlconnection_Click);
            // 
            // formclose
            // 
            this.formclose.Location = new System.Drawing.Point(452, 360);
            this.formclose.Name = "formclose";
            this.formclose.Size = new System.Drawing.Size(93, 23);
            this.formclose.TabIndex = 17;
            this.formclose.Text = "关闭";
            this.formclose.UseVisualStyleBackColor = true;
            this.formclose.Click += new System.EventHandler(this.button2_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label.Location = new System.Drawing.Point(212, 405);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(94, 21);
            this.label.TabIndex = 18;
            this.label.Text = "连接状态";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 444);
            this.Controls.Add(this.label);
            this.Controls.Add(this.formclose);
            this.Controls.Add(this.sqlconnection);
            this.Controls.Add(this.tbxhomeplace);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxhobby);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxmajor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxhight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxhight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxmajor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxhobby;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxhomeplace;
        private System.Windows.Forms.Button sqlconnection;
        private System.Windows.Forms.Button formclose;
        private System.Windows.Forms.Label label;
    }
}

