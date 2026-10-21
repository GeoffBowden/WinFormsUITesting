namespace WinFormsUITesting
{
    partial class frmMain
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
            btnChangeMessage = new Button();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // btnChangeMessage
            // 
            btnChangeMessage.Location = new Point(34, 57);
            btnChangeMessage.Name = "btnChangeMessage";
            btnChangeMessage.Size = new Size(75, 23);
            btnChangeMessage.TabIndex = 0;
            btnChangeMessage.Text = "ChangeMessage";
            btnChangeMessage.UseVisualStyleBackColor = true;
            btnChangeMessage.Click += btnChangeMessage_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(34, 96);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(38, 15);
            lblMessage.TabIndex = 1;
            lblMessage.Text = "label1";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMessage);
            Controls.Add(btnChangeMessage);
            Name = "frmMain";
            Text = "Automatic UI Testing";
            Load += frmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChangeMessage;
        private Label lblMessage;
    }
}
