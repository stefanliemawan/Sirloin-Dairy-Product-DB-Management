<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.QueryButton = New System.Windows.Forms.Button()
        Me.InsertButton = New System.Windows.Forms.Button()
        Me.ViewTablesButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'QueryButton
        '
        Me.QueryButton.BackColor = System.Drawing.Color.Black
        Me.QueryButton.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QueryButton.ForeColor = System.Drawing.SystemColors.Control
        Me.QueryButton.Location = New System.Drawing.Point(38, 257)
        Me.QueryButton.Name = "QueryButton"
        Me.QueryButton.Size = New System.Drawing.Size(220, 100)
        Me.QueryButton.TabIndex = 26
        Me.QueryButton.Text = "Show Query"
        Me.QueryButton.UseVisualStyleBackColor = False
        '
        'InsertButton
        '
        Me.InsertButton.BackColor = System.Drawing.Color.Black
        Me.InsertButton.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InsertButton.ForeColor = System.Drawing.SystemColors.Control
        Me.InsertButton.Location = New System.Drawing.Point(285, 257)
        Me.InsertButton.Name = "InsertButton"
        Me.InsertButton.Size = New System.Drawing.Size(220, 48)
        Me.InsertButton.TabIndex = 25
        Me.InsertButton.Text = "InsertTable"
        Me.InsertButton.UseVisualStyleBackColor = False
        '
        'ViewTablesButton
        '
        Me.ViewTablesButton.BackColor = System.Drawing.Color.Black
        Me.ViewTablesButton.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewTablesButton.ForeColor = System.Drawing.SystemColors.Control
        Me.ViewTablesButton.Location = New System.Drawing.Point(532, 257)
        Me.ViewTablesButton.Name = "ViewTablesButton"
        Me.ViewTablesButton.Size = New System.Drawing.Size(220, 100)
        Me.ViewTablesButton.TabIndex = 27
        Me.ViewTablesButton.Text = "View Existing Tables"
        Me.ViewTablesButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Constantia", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(-3, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(781, 261)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "WELCOME TO SIRLOIN DAIRY PRODUCT DATABASE MANAGEMENT"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Constantia", 12.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(34, 384)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 37)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "CREATED BY"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(121, 447)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 37)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Stefan Liemawan"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(255, 447)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 37)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Jordy Filbert"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(398, 447)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 37)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Edbert Hans"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Constantia", 12.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(53, 533)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(534, 19)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "pictures are from https://www.thewallpapers.org/desktop/57133/cow-wallpaper"
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.Black
        Me.UpdateButton.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateButton.ForeColor = System.Drawing.SystemColors.Control
        Me.UpdateButton.Location = New System.Drawing.Point(285, 311)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(220, 46)
        Me.UpdateButton.TabIndex = 35
        Me.UpdateButton.Text = "UpdateTable"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.FinalProject.My.Resources.Resources.cow_www_TheWallpapers_org__1024x640_
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ViewTablesButton)
        Me.Controls.Add(Me.QueryButton)
        Me.Controls.Add(Me.InsertButton)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sirloin Dairy Product"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents QueryButton As Button
    Friend WithEvents InsertButton As Button
    Friend WithEvents ViewTablesButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents UpdateButton As Button
End Class
