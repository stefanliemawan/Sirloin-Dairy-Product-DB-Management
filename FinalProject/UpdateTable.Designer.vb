<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateTable
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
        Me.Table = New System.Windows.Forms.ComboBox()
        Me.TableLbl = New System.Windows.Forms.Label()
        Me.Title = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Back = New System.Windows.Forms.Button()
        Me.HistoryButton = New System.Windows.Forms.Button()
        Me.DoButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Table
        '
        Me.Table.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Table.FormattingEnabled = True
        Me.Table.Location = New System.Drawing.Point(503, 49)
        Me.Table.Name = "Table"
        Me.Table.Size = New System.Drawing.Size(149, 34)
        Me.Table.TabIndex = 20
        '
        'TableLbl
        '
        Me.TableLbl.AutoSize = True
        Me.TableLbl.BackColor = System.Drawing.Color.Transparent
        Me.TableLbl.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLbl.ForeColor = System.Drawing.SystemColors.Control
        Me.TableLbl.Location = New System.Drawing.Point(313, 50)
        Me.TableLbl.Name = "TableLbl"
        Me.TableLbl.Size = New System.Drawing.Size(148, 33)
        Me.TableLbl.TabIndex = 19
        Me.TableLbl.Text = "Select Table"
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.Font = New System.Drawing.Font("Constantia", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.SystemColors.Control
        Me.Title.Location = New System.Drawing.Point(87, 44)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(120, 33)
        Me.Title.TabIndex = 18
        Me.Title.Text = "UPDATE"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(283, 167)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(230, 34)
        Me.ComboBox1.TabIndex = 21
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Constantia", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(283, 282)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(230, 34)
        Me.ComboBox2.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(87, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 33)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Set Column"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(87, 282)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 33)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Where"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(560, 168)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(158, 31)
        Me.TextBox1.TabIndex = 28
        '
        'Back
        '
        Me.Back.BackColor = System.Drawing.Color.Black
        Me.Back.Font = New System.Drawing.Font("Constantia", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.ForeColor = System.Drawing.SystemColors.Control
        Me.Back.Location = New System.Drawing.Point(9, 493)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(136, 56)
        Me.Back.TabIndex = 33
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = False
        '
        'HistoryButton
        '
        Me.HistoryButton.BackColor = System.Drawing.Color.Black
        Me.HistoryButton.Font = New System.Drawing.Font("Constantia", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HistoryButton.ForeColor = System.Drawing.Color.White
        Me.HistoryButton.Location = New System.Drawing.Point(270, 482)
        Me.HistoryButton.Name = "HistoryButton"
        Me.HistoryButton.Size = New System.Drawing.Size(221, 67)
        Me.HistoryButton.TabIndex = 35
        Me.HistoryButton.Text = "History"
        Me.HistoryButton.UseVisualStyleBackColor = False
        '
        'DoButton
        '
        Me.DoButton.BackColor = System.Drawing.Color.Black
        Me.DoButton.Font = New System.Drawing.Font("Constantia", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoButton.ForeColor = System.Drawing.Color.White
        Me.DoButton.Location = New System.Drawing.Point(270, 392)
        Me.DoButton.Name = "DoButton"
        Me.DoButton.Size = New System.Drawing.Size(220, 67)
        Me.DoButton.TabIndex = 34
        Me.DoButton.Text = "Do It!"
        Me.DoButton.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.BackgroundImage = Global.FinalProject.My.Resources.Resources.cow_www_TheWallpapers_org__1024x640_
        Me.GroupBox1.Controls.Add(Me.CloseButton)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(760, 537)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CloseButton.Font = New System.Drawing.Font("Constantia", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.ForeColor = System.Drawing.Color.White
        Me.CloseButton.Location = New System.Drawing.Point(566, 26)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(150, 322)
        Me.CloseButton.TabIndex = 1
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 23
        Me.ListBox1.Location = New System.Drawing.Point(17, 19)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(495, 487)
        Me.ListBox1.TabIndex = 0
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(560, 284)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(158, 31)
        Me.TextBox2.TabIndex = 37
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(524, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 33)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Constantia", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(524, 282)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 33)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "="
        '
        'UpdateTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FinalProject.My.Resources.Resources.cow_www_TheWallpapers_org__1024x640_
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.HistoryButton)
        Me.Controls.Add(Me.DoButton)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Table)
        Me.Controls.Add(Me.TableLbl)
        Me.Controls.Add(Me.Title)
        Me.Name = "UpdateTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Table As ComboBox
    Friend WithEvents TableLbl As Label
    Friend WithEvents Title As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Back As Button
    Friend WithEvents HistoryButton As Button
    Friend WithEvents DoButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CloseButton As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
