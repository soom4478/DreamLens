namespace DreamLens
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbObject = new System.Windows.Forms.TextBox();
            this.tbAct = new System.Windows.Forms.TextBox();
            this.tbEmotion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbObject
            // 
            this.tbObject.Font = new System.Drawing.Font("굴림", 15F);
            this.tbObject.Location = new System.Drawing.Point(56, 195);
            this.tbObject.Name = "tbObject";
            this.tbObject.Size = new System.Drawing.Size(202, 30);
            this.tbObject.TabIndex = 0;
            this.tbObject.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbAct
            // 
            this.tbAct.Font = new System.Drawing.Font("굴림", 15F);
            this.tbAct.Location = new System.Drawing.Point(56, 244);
            this.tbAct.Name = "tbAct";
            this.tbAct.Size = new System.Drawing.Size(202, 30);
            this.tbAct.TabIndex = 1;
            // 
            // tbEmotion
            // 
            this.tbEmotion.Font = new System.Drawing.Font("굴림", 15F);
            this.tbEmotion.Location = new System.Drawing.Point(56, 295);
            this.tbEmotion.Name = "tbEmotion";
            this.tbEmotion.Size = new System.Drawing.Size(202, 30);
            this.tbEmotion.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbEmotion);
            this.Controls.Add(this.tbAct);
            this.Controls.Add(this.tbObject);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbObject;
        private System.Windows.Forms.TextBox tbAct;
        private System.Windows.Forms.TextBox tbEmotion;
    }
}

