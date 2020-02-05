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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblBound = New System.Windows.Forms.Label()
        Me.lblCorrectAnswers = New System.Windows.Forms.Label()
        Me.lblMinutes = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.txtSubmittedNum = New System.Windows.Forms.TextBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblOperand = New System.Windows.Forms.Label()
        Me.lblFirstGivenNum = New System.Windows.Forms.Label()
        Me.lblSecondGivenNum = New System.Windows.Forms.Label()
        Me.lblRemarks = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblBound
        '
        Me.lblBound.BackColor = System.Drawing.Color.Transparent
        Me.lblBound.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBound.Location = New System.Drawing.Point(189, 275)
        Me.lblBound.Name = "lblBound"
        Me.lblBound.Size = New System.Drawing.Size(65, 32)
        Me.lblBound.TabIndex = 3
        Me.lblBound.Text = "10"
        Me.lblBound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCorrectAnswers
        '
        Me.lblCorrectAnswers.BackColor = System.Drawing.Color.Transparent
        Me.lblCorrectAnswers.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrectAnswers.Location = New System.Drawing.Point(391, 269)
        Me.lblCorrectAnswers.Name = "lblCorrectAnswers"
        Me.lblCorrectAnswers.Size = New System.Drawing.Size(58, 45)
        Me.lblCorrectAnswers.TabIndex = 4
        Me.lblCorrectAnswers.Text = "0"
        Me.lblCorrectAnswers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMinutes
        '
        Me.lblMinutes.BackColor = System.Drawing.Color.Transparent
        Me.lblMinutes.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinutes.Location = New System.Drawing.Point(333, -1)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.Size = New System.Drawing.Size(28, 47)
        Me.lblMinutes.TabIndex = 5
        Me.lblMinutes.Text = "1"
        Me.lblMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(356, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 47)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = ":"
        '
        'lblSeconds
        '
        Me.lblSeconds.BackColor = System.Drawing.Color.Transparent
        Me.lblSeconds.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeconds.Location = New System.Drawing.Point(367, -1)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(64, 47)
        Me.lblSeconds.TabIndex = 7
        Me.lblSeconds.Text = "59"
        Me.lblSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSubmittedNum
        '
        Me.txtSubmittedNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubmittedNum.Location = New System.Drawing.Point(259, 192)
        Me.txtSubmittedNum.Name = "txtSubmittedNum"
        Me.txtSubmittedNum.Size = New System.Drawing.Size(62, 40)
        Me.txtSubmittedNum.TabIndex = 12
        Me.txtSubmittedNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Aqua
        Me.btnStart.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnStart.Font = New System.Drawing.Font("Lucida Sans Typewriter", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(0, 380)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(457, 67)
        Me.btnStart.TabIndex = 13
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Aqua
        Me.btnNext.Enabled = False
        Me.btnNext.Font = New System.Drawing.Font("Lucida Sans Typewriter", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(224, 317)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(233, 66)
        Me.btnNext.TabIndex = 14
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Aqua
        Me.btnSubmit.Enabled = False
        Me.btnSubmit.Font = New System.Drawing.Font("Lucida Sans Typewriter", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(0, 317)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(231, 66)
        Me.btnSubmit.TabIndex = 15
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblOperand
        '
        Me.lblOperand.BackColor = System.Drawing.Color.Transparent
        Me.lblOperand.Font = New System.Drawing.Font("Courier New", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOperand.Location = New System.Drawing.Point(165, 71)
        Me.lblOperand.Name = "lblOperand"
        Me.lblOperand.Size = New System.Drawing.Size(126, 107)
        Me.lblOperand.TabIndex = 18
        Me.lblOperand.Text = "+"
        Me.lblOperand.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblFirstGivenNum
        '
        Me.lblFirstGivenNum.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstGivenNum.Font = New System.Drawing.Font("Courier New", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstGivenNum.Location = New System.Drawing.Point(-6, 59)
        Me.lblFirstGivenNum.Name = "lblFirstGivenNum"
        Me.lblFirstGivenNum.Size = New System.Drawing.Size(189, 127)
        Me.lblFirstGivenNum.TabIndex = 14
        Me.lblFirstGivenNum.Text = "0"
        Me.lblFirstGivenNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSecondGivenNum
        '
        Me.lblSecondGivenNum.BackColor = System.Drawing.Color.Transparent
        Me.lblSecondGivenNum.Font = New System.Drawing.Font("Courier New", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecondGivenNum.Location = New System.Drawing.Point(252, 55)
        Me.lblSecondGivenNum.Name = "lblSecondGivenNum"
        Me.lblSecondGivenNum.Size = New System.Drawing.Size(197, 134)
        Me.lblSecondGivenNum.TabIndex = 19
        Me.lblSecondGivenNum.Text = "0"
        Me.lblSecondGivenNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRemarks
        '
        Me.lblRemarks.BackColor = System.Drawing.Color.Transparent
        Me.lblRemarks.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblRemarks.Font = New System.Drawing.Font("Courier New", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemarks.Location = New System.Drawing.Point(233, 235)
        Me.lblRemarks.Name = "lblRemarks"
        Me.lblRemarks.Size = New System.Drawing.Size(175, 34)
        Me.lblRemarks.TabIndex = 16
        Me.lblRemarks.Text = "-"
        Me.lblRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(163, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 47)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Time Left : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(300, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 45)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Score :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 32)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Items Left :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Font = New System.Drawing.Font("Courier New", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(192, 34)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Your Answer :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Courier New", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(56, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(175, 34)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Remarks : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(12, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 38)
        Me.Button1.TabIndex = 20
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(457, 447)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblBound)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSeconds)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblMinutes)
        Me.Controls.Add(Me.lblOperand)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.txtSubmittedNum)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblFirstGivenNum)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblRemarks)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblCorrectAnswers)
        Me.Controls.Add(Me.lblSecondGivenNum)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FlashCards"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBound As System.Windows.Forms.Label
    Friend WithEvents lblCorrectAnswers As System.Windows.Forms.Label
    Friend WithEvents lblMinutes As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSeconds As System.Windows.Forms.Label
    Friend WithEvents txtSubmittedNum As System.Windows.Forms.TextBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblOperand As System.Windows.Forms.Label
    Friend WithEvents lblFirstGivenNum As System.Windows.Forms.Label
    Friend WithEvents lblSecondGivenNum As System.Windows.Forms.Label
    Friend WithEvents lblRemarks As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
