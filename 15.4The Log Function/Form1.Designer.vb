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
		BtnComp = New Button()
		Label1 = New Label()
		Label2 = New Label()
		TextBox1 = New TextBox()
		TextBox2 = New TextBox()
		Label3 = New Label()
		SuspendLayout()
		' 
		' BtnComp
		' 
		BtnComp.Font = New Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point)
		BtnComp.Location = New Point(278, 265)
		BtnComp.Name = "BtnComp"
		BtnComp.Size = New Size(112, 34)
		BtnComp.TabIndex = 0
		BtnComp.Text = "Compute"
		BtnComp.UseVisualStyleBackColor = True
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Location = New Point(200, 115)
		Label1.Name = "Label1"
		Label1.Size = New Size(77, 25)
		Label1.TabIndex = 1
		Label1.Text = "Number"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Location = New Point(200, 171)
		Label2.Name = "Label2"
		Label2.Size = New Size(117, 25)
		Label2.TabIndex = 1
		Label2.Text = "Log(Number)"
		' 
		' TextBox1
		' 
		TextBox1.Location = New Point(361, 109)
		TextBox1.Name = "TextBox1"
		TextBox1.Size = New Size(150, 31)
		TextBox1.TabIndex = 2
		' 
		' TextBox2
		' 
		TextBox2.Location = New Point(361, 171)
		TextBox2.Name = "TextBox2"
		TextBox2.Size = New Size(150, 31)
		TextBox2.TabIndex = 2
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Font = New Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point)
		Label3.Location = New Point(278, 42)
		Label3.Name = "Label3"
		Label3.Size = New Size(292, 30)
		Label3.TabIndex = 3
		Label3.Text = "Logarithm Function"
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(10F, 25F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = SystemColors.ActiveCaption
		ClientSize = New Size(800, 450)
		Controls.Add(Label3)
		Controls.Add(TextBox2)
		Controls.Add(TextBox1)
		Controls.Add(Label2)
		Controls.Add(Label1)
		Controls.Add(BtnComp)
		Name = "Form1"
		Text = "Form1"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents BtnComp As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents Label3 As Label
End Class
