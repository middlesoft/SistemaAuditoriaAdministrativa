<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pincipal))
        Dim TileItemElement4 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement3 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement5 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement6 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement7 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement8 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.menu1 = New DevExpress.XtraBars.Navigation.TileNavPane()
        Me.inicio = New DevExpress.XtraBars.Navigation.NavButton()
        Me.alb = New DevExpress.XtraBars.Navigation.TileNavCategory()
        Me.conalb = New DevExpress.XtraBars.Navigation.TileNavItem()
        Me.modalb = New DevExpress.XtraBars.Navigation.TileNavItem()
        Me.expalb = New DevExpress.XtraBars.Navigation.TileNavItem()
        Me.inv = New DevExpress.XtraBars.Navigation.TileNavCategory()
        Me.art = New DevExpress.XtraBars.Navigation.TileNavCategory()
        Me.emp = New DevExpress.XtraBars.Navigation.TileNavCategory()
        Me.rep = New DevExpress.XtraBars.Navigation.TileNavCategory()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2010 Blue"
        '
        'menu1
        '
        Me.menu1.BackColor = System.Drawing.Color.Transparent
        Me.menu1.ButtonPadding = New System.Windows.Forms.Padding(12)
        Me.menu1.Buttons.Add(Me.inicio)
        Me.menu1.Categories.AddRange(New DevExpress.XtraBars.Navigation.TileNavCategory() {Me.alb, Me.inv, Me.art, Me.emp, Me.rep})
        '
        'TileNavCategory1
        '
        Me.menu1.DefaultCategory.Name = "TileNavCategory1"
        Me.menu1.DefaultCategory.OptionsDropDown.BackColor = System.Drawing.Color.Empty
        Me.menu1.DefaultCategory.OwnerCollection = Nothing
        '
        '
        '
        Me.menu1.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        Me.menu1.DefaultCategory.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.[Default]
        Me.menu1.Location = New System.Drawing.Point(0, 0)
        Me.menu1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.menu1.Name = "menu1"
        Me.menu1.OptionsPrimaryDropDown.BackColor = System.Drawing.Color.Empty
        Me.menu1.OptionsSecondaryDropDown.BackColor = System.Drawing.Color.Empty
        Me.menu1.Size = New System.Drawing.Size(1688, 35)
        Me.menu1.TabIndex = 5
        Me.menu1.Text = "Inicio"
        '
        'inicio
        '
        Me.inicio.Caption = "Inicio"
        Me.inicio.IsMain = True
        Me.inicio.Name = "inicio"
        '
        'alb
        '
        Me.alb.Caption = "Albaranes"
        Me.alb.Glyph = CType(resources.GetObject("alb.Glyph"), System.Drawing.Image)
        Me.alb.Items.AddRange(New DevExpress.XtraBars.Navigation.TileNavItem() {Me.conalb, Me.modalb, Me.expalb})
        Me.alb.Name = "alb"
        Me.alb.OptionsDropDown.BackColor = System.Drawing.Color.Empty
        Me.alb.OwnerCollection = Me.menu1.Categories
        '
        '
        '
        Me.alb.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement4.Text = "Albaranes"
        Me.alb.Tile.Elements.Add(TileItemElement4)
        Me.alb.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.[Default]
        Me.alb.Tile.Name = "TileBarItem2"
        '
        'conalb
        '
        Me.conalb.Caption = "Consultar"
        Me.conalb.Name = "conalb"
        Me.conalb.OptionsDropDown.BackColor = System.Drawing.Color.Empty
        Me.conalb.OwnerCollection = Me.alb.Items
        '
        '
        '
        Me.conalb.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement1.Text = "Consultar"
        Me.conalb.Tile.Elements.Add(TileItemElement1)
        Me.conalb.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.[Default]
        Me.conalb.Tile.Name = "TileBarItem1"
        '
        'modalb
        '
        Me.modalb.Caption = "Modificar"
        Me.modalb.Name = "modalb"
        Me.modalb.OptionsDropDown.BackColor = System.Drawing.Color.Empty
        Me.modalb.OwnerCollection = Me.alb.Items
        '
        '
        '
        Me.modalb.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement2.Text = "Modificar"
        Me.modalb.Tile.Elements.Add(TileItemElement2)
        Me.modalb.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.[Default]
        Me.modalb.Tile.Name = "TileBarItem6"
        '
        'expalb
        '
        Me.expalb.Caption = "Exportar"
        Me.expalb.Name = "expalb"
        Me.expalb.OptionsDropDown.BackColor = System.Drawing.Color.Empty
        Me.expalb.OwnerCollection = Me.alb.Items
        '
        '
        '
        Me.expalb.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement3.Text = "Exportar"
        Me.expalb.Tile.Elements.Add(TileItemElement3)
        Me.expalb.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.[Default]
        Me.expalb.Tile.Name = "TileBarItem1"
        '
        'inv
        '
        Me.inv.Caption = "Movimiento de Inventario"
        Me.inv.Name = "inv"
        Me.inv.OptionsDropDown.BackColor = System.Drawing.Color.Empty
        Me.inv.OwnerCollection = Me.menu1.Categories
        '
        '
        '
        Me.inv.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement5.Text = "Movimiento de Inventario"
        Me.inv.Tile.Elements.Add(TileItemElement5)
        Me.inv.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.[Default]
        Me.inv.Tile.Name = "TileBarItem3"
        '
        'art
        '
        Me.art.Caption = "Artículos"
        Me.art.Name = "art"
        Me.art.OptionsDropDown.BackColor = System.Drawing.Color.Empty
        Me.art.OwnerCollection = Me.menu1.Categories
        '
        '
        '
        Me.art.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement6.Text = "Artículos"
        Me.art.Tile.Elements.Add(TileItemElement6)
        Me.art.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.[Default]
        Me.art.Tile.Name = "TileBarItem4"
        '
        'emp
        '
        Me.emp.Caption = "Empleados"
        Me.emp.Name = "emp"
        Me.emp.OptionsDropDown.BackColor = System.Drawing.Color.Empty
        Me.emp.OwnerCollection = Me.menu1.Categories
        '
        '
        '
        Me.emp.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement7.Text = "Empleados"
        Me.emp.Tile.Elements.Add(TileItemElement7)
        Me.emp.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.[Default]
        Me.emp.Tile.Name = "TileBarItem5"
        '
        'rep
        '
        Me.rep.Caption = "Reportes"
        Me.rep.Name = "rep"
        Me.rep.OptionsDropDown.BackColor = System.Drawing.Color.Empty
        Me.rep.OwnerCollection = Me.menu1.Categories
        '
        '
        '
        Me.rep.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        TileItemElement8.Text = "Reportes"
        Me.rep.Tile.Elements.Add(TileItemElement8)
        Me.rep.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.[Default]
        Me.rep.Tile.Name = "TileBarItem3"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Sistema_de_Auditoria_Administrativa.My.Resources.Resources.fondo3
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(768, 485)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Pincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 485)
        Me.Controls.Add(Me.menu1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Pincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Auditoria Administrativa"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents menu1 As DevExpress.XtraBars.Navigation.TileNavPane
    Friend WithEvents inicio As DevExpress.XtraBars.Navigation.NavButton
    Friend WithEvents modalb As DevExpress.XtraBars.Navigation.TileNavItem
    Friend WithEvents art As DevExpress.XtraBars.Navigation.TileNavCategory
    Friend WithEvents emp As DevExpress.XtraBars.Navigation.TileNavCategory
    Friend WithEvents inv As DevExpress.XtraBars.Navigation.TileNavCategory
    Friend WithEvents alb As DevExpress.XtraBars.Navigation.TileNavCategory
    Friend WithEvents rep As DevExpress.XtraBars.Navigation.TileNavCategory
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents expalb As DevExpress.XtraBars.Navigation.TileNavItem
    Friend WithEvents conalb As DevExpress.XtraBars.Navigation.TileNavItem
End Class
