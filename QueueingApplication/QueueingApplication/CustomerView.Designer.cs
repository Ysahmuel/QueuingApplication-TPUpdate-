namespace QueueingApplication
{
    public partial class CustomerView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblQueue = new Label();
            lblServing = new Label();
            SuspendLayout();
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Font = new Font("Segoe UI Semibold", 35F, FontStyle.Bold);
            lblQueue.Location = new Point(44, 70);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(288, 78);
            lblQueue.TabIndex = 0;
            lblQueue.Text = "P - 00000";
            lblQueue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblServing
            // 
            lblServing.AutoSize = true;
            lblServing.Font = new Font("Segoe UI", 15F);
            lblServing.Location = new Point(12, 35);
            lblServing.Name = "lblServing";
            lblServing.Size = new Size(166, 35);
            lblServing.TabIndex = 1;
            lblServing.Text = "*Now Serving";
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 193);
            Controls.Add(lblServing);
            Controls.Add(lblQueue);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CustomerView";
            Text = "CustomerView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQueue;
        private Label lblServing;

    }
}