
namespace Gun_Project
{
    partial class Form1
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
            this.Loadbtn = new System.Windows.Forms.Button();
            this.Rollbtn = new System.Windows.Forms.Button();
            this.shootbtn = new System.Windows.Forms.Button();
            this.awaybtn = new System.Windows.Forms.Button();
            this.Closebtn = new System.Windows.Forms.Button();
            this.btnrestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Loadbtn
            // 
            this.Loadbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Loadbtn.Location = new System.Drawing.Point(20, 288);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(95, 43);
            this.Loadbtn.TabIndex = 0;
            this.Loadbtn.Text = "Load";
            this.Loadbtn.UseVisualStyleBackColor = false;
            this.Loadbtn.Click += new System.EventHandler(this.Loadbtn_Click);
            // 
            // Rollbtn
            // 
            this.Rollbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Rollbtn.Location = new System.Drawing.Point(130, 288);
            this.Rollbtn.Name = "Rollbtn";
            this.Rollbtn.Size = new System.Drawing.Size(95, 43);
            this.Rollbtn.TabIndex = 1;
            this.Rollbtn.Text = "Roller";
            this.Rollbtn.UseVisualStyleBackColor = false;
            this.Rollbtn.Click += new System.EventHandler(this.Rollbtn_Click);
            // 
            // shootbtn
            // 
            this.shootbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.shootbtn.Location = new System.Drawing.Point(556, 288);
            this.shootbtn.Name = "shootbtn";
            this.shootbtn.Size = new System.Drawing.Size(95, 43);
            this.shootbtn.TabIndex = 2;
            this.shootbtn.Text = "Shoot";
            this.shootbtn.UseVisualStyleBackColor = false;
            this.shootbtn.Click += new System.EventHandler(this.shootbtn_Click);
            // 
            // awaybtn
            // 
            this.awaybtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.awaybtn.Location = new System.Drawing.Point(670, 288);
            this.awaybtn.Name = "awaybtn";
            this.awaybtn.Size = new System.Drawing.Size(95, 43);
            this.awaybtn.TabIndex = 3;
            this.awaybtn.Text = "Away";
            this.awaybtn.UseVisualStyleBackColor = false;
            this.awaybtn.Click += new System.EventHandler(this.awaybtn_Click);
            // 
            // Closebtn
            // 
            this.Closebtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Closebtn.Location = new System.Drawing.Point(693, 12);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(95, 43);
            this.Closebtn.TabIndex = 4;
            this.Closebtn.Text = "Close";
            this.Closebtn.UseVisualStyleBackColor = false;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // btnrestart
            // 
            this.btnrestart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnrestart.Location = new System.Drawing.Point(12, 12);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(95, 43);
            this.btnrestart.TabIndex = 5;
            this.btnrestart.Text = "Restart";
            this.btnrestart.UseVisualStyleBackColor = false;
            this.btnrestart.Click += new System.EventHandler(this.btnrestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gun_Project.Properties.Resources._66_662906_gun_game_playlist_icon_bo3_bo3_gun_game;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnrestart);
            this.Controls.Add(this.Closebtn);
            this.Controls.Add(this.awaybtn);
            this.Controls.Add(this.shootbtn);
            this.Controls.Add(this.Rollbtn);
            this.Controls.Add(this.Loadbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Loadbtn;
        private System.Windows.Forms.Button Rollbtn;
        private System.Windows.Forms.Button shootbtn;
        private System.Windows.Forms.Button awaybtn;
        private System.Windows.Forms.Button Closebtn;
        private System.Windows.Forms.Button btnrestart;
    }
}

