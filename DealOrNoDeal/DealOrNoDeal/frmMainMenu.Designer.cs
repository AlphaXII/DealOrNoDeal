
namespace DealOrNoDeal
{
    partial class frmMainMenu
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
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.AutoSize = true;
            this.lblMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMenu.Location = new System.Drawing.Point(307, 49);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(182, 32);
            this.lblMainMenu.TabIndex = 0;
            this.lblMainMenu.Text = "MAIN MENU";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMainMenu);
            this.Name = "frmMainMenu";
            this.Text = "Deal Or No Deal Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainMenu;
    }
}

