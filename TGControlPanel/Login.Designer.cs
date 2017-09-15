﻿namespace TGControlPanel
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.LocalLoginButton = new System.Windows.Forms.Button();
			this.CurrentRevisionTitle = new System.Windows.Forms.Label();
			this.IPTextBox = new System.Windows.Forms.TextBox();
			this.UsernameTextBox = new System.Windows.Forms.TextBox();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.RemoteLoginButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// LocalLoginButton
			// 
			this.LocalLoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.LocalLoginButton.Location = new System.Drawing.Point(51, 12);
			this.LocalLoginButton.Name = "LocalLoginButton";
			this.LocalLoginButton.Size = new System.Drawing.Size(188, 25);
			this.LocalLoginButton.TabIndex = 13;
			this.LocalLoginButton.Text = "Connect to Local Service";
			this.LocalLoginButton.UseVisualStyleBackColor = true;
			this.LocalLoginButton.Click += new System.EventHandler(this.LocalLoginButton_Click);
			// 
			// CurrentRevisionTitle
			// 
			this.CurrentRevisionTitle.AutoSize = true;
			this.CurrentRevisionTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CurrentRevisionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
			this.CurrentRevisionTitle.Location = new System.Drawing.Point(81, 76);
			this.CurrentRevisionTitle.Name = "CurrentRevisionTitle";
			this.CurrentRevisionTitle.Size = new System.Drawing.Size(128, 18);
			this.CurrentRevisionTitle.TabIndex = 14;
			this.CurrentRevisionTitle.Text = "Remote Login:";
			this.CurrentRevisionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// IPTextBox
			// 
			this.IPTextBox.Location = new System.Drawing.Point(73, 97);
			this.IPTextBox.Name = "IPTextBox";
			this.IPTextBox.Size = new System.Drawing.Size(199, 20);
			this.IPTextBox.TabIndex = 15;
			// 
			// UsernameTextBox
			// 
			this.UsernameTextBox.Location = new System.Drawing.Point(73, 130);
			this.UsernameTextBox.Name = "UsernameTextBox";
			this.UsernameTextBox.Size = new System.Drawing.Size(199, 20);
			this.UsernameTextBox.TabIndex = 16;
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.Location = new System.Drawing.Point(73, 162);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.Size = new System.Drawing.Size(199, 20);
			this.PasswordTextBox.TabIndex = 17;
			this.PasswordTextBox.UseSystemPasswordChar = true;
			// 
			// RemoteLoginButton
			// 
			this.RemoteLoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.RemoteLoginButton.Location = new System.Drawing.Point(51, 197);
			this.RemoteLoginButton.Name = "RemoteLoginButton";
			this.RemoteLoginButton.Size = new System.Drawing.Size(188, 25);
			this.RemoteLoginButton.TabIndex = 18;
			this.RemoteLoginButton.Text = "Connect to Remote Service";
			this.RemoteLoginButton.UseVisualStyleBackColor = true;
			this.RemoteLoginButton.Click += new System.EventHandler(this.RemoteLoginButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
			this.label1.Location = new System.Drawing.Point(9, 99);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 18);
			this.label1.TabIndex = 19;
			this.label1.Text = "IP:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
			this.label2.Location = new System.Drawing.Point(9, 132);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 18);
			this.label2.TabIndex = 20;
			this.label2.Text = "User:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
			this.label3.Location = new System.Drawing.Point(9, 164);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 18);
			this.label3.TabIndex = 21;
			this.label3.Text = "Pass:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
			this.label4.Location = new System.Drawing.Point(-19, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(468, 18);
			this.label4.TabIndex = 22;
			this.label4.Text = "______________________________________________";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
			this.ClientSize = new System.Drawing.Size(284, 237);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.RemoteLoginButton);
			this.Controls.Add(this.PasswordTextBox);
			this.Controls.Add(this.UsernameTextBox);
			this.Controls.Add(this.IPTextBox);
			this.Controls.Add(this.CurrentRevisionTitle);
			this.Controls.Add(this.LocalLoginButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Login";
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button LocalLoginButton;
		private System.Windows.Forms.Label CurrentRevisionTitle;
		private System.Windows.Forms.TextBox IPTextBox;
		private System.Windows.Forms.TextBox UsernameTextBox;
		private System.Windows.Forms.TextBox PasswordTextBox;
		private System.Windows.Forms.Button RemoteLoginButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}