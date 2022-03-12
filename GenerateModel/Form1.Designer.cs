
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
            this.TBX_ConnectionStrings = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBX_Query = new System.Windows.Forms.RichTextBox();
            this.BTN_Generate = new System.Windows.Forms.Button();
            this.TBX_Result = new System.Windows.Forms.RichTextBox();
            this.RB_CASE1 = new System.Windows.Forms.RadioButton();
            this.RB_CASE2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_CASE3 = new System.Windows.Forms.RadioButton();
            this.BTN_COPY = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TypeA = new System.Windows.Forms.RadioButton();
            this.TypeB = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBX_ConnectionStrings
            // 
            this.TBX_ConnectionStrings.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TBX_ConnectionStrings.Location = new System.Drawing.Point(26, 36);
            this.TBX_ConnectionStrings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBX_ConnectionStrings.Name = "TBX_ConnectionStrings";
            this.TBX_ConnectionStrings.Size = new System.Drawing.Size(689, 27);
            this.TBX_ConnectionStrings.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(22, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ConnectionStrings";
            // 
            // TBX_Query
            // 
            this.TBX_Query.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_Query.Location = new System.Drawing.Point(26, 127);
            this.TBX_Query.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBX_Query.Name = "TBX_Query";
            this.TBX_Query.Size = new System.Drawing.Size(689, 240);
            this.TBX_Query.TabIndex = 2;
            this.TBX_Query.Text = "";
            // 
            // BTN_Generate
            // 
            this.BTN_Generate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BTN_Generate.Location = new System.Drawing.Point(26, 91);
            this.BTN_Generate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_Generate.Name = "BTN_Generate";
            this.BTN_Generate.Size = new System.Drawing.Size(60, 32);
            this.BTN_Generate.TabIndex = 4;
            this.BTN_Generate.Text = "產生";
            this.BTN_Generate.UseVisualStyleBackColor = true;
            this.BTN_Generate.Click += new System.EventHandler(this.BTN_Generate_Click);
            // 
            // TBX_Result
            // 
            this.TBX_Result.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_Result.Location = new System.Drawing.Point(26, 371);
            this.TBX_Result.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBX_Result.Name = "TBX_Result";
            this.TBX_Result.ReadOnly = true;
            this.TBX_Result.Size = new System.Drawing.Size(500, 106);
            this.TBX_Result.TabIndex = 5;
            this.TBX_Result.Text = "";
            // 
            // RB_CASE1
            // 
            this.RB_CASE1.AutoSize = true;
            this.RB_CASE1.Checked = true;
            this.RB_CASE1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RB_CASE1.Location = new System.Drawing.Point(38, 12);
            this.RB_CASE1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.RB_CASE2.Location = new System.Drawing.Point(136, 12);
            this.RB_CASE2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.groupBox1.Location = new System.Drawing.Point(394, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(291, 38);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "大小寫";
            // 
            // RB_CASE3
            // 
            this.RB_CASE3.AutoSize = true;
            this.RB_CASE3.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.RB_CASE3.Location = new System.Drawing.Point(225, 12);
            this.RB_CASE3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RB_CASE3.Name = "RB_CASE3";
            this.RB_CASE3.Size = new System.Drawing.Size(68, 22);
            this.RB_CASE3.TabIndex = 8;
            this.RB_CASE3.Text = "全大寫";
            this.RB_CASE3.UseVisualStyleBackColor = true;
            // 
            // BTN_COPY
            // 
            this.BTN_COPY.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_COPY.Location = new System.Drawing.Point(530, 371);
            this.BTN_COPY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN_COPY.Name = "BTN_COPY";
            this.BTN_COPY.Size = new System.Drawing.Size(59, 105);
            this.BTN_COPY.TabIndex = 9;
            this.BTN_COPY.Text = "複製";
            this.BTN_COPY.UseVisualStyleBackColor = true;
            this.BTN_COPY.Click += new System.EventHandler(this.BTN_COPY_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TypeB);
            this.groupBox2.Controls.Add(this.TypeA);
            this.groupBox2.Location = new System.Drawing.Point(111, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 38);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "輸入";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 494);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BTN_COPY);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TBX_Result);
            this.Controls.Add(this.BTN_Generate);
            this.Controls.Add(this.TBX_Query);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBX_ConnectionStrings);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBX_ConnectionStrings;
        private System.Windows.Forms.Label label1;
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
    }
}

