namespace Lab1.AdditionalTask
{
    partial class ElipseForm
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
            this.OpenRhombFormButton = new System.Windows.Forms.Button();
            this.CloseElipseFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenRhombFormButton
            // 
            this.OpenRhombFormButton.Location = new System.Drawing.Point(422, 362);
            this.OpenRhombFormButton.Name = "OpenRhombFormButton";
            this.OpenRhombFormButton.Size = new System.Drawing.Size(211, 29);
            this.OpenRhombFormButton.TabIndex = 0;
            this.OpenRhombFormButton.Text = "Open RhombForm";
            this.OpenRhombFormButton.UseVisualStyleBackColor = true;
            this.OpenRhombFormButton.Click += new System.EventHandler(this.OpenRhombFormButton_Click);
            // 
            // CloseElipseFormButton
            // 
            this.CloseElipseFormButton.Location = new System.Drawing.Point(671, 362);
            this.CloseElipseFormButton.Name = "CloseElipseFormButton";
            this.CloseElipseFormButton.Size = new System.Drawing.Size(212, 29);
            this.CloseElipseFormButton.TabIndex = 1;
            this.CloseElipseFormButton.Text = "Close Form";
            this.CloseElipseFormButton.UseVisualStyleBackColor = true;
            this.CloseElipseFormButton.Click += new System.EventHandler(this.CloseElipseFormButton_Click);
            // 
            // ElipseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 753);
            this.Controls.Add(this.CloseElipseFormButton);
            this.Controls.Add(this.OpenRhombFormButton);
            this.Name = "ElipseForm";
            this.Text = "ElipseForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ElipseForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button OpenRhombFormButton;
        private Button CloseElipseFormButton;
    }
}