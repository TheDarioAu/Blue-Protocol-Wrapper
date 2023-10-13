namespace BlueProtocolWrapper
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblVPN;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtExecutablePath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblVPN = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtExecutablePath = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVPN
            // 
            this.lblVPN.AutoSize = true;
            this.lblVPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVPN.Location = new System.Drawing.Point(65, 48);
            this.lblVPN.Name = "lblVPN";
            this.lblVPN.Size = new System.Drawing.Size(195, 20);
            this.lblVPN.TabIndex = 0;
            this.lblVPN.Text = "Have you activated your VPN?";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(123, 101);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.Confirm);
            // 
            // txtExecutablePath
            // 
            this.txtExecutablePath.Location = new System.Drawing.Point(48, 74);
            this.txtExecutablePath.Name = "txtExecutablePath";
            this.txtExecutablePath.Size = new System.Drawing.Size(230, 20);
            this.txtExecutablePath.TabIndex = 2;
            // 
            // btnSavePath
            // 
            this.btnSave.Location = new System.Drawing.Point(69, 130);
            this.btnSave.Name = "btnSavePath";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save Path";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.SavePath);
            // 
            // btnLoadPath
            // 
            this.btnLoad.Location = new System.Drawing.Point(169, 130);
            this.btnLoad.Name = "btnLoadPath";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load Path";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.LoadPath);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 186);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtExecutablePath);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblVPN);
            this.Name = "Blue Protocol Launcher";
            this.Text = "Blue Protocol";
            this.Load += new System.EventHandler(this.LoadedApp);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClosedApp);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}