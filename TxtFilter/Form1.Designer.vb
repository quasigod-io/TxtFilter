<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFilter
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
        Me.lstFilter = New System.Windows.Forms.ListBox()
        Me.lstMain = New System.Windows.Forms.ListBox()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstFilter
        '
        Me.lstFilter.FormattingEnabled = True
        Me.lstFilter.Location = New System.Drawing.Point(12, 12)
        Me.lstFilter.Name = "lstFilter"
        Me.lstFilter.Size = New System.Drawing.Size(120, 173)
        Me.lstFilter.TabIndex = 0
        '
        'lstMain
        '
        Me.lstMain.FormattingEnabled = True
        Me.lstMain.Location = New System.Drawing.Point(138, 12)
        Me.lstMain.Name = "lstMain"
        Me.lstMain.Size = New System.Drawing.Size(120, 173)
        Me.lstMain.TabIndex = 1
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(12, 191)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(246, 23)
        Me.btnFilter.TabIndex = 2
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'frmFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 236)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.lstMain)
        Me.Controls.Add(Me.lstFilter)
        Me.Name = "frmFilter"
        Me.Text = "Filter"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstFilter As ListBox
    Friend WithEvents lstMain As ListBox
    Friend WithEvents btnFilter As Button
End Class
