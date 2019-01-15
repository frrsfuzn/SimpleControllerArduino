namespace SimpleControllerArduino
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
            this.merahOn = new System.Windows.Forms.Button();
            this.merahOff = new System.Windows.Forms.Button();
            this.hijauOn = new System.Windows.Forms.Button();
            this.hijauOff = new System.Windows.Forms.Button();
            this.biruOn = new System.Windows.Forms.Button();
            this.biruOff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // merahOn
            // 
            this.merahOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.merahOn.Location = new System.Drawing.Point(29, 71);
            this.merahOn.Name = "merahOn";
            this.merahOn.Size = new System.Drawing.Size(124, 53);
            this.merahOn.TabIndex = 0;
            this.merahOn.Text = "ON";
            this.merahOn.UseVisualStyleBackColor = true;
            this.merahOn.Click += new System.EventHandler(this.merahOn_Click);
            // 
            // merahOff
            // 
            this.merahOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.merahOff.Location = new System.Drawing.Point(29, 130);
            this.merahOff.Name = "merahOff";
            this.merahOff.Size = new System.Drawing.Size(124, 53);
            this.merahOff.TabIndex = 1;
            this.merahOff.Text = "OFF";
            this.merahOff.UseVisualStyleBackColor = true;
            this.merahOff.Click += new System.EventHandler(this.merahOff_Click);
            // 
            // hijauOn
            // 
            this.hijauOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hijauOn.Location = new System.Drawing.Point(185, 71);
            this.hijauOn.Name = "hijauOn";
            this.hijauOn.Size = new System.Drawing.Size(124, 53);
            this.hijauOn.TabIndex = 2;
            this.hijauOn.Text = "ON";
            this.hijauOn.UseVisualStyleBackColor = true;
            this.hijauOn.Click += new System.EventHandler(this.hijauOn_Click);
            // 
            // hijauOff
            // 
            this.hijauOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hijauOff.Location = new System.Drawing.Point(185, 130);
            this.hijauOff.Name = "hijauOff";
            this.hijauOff.Size = new System.Drawing.Size(124, 53);
            this.hijauOff.TabIndex = 3;
            this.hijauOff.Text = "OFF";
            this.hijauOff.UseVisualStyleBackColor = true;
            this.hijauOff.Click += new System.EventHandler(this.hijauOff_Click);
            // 
            // biruOn
            // 
            this.biruOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biruOn.Location = new System.Drawing.Point(341, 71);
            this.biruOn.Name = "biruOn";
            this.biruOn.Size = new System.Drawing.Size(124, 53);
            this.biruOn.TabIndex = 4;
            this.biruOn.Text = "ON";
            this.biruOn.UseVisualStyleBackColor = true;
            this.biruOn.Click += new System.EventHandler(this.biruOn_Click);
            // 
            // biruOff
            // 
            this.biruOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biruOff.Location = new System.Drawing.Point(341, 130);
            this.biruOff.Name = "biruOff";
            this.biruOff.Size = new System.Drawing.Size(124, 53);
            this.biruOff.TabIndex = 5;
            this.biruOff.Text = "OFF";
            this.biruOff.UseVisualStyleBackColor = true;
            this.biruOff.Click += new System.EventHandler(this.biruOff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "LED Merah";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "LED Hijau";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(361, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "LED Biru";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 209);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.biruOff);
            this.Controls.Add(this.biruOn);
            this.Controls.Add(this.hijauOff);
            this.Controls.Add(this.hijauOn);
            this.Controls.Add(this.merahOff);
            this.Controls.Add(this.merahOn);
            this.Name = "Form1";
            this.Text = "SimpleController";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button merahOn;
        private System.Windows.Forms.Button merahOff;
        private System.Windows.Forms.Button hijauOn;
        private System.Windows.Forms.Button hijauOff;
        private System.Windows.Forms.Button biruOn;
        private System.Windows.Forms.Button biruOff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

