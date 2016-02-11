<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelloWorld
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
        Me.components = New System.ComponentModel.Container()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.btnRestore = New System.Windows.Forms.Button()
        Me.btnHide = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblHelloWorld = New System.Windows.Forms.Label()
        Me.tbxHelloWorld = New System.Windows.Forms.TextBox()
        Me.ttpHelloWorld = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btnShow
        '
        Me.btnShow.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.Location = New System.Drawing.Point(38, 180)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(114, 55)
        Me.btnShow.TabIndex = 0
        Me.btnShow.Text = "&Show"
        Me.ttpHelloWorld.SetToolTip(Me.btnShow, " Show the textbox")
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnChange
        '
        Me.btnChange.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChange.Location = New System.Drawing.Point(321, 180)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(114, 55)
        Me.btnChange.TabIndex = 1
        Me.btnChange.Text = "&Change"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'btnRestore
        '
        Me.btnRestore.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestore.Location = New System.Drawing.Point(178, 281)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(114, 55)
        Me.btnRestore.TabIndex = 2
        Me.btnRestore.Text = "&Restore"
        Me.btnRestore.UseVisualStyleBackColor = True
        '
        'btnHide
        '
        Me.btnHide.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHide.Location = New System.Drawing.Point(38, 394)
        Me.btnHide.Name = "btnHide"
        Me.btnHide.Size = New System.Drawing.Size(114, 55)
        Me.btnHide.TabIndex = 3
        Me.btnHide.Text = "&Hide"
        Me.btnHide.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(321, 394)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(114, 55)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblHelloWorld
        '
        Me.lblHelloWorld.AutoSize = True
        Me.lblHelloWorld.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelloWorld.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblHelloWorld.Location = New System.Drawing.Point(184, 42)
        Me.lblHelloWorld.Name = "lblHelloWorld"
        Me.lblHelloWorld.Size = New System.Drawing.Size(99, 35)
        Me.lblHelloWorld.TabIndex = 5
        Me.lblHelloWorld.Text = "Label1"
        Me.lblHelloWorld.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tbxHelloWorld
        '
        Me.tbxHelloWorld.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxHelloWorld.Location = New System.Drawing.Point(163, 124)
        Me.tbxHelloWorld.Name = "tbxHelloWorld"
        Me.tbxHelloWorld.Size = New System.Drawing.Size(154, 32)
        Me.tbxHelloWorld.TabIndex = 7
        Me.tbxHelloWorld.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmHelloWorld
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Firebrick
        Me.ClientSize = New System.Drawing.Size(500, 524)
        Me.Controls.Add(Me.tbxHelloWorld)
        Me.Controls.Add(Me.lblHelloWorld)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHide)
        Me.Controls.Add(Me.btnRestore)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.btnShow)
        Me.Name = "frmHelloWorld"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hello World Program"
        Me.ttpHelloWorld.SetToolTip(Me, "Show the text box")
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents btnRestore As System.Windows.Forms.Button
    Friend WithEvents btnHide As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblHelloWorld As System.Windows.Forms.Label
    Friend WithEvents tbxHelloWorld As System.Windows.Forms.TextBox
    Friend WithEvents ttpHelloWorld As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
