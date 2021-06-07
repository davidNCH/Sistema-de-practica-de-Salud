Public Class formularioinicio
    Private Sub PERSONALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PERSONALToolStripMenuItem.Click
        personal.Show()
    End Sub

    Private Sub REGISTROLIBROSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REGISTROLIBROSToolStripMenuItem.Click
        libros.Show()
    End Sub

    Private Sub REGISTROLECTORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REGISTROLECTORToolStripMenuItem.Click
        lector.Show()
    End Sub

    Private Sub PRESTAMOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRESTAMOToolStripMenuItem.Click
        prestamo.Show()
    End Sub

    Private Sub LECTORESMOROSOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LECTORESMOROSOSToolStripMenuItem.Click
        personamora.Show()
        '  Me.Hide()
    End Sub

    Private Sub LIBROSDISPONIBÑESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIBROSDISPONIBÑESToolStripMenuItem.Click
        libro_disponible.Show()
        ' Me.Hide()
    End Sub

    Private Sub LIBROSDONADOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIBROSDONADOSToolStripMenuItem.Click
        libro_donado.Show()
        ' Me.Hide()
    End Sub

    Private Sub CANTIDADDELIBROSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CANTIDADDELIBROSToolStripMenuItem.Click
        cantidadlibros.Show()
    End Sub

    Private Sub PERSONALACTIVOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PERSONALACTIVOToolStripMenuItem.Click
        personalactivo.Show()
    End Sub

    Private Sub CANTIDADDEPRESTAMOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CANTIDADDEPRESTAMOSToolStripMenuItem.Click
        cantidadprestamo.Show()
    End Sub
End Class
