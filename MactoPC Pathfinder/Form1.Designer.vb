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
        Me.BtnMactoPC.Location = New System.Drawing.Point(346, 32)
        Me.BtnMactoPC.Name = "BtnMactoPC"
        Me.BtnMactoPC.Size = New System.Drawing.Size(83, 23)
        Me.BtnMactoPC.TabIndex = 0
        Me.BtnMactoPC.Text = "Mac > PC"
        Me.BtnMactoPC.UseVisualStyleBackColor = True
        '
        'Txtenter
        '
        Me.Txtenter.Location = New System.Drawing.Point(34, 35)
        Me.Txtenter.Name = "Txtenter"
        Me.Txtenter.Size = New System.Drawing.Size(306, 20)
        Me.Txtenter.TabIndex = 1
        '
        'TxtA
        '
        Me.TxtA.Location = New System.Drawing.Point(34, 64)
        Me.TxtA.Name = "TxtA"
        Me.TxtA.Size = New System.Drawing.Size(306, 20)
        Me.TxtA.TabIndex = 2
        '
        'LblA
        '
        Me.LblA.AutoSize = True
        Me.LblA.Location = New System.Drawing.Point(31, 122)
        Me.LblA.Name = "LblA"
        Me.LblA.Size = New System.Drawing.Size(39, 13)
        Me.LblA.TabIndex = 3
        Me.LblA.Text = "Label1"
        '
        'LinkA
        '
        Me.LinkA.AutoSize = True
        Me.LinkA.Location = New System.Drawing.Point(31, 147)
        Me.LinkA.Name = "LinkA"
        Me.LinkA.Size = New System.Drawing.Size(59, 13)
        Me.LinkA.TabIndex = 4
        Me.LinkA.TabStop = True
        Me.LinkA.Text = "LinkLabel1"
        '
        'BtnPCtoMac
        '
        Me.BtnPCtoMac.Location = New System.Drawing.Point(346, 61)
        Me.BtnPCtoMac.Name = "BtnPCtoMac"
        Me.BtnPCtoMac.Size = New System.Drawing.Size(83, 23)
        Me.BtnPCtoMac.TabIndex = 0
        Me.BtnPCtoMac.Text = "PC > Mac"
        Me.BtnPCtoMac.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 176)
        Me.Controls.Add(Me.LinkA)
        Me.Controls.Add(Me.LblA)
        Me.Controls.Add(Me.TxtA)
        Me.Controls.Add(Me.Txtenter)
        Me.Controls.Add(Me.BtnPCtoMac)
        Me.Controls.Add(Me.BtnMactoPC)
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
