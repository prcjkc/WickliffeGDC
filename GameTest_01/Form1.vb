Public Class Form1
    Dim timer As Stopwatch
    Dim backBuffer As Image
    Dim graphics As Graphics
    Dim clientWidth As Integer
    Dim clientHeight As Integer
    Dim interval As Long
    Dim startTick As Long
    Dim imageRect As Rectangle
    Dim direction As Point
    Dim player As Rectangle
    Dim playerDirection As Point
    Dim playSprite As Bitmap
    Private playerSpeed As Integer = 5

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        GameLoop()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        timer = New Stopwatch
        clientHeight = 300
        clientWidth = 300
        interval = 16
        Me.ClientSize = New Size(clientWidth, clientHeight)
        backBuffer = New Bitmap(clientWidth, clientHeight)
        graphics = Graphics.FromImage(backBuffer)
        direction = New Point(2, 3)
        imageRect = New Rectangle(0, 0, 30, 30)
        player = New Rectangle(1, 1, 1, 1)
        playSprite = New Bitmap(My.Resources.SpaceShip)
    End Sub

    Private Sub GameLoop()
        timer.Start()
        Do While (Me.Created)
            startTick = timer.ElapsedMilliseconds
            GameLogic()
            RenderScene()
            Application.DoEvents()
            Do While timer.ElapsedMilliseconds - startTick < interval

            Loop
        Loop
    End Sub

    Private Sub GameLogic()
        imageRect.X += direction.X
        imageRect.Y += direction.Y

        If imageRect.X < 0 Then
            imageRect.X = 3
            direction.X *= -1
        End If
        If imageRect.Y < 0 Then
            imageRect.Y = 3
            direction.Y *= -1
        End If
        If imageRect.X + imageRect.Width > clientWidth Then
            imageRect.X = clientWidth - imageRect.Width
            direction.X *= -1
        End If
        If imageRect.Y + imageRect.Height > clientHeight Then
            imageRect.Y = clientHeight - imageRect.Height
            direction.Y *= -1
        End If
    End Sub

    Private Sub RenderScene()
        backBuffer = New Bitmap(clientWidth, clientHeight)
        graphics = Graphics.FromImage(backBuffer)
        pbSurface.Image = Nothing
        graphics.FillRectangle(Brushes.Blue, imageRect)
        'graphics.FillRectangle(Brushes.Green, player)
        graphics.DrawImage(playSprite, player.Location)
        pbSurface.Image = backBuffer
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        player.X += playerDirection.X
        player.Y += playerDirection.Y

        Select Case e.KeyCode
            Case Keys.Up, Keys.W
                If Not player.Y < 0 Then
                    player.Y -= playerSpeed
                Else
                    player.Y = 3
                End If
            Case Keys.Down, Keys.S
                If player.Y + player.Height < clientHeight Then
                    player.Y += playerSpeed
                Else
                    player.Y = clientHeight - player.Height - 3
                End If
            Case Keys.Left, Keys.A
                If player.X > 0 Then
                    player.X -= playerSpeed
                Else
                    player.X = 3
                End If
            Case Keys.Right, Keys.D
                If player.X + player.Width < clientWidth Then
                    player.X += playerSpeed
                Else
                    player.X = clientWidth - player.Width - 3
                End If
        End Select
    End Sub
End Class
