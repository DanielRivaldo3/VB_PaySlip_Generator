Public Class Form1
    Dim a As Long

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PayslipDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.PayslipDataSet.Table1)

        Dim dt As String = String.Empty
        dt = dt & Format(Now, "d")
        lbl_tanggal.Text = dt




    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        Table1BindingSource.AddNew()

        Dim dt As String = String.Empty
        dt = dt & Format(Now, "d")
        lbl_tanggal.Text = dt
    End Sub

    Private Sub btn_input_Click(sender As Object, e As EventArgs) Handles btn_input.Click
        Table1BindingSource.EndEdit()
        Table1TableAdapter.Update(PayslipDataSet.Table1)
        MessageBox.Show("Successfully Update")
    End Sub

    Private Sub btn_hitung_Click(sender As Object, e As EventArgs) Handles btn_hitung.Click
        txt_totalgaji.Text = Val(txt_gajipokok.Text) + Val(txt_bonus.Text) - Val(txt_pajak.Text)
        txt_totalgaji.Text = FormatCurrency(txt_totalgaji.Text)

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.PayslipDataSet)
        MessageBox.Show("Successfully Saved")
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        txt_print.Text = ""
        txt_print.AppendText("" + vbNewLine)
        txt_print.AppendText("" + vbNewLine)
        txt_print.AppendText("" + vbNewLine)
        txt_print.AppendText("" + vbNewLine)
        txt_print.AppendText("" + vbNewLine)
        txt_print.AppendText("" + vbNewLine)
        txt_print.AppendText("" + vbNewLine)

        txt_print.AppendText("=====================================================================================" + vbNewLine)
        txt_print.AppendText("" + vbNewLine)
        txt_print.AppendText(vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + "PAY SLIP" + vbNewLine)
        txt_print.AppendText("" + vbNewLine)
        txt_print.AppendText("" + vbNewLine)
        txt_print.AppendText("=====================================================================================" + vbNewLine)
        txt_print.AppendText("" + vbNewLine)
        txt_print.AppendText("" + vbNewLine)
        txt_print.AppendText("ID Karyawan   " + vbTab + " : " + txt_id.Text + vbTab + vbTab + vbNewLine)
        txt_print.AppendText("Nama Karyawan " + vbTab + " : " + txt_nama.Text + vbTab + vbTab + vbNewLine)
        txt_print.AppendText("" + vbNewLine)
        txt_print.AppendText("=====================================================================================" + vbNewLine)
        txt_print.AppendText("" + vbNewLine)
        txt_print.AppendText("Gaji Pokok    " + vbTab + " : " + txt_gajipokok.Text + vbNewLine)
        txt_print.AppendText("Bonus         " + vbTab + " : " + txt_bonus.Text + vbNewLine)
        txt_print.AppendText("Pajak         " + vbTab + " : " + txt_pajak.Text + vbNewLine)
        txt_print.AppendText("" + vbNewLine)
        txt_print.AppendText("" + vbNewLine)
        txt_print.AppendText("=====================================================================================" + vbNewLine)
        txt_print.AppendText("" + vbNewLine)
        txt_print.AppendText("GAJI TOTAL    " + vbTab + " : " + txt_totalgaji.Text + vbNewLine)
        txt_print.AppendText("" + vbNewLine)
        txt_print.AppendText("DITERIMA OLEH : ___________________________________" + vbNewLine)
        txt_print.AppendText("" + vbNewLine)
        txt_print.AppendText("" + vbNewLine)
        txt_print.AppendText("" + vbNewLine)
        txt_print.AppendText("=====================================================================================" + vbNewLine)

        txt_print.AppendText("" + vbNewLine)
        txt_print.AppendText("" + vbNewLine)

        txt_print.AppendText(vbTab + vbTab + vbTab + vbTab + vbTab + "     Signature,   " + vbNewLine)
        txt_print.AppendText("" + vbNewLine)
        txt_print.AppendText("" + vbNewLine)
        txt_print.AppendText(vbTab + vbTab + vbTab + vbTab + vbTab + "__________________" + vbNewLine)
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(txt_print.Text, Font, Brushes.Black, 140, 140)
        e.Graphics.DrawImage(Me.PictureBox1.Image, 120, 130, PictureBox1.Width - 15, PictureBox1.Height - 25)
    End Sub

    Private Sub btn_new_print_Click(sender As Object, e As EventArgs) Handles btn_new_print.Click
        txt_print.Clear()

    End Sub

End Class
