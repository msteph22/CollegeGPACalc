Public Class Form1
    'Choosing how many classes to display, defaults to 3 classes
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim numofclasses As Integer
        numofclasses = ComboBox1.Text
        Select Case numofclasses
            Case 1

                CBGrade4.Visible = False
                CBGrade4.ResetText()
                TextBox4.Visible = False
                TextBox4.Clear()

                CBGrade5.Visible = False
                CBGrade5.ResetText()
                TextBox5.Visible = False
                TextBox5.Clear()

                CBGrade6.Visible = False
                CBGrade6.ResetText()
                TextBox6.Visible = False
                TextBox6.Clear()
            Case 2

                CBGrade4.Visible = False
                CBGrade4.ResetText()
                TextBox4.Visible = False
                TextBox4.Clear()

                CBGrade5.Visible = False
                CBGrade5.ResetText()
                TextBox5.Visible = False
                TextBox5.Clear()

                CBGrade6.Visible = False
                CBGrade6.ResetText()
                TextBox6.Visible = False
                TextBox6.Clear()
            Case 3

                CBGrade4.Visible = False
                CBGrade4.ResetText()
                TextBox4.Visible = False
                TextBox4.Clear()

                CBGrade5.Visible = False
                CBGrade5.ResetText()
                TextBox5.Visible = False
                TextBox5.Clear()

                CBGrade6.Visible = False
                CBGrade6.ResetText()
                TextBox6.Visible = False
                TextBox6.Clear()
            Case 4

                CBGrade4.Visible = True
                TextBox4.Visible = True

                CBGrade5.Visible = False
                CBGrade5.ResetText()
                TextBox5.Visible = False
                TextBox5.Clear()

                CBGrade6.Visible = False
                CBGrade6.ResetText()
                TextBox6.Visible = False
                TextBox6.Clear()
            Case 5

                CBGrade4.Visible = True
                TextBox4.Visible = True

                CBGrade5.Visible = True
                TextBox5.Visible = True

                CBGrade6.Visible = False
                CBGrade6.ResetText()
                TextBox6.Visible = False
                TextBox6.Clear()
            Case 6

                CBGrade4.Visible = True
                TextBox4.Visible = True

                CBGrade5.Visible = True
                TextBox5.Visible = True

                CBGrade6.Visible = True
                TextBox6.Visible = True
        End Select
    End Sub
    'Clear All button to clear all textboxes and ComboBoxes
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim X As Control
        Dim CB As Control

        For Each X In Me.Controls
            If TypeOf X Is TextBox Then
                X.Text = ""
            End If
        Next
        For Each CB In Me.Controls
            If TypeOf CB Is ComboBox Then
                CB.ResetText()
            End If
        Next
    End Sub
    'Calculate button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'A = 4.0, B = 3.0, C = 2.0, D = 1.0, F = 0
        Dim Grade1, Grade2, Grade3, Grade4, Grade5, Grade6, GradeTotal As Double
        Dim Hours1, Hours2, Hours3, Hours4, Hours5, Hours6, HoursTotal, FinalGPA As Double
        Select Case CBGrade1.Text
            Case "A"
                Grade1 = 4
            Case "B"
                Grade1 = 3
            Case "C"
                Grade1 = 2
            Case "D"
                Grade1 = 1
            Case "F"
                Grade1 = 0
        End Select
        Select Case CBGrade2.Text
            Case "A"
                Grade2 = 4
            Case "B"
                Grade2 = 3
            Case "C"
                Grade2 = 2
            Case "D"
                Grade2 = 1
            Case "F"
                Grade2 = 0
        End Select
        Select Case CBGrade3.Text
            Case "A"
                Grade3 = 4
            Case "B"
                Grade3 = 3
            Case "C"
                Grade3 = 2
            Case "D"
                Grade3 = 1
            Case "F"
                Grade3 = 0
        End Select
        Select Case CBGrade4.Text
            Case "A"
                Grade4 = 4
            Case "B"
                Grade4 = 3
            Case "C"
                Grade4 = 2
            Case "D"
                Grade4 = 1
            Case "F"
                Grade4 = 0
        End Select
        Select Case CBGrade5.Text
            Case "A"
                Grade5 = 4
            Case "B"
                Grade5 = 3
            Case "C"
                Grade5 = 2
            Case "D"
                Grade5 = 1
            Case "F"
                Grade5 = 0
        End Select
        Select Case CBGrade6.Text
            Case "A"
                Grade6 = 4
            Case "B"
                Grade6 = 3
            Case "C"
                Grade6 = 2
            Case "D"
                Grade6 = 1
            Case "F"
                Grade6 = 0
        End Select

        If TextBox1.Text = "" Then 'Check to see if the textbox has data
        Else 'If it does have data runs else
            If IsNumeric(TextBox1.Text) Then 'checks to see if data is numeric
                Hours1 = TextBox1.Text 'sets hours1 to whatever number is in the textbox
            Else
                MsgBox("Please enter a numeric value in the first row") 'throws and error to the user telling wrong data
                TextBox1.Focus() 'puts cursor on the textbox with wrong data
            End If
        End If
        If TextBox2.Text = "" Then
        Else
            If IsNumeric(TextBox2.Text) Then
                Hours2 = TextBox2.Text
            Else
                MsgBox("Please enter a numeric value in the first row")
                TextBox2.Focus()
            End If
        End If
        If TextBox3.Text = "" Then
        Else
            If IsNumeric(TextBox3.Text) Then
                Hours3 = TextBox3.Text
            Else
                MsgBox("Please enter a numeric value in the first row")
                TextBox3.Focus()
            End If
        End If
        If TextBox4.Text = "" Then
        Else
            If IsNumeric(TextBox4.Text) Then
                Hours4 = TextBox4.Text
            Else
                MsgBox("Please enter a numeric value in the first row")
                TextBox4.Focus()
            End If
        End If
        If TextBox5.Text = "" Then
        Else
            If IsNumeric(TextBox5.Text) Then
                Hours5 = TextBox5.Text
            Else
                MsgBox("Please enter a numeric value in the first row")
                TextBox5.Focus()
            End If
        End If
        If TextBox6.Text = "" Then
        Else
            If IsNumeric(TextBox6.Text) Then
                Hours6 = TextBox6.Text
            Else
                MsgBox("Please enter a numeric value in the first row")
                TextBox6.Focus()
            End If
        End If

        'Multiplying the grade and the hours for the specific class together and adding them
        GradeTotal = (Grade1 * Hours1) + (Grade2 * Hours2) + (Grade3 * Hours3) + (Grade4 * Hours4) + (Grade5 * Hours5) + (Grade6 * Hours6)
        'Adding hours of all classes together
        HoursTotal = Hours1 + Hours2 + Hours3 + Hours4 + Hours5 + Hours6
        'Calculate Final GPA
        FinalGPA = GradeTotal / HoursTotal
        'Display final gpa in label
        Label3.Text = FinalGPA.ToString("0.00")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim GPANum, GPANote As String
        GPANum = Label3.Text
        GPANote = TBNote.Text

        ListBox1.Items.Add(GPANum & " " & GPANote)
        TBNote.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
