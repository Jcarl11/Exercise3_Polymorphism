namespace Exercise3_Polymorphism {
    partial class MainPage {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.question_question = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.question_message = new System.Windows.Forms.Label();
            this.question_answer = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // question_question
            // 
            this.question_question.Dock = System.Windows.Forms.DockStyle.Top;
            this.question_question.Location = new System.Drawing.Point(0, 0);
            this.question_question.Multiline = true;
            this.question_question.Name = "question_question";
            this.question_question.Size = new System.Drawing.Size(629, 273);
            this.question_question.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.question_message);
            this.groupBox1.Controls.Add(this.question_answer);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ANSWER";
            // 
            // question_message
            // 
            this.question_message.AutoSize = true;
            this.question_message.Location = new System.Drawing.Point(307, 28);
            this.question_message.Name = "question_message";
            this.question_message.Size = new System.Drawing.Size(0, 16);
            this.question_message.TabIndex = 1;
            // 
            // question_answer
            // 
            this.question_answer.Location = new System.Drawing.Point(8, 25);
            this.question_answer.Name = "question_answer";
            this.question_answer.Size = new System.Drawing.Size(293, 23);
            this.question_answer.TabIndex = 0;
            this.question_answer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Question_answer_KeyDown);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 350);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.question_question);
            this.Font = new System.Drawing.Font("Lato", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainPage";
            this.ShowIcon = false;
            this.Text = "Quiz";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox question_question;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox question_answer;
        private System.Windows.Forms.Label question_message;
    }
}

