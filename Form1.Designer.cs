using MetroFramework.Forms;
namespace AnalizadorVentasRopa
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            this.btnCargarArchivo = new MetroFramework.Controls.MetroButton();
            this.btnExportar = new MetroFramework.Controls.MetroButton();
            this.btnFiltrar = new MetroFramework.Controls.MetroButton();
            this.btnLimpiar = new MetroFramework.Controls.MetroButton();
            this.btnSimular = new MetroFramework.Controls.MetroButton();
            this.dtpInicio = new MetroFramework.Controls.MetroDateTime();
            this.dtpFin = new MetroFramework.Controls.MetroDateTime();
            this.cbProducto = new MetroFramework.Controls.MetroComboBox();
            this.cbCategoria = new MetroFramework.Controls.MetroComboBox();
            this.chartProductos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMeses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBoxLogs = new MetroFramework.Controls.MetroListView();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.panelPrincipal = new MetroFramework.Controls.MetroPanel();
            this.panelEncabezado = new MetroFramework.Controls.MetroPanel();
            this.progressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTemaOscuro = new MetroFramework.Controls.MetroLabel();
            this.panelFiltros = new MetroFramework.Controls.MetroPanel();
            this.lblFechaRango = new MetroFramework.Controls.MetroLabel();
            this.panelEstadisticas = new MetroFramework.Controls.MetroPanel();
            this.lblTotal = new MetroFramework.Controls.MetroLabel();
            this.lblMejorProducto = new MetroFramework.Controls.MetroLabel();
            this.lblVentasMensuales = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.panelGraficos = new MetroFramework.Controls.MetroPanel();
            this.panelDatos = new MetroFramework.Controls.MetroPanel();
            this.dataGridView1 = new MetroFramework.Controls.MetroGrid();
            this.panelLogs = new MetroFramework.Controls.MetroPanel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMeses)).BeginInit();
            this.panelPrincipal.SuspendLayout();
            this.panelEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelFiltros.SuspendLayout();
            this.panelEstadisticas.SuspendLayout();
            this.panelGraficos.SuspendLayout();
            this.panelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            this.metroStyleManager.Style = MetroFramework.MetroColorStyle.Purple;
            // 
            // metroToolTip
            // 
            this.metroToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip.StyleManager = null;
            this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnCargarArchivo
            // 
            this.btnCargarArchivo.BackColor = System.Drawing.Color.Transparent;
            this.btnCargarArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarArchivo.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCargarArchivo.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnCargarArchivo.Highlight = true;
            this.btnCargarArchivo.Location = new System.Drawing.Point(80, 10);
            this.btnCargarArchivo.Name = "btnCargarArchivo";
            this.btnCargarArchivo.Size = new System.Drawing.Size(180, 50);
            this.btnCargarArchivo.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnCargarArchivo.TabIndex = 0;
            this.btnCargarArchivo.Text = "📂 Cargar archivo";
            this.metroToolTip.SetToolTip(this.btnCargarArchivo, "Cargar archivo CSV o Excel con datos de ventas");
            this.btnCargarArchivo.UseCustomBackColor = true;
            this.btnCargarArchivo.UseSelectable = true;
            this.btnCargarArchivo.Click += new System.EventHandler(this.btnCargarArchivo_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.Transparent;
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnExportar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnExportar.Highlight = true;
            this.btnExportar.Location = new System.Drawing.Point(274, 10);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(180, 50);
            this.btnExportar.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnExportar.TabIndex = 7;
            this.btnExportar.Text = "📊 Exportar datos";
            this.metroToolTip.SetToolTip(this.btnExportar, "Exportar resultados a Excel o PDF");
            this.btnExportar.UseCustomBackColor = true;
            this.btnExportar.UseSelectable = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.Transparent;
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnFiltrar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnFiltrar.Highlight = true;
            this.btnFiltrar.Location = new System.Drawing.Point(530, 15);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(180, 35);
            this.btnFiltrar.Style = MetroFramework.MetroColorStyle.Green;
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "🔍 Filtrar";
            this.metroToolTip.SetToolTip(this.btnFiltrar, "Aplicar filtros seleccionados");
            this.btnFiltrar.UseCustomBackColor = true;
            this.btnFiltrar.UseSelectable = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnLimpiar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnLimpiar.Highlight = true;
            this.btnLimpiar.Location = new System.Drawing.Point(530, 55);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(180, 35);
            this.btnLimpiar.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "🗑️ Limpiar filtros";
            this.metroToolTip.SetToolTip(this.btnLimpiar, "Restablecer todos los filtros");
            this.btnLimpiar.UseCustomBackColor = true;
            this.btnLimpiar.UseSelectable = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSimular
            // 
            this.btnSimular.BackColor = System.Drawing.Color.Transparent;
            this.btnSimular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimular.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSimular.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSimular.Highlight = true;
            this.btnSimular.Location = new System.Drawing.Point(780, 10);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(180, 50);
            this.btnSimular.Style = MetroFramework.MetroColorStyle.Orange;
            this.btnSimular.TabIndex = 18;
            this.btnSimular.Text = "▶️ Simular ventas";
            this.metroToolTip.SetToolTip(this.btnSimular, "Simular ventas una por una");
            this.btnSimular.UseCustomBackColor = true;
            this.btnSimular.UseSelectable = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(15, 35);
            this.dtpInicio.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(150, 30);
            this.dtpInicio.Style = MetroFramework.MetroColorStyle.Purple;
            this.dtpInicio.TabIndex = 6;
            this.metroToolTip.SetToolTip(this.dtpInicio, "Fecha inicial del período");
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(175, 35);
            this.dtpFin.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(150, 30);
            this.dtpFin.Style = MetroFramework.MetroColorStyle.Purple;
            this.dtpFin.TabIndex = 7;
            this.metroToolTip.SetToolTip(this.dtpFin, "Fecha final del período");
            // 
            // cbProducto
            // 
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.ItemHeight = 24;
            this.cbProducto.Location = new System.Drawing.Point(340, 35);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.PromptText = "Seleccionar producto";
            this.cbProducto.Size = new System.Drawing.Size(180, 30);
            this.cbProducto.Style = MetroFramework.MetroColorStyle.Purple;
            this.cbProducto.TabIndex = 8;
            this.metroToolTip.SetToolTip(this.cbProducto, "Filtrar por producto específico");
            this.cbProducto.UseSelectable = true;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.ItemHeight = 24;
            this.cbCategoria.Location = new System.Drawing.Point(340, 65);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.PromptText = "Seleccionar categoría";
            this.cbCategoria.Size = new System.Drawing.Size(180, 30);
            this.cbCategoria.Style = MetroFramework.MetroColorStyle.Purple;
            this.cbCategoria.TabIndex = 11;
            this.metroToolTip.SetToolTip(this.cbCategoria, "Filtrar por categoría de producto");
            this.cbCategoria.UseSelectable = true;
            // 
            // chartProductos
            // 
            this.chartProductos.BackColor = System.Drawing.Color.Transparent;
            this.chartProductos.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartProductos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartProductos.Legends.Add(legend1);
            this.chartProductos.Location = new System.Drawing.Point(24, 15);
            this.chartProductos.Name = "chartProductos";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Ventas por producto";
            this.chartProductos.Series.Add(series1);
            this.chartProductos.Size = new System.Drawing.Size(340, 310);
            this.chartProductos.TabIndex = 9;
            this.metroToolTip.SetToolTip(this.chartProductos, "Distribución de ventas por producto");
            // 
            // chartMeses
            // 
            this.chartMeses.BackColor = System.Drawing.Color.Transparent;
            this.chartMeses.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartMeses.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMeses.Legends.Add(legend2);
            this.chartMeses.Location = new System.Drawing.Point(370, 3);
            this.chartMeses.Name = "chartMeses";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Ventas por mes";
            this.chartMeses.Series.Add(series2);
            this.chartMeses.Size = new System.Drawing.Size(340, 310);
            this.chartMeses.TabIndex = 10;
            this.metroToolTip.SetToolTip(this.chartMeses, "Tendencia de ventas mensuales");
            // 
            // listBoxLogs
            // 
            this.listBoxLogs.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listBoxLogs.FullRowSelect = true;
            this.listBoxLogs.Location = new System.Drawing.Point(10, 10);
            this.listBoxLogs.Name = "listBoxLogs";
            this.listBoxLogs.OwnerDraw = true;
            this.listBoxLogs.Size = new System.Drawing.Size(1440, 230);
            this.listBoxLogs.TabIndex = 11;
            this.metroToolTip.SetToolTip(this.listBoxLogs, "Registro de actividades y eventos");
            this.listBoxLogs.UseCompatibleStateImageBehavior = false;
            this.listBoxLogs.UseSelectable = true;
            this.listBoxLogs.View = System.Windows.Forms.View.Details;
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.DisplayStatus = false;
            this.metroToggle1.Location = new System.Drawing.Point(1320, 25);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(50, 27);
            this.metroToggle1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroToggle1.TabIndex = 15;
            this.metroToggle1.Text = "Off";
            this.metroToolTip.SetToolTip(this.metroToggle1, "Cambiar entre tema claro y oscuro");
            this.metroToggle1.UseSelectable = true;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.panelPrincipal.Controls.Add(this.panelEncabezado);
            this.panelPrincipal.Controls.Add(this.panelFiltros);
            this.panelPrincipal.Controls.Add(this.panelEstadisticas);
            this.panelPrincipal.Controls.Add(this.panelGraficos);
            this.panelPrincipal.Controls.Add(this.panelDatos);
            this.panelPrincipal.Controls.Add(this.panelLogs);
            this.panelPrincipal.HorizontalScrollbarBarColor = true;
            this.panelPrincipal.HorizontalScrollbarHighlightOnWheel = false;
            this.panelPrincipal.HorizontalScrollbarSize = 10;
            this.panelPrincipal.Location = new System.Drawing.Point(20, 60);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1460, 780);
            this.panelPrincipal.TabIndex = 0;
            this.panelPrincipal.VerticalScrollbarBarColor = true;
            this.panelPrincipal.VerticalScrollbarHighlightOnWheel = false;
            this.panelPrincipal.VerticalScrollbarSize = 10;
            // 
            // panelEncabezado
            // 
            this.panelEncabezado.BackColor = System.Drawing.Color.Transparent;
            this.panelEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEncabezado.Controls.Add(this.btnSimular);
            this.panelEncabezado.Controls.Add(this.btnCargarArchivo);
            this.panelEncabezado.Controls.Add(this.progressBar1);
            this.panelEncabezado.Controls.Add(this.btnExportar);
            this.panelEncabezado.Controls.Add(this.pictureBox1);
            this.panelEncabezado.Controls.Add(this.metroToggle1);
            this.panelEncabezado.Controls.Add(this.lblTemaOscuro);
            this.panelEncabezado.HorizontalScrollbarBarColor = true;
            this.panelEncabezado.HorizontalScrollbarHighlightOnWheel = false;
            this.panelEncabezado.HorizontalScrollbarSize = 10;
            this.panelEncabezado.Location = new System.Drawing.Point(0, 0);
            this.panelEncabezado.Name = "panelEncabezado";
            this.panelEncabezado.Size = new System.Drawing.Size(1460, 70);
            this.panelEncabezado.TabIndex = 1;
            this.panelEncabezado.VerticalScrollbarBarColor = true;
            this.panelEncabezado.VerticalScrollbarHighlightOnWheel = false;
            this.panelEncabezado.VerticalScrollbarSize = 10;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(460, 25);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(300, 23);
            this.progressBar1.Style = MetroFramework.MetroColorStyle.Purple;
            this.progressBar1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(15, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // lblTemaOscuro
            // 
            this.lblTemaOscuro.AutoSize = true;
            this.lblTemaOscuro.BackColor = System.Drawing.Color.Transparent;
            this.lblTemaOscuro.Location = new System.Drawing.Point(1225, 25);
            this.lblTemaOscuro.Name = "lblTemaOscuro";
            this.lblTemaOscuro.Size = new System.Drawing.Size(94, 20);
            this.lblTemaOscuro.TabIndex = 16;
            this.lblTemaOscuro.Text = "Tema Oscuro:";
            this.lblTemaOscuro.UseCustomBackColor = true;
            // 
            // panelFiltros
            // 
            this.panelFiltros.BackColor = System.Drawing.Color.Transparent;
            this.panelFiltros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFiltros.Controls.Add(this.dtpInicio);
            this.panelFiltros.Controls.Add(this.dtpFin);
            this.panelFiltros.Controls.Add(this.cbProducto);
            this.panelFiltros.Controls.Add(this.cbCategoria);
            this.panelFiltros.Controls.Add(this.btnFiltrar);
            this.panelFiltros.Controls.Add(this.btnLimpiar);
            this.panelFiltros.Controls.Add(this.lblFechaRango);
            this.panelFiltros.HorizontalScrollbarBarColor = true;
            this.panelFiltros.HorizontalScrollbarHighlightOnWheel = false;
            this.panelFiltros.HorizontalScrollbarSize = 10;
            this.panelFiltros.Location = new System.Drawing.Point(0, 80);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(720, 100);
            this.panelFiltros.TabIndex = 2;
            this.panelFiltros.VerticalScrollbarBarColor = true;
            this.panelFiltros.VerticalScrollbarHighlightOnWheel = false;
            this.panelFiltros.VerticalScrollbarSize = 10;
            // 
            // lblFechaRango
            // 
            this.lblFechaRango.AutoSize = true;
            this.lblFechaRango.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaRango.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblFechaRango.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblFechaRango.Location = new System.Drawing.Point(15, 15);
            this.lblFechaRango.Name = "lblFechaRango";
            this.lblFechaRango.Size = new System.Drawing.Size(109, 17);
            this.lblFechaRango.TabIndex = 10;
            this.lblFechaRango.Text = "Rango de fechas:";
            this.lblFechaRango.UseCustomBackColor = true;
            // 
            // panelEstadisticas
            // 
            this.panelEstadisticas.BackColor = System.Drawing.Color.Transparent;
            this.panelEstadisticas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEstadisticas.Controls.Add(this.lblTotal);
            this.panelEstadisticas.Controls.Add(this.lblMejorProducto);
            this.panelEstadisticas.Controls.Add(this.lblVentasMensuales);
            this.panelEstadisticas.Controls.Add(this.metroTile1);
            this.panelEstadisticas.Controls.Add(this.metroTile2);
            this.panelEstadisticas.Controls.Add(this.metroTile3);
            this.panelEstadisticas.HorizontalScrollbarBarColor = true;
            this.panelEstadisticas.HorizontalScrollbarHighlightOnWheel = false;
            this.panelEstadisticas.HorizontalScrollbarSize = 10;
            this.panelEstadisticas.Location = new System.Drawing.Point(730, 80);
            this.panelEstadisticas.Name = "panelEstadisticas";
            this.panelEstadisticas.Size = new System.Drawing.Size(730, 100);
            this.panelEstadisticas.TabIndex = 3;
            this.panelEstadisticas.VerticalScrollbarBarColor = true;
            this.panelEstadisticas.VerticalScrollbarHighlightOnWheel = false;
            this.panelEstadisticas.VerticalScrollbarSize = 10;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTotal.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.lblTotal.Location = new System.Drawing.Point(90, 15);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(32, 25);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "$0";
            this.lblTotal.UseCustomBackColor = true;
            this.lblTotal.UseCustomForeColor = true;
            // 
            // lblMejorProducto
            // 
            this.lblMejorProducto.AutoSize = true;
            this.lblMejorProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblMejorProducto.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblMejorProducto.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblMejorProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.lblMejorProducto.Location = new System.Drawing.Point(320, 15);
            this.lblMejorProducto.Name = "lblMejorProducto";
            this.lblMejorProducto.Size = new System.Drawing.Size(19, 25);
            this.lblMejorProducto.TabIndex = 5;
            this.lblMejorProducto.Text = "-";
            this.lblMejorProducto.UseCustomBackColor = true;
            this.lblMejorProducto.UseCustomForeColor = true;
            // 
            // lblVentasMensuales
            // 
            this.lblVentasMensuales.AutoSize = true;
            this.lblVentasMensuales.BackColor = System.Drawing.Color.Transparent;
            this.lblVentasMensuales.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblVentasMensuales.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblVentasMensuales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            this.lblVentasMensuales.Location = new System.Drawing.Point(550, 15);
            this.lblVentasMensuales.Name = "lblVentasMensuales";
            this.lblVentasMensuales.Size = new System.Drawing.Size(22, 25);
            this.lblVentasMensuales.TabIndex = 9;
            this.lblVentasMensuales.Text = "0";
            this.lblVentasMensuales.UseCustomBackColor = true;
            this.lblVentasMensuales.UseCustomForeColor = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(15, 15);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(220, 70);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTile1.TabIndex = 12;
            this.metroTile1.Text = "Total de Ventas";
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(245, 15);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(220, 70);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile2.TabIndex = 13;
            this.metroTile2.Text = "Producto Estrella";
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile2.UseSelectable = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(475, 15);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(220, 70);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTile3.TabIndex = 14;
            this.metroTile3.Text = "Ventas Mensuales";
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile3.UseSelectable = true;
            // 
            // panelGraficos
            // 
            this.panelGraficos.BackColor = System.Drawing.Color.Transparent;
            this.panelGraficos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGraficos.Controls.Add(this.chartProductos);
            this.panelGraficos.Controls.Add(this.chartMeses);
            this.panelGraficos.HorizontalScrollbarBarColor = true;
            this.panelGraficos.HorizontalScrollbarHighlightOnWheel = false;
            this.panelGraficos.HorizontalScrollbarSize = 10;
            this.panelGraficos.Location = new System.Drawing.Point(0, 190);
            this.panelGraficos.Name = "panelGraficos";
            this.panelGraficos.Size = new System.Drawing.Size(720, 330);
            this.panelGraficos.TabIndex = 4;
            this.panelGraficos.VerticalScrollbarBarColor = true;
            this.panelGraficos.VerticalScrollbarHighlightOnWheel = false;
            this.panelGraficos.VerticalScrollbarSize = 10;
            // 
            // panelDatos
            // 
            this.panelDatos.BackColor = System.Drawing.Color.Transparent;
            this.panelDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDatos.Controls.Add(this.dataGridView1);
            this.panelDatos.HorizontalScrollbarBarColor = true;
            this.panelDatos.HorizontalScrollbarHighlightOnWheel = false;
            this.panelDatos.HorizontalScrollbarSize = 10;
            this.panelDatos.Location = new System.Drawing.Point(730, 190);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(730, 330);
            this.panelDatos.TabIndex = 5;
            this.panelDatos.VerticalScrollbarBarColor = true;
            this.panelDatos.VerticalScrollbarHighlightOnWheel = false;
            this.panelDatos.VerticalScrollbarSize = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(10, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(710, 310);
            this.dataGridView1.Style = MetroFramework.MetroColorStyle.Purple;
            this.dataGridView1.TabIndex = 2;
            // 
            // panelLogs
            // 
            this.panelLogs.BackColor = System.Drawing.Color.Transparent;
            this.panelLogs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogs.Controls.Add(this.listBoxLogs);
            this.panelLogs.HorizontalScrollbarBarColor = true;
            this.panelLogs.HorizontalScrollbarHighlightOnWheel = false;
            this.panelLogs.HorizontalScrollbarSize = 10;
            this.panelLogs.Location = new System.Drawing.Point(0, 530);
            this.panelLogs.Name = "panelLogs";
            this.panelLogs.Size = new System.Drawing.Size(1460, 250);
            this.panelLogs.TabIndex = 6;
            this.panelLogs.VerticalScrollbarBarColor = true;
            this.panelLogs.VerticalScrollbarHighlightOnWheel = false;
            this.panelLogs.VerticalScrollbarSize = 10;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 860);
            this.Controls.Add(this.panelPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Analizador de Ventas de Ropa";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMeses)).EndInit();
            this.panelPrincipal.ResumeLayout(false);
            this.panelEncabezado.ResumeLayout(false);
            this.panelEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            this.panelEstadisticas.ResumeLayout(false);
            this.panelEstadisticas.PerformLayout();
            this.panelGraficos.ResumeLayout(false);
            this.panelDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelLogs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
        private MetroFramework.Components.MetroToolTip metroToolTip;
        private MetroFramework.Controls.MetroPanel panelPrincipal;
        private MetroFramework.Controls.MetroPanel panelEncabezado;
        private MetroFramework.Controls.MetroPanel panelFiltros;
        private MetroFramework.Controls.MetroPanel panelEstadisticas;
        private MetroFramework.Controls.MetroPanel panelGraficos;
        private MetroFramework.Controls.MetroPanel panelDatos;
        private MetroFramework.Controls.MetroPanel panelLogs;
        private MetroFramework.Controls.MetroButton btnCargarArchivo;
        private MetroFramework.Controls.MetroButton btnExportar;
        private MetroFramework.Controls.MetroButton btnFiltrar;
        private MetroFramework.Controls.MetroButton btnLimpiar;
        private MetroFramework.Controls.MetroProgressBar progressBar1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroGrid dataGridView1;
        private MetroFramework.Controls.MetroLabel lblTotal;
        private MetroFramework.Controls.MetroLabel lblMejorProducto;
        private MetroFramework.Controls.MetroLabel lblVentasMensuales;
        private MetroFramework.Controls.MetroLabel lblFechaRango;
        private MetroFramework.Controls.MetroLabel lblTemaOscuro;
        private MetroFramework.Controls.MetroDateTime dtpInicio;
        private MetroFramework.Controls.MetroDateTime dtpFin;
        private MetroFramework.Controls.MetroComboBox cbProducto;
        private MetroFramework.Controls.MetroComboBox cbCategoria;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProductos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMeses;
        private MetroFramework.Controls.MetroListView listBoxLogs;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnSimular;

    }
}
