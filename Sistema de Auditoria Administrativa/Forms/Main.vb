Public Class Main 

    Private Sub RibbonControl_Click(sender As System.Object, e As System.EventArgs) Handles RibbonControl.Click

    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick

        Dim frm2 As New frm_alb_cosul
        frm2.MdiParent = Me
        ' Para mostrarlo maximizado al crear la ventana
        frm2.WindowState = FormWindowState.Maximized
        frm2.Show()

    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        'Dim frm2 As New prueba
        'frm2.MdiParent = Me
        '' Para mostrarlo maximizado al crear la ventana
        'frm2.WindowState = FormWindowState.Maximized
        'frm2.Show()
    End Sub
End Class