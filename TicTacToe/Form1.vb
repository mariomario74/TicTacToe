Imports System.CodeDom.Compiler
Imports System.Diagnostics.Contracts
Imports System.DirectoryServices.ActiveDirectory


''In acest program aveti posibilitatea de a folosi fie picturebox-uri direct si verificarea conditiei de castig prin acestea fie umplerea unei matrici bazate pe ce apasam adica picture box-uri si verficarea conditiei de castig prin matrice.
Public Class Form1
    Dim xPath As String = "C:/Tictac/X.png"  'Locatie default X
    Dim oPath As String = "C:/Tictac/O.png"  'Locatie default O
    Dim defaultPicturePath As String = "C:/Tictac/default.jpg"  ' Locatie default poza default
    Dim Oturn As Boolean
    Dim xScore As Integer 'Scor X
    Dim oScore As Integer 'Scor O
    Dim mat(3, 3) As Integer   'Folosesc 1 ca fiind intrarea pentru X si 2 pentru O.
    Dim fullCheck As Integer = 0  'Variabila de verificare daca este egal
    Dim playAgainstCPU As Boolean
    Dim result As String

    'Functii de incepere incarcate la deschiderea aplicatiei.
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "0"
        Label2.Text = "0"
        RandomTurnGenerator()
        checkTurn()
        resetAfterWin()

        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Font = SystemFonts.DefaultFont
        Me.AutoScaleDimensions = New SizeF(96.0F, 96.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi

    End Sub


    ''Functie resetare a tuturor valorilor.''
    Sub resetAfterWin()

        'Imagini sterse sa fie inapoi la default
        PictureBox1.Image = Image.FromFile(defaultPicturePath)
        PictureBox2.Image = Image.FromFile(defaultPicturePath)
        PictureBox3.Image = Image.FromFile(defaultPicturePath)
        PictureBox4.Image = Image.FromFile(defaultPicturePath)
        PictureBox5.Image = Image.FromFile(defaultPicturePath)
        PictureBox6.Image = Image.FromFile(defaultPicturePath)
        PictureBox7.Image = Image.FromFile(defaultPicturePath)
        PictureBox8.Image = Image.FromFile(defaultPicturePath)
        PictureBox9.Image = Image.FromFile(defaultPicturePath)

        'Tag sterse dar initializate diferit pentru a nu ne da direct un castigator pt ca tag-urile sunt la fel si eu verific pe tag-uri.
        PictureBox1.Tag = "11"
        PictureBox2.Tag = "12"
        PictureBox3.Tag = "13"
        PictureBox4.Tag = "21"
        PictureBox5.Tag = "22"
        PictureBox6.Tag = "23"
        PictureBox7.Tag = "31"
        PictureBox8.Tag = "32"
        PictureBox9.Tag = "33"

        Dim generator As System.Random = New Random
        'Stergerea/luarea de la 0 a variabilei pentru a verifica daca "tabelul" nostru este plin.
        fullCheck = 0

        'Golirea matricei
        For x = 1 To 3

            For y = 1 To 3
                mat(x, y) = generator.Next(5, 20)

            Next y
        Next x

    End Sub

    'Generator random pt inceperea meciului. Daca incepe X sau 0.
    Sub RandomTurnGenerator()

        Dim generator As System.Random = New System.Random
        Oturn = generator.Next(0, 2)

    End Sub

    'Afisare a cui este tura.
    Sub checkTurn()

        If Oturn = False Then
            Label5.Text = "X's turn!"
        Else
            Label5.Text = "O's turn!"
        End If

    End Sub

    'Functie verificare daca este egal.
    Sub checkNotFull()

        If fullCheck = 9 Then

            MessageBox.Show("It's a tie!")
            resetAfterWin()

        End If

    End Sub


    ''''''''''''''''''''''''''''''PROCEDURILE CORECTE A FIECARUI CLICK PE FIECARE PICTURE BOX 1-9''''''''''''''''''''''''''''''''''''
    '''Cele 3 functii checkTurn() checkWinMatrix() si checkNotFull() sunt apelate dupa fiecare apasare de picture box pentru a asigura functionarea corecta a programului.'''
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Oturn = False Then
            PictureBox1.Image = Image.FromFile(xPath)
            PictureBox1.Tag = "X"
            mat(1, 1) = 1   ' 1 adica e X 
            Oturn = True
        Else
            PictureBox1.Image = Image.FromFile(oPath)
            PictureBox1.Tag = "O"
            mat(1, 1) = 2   ' 2 adica e O
            Oturn = False
        End If
        fullCheck += 1
        checkTurn()
        checkWinMatrix()
        checkNotFull()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Oturn = False Then
            PictureBox2.Image = Image.FromFile(xPath)
            mat(1, 2) = 1
            PictureBox2.Tag = "X"
            Oturn = True
        Else
            PictureBox2.Image = Image.FromFile(oPath)
            mat(1, 2) = 2
            PictureBox2.Tag = "O"
            Oturn = False
        End If
        fullCheck += 1
        checkTurn()
        checkWinMatrix()
        checkNotFull()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

        If Oturn = False Then
            PictureBox3.Image = Image.FromFile(xPath)
            mat(1, 3) = 1
            PictureBox3.Tag = "X"
            Oturn = True
        Else
            PictureBox3.Image = Image.FromFile(oPath)
            mat(1, 3) = 2
            PictureBox3.Tag = "O"
            Oturn = False
        End If
        fullCheck += 1
        checkTurn()
        checkWinMatrix()
        checkNotFull()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

        If Oturn = False Then
            PictureBox4.Image = Image.FromFile(xPath)
            mat(2, 1) = 1
            PictureBox4.Tag = "X"
            Oturn = True
        Else
            PictureBox4.Image = Image.FromFile(oPath)
            mat(2, 1) = 2
            PictureBox4.Tag = "O"
            Oturn = False
        End If
        fullCheck += 1
        checkTurn()
        checkWinMatrix()
        checkNotFull()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

        If Oturn = False Then
            PictureBox5.Image = Image.FromFile(xPath)
            mat(2, 2) = 1
            PictureBox5.Tag = "X"
            Oturn = True
        Else
            PictureBox5.Image = Image.FromFile(oPath)
            mat(2, 2) = 2
            PictureBox5.Tag = "O"
            Oturn = False
        End If
        fullCheck += 1
        checkTurn()
        checkWinMatrix()
        checkNotFull()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

        If Oturn = False Then
            PictureBox6.Image = Image.FromFile(xPath)
            mat(2, 3) = 1
            PictureBox6.Tag = "X"
            Oturn = True
        Else
            PictureBox6.Image = Image.FromFile(oPath)
            mat(2, 3) = 2
            PictureBox6.Tag = "O"
            Oturn = False
        End If
        fullCheck += 1
        checkTurn()
        checkWinMatrix()
        checkNotFull()
    End Sub
    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

        If Oturn = False Then
            PictureBox7.Image = Image.FromFile(xPath)
            mat(3, 1) = 1
            PictureBox7.Tag = "X"
            Oturn = True
        Else
            PictureBox7.Image = Image.FromFile(oPath)
            mat(3, 1) = 2
            PictureBox7.Tag = "O"
            Oturn = False
        End If
        fullCheck += 1
        checkTurn()
        checkWinMatrix()
        checkNotFull()

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click

        If Oturn = False Then
            PictureBox8.Image = Image.FromFile(xPath)
            mat(3, 2) = 1
            PictureBox8.Tag = "X"
            Oturn = True
        Else
            PictureBox8.Image = Image.FromFile(oPath)
            mat(3, 2) = 2
            PictureBox8.Tag = "O"
            Oturn = False
        End If
        fullCheck += 1
        checkTurn()
        checkWinMatrix()
        checkNotFull()
    End Sub
    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click

        If Oturn = False Then
            PictureBox9.Image = Image.FromFile(xPath)
            mat(3, 3) = 1
            PictureBox9.Tag = "X"
            Oturn = True
        Else
            PictureBox9.Image = Image.FromFile(oPath)
            mat(3, 3) = 2
            PictureBox9.Tag = "O"
            Oturn = False
        End If
        fullCheck += 1
        checkTurn()
        checkWinMatrix()
        checkNotFull()
    End Sub


    'Buton reset
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        resetAfterWin()
        xScore = 0
        oScore = 0
        Label1.Text = "0"
        Label2.Text = "0"
        PictureBox1.Tag = "11"
        PictureBox2.Tag = "12"
        PictureBox3.Tag = "13"
        PictureBox4.Tag = "21"
        PictureBox5.Tag = "22"
        PictureBox6.Tag = "23"
        PictureBox7.Tag = "31"
        PictureBox8.Tag = "32"
        PictureBox9.Tag = "33"

    End Sub


    '''''''''''''''''''''FUNCTIILE DE VERIFICARE A CASTIGARII!!!''''''''''''''''''''''''

    'Logica pentru fiecare combinatie de castig cu ajutorul tag-urilor. Nu mai folosesc MOMENTAN pentru ca folosesc matrici.

    Sub checkWin()

        If PictureBox1.Tag = PictureBox2.Tag AndAlso PictureBox2.Tag = PictureBox3.Tag Then
            If Oturn Then
                MessageBox.Show("X won!")
                xScore += 1
                Label1.Text = xScore
                resetAfterWin()
            Else
                MessageBox.Show("O won!")
                oScore += 1
                Label2.Text = oScore
                resetAfterWin()
            End If
        End If

        If PictureBox1.Tag = PictureBox5.Tag AndAlso PictureBox5.Tag = PictureBox9.Tag Then
            If Oturn Then
                MessageBox.Show("X won!")
                xScore += 1
                Label1.Text = xScore
                resetAfterWin()
            Else
                MessageBox.Show("O won!")
                oScore += 1
                Label2.Text = oScore
                resetAfterWin()
            End If
        End If

        If PictureBox3.Tag = PictureBox5.Tag AndAlso PictureBox5.Tag = PictureBox7.Tag Then
            If Oturn Then
                MessageBox.Show("X won!")
                xScore += 1
                Label1.Text = xScore
                resetAfterWin()
            Else
                MessageBox.Show("O won!")
                oScore += 1
                Label2.Text = oScore
                resetAfterWin()
            End If
        End If

        If PictureBox4.Tag = PictureBox5.Tag AndAlso PictureBox5.Tag = PictureBox6.Tag Then
            If Oturn Then
                MessageBox.Show("X won!")
                xScore += 1
                Label1.Text = xScore
                resetAfterWin()
            Else
                MessageBox.Show("O won!")
                oScore += 1
                Label2.Text = oScore
                resetAfterWin()
            End If
        End If

        If PictureBox7.Tag = PictureBox8.Tag AndAlso PictureBox8.Tag = PictureBox9.Tag Then
            If Oturn Then
                MessageBox.Show("X won!")
                xScore += 1
                Label1.Text = xScore
                resetAfterWin()
            Else
                MessageBox.Show("O won!")
                oScore += 1
                Label2.Text = oScore
                resetAfterWin()
            End If
        End If

        If PictureBox1.Tag = PictureBox4.Tag AndAlso PictureBox4.Tag = PictureBox7.Tag Then
            If Oturn Then
                MessageBox.Show("X won!")
                xScore += 1
                Label1.Text = xScore
                resetAfterWin()
            Else
                MessageBox.Show("O won!")
                oScore += 1
                Label2.Text = oScore
                resetAfterWin()
            End If
        End If

        If PictureBox2.Tag = PictureBox5.Tag AndAlso PictureBox5.Tag = PictureBox8.Tag Then
            If Oturn Then
                MessageBox.Show("X won!")
                xScore += 1
                Label1.Text = xScore
                resetAfterWin()
            Else
                MessageBox.Show("O won!")
                oScore += 1
                Label2.Text = oScore
                resetAfterWin()
            End If
        End If

        If PictureBox3.Tag = PictureBox6.Tag AndAlso PictureBox6.Tag = PictureBox9.Tag Then
            If Oturn Then
                MessageBox.Show("X won!")
                xScore += 1
                Label1.Text = xScore
                resetAfterWin()
            Else
                MessageBox.Show("O won!")
                oScore += 1
                Label2.Text = oScore
                resetAfterWin()
            End If
        End If

    End Sub

    'Functii ajutatoare pentru functia cu matrici.

    Sub checkWinMatrixTurnConditionX()

        MessageBox.Show("X won!")
        xScore += 1
        Label1.Text = xScore
        resetAfterWin()

    End Sub

    Sub checkWinMatrixTurnConditionO()

        MessageBox.Show("O won!")
        oScore += 1
        Label2.Text = oScore
        resetAfterWin()

    End Sub

    'Functie verificare castig folosind matrici!!!
    Sub checkWinMatrix()

        If mat(1, 1) = mat(1, 2) And mat(1, 2) = mat(1, 3) Then
            If mat(1, 1) = 1 Then

                checkWinMatrixTurnConditionX()    'Daca valoarea este 1 inseamna ca X a castigat si apelam pe X.

            Else

                checkWinMatrixTurnConditionO()    'Altfel apelam pe O si inseamna ca valoarea din array-ul mat este 2.

            End If
        End If

        If mat(2, 1) = mat(2, 2) And mat(2, 2) = mat(2, 3) Then

            If mat(2, 1) = 1 Then

                checkWinMatrixTurnConditionX()

            Else

                checkWinMatrixTurnConditionO()

            End If
        End If

        If mat(3, 1) = mat(3, 2) And mat(3, 2) = mat(3, 3) Then

            If mat(3, 1) = 1 Then

                checkWinMatrixTurnConditionX()

            Else

                checkWinMatrixTurnConditionO()

            End If

        End If

        If mat(1, 1) = mat(2, 2) And mat(2, 2) = mat(3, 3) Then

            If mat(1, 1) = 1 Then

                checkWinMatrixTurnConditionX()

            Else

                checkWinMatrixTurnConditionO()

            End If

        End If

        If mat(1, 3) = mat(2, 2) And mat(1, 3) = mat(3, 1) Then

            If mat(1, 3) = 1 Then

                checkWinMatrixTurnConditionX()

            Else

                checkWinMatrixTurnConditionO()

            End If

        End If

        If mat(1, 1) = mat(2, 1) And mat(2, 1) = mat(3, 1) Then

            If mat(1, 1) = 1 Then

                checkWinMatrixTurnConditionX()

            Else

                checkWinMatrixTurnConditionO()

            End If

        End If

        If mat(1, 2) = mat(2, 2) And mat(2, 2) = mat(3, 2) Then

            If mat(1, 2) = 1 Then

                checkWinMatrixTurnConditionX()

            Else

                checkWinMatrixTurnConditionO()

            End If

        End If

        If mat(1, 3) = mat(2, 3) And mat(2, 3) = mat(3, 3) Then

            If mat(1, 3) = 1 Then

                checkWinMatrixTurnConditionX()

            Else

                checkWinMatrixTurnConditionO()

            End If

        End If

    End Sub

    '''Incepere incercare implementare CPU'''
    Private Sub btnPlayCPU_Click(sender As Object, e As EventArgs) Handles btnPlayCPU.Click
        playAgainstCPU = True
        result = modulPopup.Show(
            {"X", "O"},
            "Alege jucatorul!",
            "Confirma!")
        playCPU()

    End Sub


    ''Functie de jucare calculator, inca nu este implementata corect si 100% functional.''
    Sub playCPU()
        Dim latestboxRandom As Integer
        Dim generator As System.Random = New Random
        Dim boxRandom As Integer = generator.Next(1, 10)
        latestboxRandom = boxRandom
        If result = "O" And Oturn = True Then
            For x = 1 To 3
                For y = 1 To 3
                    If mat(x, y) <> 1 Or mat(x, y) <> 2 Then

                        Select Case boxRandom
                            Case "1"
                                PictureBox1.Image = Image.FromFile(oPath)
                                mat(1, 1) = 2
                            Case "2"
                                PictureBox2.Image = Image.FromFile(oPath)
                                mat(1, 2) = 2
                            Case "3"
                                PictureBox3.Image = Image.FromFile(oPath)
                                mat(1, 3) = 2
                            Case "4"
                                PictureBox4.Image = Image.FromFile(oPath)
                                mat(2, 1) = 2
                            Case "5"
                                PictureBox5.Image = Image.FromFile(oPath)
                                mat(2, 2) = 2
                            Case "6"
                                PictureBox6.Image = Image.FromFile(oPath)
                                mat(2, 3) = 2
                            Case "7"
                                PictureBox7.Image = Image.FromFile(oPath)
                                mat(3, 1) = 2
                            Case "8"
                                PictureBox8.Image = Image.FromFile(oPath)
                                mat(3, 2) = 2
                            Case "9"
                                PictureBox9.Image = Image.FromFile(oPath)
                                mat(3, 3) = 2

                        End Select

                    End If

                    While boxRandom = latestboxRandom
                        boxRandom = generator.Next(1, 10)
                        latestboxRandom = boxRandom
                        If boxRandom <> latestboxRandom Then
                            Select Case boxRandom
                                Case "1"
                                    PictureBox1.Image = Image.FromFile(oPath)
                                    mat(1, 1) = 2
                                Case "2"
                                    PictureBox2.Image = Image.FromFile(oPath)
                                    mat(1, 2) = 2
                                Case "3"
                                    PictureBox3.Image = Image.FromFile(oPath)
                                    mat(1, 3) = 2
                                Case "4"
                                    PictureBox4.Image = Image.FromFile(oPath)
                                    mat(2, 1) = 2
                                Case "5"
                                    PictureBox5.Image = Image.FromFile(oPath)
                                    mat(2, 2) = 2
                                Case "6"
                                    PictureBox6.Image = Image.FromFile(oPath)
                                    mat(2, 3) = 2
                                Case "7"
                                    PictureBox7.Image = Image.FromFile(oPath)
                                    mat(3, 1) = 2
                                Case "8"
                                    PictureBox8.Image = Image.FromFile(oPath)
                                    mat(3, 2) = 2
                                Case "9"
                                    PictureBox9.Image = Image.FromFile(oPath)
                                    mat(3, 3) = 2
                            End Select

                        End If

                        boxRandom = generator.Next(1, 10)
                        latestboxRandom = boxRandom

                    End While

                Next

            Next

        End If

    End Sub
End Class
