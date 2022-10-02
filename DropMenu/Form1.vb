Public Class Form1
    Dim isCollapsed As Boolean = True
    Dim isCollapsed2 As Boolean = True
    Dim isCollapsed3 As Boolean = True

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DropPanel1.Size = DropPanel1.MinimumSize
        DropPanel2.Size = DropPanel2.MinimumSize
        DropPanel3.Size = DropPanel3.MinimumSize


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If isCollapsed Then
            DropButton1.Image = My.Resources.arrowDown
            DropPanel1.Height += 10
            If DropPanel1.Size = DropPanel1.MaximumSize Then
                Timer1.Stop()
                isCollapsed = False
            End If
        Else
            DropButton1.Image = My.Resources.arrowRight
            DropPanel1.Height -= 10
            If DropPanel1.Size = DropPanel1.MinimumSize Then
                Timer1.Stop()
                isCollapsed = True
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If isCollapsed2 Then
            DropButton2.Image = My.Resources.arrowDown
            DropPanel2.Height += 10
            If DropPanel2.Size = DropPanel2.MaximumSize Then
                Timer2.Stop()
                isCollapsed2 = False
            End If
        Else
            DropButton2.Image = My.Resources.arrowRight
            DropPanel2.Height -= 10
            If DropPanel2.Size = DropPanel2.MinimumSize Then
                Timer2.Stop()
                isCollapsed2 = True
            End If
        End If
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If isCollapsed3 Then
            DropButton3.Image = My.Resources.arrowDown
            DropPanel3.Height += 10
            If DropPanel3.Size = DropPanel3.MaximumSize Then
                Timer3.Stop()
                isCollapsed3 = False
            End If
        Else
            DropButton3.Image = My.Resources.arrowRight
            DropPanel3.Height -= 10
            If DropPanel3.Size = DropPanel3.MinimumSize Then
                Timer3.Stop()
                isCollapsed3 = True
            End If
        End If
    End Sub

    Private Sub DropButton1_Click(sender As Object, e As EventArgs) Handles DropButton1.Click

        Timer1.Start()

    End Sub

    Private Sub DropButton2_Click(sender As Object, e As EventArgs) Handles DropButton2.Click
        Timer2.Start()
    End Sub

    Private Sub DropButton3_Click(sender As Object, e As EventArgs) Handles DropButton3.Click
        Timer3.Start()
    End Sub


End Class
