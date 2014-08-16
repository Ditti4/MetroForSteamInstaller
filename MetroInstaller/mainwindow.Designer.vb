<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainwindow
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainwindow))
        Me.textcurrent = New System.Windows.Forms.Label()
        Me.textnew = New System.Windows.Forms.Label()
        Me.updatenotice = New System.Windows.Forms.Label()
        Me.overwritecheckbox = New System.Windows.Forms.CheckBox()
        Me.updatebutton = New System.Windows.Forms.Button()
        Me.currentversionlabel = New System.Windows.Forms.Label()
        Me.newversionlabel = New System.Windows.Forms.Label()
        Me.titlebar = New System.Windows.Forms.Panel()
        Me.title = New System.Windows.Forms.Label()
        Me.minimizebutton = New System.Windows.Forms.Button()
        Me.closebutton = New System.Windows.Forms.Button()
        Me.titlebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'textcurrent
        '
        Me.textcurrent.AutoSize = True
        Me.textcurrent.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textcurrent.Location = New System.Drawing.Point(12, 50)
        Me.textcurrent.Name = "textcurrent"
        Me.textcurrent.Size = New System.Drawing.Size(89, 13)
        Me.textcurrent.TabIndex = 0
        Me.textcurrent.Text = "Current version:"
        '
        'textnew
        '
        Me.textnew.AutoSize = True
        Me.textnew.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textnew.Location = New System.Drawing.Point(12, 67)
        Me.textnew.Name = "textnew"
        Me.textnew.Size = New System.Drawing.Size(88, 13)
        Me.textnew.TabIndex = 1
        Me.textnew.Text = "Newest version:"
        '
        'updatenotice
        '
        Me.updatenotice.AutoSize = True
        Me.updatenotice.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatenotice.Location = New System.Drawing.Point(15, 94)
        Me.updatenotice.Name = "updatenotice"
        Me.updatenotice.Size = New System.Drawing.Size(40, 13)
        Me.updatenotice.TabIndex = 3
        Me.updatenotice.Text = "Notice"
        '
        'overwritecheckbox
        '
        Me.overwritecheckbox.AutoSize = True
        Me.overwritecheckbox.FlatAppearance.BorderSize = 0
        Me.overwritecheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.overwritecheckbox.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.overwritecheckbox.Location = New System.Drawing.Point(12, 120)
        Me.overwritecheckbox.Name = "overwritecheckbox"
        Me.overwritecheckbox.Size = New System.Drawing.Size(242, 17)
        Me.overwritecheckbox.TabIndex = 4
        Me.overwritecheckbox.Text = "Overwrite custom.styles (use with caution!)"
        Me.overwritecheckbox.UseVisualStyleBackColor = True
        '
        'updatebutton
        '
        Me.updatebutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.updatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updatebutton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatebutton.Location = New System.Drawing.Point(12, 144)
        Me.updatebutton.Name = "updatebutton"
        Me.updatebutton.Size = New System.Drawing.Size(164, 23)
        Me.updatebutton.TabIndex = 5
        Me.updatebutton.Text = "Update Metro for Steam now!"
        Me.updatebutton.UseVisualStyleBackColor = False
        '
        'currentversionlabel
        '
        Me.currentversionlabel.AutoSize = True
        Me.currentversionlabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentversionlabel.Location = New System.Drawing.Point(113, 50)
        Me.currentversionlabel.Name = "currentversionlabel"
        Me.currentversionlabel.Size = New System.Drawing.Size(40, 13)
        Me.currentversionlabel.TabIndex = 6
        Me.currentversionlabel.Text = "Label1"
        '
        'newversionlabel
        '
        Me.newversionlabel.AutoSize = True
        Me.newversionlabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newversionlabel.Location = New System.Drawing.Point(113, 67)
        Me.newversionlabel.Name = "newversionlabel"
        Me.newversionlabel.Size = New System.Drawing.Size(40, 13)
        Me.newversionlabel.TabIndex = 7
        Me.newversionlabel.Text = "Label1"
        '
        'titlebar
        '
        Me.titlebar.AllowDrop = True
        Me.titlebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.titlebar.Controls.Add(Me.title)
        Me.titlebar.Controls.Add(Me.minimizebutton)
        Me.titlebar.Controls.Add(Me.closebutton)
        Me.titlebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.titlebar.Location = New System.Drawing.Point(0, 0)
        Me.titlebar.Name = "titlebar"
        Me.titlebar.Size = New System.Drawing.Size(288, 34)
        Me.titlebar.TabIndex = 8
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.Location = New System.Drawing.Point(3, 9)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(154, 17)
        Me.title.TabIndex = 2
        Me.title.Text = "Metro for Steam Installer"
        '
        'minimizebutton
        '
        Me.minimizebutton.FlatAppearance.BorderSize = 0
        Me.minimizebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.minimizebutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minimizebutton.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.minimizebutton.Location = New System.Drawing.Point(232, 0)
        Me.minimizebutton.Name = "minimizebutton"
        Me.minimizebutton.Size = New System.Drawing.Size(28, 23)
        Me.minimizebutton.TabIndex = 1
        Me.minimizebutton.Text = "__"
        Me.minimizebutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.minimizebutton.UseVisualStyleBackColor = True
        '
        'closebutton
        '
        Me.closebutton.FlatAppearance.BorderSize = 0
        Me.closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closebutton.Font = New System.Drawing.Font("Webdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.closebutton.Location = New System.Drawing.Point(260, 0)
        Me.closebutton.Name = "closebutton"
        Me.closebutton.Size = New System.Drawing.Size(28, 23)
        Me.closebutton.TabIndex = 0
        Me.closebutton.Text = "r"
        Me.closebutton.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.closebutton.UseVisualStyleBackColor = True
        '
        'mainwindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(288, 181)
        Me.Controls.Add(Me.titlebar)
        Me.Controls.Add(Me.newversionlabel)
        Me.Controls.Add(Me.currentversionlabel)
        Me.Controls.Add(Me.updatebutton)
        Me.Controls.Add(Me.overwritecheckbox)
        Me.Controls.Add(Me.updatenotice)
        Me.Controls.Add(Me.textnew)
        Me.Controls.Add(Me.textcurrent)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "mainwindow"
        Me.Text = "Metro Installer"
        Me.titlebar.ResumeLayout(False)
        Me.titlebar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents textcurrent As System.Windows.Forms.Label
    Friend WithEvents textnew As System.Windows.Forms.Label
    Friend WithEvents updatenotice As System.Windows.Forms.Label
    Friend WithEvents overwritecheckbox As System.Windows.Forms.CheckBox
    Friend WithEvents updatebutton As System.Windows.Forms.Button
    Friend WithEvents currentversionlabel As System.Windows.Forms.Label
    Friend WithEvents newversionlabel As System.Windows.Forms.Label
    Friend WithEvents titlebar As System.Windows.Forms.Panel
    Friend WithEvents closebutton As System.Windows.Forms.Button
    Friend WithEvents minimizebutton As System.Windows.Forms.Button
    Friend WithEvents title As System.Windows.Forms.Label

End Class
