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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtPart1 = New System.Windows.Forms.TextBox()
        Me.txtPart2 = New System.Windows.Forms.TextBox()
        Me.txtPart3 = New System.Windows.Forms.TextBox()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(243, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Title Bar For Message"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(243, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Part 1 Message"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(243, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Part 2 Message"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(243, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Part 3 Message"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(454, 67)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(100, 26)
        Me.txtTitle.TabIndex = 1
        '
        'txtPart1
        '
        Me.txtPart1.Location = New System.Drawing.Point(454, 151)
        Me.txtPart1.Name = "txtPart1"
        Me.txtPart1.Size = New System.Drawing.Size(100, 26)
        Me.txtPart1.TabIndex = 1
        '
        'txtPart2
        '
        Me.txtPart2.Location = New System.Drawing.Point(454, 207)
        Me.txtPart2.Name = "txtPart2"
        Me.txtPart2.Size = New System.Drawing.Size(100, 26)
        Me.txtPart2.TabIndex = 1
        '
        'txtPart3
        '
        Me.txtPart3.Location = New System.Drawing.Point(454, 264)
        Me.txtPart3.Name = "txtPart3"
        Me.txtPart3.Size = New System.Drawing.Size(100, 26)
        Me.txtPart3.TabIndex = 1
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(323, 358)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(153, 49)
        Me.btn1.TabIndex = 2
        Me.btn1.Text = "Send Message"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(505, 358)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 49)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1280, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.txtPart3)
        Me.Controls.Add(Me.txtPart2)
        Me.Controls.Add(Me.txtPart1)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtPart1 As TextBox
    Friend WithEvents txtPart2 As TextBox
    Friend WithEvents txtPart3 As TextBox
    Friend WithEvents btn1 As Button
    Friend WithEvents Button2 As Button
End Class
