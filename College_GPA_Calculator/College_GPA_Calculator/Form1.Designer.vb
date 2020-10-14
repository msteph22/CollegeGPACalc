<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CBGrade1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBGrade2 = New System.Windows.Forms.ComboBox()
        Me.CBGrade3 = New System.Windows.Forms.ComboBox()
        Me.CBGrade4 = New System.Windows.Forms.ComboBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.CBGrade5 = New System.Windows.Forms.ComboBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.CBGrade6 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TBNote = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SaveFeatureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CBGrade1
        '
        Me.CBGrade1.FormattingEnabled = True
        Me.CBGrade1.Items.AddRange(New Object() {"A", "B", "C", "D", "F"})
        Me.CBGrade1.Location = New System.Drawing.Point(63, 121)
        Me.CBGrade1.Name = "CBGrade1"
        Me.CBGrade1.Size = New System.Drawing.Size(99, 21)
        Me.CBGrade1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(333, 166)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 31)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(203, 122)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(90, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(203, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Credit Hours"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(63, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Grade"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CBGrade2
        '
        Me.CBGrade2.FormattingEnabled = True
        Me.CBGrade2.Items.AddRange(New Object() {"A", "B", "C", "D", "F"})
        Me.CBGrade2.Location = New System.Drawing.Point(63, 159)
        Me.CBGrade2.Name = "CBGrade2"
        Me.CBGrade2.Size = New System.Drawing.Size(99, 21)
        Me.CBGrade2.TabIndex = 5
        '
        'CBGrade3
        '
        Me.CBGrade3.FormattingEnabled = True
        Me.CBGrade3.Items.AddRange(New Object() {"A", "B", "C", "D", "F"})
        Me.CBGrade3.Location = New System.Drawing.Point(63, 197)
        Me.CBGrade3.Name = "CBGrade3"
        Me.CBGrade3.Size = New System.Drawing.Size(99, 21)
        Me.CBGrade3.TabIndex = 6
        '
        'CBGrade4
        '
        Me.CBGrade4.FormattingEnabled = True
        Me.CBGrade4.Items.AddRange(New Object() {"A", "B", "C", "D", "F"})
        Me.CBGrade4.Location = New System.Drawing.Point(63, 235)
        Me.CBGrade4.Name = "CBGrade4"
        Me.CBGrade4.Size = New System.Drawing.Size(99, 21)
        Me.CBGrade4.TabIndex = 7
        Me.CBGrade4.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(203, 160)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(90, 20)
        Me.TextBox2.TabIndex = 8
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(203, 198)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(90, 20)
        Me.TextBox3.TabIndex = 9
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(203, 236)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(90, 20)
        Me.TextBox4.TabIndex = 10
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox4.Visible = False
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(203, 274)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(90, 20)
        Me.TextBox5.TabIndex = 14
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox5.Visible = False
        '
        'CBGrade5
        '
        Me.CBGrade5.FormattingEnabled = True
        Me.CBGrade5.Items.AddRange(New Object() {"A", "B", "C", "D", "F"})
        Me.CBGrade5.Location = New System.Drawing.Point(63, 273)
        Me.CBGrade5.Name = "CBGrade5"
        Me.CBGrade5.Size = New System.Drawing.Size(99, 21)
        Me.CBGrade5.TabIndex = 13
        Me.CBGrade5.Visible = False
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(203, 312)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(90, 20)
        Me.TextBox6.TabIndex = 17
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox6.Visible = False
        '
        'CBGrade6
        '
        Me.CBGrade6.FormattingEnabled = True
        Me.CBGrade6.Items.AddRange(New Object() {"A", "B", "C", "D", "F"})
        Me.CBGrade6.Location = New System.Drawing.Point(63, 311)
        Me.CBGrade6.Name = "CBGrade6"
        Me.CBGrade6.Size = New System.Drawing.Size(99, 21)
        Me.CBGrade6.TabIndex = 16
        Me.CBGrade6.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.ComboBox1.Location = New System.Drawing.Point(333, 122)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(115, 21)
        Me.ComboBox1.TabIndex = 19
        Me.ComboBox1.Text = "Number of Classes"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(333, 215)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 31)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Clear All"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(129, 360)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 43)
        Me.Label3.TabIndex = 21
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(497, 121)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(121, 251)
        Me.ListBox1.TabIndex = 22
        Me.ListBox1.Visible = False
        '
        'TBNote
        '
        Me.TBNote.Location = New System.Drawing.Point(333, 288)
        Me.TBNote.Multiline = True
        Me.TBNote.Name = "TBNote"
        Me.TBNote.Size = New System.Drawing.Size(115, 44)
        Me.TBNote.TabIndex = 23
        Me.TBNote.Visible = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(333, 342)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 30)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Add Note and Save"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(333, 265)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(90, 17)
        Me.CheckBox1.TabIndex = 25
        Me.CheckBox1.Text = "Save Feature"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 27
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveFeatureToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(47, 22)
        Me.ToolStripDropDownButton1.Text = "Tools"
        '
        'SaveFeatureToolStripMenuItem
        '
        Me.SaveFeatureToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox1})
        Me.SaveFeatureToolStripMenuItem.Name = "SaveFeatureToolStripMenuItem"
        Me.SaveFeatureToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveFeatureToolStripMenuItem.Text = "Save Feature"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"Save Feature Visble", "Save Feature Hidden"})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 23)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TBNote)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.CBGrade6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.CBGrade5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.CBGrade4)
        Me.Controls.Add(Me.CBGrade3)
        Me.Controls.Add(Me.CBGrade2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CBGrade1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CBGrade1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CBGrade2 As ComboBox
    Friend WithEvents CBGrade3 As ComboBox
    Friend WithEvents CBGrade4 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents CBGrade5 As ComboBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents CBGrade6 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TBNote As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents SaveFeatureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripComboBox1 As ToolStripComboBox
End Class
