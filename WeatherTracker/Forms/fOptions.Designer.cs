namespace WeatherTracker.Forms
{
    partial class fOptions
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
            this.lblCurrentZIPCode = new System.Windows.Forms.Label();
            this.txtCurrentZIPCode = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            //( (System.ComponentModel.ISupportInitialize) ( this.txtCurrentZIPCode.Properties ) ).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurrentZIPCode
            // 
            this.lblCurrentZIPCode.Location = new System.Drawing.Point( 26, 24 );
            this.lblCurrentZIPCode.Name = "lblCurrentZIPCode";
            this.lblCurrentZIPCode.Size = new System.Drawing.Size( 88, 13 );
            this.lblCurrentZIPCode.TabIndex = 0;
            this.lblCurrentZIPCode.Text = "Κωδικός περιοχής:";
            // 
            // txtCurrentZIPCode
            // 
            this.txtCurrentZIPCode.Location = new System.Drawing.Point( 120, 21 );
            this.txtCurrentZIPCode.Name = "txtCurrentZIPCode";
            //this.txtCurrentZIPCode.Properties.Appearance.BackColor = System.Drawing.Color.White;
            //this.txtCurrentZIPCode.Properties.Appearance.Options.UseBackColor = true;
            this.txtCurrentZIPCode.Size = new System.Drawing.Size( 160, 20 );
            this.txtCurrentZIPCode.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point( 54, 89 );
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size( 75, 23 );
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point( 163, 89 );
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size( 75, 23 );
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "’κυρο";
            // 
            // fOptions
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size( 292, 266 );
            this.ControlBox = false;
            this.Controls.Add( this.btnCancel );
            this.Controls.Add( this.btnOK );
            this.Controls.Add( this.txtCurrentZIPCode );
            this.Controls.Add( this.lblCurrentZIPCode );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fOptions";
            this.Text = "Επιλογές";
            //( (System.ComponentModel.ISupportInitialize) ( this.txtCurrentZIPCode.Properties ) ).EndInit();
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentZIPCode;
        private System.Windows.Forms.TextBox txtCurrentZIPCode;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}