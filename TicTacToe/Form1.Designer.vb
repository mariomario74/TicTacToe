<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MainPanel = New Panel()
        btnPlayCPU = New Button()
        btnReset = New Button()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        PictureBox9 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        lblWhoseTurn = New Label()
        timerVerifyWin = New Timer(components)
        MainPanel.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MainPanel
        ' 
        MainPanel.AutoSize = True
        MainPanel.BackColor = SystemColors.ActiveCaptionText
        MainPanel.Controls.Add(btnPlayCPU)
        MainPanel.Controls.Add(btnReset)
        MainPanel.Controls.Add(Label5)
        MainPanel.Controls.Add(Label4)
        MainPanel.Controls.Add(Label3)
        MainPanel.Controls.Add(Label2)
        MainPanel.Controls.Add(Label1)
        MainPanel.Controls.Add(PictureBox7)
        MainPanel.Controls.Add(PictureBox8)
        MainPanel.Controls.Add(PictureBox9)
        MainPanel.Controls.Add(PictureBox4)
        MainPanel.Controls.Add(PictureBox5)
        MainPanel.Controls.Add(PictureBox6)
        MainPanel.Controls.Add(PictureBox3)
        MainPanel.Controls.Add(PictureBox2)
        MainPanel.Controls.Add(PictureBox1)
        MainPanel.Controls.Add(lblWhoseTurn)
        MainPanel.Dock = DockStyle.Fill
        MainPanel.Location = New Point(0, 0)
        MainPanel.Name = "MainPanel"
        MainPanel.Size = New Size(982, 553)
        MainPanel.TabIndex = 0
        ' 
        ' btnPlayCPU
        ' 
        btnPlayCPU.Location = New Point(3, 507)
        btnPlayCPU.Name = "btnPlayCPU"
        btnPlayCPU.Size = New Size(131, 43)
        btnPlayCPU.TabIndex = 1
        btnPlayCPU.Text = "Play against CPU"
        btnPlayCPU.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Anchor = AnchorStyles.None
        btnReset.Location = New Point(885, 521)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(94, 29)
        btnReset.TabIndex = 37
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ButtonShadow
        Label5.Location = New Point(606, 389)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 20)
        Label5.TabIndex = 36
        Label5.Text = "Label5"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ButtonShadow
        Label4.Location = New Point(110, 224)
        Label4.Name = "Label4"
        Label4.Size = New Size(116, 20)
        Label4.TabIndex = 35
        Label4.Text = "O Player SCORE:"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ButtonShadow
        Label3.Location = New Point(112, 182)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 20)
        Label3.TabIndex = 34
        Label3.Text = "X Player SCORE:"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ButtonShadow
        Label2.Location = New Point(232, 224)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 33
        Label2.Text = "Label2"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ButtonShadow
        Label1.Location = New Point(232, 182)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 32
        Label1.Text = "Label1"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Anchor = AnchorStyles.None
        PictureBox7.BackColor = SystemColors.ButtonShadow
        PictureBox7.Location = New Point(433, 278)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(125, 85)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 31
        PictureBox7.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Anchor = AnchorStyles.None
        PictureBox8.BackColor = SystemColors.ButtonShadow
        PictureBox8.Location = New Point(564, 278)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(125, 85)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 30
        PictureBox8.TabStop = False
        ' 
        ' PictureBox9
        ' 
        PictureBox9.Anchor = AnchorStyles.None
        PictureBox9.BackColor = SystemColors.ButtonShadow
        PictureBox9.Location = New Point(695, 278)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(125, 85)
        PictureBox9.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox9.TabIndex = 29
        PictureBox9.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Anchor = AnchorStyles.None
        PictureBox4.BackColor = SystemColors.ButtonShadow
        PictureBox4.Location = New Point(433, 196)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(125, 85)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 28
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Anchor = AnchorStyles.None
        PictureBox5.BackColor = SystemColors.ButtonShadow
        PictureBox5.Location = New Point(564, 195)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(125, 85)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 27
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Anchor = AnchorStyles.None
        PictureBox6.BackColor = SystemColors.ButtonShadow
        PictureBox6.Location = New Point(695, 195)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(125, 85)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 26
        PictureBox6.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.None
        PictureBox3.BackColor = SystemColors.ButtonShadow
        PictureBox3.Location = New Point(695, 113)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(125, 85)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 25
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.None
        PictureBox2.BackColor = SystemColors.ButtonShadow
        PictureBox2.Location = New Point(564, 113)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(125, 85)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 24
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.BackColor = SystemColors.ButtonShadow
        PictureBox1.Location = New Point(433, 113)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(125, 85)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 23
        PictureBox1.TabStop = False
        ' 
        ' lblWhoseTurn
        ' 
        lblWhoseTurn.AutoSize = True
        lblWhoseTurn.BackColor = SystemColors.ButtonFace
        lblWhoseTurn.Image = CType(resources.GetObject("lblWhoseTurn.Image"), Image)
        lblWhoseTurn.Location = New Point(0, 0)
        lblWhoseTurn.Name = "lblWhoseTurn"
        lblWhoseTurn.Size = New Size(0, 20)
        lblWhoseTurn.TabIndex = 22
        ' 
        ' timerVerifyWin
        ' 
        timerVerifyWin.Enabled = True
        timerVerifyWin.Interval = 5000
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(982, 553)
        Controls.Add(MainPanel)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "TicTacToe"
        MainPanel.ResumeLayout(False)
        MainPanel.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MainPanel As Panel
    Friend WithEvents lblWhoseTurn As Label
    Friend WithEvents timerVerifyWin As Timer
    Friend WithEvents btnReset As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnPlayCPU As Button

End Class
