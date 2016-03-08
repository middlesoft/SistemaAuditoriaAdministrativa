<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_alb_cosul
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_alb_cosul))
        Me.STORED_ALB = New Sistema_de_Auditoria_Administrativa.STORED_ALB()
        Me.RQSP_CONSULTA_ALBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RQSP_CONSULTA_ALBTableAdapter = New Sistema_de_Auditoria_Administrativa.STORED_ALBTableAdapters.RQSP_CONSULTA_ALBTableAdapter()
        Me.TableAdapterManager = New Sistema_de_Auditoria_Administrativa.STORED_ALBTableAdapters.TableAdapterManager()
        Me.RQSP_CONSULTA_ALBBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.RQSP_CONSULTA_ALBBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip()
        Me.TiendaToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.TiendaToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.DesdeToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.DesdeToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.HastaToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.HastaToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.grid = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIDET_MODEL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDET_QUALITY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDET_WHEAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDET_WAREHOUSE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDET_FACDATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDET_DATE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDET_INVOICE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDET_DOCUMENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDET_BOXNUMBER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDET_DPTO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDET_SERIE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCODSAP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDET_COST = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDET_PRICE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDET_LINE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDET_STORE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDET_UNITS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDET_ASOCDOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDET_PRODUCT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDET_COLOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDET_SIZE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIDET_AUXSTORE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.STOREDALBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.STORED_ALB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RQSP_CONSULTA_ALBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RQSP_CONSULTA_ALBBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RQSP_CONSULTA_ALBBindingNavigator.SuspendLayout()
        Me.FillToolStrip.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STOREDALBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'STORED_ALB
        '
        Me.STORED_ALB.DataSetName = "STORED_ALB"
        Me.STORED_ALB.EnforceConstraints = False
        Me.STORED_ALB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RQSP_CONSULTA_ALBBindingSource
        '
        Me.RQSP_CONSULTA_ALBBindingSource.DataMember = "RQSP_CONSULTA_ALB"
        Me.RQSP_CONSULTA_ALBBindingSource.DataSource = Me.STORED_ALB
        '
        'RQSP_CONSULTA_ALBTableAdapter
        '
        Me.RQSP_CONSULTA_ALBTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistema_de_Auditoria_Administrativa.STORED_ALBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RQSP_CONSULTA_ALBBindingNavigator
        '
        Me.RQSP_CONSULTA_ALBBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RQSP_CONSULTA_ALBBindingNavigator.BindingSource = Me.RQSP_CONSULTA_ALBBindingSource
        Me.RQSP_CONSULTA_ALBBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RQSP_CONSULTA_ALBBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RQSP_CONSULTA_ALBBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RQSP_CONSULTA_ALBBindingNavigatorSaveItem})
        Me.RQSP_CONSULTA_ALBBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RQSP_CONSULTA_ALBBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RQSP_CONSULTA_ALBBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RQSP_CONSULTA_ALBBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RQSP_CONSULTA_ALBBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RQSP_CONSULTA_ALBBindingNavigator.Name = "RQSP_CONSULTA_ALBBindingNavigator"
        Me.RQSP_CONSULTA_ALBBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RQSP_CONSULTA_ALBBindingNavigator.Size = New System.Drawing.Size(833, 25)
        Me.RQSP_CONSULTA_ALBBindingNavigator.TabIndex = 0
        Me.RQSP_CONSULTA_ALBBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'RQSP_CONSULTA_ALBBindingNavigatorSaveItem
        '
        Me.RQSP_CONSULTA_ALBBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RQSP_CONSULTA_ALBBindingNavigatorSaveItem.Enabled = False
        Me.RQSP_CONSULTA_ALBBindingNavigatorSaveItem.Image = CType(resources.GetObject("RQSP_CONSULTA_ALBBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RQSP_CONSULTA_ALBBindingNavigatorSaveItem.Name = "RQSP_CONSULTA_ALBBindingNavigatorSaveItem"
        Me.RQSP_CONSULTA_ALBBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.RQSP_CONSULTA_ALBBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'FillToolStrip
        '
        Me.FillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TiendaToolStripLabel, Me.TiendaToolStripTextBox, Me.DesdeToolStripLabel, Me.DesdeToolStripTextBox, Me.HastaToolStripLabel, Me.HastaToolStripTextBox, Me.FillToolStripButton, Me.ToolStripSeparator1, Me.ToolStripButton1})
        Me.FillToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillToolStrip.Name = "FillToolStrip"
        Me.FillToolStrip.Size = New System.Drawing.Size(833, 25)
        Me.FillToolStrip.TabIndex = 1
        Me.FillToolStrip.Text = "FillToolStrip"
        '
        'TiendaToolStripLabel
        '
        Me.TiendaToolStripLabel.Name = "TiendaToolStripLabel"
        Me.TiendaToolStripLabel.Size = New System.Drawing.Size(43, 22)
        Me.TiendaToolStripLabel.Text = "tienda:"
        '
        'TiendaToolStripTextBox
        '
        Me.TiendaToolStripTextBox.Name = "TiendaToolStripTextBox"
        Me.TiendaToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'DesdeToolStripLabel
        '
        Me.DesdeToolStripLabel.Name = "DesdeToolStripLabel"
        Me.DesdeToolStripLabel.Size = New System.Drawing.Size(41, 22)
        Me.DesdeToolStripLabel.Text = "desde:"
        '
        'DesdeToolStripTextBox
        '
        Me.DesdeToolStripTextBox.Name = "DesdeToolStripTextBox"
        Me.DesdeToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'HastaToolStripLabel
        '
        Me.HastaToolStripLabel.Name = "HastaToolStripLabel"
        Me.HastaToolStripLabel.Size = New System.Drawing.Size(38, 22)
        Me.HastaToolStripLabel.Text = "hasta:"
        '
        'HastaToolStripTextBox
        '
        Me.HastaToolStripTextBox.Name = "HastaToolStripTextBox"
        Me.HastaToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillToolStripButton
        '
        Me.FillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton.Name = "FillToolStripButton"
        Me.FillToolStripButton.Size = New System.Drawing.Size(26, 22)
        Me.FillToolStripButton.Text = "Fill"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'grid
        '
        Me.grid.DataSource = Me.RQSP_CONSULTA_ALBBindingSource
        Me.grid.Location = New System.Drawing.Point(12, 68)
        Me.grid.MainView = Me.GridView1
        Me.grid.Name = "grid"
        Me.grid.Size = New System.Drawing.Size(706, 293)
        Me.grid.TabIndex = 2
        Me.grid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIDET_MODEL, Me.colIDET_QUALITY, Me.colIDET_WHEAD, Me.colIDET_WAREHOUSE, Me.colIDET_FACDATE, Me.colIDET_DATE, Me.colIDET_INVOICE, Me.colIDET_DOCUMENT, Me.colIDET_BOXNUMBER, Me.colIDET_DPTO, Me.colIDET_SERIE, Me.colCODSAP, Me.colIDET_COST, Me.colIDET_PRICE, Me.colIDET_LINE, Me.colIDET_STORE, Me.colIDET_UNITS, Me.colIDET_ASOCDOC, Me.colIDET_PRODUCT, Me.colIDET_COLOR, Me.colIDET_SIZE, Me.colIDET_AUXSTORE})
        Me.GridView1.GridControl = Me.grid
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colIDET_MODEL
        '
        Me.colIDET_MODEL.FieldName = "IDET_MODEL"
        Me.colIDET_MODEL.Name = "colIDET_MODEL"
        Me.colIDET_MODEL.Visible = True
        Me.colIDET_MODEL.VisibleIndex = 0
        '
        'colIDET_QUALITY
        '
        Me.colIDET_QUALITY.FieldName = "IDET_QUALITY"
        Me.colIDET_QUALITY.Name = "colIDET_QUALITY"
        Me.colIDET_QUALITY.Visible = True
        Me.colIDET_QUALITY.VisibleIndex = 1
        '
        'colIDET_WHEAD
        '
        Me.colIDET_WHEAD.FieldName = "IDET_WHEAD"
        Me.colIDET_WHEAD.Name = "colIDET_WHEAD"
        Me.colIDET_WHEAD.Visible = True
        Me.colIDET_WHEAD.VisibleIndex = 2
        '
        'colIDET_WAREHOUSE
        '
        Me.colIDET_WAREHOUSE.FieldName = "IDET_WAREHOUSE"
        Me.colIDET_WAREHOUSE.Name = "colIDET_WAREHOUSE"
        Me.colIDET_WAREHOUSE.Visible = True
        Me.colIDET_WAREHOUSE.VisibleIndex = 3
        '
        'colIDET_FACDATE
        '
        Me.colIDET_FACDATE.FieldName = "IDET_FACDATE"
        Me.colIDET_FACDATE.Name = "colIDET_FACDATE"
        Me.colIDET_FACDATE.Visible = True
        Me.colIDET_FACDATE.VisibleIndex = 4
        '
        'colIDET_DATE
        '
        Me.colIDET_DATE.FieldName = "IDET_DATE"
        Me.colIDET_DATE.Name = "colIDET_DATE"
        Me.colIDET_DATE.Visible = True
        Me.colIDET_DATE.VisibleIndex = 5
        '
        'colIDET_INVOICE
        '
        Me.colIDET_INVOICE.FieldName = "IDET_INVOICE"
        Me.colIDET_INVOICE.Name = "colIDET_INVOICE"
        Me.colIDET_INVOICE.Visible = True
        Me.colIDET_INVOICE.VisibleIndex = 6
        '
        'colIDET_DOCUMENT
        '
        Me.colIDET_DOCUMENT.FieldName = "IDET_DOCUMENT"
        Me.colIDET_DOCUMENT.Name = "colIDET_DOCUMENT"
        Me.colIDET_DOCUMENT.Visible = True
        Me.colIDET_DOCUMENT.VisibleIndex = 7
        '
        'colIDET_BOXNUMBER
        '
        Me.colIDET_BOXNUMBER.FieldName = "IDET_BOXNUMBER"
        Me.colIDET_BOXNUMBER.Name = "colIDET_BOXNUMBER"
        Me.colIDET_BOXNUMBER.Visible = True
        Me.colIDET_BOXNUMBER.VisibleIndex = 8
        '
        'colIDET_DPTO
        '
        Me.colIDET_DPTO.FieldName = "IDET_DPTO"
        Me.colIDET_DPTO.Name = "colIDET_DPTO"
        Me.colIDET_DPTO.Visible = True
        Me.colIDET_DPTO.VisibleIndex = 9
        '
        'colIDET_SERIE
        '
        Me.colIDET_SERIE.FieldName = "IDET_SERIE"
        Me.colIDET_SERIE.Name = "colIDET_SERIE"
        Me.colIDET_SERIE.Visible = True
        Me.colIDET_SERIE.VisibleIndex = 10
        '
        'colCODSAP
        '
        Me.colCODSAP.FieldName = "CODSAP"
        Me.colCODSAP.Name = "colCODSAP"
        Me.colCODSAP.Visible = True
        Me.colCODSAP.VisibleIndex = 11
        '
        'colIDET_COST
        '
        Me.colIDET_COST.FieldName = "IDET_COST"
        Me.colIDET_COST.Name = "colIDET_COST"
        Me.colIDET_COST.Visible = True
        Me.colIDET_COST.VisibleIndex = 12
        '
        'colIDET_PRICE
        '
        Me.colIDET_PRICE.FieldName = "IDET_PRICE"
        Me.colIDET_PRICE.Name = "colIDET_PRICE"
        Me.colIDET_PRICE.Visible = True
        Me.colIDET_PRICE.VisibleIndex = 13
        '
        'colIDET_LINE
        '
        Me.colIDET_LINE.FieldName = "IDET_LINE"
        Me.colIDET_LINE.Name = "colIDET_LINE"
        Me.colIDET_LINE.Visible = True
        Me.colIDET_LINE.VisibleIndex = 14
        '
        'colIDET_STORE
        '
        Me.colIDET_STORE.FieldName = "IDET_STORE"
        Me.colIDET_STORE.Name = "colIDET_STORE"
        Me.colIDET_STORE.Visible = True
        Me.colIDET_STORE.VisibleIndex = 15
        '
        'colIDET_UNITS
        '
        Me.colIDET_UNITS.FieldName = "IDET_UNITS"
        Me.colIDET_UNITS.Name = "colIDET_UNITS"
        Me.colIDET_UNITS.Visible = True
        Me.colIDET_UNITS.VisibleIndex = 16
        '
        'colIDET_ASOCDOC
        '
        Me.colIDET_ASOCDOC.FieldName = "IDET_ASOCDOC"
        Me.colIDET_ASOCDOC.Name = "colIDET_ASOCDOC"
        Me.colIDET_ASOCDOC.Visible = True
        Me.colIDET_ASOCDOC.VisibleIndex = 17
        '
        'colIDET_PRODUCT
        '
        Me.colIDET_PRODUCT.FieldName = "IDET_PRODUCT"
        Me.colIDET_PRODUCT.Name = "colIDET_PRODUCT"
        Me.colIDET_PRODUCT.Visible = True
        Me.colIDET_PRODUCT.VisibleIndex = 18
        '
        'colIDET_COLOR
        '
        Me.colIDET_COLOR.FieldName = "IDET_COLOR"
        Me.colIDET_COLOR.Name = "colIDET_COLOR"
        Me.colIDET_COLOR.Visible = True
        Me.colIDET_COLOR.VisibleIndex = 19
        '
        'colIDET_SIZE
        '
        Me.colIDET_SIZE.FieldName = "IDET_SIZE"
        Me.colIDET_SIZE.Name = "colIDET_SIZE"
        Me.colIDET_SIZE.Visible = True
        Me.colIDET_SIZE.VisibleIndex = 20
        '
        'colIDET_AUXSTORE
        '
        Me.colIDET_AUXSTORE.FieldName = "IDET_AUXSTORE"
        Me.colIDET_AUXSTORE.Name = "colIDET_AUXSTORE"
        Me.colIDET_AUXSTORE.Visible = True
        Me.colIDET_AUXSTORE.VisibleIndex = 21
        '
        'STOREDALBBindingSource
        '
        Me.STOREDALBBindingSource.DataSource = Me.STORED_ALB
        Me.STOREDALBBindingSource.Position = 0
        '
        'frm_alb_cosul
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 449)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.FillToolStrip)
        Me.Controls.Add(Me.RQSP_CONSULTA_ALBBindingNavigator)
        Me.Name = "frm_alb_cosul"
        Me.Text = "frm_alb_cosul"
        CType(Me.STORED_ALB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RQSP_CONSULTA_ALBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RQSP_CONSULTA_ALBBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RQSP_CONSULTA_ALBBindingNavigator.ResumeLayout(False)
        Me.RQSP_CONSULTA_ALBBindingNavigator.PerformLayout()
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STOREDALBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents STORED_ALB As Sistema_de_Auditoria_Administrativa.STORED_ALB
    Friend WithEvents RQSP_CONSULTA_ALBBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RQSP_CONSULTA_ALBTableAdapter As Sistema_de_Auditoria_Administrativa.STORED_ALBTableAdapters.RQSP_CONSULTA_ALBTableAdapter
    Friend WithEvents TableAdapterManager As Sistema_de_Auditoria_Administrativa.STORED_ALBTableAdapters.TableAdapterManager
    Friend WithEvents RQSP_CONSULTA_ALBBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RQSP_CONSULTA_ALBBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents FillToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents TiendaToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TiendaToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents DesdeToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DesdeToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents HastaToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents HastaToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents grid As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents colIDET_MODEL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDET_QUALITY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDET_WHEAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDET_WAREHOUSE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDET_FACDATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDET_DATE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDET_INVOICE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDET_DOCUMENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDET_BOXNUMBER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDET_DPTO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDET_SERIE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODSAP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDET_COST As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDET_PRICE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDET_LINE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDET_STORE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDET_UNITS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDET_ASOCDOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDET_PRODUCT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDET_COLOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDET_SIZE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIDET_AUXSTORE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents STOREDALBBindingSource As System.Windows.Forms.BindingSource
End Class
