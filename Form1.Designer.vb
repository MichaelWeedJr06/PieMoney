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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDontionAMt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDonate = New System.Windows.Forms.Button()
        Me.cboStudents = New System.Windows.Forms.ComboBox()
        Me.lstStudentDonations = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblStudentTotal = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblClassTotal = New System.Windows.Forms.Label()
        Me.lblHighest = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'txtDontionAMt
        '
        Me.txtDontionAMt.Location = New System.Drawing.Point(341, 41)
        Me.txtDontionAMt.Name = "txtDontionAMt"
        Me.txtDontionAMt.Size = New System.Drawing.Size(100, 20)
        Me.txtDontionAMt.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(246, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Donation Amount"
        '
        'btnDonate
        '
        Me.btnDonate.Location = New System.Drawing.Point(480, 39)
        Me.btnDonate.Name = "btnDonate"
        Me.btnDonate.Size = New System.Drawing.Size(164, 23)
        Me.btnDonate.TabIndex = 4
        Me.btnDonate.Text = "Add Donation"
        Me.btnDonate.UseVisualStyleBackColor = True
        '
        'cboStudents
        '
        Me.cboStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStudents.FormattingEnabled = True
        Me.cboStudents.Location = New System.Drawing.Point(91, 41)
        Me.cboStudents.Name = "cboStudents"
        Me.cboStudents.Size = New System.Drawing.Size(121, 21)
        Me.cboStudents.Sorted = True
        Me.cboStudents.TabIndex = 5
        '
        'lstStudentDonations
        '
        Me.lstStudentDonations.FormattingEnabled = True
        Me.lstStudentDonations.Location = New System.Drawing.Point(32, 97)
        Me.lstStudentDonations.Margin = New System.Windows.Forms.Padding(2)
        Me.lstStudentDonations.Name = "lstStudentDonations"
        Me.lstStudentDonations.Size = New System.Drawing.Size(180, 69)
        Me.lstStudentDonations.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 186)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Student Total: "
        '
        'lblStudentTotal
        '
        Me.lblStudentTotal.Location = New System.Drawing.Point(104, 186)
        Me.lblStudentTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStudentTotal.Name = "lblStudentTotal"
        Me.lblStudentTotal.Size = New System.Drawing.Size(107, 13)
        Me.lblStudentTotal.TabIndex = 8
        Me.lblStudentTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(248, 97)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(80, 25)
        Me.btnRemove.TabIndex = 9
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(308, 236)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 26)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Total Donations:"
        '
        'lblClassTotal
        '
        Me.lblClassTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblClassTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassTotal.Location = New System.Drawing.Point(479, 236)
        Me.lblClassTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblClassTotal.Name = "lblClassTotal"
        Me.lblClassTotal.Size = New System.Drawing.Size(166, 26)
        Me.lblClassTotal.TabIndex = 11
        '
        'lblHighest
        '
        Me.lblHighest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHighest.Font = New System.Drawing.Font("Courier New", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighest.Location = New System.Drawing.Point(480, 97)
        Me.lblHighest.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHighest.Name = "lblHighest"
        Me.lblHighest.Size = New System.Drawing.Size(165, 116)
        Me.lblHighest.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(380, 97)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Highest Donors:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(634, 265)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(39, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 296)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblHighest)
        Me.Controls.Add(Me.lblClassTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lblStudentTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstStudentDonations)
        Me.Controls.Add(Me.cboStudents)
        Me.Controls.Add(Me.btnDonate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDontionAMt)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Donation Tracker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDontionAMt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDonate As Button
    Friend WithEvents cboStudents As ComboBox
    Friend WithEvents lstStudentDonations As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblStudentTotal As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblClassTotal As Label
    Friend WithEvents lblHighest As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnExit As Button
End Class
