<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PayslipDataSet = New PaySlip.payslipDataSet()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.txt_gajipokok = New System.Windows.Forms.TextBox()
        Me.txt_bonus = New System.Windows.Forms.TextBox()
        Me.txt_totalgaji = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_hitung = New System.Windows.Forms.Button()
        Me.btn_input = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GajiPokokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BonusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PajakDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanggalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_new_print = New System.Windows.Forms.Button()
        Me.txt_print = New System.Windows.Forms.TextBox()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.lbl_tanggal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Table1TableAdapter = New PaySlip.payslipDataSetTableAdapters.Table1TableAdapter()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_pajak = New System.Windows.Forms.TextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.TableAdapterManager1 = New PaySlip.payslipDataSetTableAdapters.TableAdapterManager()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayslipDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(253, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Gaji Pokok"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(253, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Bonus"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(253, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total Gaji"
        '
        'txt_id
        '
        Me.txt_id.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "ID", True))
        Me.txt_id.Location = New System.Drawing.Point(119, 143)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(101, 20)
        Me.txt_id.TabIndex = 5
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.PayslipDataSet
        '
        'PayslipDataSet
        '
        Me.PayslipDataSet.DataSetName = "payslipDataSet"
        Me.PayslipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_nama
        '
        Me.txt_nama.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Name", True))
        Me.txt_nama.Location = New System.Drawing.Point(119, 173)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(101, 20)
        Me.txt_nama.TabIndex = 6
        '
        'txt_gajipokok
        '
        Me.txt_gajipokok.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "GajiPokok", True))
        Me.txt_gajipokok.Location = New System.Drawing.Point(385, 140)
        Me.txt_gajipokok.Name = "txt_gajipokok"
        Me.txt_gajipokok.Size = New System.Drawing.Size(199, 20)
        Me.txt_gajipokok.TabIndex = 7
        '
        'txt_bonus
        '
        Me.txt_bonus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Bonus", True))
        Me.txt_bonus.Location = New System.Drawing.Point(385, 172)
        Me.txt_bonus.Name = "txt_bonus"
        Me.txt_bonus.Size = New System.Drawing.Size(199, 20)
        Me.txt_bonus.TabIndex = 8
        '
        'txt_totalgaji
        '
        Me.txt_totalgaji.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Total", True))
        Me.txt_totalgaji.Location = New System.Drawing.Point(385, 235)
        Me.txt_totalgaji.Name = "txt_totalgaji"
        Me.txt_totalgaji.ReadOnly = True
        Me.txt_totalgaji.Size = New System.Drawing.Size(199, 20)
        Me.txt_totalgaji.TabIndex = 9
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(20, 275)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(569, 236)
        Me.TabControl1.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btn_save)
        Me.TabPage1.Controls.Add(Me.btn_hitung)
        Me.TabPage1.Controls.Add(Me.btn_input)
        Me.TabPage1.Controls.Add(Me.btn_new)
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(561, 210)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Database"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(295, 171)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(80, 32)
        Me.btn_save.TabIndex = 4
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_hitung
        '
        Me.btn_hitung.Location = New System.Drawing.Point(197, 172)
        Me.btn_hitung.Name = "btn_hitung"
        Me.btn_hitung.Size = New System.Drawing.Size(80, 32)
        Me.btn_hitung.TabIndex = 3
        Me.btn_hitung.Text = "Hitung"
        Me.btn_hitung.UseVisualStyleBackColor = True
        '
        'btn_input
        '
        Me.btn_input.Location = New System.Drawing.Point(100, 172)
        Me.btn_input.Name = "btn_input"
        Me.btn_input.Size = New System.Drawing.Size(80, 32)
        Me.btn_input.TabIndex = 2
        Me.btn_input.Text = "Input"
        Me.btn_input.UseVisualStyleBackColor = True
        '
        'btn_new
        '
        Me.btn_new.Location = New System.Drawing.Point(7, 172)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(80, 32)
        Me.btn_new.TabIndex = 1
        Me.btn_new.Text = "New"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.GajiPokokDataGridViewTextBoxColumn, Me.BonusDataGridViewTextBoxColumn, Me.PajakDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn, Me.TanggalDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Table1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(7, 7)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(548, 158)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'GajiPokokDataGridViewTextBoxColumn
        '
        Me.GajiPokokDataGridViewTextBoxColumn.DataPropertyName = "GajiPokok"
        Me.GajiPokokDataGridViewTextBoxColumn.HeaderText = "GajiPokok"
        Me.GajiPokokDataGridViewTextBoxColumn.Name = "GajiPokokDataGridViewTextBoxColumn"
        '
        'BonusDataGridViewTextBoxColumn
        '
        Me.BonusDataGridViewTextBoxColumn.DataPropertyName = "Bonus"
        Me.BonusDataGridViewTextBoxColumn.HeaderText = "Bonus"
        Me.BonusDataGridViewTextBoxColumn.Name = "BonusDataGridViewTextBoxColumn"
        '
        'PajakDataGridViewTextBoxColumn
        '
        Me.PajakDataGridViewTextBoxColumn.DataPropertyName = "Pajak"
        Me.PajakDataGridViewTextBoxColumn.HeaderText = "Pajak"
        Me.PajakDataGridViewTextBoxColumn.Name = "PajakDataGridViewTextBoxColumn"
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        '
        'TanggalDataGridViewTextBoxColumn
        '
        Me.TanggalDataGridViewTextBoxColumn.DataPropertyName = "Tanggal"
        Me.TanggalDataGridViewTextBoxColumn.HeaderText = "Tanggal"
        Me.TanggalDataGridViewTextBoxColumn.Name = "TanggalDataGridViewTextBoxColumn"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btn_new_print)
        Me.TabPage2.Controls.Add(Me.txt_print)
        Me.TabPage2.Controls.Add(Me.btn_print)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(561, 210)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Print Preview"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btn_new_print
        '
        Me.btn_new_print.Location = New System.Drawing.Point(268, 179)
        Me.btn_new_print.Name = "btn_new_print"
        Me.btn_new_print.Size = New System.Drawing.Size(80, 25)
        Me.btn_new_print.TabIndex = 6
        Me.btn_new_print.Text = "New"
        Me.btn_new_print.UseVisualStyleBackColor = True
        '
        'txt_print
        '
        Me.txt_print.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_print.Location = New System.Drawing.Point(7, 7)
        Me.txt_print.Multiline = True
        Me.txt_print.Name = "txt_print"
        Me.txt_print.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_print.Size = New System.Drawing.Size(548, 166)
        Me.txt_print.TabIndex = 5
        '
        'btn_print
        '
        Me.btn_print.Location = New System.Drawing.Point(177, 179)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(80, 25)
        Me.btn_print.TabIndex = 4
        Me.btn_print.Text = "Print"
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'lbl_tanggal
        '
        Me.lbl_tanggal.AutoSize = True
        Me.lbl_tanggal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Tanggal", True))
        Me.lbl_tanggal.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tanggal.Location = New System.Drawing.Point(116, 207)
        Me.lbl_tanggal.Name = "lbl_tanggal"
        Me.lbl_tanggal.Size = New System.Drawing.Size(68, 18)
        Me.lbl_tanggal.TabIndex = 11
        Me.lbl_tanggal.Text = "tanggal"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 207)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 18)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Tanggal"
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(253, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 18)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Pajak"
        '
        'txt_pajak
        '
        Me.txt_pajak.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Pajak", True))
        Me.txt_pajak.Location = New System.Drawing.Point(386, 205)
        Me.txt_pajak.Name = "txt_pajak"
        Me.txt_pajak.Size = New System.Drawing.Size(199, 20)
        Me.txt_pajak.TabIndex = 14
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Table1TableAdapter = Me.Table1TableAdapter
        Me.TableAdapterManager1.UpdateOrder = PaySlip.payslipDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(234, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(138, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 523)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt_pajak)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_tanggal)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.txt_totalgaji)
        Me.Controls.Add(Me.txt_bonus)
        Me.Controls.Add(Me.txt_gajipokok)
        Me.Controls.Add(Me.txt_nama)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pay Slip Generator"
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayslipDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents txt_nama As System.Windows.Forms.TextBox
    Friend WithEvents txt_gajipokok As System.Windows.Forms.TextBox
    Friend WithEvents txt_bonus As System.Windows.Forms.TextBox
    Friend WithEvents txt_totalgaji As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lbl_tanggal As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_hitung As System.Windows.Forms.Button
    Friend WithEvents btn_input As System.Windows.Forms.Button
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents btn_print As System.Windows.Forms.Button
    Friend WithEvents PayslipDataSet As PaySlip.payslipDataSet
    Friend WithEvents Table1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table1TableAdapter As PaySlip.payslipDataSetTableAdapters.Table1TableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GajiPokokDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BonusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PajakDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TanggalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_pajak As System.Windows.Forms.TextBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents txt_print As System.Windows.Forms.TextBox
    Friend WithEvents TableAdapterManager1 As PaySlip.payslipDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_new_print As System.Windows.Forms.Button

End Class
