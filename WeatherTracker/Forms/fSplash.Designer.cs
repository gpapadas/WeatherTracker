namespace WeatherTracker.Forms
{
    partial class fSplash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblApplicationTitle = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            //this.SuspendLayout();
            // 
            // lblApplicationTitle
            // 
            //this.lblApplicationTitle.Appearance.Font = new System.Drawing.Font( "Microsoft Sans Serif", 20F );
            //this.lblApplicationTitle.Appearance.Options.UseFont = true;
            this.lblApplicationTitle.Location = new System.Drawing.Point( 12, 66 );
            this.lblApplicationTitle.Name = "lblApplicationTitle";
            this.lblApplicationTitle.Size = new System.Drawing.Size( 192, 31 );
            this.lblApplicationTitle.TabIndex = 0;
            this.lblApplicationTitle.Text = "Application Title";
            // 
            // lblVersion
            // 
            //this.lblVersion.Appearance.Font = new System.Drawing.Font( "Microsoft Sans Serif", 12F );
            //this.lblVersion.Appearance.Options.UseFont = true;
            this.lblVersion.Location = new System.Drawing.Point( 12, 114 );
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size( 54, 20 );
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Version";
            // 
            // lblCopyright
            // 
            //this.lblCopyright.Appearance.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F );
            //this.lblCopyright.Appearance.Options.UseFont = true;
            this.lblCopyright.Location = new System.Drawing.Point( 12, 153 );
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size( 44, 13 );
            this.lblCopyright.TabIndex = 2;
            this.lblCopyright.Text = "Copyright";
            // 
            // fSplash
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.BackgroundImage = global::WeatherTracker.Properties.Resources.mountain;
            //this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            //this.ClientSize = new System.Drawing.Size( 400, 300 );
            //this.Controls.Add( this.lblCopyright );
            //this.Controls.Add( this.lblVersion );
            //this.Controls.Add( this.lblApplicationTitle );
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.Name = "fSplash";
            //this.ShowInTaskbar = false;
            //this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            //this.Text = "fSplash";
            //this.ResumeLayout( false );
            //this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApplicationTitle;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblCopyright;
    }
}