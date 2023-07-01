<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MasterEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutOfStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SerialControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MSWordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotepadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterEntryToolStripMenuItem, Me.UsersToolStripMenuItem, Me.SerialControlToolStripMenuItem, Me.RecordsToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.AboutUsToolStripMenuItem, Me.ContactUsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1379, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterEntryToolStripMenuItem
        '
        Me.MasterEntryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.StudentToolStripMenuItem})
        Me.MasterEntryToolStripMenuItem.Name = "MasterEntryToolStripMenuItem"
        Me.MasterEntryToolStripMenuItem.Size = New System.Drawing.Size(56, 24)
        Me.MasterEntryToolStripMenuItem.Text = "Users"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(129, 24)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'StudentToolStripMenuItem
        '
        Me.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem"
        Me.StudentToolStripMenuItem.Size = New System.Drawing.Size(129, 24)
        Me.StudentToolStripMenuItem.Text = "Student"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InStockToolStripMenuItem, Me.OutOfStockToolStripMenuItem})
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(61, 24)
        Me.UsersToolStripMenuItem.Text = "Books"
        '
        'InStockToolStripMenuItem
        '
        Me.InStockToolStripMenuItem.Name = "InStockToolStripMenuItem"
        Me.InStockToolStripMenuItem.Size = New System.Drawing.Size(160, 24)
        Me.InStockToolStripMenuItem.Text = "In Stock"
        '
        'OutOfStockToolStripMenuItem
        '
        Me.OutOfStockToolStripMenuItem.Name = "OutOfStockToolStripMenuItem"
        Me.OutOfStockToolStripMenuItem.Size = New System.Drawing.Size(160, 24)
        Me.OutOfStockToolStripMenuItem.Text = "Out of Stock"
        '
        'SerialControlToolStripMenuItem
        '
        Me.SerialControlToolStripMenuItem.Name = "SerialControlToolStripMenuItem"
        Me.SerialControlToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.SerialControlToolStripMenuItem.Text = "View"
        '
        'RecordsToolStripMenuItem
        '
        Me.RecordsToolStripMenuItem.Name = "RecordsToolStripMenuItem"
        Me.RecordsToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.RecordsToolStripMenuItem.Text = "Records"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculatorToolStripMenuItem, Me.MSWordToolStripMenuItem, Me.NotepadToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(56, 24)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculatorToolStripMenuItem.Image = Global.form1.My.Resources.Resources.cal
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(156, 28)
        Me.CalculatorToolStripMenuItem.Text = "Calculator"
        '
        'MSWordToolStripMenuItem
        '
        Me.MSWordToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MSWordToolStripMenuItem.Image = Global.form1.My.Resources.Resources.Microsoft_Word_Logo
        Me.MSWordToolStripMenuItem.Name = "MSWordToolStripMenuItem"
        Me.MSWordToolStripMenuItem.Size = New System.Drawing.Size(156, 28)
        Me.MSWordToolStripMenuItem.Text = "MS Word"
        '
        'NotepadToolStripMenuItem
        '
        Me.NotepadToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotepadToolStripMenuItem.Image = Global.form1.My.Resources.Resources.Notepad_icon_svg
        Me.NotepadToolStripMenuItem.Name = "NotepadToolStripMenuItem"
        Me.NotepadToolStripMenuItem.Size = New System.Drawing.Size(156, 28)
        Me.NotepadToolStripMenuItem.Text = "Notepad"
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(82, 24)
        Me.AboutUsToolStripMenuItem.Text = "About Us"
        '
        'ContactUsToolStripMenuItem
        '
        Me.ContactUsToolStripMenuItem.Name = "ContactUsToolStripMenuItem"
        Me.ContactUsToolStripMenuItem.Size = New System.Drawing.Size(92, 24)
        Me.ContactUsToolStripMenuItem.Text = "Contact Us"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripButton7, Me.ToolStripButton8})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 28)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1379, 53)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.BackgroundImage = Global.form1.My.Resources.Resources.KC1
        Me.ToolStripButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ToolStripButton1.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(70, 50)
        Me.ToolStripButton1.Text = "Registration"
        Me.ToolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.AutoSize = False
        Me.ToolStripButton2.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripButton2.BackgroundImage = Global.form1.My.Resources.Resources.Feature_1_30fab11b98
        Me.ToolStripButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripButton2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(70, 50)
        Me.ToolStripButton2.Text = "Books"
        Me.ToolStripButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.AutoSize = False
        Me.ToolStripButton3.BackgroundImage = Global.form1.My.Resources.Resources.stud
        Me.ToolStripButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ToolStripButton3.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(70, 50)
        Me.ToolStripButton3.Text = "Customers"
        Me.ToolStripButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.AutoSize = False
        Me.ToolStripButton4.BackgroundImage = Global.form1.My.Resources.Resources.faculties_and_departments_1920x1080
        Me.ToolStripButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripButton4.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(70, 50)
        Me.ToolStripButton4.Text = "Faculties"
        Me.ToolStripButton4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.AutoSize = False
        Me.ToolStripButton5.BackgroundImage = Global.form1.My.Resources.Resources.national
        Me.ToolStripButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ToolStripButton5.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(70, 50)
        Me.ToolStripButton5.Text = "Book Issue"
        Me.ToolStripButton5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.AutoSize = False
        Me.ToolStripButton6.BackgroundImage = Global.form1.My.Resources.Resources.return_book_icon
        Me.ToolStripButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ToolStripButton6.Font = New System.Drawing.Font("Cambria", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(70, 50)
        Me.ToolStripButton6.Text = "Book Return"
        Me.ToolStripButton6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.AutoSize = False
        Me.ToolStripButton7.BackgroundImage = Global.form1.My.Resources.Resources.bsearch_icon
        Me.ToolStripButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ToolStripButton7.Font = New System.Drawing.Font("Cambria Math", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(70, 50)
        Me.ToolStripButton7.Text = "Books Search"
        Me.ToolStripButton7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.AutoSize = False
        Me.ToolStripButton8.BackgroundImage = Global.form1.My.Resources.Resources.log_out
        Me.ToolStripButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.Size = New System.Drawing.Size(70, 50)
        Me.ToolStripButton8.Text = "ToolStripButton8"
        Me.ToolStripButton8.ToolTipText = "LogOut"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.Font = New System.Drawing.Font("Algerian", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(991, 45)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "WELCOME TO THE LIBRARY MANAGEMENT SYSTEM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.Font = New System.Drawing.Font("Algerian", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(943, 456)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(304, 42)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "THANK YOU...!!!"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox1.Location = New System.Drawing.Point(971, 167)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(13, 287)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(41, 384)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(813, 96)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.form1.My.Resources.Resources.Math_NS_Library_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1379, 562)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SerialControlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OutOfStockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactUsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MSWordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotepadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
