
namespace WhatsappAPI_Creator
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ExitButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.NumberW = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.TextW = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.API = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ExitButton
            // 
            this.ExitButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitButton.BorderRadius = 0;
            this.ExitButton.ButtonText = "X";
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.DisabledColor = System.Drawing.Color.Gray;
            this.ExitButton.Iconcolor = System.Drawing.Color.Transparent;
            this.ExitButton.Iconimage = null;
            this.ExitButton.Iconimage_right = null;
            this.ExitButton.Iconimage_right_Selected = null;
            this.ExitButton.Iconimage_Selected = null;
            this.ExitButton.IconMarginLeft = 0;
            this.ExitButton.IconMarginRight = 0;
            this.ExitButton.IconRightVisible = true;
            this.ExitButton.IconRightZoom = 0D;
            this.ExitButton.IconVisible = true;
            this.ExitButton.IconZoom = 90D;
            this.ExitButton.IsTab = false;
            this.ExitButton.Location = new System.Drawing.Point(602, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Normalcolor = System.Drawing.Color.Red;
            this.ExitButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExitButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.ExitButton.selected = false;
            this.ExitButton.Size = new System.Drawing.Size(40, 34);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "X";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitButton.Textcolor = System.Drawing.Color.Black;
            this.ExitButton.TextFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // NumberW
            // 
            this.NumberW.BorderColorFocused = System.Drawing.Color.Blue;
            this.NumberW.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NumberW.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.NumberW.BorderThickness = 3;
            this.NumberW.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumberW.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NumberW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NumberW.isPassword = false;
            this.NumberW.Location = new System.Drawing.Point(160, 13);
            this.NumberW.Margin = new System.Windows.Forms.Padding(4);
            this.NumberW.Name = "NumberW";
            this.NumberW.Size = new System.Drawing.Size(419, 44);
            this.NumberW.TabIndex = 1;
            this.NumberW.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TextW
            // 
            this.TextW.BorderColorFocused = System.Drawing.Color.Blue;
            this.TextW.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextW.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.TextW.BorderThickness = 3;
            this.TextW.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextW.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextW.isPassword = false;
            this.TextW.Location = new System.Drawing.Point(160, 65);
            this.TextW.Margin = new System.Windows.Forms.Padding(4);
            this.TextW.Name = "TextW";
            this.TextW.Size = new System.Drawing.Size(419, 44);
            this.TextW.TabIndex = 2;
            this.TextW.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Create Whatsapp API Link";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(12, 256);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(583, 48);
            this.bunifuFlatButton1.TabIndex = 3;
            this.bunifuFlatButton1.Text = "Create Whatsapp API Link";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FloralWhite;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(7, 26);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(146, 18);
            this.bunifuCustomLabel1.TabIndex = 4;
            this.bunifuCustomLabel1.Text = "Whatsapp Number: \r\n";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FloralWhite;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(52, 78);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(101, 18);
            this.bunifuCustomLabel2.TabIndex = 5;
            this.bunifuCustomLabel2.Text = "Custom Text: \r\n";
            // 
            // API
            // 
            this.API.BorderColorFocused = System.Drawing.Color.Blue;
            this.API.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.API.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.API.BorderThickness = 3;
            this.API.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.API.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.API.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.API.isPassword = false;
            this.API.Location = new System.Drawing.Point(160, 144);
            this.API.Margin = new System.Windows.Forms.Padding(4);
            this.API.Name = "API";
            this.API.Size = new System.Drawing.Size(419, 44);
            this.API.TabIndex = 6;
            this.API.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FloralWhite;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(7, 158);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(148, 18);
            this.bunifuCustomLabel3.TabIndex = 7;
            this.bunifuCustomLabel3.Text = "Whatsapp API Link: ";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuGradientPanel1.Controls.Add(this.NumberW);
            this.bunifuGradientPanel1.Controls.Add(this.API);
            this.bunifuGradientPanel1.Controls.Add(this.TextW);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Gray;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DarkGray;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(12, 38);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(583, 212);
            this.bunifuGradientPanel1.TabIndex = 8;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Arial", 16F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(12, 9);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(292, 25);
            this.bunifuCustomLabel4.TabIndex = 9;
            this.bunifuCustomLabel4.Text = "Whatsapp API Link Creator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 316);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(642, 316);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(642, 316);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Whatsapp API Link Creator";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton ExitButton;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMetroTextbox API;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuMetroTextbox TextW;
        private Bunifu.Framework.UI.BunifuMetroTextbox NumberW;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
    }
}

