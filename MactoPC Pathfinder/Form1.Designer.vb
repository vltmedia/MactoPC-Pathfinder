<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BtnMactoPC = New System.Windows.Forms.Button()
        Me.Txtenter = New System.Windows.Forms.TextBox()
        Me.TxtA = New System.Windows.Forms.TextBox()
        Me.LblA = New System.Windows.Forms.Label()
        Me.LinkA = New System.Windows.Forms.LinkLabel()
        Me.BtnPCtoMac = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnMactoPC
        '
        Me.BtnMactoPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMactoPC.Location = New System.Drawing.Point(343, 26)
        Me.BtnMactoPC.Name = "BtnMactoPC"
        Me.BtnMactoPC.Size = New System.Drawing.Size(83, 25)
        Me.BtnMactoPC.TabIndex = 0
        Me.BtnMactoPC.Text = "Mac > PC"
        Me.BtnMactoPC.UseVisualStyleBackColor = True
        '
        'Txtenter
        '
        Me.Txtenter.Location = New System.Drawing.Point(31, 29)
        Me.Txtenter.Name = "Txtenter"
        Me.Txtenter.Size = New System.Drawing.Size(306, 21)
        Me.Txtenter.TabIndex = 1
        '
        'TxtA
        '
        Me.TxtA.Location = New System.Drawing.Point(31, 60)
        Me.TxtA.Name = "TxtA"
        Me.TxtA.Size = New System.Drawing.Size(306, 21)
        Me.TxtA.TabIndex = 2
        '
        'LblA
        '
        Me.LblA.AutoSize = True
        Me.LblA.Location = New System.Drawing.Point(493, 115)
        Me.LblA.Name = "LblA"
        Me.LblA.Size = New System.Drawing.Size(40, 14)
        Me.LblA.TabIndex = 3
        Me.LblA.Text = "Label1"
        '
        'LinkA
        '
        Me.LinkA.AutoSize = True
        Me.LinkA.Location = New System.Drawing.Point(28, 109)
        Me.LinkA.Name = "LinkA"
        Me.LinkA.Size = New System.Drawing.Size(61, 14)
        Me.LinkA.TabIndex = 4
        Me.LinkA.TabStop = True
        Me.LinkA.Text = "LinkLabel1"
        '
        'BtnPCtoMac
        '
        Me.BtnPCtoMac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPCtoMac.Location = New System.Drawing.Point(343, 57)
        Me.BtnPCtoMac.Name = "BtnPCtoMac"
        Me.BtnPCtoMac.Size = New System.Drawing.Size(83, 25)
        Me.BtnPCtoMac.TabIndex = 0
        Me.BtnPCtoMac.Text = "PC > Mac"
        Me.BtnPCtoMac.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(446, 153)
        Me.Controls.Add(Me.LinkA)
        Me.Controls.Add(Me.LblA)
        Me.Controls.Add(Me.TxtA)
        Me.Controls.Add(Me.Txtenter)
        Me.Controls.Add(Me.BtnPCtoMac)
        Me.Controls.Add(Me.BtnMactoPC)
        Me.Font = New System.Drawing.Font("DIN", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnMactoPC As Button
    Friend WithEvents Txtenter As TextBox
    Friend WithEvents TxtA As TextBox
    Friend WithEvents LblA As Label
    Friend WithEvents LinkA As LinkLabel
    Friend WithEvents BtnPCtoMac As Button
End Class
