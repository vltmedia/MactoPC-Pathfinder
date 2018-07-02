<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PathTracer
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnQuest = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnMactoPC
        '
        Me.BtnMactoPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMactoPC.Location = New System.Drawing.Point(864, 70)
        Me.BtnMactoPC.Name = "BtnMactoPC"
        Me.BtnMactoPC.Size = New System.Drawing.Size(83, 25)
        Me.BtnMactoPC.TabIndex = 0
        Me.BtnMactoPC.Text = "Mac > PC"
        Me.BtnMactoPC.UseVisualStyleBackColor = True
        '
        'Txtenter
        '
        Me.Txtenter.Location = New System.Drawing.Point(552, 73)
        Me.Txtenter.Name = "Txtenter"
        Me.Txtenter.Size = New System.Drawing.Size(306, 21)
        Me.Txtenter.TabIndex = 1
        '
        'TxtA
        '
        Me.TxtA.Location = New System.Drawing.Point(28, 97)
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
        Me.LinkA.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LinkA.Location = New System.Drawing.Point(25, 142)
        Me.LinkA.Name = "LinkA"
        Me.LinkA.Size = New System.Drawing.Size(395, 14)
        Me.LinkA.TabIndex = 4
        Me.LinkA.TabStop = True
        Me.LinkA.Text = "PATH"
        Me.LinkA.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnPCtoMac
        '
        Me.BtnPCtoMac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPCtoMac.Location = New System.Drawing.Point(340, 94)
        Me.BtnPCtoMac.Name = "BtnPCtoMac"
        Me.BtnPCtoMac.Size = New System.Drawing.Size(83, 25)
        Me.BtnPCtoMac.TabIndex = 0
        Me.BtnPCtoMac.Text = "PC > Mac"
        Me.BtnPCtoMac.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(178, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 14)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Shortcut: Alt + V"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("DIN", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(98, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(269, 46)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "PATH TRACER"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnQuest
        '
        Me.btnQuest.AutoSize = True
        Me.btnQuest.Location = New System.Drawing.Point(422, 194)
        Me.btnQuest.Name = "btnQuest"
        Me.btnQuest.Size = New System.Drawing.Size(12, 14)
        Me.btnQuest.TabIndex = 6
        Me.btnQuest.Text = "?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 14)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Settings"
        '
        'PathTracer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(451, 230)
        Me.Controls.Add(Me.btnQuest)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkA)
        Me.Controls.Add(Me.LblA)
        Me.Controls.Add(Me.TxtA)
        Me.Controls.Add(Me.Txtenter)
        Me.Controls.Add(Me.BtnPCtoMac)
        Me.Controls.Add(Me.BtnMactoPC)
        Me.Font = New System.Drawing.Font("DIN", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "PathTracer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Path Tracer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnMactoPC As Button
    Friend WithEvents Txtenter As TextBox
    Friend WithEvents TxtA As TextBox
    Friend WithEvents LblA As Label
    Friend WithEvents LinkA As LinkLabel
    Friend WithEvents BtnPCtoMac As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnQuest As Label
    Friend WithEvents Label3 As Label
End Class
