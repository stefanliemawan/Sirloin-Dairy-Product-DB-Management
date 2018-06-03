<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class View
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
        Me.ViewButton = New System.Windows.Forms.Button()
        Me.TabelSelection = New System.Windows.Forms.Label()
        Me.RBProduct = New System.Windows.Forms.RadioButton()
        Me.RBBranch = New System.Windows.Forms.RadioButton()
        Me.RBStaff = New System.Windows.Forms.RadioButton()
        Me.RBCustomer = New System.Windows.Forms.RadioButton()
        Me.RBPricing = New System.Windows.Forms.RadioButton()
        Me.RBTransaction = New System.Windows.Forms.RadioButton()
        Me.Back = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ViewButton
        '
        Me.ViewButton.BackColor = System.Drawing.Color.Black
        Me.ViewButton.Font = New System.Drawing.Font("Constantia", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewButton.ForeColor = System.Drawing.SystemColors.Control
        Me.ViewButton.Location = New System.Drawing.Point(281, 448)
        Me.ViewButton.Name = "ViewButton"
        Me.ViewButton.Size = New System.Drawing.Size(226, 101)
        Me.ViewButton.TabIndex = 3
        Me.ViewButton.Text = "View"
        Me.ViewButton.UseVisualStyleBackColor = False
        '
        'TabelSelection
        '
        Me.TabelSelection.AutoSize = True
        Me.TabelSelection.BackColor = System.Drawing.Color.Transparent
        Me.TabelSelection.Font = New System.Drawing.Font("Constantia", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabelSelection.ForeColor = System.Drawing.SystemColors.Control
        Me.TabelSelection.Location = New System.Drawing.Point(219, 62)
        Me.TabelSelection.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.TabelSelection.Name = "TabelSelection"
        Me.TabelSelection.Size = New System.Drawing.Size(353, 59)
        Me.TabelSelection.TabIndex = 7
        Me.TabelSelection.Text = "SELECT TABLE"
        '
        'RBProduct
        '
        Me.RBProduct.AutoSize = True
        Me.RBProduct.BackColor = System.Drawing.Color.Transparent
        Me.RBProduct.Font = New System.Drawing.Font("Constantia", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBProduct.ForeColor = System.Drawing.SystemColors.Control
        Me.RBProduct.Location = New System.Drawing.Point(59, 299)
        Me.RBProduct.Name = "RBProduct"
        Me.RBProduct.Size = New System.Drawing.Size(162, 49)
        Me.RBProduct.TabIndex = 17
        Me.RBProduct.TabStop = True
        Me.RBProduct.Text = "Product"
        Me.RBProduct.UseVisualStyleBackColor = False
        '
        'RBBranch
        '
        Me.RBBranch.AutoSize = True
        Me.RBBranch.BackColor = System.Drawing.Color.Transparent
        Me.RBBranch.Font = New System.Drawing.Font("Constantia", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBBranch.ForeColor = System.Drawing.SystemColors.Control
        Me.RBBranch.Location = New System.Drawing.Point(59, 203)
        Me.RBBranch.Name = "RBBranch"
        Me.RBBranch.Size = New System.Drawing.Size(151, 49)
        Me.RBBranch.TabIndex = 18
        Me.RBBranch.TabStop = True
        Me.RBBranch.Text = "Branch"
        Me.RBBranch.UseVisualStyleBackColor = False
        '
        'RBStaff
        '
        Me.RBStaff.AutoSize = True
        Me.RBStaff.BackColor = System.Drawing.Color.Transparent
        Me.RBStaff.Font = New System.Drawing.Font("Constantia", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBStaff.ForeColor = System.Drawing.SystemColors.Control
        Me.RBStaff.Location = New System.Drawing.Point(583, 299)
        Me.RBStaff.Name = "RBStaff"
        Me.RBStaff.Size = New System.Drawing.Size(110, 49)
        Me.RBStaff.TabIndex = 19
        Me.RBStaff.TabStop = True
        Me.RBStaff.Text = "Staff"
        Me.RBStaff.UseVisualStyleBackColor = False
        '
        'RBCustomer
        '
        Me.RBCustomer.AutoSize = True
        Me.RBCustomer.BackColor = System.Drawing.Color.Transparent
        Me.RBCustomer.Font = New System.Drawing.Font("Constantia", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBCustomer.ForeColor = System.Drawing.SystemColors.Control
        Me.RBCustomer.Location = New System.Drawing.Point(296, 203)
        Me.RBCustomer.Name = "RBCustomer"
        Me.RBCustomer.Size = New System.Drawing.Size(192, 49)
        Me.RBCustomer.TabIndex = 20
        Me.RBCustomer.TabStop = True
        Me.RBCustomer.Text = "Customer"
        Me.RBCustomer.UseVisualStyleBackColor = False
        '
        'RBPricing
        '
        Me.RBPricing.AutoSize = True
        Me.RBPricing.BackColor = System.Drawing.Color.Transparent
        Me.RBPricing.Font = New System.Drawing.Font("Constantia", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBPricing.ForeColor = System.Drawing.SystemColors.Control
        Me.RBPricing.Location = New System.Drawing.Point(583, 203)
        Me.RBPricing.Name = "RBPricing"
        Me.RBPricing.Size = New System.Drawing.Size(150, 49)
        Me.RBPricing.TabIndex = 21
        Me.RBPricing.TabStop = True
        Me.RBPricing.Text = "Pricing"
        Me.RBPricing.UseVisualStyleBackColor = False
        '
        'RBTransaction
        '
        Me.RBTransaction.AutoSize = True
        Me.RBTransaction.BackColor = System.Drawing.Color.Transparent
        Me.RBTransaction.Font = New System.Drawing.Font("Constantia", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBTransaction.ForeColor = System.Drawing.SystemColors.Control
        Me.RBTransaction.Location = New System.Drawing.Point(296, 299)
        Me.RBTransaction.Name = "RBTransaction"
        Me.RBTransaction.Size = New System.Drawing.Size(227, 49)
        Me.RBTransaction.TabIndex = 22
        Me.RBTransaction.TabStop = True
        Me.RBTransaction.Text = "Transaction"
        Me.RBTransaction.UseVisualStyleBackColor = False
        '
        'Back
        '
        Me.Back.BackColor = System.Drawing.Color.Black
        Me.Back.Font = New System.Drawing.Font("Constantia", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.ForeColor = System.Drawing.SystemColors.Control
        Me.Back.Location = New System.Drawing.Point(21, 493)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(136, 56)
        Me.Back.TabIndex = 23
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.FinalProject.My.Resources.Resources.cow_www_TheWallpapers_org__1024x640_
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.RBTransaction)
        Me.Controls.Add(Me.RBPricing)
        Me.Controls.Add(Me.RBCustomer)
        Me.Controls.Add(Me.RBStaff)
        Me.Controls.Add(Me.RBBranch)
        Me.Controls.Add(Me.RBProduct)
        Me.Controls.Add(Me.TabelSelection)
        Me.Controls.Add(Me.ViewButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "View"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Table"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ViewButton As Button
    Friend WithEvents TabelSelection As Label
    Friend WithEvents RBProduct As RadioButton
    Friend WithEvents RBBranch As RadioButton
    Friend WithEvents RBStaff As RadioButton
    Friend WithEvents RBCustomer As RadioButton
    Friend WithEvents RBPricing As RadioButton
    Friend WithEvents RBTransaction As RadioButton
    Friend WithEvents Back As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
