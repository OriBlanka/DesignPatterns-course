
namespace BasicFacebookFeatures
{
    partial class ColorPickerForm
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
            this.m_ColorPanel = new System.Windows.Forms.Panel();
            this.m_RedTrackBar = new System.Windows.Forms.TrackBar();
            this.m_GreenTrackBar = new System.Windows.Forms.TrackBar();
            this.m_BlueTrackBar = new System.Windows.Forms.TrackBar();
            this.m_RedLabel = new System.Windows.Forms.Label();
            this.m_GreenLabel = new System.Windows.Forms.Label();
            this.m_BlueLabel = new System.Windows.Forms.Label();
            this.m_SubmitColorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_RedTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_GreenTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_BlueTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // m_ColorPanel
            // 
            this.m_ColorPanel.Location = new System.Drawing.Point(749, 47);
            this.m_ColorPanel.Name = "m_ColorPanel";
            this.m_ColorPanel.Size = new System.Drawing.Size(408, 403);
            this.m_ColorPanel.TabIndex = 0;
            // 
            // m_RedTrackBar
            // 
            this.m_RedTrackBar.Location = new System.Drawing.Point(208, 47);
            this.m_RedTrackBar.Maximum = 255;
            this.m_RedTrackBar.Name = "m_RedTrackBar";
            this.m_RedTrackBar.Size = new System.Drawing.Size(515, 101);
            this.m_RedTrackBar.TabIndex = 1;
            this.m_RedTrackBar.Scroll += new System.EventHandler(this.m_RedTrackBar_Scroll);
            // 
            // m_GreenTrackBar
            // 
            this.m_GreenTrackBar.Location = new System.Drawing.Point(208, 194);
            this.m_GreenTrackBar.Maximum = 255;
            this.m_GreenTrackBar.Name = "m_GreenTrackBar";
            this.m_GreenTrackBar.Size = new System.Drawing.Size(515, 101);
            this.m_GreenTrackBar.TabIndex = 1;
            this.m_GreenTrackBar.Scroll += new System.EventHandler(this.m_GreenTrackBar_Scroll);
            // 
            // m_BlueTrackBar
            // 
            this.m_BlueTrackBar.Location = new System.Drawing.Point(208, 343);
            this.m_BlueTrackBar.Maximum = 255;
            this.m_BlueTrackBar.Name = "m_BlueTrackBar";
            this.m_BlueTrackBar.Size = new System.Drawing.Size(515, 101);
            this.m_BlueTrackBar.TabIndex = 1;
            this.m_BlueTrackBar.Scroll += new System.EventHandler(this.m_BlueTrackBar_Scroll);
            // 
            // m_RedLabel
            // 
            this.m_RedLabel.AutoSize = true;
            this.m_RedLabel.Location = new System.Drawing.Point(76, 56);
            this.m_RedLabel.Name = "m_RedLabel";
            this.m_RedLabel.Size = new System.Drawing.Size(58, 29);
            this.m_RedLabel.TabIndex = 2;
            this.m_RedLabel.Text = "Red";
            // 
            // m_GreenLabel
            // 
            this.m_GreenLabel.AutoSize = true;
            this.m_GreenLabel.Location = new System.Drawing.Point(76, 194);
            this.m_GreenLabel.Name = "m_GreenLabel";
            this.m_GreenLabel.Size = new System.Drawing.Size(80, 29);
            this.m_GreenLabel.TabIndex = 2;
            this.m_GreenLabel.Text = "Green";
            // 
            // m_BlueLabel
            // 
            this.m_BlueLabel.AutoSize = true;
            this.m_BlueLabel.Location = new System.Drawing.Point(76, 343);
            this.m_BlueLabel.Name = "m_BlueLabel";
            this.m_BlueLabel.Size = new System.Drawing.Size(62, 29);
            this.m_BlueLabel.TabIndex = 2;
            this.m_BlueLabel.Text = "Blue";
            // 
            // m_SubmitColorButton
            // 
            this.m_SubmitColorButton.Location = new System.Drawing.Point(522, 505);
            this.m_SubmitColorButton.Name = "m_SubmitColorButton";
            this.m_SubmitColorButton.Size = new System.Drawing.Size(148, 60);
            this.m_SubmitColorButton.TabIndex = 3;
            this.m_SubmitColorButton.Text = "Submit";
            this.m_SubmitColorButton.UseVisualStyleBackColor = true;
            // 
            // ColorPickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 597);
            this.Controls.Add(this.m_SubmitColorButton);
            this.Controls.Add(this.m_BlueLabel);
            this.Controls.Add(this.m_GreenLabel);
            this.Controls.Add(this.m_RedLabel);
            this.Controls.Add(this.m_BlueTrackBar);
            this.Controls.Add(this.m_GreenTrackBar);
            this.Controls.Add(this.m_RedTrackBar);
            this.Controls.Add(this.m_ColorPanel);
            this.Name = "ColorPickerForm";
            this.Text = "ColorPickerForm";
            this.Load += new System.EventHandler(this.ColorPickerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_RedTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_GreenTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_BlueTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel m_ColorPanel;
        private System.Windows.Forms.TrackBar m_RedTrackBar;
        private System.Windows.Forms.TrackBar m_GreenTrackBar;
        private System.Windows.Forms.TrackBar m_BlueTrackBar;
        private System.Windows.Forms.Label m_RedLabel;
        private System.Windows.Forms.Label m_GreenLabel;
        private System.Windows.Forms.Label m_BlueLabel;
        private System.Windows.Forms.Button m_SubmitColorButton;
    }
}