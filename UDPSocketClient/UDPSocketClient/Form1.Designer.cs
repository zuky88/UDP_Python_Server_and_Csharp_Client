namespace UDPSocketClient
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
            btStart = new Button();
            btEnd = new Button();
            tbMessage = new TextBox();
            lbTime = new Label();
            btAlive = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // btStart
            // 
            btStart.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btStart.Location = new Point(170, 307);
            btStart.Name = "btStart";
            btStart.Size = new Size(188, 92);
            btStart.TabIndex = 0;
            btStart.Text = "Start";
            btStart.UseVisualStyleBackColor = true;
            btStart.Click += btStart_Click;
            // 
            // btEnd
            // 
            btEnd.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btEnd.Location = new Point(392, 307);
            btEnd.Name = "btEnd";
            btEnd.Size = new Size(188, 92);
            btEnd.TabIndex = 1;
            btEnd.Text = "End";
            btEnd.UseVisualStyleBackColor = true;
            btEnd.Click += btEnd_Click;
            // 
            // tbMessage
            // 
            tbMessage.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbMessage.Location = new Point(170, 164);
            tbMessage.Name = "tbMessage";
            tbMessage.Size = new Size(942, 61);
            tbMessage.TabIndex = 2;
            tbMessage.Text = "received message";
            // 
            // lbTime
            // 
            lbTime.AutoSize = true;
            lbTime.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lbTime.Location = new Point(669, 345);
            lbTime.Name = "lbTime";
            lbTime.Size = new Size(485, 54);
            lbTime.TabIndex = 3;
            lbTime.Text = "yyyy/MM/dd HH:mm:ss.fff";
            // 
            // btAlive
            // 
            btAlive.BackColor = Color.Black;
            btAlive.Enabled = false;
            btAlive.Location = new Point(38, 23);
            btAlive.Name = "btAlive";
            btAlive.Size = new Size(54, 58);
            btAlive.TabIndex = 4;
            btAlive.UseVisualStyleBackColor = false;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 462);
            Controls.Add(btAlive);
            Controls.Add(lbTime);
            Controls.Add(tbMessage);
            Controls.Add(btEnd);
            Controls.Add(btStart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btStart;
        private Button btEnd;
        private TextBox tbMessage;
        private Label lbTime;
        private Button btAlive;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
