<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBieuDoNhapXuatKho
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnInExcel = New System.Windows.Forms.Button()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(48, 59)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(1029, 488)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'btnInExcel
        '
        Me.btnInExcel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnInExcel.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInExcel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnInExcel.Image = Global.QuanLyKhoHang_BaiTapThucHanh.My.Resources.Resources.printer
        Me.btnInExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInExcel.Location = New System.Drawing.Point(487, 588)
        Me.btnInExcel.Name = "btnInExcel"
        Me.btnInExcel.Size = New System.Drawing.Size(182, 56)
        Me.btnInExcel.TabIndex = 1
        Me.btnInExcel.Text = "In Excel"
        Me.btnInExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnInExcel.UseVisualStyleBackColor = False
        '
        'FormBieuDoNhapXuatKho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.QuanLyKhoHang_BaiTapThucHanh.My.Resources.Resources.NenBieuDo
        Me.ClientSize = New System.Drawing.Size(1120, 674)
        Me.Controls.Add(Me.btnInExcel)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "FormBieuDoNhapXuatKho"
        Me.Text = "FormBieuDoNhapXuatKho"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents btnInExcel As Button
End Class
