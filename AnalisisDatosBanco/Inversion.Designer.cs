namespace AnalisisDatosBanco
{
    partial class Inversion
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelCard = new System.Windows.Forms.Panel();
            this.tablaDatos = new System.Windows.Forms.TableLayoutPanel();
            this.lblAnio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelMensual = new System.Windows.Forms.Label();
            this.textBox2023Provincia = new System.Windows.Forms.TextBox();
            this.textBox2023Nacion = new System.Windows.Forms.TextBox();
            this.textBox2023Hipotecario = new System.Windows.Forms.TextBox();
            this.lblTrimestral = new System.Windows.Forms.Label();
            this.textBox2024Provincia = new System.Windows.Forms.TextBox();
            this.textBox2024Nacion = new System.Windows.Forms.TextBox();
            this.textBox2024Hipotecario = new System.Windows.Forms.TextBox();
            this.labelAnual = new System.Windows.Forms.Label();
            this.textBox2025Provincia = new System.Windows.Forms.TextBox();
            this.textBox2025Nacion = new System.Windows.Forms.TextBox();
            this.textBox2025Hipotecario = new System.Windows.Forms.TextBox();
            this.labelMejorOpcion = new System.Windows.Forms.Label();
            this.textBoxPromedioProvincia = new System.Windows.Forms.TextBox();
            this.textBoxPromedioNacion = new System.Windows.Forms.TextBox();
            this.textBoxPromedioHipotecario = new System.Windows.Forms.TextBox();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelCard.SuspendLayout();
            this.tablaDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.panelHeader.Controls.Add(this.lblSubtitulo);
            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(760, 1314);
            this.panelHeader.TabIndex = 0;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(205)))), ((int)(((byte)(225)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(31, 54);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(266, 19);
            this.lblSubtitulo.TabIndex = 0;
            this.lblSubtitulo.Text = "Ingrese los valores de cada banco por año";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 18F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(28, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(307, 32);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Análisis de datos bancarios";
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCard.Controls.Add(this.tablaDatos);
            this.panelCard.Location = new System.Drawing.Point(30, 130);
            this.panelCard.Name = "panelCard";
            this.panelCard.Padding = new System.Windows.Forms.Padding(16);
            this.panelCard.Size = new System.Drawing.Size(700, 285);
            this.panelCard.TabIndex = 1;
            // 
            // tablaDatos
            // 
            this.tablaDatos.ColumnCount = 4;
            this.tablaDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tablaDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tablaDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tablaDatos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tablaDatos.Controls.Add(this.lblAnio, 0, 0);
            this.tablaDatos.Controls.Add(this.label4, 1, 0);
            this.tablaDatos.Controls.Add(this.label5, 2, 0);
            this.tablaDatos.Controls.Add(this.label6, 3, 0);
            this.tablaDatos.Controls.Add(this.labelMensual, 0, 1);
            this.tablaDatos.Controls.Add(this.textBox2023Provincia, 1, 1);
            this.tablaDatos.Controls.Add(this.textBox2023Nacion, 2, 1);
            this.tablaDatos.Controls.Add(this.textBox2023Hipotecario, 3, 1);
            this.tablaDatos.Controls.Add(this.lblTrimestral, 0, 2);
            this.tablaDatos.Controls.Add(this.textBox2024Provincia, 1, 2);
            this.tablaDatos.Controls.Add(this.textBox2024Nacion, 2, 2);
            this.tablaDatos.Controls.Add(this.textBox2024Hipotecario, 3, 2);
            this.tablaDatos.Controls.Add(this.labelAnual, 0, 3);
            this.tablaDatos.Controls.Add(this.textBox2025Provincia, 1, 3);
            this.tablaDatos.Controls.Add(this.textBox2025Nacion, 2, 3);
            this.tablaDatos.Controls.Add(this.textBox2025Hipotecario, 3, 3);
            this.tablaDatos.Controls.Add(this.labelMejorOpcion, 0, 4);
            this.tablaDatos.Controls.Add(this.textBoxPromedioProvincia, 1, 4);
            this.tablaDatos.Controls.Add(this.textBoxPromedioNacion, 2, 4);
            this.tablaDatos.Controls.Add(this.textBoxPromedioHipotecario, 3, 4);
            this.tablaDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaDatos.Location = new System.Drawing.Point(16, 16);
            this.tablaDatos.Name = "tablaDatos";
            this.tablaDatos.RowCount = 5;
            this.tablaDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tablaDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablaDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablaDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablaDatos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablaDatos.Size = new System.Drawing.Size(666, 251);
            this.tablaDatos.TabIndex = 0;
            // 
            // lblAnio
            // 
            this.lblAnio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAnio.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.lblAnio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.lblAnio.Location = new System.Drawing.Point(3, 0);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(94, 44);
            this.lblAnio.TabIndex = 0;
            this.lblAnio.Text = "Año";
            this.lblAnio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.label4.Location = new System.Drawing.Point(103, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 44);
            this.label4.TabIndex = 1;
            this.label4.Text = "Banco Provincia";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.label5.Location = new System.Drawing.Point(291, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 44);
            this.label5.TabIndex = 2;
            this.label5.Text = "Banco Nación";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.label6.Location = new System.Drawing.Point(479, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 44);
            this.label6.TabIndex = 3;
            this.label6.Text = "Banco Hipotecario";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMensual
            // 
            this.labelMensual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMensual.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.labelMensual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.labelMensual.Location = new System.Drawing.Point(3, 44);
            this.labelMensual.Name = "labelMensual";
            this.labelMensual.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.labelMensual.Size = new System.Drawing.Size(94, 51);
            this.labelMensual.TabIndex = 4;
            this.labelMensual.Text = "Mensual";
            this.labelMensual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox2023Provincia
            // 
            this.textBox2023Provincia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2023Provincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.textBox2023Provincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2023Provincia.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBox2023Provincia.Location = new System.Drawing.Point(110, 56);
            this.textBox2023Provincia.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBox2023Provincia.Name = "textBox2023Provincia";
            this.textBox2023Provincia.ReadOnly = true;
            this.textBox2023Provincia.Size = new System.Drawing.Size(168, 27);
            this.textBox2023Provincia.TabIndex = 0;
            this.textBox2023Provincia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2023Nacion
            // 
            this.textBox2023Nacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2023Nacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.textBox2023Nacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2023Nacion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBox2023Nacion.Location = new System.Drawing.Point(298, 56);
            this.textBox2023Nacion.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBox2023Nacion.Name = "textBox2023Nacion";
            this.textBox2023Nacion.ReadOnly = true;
            this.textBox2023Nacion.Size = new System.Drawing.Size(168, 27);
            this.textBox2023Nacion.TabIndex = 1;
            this.textBox2023Nacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2023Hipotecario
            // 
            this.textBox2023Hipotecario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2023Hipotecario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.textBox2023Hipotecario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2023Hipotecario.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBox2023Hipotecario.Location = new System.Drawing.Point(486, 56);
            this.textBox2023Hipotecario.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBox2023Hipotecario.Name = "textBox2023Hipotecario";
            this.textBox2023Hipotecario.ReadOnly = true;
            this.textBox2023Hipotecario.Size = new System.Drawing.Size(170, 27);
            this.textBox2023Hipotecario.TabIndex = 2;
            this.textBox2023Hipotecario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTrimestral
            // 
            this.lblTrimestral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTrimestral.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.lblTrimestral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblTrimestral.Location = new System.Drawing.Point(3, 95);
            this.lblTrimestral.Name = "lblTrimestral";
            this.lblTrimestral.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lblTrimestral.Size = new System.Drawing.Size(94, 51);
            this.lblTrimestral.TabIndex = 5;
            this.lblTrimestral.Text = "Trimestral";
            this.lblTrimestral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox2024Provincia
            // 
            this.textBox2024Provincia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2024Provincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.textBox2024Provincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2024Provincia.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBox2024Provincia.Location = new System.Drawing.Point(110, 107);
            this.textBox2024Provincia.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBox2024Provincia.Name = "textBox2024Provincia";
            this.textBox2024Provincia.ReadOnly = true;
            this.textBox2024Provincia.Size = new System.Drawing.Size(168, 27);
            this.textBox2024Provincia.TabIndex = 3;
            this.textBox2024Provincia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2024Nacion
            // 
            this.textBox2024Nacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2024Nacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.textBox2024Nacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2024Nacion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBox2024Nacion.Location = new System.Drawing.Point(298, 107);
            this.textBox2024Nacion.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBox2024Nacion.Name = "textBox2024Nacion";
            this.textBox2024Nacion.ReadOnly = true;
            this.textBox2024Nacion.Size = new System.Drawing.Size(168, 27);
            this.textBox2024Nacion.TabIndex = 4;
            this.textBox2024Nacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2024Hipotecario
            // 
            this.textBox2024Hipotecario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2024Hipotecario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.textBox2024Hipotecario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2024Hipotecario.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBox2024Hipotecario.Location = new System.Drawing.Point(486, 107);
            this.textBox2024Hipotecario.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBox2024Hipotecario.Name = "textBox2024Hipotecario";
            this.textBox2024Hipotecario.ReadOnly = true;
            this.textBox2024Hipotecario.Size = new System.Drawing.Size(170, 27);
            this.textBox2024Hipotecario.TabIndex = 5;
            this.textBox2024Hipotecario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelAnual
            // 
            this.labelAnual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAnual.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F);
            this.labelAnual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.labelAnual.Location = new System.Drawing.Point(3, 146);
            this.labelAnual.Name = "labelAnual";
            this.labelAnual.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.labelAnual.Size = new System.Drawing.Size(94, 51);
            this.labelAnual.TabIndex = 6;
            this.labelAnual.Text = "Anual";
            this.labelAnual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox2025Provincia
            // 
            this.textBox2025Provincia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2025Provincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.textBox2025Provincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2025Provincia.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBox2025Provincia.Location = new System.Drawing.Point(110, 158);
            this.textBox2025Provincia.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBox2025Provincia.Name = "textBox2025Provincia";
            this.textBox2025Provincia.ReadOnly = true;
            this.textBox2025Provincia.Size = new System.Drawing.Size(168, 27);
            this.textBox2025Provincia.TabIndex = 6;
            this.textBox2025Provincia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2025Nacion
            // 
            this.textBox2025Nacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2025Nacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.textBox2025Nacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2025Nacion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBox2025Nacion.Location = new System.Drawing.Point(298, 158);
            this.textBox2025Nacion.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBox2025Nacion.Name = "textBox2025Nacion";
            this.textBox2025Nacion.ReadOnly = true;
            this.textBox2025Nacion.Size = new System.Drawing.Size(168, 27);
            this.textBox2025Nacion.TabIndex = 7;
            this.textBox2025Nacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2025Hipotecario
            // 
            this.textBox2025Hipotecario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2025Hipotecario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.textBox2025Hipotecario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2025Hipotecario.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBox2025Hipotecario.Location = new System.Drawing.Point(486, 158);
            this.textBox2025Hipotecario.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBox2025Hipotecario.Name = "textBox2025Hipotecario";
            this.textBox2025Hipotecario.ReadOnly = true;
            this.textBox2025Hipotecario.Size = new System.Drawing.Size(170, 27);
            this.textBox2025Hipotecario.TabIndex = 8;
            this.textBox2025Hipotecario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelMejorOpcion
            // 
            this.labelMejorOpcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMejorOpcion.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.labelMejorOpcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.labelMejorOpcion.Location = new System.Drawing.Point(3, 197);
            this.labelMejorOpcion.Name = "labelMejorOpcion";
            this.labelMejorOpcion.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.labelMejorOpcion.Size = new System.Drawing.Size(94, 54);
            this.labelMejorOpcion.TabIndex = 7;
            this.labelMejorOpcion.Text = "Mejor Opción";
            this.labelMejorOpcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxPromedioProvincia
            // 
            this.textBoxPromedioProvincia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPromedioProvincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.textBoxPromedioProvincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPromedioProvincia.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.textBoxPromedioProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.textBoxPromedioProvincia.Location = new System.Drawing.Point(110, 210);
            this.textBoxPromedioProvincia.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBoxPromedioProvincia.Name = "textBoxPromedioProvincia";
            this.textBoxPromedioProvincia.ReadOnly = true;
            this.textBoxPromedioProvincia.Size = new System.Drawing.Size(168, 27);
            this.textBoxPromedioProvincia.TabIndex = 11;
            this.textBoxPromedioProvincia.TabStop = false;
            this.textBoxPromedioProvincia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxPromedioNacion
            // 
            this.textBoxPromedioNacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPromedioNacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.textBoxPromedioNacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPromedioNacion.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.textBoxPromedioNacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.textBoxPromedioNacion.Location = new System.Drawing.Point(298, 210);
            this.textBoxPromedioNacion.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBoxPromedioNacion.Name = "textBoxPromedioNacion";
            this.textBoxPromedioNacion.ReadOnly = true;
            this.textBoxPromedioNacion.Size = new System.Drawing.Size(168, 27);
            this.textBoxPromedioNacion.TabIndex = 12;
            this.textBoxPromedioNacion.TabStop = false;
            this.textBoxPromedioNacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxPromedioHipotecario
            // 
            this.textBoxPromedioHipotecario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPromedioHipotecario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.textBoxPromedioHipotecario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPromedioHipotecario.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.textBoxPromedioHipotecario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.textBoxPromedioHipotecario.Location = new System.Drawing.Point(486, 210);
            this.textBoxPromedioHipotecario.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBoxPromedioHipotecario.Name = "textBoxPromedioHipotecario";
            this.textBoxPromedioHipotecario.ReadOnly = true;
            this.textBoxPromedioHipotecario.Size = new System.Drawing.Size(170, 27);
            this.textBoxPromedioHipotecario.TabIndex = 13;
            this.textBoxPromedioHipotecario.TabStop = false;
            this.textBoxPromedioHipotecario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnAnalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnalizar.FlatAppearance.BorderSize = 0;
            this.btnAnalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalizar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnAnalizar.ForeColor = System.Drawing.Color.White;
            this.btnAnalizar.Location = new System.Drawing.Point(590, 420);
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
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btnLimpiar.Location = new System.Drawing.Point(440, 420);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(140, 38);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(590, 420);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(140, 38);
            this.btnSiguiente.TabIndex = 11;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            // 
            // Inversion
            // 
            this.AcceptButton = this.btnAnalizar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(760, 485);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAnalizar);
            this.Controls.Add(this.panelCard);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Inversion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Análisis de Datos Bancarios";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelCard.ResumeLayout(false);
            this.tablaDatos.ResumeLayout(false);
            this.tablaDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.TableLayoutPanel tablaDatos;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.TextBox textBox2023Provincia;
        private System.Windows.Forms.TextBox textBox2023Nacion;
        private System.Windows.Forms.TextBox textBox2023Hipotecario;
        private System.Windows.Forms.TextBox textBox2024Hipotecario;
        private System.Windows.Forms.TextBox textBox2024Nacion;
        private System.Windows.Forms.TextBox textBox2024Provincia;
        private System.Windows.Forms.TextBox textBox2025Hipotecario;
        private System.Windows.Forms.TextBox textBox2025Nacion;
        private System.Windows.Forms.TextBox textBox2025Provincia;
        private System.Windows.Forms.Label labelMensual;
        private System.Windows.Forms.Label lblTrimestral;
        private System.Windows.Forms.Label labelAnual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelMejorOpcion;
        private System.Windows.Forms.TextBox textBoxPromedioProvincia;
        private System.Windows.Forms.TextBox textBoxPromedioNacion;
        private System.Windows.Forms.TextBox textBoxPromedioHipotecario;
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSiguiente;
    }
}