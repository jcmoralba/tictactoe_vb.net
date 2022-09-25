Public Class Form1
    Dim turn As Integer = 1
    Dim win As String
    Dim check As Boolean = False


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call turnPlot(Button1)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub turnPlot(btn As Button)

        If Len(btn.Text) = 0 Then
            If turn Mod 2 = 0 Then
                btn.Text = "O"
                Label1.Text = "Next Turn: Player X"
            Else
                btn.Text = "X"
                Label1.Text = "Next Turn: Player O"

            End If

            turn += 1

            Call checkdraw()
            If check = True Then
                Label1.Text = "--- DRAW --- DRAW --- DRAW ---  DRAW --- "
                finished()

            End If
            Call checkWinner()

        End If
    End Sub
    Private Sub checkWinner()
        Dim b1 As String
        Dim b2 As String
        Dim b3 As String
        Dim b4 As String
        Dim b5 As String
        Dim b6 As String
        Dim b7 As String
        Dim b8 As String
        Dim b9 As String
        Dim line1 As String
        Dim line2 As String
        Dim line3 As String
        Dim line4 As String
        Dim line5 As String
        Dim line6 As String
        Dim line7 As String
        Dim line8 As String

        b1 = Button1.Text
        b2 = Button2.Text
        b3 = Button3.Text
        b4 = Button4.Text
        b5 = Button5.Text
        b6 = Button6.Text
        b7 = Button7.Text
        b8 = Button8.Text
        b9 = Button9.Text


        '   [b1]    [b2]    [b3]
        '   [b4]    [b5]    [b6]
        '   [b7]    [b8]    [b9]



        line1 = b1 + b2 + b3
        line2 = b4 + b5 + b6
        line3 = b7 + b8 + b9
        line4 = b1 + b4 + b7
        line5 = b2 + b5 + b8
        line6 = b3 + b6 + b9
        line7 = b1 + b5 + b9
        line8 = b3 + b5 + b7



        Call lines(line1)
        Call lines(line2)
        Call lines(line3)
        Call lines(line4)
        Call lines(line5)
        Call lines(line6)
        Call lines(line7)
        Call lines(line8)

    End Sub

    Private Sub lines(line As String)

        If line = "XXX" Or line = "OOO" Then
            If line = "XXX" Then
                Label1.Text = "Winner Player X!"
                MsgBox("Winner Player X!")
                check = False
                finished()
            Else
                Label1.Text = "Winner Player O!"
                MsgBox("Winner Player O!")
                check = False
                finished()

            End If

        End If



    End Sub


    Private Sub checkdraw()
        If Button1.Text = String.Empty = False And
           Button2.Text = String.Empty = False And
           Button3.Text = String.Empty = False And
           Button4.Text = String.Empty = False And
           Button5.Text = String.Empty = False And
           Button6.Text = String.Empty = False And
           Button7.Text = String.Empty = False And
           Button8.Text = String.Empty = False And
           Button9.Text = String.Empty = False Then

            check = True

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call turnPlot(Button2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call turnPlot(Button3)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call turnPlot(Button4)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call turnPlot(Button5)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Call turnPlot(Button6)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Call turnPlot(Button7)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Call turnPlot(Button8)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Call turnPlot(Button9)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btnNewGame2.Click
        Controls.Clear()
        InitializeComponent()
        check = False
        turn = 1
    End Sub
    Private Sub finished()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
    End Sub

End Class
