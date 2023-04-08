namespace the_final_travel_system
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.project_name = new System.Windows.Forms.Label();
            this.Bus_button = new System.Windows.Forms.Button();
            this.Train_button = new System.Windows.Forms.Button();
            this.Plane_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // project_name
            // 
            this.project_name.BackColor = System.Drawing.Color.Transparent;
            this.project_name.Font = new System.Drawing.Font("Snap ITC", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.project_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.project_name.Location = new System.Drawing.Point(435, 31);
            this.project_name.Name = "project_name";
            this.project_name.Size = new System.Drawing.Size(500, 125);
            this.project_name.TabIndex = 0;
            this.project_name.Text = "ya-msafer ";
            this.project_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bus_button
            // 
            this.Bus_button.AutoSize = true;
            this.Bus_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Bus_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Bus_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bus_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bus_button.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bus_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Bus_button.Location = new System.Drawing.Point(203, 394);
            this.Bus_button.Name = "Bus_button";
            this.Bus_button.Size = new System.Drawing.Size(134, 89);
            this.Bus_button.TabIndex = 1;
            this.Bus_button.Text = "Bus";
            this.Bus_button.UseVisualStyleBackColor = false;
            this.Bus_button.Click += new System.EventHandler(this.Bus_button_Click);
            // 
            // Train_button
            // 
            this.Train_button.AutoSize = true;
            this.Train_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Train_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Train_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Train_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Train_button.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Train_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Train_button.Location = new System.Drawing.Point(593, 394);
            this.Train_button.Name = "Train_button";
            this.Train_button.Size = new System.Drawing.Size(171, 89);
            this.Train_button.TabIndex = 2;
            this.Train_button.Text = "Train";
            this.Train_button.UseVisualStyleBackColor = false;
            this.Train_button.Click += new System.EventHandler(this.Train_button_Click);
            // 
            // Plane_button
            // 
            this.Plane_button.AutoSize = true;
            this.Plane_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Plane_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Plane_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Plane_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Plane_button.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plane_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Plane_button.Location = new System.Drawing.Point(1036, 394);
            this.Plane_button.Name = "Plane_button";
            this.Plane_button.Size = new System.Drawing.Size(177, 89);
            this.Plane_button.TabIndex = 3;
            this.Plane_button.Text = "Plane";
            this.Plane_button.UseVisualStyleBackColor = false;
            this.Plane_button.Click += new System.EventHandler(this.Plane_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.Plane_button);
            this.Controls.Add(this.Train_button);
            this.Controls.Add(this.Bus_button);
            this.Controls.Add(this.project_name);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ya-msafer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label project_name;
        private System.Windows.Forms.Button Bus_button;
        private System.Windows.Forms.Button Train_button;
        private System.Windows.Forms.Button Plane_button;
    }
}

