Public Class Form1
    Dim r As New Random
    Dim total As Integer
    Dim Divide As Double
    Dim RandomOperator As String() = New String() {"+", "-", "*", "/"}

    Public Sub Nex()
        Dim nexts = r.Next(0, 4)
        Select Case nexts
            Case 0
                lblRemarks.Text = "Try Harder"
            Case 1
                lblRemarks.Text = "Study More"
            Case 2
                lblRemarks.Text = "Practice!!!"
            Case 3
                lblRemarks.Text = "Try Answering"
        End Select
    End Sub

    Public Sub negativeRemarks()
        Dim wrong = r.Next(0, 5)
        Select Case wrong
            Case 0
                lblRemarks.Text = "Try Harder"
            Case 1
                lblRemarks.Text = "Study"
            Case 2
                lblRemarks.Text = "Try Again"
            Case 3
                lblRemarks.Text = "Incorrect"
            Case 4
                lblRemarks.Text = "More Practice"
        End Select
    End Sub

    Public Sub PositiveRemarks()
        Dim correct = r.Next(0, 5)
        Select Case correct
            Case 0
                lblRemarks.Text = "Excellent"
            Case 1
                lblRemarks.Text = "Remarkable"
            Case 2
                lblRemarks.Text = "Genius"
            Case 3
                lblRemarks.Text = "Correct"
            Case 4
                lblRemarks.Text = "Brilliant"
        End Select
    End Sub

    Public Sub Generate()
        Dim firstnum = r.Next(10, 20) + 1
        Dim secondnum = r.Next(10) + 1
        Dim Ope = r.Next(0, 4)



        lblFirstGivenNum.Text = firstnum
        lblSecondGivenNum.Text = secondnum

        Select Case Ope
            Case 0
                total = firstnum + secondnum
            Case 1
                total = firstnum - secondnum
            Case 2
                total = firstnum * secondnum
            Case 3
                Divide = firstnum / secondnum
        End Select
        Divide = FormatNumber(Divide, 2)
        lblOperand.Text = RandomOperator(Ope)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtSubmittedNum.Enabled = False
    End Sub

    Private Sub lblRemaining_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblBound.TextChanged, Label4.TextChanged
        If lblBound.Text = 0 Then
            If lblCorrectAnswers.Text > 5 Then
                MsgBox("You Win!!!")
                Timer1.Stop()
                btnNext.Enabled = False
                btnStart.Enabled = True
                btnStart.Enabled = True
                btnSubmit.Enabled = False

            End If
            If lblBound.Text = 0 Then
                If lblCorrectAnswers.Text < 6 Then
                    MsgBox("You Lose!!!")
                    Timer1.Stop()
                    btnNext.Enabled = False
                    btnStart.Enabled = True
                    btnStart.Enabled = True
                    btnSubmit.Enabled = False
                End If
            End If
        End If
    End Sub
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Generate()
        btnSubmit.Enabled = True
        btnSubmit.Enabled = True
        btnStart.Enabled = False
        btnStart.Enabled = False
        btnNext.Enabled = True
        txtSubmittedNum.Enabled = True
        lblMinutes.Text = 1
        lblSeconds.Text = 30
        lblBound.Text = 10
        lblCorrectAnswers.Text = 0
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If lblSeconds.Text > Val(0) Then
            lblSeconds.Text = Val(lblSeconds.Text) - 1
        End If
        If lblMinutes.Text > Val(0) Then
            If lblSeconds.Text = Val(0) Then
                lblMinutes.Text = lblMinutes.Text - 1
                lblSeconds.Text = "59"
            End If
        End If
        If lblMinutes.Text = Val(0) Then
            If lblSeconds.Text = Val(0) Then
                Timer1.Stop()
                btnNext.Enabled = False
                btnStart.Enabled = True
                btnSubmit.Enabled = False
                MsgBox("Times Up!")
            End If
        End If
    End Sub

    Private Sub txtAns_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSubmittedNum.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                         Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 45 Or
                         (e.KeyChar = DecimalSeparator And txtSubmittedNum.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click

        Try
            If txtSubmittedNum.Text = Nothing Then
                MsgBox("ENTER A NUMBER", MsgBoxStyle.Information, vbOK)
            ElseIf txtSubmittedNum.Text = total Or txtSubmittedNum.Text = Divide Then
                lblCorrectAnswers.Text = Val(lblCorrectAnswers.Text) + 1
                lblBound.Text = Val(lblBound.Text) - 1
                Generate()
                PositiveRemarks()
                txtSubmittedNum.Text = ""
            Else
                Generate()
                lblBound.Text = Val(lblBound.Text) - 1
                negativeRemarks()
                txtSubmittedNum.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Generate()
        lblBound.Text = Val(lblBound.Text) - 1
        Nex()
        txtSubmittedNum.Text = ""
    End Sub

   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblFirstGivenNum.Text = 0
        lblSecondGivenNum.Text = 0
        btnSubmit.Enabled = False
        btnNext.Enabled = False
        btnStart.Enabled = True
        lblMinutes.Text = 1
        lblSeconds.Text = 30
        lblBound.Text = 10
        lblCorrectAnswers.Text = 0
        Timer1.Stop()
    End Sub
End Class
