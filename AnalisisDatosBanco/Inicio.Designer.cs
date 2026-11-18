namespace AnalisisDatosBanco
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

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelCard = new System.Windows.Forms.Panel();
            this.tablaDatos = new System.Windows.Forms.TableLayoutPanel();
            this.lblAnio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2023 = new System.Windows.Forms.Label();
            this.label2024 = new System.Windows.Forms.Label();
            this.label2025 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelCard.SuspendLayout();
            this.tablaDatos.SuspendLayout();
            this.SuspendLayout();
            //
            // panelHeader
            //
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.panelHeader.Controls.Add(this.lblSubtitulo);
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(760, 90);
            this.panelHeader.TabIndex = 0;
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(28, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Análisis de datos bancarios";
            //
            // lblSubtitulo
            //
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(190, 205, 225);
            this.lblSubtitulo.Location = new System.Drawing.Point(31, 54);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Text = "Ingresá los valores de cada banco por año";
            //
            // panelCard
            //
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCard.Controls.Add(this.tablaDatos);
            this.panelCard.Location = new System.Drawing.Point(30, 115);
            this.panelCard.Name = "panelCard";
            this.panelCard.Padding = new System.Windows.Forms.Padding(16);
            this.panelCard.Size = new System.Drawing.Size(700, 230);
            this.panelCard.TabIndex = 1;
            //
            // tablaDatos
            //
            this.tablaDatos.ColumnCount = 4;
            this.tablaDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tablaDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tablaDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tablaDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tablaDatos.RowCount = 4;
            this.tablaDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tablaDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tablaDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tablaDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tablaDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaDatos.Name = "tablaDatos";
            this.tablaDatos.TabIndex = 0;
            this.tablaDatos.Controls.Add(this.lblAnio, 0, 0);
            this.tablaDatos.Controls.Add(this.label4, 1, 0);
            this.tablaDatos.Controls.Add(this.label5, 2, 0);
            this.tablaDatos.Controls.Add(this.label6, 3, 0);
            this.tablaDatos.Controls.Add(this.label2023, 0, 1);
            this.tablaDatos.Controls.Add(this.textBox1, 1, 1);
            this.tablaDatos.Controls.Add(this.textBox2, 2, 1);
            this.tablaDatos.Controls.Add(this.textBox3, 3, 1);
            this.tablaDatos.Controls.Add(this.label2024, 0, 2);
            this.tablaDatos.Controls.Add(this.textBox6, 1, 2);
            this.tablaDatos.Controls.Add(this.textBox5, 2, 2);
            this.tablaDatos.Controls.Add(this.textBox4, 3, 2);
            this.tablaDatos.Controls.Add(this.label2025, 0, 3);
            this.tablaDatos.Controls.Add(this.textBox9, 1, 3);
            this.tablaDatos.Controls.Add(this.textBox8, 2, 3);
            this.tablaDatos.Controls.Add(this.textBox7, 3, 3);
            //
            // lblAnio
            //
            this.lblAnio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAnio.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.lblAnio.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Text = "Año";
            this.lblAnio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // label4
            //
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.label4.Name = "label4";
            this.label4.Text = "Banco Provincia";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // label5
            //
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.label5.Name = "label5";
            this.label5.Text = "Banco Nación";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // label6
            //
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(30, 58, 95);
            this.label6.Name = "label6";
            this.label6.Text = "Banco Hipotecario";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // label2023
            //
            this.label2023.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2023.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.label2023.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.label2023.Name = "label2023";
            this.label2023.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label2023.Text = "2023";
            this.label2023.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // label2024
            //
            this.label2024.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2024.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.label2024.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.label2024.Name = "label2024";
            this.label2024.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label2024.Text = "2024";
            this.label2024.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // label2025
            //
            this.label2025.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2025.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.label2025.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.label2025.Name = "label2025";
            this.label2025.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label2025.Text = "2025";
            this.label2025.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // textBox1
            //
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBox1.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // textBox2
            //
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBox2.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.TabIndex = 1;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // textBox3
            //
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBox3.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.TabIndex = 2;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // textBox6
            //
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBox6.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBox6.Name = "textBox6";
            this.textBox6.TabIndex = 3;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // textBox5
            //
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBox5.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBox5.Name = "textBox5";
            this.textBox5.TabIndex = 4;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // textBox4
            //
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBox4.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.TabIndex = 5;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // textBox9
            //
            this.textBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox9.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox9.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBox9.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBox9.Name = "textBox9";
            this.textBox9.TabIndex = 6;
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // textBox8
            //
            this.textBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox8.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBox8.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBox8.Name = "textBox8";
            this.textBox8.TabIndex = 7;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // textBox7
            //
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBox7.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBox7.Name = "textBox7";
            this.textBox7.TabIndex = 8;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // btnAnalizar
            //
            this.btnAnalizar.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnAnalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnalizar.FlatAppearance.BorderSize = 0;
            this.btnAnalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalizar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnAnalizar.ForeColor = System.Drawing.Color.White;
            this.btnAnalizar.Location = new System.Drawing.Point(590, 365);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(140, 38);
            this.btnAnalizar.TabIndex = 9;
            this.btnAnalizar.Text = "Analizar";
            this.btnAnalizar.UseVisualStyleBackColor = false;
            //
            // btnLimpiar
            //
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnLimpiar.Location = new System.Drawing.Point(440, 365);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(140, 38);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            //
            // Inicio
            //
            this.AcceptButton = this.btnAnalizar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(760, 430);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAnalizar);
            this.Controls.Add(this.panelCard);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Análisis de Datos Bancarios";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tablaDatos.ResumeLayout(false);
            this.tablaDatos.PerformLayout();
            this.panelCard.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.TableLayoutPanel tablaDatos;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label2023;
        private System.Windows.Forms.Label label2024;
        private System.Windows.Forms.Label label2025;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}