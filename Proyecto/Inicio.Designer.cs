namespace Proyecto
{
    partial class Inicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuelemento = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu2 = new System.Windows.Forms.MenuStrip();
            this.lblusuario = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.ForestGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(333, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1031, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "SISTEMA DE CONTROL Y PRÉSTAMO DE ELEMENTOS DE FORMACIÓN";
            // 
            // menu
            // 
            this.menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuelemento,
            this.uSUARIOToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 82);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1736, 65);
            this.menu.TabIndex = 5;
            this.menu.Text = "menuStrip1";
            // 
            // menuelemento
            // 
            this.menuelemento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuelemento.Name = "menuelemento";
            this.menuelemento.Size = new System.Drawing.Size(96, 61);
            this.menuelemento.Text = "ELEMENTO";
            this.menuelemento.Click += new System.EventHandler(this.menuelemento_Click);
            // 
            // uSUARIOToolStripMenuItem
            // 
            this.uSUARIOToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.uSUARIOToolStripMenuItem.Name = "uSUARIOToolStripMenuItem";
            this.uSUARIOToolStripMenuItem.Size = new System.Drawing.Size(85, 61);
            this.uSUARIOToolStripMenuItem.Text = "USUARIO";
            // 
            // menu2
            // 
            this.menu2.AutoSize = false;
            this.menu2.BackColor = System.Drawing.Color.ForestGreen;
            this.menu2.Enabled = false;
            this.menu2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menu2.GripMargin = new System.Windows.Forms.Padding(5);
            this.menu2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menu2.Location = new System.Drawing.Point(0, 0);
            this.menu2.Name = "menu2";
            this.menu2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menu2.Size = new System.Drawing.Size(1736, 82);
            this.menu2.TabIndex = 6;
            this.menu2.Text = "menuStrip2";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.ForestGreen;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(134, 31);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(0, 20);
            this.lblusuario.TabIndex = 7;
            // 
            // contenedor
            // 
            this.contenedor.Location = new System.Drawing.Point(0, 150);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1736, 551);
            this.contenedor.TabIndex = 8;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.ForestGreen;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(1545, 8);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(1);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(184, 29);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.Text = "Cerrar sesión";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.btncerrarsesion_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.ForestGreen;
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton2.IconSize = 20;
            this.iconButton2.Location = new System.Drawing.Point(1545, 45);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(1);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(184, 29);
            this.iconButton2.TabIndex = 4;
            this.iconButton2.Text = "Generar";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1736, 704);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menu2);
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuelemento;
        private System.Windows.Forms.ToolStripMenuItem uSUARIOToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menu2;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Panel contenedor;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}

