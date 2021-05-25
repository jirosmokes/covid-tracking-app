
namespace SHINKANSENAPP
{
    partial class Infographics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Infographics));
            this.label2 = new System.Windows.Forms.Label();
            this.geninfo = new System.Windows.Forms.Button();
            this.symptoms = new System.Windows.Forms.Button();
            this.guidance = new System.Windows.Forms.Button();
            this.igloader = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 3;
            // 
            // geninfo
            // 
            this.geninfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geninfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geninfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geninfo.Location = new System.Drawing.Point(1, 28);
            this.geninfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.geninfo.Name = "geninfo";
            this.geninfo.Size = new System.Drawing.Size(427, 52);
            this.geninfo.TabIndex = 4;
            this.geninfo.Text = "General Information";
            this.geninfo.UseVisualStyleBackColor = true;
            this.geninfo.Click += new System.EventHandler(this.geninfo_Click);
            // 
            // symptoms
            // 
            this.symptoms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.symptoms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.symptoms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.symptoms.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symptoms.Location = new System.Drawing.Point(437, 28);
            this.symptoms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.symptoms.Name = "symptoms";
            this.symptoms.Size = new System.Drawing.Size(427, 52);
            this.symptoms.TabIndex = 5;
            this.symptoms.Text = "Advice";
            this.symptoms.UseVisualStyleBackColor = false;
            this.symptoms.Click += new System.EventHandler(this.symptoms_Click);
            // 
            // guidance
            // 
            this.guidance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guidance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guidance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guidance.Location = new System.Drawing.Point(873, 28);
            this.guidance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guidance.Name = "guidance";
            this.guidance.Size = new System.Drawing.Size(427, 52);
            this.guidance.TabIndex = 6;
            this.guidance.Text = "Guidance and Vaccines";
            this.guidance.UseVisualStyleBackColor = true;
            this.guidance.Click += new System.EventHandler(this.precaution_Click);
            // 
            // igloader
            // 
            this.igloader.Font = new System.Drawing.Font("Century Gothic", 7.8F);
            this.igloader.Location = new System.Drawing.Point(0, 87);
            this.igloader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.igloader.Name = "igloader";
            this.igloader.Size = new System.Drawing.Size(1307, 434);
            this.igloader.TabIndex = 7;
            this.igloader.Paint += new System.Windows.Forms.PaintEventHandler(this.igloader_Paint);
            // 
            // Infographics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1307, 518);
            this.Controls.Add(this.igloader);
            this.Controls.Add(this.guidance);
            this.Controls.Add(this.symptoms);
            this.Controls.Add(this.geninfo);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Infographics";
            this.Text = "Infographics";
            this.Load += new System.EventHandler(this.Infographics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button geninfo;
        private System.Windows.Forms.Button symptoms;
        private System.Windows.Forms.Button guidance;
        private System.Windows.Forms.Panel igloader;
    }
}