namespace MazeGenerator
{
    partial class MazeGeneratorForm
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
            this.widthText = new System.Windows.Forms.TextBox();
            this.heightText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.mazePanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // widthText
            // 
            this.widthText.Location = new System.Drawing.Point(75, 21);
            this.widthText.Name = "widthText";
            this.widthText.Size = new System.Drawing.Size(100, 21);
            this.widthText.TabIndex = 0;
            // 
            // heightText
            // 
            this.heightText.Location = new System.Drawing.Point(244, 21);
            this.heightText.Name = "heightText";
            this.heightText.Size = new System.Drawing.Size(100, 21);
            this.heightText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "너비 입력";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "높이 입력";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(394, 21);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 4;
            this.generateButton.Text = "미로 생성";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Tomato;
            this.saveButton.Location = new System.Drawing.Point(506, 17);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(184, 30);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "미로 저장 !!";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // mazePanel
            // 
            this.mazePanel.BackColor = System.Drawing.Color.White;
            this.mazePanel.Location = new System.Drawing.Point(14, 53);
            this.mazePanel.Name = "mazePanel";
            this.mazePanel.Size = new System.Drawing.Size(1191, 594);
            this.mazePanel.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(718, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(463, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "사용법 : 미로의 너비와 높이를 입력 후, 미로 생성 버튼 클릭. 생성된 버튼을 왼쪽으로 클릭하면 0, 1, 2 / 오른쪽 클릭하면 -2. 저장하" +
    "면 텍스트 파일로 출력된다.";
            // 
            // MazeGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 659);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mazePanel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.heightText);
            this.Controls.Add(this.widthText);
            this.Name = "MazeGeneratorForm";
            this.Text = "Maze Generator 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox widthText;
        private System.Windows.Forms.TextBox heightText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel mazePanel;
        private System.Windows.Forms.Label label3;
    }
}

