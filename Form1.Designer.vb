<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.start = New System.Windows.Forms.Label()
        Me.introduce = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'start
        '
        Me.start.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.start.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.start.Location = New System.Drawing.Point(223, 188)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(120, 36)
        Me.start.TabIndex = 0
        Me.start.Text = "开 始"
        Me.start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'introduce
        '
        Me.introduce.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.introduce.Font = New System.Drawing.Font("微软雅黑", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.introduce.Location = New System.Drawing.Point(223, 278)
        Me.introduce.Name = "introduce"
        Me.introduce.Size = New System.Drawing.Size(120, 36)
        Me.introduce.TabIndex = 1
        Me.introduce.Text = "说 明"
        Me.introduce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("宋体", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 150)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "2048"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(582, 553)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.introduce)
        Me.Controls.Add(Me.start)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(600, 600)
        Me.MinimumSize = New System.Drawing.Size(600, 600)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "2048游戏"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents start As Label
    Friend WithEvents introduce As Label
    Friend WithEvents Label1 As Label
End Class
