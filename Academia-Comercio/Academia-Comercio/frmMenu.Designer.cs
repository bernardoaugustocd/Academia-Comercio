namespace Academia_Comercio
{
    partial class frmMenu
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
            lblTitulo_Menu = new Label();
            SuspendLayout();
            // 
            // lblTitulo_Menu
            // 
            lblTitulo_Menu.AutoSize = true;
            lblTitulo_Menu.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo_Menu.Location = new Point(264, 38);
            lblTitulo_Menu.Name = "lblTitulo_Menu";
            lblTitulo_Menu.Size = new Size(246, 45);
            lblTitulo_Menu.TabIndex = 0;
            lblTitulo_Menu.Text = "Menu Principal";
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitulo_Menu);
            Name = "frmMenu";
            Text = "frmMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo_Menu;
    }
}