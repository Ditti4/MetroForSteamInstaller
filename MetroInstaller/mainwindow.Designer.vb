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
        Me.SuspendLayout()
        '
        'textcurrent
        '
        Me.textcurrent.AutoSize = True
        Me.textcurrent.Location = New System.Drawing.Point(13, 13)
        Me.textcurrent.Name = "textcurrent"
        Me.textcurrent.Size = New System.Drawing.Size(81, 13)
        Me.textcurrent.TabIndex = 0
        Me.textcurrent.Text = "Current version:"
        '
        'textnew
        '
        Me.textnew.AutoSize = True
        Me.textnew.Location = New System.Drawing.Point(13, 30)
        Me.textnew.Name = "textnew"
        Me.textnew.Size = New System.Drawing.Size(83, 13)
        Me.textnew.TabIndex = 1
        Me.textnew.Text = "Newest version:"
        '
        'updatenotice
        '
        Me.updatenotice.AutoSize = True
        Me.updatenotice.Location = New System.Drawing.Point(16, 57)
        Me.updatenotice.Name = "updatenotice"
        Me.updatenotice.Size = New System.Drawing.Size(38, 13)
        Me.updatenotice.TabIndex = 3
        Me.updatenotice.Text = "Notice"
        '
        'overwritecheckbox
        '
        Me.overwritecheckbox.AutoSize = True
        Me.overwritecheckbox.FlatAppearance.BorderSize = 0
        Me.overwritecheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.overwritecheckbox.Location = New System.Drawing.Point(13, 83)
        Me.overwritecheckbox.Name = "overwritecheckbox"
        Me.overwritecheckbox.Size = New System.Drawing.Size(223, 17)
        Me.overwritecheckbox.TabIndex = 4
        Me.overwritecheckbox.Text = "Overwrite custom.styles (use with caution!)"
        Me.overwritecheckbox.UseVisualStyleBackColor = True
        '
        'updatebutton
        '
        Me.updatebutton.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.updatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updatebutton.Location = New System.Drawing.Point(13, 107)
        Me.updatebutton.Name = "updatebutton"
        Me.updatebutton.Size = New System.Drawing.Size(164, 23)
        Me.updatebutton.TabIndex = 5
        Me.updatebutton.Text = "Update Metro for Steam now!"
        Me.updatebutton.UseVisualStyleBackColor = True
        '
        'currentversionlabel
        '
        Me.currentversionlabel.AutoSize = True
        Me.currentversionlabel.Location = New System.Drawing.Point(114, 13)
        Me.currentversionlabel.Name = "currentversionlabel"
        Me.currentversionlabel.Size = New System.Drawing.Size(39, 13)
        Me.currentversionlabel.TabIndex = 6
        Me.currentversionlabel.Text = "Label1"
        '
        'newversionlabel
        '
        Me.newversionlabel.AutoSize = True
        Me.newversionlabel.Location = New System.Drawing.Point(114, 30)
        Me.newversionlabel.Name = "newversionlabel"
        Me.newversionlabel.Size = New System.Drawing.Size(39, 13)
        Me.newversionlabel.TabIndex = 7
        Me.newversionlabel.Text = "Label1"
        '
        'mainwindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(288, 155)
        Me.Controls.Add(Me.newversionlabel)
        Me.Controls.Add(Me.currentversionlabel)
        Me.Controls.Add(Me.updatebutton)
        Me.Controls.Add(Me.overwritecheckbox)
        Me.Controls.Add(Me.updatenotice)
        Me.Controls.Add(Me.textnew)
        Me.Controls.Add(Me.textcurrent)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "mainwindow"
        Me.Text = "Metro Installer"
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

End Class
