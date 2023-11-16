namespace projet_de_groupe.View
{
    partial class categoryView
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
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.CheckedState.ImageSize = new System.Drawing.Size(55, 55);
            this.BtnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnAdd.HoverState.ImageSize = new System.Drawing.Size(57, 57);
            this.BtnAdd.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            this.BtnAdd.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(133, 30);
            this.label2.Text = "Category List";
            // 
            // categoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 450);
            this.Name = "categoryView";
            this.Text = "categoryView";
            this.Load += new System.EventHandler(this.categoryView_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.BtnAdd, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.guna2Separator1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}