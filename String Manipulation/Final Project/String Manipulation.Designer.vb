<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinal
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
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblRandom = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCountyState = New System.Windows.Forms.TextBox()
        Me.btnTotalHousehold = New System.Windows.Forms.Button()
        Me.btnAverageHousehold = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIncome = New System.Windows.Forms.TextBox()
        Me.lblRand = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(46, 324)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(56, 19)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblRandom
        '
        Me.lblRandom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRandom.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRandom.Location = New System.Drawing.Point(171, 32)
        Me.lblRandom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRandom.Name = "lblRandom"
        Me.lblRandom.Size = New System.Drawing.Size(200, 47)
        Me.lblRandom.TabIndex = 2
        Me.lblRandom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(171, 82)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "County and State"
        '
        'txtCountyState
        '
        Me.txtCountyState.Location = New System.Drawing.Point(171, 120)
        Me.txtCountyState.Name = "txtCountyState"
        Me.txtCountyState.Size = New System.Drawing.Size(200, 20)
        Me.txtCountyState.TabIndex = 6
        '
        'btnTotalHousehold
        '
        Me.btnTotalHousehold.AutoSize = True
        Me.btnTotalHousehold.Location = New System.Drawing.Point(171, 324)
        Me.btnTotalHousehold.Name = "btnTotalHousehold"
        Me.btnTotalHousehold.Size = New System.Drawing.Size(148, 23)
        Me.btnTotalHousehold.TabIndex = 8
        Me.btnTotalHousehold.Text = "Total Households Surveyed"
        Me.btnTotalHousehold.UseVisualStyleBackColor = True
        '
        'btnAverageHousehold
        '
        Me.btnAverageHousehold.AutoSize = True
        Me.btnAverageHousehold.Location = New System.Drawing.Point(328, 324)
        Me.btnAverageHousehold.Name = "btnAverageHousehold"
        Me.btnAverageHousehold.Size = New System.Drawing.Size(149, 23)
        Me.btnAverageHousehold.TabIndex = 9
        Me.btnAverageHousehold.Text = "Average Household Income"
        Me.btnAverageHousehold.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(490, 324)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Household Yearly Income"
        '
        'txtIncome
        '
        Me.txtIncome.Location = New System.Drawing.Point(171, 168)
        Me.txtIncome.Name = "txtIncome"
        Me.txtIncome.Size = New System.Drawing.Size(200, 20)
        Me.txtIncome.TabIndex = 12
        '
        'lblRand
        '
        Me.lblRand.AutoSize = True
        Me.lblRand.Location = New System.Drawing.Point(16, 32)
        Me.lblRand.Name = "lblRand"
        Me.lblRand.Size = New System.Drawing.Size(87, 13)
        Me.lblRand.TabIndex = 13
        Me.lblRand.Text = "Random Number"
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.Location = New System.Drawing.Point(16, 82)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(58, 13)
        Me.lblDateTime.TabIndex = 14
        Me.lblDateTime.Text = "Date/Time"
        '
        'frmFinal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 507)
        Me.Controls.Add(Me.lblDateTime)
        Me.Controls.Add(Me.lblRand)
        Me.Controls.Add(Me.txtIncome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAverageHousehold)
        Me.Controls.Add(Me.btnTotalHousehold)
        Me.Controls.Add(Me.txtCountyState)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblRandom)
        Me.Name = "frmFinal"
        Me.Text = "String Manipulation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblRandom As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCountyState As TextBox
    Friend WithEvents btnTotalHousehold As Button
    Friend WithEvents btnAverageHousehold As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIncome As TextBox
    Friend WithEvents lblRand As Label
    Friend WithEvents lblDateTime As Label
End Class
