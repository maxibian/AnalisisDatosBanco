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
            this.textBoxMensualProvincia = new System.Windows.Forms.TextBox();
            this.textBoxMensualNacion = new System.Windows.Forms.TextBox();
            this.textBoxMensualHipotecario = new System.Windows.Forms.TextBox();
            this.lblTrimestral = new System.Windows.Forms.Label();
            this.textBoxTrimestralProvincia = new System.Windows.Forms.TextBox();
            this.textBoxTrimestralNacion = new System.Windows.Forms.TextBox();
            this.textBoxTrimestralHipotecario = new System.Windows.Forms.TextBox();
            this.labelAnual = new System.Windows.Forms.Label();
            this.textBoxAnualProvincia = new System.Windows.Forms.TextBox();
            this.textBoxAnualNacion = new System.Windows.Forms.TextBox();
            this.textBoxAnualHipotecario = new System.Windows.Forms.TextBox();
            this.labelMejorOpcion = new System.Windows.Forms.Label();
            this.textBoxPromedioProvincia = new System.Windows.Forms.TextBox();
            this.textBoxPromedioNacion = new System.Windows.Forms.TextBox();
            this.textBoxPromedioHipotecario = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
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
            this.lblSubtitulo.Size = new System.Drawing.Size(183, 19);
            this.lblSubtitulo.TabIndex = 0;
            this.lblSubtitulo.Text = "Resultados por cada período";
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
            this.tablaDatos.Controls.Add(this.textBoxMensualProvincia, 1, 1);
            this.tablaDatos.Controls.Add(this.textBoxMensualNacion, 2, 1);
            this.tablaDatos.Controls.Add(this.textBoxMensualHipotecario, 3, 1);
            this.tablaDatos.Controls.Add(this.lblTrimestral, 0, 2);
            this.tablaDatos.Controls.Add(this.textBoxTrimestralProvincia, 1, 2);
            this.tablaDatos.Controls.Add(this.textBoxTrimestralNacion, 2, 2);
            this.tablaDatos.Controls.Add(this.textBoxTrimestralHipotecario, 3, 2);
            this.tablaDatos.Controls.Add(this.labelAnual, 0, 3);
            this.tablaDatos.Controls.Add(this.textBoxAnualProvincia, 1, 3);
            this.tablaDatos.Controls.Add(this.textBoxAnualNacion, 2, 3);
            this.tablaDatos.Controls.Add(this.textBoxAnualHipotecario, 3, 3);
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
            // textBoxMensualProvincia
            // 
            this.textBoxMensualProvincia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMensualProvincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.textBoxMensualProvincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMensualProvincia.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBoxMensualProvincia.Location = new System.Drawing.Point(110, 56);
            this.textBoxMensualProvincia.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBoxMensualProvincia.Name = "textBoxMensualProvincia";
            this.textBoxMensualProvincia.ReadOnly = true;
            this.textBoxMensualProvincia.Size = new System.Drawing.Size(168, 27);
            this.textBoxMensualProvincia.TabIndex = 0;
            this.textBoxMensualProvincia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxMensualNacion
            // 
            this.textBoxMensualNacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMensualNacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.textBoxMensualNacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMensualNacion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBoxMensualNacion.Location = new System.Drawing.Point(298, 56);
            this.textBoxMensualNacion.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBoxMensualNacion.Name = "textBoxMensualNacion";
            this.textBoxMensualNacion.ReadOnly = true;
            this.textBoxMensualNacion.Size = new System.Drawing.Size(168, 27);
            this.textBoxMensualNacion.TabIndex = 1;
            this.textBoxMensualNacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxMensualHipotecario
            // 
            this.textBoxMensualHipotecario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMensualHipotecario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.textBoxMensualHipotecario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMensualHipotecario.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBoxMensualHipotecario.Location = new System.Drawing.Point(486, 56);
            this.textBoxMensualHipotecario.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBoxMensualHipotecario.Name = "textBoxMensualHipotecario";
            this.textBoxMensualHipotecario.ReadOnly = true;
            this.textBoxMensualHipotecario.Size = new System.Drawing.Size(170, 27);
            this.textBoxMensualHipotecario.TabIndex = 2;
            this.textBoxMensualHipotecario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // textBoxTrimestralProvincia
            // 
            this.textBoxTrimestralProvincia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTrimestralProvincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.textBoxTrimestralProvincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTrimestralProvincia.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBoxTrimestralProvincia.Location = new System.Drawing.Point(110, 107);
            this.textBoxTrimestralProvincia.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBoxTrimestralProvincia.Name = "textBoxTrimestralProvincia";
            this.textBoxTrimestralProvincia.ReadOnly = true;
            this.textBoxTrimestralProvincia.Size = new System.Drawing.Size(168, 27);
            this.textBoxTrimestralProvincia.TabIndex = 3;
            this.textBoxTrimestralProvincia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTrimestralNacion
            // 
            this.textBoxTrimestralNacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTrimestralNacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.textBoxTrimestralNacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTrimestralNacion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBoxTrimestralNacion.Location = new System.Drawing.Point(298, 107);
            this.textBoxTrimestralNacion.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBoxTrimestralNacion.Name = "textBoxTrimestralNacion";
            this.textBoxTrimestralNacion.ReadOnly = true;
            this.textBoxTrimestralNacion.Size = new System.Drawing.Size(168, 27);
            this.textBoxTrimestralNacion.TabIndex = 4;
            this.textBoxTrimestralNacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTrimestralHipotecario
            // 
            this.textBoxTrimestralHipotecario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTrimestralHipotecario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.textBoxTrimestralHipotecario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTrimestralHipotecario.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBoxTrimestralHipotecario.Location = new System.Drawing.Point(486, 107);
            this.textBoxTrimestralHipotecario.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBoxTrimestralHipotecario.Name = "textBoxTrimestralHipotecario";
            this.textBoxTrimestralHipotecario.ReadOnly = true;
            this.textBoxTrimestralHipotecario.Size = new System.Drawing.Size(170, 27);
            this.textBoxTrimestralHipotecario.TabIndex = 5;
            this.textBoxTrimestralHipotecario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // textBoxAnualProvincia
            // 
            this.textBoxAnualProvincia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAnualProvincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.textBoxAnualProvincia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAnualProvincia.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBoxAnualProvincia.Location = new System.Drawing.Point(110, 158);
            this.textBoxAnualProvincia.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBoxAnualProvincia.Name = "textBoxAnualProvincia";
            this.textBoxAnualProvincia.ReadOnly = true;
            this.textBoxAnualProvincia.Size = new System.Drawing.Size(168, 27);
            this.textBoxAnualProvincia.TabIndex = 6;
            this.textBoxAnualProvincia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxAnualNacion
            // 
            this.textBoxAnualNacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAnualNacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.textBoxAnualNacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAnualNacion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBoxAnualNacion.Location = new System.Drawing.Point(298, 158);
            this.textBoxAnualNacion.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBoxAnualNacion.Name = "textBoxAnualNacion";
            this.textBoxAnualNacion.ReadOnly = true;
            this.textBoxAnualNacion.Size = new System.Drawing.Size(168, 27);
            this.textBoxAnualNacion.TabIndex = 7;
            this.textBoxAnualNacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxAnualHipotecario
            // 
            this.textBoxAnualHipotecario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAnualHipotecario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.textBoxAnualHipotecario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAnualHipotecario.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textBoxAnualHipotecario.Location = new System.Drawing.Point(486, 158);
            this.textBoxAnualHipotecario.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.textBoxAnualHipotecario.Name = "textBoxAnualHipotecario";
            this.textBoxAnualHipotecario.ReadOnly = true;
            this.textBoxAnualHipotecario.Size = new System.Drawing.Size(170, 27);
            this.textBoxAnualHipotecario.TabIndex = 8;
            this.textBoxAnualHipotecario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(590, 420);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(140, 38);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Inversion
            // 
            this.AcceptButton = this.btnVolver;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(760, 485);
            this.Controls.Add(this.btnVolver);
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
        private System.Windows.Forms.TextBox textBoxMensualProvincia;
        private System.Windows.Forms.TextBox textBoxMensualNacion;
        private System.Windows.Forms.TextBox textBoxMensualHipotecario;
        private System.Windows.Forms.TextBox textBoxTrimestralHipotecario;
        private System.Windows.Forms.TextBox textBoxTrimestralNacion;
        private System.Windows.Forms.TextBox textBoxTrimestralProvincia;
        private System.Windows.Forms.TextBox textBoxAnualHipotecario;
        private System.Windows.Forms.TextBox textBoxAnualNacion;
        private System.Windows.Forms.TextBox textBoxAnualProvincia;
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
        private System.Windows.Forms.Button btnVolver;
    }
}