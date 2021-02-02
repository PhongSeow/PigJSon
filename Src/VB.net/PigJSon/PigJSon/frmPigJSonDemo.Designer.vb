<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPigJSonDemo
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的

    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的

    '可以使用 Windows 窗体设计器修改它。

    '不要使用代码编辑器修改它。

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tbMain = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JSonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssembleDemoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpleElementsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpleTextElementsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpleArrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpleArrayElementsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ParseToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowJSonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeowPhongHomePageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PiggyJSonPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbMain
        '
        Me.tbMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbMain.Location = New System.Drawing.Point(0, 28)
        Me.tbMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbMain.Multiline = True
        Me.tbMain.Name = "tbMain"
        Me.tbMain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbMain.Size = New System.Drawing.Size(884, 310)
        Me.tbMain.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.JSonToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(884, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(48, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(118, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'JSonToolStripMenuItem
        '
        Me.JSonToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AssembleDemoToolStripMenuItem, Me.ToolStripMenuItem1, Me.ParseToolStripMenuItem1, Me.ShowJSonToolStripMenuItem})
        Me.JSonToolStripMenuItem.Name = "JSonToolStripMenuItem"
        Me.JSonToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.JSonToolStripMenuItem.Text = "&JSon"
        '
        'AssembleDemoToolStripMenuItem
        '
        Me.AssembleDemoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SimpleElementsToolStripMenuItem, Me.SimpleTextElementsToolStripMenuItem, Me.SimpleArrayToolStripMenuItem, Me.SimpleArrayElementsToolStripMenuItem})
        Me.AssembleDemoToolStripMenuItem.Name = "AssembleDemoToolStripMenuItem"
        Me.AssembleDemoToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
        Me.AssembleDemoToolStripMenuItem.Text = "Assemble Demo"
        '
        'SimpleElementsToolStripMenuItem
        '
        Me.SimpleElementsToolStripMenuItem.Name = "SimpleElementsToolStripMenuItem"
        Me.SimpleElementsToolStripMenuItem.Size = New System.Drawing.Size(357, 26)
        Me.SimpleElementsToolStripMenuItem.Text = "Simple text elements"
        '
        'SimpleTextElementsToolStripMenuItem
        '
        Me.SimpleTextElementsToolStripMenuItem.Name = "SimpleTextElementsToolStripMenuItem"
        Me.SimpleTextElementsToolStripMenuItem.Size = New System.Drawing.Size(357, 26)
        Me.SimpleTextElementsToolStripMenuItem.Text = "Simple multiple data types elements"
        '
        'SimpleArrayToolStripMenuItem
        '
        Me.SimpleArrayToolStripMenuItem.Name = "SimpleArrayToolStripMenuItem"
        Me.SimpleArrayToolStripMenuItem.Size = New System.Drawing.Size(357, 26)
        Me.SimpleArrayToolStripMenuItem.Text = "Simple array elements"
        '
        'SimpleArrayElementsToolStripMenuItem
        '
        Me.SimpleArrayElementsToolStripMenuItem.Name = "SimpleArrayElementsToolStripMenuItem"
        Me.SimpleArrayElementsToolStripMenuItem.Size = New System.Drawing.Size(357, 26)
        Me.SimpleArrayElementsToolStripMenuItem.Text = "complex array elements"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(211, 6)
        '
        'ParseToolStripMenuItem1
        '
        Me.ParseToolStripMenuItem1.Name = "ParseToolStripMenuItem1"
        Me.ParseToolStripMenuItem1.Size = New System.Drawing.Size(214, 26)
        Me.ParseToolStripMenuItem1.Text = "Parse JSon"
        '
        'ShowJSonToolStripMenuItem
        '
        Me.ShowJSonToolStripMenuItem.Name = "ShowJSonToolStripMenuItem"
        Me.ShowJSonToolStripMenuItem.Size = New System.Drawing.Size(214, 26)
        Me.ShowJSonToolStripMenuItem.Text = "Show JSon Value"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeowPhongHomePageToolStripMenuItem, Me.PiggyJSonPageToolStripMenuItem, Me.ToolStripMenuItem2, Me.AboutToolStripMenuItem1})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.AboutToolStripMenuItem.Text = "&Help"
        '
        'SeowPhongHomePageToolStripMenuItem
        '
        Me.SeowPhongHomePageToolStripMenuItem.Name = "SeowPhongHomePageToolStripMenuItem"
        Me.SeowPhongHomePageToolStripMenuItem.Size = New System.Drawing.Size(339, 26)
        Me.SeowPhongHomePageToolStripMenuItem.Text = "Seow Phong Web Site"
        '
        'PiggyJSonPageToolStripMenuItem
        '
        Me.PiggyJSonPageToolStripMenuItem.Name = "PiggyJSonPageToolStripMenuItem"
        Me.PiggyJSonPageToolStripMenuItem.Size = New System.Drawing.Size(339, 26)
        Me.PiggyJSonPageToolStripMenuItem.Text = "Piggy JSon Online Documentation"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(336, 6)
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(339, 26)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'frmPigJSonDemo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 338)
        Me.Controls.Add(Me.tbMain)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmPigJSonDemo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Piggy JSon Demo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbMain As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JSonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ParseToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeowPhongHomePageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PiggyJSonPageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ShowJSonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AssembleDemoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpleElementsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpleTextElementsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpleArrayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpleArrayElementsToolStripMenuItem As ToolStripMenuItem
End Class
