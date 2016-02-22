Public Class Form1



    Private a As Integer
    Private b As Integer
    Private c As Integer
    Private d As Integer
    Private ee As Integer
    Private f As Integer
    Private g As Integer
    Private h As Integer
    Private ii As Integer

    Private aivalue(9) As Integer
    Private airandom As New Random
    Private airandval As Integer

    Private player1score As Integer
    Private player2score As Integer

    Private ai As Boolean
    Private playermatch As Boolean
    Private player1 As Boolean
    Private player2 As Boolean
    Private game As Boolean

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If game = True Then



            If player2 = False Then

                If player1 = True Then
                    If a = 0 Then
                        Button1.Text = "O"
                        a = 1
                        If a = 1 And ee = 1 And ii = 1 Then

                            MsgBox("Player 1 Wins!")
                            player1score = player1score + 1
                            Label4.Text = player1score
                            game = False
                            player1 = False
                            player2 = False
                        ElseIf a = 1 And d = 1 And g = 1 Then
                            MsgBox("Player 1 Wins!")
                            player1score = player1score + 1
                            Label4.Text = player1score
                            game = False
                            player1 = False
                            player2 = False
                        ElseIf a = 1 And b = 1 And c = 1 Then
                            MsgBox("Player 1 Wins!")
                            player1score = player1score + 1
                            Label4.Text = player1score
                            game = False
                            player1 = False
                            player2 = False
                        ElseIf a <> 0 And b <> 0 And c <> 0 And d <> 0 And ee <> 0 And f <> 0 And g <> 0 And h <> 0 And ii <> 0 Then
                            MsgBox("Tie!")
                            game = False
                            player1 = False
                            player2 = False
                        Else
                            player1 = False
                            player2 = True
                            Label6.Text = "Turn: Player 2"
                            If playermatch = False Then
                                If ai = True Then

                                    aicontrol()
                                Else
                                    player1 = False
                                    player2 = True
                                    Label6.Text = "Turn: Player 2"
                                End If
                            End If
                        End If

                    End If

                End If
            End If
        End If
        If player1 = False Then
            If player2 = True Then
                If a = 0 Then
                    Button1.Text = "X"
                    a = 2
                    If a = 2 And ee = 2 And ii = 2 Then
                        MsgBox("Player 2 Wins!")
                        player2score = player2score + 1
                        Label5.Text = player2score
                        game = False
                        player1 = False
                        player2 = False
                    ElseIf a = 2 And d = 2 And g = 2 Then
                        MsgBox("Player 2 Wins!")
                        player2score = player2score + 1
                        Label5.Text = player2score
                        game = False
                        player1 = False
                        player2 = False
                    ElseIf a = 2 And b = 2 And c = 2 Then
                        MsgBox("Player 2 Wins!")
                        player2score = player2score + 1
                        Label5.Text = player2score
                        game = False
                        player1 = False
                        player2 = False
                    ElseIf a <> 0 And b <> 0 And c <> 0 And d <> 0 And ee <> 0 And f <> 0 And g <> 0 And h <> 0 And ii <> 0 Then
                        MsgBox("Tie!")
                        game = False
                        player1 = False
                        player2 = False
                    Else
                        player1 = True
                        player2 = False
                        Label6.Text = "Turn: Player 1"
                    End If
                End If
            End If

        End If




    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If game = True Then

            If player2 = False Then

                If player1 = True Then
                    If b = 0 Then
                        Button2.Text = "O"
                        b = 1
                        If b = 1 And ee = 1 And h = 1 Then
                            MsgBox("Player 1 Wins!")
                            player1score = player1score + 1
                            Label4.Text = player1score
                            game = False
                            player1 = False
                            player2 = False
                        ElseIf b = 1 And a = 1 And c = 1 Then

                            MsgBox("Player 1 Wins!")
                            player1score = player1score + 1
                            Label4.Text = player1score
                            game = False
                            player1 = False
                            player2 = False

                        ElseIf a <> 0 And b <> 0 And c <> 0 And d <> 0 And ee <> 0 And f <> 0 And g <> 0 And h <> 0 And ii <> 0 Then
                            MsgBox("Tie!")
                            game = False
                            player1 = False
                            player2 = False
                        Else
                            player1 = False
                            player2 = True
                            Label6.Text = "Turn: Player 2"
                            If playermatch = False Then
                                If ai = True Then

                                    aicontrol()
                                Else
                                    player1 = False
                                    player2 = True
                                    Label6.Text = "Turn: Player 2"
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            If player1 = False Then
                If player2 = True Then
                    If b = 0 Then
                        Button2.Text = "X"
                        b = 2
                        If b = 2 And ee = 2 And h = 2 Then
                            MsgBox("Player 2 Wins!")
                            player2score = player2score + 1
                            Label5.Text = player2score
                            game = False
                            player1 = False
                            player2 = False
                        ElseIf b = 2 And a = 2 And c = 2 Then

                            MsgBox("Player 2 Wins!")
                            player2score = player2score + 1
                            Label5.Text = player2score
                            game = False
                            player1 = False
                            player2 = False

                        ElseIf a <> 0 And b <> 0 And c <> 0 And d <> 0 And ee <> 0 And f <> 0 And g <> 0 And h <> 0 And ii <> 0 Then
                            MsgBox("Tie!")
                            game = False
                            player1 = False
                            player2 = False
                        Else


                            player1 = True
                            player2 = False
                            Label6.Text = "Turn: Player 1"
                        End If
                    End If
                End If
            End If
  
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If game = True Then

            If player2 = False Then

                If player1 = True Then
                    If c = 0 Then
                        Button3.Text = "O"
                        c = 1
                        If a = 1 And b = 1 And c = 1 Then
                            MsgBox("Player 1 Wins!")
                            player1score = player1score + 1
                            Label4.Text = player1score
                            game = False
                            player1 = False
                            player2 = False
                        ElseIf c = 1 And f = 1 And ii = 1 Then

                            MsgBox("Player 1 Wins!")
                            player1score = player1score + 1
                            Label4.Text = player1score
                            game = False
                            player1 = False
                            player2 = False

                        ElseIf c = 1 And ee = 1 And g = 1 Then

                            MsgBox("Player 1 Wins!")
                            player1score = player1score + 1
                            Label4.Text = player1score
                            game = False
                            player1 = False
                            player2 = False

                           
                        ElseIf a <> 0 And b <> 0 And c <> 0 And d <> 0 And ee <> 0 And f <> 0 And g <> 0 And h <> 0 And ii <> 0 Then
                            MsgBox("Tie!")
                            game = False
                            player1 = False
                            player2 = False
                        Else
                            player1 = False
                            player2 = True
                            Label6.Text = "Turn: Player 2"
                            If playermatch = False Then
                                If ai = True Then

                                    aicontrol()
                                Else
                                    player1 = False
                                    player2 = True
                                    Label6.Text = "Turn: Player 2"
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            If player1 = False Then
                If player2 = True Then
                    If c = 0 Then
                        Button3.Text = "X"
                        c = 2
                        If a = 2 And b = 2 And c = 2 Then
                            MsgBox("Player 2 Wins!")
                            player2score = player2score + 1
                            Label5.Text = player2score
                            game = False
                            player1 = False
                            player2 = False
                        ElseIf c = 2 And f = 2 And ii = 2 Then

                            MsgBox("Player 2 Wins!")
                            player2score = player2score + 1
                            Label5.Text = player2score
                            game = False
                            player1 = False
                            player2 = False

                        ElseIf c = 2 And ee = 2 And g = 2 Then

                            MsgBox("Player 2 Wins!")
                            player2score = player2score + 1
                            Label5.Text = player2score
                            game = False
                            player1 = False
                            player2 = False
                        ElseIf a <> 0 And b <> 0 And c <> 0 And d <> 0 And ee <> 0 And f <> 0 And g <> 0 And h <> 0 And ii <> 0 Then
                            MsgBox("Tie!")
                            game = False
                            player1 = False
                            player2 = False
                        Else


                            player1 = True
                            player2 = False
                            Label6.Text = "Turn: Player 1"
                        End If
                    End If
                End If
            End If
    
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If game = True Then

            If player2 = False Then

                If player1 = True Then
                    If d = 0 Then
                        Button4.Text = "O"
                        d = 1
                        If d = 1 And a = 1 And g = 1 Then
                            MsgBox("Player 1 Wins!")
                            player1score = player1score + 1
                            Label4.Text = player1score
                            game = False
                            player1 = False
                            player2 = False
                        ElseIf d = 1 And ee = 1 And f = 1 Then
                            MsgBox("Player 1 Wins!")
                            player1score = player1score + 1
                            Label4.Text = player1score
                            game = False
                            player1 = False
                            player2 = False
                        ElseIf a <> 0 And b <> 0 And c <> 0 And d <> 0 And ee <> 0 And f <> 0 And g <> 0 And h <> 0 And ii <> 0 Then
                            MsgBox("Tie!")
                            game = False
                            player1 = False
                            player2 = False
                        Else
                            player1 = False
                            player2 = True
                            Label6.Text = "Turn: Player 2"
                            If playermatch = False Then
                                If ai = True Then

                                    aicontrol()
                                Else
                                    player1 = False
                                    player2 = True
                                    Label6.Text = "Turn: Player 2"
                                End If
                            End If
                        End If

                    End If
                End If
            End If
            If player1 = False Then
                If player2 = True Then
                    If d = 0 Then
                        Button4.Text = "X"
                        d = 2

                        If d = 2 And a = 2 And g = 2 Then
                            MsgBox("Player 2 Wins!")
                            player2score = player2score + 1
                            Label5.Text = player2score
                            game = False
                            player1 = False
                            player2 = False
                        ElseIf d = 2 And ee = 2 And f = 2 Then
                            MsgBox("Player 2 Wins!")
                            player2score = player2score + 1
                            Label5.Text = player2score
                            game = False
                            player1 = False
                            player2 = False
                        ElseIf a <> 0 And b <> 0 And c <> 0 And d <> 0 And ee <> 0 And f <> 0 And g <> 0 And h <> 0 And ii <> 0 Then
                            MsgBox("Tie!")
                            game = False
                            player1 = False
                            player2 = False
                        Else
                            player1 = True
                            player2 = False
                            Label6.Text = "Turn: Player 2"
                        End If
                    End If
                End If
            End If
   
        End If

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If game = True Then

            If player2 = False Then

                If player1 = True Then
                    If ee = 0 Then
                        Button5.Text = "O"
                        ee = 1
                        If a = 1 And ee = 1 And ii = 1 Then
                            MsgBox("Player 1 Wins!")
                            player1score = player1score + 1
                            Label4.Text = player1score
                            game = False
                            player1 = False
                            player2 = False
                        ElseIf d = 1 And ee = 1 And f = 1 Then
                            MsgBox("Player 1 Wins!")
                            player1score = player1score + 1
                            Label4.Text = player1score
                            game = False
                            player1 = False
                            player2 = False
                        ElseIf b = 1 And ee = 1 And h = 1 Then
                            MsgBox("Player 1 Wins!")
                            player1score = player1score + 1
                            Label4.Text = player1score
                            game = False
                            player1 = False
                            player2 = False
                        ElseIf g = 1 And ee = 1 And c = 1 Then
                            MsgBox("Player 1 Wins!")
                            player1score = player1score + 1
                            Label4.Text = player1score
                            game = False
                            player1 = False
                            player2 = False
                        ElseIf a <> 0 And b <> 0 And c <> 0 And d <> 0 And ee <> 0 And f <> 0 And g <> 0 And h <> 0 And ii <> 0 Then
                            MsgBox("Tie!")
                            game = False
                            player1 = False
                            player2 = False
                        Else
                            player1 = False
                            player2 = True
                            Label6.Text = "Turn: Player 2"
                            If playermatch = False Then
                                If ai = True Then

                                    aicontrol()
                                Else
                                    player1 = False
                                    player2 = True
                                    Label6.Text = "Turn: Player 2"
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If player1 = False Then
            If player2 = True Then
                If ee = 0 Then
                    Button5.Text = "X"
                    ee = 2
                    If a = 2 And ee = 2 And ii = 2 Then
                        MsgBox("Player 2 Wins!")
                        player2score = player2score + 1
                        Label5.Text = player2score
                        game = False
                        player1 = False
                        player2 = False
                    ElseIf d = 2 And ee = 2 And f = 2 Then
                        MsgBox("Player 2 Wins!")
                        player2score = player2score + 1
                        Label5.Text = player2score
                        game = False
                        player1 = False
                        player2 = False
                    ElseIf b = 2 And ee = 2 And h = 2 Then
                        MsgBox("Player 2 Wins!")
                        player2score = player2score + 1
                        Label5.Text = player2score
                        game = False
                        player1 = False
                        player2 = False
                    ElseIf g = 2 And ee = 2 And c = 2 Then
                        MsgBox("Player 2 Wins!")
                        player2score = player2score + 1
                        Label5.Text = player2score
                        game = False
                        player1 = False
                        player2 = False
                    ElseIf a <> 0 And b <> 0 And c <> 0 And d <> 0 And ee <> 0 And f <> 0 And g <> 0 And h <> 0 And ii <> 0 Then
                        MsgBox("Tie!")
                        game = False
                        player1 = False
                        player2 = False
                    Else
                        player1 = True
                        player2 = False
                        Label6.Text = "Turn: Player 1"
                    End If
                End If
            End If
      
        End If

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If game = True Then

            If player2 = False Then

                If player1 = True Then
                    If f = 0 Then
                        Button6.Text = "O"
                        f = 1

                        If f = 1 And c = 1 And ii = 1 Then
                            MsgBox("Player 1 Wins!")
                            player1score = player1score + 1
                            Label4.Text = player1score
                            game = False
                            player1 = False
                            player2 = False
                        ElseIf d = 1 And ee = 1 And f = 1 Then
                            MsgBox("Player 1 Wins!")
                            player1score = player1score + 1
                            Label4.Text = player1score
                            game = False
                            player1 = False
                            player2 = False
                        ElseIf a <> 0 And b <> 0 And c <> 0 And d <> 0 And ee <> 0 And f <> 0 And g <> 0 And h <> 0 And ii <> 0 Then
                            MsgBox("Tie!")
                            game = False
                            player1 = False
                            player2 = False
                        Else
                            player1 = False
                            player2 = True
                            Label6.Text = "Turn: Player 2"
                            If playermatch = False Then
                                If ai = True Then

                                    aicontrol()
                                Else
                                    player1 = False
                                    player2 = True
                                    Label6.Text = "Turn: Player 2"
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If player1 = False Then
            If player2 = True Then
                If f = 0 Then
                    Button6.Text = "X"
                    f = 2
                    If f = 2 And c = 2 And ii = 2 Then
                        MsgBox("Player 2 Wins!")
                        player2score = player2score + 1
                        Label5.Text = player2score
                        game = False
                        player1 = False
                        player2 = False
                    ElseIf d = 2 And ee = 2 And f = 2 Then
                        MsgBox("Player 2 Wins!")
                        player2score = player2score + 1
                        Label5.Text = player2score
                        game = False
                        player1 = False
                        player2 = False
                    ElseIf a <> 0 And b <> 0 And c <> 0 And d <> 0 And ee <> 0 And f <> 0 And g <> 0 And h <> 0 And ii <> 0 Then
                        MsgBox("Tie!")
                        game = False
                        player1 = False
                        player2 = False
                    Else
                        player1 = True
                        player2 = False
                        Label6.Text = "Turn: Player 1"
                    End If
                End If
            End If
     
        End If

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If game = True Then

            If player2 = False Then

                If player1 = True Then
                    If g = 0 Then
                        Button7.Text = "O"
                        g = 1
                        If g = 1 And ee = 1 And c = 1 Then
                            MsgBox("Player 1 Wins!")
                            player1score = player1score + 1
                            Label4.Text = player1score
                            game = False
                            player1 = False
                            player2 = False
                        ElseIf g = 1 And d = 1 And a = 1 Then
                            MsgBox("Player 1 Wins!")
                            player1score = player1score + 1
                            Label4.Text = player1score
                            game = False
                            player1 = False
                            player2 = False
                        ElseIf g = 1 And h = 1 And ii = 1 Then
                            MsgBox("Player 1 Wins!")
                            player1score = player1score + 1
                            Label4.Text = player1score
                            game = False
                            player1 = False
                            player2 = False
                        ElseIf a <> 0 And b <> 0 And c <> 0 And d <> 0 And ee <> 0 And f <> 0 And g <> 0 And h <> 0 And ii <> 0 Then
                            MsgBox("Tie!")
                            game = False
                            player1 = False
                            player2 = False
                        Else
                            player1 = False
                            player2 = True
                            Label6.Text = "Turn: Player 2"
                            If playermatch = False Then
                                If ai = True Then

                                    aicontrol()
                                Else
                                    player1 = False
                                    player2 = True
                                    Label6.Text = "Turn: Player 2"
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If player1 = False Then
            If player2 = True Then
                If g = 0 Then
                    Button7.Text = "X"
                    g = 2
                    If g = 2 And ee = 2 And c = 2 Then
                        MsgBox("Player 2 Wins!")
                        player2score = player2score + 1
                        Label5.Text = player2score
                        game = False
                        player1 = False
                        player2 = False
                    ElseIf g = 2 And d = 2 And a = 2 Then
                        MsgBox("Player 2 Wins!")
                        player2score = player2score + 1
                        Label5.Text = player2score
                        game = False
                        player1 = False
                        player2 = False
                    ElseIf g = 2 And h = 2 And ii = 2 Then
                        MsgBox("Player 2 Wins!")
                        player2score = player2score + 1
                        Label5.Text = player2score
                        game = False
                        player1 = False
                        player2 = False
                    ElseIf a <> 0 And b <> 0 And c <> 0 And d <> 0 And ee <> 0 And f <> 0 And g <> 0 And h <> 0 And ii <> 0 Then
                        MsgBox("Tie!")
                        game = False
                        player1 = False
                        player2 = False
                    Else
                        player1 = True
                        player2 = False
                        Label6.Text = "Turn: Player 1"
                    End If
                End If
            End If
     
        End If

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If game = True Then

            If player2 = False Then

                If player1 = True Then
                    If h = 0 Then
                        Button8.Text = "O"
                        h = 1

                        If ii = 1 And h = 1 And g = 1 Then
                            MsgBox("Player 1 Wins!")
                            player1score = player1score + 1
                            Label4.Text = player1score
                            game = False
                            player1 = False
                            player2 = False
                        ElseIf ee = 1 And b = 1 And h = 1 Then
                            MsgBox("Player 1 Wins!")
                            player1score = player1score + 1
                            Label4.Text = player1score
                            game = False
                            player1 = False
                            player2 = False
                        ElseIf a <> 0 And b <> 0 And c <> 0 And d <> 0 And ee <> 0 And f <> 0 And g <> 0 And h <> 0 And ii <> 0 Then
                            MsgBox("Tie!")
                            game = False
                            player1 = False
                            player2 = False
                        Else
                            player1 = False
                            player2 = True
                            Label6.Text = "Turn: Player 2"
                            If playermatch = False Then
                                If ai = True Then

                                    aicontrol()
                                Else
                                    player1 = False
                                    player2 = True
                                    Label6.Text = "Turn: Player 2"
                                End If
                            End If
                        End If
                    End If

                End If
            End If
        End If
        If player1 = False Then
            If player2 = True Then
                If h = 0 Then
                    Button8.Text = "X"
                    h = 2

                    If ii = 1 And h = 1 And g = 1 Then
                        MsgBox("Player 2 Wins!")
                        player2score = player2score + 1
                        Label5.Text = player2score
                        game = False
                        player1 = False
                        player2 = False
                    ElseIf ee = 1 And b = 1 And h = 1 Then
                        MsgBox("Player 2 Wins!")
                        player2score = player2score + 1
                        Label5.Text = player2score
                        game = False
                        player1 = False
                        player2 = False
                    ElseIf a <> 0 And b <> 0 And c <> 0 And d <> 0 And ee <> 0 And f <> 0 And g <> 0 And h <> 0 And ii <> 0 Then
                        MsgBox("Tie!")
                        game = False
                        player1 = False
                        player2 = False
                    Else

                        player1 = True
                        player2 = False
                        Label6.Text = "Turn: Player 1"
                    End If
                End If
            End If
      
        End If

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If game = True Then

            If player2 = False Then

                If player1 = True Then
                    If ii = 0 Then
                        Button9.Text = "O"
                        ii = 1
                        If a = 1 And ee = 1 And ii = 1 Then
                            MsgBox("Player 1 Wins!")
                            player1score = player1score + 1
                            Label4.Text = player1score
                            game = False
                            player1 = False
                            player2 = False
                        ElseIf ii = 1 And c = 1 And f = 1 Then
                            MsgBox("Player 1 Wins!")
                            player1score = player1score + 1
                            Label4.Text = player1score
                            game = False
                            player1 = False
                            player2 = False
                        ElseIf ii = 1 And h = 1 And g = 1 Then
                            MsgBox("Player 1 Wins!")
                            player1score = player1score + 1
                            Label4.Text = player1score
                            game = False
                            player1 = False
                            player2 = False

                        ElseIf a <> 0 And b <> 0 And c <> 0 And d <> 0 And ee <> 0 And f <> 0 And g <> 0 And h <> 0 And ii <> 0 Then
                            MsgBox("Tie!")
                            game = False
                            player1 = False
                            player2 = False
                        Else
                            player1 = False
                            player2 = True
                            Label6.Text = "Turn: Player 2"
                            If playermatch = False Then
                                If ai = True Then

                                    aicontrol()
                                Else
                                    player1 = False
                                    player2 = True
                                    Label6.Text = "Turn: Player 2"
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If player1 = False Then
            If player2 = True Then
                If ii = 0 Then
                    Button9.Text = "X"
                    ii = 2
                    If a = 1 And ee = 1 And ii = 1 Then
                        MsgBox("Player 2 Wins!")
                        player2score = player2score + 1
                        Label5.Text = player2score
                        game = False
                        player1 = False
                        player2 = False
                    ElseIf ii = 1 And c = 1 And f = 1 Then
                        MsgBox("Player 2 Wins!")
                        player2score = player2score + 1
                        Label5.Text = player2score
                        game = False
                        player1 = False
                        player2 = False
                    ElseIf ii = 1 And h = 1 And g = 1 Then
                        MsgBox("Player 2 Wins!")
                        player2score = player2score + 1
                        Label5.Text = player2score
                        game = False
                        player1 = False
                        player2 = False

                    ElseIf a <> 0 And b <> 0 And c <> 0 And d <> 0 And ee <> 0 And f <> 0 And g <> 0 And h <> 0 And ii <> 0 Then
                        MsgBox("Tie!")
                        game = False
                        player1 = False
                        player2 = False
                    Else
                        player1 = True
                        player2 = False
                        Label6.Text = "Turn: Player 1"
                    End If
                End If
            End If
       
        End If

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If game = False Then
            If player1 = False Then
                If player2 = False Then
                    newgame()
                End If
            End If
        End If

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        resetall()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
    Private Sub newgame()
        If game = False Then
            If player1 = False Then
                If player2 = False Then
                    game = True
                    player1 = True
                    Button1.Text = String.Empty
                    Button2.Text = String.Empty
                    Button3.Text = String.Empty
                    Button4.Text = String.Empty
                    Button5.Text = String.Empty
                    Button6.Text = String.Empty
                    Button7.Text = String.Empty
                    Button8.Text = String.Empty
                    Button9.Text = String.Empty

                    a = 0
                    b = 0
                    c = 0
                    d = 0
                    ee = 0
                    f = 0
                    g = 0
                    h = 0
                    ii = 0

                    Label6.Text = "Turn: Player 1"
                    Label7.Text = ""
                End If
            End If


        End If
    End Sub
    Private Sub aicheckwin()
        If game = True Then
            If playermatch = False Then
                If ai = True Then
                    If a = 2 And b = 2 And c = 2 Then
                        win1()
                    ElseIf d = 2 And ee = 2 And f = 2 Then
                        win2()
                    ElseIf g = 2 And h = 2 And ii = 2 Then
                        win3()
                    ElseIf a = 2 And d = 2 And g = 2 Then
                        win4()
                    ElseIf b = 2 And ee = 2 And h = 2 Then
                        win5()
                    ElseIf c = 2 And f = 2 And ii = 2 Then
                        win6()
                    ElseIf a = 2 And ee = 2 And ii = 2 Then
                        win7()
                    ElseIf g = 2 And ee = 2 And c = 2 Then
                        win8()
                    Else
                        player1 = True
                        player2 = False
                        Label6.Text = "Turn: Player 1"
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub aicontrol()
        If game = True Then
            If playermatch = False Then
                If player1 = False Then
                    If player2 = True Then
                        If ai = True Then
                            aivalue(1) = 1
                            aivalue(2) = 2
                            aivalue(3) = 3
                            aivalue(4) = 4
                            aivalue(5) = 5
                            aivalue(6) = 6
                            aivalue(7) = 7
                            aivalue(8) = 8
                            aivalue(9) = 9

                            airandval = airandom.Next(1, aivalue.Length)

                            If a = 2 And b = 2 And c = 2 Then
                                win1()
                            ElseIf d = 2 And ee = 2 And f = 2 Then
                                win2()
                            ElseIf g = 2 And h = 2 And ii = 2 Then
                                win3()
                            ElseIf a = 2 And d = 2 And g = 2 Then
                                win4()
                            ElseIf b = 2 And ee = 2 And h = 2 Then
                                win5()
                            ElseIf c = 2 And f = 2 And ii = 2 Then
                                win6()
                            ElseIf a = 2 And ee = 2 And ii = 2 Then
                                win7()
                            ElseIf g = 2 And ee = 2 And c = 2 Then
                                win8()
                            ElseIf a = 1 And b = 1 And c = 0 Then
                                csq()
                                aicheckwin()
                            ElseIf d = 1 And ee = 1 And f = 0 Then
                                fsq()
                                aicheckwin()
                            ElseIf g = 1 And h = 1 And ii = 0 Then
                                iisq()
                                aicheckwin()
                            ElseIf c = 1 And b = 1 And a = 0 Then
                                asq()
                                aicheckwin()
                            ElseIf f = 1 And ee = 1 And d = 0 Then
                                dsq()
                                aicheckwin()
			    Elseif c = 1 and f = 0 and ii = 1 Then
				fsq()
				aicheckwin()
                            ElseIf ii = 1 And h = 1 And g = 0 Then
                                gsq()
                                aicheckwin()
                            ElseIf a = 1 And d = 1 And g = 0 Then
                                gsq()
                                aicheckwin()
                            ElseIf b = 1 And ee = 1 And h = 0 Then
                                hsq()
                                aicheckwin()
                            ElseIf c = 1 And f = 1 And ii = 0 Then
                                iisq()
                                aicheckwin()
                            ElseIf g = 1 And d = 1 And a = 0 Then
                                asq()
                                aicheckwin()
                            ElseIf h = 1 And ee = 1 And b = 0 Then
                                bsq()
                                aicheckwin()
                            ElseIf ii = 1 And f = 1 And c = 0 Then
                                csq()
                                aicheckwin()
                            ElseIf a = 1 And b = 0 And c = 1 Then
                                bsq()
                                aicheckwin()
                            ElseIf d = 1 And ee = 0 And f = 1 Then
                                eesq()
                                aicheckwin()
                            ElseIf g = 1 And h = 0 And ii = 1 Then
                                hsq()
                                aicheckwin()
                            ElseIf a = 1 And ee = 1 And ii = 0 Then
                                iisq()
                                aicheckwin()
                            ElseIf ii = 1 And ee = 1 And a = 0 Then
                                asq()
                                aicheckwin()
                            ElseIf c = 1 And ee = 1 And g = 0 Then
                                gsq()
                                aicheckwin()
                            ElseIf g = 1 And ee = 1 And c = 0 Then
                                csq()
                                aicheckwin()
                            ElseIf b = 1 And ee = 0 And h = 1 Then
                                eesq()
                                aicheckwin()
                            ElseIf a = 2 And c = 2 And b = 0 Then
                                bsq()
                                aicheckwin()
                            ElseIf a = 2 And d = 0 And g = 2 Then
                                dsq()
                                aicheckwin()
                            ElseIf a = 2 And ii = 2 And ee = 0 Then
                                eesq()
                                aicheckwin()
                            ElseIf b = 2 And h = 2 And ee = 0 Then
                                eesq()
                                aicheckwin()
                            ElseIf c = 2 And ii = 2 And f = 0 Then
                                iisq()
                                aicheckwin()
                            ElseIf c = 2 And g = 2 And ee = 0 Then
                                eesq()
                                aicheckwin()
                            ElseIf c = 2 And a = 2 And b = 0 Then
                                bsq()
                                aicheckwin()
                            ElseIf d = 2 And f = 2 And ee = 0 Then
                                eesq()
                                aicheckwin()
                            ElseIf f = 2 And d = 2 And ee = 0 Then
                                eesq()
                                aicheckwin()
                            ElseIf g = 2 And ii = 2 And h = 0 Then
                                hsq()
                                aicheckwin()
                            ElseIf g = 2 And c = 2 And ee = 0 Then
                                eesq()
                                aicheckwin()
                            ElseIf g = 2 And a = 2 And d = 0 Then
                                dsq()
                                aicheckwin()
                            ElseIf h = 2 And b = 2 And ee = 0 Then
                                eesq()
                                aicheckwin()
                            ElseIf ii = 2 And a = 2 And ee = 0 Then
                                eesq()
                                aicheckwin()
                            ElseIf ii = 2 And c = 2 And f = 0 Then
                                fsq()
                                aicheckwin()
                            ElseIf ii = 2 And g = 2 And h = 0 Then
                                hsq()
                                aicheckwin()
                            ElseIf a = 0 Or b = 0 Or c = 0 Or d = 0 Or ee = 0 Or f = 0 Or g = 0 Or h = 0 Or ii = 0 Then
                                If airandval = 1 Then
                                    If a = 0 Then
                                        asq()
                                        aicheckwin()
                                    Else
                                        aicontrol()
                                    End If
                                ElseIf airandval = 2 Then
                                    If b = 0 Then
                                        bsq()
                                        aicheckwin()
                                    Else
                                        aicontrol()
                                    End If
                                ElseIf airandval = 3 Then
                                    If c = 0 Then
                                        csq()
                                        aicheckwin()
                                    Else
                                        aicontrol()
                                    End If
                                ElseIf airandval = 4 Then
                                    If d = 0 Then
                                        dsq()
                                        aicheckwin()
                                    Else
                                        aicontrol()
                                    End If
                                ElseIf airandval = 5 Then
                                    If ee = 0 Then
                                        eesq()
                                        aicheckwin()
                                    Else
                                        aicontrol()
                                    End If
                                ElseIf airandval = 6 Then
                                    If f = 0 Then
                                        fsq()
                                        aicheckwin()
                                    Else
                                        aicontrol()
                                    End If
                                ElseIf airandval = 7 Then
                                    If g = 0 Then
                                        gsq()
                                        aicheckwin()
                                    Else
                                        aicontrol()
                                    End If
                                ElseIf airandval = 8 Then
                                    If h = 0 Then
                                        hsq()
                                        aicheckwin()
                                    Else
                                        aicontrol()
                                    End If
                                ElseIf airandval = 9 Then
                                    If ii = 0 Then
                                        iisq()
                                        aicheckwin()
                                    Else
                                        aicontrol()
                                    End If
                                Else
                                    aicontrol()
                                End If
                            ElseIf a = 0 Then
                                asq()
                                aicheckwin()
                            ElseIf b = 0 Then
                                bsq()
                                aicheckwin()
                            ElseIf c = 0 Then
                                csq()
                                aicheckwin()
                            ElseIf d = 0 Then
                                dsq()
                                aicheckwin()
                            ElseIf ee = 0 Then
                                eesq()
                                aicheckwin()
                            ElseIf f = 0 Then
                                fsq()
                                aicheckwin()
                            ElseIf g = 0 Then
                                gsq()
                                aicheckwin()
                            ElseIf h = 0 Then
                                hsq()
                                aicheckwin()
                            ElseIf ii = 0 Then
                                iisq()
                                aicheckwin()

                            End If
                        End If
                    End If
                    End If
                End If
        End If
        airandval = 0
    End Sub

    Private Sub aiwin()
        MsgBox("Player 2 Wins!")
        player2score = player2score + 1
        Label5.Text = player2score
        game = False
        player1 = False
        player2 = False
    End Sub

    Private Sub asq()
        If game = True Then
            If player1 = False Then
                If player2 = True Then
                    If ai = True Then
                        If a = 0 Then
                            a = 2
                            Button1.Text = "X"
                            aicheckwin()
                            If a = 2 And b = 2 And c = 2 Then
                                win1()
                            ElseIf a = 2 And d = 2 And g = 2 Then
                                win4()
                            ElseIf a = 2 And ee = 2 And ii = 2 Then
                                win7()
                            ElseIf a <> 0 And b <> 0 And c <> 0 And d <> 0 And ee <> 0 And f <> 0 And g <> 0 And h <> 0 And ii <> 0 Then
                                MsgBox("Tie!")
                                game = False
                                player1 = False
                                player2 = False
                            Else
                                player1 = True
                                player2 = False
                                Label6.Text = "Turn: Player 1"
                            End If
                        End If
                        End If
                    End If
                End If
            End If
    End Sub
    Private Sub bsq()
        If game = True Then
            If player1 = False Then
                If player2 = True Then
                    If ai = True Then
                        If b = 0 Then
                            b = 2
                            Button2.Text = "X"
                            aicheckwin()
                            If a = 2 And b = 2 And c = 2 Then
                                win1()
                            ElseIf b = 2 And ee = 2 And h = 2 Then
                                win5()
                            ElseIf a <> 0 And b <> 0 And c <> 0 And d <> 0 And ee <> 0 And f <> 0 And g <> 0 And h <> 0 And ii <> 0 Then
                                MsgBox("Tie!")
                                game = False
                                player1 = False
                                player2 = False
                            Else

                                player1 = True
                                player2 = False
                                Label6.Text = "Turn: Player 1"
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub csq()
        If game = True Then
            If player1 = False Then
                If player2 = True Then
                    If ai = True Then
                        If c = 0 Then
                            c = 2
                            Button3.Text = "X"
                            aicheckwin()
                            If a = 2 And b = 2 And c = 2 Then
                                win1()
                            ElseIf c = 2 And f = 2 And ii = 2 Then
                                win6()
                            ElseIf c = 2 And ee = 2 And g = 2 Then
                                win8()
                            ElseIf a <> 0 And b <> 0 And c <> 0 And d <> 0 And ee <> 0 And f <> 0 And g <> 0 And h <> 0 And ii <> 0 Then
                                MsgBox("Tie!")
                                game = False
                                player1 = False
                                player2 = False
                            Else

                                player1 = True
                                player2 = False
                                Label6.Text = "Turn: Player 1"
                            End If

                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub dsq()
        If game = True Then
            If player1 = False Then
                If player2 = True Then
                    If ai = True Then
                        If d = 0 Then
                            d = 2
                            Button4.Text = "X"
                            aicheckwin()
                            If d = 2 And ee = 2 And f = 2 Then
                                win2()
                            ElseIf a = 2 And d = 2 And g = 2 Then
                                win4()
                            ElseIf a <> 0 And b <> 0 And c <> 0 And d <> 0 And ee <> 0 And f <> 0 And g <> 0 And h <> 0 And ii <> 0 Then
                                MsgBox("Tie!")
                                game = False
                                player1 = False
                                player2 = False
                            Else

                                player1 = True
                                player2 = False
                                Label6.Text = "Turn: Player 1"
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub eesq()
        If game = True Then
            If player1 = False Then
                If player2 = True Then
                    If ai = True Then
                        If ee = 0 Then
                            ee = 2
                            Button5.Text = "X"
                            aicheckwin()
                            If a = 2 And ee = 2 And ii = 2 Then
                                win7()
                            ElseIf d = 2 And ee = 2 And f = 2 Then
                                win2()
                            ElseIf g = 2 And ee = 2 And c = 2 Then
                                win8()
                            ElseIf b = 2 And ee = 2 And h = 2 Then
                                win5()
                            ElseIf a <> 0 And b <> 0 And c <> 0 And d <> 0 And ee <> 0 And f <> 0 And g <> 0 And h <> 0 And ii <> 0 Then
                                MsgBox("Tie!")
                                game = False
                                player1 = False
                                player2 = False
                            Else
                                player1 = True
                                player2 = False
                                Label6.Text = "Turn: Player 1"
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub fsq()
        If game = True Then
            If player1 = False Then
                If player2 = True Then
                    If ai = True Then
                        If f = 0 Then
                            f = 2
                            Button6.Text = "X"
                            aicheckwin()
                            If c = 2 And f = 2 And ii = 2 Then
                                win6()
                            ElseIf d = 2 And ee = 2 And f = 2 Then
                                win2()
                            ElseIf a <> 0 And b <> 0 And c <> 0 And d <> 0 And ee <> 0 And f <> 0 And g <> 0 And h <> 0 And ii <> 0 Then
                                MsgBox("Tie!")
                                game = False
                                player1 = False
                                player2 = False
                            Else
                                player1 = True
                                player2 = False
                                Label6.Text = "Turn: Player 1"
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub gsq()
        If game = True Then
            If player1 = False Then
                If player2 = True Then
                    If ai = True Then
                        If g = 0 Then
                            g = 2
                            Button7.Text = "X"
                            aicheckwin()
                            If g = 2 And h = 2 And ii = 2 Then
                                win3()
                            ElseIf g = 2 And d = 2 And a = 2 Then
                                win4()
                            ElseIf g = 2 And ee = 2 And c = 2 Then
                                win8()
                            ElseIf a <> 0 And b <> 0 And c <> 0 And d <> 0 And ee <> 0 And f <> 0 And g <> 0 And h <> 0 And ii <> 0 Then
                                MsgBox("Tie!")
                                game = False
                                player1 = False
                                player2 = False
                            Else
                                player1 = True
                                player2 = False
                                Label6.Text = "Turn: Player 1"
                            End If

                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub hsq()
        If game = True Then
            If player1 = False Then
                If player2 = True Then
                    If ai = True Then
                        If h = 0 Then
                            h = 2
                            Button8.Text = "X"
                            aicheckwin()
                            If h = 2 And ee = 2 And b = 2 Then
                                win5()
                            ElseIf g = 2 And h = 2 And ii = 2 Then
                                win3()
                            ElseIf a <> 0 And b <> 0 And c <> 0 And d <> 0 And ee <> 0 And f <> 0 And g <> 0 And h <> 0 And ii <> 0 Then
                                MsgBox("Tie!")
                                game = False
                                player1 = False
                                player2 = False
                            Else
                                player1 = True
                                player2 = False
                                Label6.Text = "Turn: Player 1"
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub iisq()
        If game = True Then
            If player1 = False Then
                If player2 = True Then
                    If ai = True Then
                        If ii = 0 Then
                            ii = 2
                            Button9.Text = "X"
                            aicheckwin()
                            If ii = 2 And f = 2 And c = 2 Then
                                win3()
                            ElseIf ii = 2 And ee = 2 And a = 2 Then
                                win7()
                            ElseIf ii = 2 And h = 2 And g = 2 Then
                                win3()
                            ElseIf a <> 0 And b <> 0 And c <> 0 And d <> 0 And ee <> 0 And f <> 0 And g <> 0 And h <> 0 And ii <> 0 Then
                                MsgBox("Tie!")
                                game = False
                                player1 = False
                                player2 = False
                            Else
                                player1 = True
                                player2 = False
                                Label6.Text = "Turn: Player 1"
                            End If
                        End If

                    End If
                End If
            End If
        End If
    End Sub
    Private Sub win1()
        If game = True Then
            If player1 = False Then
                If ai = True Then
                    If a = 2 And b = 2 And c = 2 Then
                        aiwin()
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub win2()
        If game = True Then
            If player1 = False Then
                If ai = True Then
                    If d = 2 And ee = 2 And f = 2 Then
                        aiwin()
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub win3()
        If game = True Then
            If player1 = False Then
                If ai = True Then
                    If g = 2 And h = 2 And ii = 2 Then
                        aiwin()
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub win4()
        If game = True Then
            If player1 = False Then
                If ai = True Then
                    If a = 2 And d = 2 And g = 2 Then
                        aiwin()
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub win5()
        If game = True Then
            If player1 = False Then
                If ai = True Then
                    If b = 2 And ee = 2 And h = 2 Then
                        aiwin()
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub win6()
        If game = True Then
            If player1 = False Then
                If ai = True Then
                    If a = c And f = 2 And ii = 2 Then
                        aiwin()
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub win7()
        If game = True Then
            If player1 = False Then
                If ai = True Then
                    If a = 2 And ee = 2 And ii = 2 Then
                        aiwin()
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub win8()
        If game = True Then
            If player1 = False Then
                If ai = True Then
                    If g = 2 And ee = 2 And c = 2 Then
                        aiwin()
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub aitie()
        If game = True Then
            If player1 = False Then
                If ai = True Then
                    If a <> 0 And b <> 0 And c <> 0 And d <> 0 And ee <> 0 And f <> 0 And g <> 0 And h <> 0 And ii <> 0 Then
                        MsgBox("Tie!")
                        game = False
                        player1 = False
                        player2 = False
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        ai = True
        playermatch = False

        resetall()

    End Sub
    Private Sub resetall()
        game = False
        player1 = False
        player2 = False

        Label7.Text = "Please Press New Game"

        Button1.Text = String.Empty
        Button2.Text = String.Empty
        Button3.Text = String.Empty
        Button4.Text = String.Empty
        Button5.Text = String.Empty
        Button6.Text = String.Empty
        Button7.Text = String.Empty
        Button8.Text = String.Empty
        Button9.Text = String.Empty

        a = 0
        b = 0
        c = 0
        d = 0
        ee = 0
        f = 0
        g = 0
        h = 0
        ii = 0

        player1score = 0
        player2score = 0

        Label4.Text = player1score
        Label5.Text = player2score
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        ai = False
        playermatch = True

        resetall()
    End Sub
End Class

