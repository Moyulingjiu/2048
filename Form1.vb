Public Class Form1

    Dim ListLabColor As Integer = 210

    Dim Dot(0 To 4, 0 To 4) As Integer

    Public Function GetAlphanumeric(max As Integer) As Integer
        Dim rnd As New Random()
        Return rnd.Next(max)
    End Function

    Public Function DotDrawNew(num As Integer, x As Integer, y As Integer, SingalWidth As Integer) As Integer
        Dim MyGraphics As Graphics = Me.CreateGraphics
        Dim ShowNumber As Integer = (num + 1) * 2
        Dim Mystring_Size As SizeF = MyGraphics.MeasureString(ShowNumber, Label1.Font)
        Dim DrawX As Integer = x * SingalWidth + (SingalWidth - Mystring_Size.Width) / 2
        Dim DrawY As Integer = y * SingalWidth + (SingalWidth - Mystring_Size.Height) / 2
        Dim solidbrush As SolidBrush = New SolidBrush(Color.FromArgb(117, 110, 102))



        If Dot(x, y) = 0 Then
            Dot(x, y) = ShowNumber
        Else
            Dim DotEmpty As Boolean = False
            For i = 0 To 3
                For j = 0 To 3
                    If Dot(i, j) = 0 And Not DotEmpty Then
                        DrawX = i * SingalWidth + (SingalWidth - Mystring_Size.Width) / 2
                        DrawY = j * SingalWidth + (SingalWidth - Mystring_Size.Height) / 2
                        DotEmpty = True
                        Dot(i, j) = ShowNumber
                        x = i
                        y = j
                    End If
                Next
            Next
        End If

        Dim LeaveSpace As Integer = 3
        Dim SpaceX As Integer = x * SingalWidth + LeaveSpace
        Dim SpaceY As Integer = y * SingalWidth + LeaveSpace
        Dim SpaceWidth As Integer = SingalWidth - LeaveSpace * 2
        If num = 2 Then
            Dim myBrush As New SolidBrush(Color.FromArgb(236, 228, 219))
            MyGraphics.FillRectangle(myBrush, SpaceX, SpaceY, SpaceWidth, SpaceWidth)
        Else
            Dim myBrush As New SolidBrush(Color.FromArgb(236, 228, 219))
            MyGraphics.FillRectangle(myBrush, SpaceX, SpaceY, SpaceWidth, SpaceWidth)
        End If

        MyGraphics.DrawString(ShowNumber, Label1.Font, solidbrush, New RectangleF(DrawX, DrawY, Mystring_Size.Width, Mystring_Size.Height))

        Return 0
    End Function

    Public Function DotDraw(num As Integer, x As Integer, y As Integer, SingalWidth As Integer) As Integer
        Dim MyGraphics As Graphics = Me.CreateGraphics
        Dim Mystring_Size As SizeF = MyGraphics.MeasureString(num, Label1.Font)
        Dim DrawX As Integer = x * SingalWidth + (SingalWidth - Mystring_Size.Width) / 2
        Dim DrawY As Integer = y * SingalWidth + (SingalWidth - Mystring_Size.Height) / 2
        Dim LeaveSpace As Integer = 3
        Dim SpaceX As Integer = x * SingalWidth + LeaveSpace
        Dim SpaceY As Integer = y * SingalWidth + LeaveSpace
        Dim SpaceWidth As Integer = SingalWidth - LeaveSpace * 2

        If num = 2 Or num = 4 Then
            Dim solidbrush As SolidBrush = New SolidBrush(Color.FromArgb(117, 110, 102))
            If num = 2 Then
                Dim myBrush As New SolidBrush(Color.FromArgb(236, 228, 219))
                MyGraphics.FillRectangle(myBrush, SpaceX, SpaceY, SpaceWidth, SpaceWidth)
            Else
                Dim myBrush As New SolidBrush(Color.FromArgb(236, 228, 219))
                MyGraphics.FillRectangle(myBrush, SpaceX, SpaceY, SpaceWidth, SpaceWidth)
            End If
            MyGraphics.DrawString(num, Label1.Font, solidbrush, New RectangleF(DrawX, DrawY, Mystring_Size.Width, Mystring_Size.Height))
        Else
            Dim solidbrush As SolidBrush = New SolidBrush(Color.FromArgb(255, 255, 255))
            If num = 8 Then
                Dim myBrush As New SolidBrush(Color.FromArgb(232, 179, 129))
                MyGraphics.FillRectangle(myBrush, SpaceX, SpaceY, SpaceWidth, SpaceWidth)
            ElseIf num = 16 Then
                Dim myBrush As New SolidBrush(Color.FromArgb(223, 145, 95))
                MyGraphics.FillRectangle(myBrush, SpaceX, SpaceY, SpaceWidth, SpaceWidth)
            ElseIf num = 32 Then
                Dim myBrush As New SolidBrush(Color.FromArgb(246, 124, 95))
                MyGraphics.FillRectangle(myBrush, SpaceX, SpaceY, SpaceWidth, SpaceWidth)
            ElseIf num = 64 Then
                Dim myBrush As New SolidBrush(Color.FromArgb(246, 124, 95))
                MyGraphics.FillRectangle(myBrush, SpaceX, SpaceY, SpaceWidth, SpaceWidth)
            ElseIf num = 128 Then
                Dim myBrush As New SolidBrush(Color.FromArgb(237, 207, 114))
                MyGraphics.FillRectangle(myBrush, SpaceX, SpaceY, SpaceWidth, SpaceWidth)
            ElseIf num = 256 Then
                Dim myBrush As New SolidBrush(Color.FromArgb(235, 209, 99))
                MyGraphics.FillRectangle(myBrush, SpaceX, SpaceY, SpaceWidth, SpaceWidth)
            ElseIf num = 512 Then
                Dim myBrush As New SolidBrush(Color.FromArgb(206, 255, 94))
                MyGraphics.FillRectangle(myBrush, SpaceX, SpaceY, SpaceWidth, SpaceWidth)
            ElseIf num = 1024 Then
                Dim myBrush As New SolidBrush(Color.FromArgb(178, 255, 90))
                MyGraphics.FillRectangle(myBrush, SpaceX, SpaceY, SpaceWidth, SpaceWidth)
            Else
                Dim myBrush As New SolidBrush(Color.FromArgb(100, 255, 0))
                MyGraphics.FillRectangle(myBrush, SpaceX, SpaceY, SpaceWidth, SpaceWidth)
            End If
            MyGraphics.DrawString(num, Label1.Font, solidbrush, New RectangleF(DrawX, DrawY, Mystring_Size.Width, Mystring_Size.Height))
        End If


        Return 0
    End Function

    Private Sub ConditionDetection()
        '胜利，失败检测
        Dim DieValue As Boolean = False
        Dim NoFull As Boolean = True
        For i = 0 To 3
            For j = 0 To 3
                If Dot(i, j) = 0 Then
                    NoFull = False
                End If
                If Dot(i, j) = 2048 Then
                    MsgBox("胜利!!")
                    Dim myg As Graphics = Me.CreateGraphics
                    myg.Clear(Color.White) '清楚画布
                    start.Visible = True
                    introduce.Visible = True
                End If
                If i <> 0 And i <> 3 And j <> 0 And j <> 3 Then
                    If Dot(i, j) = Dot(i - 1, j) Or Dot(i, j) = Dot(i + 1, j) Or Dot(i, j) = Dot(i, j - 1) Or Dot(i, j) = Dot(i, j + 1) Then
                        DieValue = True
                    End If
                End If

            Next
        Next
        If Dot(0, 0) = Dot(0, 1) Or Dot(0, 1) = Dot(0, 2) Or Dot(0, 2) = Dot(0, 3) Then
            DieValue = True
        End If
        If Dot(3, 0) = Dot(3, 1) Or Dot(3, 1) = Dot(3, 2) Or Dot(3, 2) = Dot(3, 3) Then
            DieValue = True
        End If
        If Dot(0, 0) = Dot(1, 0) Or Dot(1, 0) = Dot(2, 0) Or Dot(2, 0) = Dot(3, 0) Then
            DieValue = True
        End If
        If Dot(0, 3) = Dot(1, 3) Or Dot(1, 3) = Dot(2, 3) Or Dot(2, 3) = Dot(3, 3) Then
            DieValue = True
        End If

        If Not DieValue And NoFull Then
            MsgBox("场上再无可移动的方块！失败")
            Dim myg As Graphics = Me.CreateGraphics
            myg.Clear(Color.White) '清楚画布
            start.Visible = True
            introduce.Visible = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Draw()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim PressValue As Boolean = False
        Dim MoveValue As Boolean = False
        If e.KeyCode = 27 Then
            Dim Sure As Integer
            Sure = MsgBox("是否要重新开始本局游戏？", vbOKCancel)
            If Sure = 1 Then
                Dim myg As Graphics = Me.CreateGraphics
                myg.Clear(Color.White) '清楚画布
                start.Visible = True
                introduce.Visible = True
            End If
        End If

        If e.KeyCode = 37 Then '向左
            PressValue = True
            For i = 0 To 3
                For j = 0 To 3
                    If Dot(i, j) <> 0 And i <> 0 Then
                        For k = i - 1 To 0 Step -1 '判定其是否与左侧的数字相等
                            'MsgBox("向左" & vbNewLine & Dot(0, 0) & " " & Dot(1, 0) & " " & Dot(2, 0) & " " & Dot(3, 0) & vbNewLine & Dot(0, 1) & " " & Dot(1, 1) & " " & Dot(2, 1) & " " & Dot(3, 1) & vbNewLine & Dot(0, 2) & " " & Dot(1, 2) & " " & Dot(2, 2) & " " & Dot(3, 2) & vbNewLine & Dot(0, 3) & " " & Dot(1, 3) & " " & Dot(2, 3) & " " & Dot(3, 3))
                            If Dot(k, j) = Dot(k + 1, j) Then
                                Dot(k, j) = Dot(k, j) * 2
                                Dot(k + 1, j) = 0
                                MoveValue = True
                                k = -1
                                If i <> 3 Then
                                    i = i + 1
                                    For t = i - 1 To 1 Step -1
                                        Dot(t, j) = Dot(t - 1, j)
                                    Next
                                    Dot(0, j) = 0
                                End If
                            ElseIf Dot(k, j) = 0 Then
                                    Dot(k, j) = Dot(k + 1, j)
                                    Dot(k + 1, j) = 0
                                    MoveValue = True
                                Else
                                    k = -1
                            End If
                        Next
                    End If
                Next
            Next
            For j = 0 To 3 '自然滑落
                For i = 0 To 2
                    If Dot(i, j) = 0 And Dot(i + 1, j) <> 0 Then
                        For k = i To 2
                            Dot(k, j) = Dot(k + 1, j)
                        Next
                        Dot(3, j) = 0
                    End If
                    If i < 2 Then
                        If Dot(i, j) = 0 And Dot(i + 1, j) = 0 And Dot(i + 2, j) <> 0 Then
                            For k = i To 1
                                Dot(k, j) = Dot(k + 2, j)
                            Next
                            Dot(2, j) = 0
                            Dot(3, j) = 0
                        End If
                    End If
                    If i < 1 Then
                        If Dot(i, j) = 0 And Dot(i + 1, j) = 0 And Dot(i + 2, j) = 0 And Dot(i + 3, j) <> 0 Then
                            Dot(0, j) = Dot(3, j)
                            Dot(3, j) = 0
                        End If
                    End If
                Next
            Next
        ElseIf e.KeyCode = 38 Then '向上
            PressValue = True
            For i = 0 To 3
                For j = 0 To 3
                    If Dot(i, j) <> 0 And j <> 0 Then
                        For k = j - 1 To 0 Step -1
                            'MsgBox("向上" & vbNewLine & Dot(0, 0) & " " & Dot(1, 0) & " " & Dot(2, 0) & " " & Dot(3, 0) & vbNewLine & Dot(0, 1) & " " & Dot(1, 1) & " " & Dot(2, 1) & " " & Dot(3, 1) & vbNewLine & Dot(0, 2) & " " & Dot(1, 2) & " " & Dot(2, 2) & " " & Dot(3, 2) & vbNewLine & Dot(0, 3) & " " & Dot(1, 3) & " " & Dot(2, 3) & " " & Dot(3, 3))
                            If Dot(i, k) = Dot(i, k + 1) Then
                                Dot(i, k) = Dot(i, k) * 2
                                Dot(i, k + 1) = 0
                                MoveValue = True
                                k = -1
                                If j <> 3 Then
                                    j = j + 1
                                    For t = j - 1 To 1 Step -1
                                        Dot(i, t) = Dot(i, t - 1)
                                    Next
                                    Dot(i, 0) = 0
                                End If
                            ElseIf Dot(i, k) = 0 Then
                                    Dot(i, k) = Dot(i, k + 1)
                                    Dot(i, k + 1) = 0
                                    MoveValue = True
                                Else
                                    k = -1
                            End If
                        Next
                    End If
                Next
            Next
            For i = 0 To 3 '自然滑落
                For j = 0 To 2
                    If Dot(i, j) = 0 And Dot(i, j + 1) <> 0 Then
                        For k = j To 2
                            Dot(i, k) = Dot(i, k + 1)
                        Next
                        Dot(i, 3) = 0
                    End If
                    If j < 2 Then
                        If Dot(i, j) = 0 And Dot(i, j + 1) = 0 And Dot(i, j + 2) <> 0 Then
                            For k = j To 1
                                Dot(i, k) = Dot(j, k + 2)
                            Next
                            Dot(j, 2) = 0
                            Dot(j, 3) = 0
                        End If
                    End If
                    If j < 1 Then
                        If Dot(i, j) = 0 And Dot(i, j + 1) = 0 And Dot(i, j + 2) = 0 And Dot(i, j + 3) <> 0 Then
                            Dot(i, 0) = Dot(i, 3)
                            Dot(i, 3) = 0
                        End If
                    End If
                Next
            Next
        ElseIf e.KeyCode = 39 Then '向右
            PressValue = True
            For i = 3 To 0 Step -1
                For j = 0 To 3
                    If Dot(i, j) <> 0 And i <> 3 Then
                        For k = i + 1 To 3 '判定其是否与右侧的数字相等
                            'MsgBox("向右" & vbNewLine & Dot(0, 0) & " " & Dot(1, 0) & " " & Dot(2, 0) & " " & Dot(3, 0) & vbNewLine & Dot(0, 1) & " " & Dot(1, 1) & " " & Dot(2, 1) & " " & Dot(3, 1) & vbNewLine & Dot(0, 2) & " " & Dot(1, 2) & " " & Dot(2, 2) & " " & Dot(3, 2) & vbNewLine & Dot(0, 3) & " " & Dot(1, 3) & " " & Dot(2, 3) & " " & Dot(3, 3))
                            If Dot(k, j) = Dot(k - 1, j) Then
                                Dot(k, j) = Dot(k, j) * 2
                                Dot(k - 1, j) = 0
                                MoveValue = True
                                k = 4
                                If i <> 0 Then
                                    i = i - 1
                                    For t = i + 1 To 2
                                        Dot(t, j) = Dot(t + 1, j)
                                    Next
                                    Dot(3, j) = 0
                                End If
                            ElseIf Dot(k, j) = 0 Then
                                    Dot(k, j) = Dot(k - 1, j)
                                    Dot(k - 1, j) = 0
                                    MoveValue = True
                                Else
                                    k = 4
                            End If
                        Next
                    End If
                Next
            Next
            For j = 0 To 3 '自然滑落
                For i = 3 To 1 Step -1
                    If Dot(i, j) = 0 And Dot(i - 1, j) <> 0 Then
                        For k = i To 1 Step -1
                            Dot(k, j) = Dot(k - 1, j)
                        Next
                        Dot(0, j) = 0
                    End If
                    If i > 1 Then
                        If Dot(i, j) = 0 And Dot(i - 1, j) = 0 And Dot(i - 2, j) <> 0 Then
                            For k = i To 2 Step -1
                                Dot(k, j) = Dot(k - 2, j)
                            Next
                            Dot(1, j) = 0
                            Dot(0, j) = 0
                        End If
                    End If
                    If i > 2 Then
                        If Dot(i, j) = 0 And Dot(i - 1, j) = 0 And Dot(i - 2, j) = 0 And Dot(i - 3, j) <> 0 Then
                            Dot(3, j) = Dot(0, j)
                            Dot(0, j) = 0
                        End If
                    End If
                Next
            Next
        ElseIf e.KeyCode = 40 Then '向下
            PressValue = True
            For i = 0 To 3
                For j = 3 To 0 Step -1
                    If Dot(i, j) <> 0 And j <> 3 Then
                        For k = j + 1 To 3
                            'MsgBox("向下" & vbNewLine & Dot(0, 0) & " " & Dot(1, 0) & " " & Dot(2, 0) & " " & Dot(3, 0) & vbNewLine & Dot(0, 1) & " " & Dot(1, 1) & " " & Dot(2, 1) & " " & Dot(3, 1) & vbNewLine & Dot(0, 2) & " " & Dot(1, 2) & " " & Dot(2, 2) & " " & Dot(3, 2) & vbNewLine & Dot(0, 3) & " " & Dot(1, 3) & " " & Dot(2, 3) & " " & Dot(3, 3))
                            If Dot(i, k) = Dot(i, k - 1) Then
                                Dot(i, k) = Dot(i, k) * 2
                                Dot(i, k - 1) = 0
                                MoveValue = True
                                k = 4
                                If j <> 0 Then
                                    j = j - 1
                                    For t = j + 1 To 2
                                        Dot(i, t) = Dot(i, t + 1)
                                    Next
                                    Dot(i, 3) = 0
                                End If
                            ElseIf Dot(i, k) = 0 Then
                                    Dot(i, k) = Dot(i, k - 1)
                                    Dot(i, k - 1) = 0
                                    MoveValue = True
                                Else
                                    k = 4
                            End If
                        Next
                    End If
                Next
            Next
            For i = 0 To 3 '自然滑落
                For j = 3 To 1 Step -1
                    If Dot(i, j) = 0 And Dot(i, j - 1) <> 0 Then
                        For k = j To 1 Step -1
                            Dot(i, k) = Dot(i, k - 1)
                        Next
                        Dot(i, 0) = 0
                    End If
                    If j > 1 Then
                        If Dot(i, j) = 0 And Dot(i, j - 1) = 0 And Dot(i, j - 2) <> 0 Then
                            For k = j To 2 Step -1
                                Dot(i, k) = Dot(j, k - 2)
                            Next
                            Dot(j, 1) = 0
                            Dot(j, 0) = 0
                        End If
                    End If
                    If j > 2 Then
                        If Dot(i, j) = 0 And Dot(i, j - 1) = 0 And Dot(i, j - 2) = 0 And Dot(i, j - 3) <> 0 Then
                            Dot(i, 3) = Dot(i, 0)
                            Dot(i, 0) = 0
                        End If
                    End If
                Next
            Next
        End If

        If PressValue And MoveValue Then
            Dim myg As Graphics = Me.CreateGraphics
            Dim mpen As New Pen(Color.FromArgb(ListLabColor, ListLabColor, ListLabColor))
            myg.Clear(Color.White) '清除画布
            Dim piece As Integer = Me.Width / 4 - 4
            myg.DrawLine(mpen, 0, 0, piece * 4, 0)
            'For i = 1 To 3
            'myg.DrawLine(mpen, 0, piece * i, piece * 4, piece * i)
            'myg.DrawLine(mpen, piece * i, 0, piece * i, piece * 4)
            'Next

            For i = 0 To 3
                For j = 0 To 3
                    If Dot(i, j) <> 0 Then
                        Call DotDraw(Dot(i, j), i, j, piece)
                    End If
                Next
            Next

            If MoveValue Then
                Call DotDrawNew(GetAlphanumeric(2), GetAlphanumeric(4), GetAlphanumeric(4), piece)
                Call ConditionDetection()
            End If
        End If
    End Sub

    Private Sub Draw()
        start.Top = Me.Height / 2 - 50 - start.Height
        introduce.Top = Me.Height / 2 - 40
    End Sub

    Private Sub start_MouseEnter(sender As Object, e As EventArgs) Handles start.MouseEnter
        start.BackColor = Color.FromArgb(ListLabColor, ListLabColor, ListLabColor)
    End Sub

    Private Sub start_MouseLeave(sender As Object, e As EventArgs) Handles start.MouseLeave
        start.BackColor = Color.White
    End Sub


    Private Sub introduce_MouseEnter(sender As Object, e As EventArgs) Handles introduce.MouseEnter
        introduce.BackColor = Color.FromArgb(ListLabColor, ListLabColor, ListLabColor)
    End Sub

    Private Sub introduce_MouseLeave(sender As Object, e As EventArgs) Handles introduce.MouseLeave
        introduce.BackColor = Color.White
    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles start.Click
        Dim myg As Graphics = Me.CreateGraphics
        Dim mpen As New Pen(Color.FromArgb(ListLabColor, ListLabColor, ListLabColor))
        Dim piece As Integer = Me.Width / 4 - 4
        start.Visible = False
        introduce.Visible = False
        Label1.ForeColor = Color.FromArgb(117, 110, 102)
        For i = 0 To 4
            For j = 0 To 4
                Dot(i, j) = 0
            Next
        Next
        myg.DrawLine(mpen, 0, 0, piece * 4, 0)
        'For i = 1 To 3
        'myg.DrawLine(mpen, 0, piece * i, piece * 4, piece * i)
        'myg.DrawLine(mpen, piece * i, 0, piece * i, piece * 4)
        'Next
        Call DotDrawNew(GetAlphanumeric(2), GetAlphanumeric(4), GetAlphanumeric(4), piece)
        Call DotDrawNew(GetAlphanumeric(2), GetAlphanumeric(4), GetAlphanumeric(4), piece)

    End Sub

    Private Sub Introduce_Click(sender As Object, e As EventArgs) Handles introduce.Click
        MsgBox("游戏2048     " & vbNewLine & vbNewLine & vbNewLine & "游戏规则：" & vbNewLine & "  1、2048有一个4*4的棋盘。" _
               & vbNewLine & "  2、开始时棋盘内随机出现两个数字，出现的数字仅可能为2或4。" _
               & vbNewLine & "  3、玩家可以选择上下左右四个方向，棋盘内的棋子按该方向位移。" _
               & vbNewLine & "    a) 若有棋子在移动方向的一侧（如：右侧）为空，则将其移动到该位。" _
               & vbNewLine & "    b) 若有棋子在移动方向的一侧（如：右侧）为同样的数字，则将其与该侧数字相加。不可将两个以上数字相加。" _
               & vbNewLine & "    c) 若该方向无棋子满足a)或b)条件，则不移动棋子。" _
               & vbNewLine & "  4、每有效移动一步，棋盘的空位（无数字处）随机出现一个数字（为2或4）。" _
               & vbNewLine & "  5、若四个方向都满足第3条c)规则，则判负。" _
               & vbNewLine & "  6、若出现2048，则判胜。" _
               & vbNewLine & "  7、按下ESC键即可重开游戏。" _
               & vbNewLine & vbNewLine & "Copyright @ 2019, 墨羽 all rights reserved.")
    End Sub
End Class
