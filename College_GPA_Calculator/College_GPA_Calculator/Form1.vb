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
End Class
