Public Class frm_alb_cosul 

    Private Sub FillToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles FillToolStripButton.Click
        Try
            Me.RQSP_CONSULTA_ALBTableAdapter.Fill(Me.STORED_ALB.RQSP_CONSULTA_ALB, TiendaToolStripTextBox.Text, DesdeToolStripTextBox.Text, HastaToolStripTextBox.Text)
            grid.DataSource = Me.RQSP_CONSULTA_ALBTableAdapter.Fill(Me.STORED_ALB.RQSP_CONSULTA_ALB, TiendaToolStripTextBox.Text, DesdeToolStripTextBox.Text, HastaToolStripTextBox.Text)
            grid.Refresh()

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class