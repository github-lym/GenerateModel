
namespace GenerateModel
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TBX_ConnectionString = new System.Windows.Forms.TextBox();
            this.TBX_Query = new System.Windows.Forms.RichTextBox();
            this.BTN_Generate = new System.Windows.Forms.Button();
            this.TBX_Result = new System.Windows.Forms.RichTextBox();
            this.RB_CASE1 = new System.Windows.Forms.RadioButton();
            this.RB_CASE2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_CASE3 = new System.Windows.Forms.RadioButton();
            this.BTN_COPY = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TypeB = new System.Windows.Forms.RadioButton();
            this.TypeA = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CB_ConnectionStrings = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBX_ConnectionString
            // 
            this.TBX_ConnectionString.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_ConnectionString.Location = new System.Drawing.Point(5, 22);
            this.TBX_ConnectionString.Margin = new System.Windows.Forms.Padding(2);
            this.TBX_ConnectionString.Name = "TBX_ConnectionString";
            this.TBX_ConnectionString.Size = new System.Drawing.Size(679, 26);
            this.TBX_ConnectionString.TabIndex = 0;
            // 
            // TBX_Query
            // 
            this.TBX_Query.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_Query.Location = new System.Drawing.Point(7, 16);
            this.TBX_Query.Margin = new System.Windows.Forms.Padding(2);
            this.TBX_Query.Name = "TBX_Query";
            this.TBX_Query.Size = new System.Drawing.Size(677, 162);
            this.TBX_Query.TabIndex = 2;
            this.TBX_Query.Text = "";
            // 
            // BTN_Generate
            // 
            this.BTN_Generate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Generate.Location = new System.Drawing.Point(321, 133);
            this.BTN_Generate.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Generate.Name = "BTN_Generate";
            this.BTN_Generate.Size = new System.Drawing.Size(60, 32);
            this.BTN_Generate.TabIndex = 4;
            this.BTN_Generate.Text = "產生";
            this.BTN_Generate.UseVisualStyleBackColor = true;
            this.BTN_Generate.Click += new System.EventHandler(this.BTN_Generate_Click);
            // 
            // TBX_Result
            // 
            this.TBX_Result.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_Result.Location = new System.Drawing.Point(7, 14);
            this.TBX_Result.Margin = new System.Windows.Forms.Padding(2);
            this.TBX_Result.Name = "TBX_Result";
            this.TBX_Result.ReadOnly = true;
            this.TBX_Result.Size = new System.Drawing.Size(492, 142);
            this.TBX_Result.TabIndex = 5;
            this.TBX_Result.Text = "";
            // 
            // RB_CASE1
            // 
            this.RB_CASE1.AutoSize = true;
            this.RB_CASE1.Checked = true;
            this.RB_CASE1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RB_CASE1.Location = new System.Drawing.Point(19, 12);
            this.RB_CASE1.Margin = new System.Windows.Forms.Padding(2);
            this.RB_CASE1.Name = "RB_CASE1";
            this.RB_CASE1.Size = new System.Drawing.Size(96, 22);
            this.RB_CASE1.TabIndex = 6;
            this.RB_CASE1.TabStop = true;
            this.RB_CASE1.Text = "大小寫不變";
            this.RB_CASE1.UseVisualStyleBackColor = true;
            // 
            // RB_CASE2
            // 
            this.RB_CASE2.AutoSize = true;
            this.RB_CASE2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RB_CASE2.Location = new System.Drawing.Point(117, 12);
            this.RB_CASE2.Margin = new System.Windows.Forms.Padding(2);
            this.RB_CASE2.Name = "RB_CASE2";
            this.RB_CASE2.Size = new System.Drawing.Size(82, 22);
            this.RB_CASE2.TabIndex = 7;
            this.RB_CASE2.Text = "首字大寫";
            this.RB_CASE2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_CASE3);
            this.groupBox1.Controls.Add(this.RB_CASE1);
            this.groupBox1.Controls.Add(this.RB_CASE2);
            this.groupBox1.Location = new System.Drawing.Point(26, 127);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(291, 38);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "大小寫";
            // 
            // RB_CASE3
            // 
            this.RB_CASE3.AutoSize = true;
            this.RB_CASE3.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RB_CASE3.Location = new System.Drawing.Point(206, 12);
            this.RB_CASE3.Margin = new System.Windows.Forms.Padding(2);
            this.RB_CASE3.Name = "RB_CASE3";
            this.RB_CASE3.Size = new System.Drawing.Size(68, 22);
            this.RB_CASE3.TabIndex = 8;
            this.RB_CASE3.Text = "全大寫";
            this.RB_CASE3.UseVisualStyleBackColor = true;
            // 
            // BTN_COPY
            // 
            this.BTN_COPY.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_COPY.Location = new System.Drawing.Point(537, 479);
            this.BTN_COPY.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_COPY.Name = "BTN_COPY";
            this.BTN_COPY.Size = new System.Drawing.Size(59, 42);
            this.BTN_COPY.TabIndex = 9;
            this.BTN_COPY.Text = "複製";
            this.BTN_COPY.UseVisualStyleBackColor = true;
            this.BTN_COPY.Click += new System.EventHandler(this.BTN_COPY_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TypeB);
            this.groupBox2.Controls.Add(this.TypeA);
            this.groupBox2.Location = new System.Drawing.Point(301, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 38);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "輸入";
            this.groupBox2.Visible = false;
            // 
            // TypeB
            // 
            this.TypeB.AutoSize = true;
            this.TypeB.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TypeB.Location = new System.Drawing.Point(134, 11);
            this.TypeB.Name = "TypeB";
            this.TypeB.Size = new System.Drawing.Size(59, 21);
            this.TypeB.TabIndex = 1;
            this.TypeB.Text = "Input";
            this.TypeB.UseVisualStyleBackColor = true;
            // 
            // TypeA
            // 
            this.TypeA.AutoSize = true;
            this.TypeA.Checked = true;
            this.TypeA.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TypeA.Location = new System.Drawing.Point(36, 11);
            this.TypeA.Name = "TypeA";
            this.TypeA.Size = new System.Drawing.Size(64, 21);
            this.TypeA.TabIndex = 0;
            this.TypeA.TabStop = true;
            this.TypeA.Text = "Query";
            this.TypeA.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TBX_ConnectionString);
            this.groupBox3.Location = new System.Drawing.Point(26, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(689, 54);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ConnectionString";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CB_ConnectionStrings);
            this.groupBox4.Location = new System.Drawing.Point(26, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 58);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "連線設定";
            // 
            // CB_ConnectionStrings
            // 
            this.CB_ConnectionStrings.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_ConnectionStrings.FormattingEnabled = true;
            this.CB_ConnectionStrings.Location = new System.Drawing.Point(7, 22);
            this.CB_ConnectionStrings.Name = "CB_ConnectionStrings";
            this.CB_ConnectionStrings.Size = new System.Drawing.Size(187, 27);
            this.CB_ConnectionStrings.TabIndex = 0;
            this.CB_ConnectionStrings.SelectedIndexChanged += new System.EventHandler(this.CB_ConnectionStrings_Change);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TBX_Query);
            this.groupBox5.Location = new System.Drawing.Point(26, 171);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(689, 183);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "MSSQL查詢";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.TBX_Result);
            this.groupBox6.Location = new System.Drawing.Point(26, 360);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(506, 161);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "生成Model";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 533);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BTN_COPY);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTN_Generate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "GenerateModel_20220318";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TBX_ConnectionString;
        private System.Windows.Forms.RichTextBox TBX_Query;
        private System.Windows.Forms.Button BTN_Generate;
        private System.Windows.Forms.RichTextBox TBX_Result;
        private System.Windows.Forms.RadioButton RB_CASE1;
        private System.Windows.Forms.RadioButton RB_CASE2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB_CASE3;
        private System.Windows.Forms.Button BTN_COPY;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton TypeB;
        private System.Windows.Forms.RadioButton TypeA;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox CB_ConnectionStrings;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}

